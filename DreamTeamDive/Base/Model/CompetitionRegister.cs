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
        main_auth_form mainForm = new main_auth_form();
        diver_form diver = new diver_form();
        void ICompetition.Login(string authCode, Diver diver, diver_form DivForm)
        {
            string sqlAuthCheck;
            if (mainForm.DiverButton.Enabled == true)
            {
                sqlAuthCheck = "SELECT * FROM Divers WHERE auth_code = " + authCode;
            }
            else
            {
                sqlAuthCheck = "SELECT * FROM Judges WHERE auth_code = " + authCode;
            }

            try
            {
                //Connect to Database
                Mysql_db.connect();
                // Check authentication code
                MySqlCommand command = Mysql_db.execute(sqlAuthCheck);
             
                //While not 0
                if(Convert.ToInt32(command.ExecuteScalar()) != 0)
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        //While reading in DB
                        while (reader.Read())
                        {
                            //Fetch data from database and create new diver
                            

                            diver.id = Convert.ToInt32(reader["id"]);
                            diver.name = reader["name"].ToString();
                            diver.country = reader["country"].ToString();
                            diver.competition = Convert.ToInt32(reader["in_competition"]);
                        }
                    }
                    //If validation open driver form
                    DivForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Not a valid Code!", "Error");

                }
               
            }
            catch
            {
                // Logg error
            }

        }

        void ICompetition.Exit()
        {
            if (mainForm.ExitButton.Enabled == true)
            {
                //Exit application
                Application.Exit();
            }
        }

        void ICompetition.Jump(Diver diver, diver_form DivForm)
        {
            if(DivForm.JumpButton.Enabled)
            {
                //Perform Jump
                diver.jump();
            }
        }
    }
}
