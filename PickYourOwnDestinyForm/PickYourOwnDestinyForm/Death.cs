using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PickYourOwnDestiny.Entities;
using PYOD_Slpash;
using PickYourOwnDestiny.UI;

namespace PYOD_Slpash
{
    public partial class Death : Form
    {
        public Death()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Load
            CharacterCreation.currentCharacter = dbHelper.Instance.getCharacter(CharacterCreation.currentCharacter.Name.ToString());
            this.Hide();
            MainAdventureScreen mas = new MainAdventureScreen();
            mas.Show();
        }
    }
}
