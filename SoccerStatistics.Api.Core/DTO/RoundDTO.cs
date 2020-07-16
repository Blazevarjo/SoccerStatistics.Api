﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerStatistics.Api.Core.DTO
{
    public class RoundDTO
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public uint LeagueId { get; set; }
        public IEnumerable<MatchBasicDTO> Matches { get; set; }
    }
}
