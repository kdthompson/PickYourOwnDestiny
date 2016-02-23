using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickYourOwnDestiny.UI
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            richTextBox_EndSummary.Text = "End Game Summary Text";
        }

        private void button_EndNewChar_Click(object sender, EventArgs e)
        {
            //load character creation screen
        }

        private void button_EndReplayWithSame_Click(object sender, EventArgs e)
        {
            //save character info and back to main adventure 1
        }

        private void button_EndAllGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
