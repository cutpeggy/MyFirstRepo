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

        public void Render(Point location)
        {
            this.BackColor = Color.Transparent;
            this.Name = pokemon.Name;
            this.Location = location;
            this.TabIndex = 0;

            this.LinkLabel.Text = pokemon.Name;
            this.PictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon.ImageFileName);
        }

        private void PokemonBox_Click(object sender, EventArgs e)
        {
            BattleScreen battleScreen = new BattleScreen();
            battleScreen.battleTitleLabel.Text = "發現野生的" + pokemon.Name;
            battleScreen.pokemonBox.PictureBox.Image = this.PictureBox.Image;
            battleScreen.pokemonBox.LinkLabel.Text = "CP " + pokemon.CP;
            battleScreen.Show();
        }
    }
}