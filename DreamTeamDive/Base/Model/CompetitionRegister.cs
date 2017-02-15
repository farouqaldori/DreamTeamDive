using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diver_Contest
{
    public class CompetitionRegister : ICompetition
    {
        void ICompetition.StartConnection()
        {
            Mysql_db.connect();
        }

        /* Skapa ny funktion JudgeLogin. */
        

        /// <summary>
        /// Authorize a diver via the MySql database.
        /// </summary>
        /// <param name="_authcode">The authentication code to verify the user.</param>
        /// <returns>A diver object with the information about the diver.</returns>
        Diver ICompetition.DiverLogin(string _authcode)
        {
            // Construct MySql code to be executed.
            MySqlCommand command = new MySqlCommand("SELECT * FROM Divers WHERE auth_code = @authCode", Mysql_db.connection);
            // Check if the Authentication code is valid using the parameter authCode
            command.Parameters.AddWithValue("@authCode", _authcode);

            // If the command does not return a value, throw exception
            if (Convert.ToInt32(command.ExecuteScalar()) == 0)
            {
                throw new System.ArgumentException("Invalid_auth");
            } else
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Create a new diver
                    Diver diver = new Diver();
                    // While it's not end of line
                    while (reader.Read())
                    {
                        diver.id = Convert.ToInt32(reader["id"]);
                        diver.name = reader["name"].ToString();
                        diver.country = reader["country"].ToString();
                        diver.competition = Convert.ToInt32(reader["in_competition"]);
                    }
                    reader.Close();
                    return diver;
                }
            }
        }

        void ICompetition.Exit()
        {
            Application.Exit();
        }

        void ICompetition.Jump(Diver _diver)
        {
            int jumpId = 0;
            _diver.jump();
         
            // Get Id of jump
            MySqlCommand command = new MySqlCommand("SELECT * FROM Jumps WHERE jumper = @diverId LIMIT @jumpIndex,1", Mysql_db.connection);
            command.Parameters.AddWithValue("@diverId", _diver.id);
            command.Parameters.AddWithValue("@jumpIndex", _diver.jumpIndex);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    jumpId = Convert.ToInt32(reader["id"]);
                }
                reader.Close();
            }
            
            // Update jump in database
            MySqlCommand command2 = new MySqlCommand("UPDATE `Jumps` SET `status`= @jumpStatus, `difficulty`= @jumpDifficulty, `style`= @jumpStyle, `form`= @jumpForm, `takeOff`= @jumpTakeoff,`Takeoff`= @jumpFinishing WHERE `id` = @jumpId", Mysql_db.connection);
            command2.Parameters.AddWithValue("@jumpStatus", 1);
            command2.Parameters.AddWithValue("@jumpDifficulty", _diver.jumps[_diver.jumpIndex].difficulty);
            command2.Parameters.AddWithValue("@jumpStyle", _diver.jumps[_diver.jumpIndex].style);
            command2.Parameters.AddWithValue("@jumpForm", _diver.jumps[_diver.jumpIndex].form);
            command2.Parameters.AddWithValue("@jumpTakeoff", _diver.jumps[_diver.jumpIndex].takeOff);
            command2.Parameters.AddWithValue("@jumpFinishing", _diver.jumps[_diver.jumpIndex].flight);
            command2.Parameters.AddWithValue("@jumpId", jumpId);

            command2.ExecuteNonQuery();

            _diver.jumpIndex++;
        }

        //Judge ICompetition.SendRating()
        //{

        //}

        List<Jump> ICompetition.UpdateJumps(int diver_id)
        {
            // Construct MySql code to be executed.
            MySqlCommand command = new MySqlCommand("SELECT * FROM Jumps WHERE jumper = @diverId", Mysql_db.connection2);
            command.Parameters.AddWithValue("@diverId", diver_id);

            // Create new jump lists.
            List<Jump> newJumps = new List<Jump>();

            using (MySqlDataReader bgreader = command.ExecuteReader())
            {
                while (bgreader.Read())
                {
                    
                    Jump newJump = new Jump();
                    newJump.id = Convert.ToInt32(bgreader["id"]);
                    newJump.difficulty = Convert.ToInt32(bgreader["difficulty"]);
                    newJump.status = Convert.ToInt32(bgreader["status"]);
                    newJump.style = Convert.ToInt32(bgreader["style"]);
                    newJump.form = Convert.ToDouble(bgreader["form"]);
                    newJump.takeOff = Convert.ToDouble(bgreader["takeOff"]);
                    newJump.flight = Convert.ToDouble(bgreader["flight"]);

                    // Add the new Jump to the Jump list
                    newJumps.Add(newJump);
                }
                bgreader.Close();
                return newJumps;
            }

        }

        void ICompetition.SendRating(Judge _judge)
        {
            // Get judgeID.
            // Fetch jump to rate.
            // Rate and update DB
        }
        
    }
}
