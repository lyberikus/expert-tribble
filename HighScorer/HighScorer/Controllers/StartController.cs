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
        [HttpGet, Route("api/GetPlayableGames")]
        public IHttpActionResult GetPlayableGames()
        {
            return Ok(new List<PlayableGame> { 
                new PlayableGame {Name="Bowling", Link = "/bowling"}
            });
        }
    }
}
