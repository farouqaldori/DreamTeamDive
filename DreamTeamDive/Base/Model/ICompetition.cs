using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public interface ICompetition
    {
        void StartConnection();

        Diver Login(string _authcode);

        void Exit();

        void Jump();

        List<Jump> UpdateJumps(int diver_id);
    }
}
