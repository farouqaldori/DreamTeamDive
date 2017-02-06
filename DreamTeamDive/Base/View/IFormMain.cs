using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public delegate void DelegateLogin();
    public delegate void DelegateExit();
    public delegate void DelegateJump();
    
    public interface IFormMain
    {
        event DelegateLogin EventLogin;
        event DelegateExit EventExit;
        event DelegateJump EventJump;

    }
}
