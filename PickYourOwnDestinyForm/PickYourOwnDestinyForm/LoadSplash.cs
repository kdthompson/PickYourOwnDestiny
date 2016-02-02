using PickYourOwnDestiny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYOD_Slpash
{
    public partial class LoadSplash : Form
    {
        public int count = 1;
        
        public LoadSplash()
        {
            InitializeComponent();
         
            
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splashProgressbar.Increment(count);
            if (splashProgressbar.Value==100) 
            {
                timerSplash.Stop();
                Console.WriteLine("in");
                LoadingScreen f2 = new LoadingScreen();
                this.Hide();
                f2.Show();
            }
            else
            {
                //count++;
                Console.WriteLine("hit" +  count.ToString());
            }

        }
    }
}
