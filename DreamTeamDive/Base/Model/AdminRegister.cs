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
        void IAdmin.DeleteJudge(int index)
        {
            judges.RemoveAt(index);
        }
        void IAdmin.DeleteDiver(int index)
        {
            divers.RemoveAt(index);
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
    }
}
