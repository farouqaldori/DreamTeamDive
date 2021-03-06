﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Diver_Contest
{
    public interface IAdmin
    {
        void InsertNewDivers(int DiverCoun);
        void InsertNewJudges(int JudgeCoun);
        void startconnection();
        void UpdateJudgeGridTabel(Judge judge);
        void UpdateDiverGridTabel(Diver diver);
        void WriteToFileDiver();
        void ReadFromfileDiver();
        void WriteToFileJudge();
        void ReadFromfileJudge();
        void CreateNewCompetition(string _name, string _date);
    }
}
