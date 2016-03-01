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
using System.Collections;

namespace PickYourOwnDestiny.UI
{
    public partial class MainAdventureScreen : Form
    {
        private bool _canBartander = true;

        Adventure _MainAdventure;
        private ArrayList ChoiceReturn;
        int ChoiceStat;


        public MainAdventureScreen()
        {
            InitializeComponent();
            PlayGame();
        }

        private void PlayGame()
        {
            this.Text = "Pick Your Own Destiny";

            //Test purposes only
            //CharacterCreation.currentCharacter.StoryModeTracker = 5;
            //_MainAdventure = new AlleyBrawlAdventure();
            //textBox_MainAdventure_HitPoints.Text = CharacterCreation.currentCharacter.HitPoints.ToString();
            //textBox_MainAdventure_CharacterName.Text = CharacterCreation.currentCharacter.Name;
            if (CharacterCreation.currentCharacter.StoryModeTracker == 2)
            {
                CharacterCreation.currentCharacter.HitPoints = 0;
                CheckForGameOver();
            }
            else
            {
                _MainAdventure = dbHelper.Instance.getAdventure(CharacterCreation.currentCharacter.StoryModeTracker);
                SetPreChoiceText();
            }


            //switch (CharacterCreation.currentCharacter.StoryModeTracker)
            //{
            //    case 1:
            //        _MainAdventure = dbHelper.Instance.getAdventure(CharacterCreation.currentCharacter.StoryModeTracker);
            //        break;
            //    //case 2:
            //    //    _MainAdventure = new CardGame();
            //    //    break;
            //    //case 3:
            //    //    _MainAdventure = new Riddler();
            //    //    break;
            //    //case 4:
            //    //    _MainAdventure = new BarChallenge();
            //    //    break;
            //    case 5:
            //        _MainAdventure = new AlleyBrawlAdventure();
            //        break;
            //    //case 6:
            //    //    _MainAdventure = new EndScreen;
            //    //case 0:
            //    //    _MainAdventure = new Bartender();
            //    //    break;
            //}
        }

        private void SetPreChoiceText()
        {
            EnableAllChoices();
            this.textbox_MainAdventure_Text.Text = _MainAdventure.StoryText;
            this.button_MainActivity_Choice1.Text = _MainAdventure.Choice1ButtonText;
            this.button_MainActivity_Choice2.Text = _MainAdventure.Choice2ButtonText;
            this.button_MainActivity_Choice3.Text = _MainAdventure.Choice3ButtonText;
        }

        private void PostTextChoice()
        {
            this.button_MainActivity_Continue.Show();
        }
        private void ChoiceChk(String multi, String success)
        {
            ChoiceReturn = dbHelper.Instance.returnChallenge("Adventure", multi, success, "where StoryModeTracker = " + CharacterCreation.currentCharacter.StoryModeTracker);
        }
        private void StatGrab(String stat)
        {
            ChoiceStat = dbHelper.Instance.returnCharStat(stat , "Character", "where Name = '" + CharacterCreation.currentCharacter.Name + "'");
        }        
        private void button_MainActivity_Choice1_Click(object sender, EventArgs e)
        {
            DisableAllChoices();
            this.textbox_MainAdventure_Text.Text = _MainAdventure.Choice1ResultText;
            ChoiceChk("COneMultiplier", "COneCQSuccess");
            //StatGrab("COneStat");
            PostTextChoice();
        }

        private void button_MainActivity_Choice2_Click(object sender, EventArgs e)
        {
            DisableAllChoices();
            this.textbox_MainAdventure_Text.Text = _MainAdventure.Choice2ResultText;
            ChoiceChk("CTwoMultiplier", "CtwoCQSuccess");
            //StatGrab("CTwoStat");
            PostTextChoice();
        }

        private void button_MainActivity_Choice3_Click(object sender, EventArgs e)
        {
            DisableAllChoices();
            this.textbox_MainAdventure_Text.Text = _MainAdventure.Choice3ResultText;
            ChoiceChk("CThreeMultiplier", "CThreeCQSuccess");
            //StatGrab("CThreeStat");
            PostTextChoice();
        }

        private void button_MainActivity_Continue_Click(object sender, EventArgs e)
        {
            CheckForGameOver();
            CharacterCreation.currentCharacter.StoryModeTracker += 1;
            PlayGame();
        }
        private int hpCons()
        {
            int success = Convert.ToInt32(ChoiceReturn[1]);
            Random rng = new Random();
            if (success == 1)
                return 1;
            if (success == 0 || ChoiceStat + rng.Next(0, Convert.ToInt32(ChoiceReturn[0])) > success)
                return 0;
            else
                return success - (ChoiceStat + rng.Next(0, Convert.ToInt32(ChoiceReturn[0])));
        }
        private int hpAdjust(int hpCons)
        {
            return dbHelper.Instance.returnCharStat("HitPoints", "Character", "where Name = '" + CharacterCreation.currentCharacter.Name + "'") - hpCons;
        }

        private void CheckForGameOver()
        {
            if (CharacterCreation.currentCharacter.HitPoints > 0)
            {
                CharacterCreation.currentCharacter.HitPoints -= hpAdjust(hpCons());
            }
            if (CharacterCreation.currentCharacter.HitPoints <= 0)
            {
                this.Close();
                Death death = new Death();
                death.Show();
            }
        }

        private void quit_MenuItem_MainActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DisableAllChoices()
        {
            this.button_MainActivity_Choice1.Enabled = false;
            this.button_MainActivity_Choice2.Enabled = false;
            this.button_MainActivity_Choice3.Enabled = false;
        }

        private void EnableAllChoices()
        {
            this.button_MainActivity_Choice1.Enabled = true;
            this.button_MainActivity_Choice2.Enabled = true;
            this.button_MainActivity_Choice3.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_MainAdventure_TalkToBartender_Click(object sender, EventArgs e)
        {

            if (_canBartander)
            {
                _MainAdventure = dbHelper.Instance.getAdventure(0);
                _canBartander = false;
                SetPreChoiceText();
            }
            else
            {
                var message = MessageBox.Show("The bar bouncer stops you from going up to see the Bartender", "Go Sit Back Down", MessageBoxButtons.OK);
            }

        }
    }
    
}
