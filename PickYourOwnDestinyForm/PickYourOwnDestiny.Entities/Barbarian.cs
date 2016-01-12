using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourOwnDestiny.Entities
{
    class Barbarian : Character
    {
        public Barbarian()
        {
            this.Name = "Greg";
            this.CharacterClass = "Barbarian";
            this.CharacterRace = "Human";
            this.Strength = 18;
            this.Dex = 13;
            this.Knowledge = 8;
            this.HitPoints = 15;
            this.HeroPoints = 5;
            this.StoryModeTracker = 1;
        }
    }
}
