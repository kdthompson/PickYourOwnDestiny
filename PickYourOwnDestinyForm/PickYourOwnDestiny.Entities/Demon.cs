using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourOwnDestiny.Entities
{
    class Demon : Character
    {
        public Demon()
        {
            this.Name = "Ra's Al Ghul";
            this.Strength = 15;
            this.Knowledge = 15;
            this.Dex = 12;
            this.HeroPoints = 5;
            this.HitPoints = 20;
            this.StoryModeTracker = 1;

        }
    }
}
