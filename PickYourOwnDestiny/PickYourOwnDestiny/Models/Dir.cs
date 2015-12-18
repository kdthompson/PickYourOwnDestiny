using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PickYourOwnAdventure.Models
{
    public class Dir
    {
        public string name { get; set; }
        public string path { get; set; }
        public List<CharacterImage> images { get; set; }
    }
}