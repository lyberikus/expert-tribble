using HighScorer.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HighScorer.Backend
{
    public class GameContext : DbContext 
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<GameSession> GameSessions { get; set; } 
    }
}