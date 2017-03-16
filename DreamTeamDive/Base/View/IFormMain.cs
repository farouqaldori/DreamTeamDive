using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public delegate void DelegateLogin();
    public delegate void DelegateExit();

    // Diver delegates
    public delegate void DelegateJump();
    public delegate void DelegateUpdateJumps();

    // Judge delegates
    public delegate void DelegateSendRating();
    public delegate void DelegateGetJump();

    //Spectator delegates
    public delegate void DelegateGetRatingDivers();
    public delegate void DelegateGetEndResultDivers();

    public interface IFormMain
    {
       
        event DelegateLogin EventLogin;
        event DelegateExit EventExit;

        // Diver events
        event DelegateJump EventJump;
        event DelegateUpdateJumps EventUpdateJumps;

        // Judge events
        event DelegateSendRating EventSendRating;
        event DelegateGetJump EventGetJump;

        //Spectator events
        event DelegateGetRatingDivers EventGetRatingDivers;
        event DelegateGetEndResultDivers EventGetEndResultDivers;
    }
}
