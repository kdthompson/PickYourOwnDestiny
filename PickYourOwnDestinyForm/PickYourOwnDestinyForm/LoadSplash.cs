using System;
using System.Windows.Forms;
using PickYourOwnDestiny.UI;

namespace PYOD_Slpash
{
    public partial class LoadSplash : Form
    {
        public int count = 5;
        
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
