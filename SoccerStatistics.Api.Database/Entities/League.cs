﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoccerStatistics.Api.Database.Entities
{
    public class League
    {
        public uint Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Shortname { get; set; }
        [Required]
        [StringLength(20)]
        public string Season { get; set; }
        [StringLength(50)]
        public string MVP { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(50)]
        public string Winner { get; set; }
        public virtual IEnumerable<Round> Rounds { get; set; }
        public virtual IEnumerable<Team> Teams { get; set; }
    }
}
