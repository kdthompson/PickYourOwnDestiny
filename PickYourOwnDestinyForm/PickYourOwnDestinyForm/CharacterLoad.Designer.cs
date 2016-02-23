namespace PickYourOwnDestiny.UI
{
    partial class CharacterLoad
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
            this.cbCharacters = new System.Windows.Forms.ComboBox();
            this.button_CharacterLoad_LoadCharater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCharacters
            // 
            this.cbCharacters.FormattingEnabled = true;
            this.cbCharacters.Location = new System.Drawing.Point(213, 98);
            this.cbCharacters.Name = "cbCharacters";
            this.cbCharacters.Size = new System.Drawing.Size(121, 21);
            this.cbCharacters.TabIndex = 0;
            this.cbCharacters.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_CharacterLoad_LoadCharater
            // 
            this.button_CharacterLoad_LoadCharater.Location = new System.Drawing.Point(213, 240);
            this.button_CharacterLoad_LoadCharater.Name = "button_CharacterLoad_LoadCharater";
            this.button_CharacterLoad_LoadCharater.Size = new System.Drawing.Size(121, 23);
            this.button_CharacterLoad_LoadCharater.TabIndex = 1;
            this.button_CharacterLoad_LoadCharater.Text = "Load Character";
            this.button_CharacterLoad_LoadCharater.UseVisualStyleBackColor = true;
            this.button_CharacterLoad_LoadCharater.Click += new System.EventHandler(this.button_CharacterLoad_LoadCharater_Click);
            // 
            // CharacterLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 374);
            this.Controls.Add(this.button_CharacterLoad_LoadCharater);
            this.Controls.Add(this.cbCharacters);
            this.Name = "CharacterLoad";
            this.Text = "CharacterLoad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCharacters;
        private System.Windows.Forms.Button button_CharacterLoad_LoadCharater;
    }
}