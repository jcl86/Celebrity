﻿using System;
using System.Collections.Generic;

namespace Celebrity.Repositories
{
    public class GameCreationCriteria
    {
        public int TotalRounds { get; }
        public int MaximunNumber { get; }
        public bool IncludeEasy { get; }
        public bool IncludeIntermediate { get; }
        public bool IncludeHard { get;  }
        public IEnumerable<Guid> SubcategoriesToInclude { get; }
        public IEnumerable<Team> Teams { get; }

        public GameCreationCriteria(int maximunNumber, int totalRounds, bool inludeEasy, bool includeIntermediate, bool includeHard, 
            IEnumerable<Guid> subcategoriesToInclude, IEnumerable<Team> teams)
        {
            MaximunNumber = maximunNumber;
            TotalRounds = totalRounds;
            IncludeEasy = inludeEasy;
            IncludeIntermediate = includeIntermediate;
            IncludeHard = includeHard;
            SubcategoriesToInclude = subcategoriesToInclude;
            Teams = teams;
        }
    }
}