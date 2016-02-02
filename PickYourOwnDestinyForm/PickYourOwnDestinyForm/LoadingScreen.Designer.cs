namespace PickYourOwnDestiny.UI
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.Loading_TextBox = new System.Windows.Forms.RichTextBox();
            this.LoadingScreen_Continue = new System.Windows.Forms.PictureBox();
            this.LoadingScreen_Start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingScreen_Continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingScreen_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // Loading_TextBox
            // 
            this.Loading_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading_TextBox.Location = new System.Drawing.Point(172, 445);
            this.Loading_TextBox.Name = "Loading_TextBox";
            this.Loading_TextBox.Size = new System.Drawing.Size(503, 52);
            this.Loading_TextBox.TabIndex = 2;
            this.Loading_TextBox.Text = "Welcome! Please selected an option.";
            // 
            // LoadingScreen_Continue
            // 
            this.LoadingScreen_Continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadingScreen_Continue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoadingScreen_Continue.Image = global::PickYourOwnDestiny.UI.Properties.Resources.Continue;
            this.LoadingScreen_Continue.InitialImage = ((System.Drawing.Image)(resources.GetObject("LoadingScreen_Continue.InitialImage")));
            this.LoadingScreen_Continue.Location = new System.Drawing.Point(444, 57);
            this.LoadingScreen_Continue.Name = "LoadingScreen_Continue";
            this.LoadingScreen_Continue.Size = new System.Drawing.Size(325, 349);
            this.LoadingScreen_Continue.TabIndex = 1;
            this.LoadingScreen_Continue.TabStop = false;
            this.LoadingScreen_Continue.Click += new System.EventHandler(this.LoadingScreen_Continue_Click);
            // 
            // LoadingScreen_Start
            // 
            this.LoadingScreen_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadingScreen_Start.Image = global::PickYourOwnDestiny.UI.Properties.Resources.Start;
            this.LoadingScreen_Start.InitialImage = ((System.Drawing.Image)(resources.GetObject("LoadingScreen_Start.InitialImage")));
            this.LoadingScreen_Start.Location = new System.Drawing.Point(69, 57);
            this.LoadingScreen_Start.Name = "LoadingScreen_Start";
            this.LoadingScreen_Start.Size = new System.Drawing.Size(325, 349);
            this.LoadingScreen_Start.TabIndex = 0;
            this.LoadingScreen_Start.TabStop = false;
            this.LoadingScreen_Start.Click += new System.EventHandler(this.LoadingScreen_Start_Click);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 529);
            this.Controls.Add(this.Loading_TextBox);
            this.Controls.Add(this.LoadingScreen_Continue);
            this.Controls.Add(this.LoadingScreen_Start);
            this.Name = "LoadingScreen";
            this.Text = "LoadingScreen";
            ((System.ComponentModel.ISupportInitialize)(this.LoadingScreen_Continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingScreen_Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadingScreen_Start;
        private System.Windows.Forms.PictureBox LoadingScreen_Continue;
        private System.Windows.Forms.RichTextBox Loading_TextBox;
    }
}