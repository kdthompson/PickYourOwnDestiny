using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourOwnDestiny.Entities
{
    public class Character
    {
        public string CharacterRace { get; set; }

        public string CharacterClass { get; set; }

        public string Name { get; set; }

        public int Strength { get; set; }

        public int Dex { get; set; }

        public int Knowledge { get; set; }

        public int HitPoints { get; set; }

        public int HeroPoints { get; set; }

        public int StoryModeTracker { get; set; }

        public Character()
        {
            this.CharacterClass = String.Empty;
            this.CharacterRace = String.Empty;
            this.Name = String.Empty;
            this.Strength = 0;
            this.Dex = 0;
            this.Knowledge = 0;
            this.HitPoints = 0;
            this.HeroPoints = 0;
            this.StoryModeTracker = 0;
        }
        public Character(String mName, String mClass, String mRace, int mStrength,
            int mDexterity, int mKnowledge, int mHitPoints, int mHeroPoints)
        {
            this.Name = mName;
            this.CharacterClass = mClass;
            this.CharacterRace = mRace;
            this.Strength = mStrength;
            this.Dex = mDexterity;
            this.Knowledge = mKnowledge;
            this.HitPoints = mHitPoints;
            this.HeroPoints = mHeroPoints;
            this.StoryModeTracker = 1;
        }
        public Character(ArrayList Character)
        {
            this.Name = Character[1].ToString();
            this.CharacterRace = Character[2].ToString();
            this.CharacterClass = Character[3].ToString();
            this.Strength = Int32.Parse(Character[4].ToString());
            this.Dex = Int32.Parse(Character[5].ToString());
            this.Knowledge = Int32.Parse(Character[6].ToString());
            this.HitPoints = Int32.Parse(Character[7].ToString());
            this.HeroPoints = Int32.Parse(Character[8].ToString());
            this.StoryModeTracker = Int32.Parse(Character[9].ToString());
        }

    }
}
