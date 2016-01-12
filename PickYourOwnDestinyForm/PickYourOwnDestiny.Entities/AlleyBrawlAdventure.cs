using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourOwnDestiny.Entities
{
    class AlleyBrawlAdventure: Adventure
    {
        public AlleyBrawlAdventure()
        {
            this.StoryModeTracker = 1;
            this.StoryText = "You step outside and start walking down a dark alley. Suddenly, you are surrounded by 5 very large men, who all appear to be armed with clubs or knives...";
            this.Choice1ButtonText = "Run up the pile of trash next to the wall and jump over them";
            this.Choice1Success = 25;
            this.Choice1Stat = "Dex";
            this.Choice1Max = 5;
            this.Choice1Multiplier = -1;
            this.Choice2ButtonText = "Rush the one in front of you, it's time to brawl";
            this.Choice2Stat = "Strength";
            this.Choice2Success = 18;
            this.Choice2Max = 8;
            this.Choice2Multiplier = -2;
            this.Choice3ButtonText = "Start acting like a crazy person, then run away while they laugh";
            this.Choice3Stat = "Knowledge";
            this.Choice3Success = 20;
            this.Choice3Max = 10;
            this.Choice3Multiplier = -3;
        }
    }
}
