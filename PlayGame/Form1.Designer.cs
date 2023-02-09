namespace PlayGame
{
    partial class SuperAwesomeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAwesomeGame));
            this.StartButton = new System.Windows.Forms.Button();
            this.SuperAwesomeGameTitle = new System.Windows.Forms.Label();
            this.CowPng = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CowPng)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Green;
            this.StartButton.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(188, 246);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(435, 87);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SuperAwesomeGameTitle
            // 
            this.SuperAwesomeGameTitle.AutoSize = true;
            this.SuperAwesomeGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.SuperAwesomeGameTitle.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperAwesomeGameTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SuperAwesomeGameTitle.Location = new System.Drawing.Point(74, 81);
            this.SuperAwesomeGameTitle.Name = "SuperAwesomeGameTitle";
            this.SuperAwesomeGameTitle.Size = new System.Drawing.Size(650, 63);
            this.SuperAwesomeGameTitle.TabIndex = 1;
            this.SuperAwesomeGameTitle.Text = "Super Awesome Game Title";
            this.SuperAwesomeGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SuperAwesomeGameTitle.Click += new System.EventHandler(this.SuperAwesomeGameTitle_Click);
            // 
            // CowPng
            // 
            this.CowPng.Image = global::PlayGame.Properties.Resources.Cow;
            this.CowPng.Location = new System.Drawing.Point(291, 135);
            this.CowPng.Name = "CowPng";
            this.CowPng.Size = new System.Drawing.Size(192, 218);
            this.CowPng.TabIndex = 2;
            this.CowPng.TabStop = false;
            this.CowPng.Visible = false;
            // 
            // SuperAwesomeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SuperAwesomeGameTitle);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CowPng);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuperAwesomeGame";
            this.Text = "SuperAwesomeGame";
            ((System.ComponentModel.ISupportInitialize)(this.CowPng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label SuperAwesomeGameTitle;
        private System.Windows.Forms.PictureBox CowPng;
    }
}

