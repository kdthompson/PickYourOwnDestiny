namespace PickYourOwnDestiny.UI
{
    partial class EndGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_EndScreen = new System.Windows.Forms.Panel();
            this.label_HeroRank = new System.Windows.Forms.Label();
            this.richTextBox_EndSummary = new System.Windows.Forms.RichTextBox();
            this.button_EndNewChar = new System.Windows.Forms.Button();
            this.button_EndReplayWithSame = new System.Windows.Forms.Button();
            this.button_EndAllGame = new System.Windows.Forms.Button();
            this.panel_EndScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_EndScreen
            // 
            this.panel_EndScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_EndScreen.Controls.Add(this.button_EndAllGame);
            this.panel_EndScreen.Controls.Add(this.button_EndReplayWithSame);
            this.panel_EndScreen.Controls.Add(this.button_EndNewChar);
            this.panel_EndScreen.Controls.Add(this.richTextBox_EndSummary);
            this.panel_EndScreen.Controls.Add(this.label_HeroRank);
            this.panel_EndScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_EndScreen.Location = new System.Drawing.Point(0, 0);
            this.panel_EndScreen.Name = "panel_EndScreen";
            this.panel_EndScreen.Size = new System.Drawing.Size(777, 358);
            this.panel_EndScreen.TabIndex = 0;
            // 
            // label_HeroRank
            // 
            this.label_HeroRank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_HeroRank.AutoSize = true;
            this.label_HeroRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HeroRank.Location = new System.Drawing.Point(293, 9);
            this.label_HeroRank.Name = "label_HeroRank";
            this.label_HeroRank.Size = new System.Drawing.Size(121, 24);
            this.label_HeroRank.TabIndex = 0;
            this.label_HeroRank.Text = "Hero Rank: ";
            // 
            // richTextBox_EndSummary
            // 
            this.richTextBox_EndSummary.Location = new System.Drawing.Point(104, 41);
            this.richTextBox_EndSummary.Name = "richTextBox_EndSummary";
            this.richTextBox_EndSummary.Size = new System.Drawing.Size(512, 256);
            this.richTextBox_EndSummary.TabIndex = 1;
            this.richTextBox_EndSummary.Text = "";
            // 
            // button_EndNewChar
            // 
            this.button_EndNewChar.Location = new System.Drawing.Point(104, 303);
            this.button_EndNewChar.Name = "button_EndNewChar";
            this.button_EndNewChar.Size = new System.Drawing.Size(100, 52);
            this.button_EndNewChar.TabIndex = 2;
            this.button_EndNewChar.Text = "Make New Character";
            this.button_EndNewChar.UseVisualStyleBackColor = true;
            this.button_EndNewChar.Click += new System.EventHandler(this.button_EndNewChar_Click);
            // 
            // button_EndReplayWithSame
            // 
            this.button_EndReplayWithSame.Location = new System.Drawing.Point(308, 303);
            this.button_EndReplayWithSame.Name = "button_EndReplayWithSame";
            this.button_EndReplayWithSame.Size = new System.Drawing.Size(100, 52);
            this.button_EndReplayWithSame.TabIndex = 3;
            this.button_EndReplayWithSame.Text = "Replay With Current Character";
            this.button_EndReplayWithSame.UseVisualStyleBackColor = true;
            this.button_EndReplayWithSame.Click += new System.EventHandler(this.button_EndReplayWithSame_Click);
            // 
            // button_EndAllGame
            // 
            this.button_EndAllGame.Location = new System.Drawing.Point(512, 303);
            this.button_EndAllGame.Name = "button_EndAllGame";
            this.button_EndAllGame.Size = new System.Drawing.Size(100, 52);
            this.button_EndAllGame.TabIndex = 4;
            this.button_EndAllGame.Text = "Quit Game";
            this.button_EndAllGame.UseVisualStyleBackColor = true;
            this.button_EndAllGame.Click += new System.EventHandler(this.button_EndAllGame_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 358);
            this.Controls.Add(this.panel_EndScreen);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.panel_EndScreen.ResumeLayout(false);
            this.panel_EndScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_EndScreen;
        private System.Windows.Forms.Button button_EndAllGame;
        private System.Windows.Forms.Button button_EndReplayWithSame;
        private System.Windows.Forms.Button button_EndNewChar;
        private System.Windows.Forms.RichTextBox richTextBox_EndSummary;
        private System.Windows.Forms.Label label_HeroRank;
    }
}