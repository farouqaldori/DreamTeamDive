using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public delegate void DelegateConinute();
    public delegate void DelegateExit();
    public delegate void DelegateJump();
    
    public interface IFormMain
    {
        event DelegateConinute EventContinue;
        event DelegateExit EventExit;
        event DelegateJump EventJump;

    }
}
