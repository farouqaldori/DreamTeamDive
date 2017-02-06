﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public class PresenterForMain
    {
        public IFormMain _view { get; set; }

        public ICompetition _Model { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="view"></param>
        public PresenterForMain(IFormMain view, CompetitionRegister cr)
        {
            this._Model = cr;
            this._view = view;
            this._view.EventContinue += Continute;
            this._view.EventExit += Exit;
            this._view.EventJump += Jump;
        }

        public void Continute()
        {
            this._Model.Continute();
        }

        public void Exit()
        {
            this._Model.Exit();
        }

        public void Jump()
        {
            this._Model.Jump();
        }
    }
}