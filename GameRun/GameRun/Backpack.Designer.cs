namespace GameRun
{
    partial class Backpack
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
            this.characterBox = new System.Windows.Forms.PictureBox();
            this.weaponBox = new System.Windows.Forms.PictureBox();
            this.ArmorBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArmorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // characterBox
            // 
            this.characterBox.BackColor = System.Drawing.Color.Transparent;
            this.characterBox.Image = global::GameRun.Properties.Resources.character;
            this.characterBox.Location = new System.Drawing.Point(12, -64);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(240, 417);
            this.characterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.characterBox.TabIndex = 0;
            this.characterBox.TabStop = false;
            // 
            // weaponBox
            // 
            this.weaponBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weaponBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponBox.Image = global::GameRun.Properties.Resources.Attack1;
            this.weaponBox.Location = new System.Drawing.Point(35, 268);
            this.weaponBox.Name = "weaponBox";
            this.weaponBox.Size = new System.Drawing.Size(83, 78);
            this.weaponBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weaponBox.TabIndex = 1;
            this.weaponBox.TabStop = false;
            // 
            // ArmorBox
            // 
            this.ArmorBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ArmorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArmorBox.Image = global::GameRun.Properties.Resources.Defence1;
            this.ArmorBox.Location = new System.Drawing.Point(143, 268);
            this.ArmorBox.Name = "ArmorBox";
            this.ArmorBox.Size = new System.Drawing.Size(82, 78);
            this.ArmorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArmorBox.TabIndex = 2;
            this.ArmorBox.TabStop = false;
            // 
            // Backpack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameRun.Properties.Resources.Backpack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 352);
            this.Controls.Add(this.ArmorBox);
            this.Controls.Add(this.weaponBox);
            this.Controls.Add(this.characterBox);
            this.Name = "Backpack";
            this.Text = "Backbag";
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArmorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox characterBox;
        private System.Windows.Forms.PictureBox weaponBox;
        private System.Windows.Forms.PictureBox ArmorBox;
    }
}