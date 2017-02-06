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
        
        diver_form diver = new diver_form();
        void ICompetition.Login()
        {
            string authCode = authBOX.Text;
            string sqlAuthCheck;

            if (mainForm.DiverRadioButton.Checked == true)
            {
               sqlAuthCheck = "SELECT * FROM Divers WHERE auth_code = " + authCode;
            }
            else
            {
                sqlAuthCheck = "SELECT * FROM Judges WHERE auth_code = " + authCode;
            }

            try
            {
                MySqlCommand command = Mysql_db.execute(sqlAuthCheck);
                
                if(Convert.ToInt32(command.ExecuteScalar()) == 0)
                {
                    // Error validating auth code
                }
                else
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Fetch data from database and create new diver
                            Diver diver = new Diver();

                            diver.id = Convert.ToInt32(reader["id"]);
                            diver.name = reader["name"].ToString();
                            diver.country = reader["coutry"].ToString();
                            diver.competition = Convert.ToInt32(reader["in_competition"]);
                        }
                    }

                    diver.Show();
                    mainForm.Hide();
                }
            }
            catch
            {
                // Logg error
            }

        }

        void ICompetition.Exit()
        {
            if (mainForm.ExitButn.Enabled)
            {
                Application.Exit();
            }
        }

        void ICompetition.Jump()
        {
            if(diver.JumpButton.Enabled)
            {
                Diver Diver = new Diver();
                Diver.jump();
            }
        }
    }
}
