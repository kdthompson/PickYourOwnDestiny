namespace PickYourOwnDestiny.UI
{
    partial class CharacterCreation
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
            this.gbRace = new System.Windows.Forms.GroupBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.rbW = new System.Windows.Forms.RadioButton();
            this.rbR = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.tbKnow = new System.Windows.Forms.TextBox();
            this.tbDex = new System.Windows.Forms.TextBox();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCharName = new System.Windows.Forms.TextBox();
            this.gbRace.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRace
            // 
            this.gbRace.Controls.Add(this.rbD);
            this.gbRace.Controls.Add(this.rbE);
            this.gbRace.Controls.Add(this.rbH);
            this.gbRace.Location = new System.Drawing.Point(74, 68);
            this.gbRace.Name = "gbRace";
            this.gbRace.Size = new System.Drawing.Size(124, 169);
            this.gbRace.TabIndex = 21;
            this.gbRace.TabStop = false;
            // 
            // rbD
            // 
            this.rbD.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(28, 117);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(45, 23);
            this.rbD.TabIndex = 2;
            this.rbD.TabStop = true;
            this.rbD.Text = "Dwarf";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // rbE
            // 
            this.rbE.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbE.AutoSize = true;
            this.rbE.Location = new System.Drawing.Point(28, 77);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(29, 23);
            this.rbE.TabIndex = 1;
            this.rbE.TabStop = true;
            this.rbE.Text = "Elf";
            this.rbE.UseVisualStyleBackColor = true;
            this.rbE.CheckedChanged += new System.EventHandler(this.rbE_CheckedChanged);
            // 
            // rbH
            // 
            this.rbH.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(28, 38);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(51, 23);
            this.rbH.TabIndex = 0;
            this.rbH.TabStop = true;
            this.rbH.Text = "Human";
            this.rbH.UseVisualStyleBackColor = true;
            this.rbH.CheckedChanged += new System.EventHandler(this.rbH_CheckedChanged);
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.rbW);
            this.gbClass.Controls.Add(this.rbR);
            this.gbClass.Controls.Add(this.rbM);
            this.gbClass.Location = new System.Drawing.Point(253, 77);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(110, 152);
            this.gbClass.TabIndex = 20;
            this.gbClass.TabStop = false;
            // 
            // rbW
            // 
            this.rbW.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbW.AutoSize = true;
            this.rbW.Location = new System.Drawing.Point(13, 111);
            this.rbW.Name = "rbW";
            this.rbW.Size = new System.Drawing.Size(51, 23);
            this.rbW.TabIndex = 2;
            this.rbW.TabStop = true;
            this.rbW.Text = "Warrior";
            this.rbW.UseVisualStyleBackColor = true;
            this.rbW.CheckedChanged += new System.EventHandler(this.rbW_CheckedChanged);
            // 
            // rbR
            // 
            this.rbR.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbR.AutoSize = true;
            this.rbR.Location = new System.Drawing.Point(13, 71);
            this.rbR.Name = "rbR";
            this.rbR.Size = new System.Drawing.Size(52, 23);
            this.rbR.TabIndex = 1;
            this.rbR.TabStop = true;
            this.rbR.Text = "Ranger";
            this.rbR.UseVisualStyleBackColor = true;
            this.rbR.CheckedChanged += new System.EventHandler(this.rbR_CheckedChanged);
            // 
            // rbM
            // 
            this.rbM.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(13, 32);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(44, 23);
            this.rbM.TabIndex = 0;
            this.rbM.TabStop = true;
            this.rbM.Text = "Mage";
            this.rbM.UseVisualStyleBackColor = true;
            this.rbM.CheckedChanged += new System.EventHandler(this.rbM_CheckedChanged);
            // 
            // tbKnow
            // 
            this.tbKnow.Enabled = false;
            this.tbKnow.Location = new System.Drawing.Point(328, 306);
            this.tbKnow.Name = "tbKnow";
            this.tbKnow.Size = new System.Drawing.Size(100, 20);
            this.tbKnow.TabIndex = 19;
            // 
            // tbDex
            // 
            this.tbDex.Enabled = false;
            this.tbDex.Location = new System.Drawing.Point(208, 306);
            this.tbDex.Name = "tbDex";
            this.tbDex.Size = new System.Drawing.Size(100, 20);
            this.tbDex.TabIndex = 18;
            // 
            // tbStrength
            // 
            this.tbStrength.Enabled = false;
            this.tbStrength.Location = new System.Drawing.Point(77, 306);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.Size = new System.Drawing.Size(100, 20);
            this.tbStrength.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Knowledge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dexterity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Strength";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Character Name";
            // 
            // tbCharName
            // 
            this.tbCharName.Location = new System.Drawing.Point(142, 19);
            this.tbCharName.Name = "tbCharName";
            this.tbCharName.Size = new System.Drawing.Size(283, 20);
            this.tbCharName.TabIndex = 24;
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 416);
            this.Controls.Add(this.tbCharName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbRace);
            this.Controls.Add(this.gbClass);
            this.Controls.Add(this.tbKnow);
            this.Controls.Add(this.tbDex);
            this.Controls.Add(this.tbStrength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CharacterCreation";
            this.Text = "CharacterCreation";
            this.gbRace.ResumeLayout(false);
            this.gbRace.PerformLayout();
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRace;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbE;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.RadioButton rbW;
        private System.Windows.Forms.RadioButton rbR;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox tbKnow;
        private System.Windows.Forms.TextBox tbDex;
        private System.Windows.Forms.TextBox tbStrength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCharName;
    }
}