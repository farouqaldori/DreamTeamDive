using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace Diver_Contest
{
    [Serializable()]
    public class AdminRegister : IAdmin
    {
       

        private Collection<Diver> _divers;
        public Collection<Diver> divers
        {
            get { return _divers; }
            set { _divers = value; }
        }
        private Collection<Judge> _judges;
        public Collection<Judge> judges
        {
            get { return _judges; }
            set { _judges = value; }
        }

        public AdminRegister ()
        {
            divers = new BindingList<Diver>();
            judges = new BindingList<Judge>();
        }
        void IAdmin.UpdateJudgeGridTabel(Judge judge)
        {
            judges.Add(judge);
        }

        void IAdmin.UpdateDiverGridTabel(Diver diver)
        {
            divers.Add(diver);
        }

        void IAdmin.startconnection()
        {
            Mysql_db.connect();
        }

        void IAdmin.WriteToFileDiver()
        {
            Stream stream = new FileStream("divers.xml", FileMode.Create, FileAccess.Write, FileShare.Write);
            XmlSerializer Xs = new XmlSerializer(typeof(AdminRegister));
            Xs.Serialize(stream, this);
            stream.Close();
        }

        void IAdmin.ReadFromfileDiver()
        {
            Stream stream = new FileStream("divers.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer xs = new XmlSerializer(typeof(AdminRegister));
            AdminRegister ar = (AdminRegister)xs.Deserialize(stream);
            
            divers.Clear();
            foreach (var diver in ar.divers)
            {
                divers.Add(diver);
            }
            stream.Close();
        }

        void IAdmin.WriteToFileJudge()
        {
            Stream stream = new FileStream("judges.xml", FileMode.Create, FileAccess.Write, FileShare.Write);
            XmlSerializer xS = new XmlSerializer(typeof(AdminRegister));
            xS.Serialize(stream, this);
            stream.Close();
        }

        void IAdmin.ReadFromfileJudge()
        {
            Stream stream = new FileStream("judges.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer xs = new XmlSerializer(typeof(AdminRegister));
            AdminRegister ar = (AdminRegister)xs.Deserialize(stream);
            
            judges.Clear();
            foreach (var judge in ar.judges)
            {
                judges.Add(judge);
            }
            stream.Close();
        }

        void IAdmin.CreateNewCompetition(string _name, string _date)
        {
           MySqlCommand command = new MySqlCommand("INSERT INTO `Contests`(`name`, `date_created`) VALUES (@name, @date_created)", Mysql_db.connection);
               
           command.Parameters.AddWithValue("@name", _name);
           command.Parameters.AddWithValue("@date_created", _date);
           command.ExecuteNonQuery();
        }

        void IAdmin.InsertNewDivers(int DiverCount)
        {
            for (int i = 0; i < DiverCount; i++)
            {
                MySqlCommand command2 = new MySqlCommand("INSERT INTO `Divers`(`name`, `auth_code`, `country`, `in_competiton`) VALUES (@name, @auth_code, @country, @in_competiton)", Mysql_db.connection);
                command2.Parameters.AddWithValue("@name", divers[i].name);
                command2.Parameters.AddWithValue("@in_competiton", divers[i].competition);
                command2.Parameters.AddWithValue("@country", divers[i].country);
                command2.Parameters.AddWithValue("@auth_code", divers[i].authCode);
                command2.ExecuteNonQuery();
            }
        }

        void IAdmin.InsertNewJudges(int JudgeCount)
        {
            for (int i = 0; i < JudgeCount; i++)
            {
                MySqlCommand command3 = new MySqlCommand("INSERT INTO `Judge`(`name`, `auth_code`, `in_competiton`) VALUES (@name, @auth_code, @in_competiton)", Mysql_db.connection);
                command3.Parameters.AddWithValue("@name", judges[i].name);
                command3.Parameters.AddWithValue("@in_competiton", judges[i].competition);
                command3.Parameters.AddWithValue("@auth_code", judges[i].authCode);
                command3.ExecuteNonQuery();
            }
        }
    }
}
