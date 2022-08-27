using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public Club Home { get; set; } = new Club();
        public Club Away { get; set; } = new Club();
        public DateTime KickOff { get; set; }
    }
}