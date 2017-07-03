﻿namespace PokemonRun
{
    partial class GymScreen
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
            this.hpLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pokemon2HpLabel = new System.Windows.Forms.Label();
            this.gymTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hpLabel
            // 
            this.hpLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hpLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hpLabel.Location = new System.Drawing.Point(524, 65);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(112, 28);
            this.hpLabel.TabIndex = 1;
            this.hpLabel.Text = "HP:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(488, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(41, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pokemon2HpLabel
            // 
            this.pokemon2HpLabel.BackColor = System.Drawing.Color.Transparent;
            this.pokemon2HpLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemon2HpLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pokemon2HpLabel.Location = new System.Drawing.Point(80, 262);
            this.pokemon2HpLabel.Name = "pokemon2HpLabel";
            this.pokemon2HpLabel.Size = new System.Drawing.Size(112, 28);
            this.pokemon2HpLabel.TabIndex = 4;
            this.pokemon2HpLabel.Text = "HP:";
            // 
            // gymTimer
            // 
            this.gymTimer.Enabled = true;
            this.gymTimer.Interval = 1000;
            this.gymTimer.Tick += new System.EventHandler(this.gymTimer_Tick);
            // 
            // GymScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonRun.Properties.Resources.Gym1;
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.pokemon2HpLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hpLabel);
            this.Name = "GymScreen";
            this.Text = "GymScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label hpLabel;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label pokemon2HpLabel;
        private System.Windows.Forms.Timer gymTimer;
    }
}