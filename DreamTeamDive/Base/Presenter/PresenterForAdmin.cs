using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace Diver_Contest
{
    public class PresenterForAdmin
    {
        public IAdminForm _admin { get; set; }
        public IAdmin _Model { get; set; }
        
        public PresenterForAdmin(IAdminForm admin, AdminRegister ar)
        {
            this._Model = ar;
            this._admin = admin;
            this._Model.startconnection();

            this._admin.SetDiversList(ar.divers);
            this._admin.SetJudgesList(ar.judges);
            this._admin.EventUpdateDiverGridTable += UpdateDiverGridTable;
            this._admin.EventUpdateJudgeGridTable += UpdateJudgeGridTable;
            this._admin.EventReadFromFileDiver += ReadFromFileDiver;
            this._admin.EventReadFromFileJudge += ReadFromFileJudge;
            this._admin.EventWriteToFileDiver += WriteToFileDiver;
            this._admin.EventWriteToFileJudge += WriteToFileJudge;
            this._admin.EventCreateNewCompetition += CreateNewCompetition;
            this._admin.EventInsertNewDivers += InsertNewDivers;
            this._admin.EventInsertNewJudges += InsertNewJudge;
        }

        public void InsertNewDivers(int DiverCount)
        {
            this._Model.InsertNewDivers(DiverCount);
        }
        public void InsertNewJudge(int JudgeCount)
        {
            this._Model.InsertNewJudges(JudgeCount);
        }

        public void CreateNewCompetition(string _name, string _date)
        {
            try
            {
                this._Model.CreateNewCompetition(_name, _date);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("A problem occured, try changing the ID", "Warning");
            }
        }

        public void ReadFromFileDiver()
        {
            this._Model.ReadFromfileDiver();
        }

        public void ReadFromFileJudge()
        {
            this._Model.ReadFromfileJudge();
        }
        
        public void WriteToFileDiver()
        {
            this._Model.WriteToFileDiver();
        }
        
        public void WriteToFileJudge()
        {
            this._Model.WriteToFileJudge();
        }

        public void UpdateJudgeGridTable()
        {
            this._Model.UpdateJudgeGridTabel(new Judge());
        }

        public void UpdateDiverGridTable()
        {
            this._Model.UpdateDiverGridTabel(new Diver());       
        }
    }
}
