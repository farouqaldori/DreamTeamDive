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
    public delegate void DelegateUpdateJumps();
    //public delegate void DelegateSendRating();

    public interface IFormMain
    {
        event DelegateLogin EventLogin;
        event DelegateExit EventExit;
        event DelegateJump EventJump;
        event DelegateUpdateJumps EventUpdateJumps;
        //event DelegateSendrating EventSendRating;
    }
}
