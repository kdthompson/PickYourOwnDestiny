﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_StartGame_Click_1(object sender, EventArgs e)
        {
            MainAdventureScreen mas = new MainAdventureScreen();
            mas.Show();
        }
    }
}
