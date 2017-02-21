using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighScorer.Backend.Models
{
    public class GameSession
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual Game Game { get; set; }
        public virtual List<Player> Players { get; set; }
    }
}