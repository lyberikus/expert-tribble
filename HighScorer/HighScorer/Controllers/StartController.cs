using HighScorer.Backend;
using HighScorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HighScorer.Controllers
{
    public class StartController : ApiController
    {
        private readonly GameContext GameContext;
        public StartController()
        {
            GameContext = new GameContext();
        }
        [HttpGet, Route("api/GetPlayableGames")]
        public IHttpActionResult GetPlayableGames()
        {
            var playableGames = GameContext.Games.Select(x => new PlayableGame
            {
                Name = x.Name,
                Link = x.Links.FirstOrDefault(l => l.Name == "Default").Url
            }).ToList();
            return Ok(playableGames);
        }
    }
}
