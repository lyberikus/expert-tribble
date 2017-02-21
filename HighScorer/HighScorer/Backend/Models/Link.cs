using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighScorer.Backend.Models
{
    public class Link
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
    }
}