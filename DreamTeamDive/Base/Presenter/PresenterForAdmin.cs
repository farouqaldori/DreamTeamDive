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
            
            this._admin.SetDiversList(ar.divers);
            this._admin.SetJudgesList(ar.judges);
            this._admin.EventUpdateDiverGridTable += UpdateDiverGridTable;
            this._admin.EventUpdateJudgeGridTable += UpdateJudgeGridTable;
            this._admin.EventDeleteJudge += DeleteJudge;
            this._admin.EventDeleteDiver += DeleteDiver;
            this._admin.EventReadFromFileDiver += ReadFromFileDiver;
            this._admin.EventReadFromFileJudge += ReadFromFileJudge;
            this._admin.EventWriteToFileDiver += WriteToFileDiver;
            this._admin.EventWriteToFileJudge += WriteToFileJudge;
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

        public void DeleteJudge(int index)
        {
            this._Model.DeleteJudge(index);
        }
        public void DeleteDiver(int index)
        {
            this._Model.DeleteDiver(index);
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
