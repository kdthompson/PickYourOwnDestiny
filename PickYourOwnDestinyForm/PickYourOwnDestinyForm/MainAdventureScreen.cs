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

namespace PickYourOwnDestiny.UI
{
    public partial class MainAdventureScreen : Form
    {
        private bool _canBartander = true;

        Adventure _MainAdventure;


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

            _MainAdventure = dbHelper.Instance.getAdventure(CharacterCreation.currentCharacter.StoryModeTracker);
            SetPreChoiceText();

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
            this.textbox_MainAdventure_Text.Text = _MainAdventure.StoryText;
            this.button_MainActivity_Choice1.Text = _MainAdventure.Choice1ButtonText;
            this.button_MainActivity_Choice2.Text = _MainAdventure.Choice2ButtonText;
            this.button_MainActivity_Choice3.Text = _MainAdventure.Choice3ButtonText;
        }

        private void PostTextChoice()
        {
            this.button_MainActivity_Continue.Show();
        }

        private void button_MainActivity_Choice1_Click(object sender, EventArgs e)
        {
            DisableAllChoices();
            this.textbox_MainAdventure_Text.Text = _MainAdventure.Choice1ResultText;
            PostTextChoice();
        }

        private void button_MainActivity_Choice2_Click(object sender, EventArgs e)
        {
            DisableAllChoices();
            this.textbox_MainAdventure_Text.Text = _MainAdventure.Choice2ResultText;
            PostTextChoice();
        }

        private void button_MainActivity_Choice3_Click(object sender, EventArgs e)
        {
            DisableAllChoices();
            this.textbox_MainAdventure_Text.Text = _MainAdventure.Choice3ResultText;
            PostTextChoice();
        }

        private void button_MainActivity_Continue_Click(object sender, EventArgs e)
        {
            CheckForGameOver();
            CharacterCreation.currentCharacter.StoryModeTracker += 1;
            PlayGame();
        }

        private void CheckForGameOver()
        {
            if (CharacterCreation.currentCharacter.HitPoints <= 0)
            {
                this.Hide();
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
