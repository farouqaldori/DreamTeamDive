using System;
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
        void UpdateJudgeGridTabel(Judge judge);

        void UpdateDiverGridTabel(Diver diver);

        void DeleteJudge(int index);
        void DeleteDiver(int index);
        void WriteToFileDiver();

        void ReadFromfileDiver();
        void WriteToFileJudge();
        void ReadFromfileJudge();
    }
}
