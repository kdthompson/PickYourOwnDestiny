using System;
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

        public Character()
        {
            this.CharacterClass = String.Empty;
            this.CharacterRace = String.Empty;
            this.Name = String.Empty;
        }
    }
}
