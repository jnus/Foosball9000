﻿using System;
using System.Collections.Generic;
using Foosball.Models;

namespace Foosball.Repository
{
    public interface IMatchRepository
    {
        void SaveMatch(Match draft);
        List<Match> GetMatches();
        Match GetByTimeStamp(DateTime dateTime);
        List<Match> GetRecentMatches(int numberOfMatches);
    }
}