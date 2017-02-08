using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public interface ICompetition
    {
        void Login(string authCode, Diver diver, diver_form DivForm);

        void Exit();

        void Jump(Diver diver, diver_form DivForm);
    }
}
