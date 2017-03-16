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
    // Judge delegates
    public delegate void DelegateUpdateJudgeGridTable();
    public delegate void DelegateWriteToFileJudge();
    public delegate void DelegateReadFromFileJudge();
    public delegate void DelegateInsertNewJudges(int JudgeCount);
    // Diver delegates
    public delegate void DelegateUpdateDiverGridTable();
    public delegate void DelegateWriteToFileDiver();
    public delegate void DelegateReadFromFileDiver();
    public delegate void DelegateInsertNewDivers(int DiverCount);

    // Competition delegate
    public delegate void DelegateCreateNewCompetition(string _name, string _date);
    public interface IAdminForm
    {
        void SetDiversList(Collection<Diver> divers);
        void SetJudgesList(Collection<Judge> judges);

        event DelegateUpdateDiverGridTable EventUpdateDiverGridTable;
        event DelegateUpdateJudgeGridTable EventUpdateJudgeGridTable;
        event DelegateWriteToFileDiver EventWriteToFileDiver;
        event DelegateReadFromFileDiver EventReadFromFileDiver;
        event DelegateWriteToFileJudge EventWriteToFileJudge;
        event DelegateReadFromFileJudge EventReadFromFileJudge;
        event DelegateCreateNewCompetition EventCreateNewCompetition;
        event DelegateInsertNewDivers EventInsertNewDivers;
        event DelegateInsertNewJudges EventInsertNewJudges;
    }
}
