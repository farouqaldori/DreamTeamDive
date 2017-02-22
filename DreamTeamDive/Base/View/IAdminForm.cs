using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Diver_Contest
{
    public delegate void DelegateUpdateJudgeGridTable();
    public delegate void DelegateUpdateDiverGridTable();
    public delegate void DelegateDeleteJudge(int index);
    public delegate void DelegateDeleteDiver(int index);
    public delegate void DelegateWriteToFileDiver();
    public delegate void DelegateReadFromFileDiver();
    public delegate void DelegateWriteToFileJudge();
    public delegate void DelegateReadFromFileJudge();
    public interface IAdminForm
    {
        void SetDiversList(Collection<Diver> divers);
        void SetJudgesList(Collection<Judge> judges);

        event DelegateUpdateDiverGridTable EventUpdateDiverGridTable;
        event DelegateUpdateJudgeGridTable EventUpdateJudgeGridTable;
        event DelegateDeleteJudge EventDeleteJudge;
        event DelegateDeleteDiver EventDeleteDiver;
        event DelegateWriteToFileDiver EventWriteToFileDiver;
        event DelegateReadFromFileDiver EventReadFromFileDiver;
        event DelegateWriteToFileJudge EventWriteToFileJudge;
        event DelegateReadFromFileJudge EventReadFromFileJudge;
    }
}
