using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LeagueYear
    {
        public Guid Id { get; set; }
        public virtual League League { get; set; } = new League();
        public string Season { get; set; } = string.Empty;        
    }
}