namespace PokemonRun
{
    partial class BattleScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.battleTitleLabel = new System.Windows.Forms.Label();
            this.pokemonBox = new PokemonRun.PokemonBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokemonRun.Properties.Resources.Ball;
            this.pictureBox1.Location = new System.Drawing.Point(304, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // battleTitleLabel
            // 
            this.battleTitleLabel.AutoSize = true;
            this.battleTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.battleTitleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.battleTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.battleTitleLabel.Location = new System.Drawing.Point(270, 97);
            this.battleTitleLabel.Name = "battleTitleLabel";
            this.battleTitleLabel.Size = new System.Drawing.Size(82, 31);
            this.battleTitleLabel.TabIndex = 2;
            this.battleTitleLabel.Text = "label1";
            // 
            // pokemonBox
            // 
            this.pokemonBox.BackColor = System.Drawing.Color.Transparent;
            this.pokemonBox.Location = new System.Drawing.Point(285, 131);
            this.pokemonBox.Name = "pokemonBox";
            this.pokemonBox.Size = new System.Drawing.Size(170, 215);
            this.pokemonBox.TabIndex = 3;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonRun.Properties.Resources.battle_sun;
            this.ClientSize = new System.Drawing.Size(751, 479);
            this.Controls.Add(this.pokemonBox);
            this.Controls.Add(this.battleTitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BattleScreen";
            this.Text = "BattleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label battleTitleLabel;
        public PokemonBox pokemonBox;
    }
}