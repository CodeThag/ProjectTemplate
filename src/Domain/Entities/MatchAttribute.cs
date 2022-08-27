using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MatchStatistic
    {
        public int Id { get; set; }
        public Match Match { get; set; } = new Match();
        public StatisticAttribute StatisticAttribute { get; set; } = new StatisticAttribute();
        public int Home { get; set; }
        public int Away { get; set; }
    }
}