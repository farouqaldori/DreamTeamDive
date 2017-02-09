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

        Diver ICompetition.Login(string _authcode)
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
                    return diver;
                }
            }

        }

        void ICompetition.Exit()
        {

        }

        void ICompetition.Jump()
        {

        }

        //Judge ICompetition.SendRating()
        //{

        //}

        List<Jump> ICompetition.UpdateJumps(int diver_id)
        {
            // Construct MySql code to be executed.
            MySqlCommand command = new MySqlCommand("SELECT * FROM Jumps WHERE jumper = @diverId", Mysql_db.connection);
            command.Parameters.AddWithValue("@diverId", diver_id);

            // Create new jump lists.
            List<Jump> newJumps = new List<Jump>();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    Jump newJump = new Jump();
                    newJump.id = Convert.ToInt32(reader["id"]);
                    newJump.difficulty = Convert.ToInt32(reader["difficulty"]);
                    newJump.status = Convert.ToInt32(reader["status"]);
                    newJump.style = Convert.ToInt32(reader["style"]);
                    newJump.form = Convert.ToDouble(reader["form"]);
                    newJump.takeOff = Convert.ToDouble(reader["takeOff"]);
                    newJump.finishing = Convert.ToDouble(reader["finishing"]);

                    // Add the new Jump to the Jump list
                    newJumps.Add(newJump);
                }
                return newJumps;
            }

        }
        
    }
}
