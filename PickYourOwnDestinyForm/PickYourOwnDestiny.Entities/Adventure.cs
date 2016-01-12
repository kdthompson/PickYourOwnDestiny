using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourOwnDestiny.Entities
{
    class Adventure
    {
        public int StoryModeTracker { get; set; }
        public string StoryText { get; set; }
        public string Choice1ButtonText { get; set; }
        public string Choice1Stat { get; set; }
        public int Choice1Success { get; set; }
        public int Choice1Max { get; set; }
        public int Choice1Multiplier { get; set; }
        public string Choice2ButtonText { get; set; }
        public string Choice2Stat { get; set; }
        public int Choice2Success { get; set; }
        public int Choice2Max { get; set; }
        public int Choice2Multiplier { get; set; }
        public string Choice3ButtonText { get; set; }
        public string Choice3Stat { get; set; }
        public int Choice3Success { get; set; }
        public int Choice3Max { get; set; }
        public int Choice3Multiplier { get; set; }
    }
}
