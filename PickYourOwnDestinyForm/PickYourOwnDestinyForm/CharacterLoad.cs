using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickYourOwnDestiny.UI
{
    public partial class CharacterLoad : Form
    {

        public CharacterLoad()
        {
            InitializeComponent();
            ArrayList characterList = dbHelper.Instance.getAtributeList("Character", "Name", "");
            cbCharacters.DataSource = characterList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_CharacterLoad_LoadCharater_Click(object sender, EventArgs e)
        {
            CharacterCreation.currentCharacter = dbHelper.Instance.getCharacter(cbCharacters.Text.ToString());
            this.Hide();
            MainAdventureScreen mas = new MainAdventureScreen();
            mas.Show();
        }
    }
}
