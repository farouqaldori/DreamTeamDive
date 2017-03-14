﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public interface ICompetition
    {
        // Main functions
        void StartConnection();
        void Exit();

        // Functions for diver
        Dictionary<int, string> GetJumpTypes();
        Diver DiverLogin(string _authcode);
        void Jump(Diver _diver, int _jumpStyle, int _difficulty);
        List<Jump> UpdateJumps(int diver_id);

        // Functions for judge
        Judge JudgeLogin(string _authcode);
        Tuple<Jump, Diver> GetJumps(int _compId, int _thisJudgeId);
        void SendRating(Judge _judge, int _jumpId, string _grade);
    }
}
