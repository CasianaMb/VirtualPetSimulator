namespace VirtualPetSimulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblHunger = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblHappiness = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarHunger = new System.Windows.Forms.ProgressBar();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarHappiness = new System.Windows.Forms.ProgressBar();
            this.rbtnDog = new System.Windows.Forms.RadioButton();
            this.rbtnCat = new System.Windows.Forms.RadioButton();
            this.comboBoxPlayMode = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHunger
            // 
            this.lblHunger.AutoSize = true;
            this.lblHunger.Location = new System.Drawing.Point(23, 120);
            this.lblHunger.Name = "lblHunger";
            this.lblHunger.Size = new System.Drawing.Size(62, 20);
            this.lblHunger.TabIndex = 0;
            this.lblHunger.Text = "Hunger";
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(23, 160);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(59, 20);
            this.lblEnergy.TabIndex = 1;
            this.lblEnergy.Text = "Energy";
            // 
            // lblHappiness
            // 
            this.lblHappiness.AutoSize = true;
            this.lblHappiness.Location = new System.Drawing.Point(23, 200);
            this.lblHappiness.Name = "lblHappiness";
            this.lblHappiness.Size = new System.Drawing.Size(85, 20);
            this.lblHappiness.TabIndex = 2;
            this.lblHappiness.Text = "Happiness";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(592, 113);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 34);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(592, 160);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(98, 34);
            this.btnFeed.TabIndex = 4;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(592, 209);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(98, 34);
            this.btnSleep.TabIndex = 5;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarHunger
            // 
            this.progressBarHunger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBarHunger.Location = new System.Drawing.Point(169, 120);
            this.progressBarHunger.Name = "progressBarHunger";
            this.progressBarHunger.Size = new System.Drawing.Size(150, 20);
            this.progressBarHunger.TabIndex = 8;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBarEnergy.Location = new System.Drawing.Point(169, 160);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(150, 20);
            this.progressBarEnergy.TabIndex = 9;
            // 
            // progressBarHappiness
            // 
            this.progressBarHappiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBarHappiness.Location = new System.Drawing.Point(169, 200);
            this.progressBarHappiness.Name = "progressBarHappiness";
            this.progressBarHappiness.Size = new System.Drawing.Size(150, 20);
            this.progressBarHappiness.TabIndex = 10;
            // 
            // rbtnDog
            // 
            this.rbtnDog.AutoSize = true;
            this.rbtnDog.Location = new System.Drawing.Point(386, 297);
            this.rbtnDog.Name = "rbtnDog";
            this.rbtnDog.Size = new System.Drawing.Size(64, 24);
            this.rbtnDog.TabIndex = 11;
            this.rbtnDog.TabStop = true;
            this.rbtnDog.Text = "Dog";
            this.rbtnDog.UseVisualStyleBackColor = true;
            this.rbtnDog.CheckedChanged += new System.EventHandler(this.rbtnDog_CheckedChanged);
            // 
            // rbtnCat
            // 
            this.rbtnCat.AutoSize = true;
            this.rbtnCat.Location = new System.Drawing.Point(481, 297);
            this.rbtnCat.Name = "rbtnCat";
            this.rbtnCat.Size = new System.Drawing.Size(59, 24);
            this.rbtnCat.TabIndex = 12;
            this.rbtnCat.TabStop = true;
            this.rbtnCat.Text = "Cat";
            this.rbtnCat.UseVisualStyleBackColor = true;
            this.rbtnCat.CheckedChanged += new System.EventHandler(this.rbtnCat_CheckedChanged);
            // 
            // comboBoxPlayMode
            // 
            this.comboBoxPlayMode.FormattingEnabled = true;
            this.comboBoxPlayMode.Location = new System.Drawing.Point(705, 117);
            this.comboBoxPlayMode.Name = "comboBoxPlayMode";
            this.comboBoxPlayMode.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPlayMode.TabIndex = 13;
            this.comboBoxPlayMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayMode_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.comboBoxPlayMode);
            this.Controls.Add(this.rbtnCat);
            this.Controls.Add(this.rbtnDog);
            this.Controls.Add(this.progressBarHappiness);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarHunger);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblHappiness);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.lblHunger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHunger;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblHappiness;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarHunger;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarHappiness;
        private System.Windows.Forms.RadioButton rbtnDog;
        private System.Windows.Forms.RadioButton rbtnCat;
        private System.Windows.Forms.ComboBox comboBoxPlayMode;
        private System.Windows.Forms.Timer timer1;
    }
}

