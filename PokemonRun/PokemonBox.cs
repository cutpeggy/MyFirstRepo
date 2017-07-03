using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRunLibrary;

namespace PokemonRun
{
    public partial class PokemonBox : UserControl
    {
        public Pokemon pokemon;

        public PokemonBox()
        {
            InitializeComponent();
        }

        public PokemonBox(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
        }

        public void Render(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            this.Name = pokemon.Name;

            this.cpLabel.Text = pokemon.Name;
            this.PictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon.ImageFileName);
        }

        public void Render(Size formSize)
        {
            this.BackColor = Color.Transparent;
            this.Name = pokemon.Name;
            this.TabIndex = 0;

            this.cpLabel.Text = pokemon.Name;
            this.PictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon.ImageFileName);

            this.Size = new Size(170, 215);
            int x = Pokemon.RandomGenerator.Next(0, formSize.Width - this.Width + 1);
            int y = Pokemon.RandomGenerator.Next(0, formSize.Height - this.Height + 1);
            this.Location = new Point(x, y);
        }

        private void PokemonBox_Click(object sender, EventArgs e)
        {
            BattleScreen battleScreen = new BattleScreen();
            battleScreen.battleTitleLabel.Text = "發現野生的" + pokemon.Name;
            battleScreen.pokemonBox.PictureBox.Image = this.PictureBox.Image;
            battleScreen.pokemonBox.cpLabel.Text = "CP " + pokemon.CP;
            battleScreen.Show();
        }
    }
}