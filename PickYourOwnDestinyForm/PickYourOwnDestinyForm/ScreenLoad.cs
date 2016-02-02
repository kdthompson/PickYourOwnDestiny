﻿using System;
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
    public partial class ScreenLoad : Form
    {
        public ScreenLoad()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Start_Click(object sender, EventArgs e)
        {
            var conformationStart = MessageBox.Show("Are you sure you wish to start a new character?", "Confirm Start"
                , MessageBoxButtons.YesNo);
            if (conformationStart == DialogResult.Yes)
            {
                //stuff
            }
            else
            {
                //stuff
            }
        }

        private void LoadingScreen_Continue_Click(object sender, EventArgs e)
        {
            var conformationLoad = MessageBox.Show("Are you sure you wish to load a character?", "Confirm Load"
                , MessageBoxButtons.YesNo);
            if (conformationLoad == DialogResult.Yes)
            {
                //stuff
            }
            else
            {
                //stuff
            }
        }
    }

}