using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PickYourOwnDestiny.UI;

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
                ScreenLoad f2 = new ScreenLoad();
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
