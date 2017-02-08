using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public delegate void DelegateLogin(string authCode, Diver diver, diver_form DivForm);
    public delegate void DelegateExit();
    public delegate void DelegateJump(Diver diver, diver_form DivForm);
    
    public interface IFormMain
    {
        event DelegateLogin EventLogin;
        event DelegateExit EventExit;
        event DelegateJump EventJump;

    }
}
