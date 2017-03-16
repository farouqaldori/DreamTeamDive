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

        /// <summary>
        /// Check if the competition is over
        /// </summary>
        /// <returns>True if over.</returns>
        bool ICompetition.CheckCompetitionDone(Diver _diver)
        {
            // Check how many judges in competition
            MySqlCommand countJumpers = new MySqlCommand("SELECT * FROM Divers WHERE status = 0 AND in_competition = @compId ", Mysql_db.connection3);
            countJumpers.Parameters.AddWithValue("@compId", _diver.competition);
            if (Convert.ToInt32(countJumpers.ExecuteScalar()) == 0)
            {
                return true;
            }
            return false;
        }

        Judge ICompetition.JudgeLogin(string _authcode)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Judge WHERE auth_code = @authCode", Mysql_db.connection);

            command.Parameters.AddWithValue("@authCode", _authcode);

            if (Convert.ToInt32(command.ExecuteScalar()) == 0)
            {
                throw new System.ArgumentException("Invalid_auth");
            }
            else
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Judge judge = new Judge();
                    while (reader.Read())
                    {
                        judge.id = Convert.ToInt32(reader["id"]);
                        judge.name = reader["name"].ToString();
                        judge.competition = Convert.ToInt32(reader["in_competition"]);
                    }
                    reader.Close();
                    return judge;
                }
            }


        }

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

        List<Diver> ICompetition.GetRatingDivers()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Divers", Mysql_db.connection2);
            // Create new jump lists.
            List<Diver> diverStandings = new List<Diver>();

            using (MySqlDataReader bgreader = command.ExecuteReader())
            {
                while (bgreader.Read())
                {
                    Diver diverStanding = new Diver();
                    diverStanding.name = bgreader["name"].ToString();
                    diverStanding.country = bgreader["country"].ToString();
                    diverStanding.gender = Convert.ToString(bgreader["gender"]);


                    diverStandings.Add(diverStanding);
                }
                bgreader.Close();
                return diverStandings;
            }
        }

        List<Diver> ICompetition.GetEndResultDivers()
        {
            MySqlCommand command2 = new MySqlCommand("select D.name, MAX(G.grade) as maxgrade, MIN(G.grade) as mingrade, SUM(G.grade) as sum_grade, J.difficulty from Divers D inner join Jumps J on D.id = J.jumper inner join Grade G on J.id = G.jump_id GROUP BY J.jumper ORDER BY sum_grade DESC", Mysql_db.connection2);
            

            List<Diver> endResults = new List<Diver>();
            using (MySqlDataReader bgreader = command2.ExecuteReader())
            {
                while (bgreader.Read())
                {
                    Diver endResult = new Diver();
                    endResult.name = bgreader["name"].ToString();
                 
                    endResult.sumGrades = (Convert.ToInt32(bgreader["sum_grade"]) - Convert.ToInt32(bgreader["maxgrade"]) - Convert.ToInt32(bgreader["mingrade"]));

                    endResults.Add(endResult);
                }
                bgreader.Close();
                return endResults;
            }
        }

        void ICompetition.Exit()
        {
            Application.Exit();
        }

        Dictionary<int, string> ICompetition.GetJumpTypes()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();

            MySqlCommand command = new MySqlCommand("SELECT * FROM JumpTypes", Mysql_db.connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboSource.Add(Convert.ToInt32(reader["id"]), reader["name"].ToString());
                }
                reader.Close();
            }

            return comboSource;
        }

        void ICompetition.Jump(Diver _diver, int _jumpStyle, int _difficulty)
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
            MySqlCommand command2 = new MySqlCommand("UPDATE `Jumps` SET `status`= @jumpStatus , `difficulty`= @jumpDifficulty , `style`= @jumpStyle , `form`= @jumpForm , `starting`= @jumpStarting , `approach` = @jumpApproach , `takeOff`= @jumpTakeoff , `flight`= @jumpFlight , `entry`= @jumpEntry WHERE `id` = @jumpId", Mysql_db.connection);

            command2.Parameters.AddWithValue("@jumpStatus", 1);
            command2.Parameters.AddWithValue("@jumpDifficulty", _difficulty);
            command2.Parameters.AddWithValue("@jumpStyle", _jumpStyle);
            command2.Parameters.AddWithValue("@jumpForm", _diver.jumps[_diver.jumpIndex].form);
            command2.Parameters.AddWithValue("@jumpStarting", _diver.jumps[_diver.jumpIndex].starting);
            command2.Parameters.AddWithValue("@jumpApproach", _diver.jumps[_diver.jumpIndex].approach);
            command2.Parameters.AddWithValue("@jumpTakeoff", _diver.jumps[_diver.jumpIndex].takeOff);
            command2.Parameters.AddWithValue("@jumpFlight", _diver.jumps[_diver.jumpIndex].flight);
            command2.Parameters.AddWithValue("@jumpEntry", _diver.jumps[_diver.jumpIndex].entry);
            command2.Parameters.AddWithValue("@jumpId", jumpId);

            command2.ExecuteNonQuery();

            _diver.jumpIndex++;
        }

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
                    newJump.starting = Convert.ToDouble(bgreader["starting"]);
                    newJump.approach = Convert.ToDouble(bgreader["approach"]);
                    newJump.takeOff = Convert.ToDouble(bgreader["takeOff"]);
                    newJump.flight = Convert.ToDouble(bgreader["flight"]);
                    newJump.entry = Convert.ToDouble(bgreader["entry"]);
                   
                    // Add the new Jump to the Jump list
                    newJumps.Add(newJump);
                }
                bgreader.Close();
                return newJumps;
            }

        }

        /// <summary>
        /// Get the first ungraded jump from competition.
        /// </summary>
        /// <param name="_compId">Competition id</param>
        /// <returns>Jump object of the current jump to grade.</returns>
        Tuple<Jump, Diver> ICompetition.GetJumps(int _compId, int _thisJudgeId)
        {
            // Get user id to retrieve jumps.
            int userId = 0;
            MySqlCommand command = new MySqlCommand("SELECT * FROM Divers WHERE `in_competition` = @compId AND `status` = 0 LIMIT 0,1", Mysql_db.connection2);
            command.Parameters.AddWithValue("@compId", _compId);

            // If the command does not return a value, throw exception
            if (Convert.ToInt32(command.ExecuteScalar()) == 0)
            {
                throw new System.ArgumentException("No users to judge");
            }

            Diver newDiver = new Diver();
            using (MySqlDataReader bgreader = command.ExecuteReader())
            {
                while (bgreader.Read())
                {
                    newDiver.id = Convert.ToInt32(bgreader["id"]);
                    userId = newDiver.id;
                    newDiver.name = bgreader["name"].ToString();
                    newDiver.country = bgreader["country"].ToString();
                    newDiver.gender = bgreader["gender"].ToString();
                }
                bgreader.Close();
            }
            
            // Get first ungraded jump for user
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM Jumps WHERE `jumper` = @jumperId AND `status` = 1 AND id NOT IN (SELECT `jump_id` FROM Grade WHERE `judge_id` = @judgeId) LIMIT 0,1", Mysql_db.connection2);
            command2.Parameters.AddWithValue("@jumperId", userId);
            command2.Parameters.AddWithValue("@judgeId", _thisJudgeId);

            // If the command does not return a value, throw exception
            if (Convert.ToInt32(command2.ExecuteScalar()) == 0)
            {
                throw new System.ArgumentException("No jumps to judge");
            }
            
            Jump newJump = new Jump();

            using (MySqlDataReader bgreader = command2.ExecuteReader())
            {
                while (bgreader.Read())
                {
                    newJump.id = Convert.ToInt32(bgreader["id"]);
                    newJump.difficulty = Convert.ToInt32(bgreader["difficulty"]);
                    newJump.status = Convert.ToInt32(bgreader["status"]);
                    newJump.style = Convert.ToInt32(bgreader["style"]);
                    newJump.form = Convert.ToDouble(bgreader["form"]);
                    newJump.starting = Convert.ToDouble(bgreader["starting"]);
                    newJump.approach = Convert.ToDouble(bgreader["approach"]);
                    newJump.takeOff = Convert.ToDouble(bgreader["takeOff"]);
                    newJump.flight = Convert.ToDouble(bgreader["flight"]);
                    newJump.entry = Convert.ToDouble(bgreader["entry"]);
                }
                bgreader.Close();
            }
            // Return current jump and diver object.
            return Tuple.Create(newJump, newDiver);

        }

        void ICompetition.SendRating(Judge _judge, int _jumpId, string _grade)
        {
            if (_jumpId != 0)
            {
                int judgeAmount = 0;
                MySqlCommand command = new MySqlCommand("INSERT INTO `Grade`(`judge_id`, `jump_id`, `grade`) VALUES (@judgeid , @jumpId , @grade)", Mysql_db.connection);
                command.Parameters.AddWithValue("@judgeid", _judge.id);
                command.Parameters.AddWithValue("@jumpId", _jumpId);

                command.Parameters.AddWithValue("@grade", _grade);
                command.ExecuteNonQuery();

                // Check how many judges in competition
                MySqlCommand countJugdesCommand = new MySqlCommand("SELECT count(id) as judge_count FROM Judge WHERE in_competition = @compId ", Mysql_db.connection);
                countJugdesCommand.Parameters.AddWithValue("@compId", _judge.competition);
                countJugdesCommand.ExecuteNonQuery();

                // Get value
                using (MySqlDataReader bgreader = countJugdesCommand.ExecuteReader())
                {
                    while (bgreader.Read())
                    {
                        judgeAmount = Convert.ToInt32(bgreader["judge_count"]);
                    }
                    bgreader.Close();
                }

                // This part of code is to check if all judges have graded the jump.
                int amountGraded = 0;
                MySqlCommand command3 = new MySqlCommand("SELECT count(id) as count FROM `Grade` WHERE `jump_id` = @jumpId", Mysql_db.connection);
                command3.Parameters.AddWithValue("@jumpId", _jumpId);
                command3.ExecuteNonQuery();
                // Get value
                using (MySqlDataReader bgreader = command3.ExecuteReader())
                {
                    while (bgreader.Read())
                    {
                        amountGraded = Convert.ToInt32(bgreader["count"]);
                    }
                    bgreader.Close();
                }

                if (judgeAmount == 5)
                {
                    if (amountGraded == 5)
                    {
                        MySqlCommand command2 = new MySqlCommand("UPDATE `Jumps` SET `status` = @status WHERE `id` = @jumpId", Mysql_db.connection);
                        command2.Parameters.AddWithValue("@status", 2);
                        command2.Parameters.AddWithValue("@jumpId", _jumpId);
                        command2.ExecuteNonQuery();
                    }
                }
                else if (judgeAmount == 7)
                {
                    if (amountGraded == 7)
                    {
                        MySqlCommand command2 = new MySqlCommand("UPDATE `Jumps` SET `status` = @status WHERE `id` = @jumpId", Mysql_db.connection);
                        command2.Parameters.AddWithValue("@status", 2);
                        command2.Parameters.AddWithValue("@jumpId", _jumpId);
                        command2.ExecuteNonQuery();
                    }
                }
            }
        }
        
    }
}
