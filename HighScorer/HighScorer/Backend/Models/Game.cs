using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighScorer.Backend.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Link> Links { get; set; }
    }
}