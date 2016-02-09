using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using PickYourOwnDestiny.Entities;

namespace PickYourOwnDestiny.UI
{
    public partial class CharacterCreation : Form
    {
        //RadioButton m_radiogroup1Checked = null;
        public static Character currentCharacter = new Character();
        int HEROPOINTS = 5, HITPOINTS = 10;
        String mCharRace = "", mCharClass = "";
        int HSTR = 2, ESTR = 1, DSTR = 3, HDEX = 2, EDEX = 3, DDEX = 1, HKNOW = 2, EKNOW = 3, DKNOW = 1;
        int MSTR = 1, RSTR = 2, WSTR = 3, MDEX = 1, RDEX = 3, WDEX = 2, MKNOW = 3, RKNOW = 2, WKNOW = 1;
        public CharacterCreation()
        {
            InitializeComponent();
            
            
        }
        private void rbH_CheckedChanged(object sender, EventArgs e)
        {
            calc_stats();
        }
       
        private void rbE_CheckedChanged(object sender, EventArgs e)
        {
            calc_stats();
        }
        private void calc_stats()
        {
            if (rbM.Checked)
            {
                mCharClass = "Mage";
                if (rbH.Checked)
                {
                    tbStrength.Text =  "" + (HSTR + MSTR + 10);
                    tbDex.Text = "" + (HDEX + MDEX + 10);
                    tbKnow.Text = "" + (HKNOW + MKNOW + 10);
                    mCharRace = "Human";
                }
                else if (rbE.Checked)
                {
                    tbStrength.Text = "" + (ESTR + MSTR + 10);
                    tbDex.Text = "" + (EDEX + MDEX + 10);
                    tbKnow.Text = "" + (EKNOW + MKNOW + 10);
                    mCharRace = "Elf";
                }
                else if (rbD.Checked)
                {
                    tbStrength.Text = "" + (DSTR + MSTR + 10);
                    tbDex.Text = "" + (DDEX + MDEX + 10);
                    tbKnow.Text = "" + (DKNOW + MKNOW + 10);
                    mCharRace = "Dwarf";
                }
            }
            else if (rbR.Checked)
            {
                mCharClass = "Ranger";
                if (rbH.Checked)
                {
                    tbStrength.Text = "" + (HSTR + RSTR + 10);
                    tbDex.Text = "" + (HDEX + RDEX + 10);
                    tbKnow.Text = "" + (HKNOW + RKNOW + 10);
                    mCharRace = "Human";
                }
                else if (rbE.Checked)
                {
                    tbStrength.Text = "" + (ESTR + RSTR + 10);
                    tbDex.Text = "" + (EDEX + RDEX + 10);
                    tbKnow.Text = "" + (HKNOW + RKNOW + 10);
                    mCharRace = "Elf";
                }
                else if (rbD.Checked)
                {
                    tbStrength.Text = "" + (DSTR + RSTR + 10);
                    tbDex.Text = "" + (DDEX + RDEX + 10);
                    tbKnow.Text = "" + (HKNOW + RKNOW + 10);
                    mCharRace = "Dwarf";
                }
            }
            else if (rbW.Checked)
            {
                mCharClass = "Warrior";
                if (rbH.Checked)
                {
                    tbStrength.Text = "" + (HSTR + WSTR + 10);
                    tbDex.Text = "" + (HDEX + WDEX + 10);
                    tbKnow.Text = "" + (HKNOW + WKNOW + 10);
                    mCharRace = "Human";
                }
                else if (rbE.Checked)
                {
                    tbStrength.Text = "" + (ESTR + WSTR + 10);
                    tbDex.Text = "" + (EDEX + WDEX + 10);
                    tbKnow.Text = "" + (EKNOW + WKNOW + 10);
                    mCharRace = "Elf";
                }
                else if (rbD.Checked)
                {
                    tbStrength.Text = "" + (DSTR + WSTR + 10);
                    tbDex.Text = "" + (DDEX + WDEX + 10);
                    tbKnow.Text = "" + (DKNOW + WKNOW + 10);
                    mCharRace = "Dwarf";
                }
            }
            else
            {
                tbStrength.Text = "Please validate selection.";
            }
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            calc_stats();
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            calc_stats();
        }

        private void rbR_CheckedChanged(object sender, EventArgs e)
        {
            calc_stats();
        }

        private void rbW_CheckedChanged(object sender, EventArgs e)
        {
            calc_stats();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbStrength.Text.CompareTo("") == 0 || tbDex.Text.CompareTo("") == 0 || tbKnow.Text.CompareTo("") == 0 || tbCharName.Text.CompareTo("")==0 )
            {
                MessageBox.Show("Please choose your character and name.");
            }
            else
            {
               
                int mBtnStrength = Int32.Parse(tbStrength.Text);
                int mBtnDex = Int32.Parse(tbDex.Text);
                int mBtnKnow = Int32.Parse(tbKnow.Text);
                String mConnectionString="c:\\PYOD\\PYOD.db";
                dbHelper  mDBHelper = new dbHelper(mConnectionString);
                if (mDBHelper.createCharacter(tbCharName.Text.ToString(), mCharRace, mCharClass, mBtnStrength, mBtnDex, mBtnKnow,HITPOINTS,HEROPOINTS))
                {
                    MessageBox.Show("CONGRATULATIONS! You may now go forth and pick your destiny!");
                    currentCharacter = new Character(tbCharName.Text.ToString(), mCharClass, mCharRace, mBtnStrength, mBtnDex, mBtnKnow, HITPOINTS, HEROPOINTS);
                    MainAdventureScreen f4 = new MainAdventureScreen();
                    this.Hide();
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("Magical difficulties! Character did not come forth!");
                }

            }
        }




       
    }
}
