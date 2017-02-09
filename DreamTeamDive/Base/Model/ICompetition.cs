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

        // Function of Diver class using a parameter [_authcode] to validate the diver
        Diver Login(string _authcode);

        void Exit();

        void Jump();

        // Function of List<Jump> using the parameter [diver_id] to store each jump 
        List<Jump> UpdateJumps(int diver_id);

        //ALT: Judge SendRating(string _authcode);
    }
}
