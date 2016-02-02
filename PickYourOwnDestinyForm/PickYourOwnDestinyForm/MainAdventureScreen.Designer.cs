namespace PickYourOwnDestiny.UI
{
    partial class MainAdventureScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenu_MainActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGame_MenuItem_MainActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGame_MenuItem_MainActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.quit_MenuItem_MainActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.textbox_MainAdventure = new System.Windows.Forms.TextBox();
            this.button_MainActivity_Choice1 = new System.Windows.Forms.Button();
            this.button_MainActivity_Choice2 = new System.Windows.Forms.Button();
            this.button_MainActivity_Choice3 = new System.Windows.Forms.Button();
            this.button_MainActivity_Continue = new System.Windows.Forms.Button();
            this.progressBar_HitPoints = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_MainActivity});
            this.menuStrip1.Location = new System.Drawing.Point(768, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(86, 539);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenu_MainActivity
            // 
            this.mainMenu_MainActivity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGame_MenuItem_MainActivity,
            this.loadGame_MenuItem_MainActivity,
            this.quit_MenuItem_MainActivity});
            this.mainMenu_MainActivity.Name = "mainMenu_MainActivity";
            this.mainMenu_MainActivity.Size = new System.Drawing.Size(73, 19);
            this.mainMenu_MainActivity.Text = "Main Menu";
            // 
            // saveGame_MenuItem_MainActivity
            // 
            this.saveGame_MenuItem_MainActivity.Name = "saveGame_MenuItem_MainActivity";
            this.saveGame_MenuItem_MainActivity.Size = new System.Drawing.Size(134, 22);
            this.saveGame_MenuItem_MainActivity.Text = "Save Game";
            // 
            // loadGame_MenuItem_MainActivity
            // 
            this.loadGame_MenuItem_MainActivity.Name = "loadGame_MenuItem_MainActivity";
            this.loadGame_MenuItem_MainActivity.Size = new System.Drawing.Size(134, 22);
            this.loadGame_MenuItem_MainActivity.Text = "Load Game";
            // 
            // quit_MenuItem_MainActivity
            // 
            this.quit_MenuItem_MainActivity.Name = "quit_MenuItem_MainActivity";
            this.quit_MenuItem_MainActivity.Size = new System.Drawing.Size(134, 22);
            this.quit_MenuItem_MainActivity.Text = "Quit";
            this.quit_MenuItem_MainActivity.Click += new System.EventHandler(this.quit_MenuItem_MainActivity_Click);
            // 
            // textbox_MainAdventure
            // 
            this.textbox_MainAdventure.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_MainAdventure.Location = new System.Drawing.Point(76, 54);
            this.textbox_MainAdventure.Multiline = true;
            this.textbox_MainAdventure.Name = "textbox_MainAdventure";
            this.textbox_MainAdventure.ReadOnly = true;
            this.textbox_MainAdventure.Size = new System.Drawing.Size(696, 291);
            this.textbox_MainAdventure.TabIndex = 1;
            this.textbox_MainAdventure.TabStop = false;
            this.textbox_MainAdventure.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_MainActivity_Choice1
            // 
            this.button_MainActivity_Choice1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MainActivity_Choice1.Location = new System.Drawing.Point(76, 367);
            this.button_MainActivity_Choice1.Name = "button_MainActivity_Choice1";
            this.button_MainActivity_Choice1.Size = new System.Drawing.Size(408, 39);
            this.button_MainActivity_Choice1.TabIndex = 2;
            this.button_MainActivity_Choice1.TabStop = false;
            this.button_MainActivity_Choice1.UseVisualStyleBackColor = true;
            this.button_MainActivity_Choice1.Click += new System.EventHandler(this.button_MainActivity_Choice1_Click);
            // 
            // button_MainActivity_Choice2
            // 
            this.button_MainActivity_Choice2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MainActivity_Choice2.Location = new System.Drawing.Point(76, 412);
            this.button_MainActivity_Choice2.Name = "button_MainActivity_Choice2";
            this.button_MainActivity_Choice2.Size = new System.Drawing.Size(408, 39);
            this.button_MainActivity_Choice2.TabIndex = 3;
            this.button_MainActivity_Choice2.TabStop = false;
            this.button_MainActivity_Choice2.UseVisualStyleBackColor = true;
            this.button_MainActivity_Choice2.Click += new System.EventHandler(this.button_MainActivity_Choice2_Click);
            // 
            // button_MainActivity_Choice3
            // 
            this.button_MainActivity_Choice3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MainActivity_Choice3.Location = new System.Drawing.Point(76, 457);
            this.button_MainActivity_Choice3.Name = "button_MainActivity_Choice3";
            this.button_MainActivity_Choice3.Size = new System.Drawing.Size(408, 39);
            this.button_MainActivity_Choice3.TabIndex = 4;
            this.button_MainActivity_Choice3.TabStop = false;
            this.button_MainActivity_Choice3.UseVisualStyleBackColor = true;
            this.button_MainActivity_Choice3.Click += new System.EventHandler(this.button_MainActivity_Choice3_Click);
            // 
            // button_MainActivity_Continue
            // 
            this.button_MainActivity_Continue.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MainActivity_Continue.Location = new System.Drawing.Point(491, 457);
            this.button_MainActivity_Continue.Name = "button_MainActivity_Continue";
            this.button_MainActivity_Continue.Size = new System.Drawing.Size(281, 39);
            this.button_MainActivity_Continue.TabIndex = 5;
            this.button_MainActivity_Continue.TabStop = false;
            this.button_MainActivity_Continue.Text = "Continue";
            this.button_MainActivity_Continue.UseVisualStyleBackColor = true;
            this.button_MainActivity_Continue.Visible = false;
            this.button_MainActivity_Continue.Click += new System.EventHandler(this.button_MainActivity_Continue_Click);
            // 
            // progressBar_HitPoints
            // 
            this.progressBar_HitPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar_HitPoints.ForeColor = System.Drawing.Color.Red;
            this.progressBar_HitPoints.Location = new System.Drawing.Point(156, 17);
            this.progressBar_HitPoints.Name = "progressBar_HitPoints";
            this.progressBar_HitPoints.Size = new System.Drawing.Size(143, 18);
            this.progressBar_HitPoints.TabIndex = 6;
            this.progressBar_HitPoints.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hit Points";
            // 
            // MainAdventureScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_HitPoints);
            this.Controls.Add(this.button_MainActivity_Continue);
            this.Controls.Add(this.button_MainActivity_Choice3);
            this.Controls.Add(this.button_MainActivity_Choice2);
            this.Controls.Add(this.button_MainActivity_Choice1);
            this.Controls.Add(this.textbox_MainAdventure);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainAdventureScreen";
            this.Text = "MainAdventureScreen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_MainActivity;
        private System.Windows.Forms.ToolStripMenuItem saveGame_MenuItem_MainActivity;
        private System.Windows.Forms.ToolStripMenuItem loadGame_MenuItem_MainActivity;
        private System.Windows.Forms.ToolStripMenuItem quit_MenuItem_MainActivity;
        private System.Windows.Forms.TextBox textbox_MainAdventure;
        private System.Windows.Forms.Button button_MainActivity_Choice1;
        private System.Windows.Forms.Button button_MainActivity_Choice2;
        private System.Windows.Forms.Button button_MainActivity_Choice3;
        private System.Windows.Forms.Button button_MainActivity_Continue;
        private System.Windows.Forms.ProgressBar progressBar_HitPoints;
        private System.Windows.Forms.Label label1;
    }
}