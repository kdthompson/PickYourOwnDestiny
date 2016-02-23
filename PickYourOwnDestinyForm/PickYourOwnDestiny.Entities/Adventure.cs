using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourOwnDestiny.Entities
{
    public class Adventure
    {
        public int StoryModeTracker { get; set; }
        public string StoryText { get; set; }

        public string Choice1ButtonText { get; set; }
        public string Choice1Stat { get; set; }
        public int Choice1Success { get; set; }
        public int Choice1Max { get; set; }
        public int Choice1Multiplier { get; set; }
        public string Choice1ResultText { get; set; }

        public string Choice2ButtonText { get; set; }
        public string Choice2Stat { get; set; }
        public int Choice2Success { get; set; }
        public int Choice2Max { get; set; }
        public int Choice2Multiplier { get; set; }
        public string Choice2ResultText { get; set; }

        public string Choice3ButtonText { get; set; }
        public string Choice3Stat { get; set; }
        public int Choice3Success { get; set; }
        public int Choice3Max { get; set; }
        public int Choice3Multiplier { get; set; }
        public string Choice3ResultText { get; set; }

        public Adventure(ArrayList adventureList)
        {
            this.StoryModeTracker = Int32.Parse(adventureList[0].ToString());
            this.StoryText = adventureList[1].ToString();

            this.Choice1ButtonText = adventureList[2].ToString();
            this.Choice1Stat = adventureList[3].ToString();
            this.Choice1Success = Int32.Parse(adventureList[4].ToString());
            this.Choice1Max = Int32.Parse(adventureList[5].ToString());
            this.Choice1Multiplier = Int32.Parse(adventureList[6].ToString());
            this.Choice1ResultText = adventureList[7].ToString();

            this.Choice2ButtonText = adventureList[8].ToString();
            this.Choice2Stat = adventureList[9].ToString();
            this.Choice2Success = Int32.Parse(adventureList[10].ToString());
            this.Choice2Max = Int32.Parse(adventureList[11].ToString());
            this.Choice2Multiplier = Int32.Parse(adventureList[12].ToString());
            this.Choice2ResultText = adventureList[13].ToString();

            this.Choice3ButtonText = adventureList[14].ToString();
            this.Choice3Stat = adventureList[15].ToString();
            this.Choice3Success = Int32.Parse(adventureList[16].ToString());
            this.Choice3Max = Int32.Parse(adventureList[17].ToString());
            this.Choice3Multiplier = Int32.Parse(adventureList[18].ToString());
            this.Choice3ResultText = adventureList[19].ToString();
        }
        public Adventure()
        {
        }
    }
    
}
