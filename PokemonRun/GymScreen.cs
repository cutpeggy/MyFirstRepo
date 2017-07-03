using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRunLibrary;

namespace PokemonRun
{
    public partial class GymScreen : Form
    {
        private Pokemon pokemon1;
        private Pokemon pokemon2;

        public GymScreen()
        {
            InitializeComponent();
        }

        public void Render(Pokemon pokemon)
        {
            this.pokemon1 = pokemon;
            this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon.ImageFileName);
            this.pokemon2 = PokemonFactory.Create(2);
            this.pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon2.ImageFileName);
            this.hpLabel.Text = "HP: " + pokemon1.CurrentHP;
        }

        private void gymTimer_Tick(object sender, EventArgs e)
        {
            pokemon2.CurrentHP -= 3;
            this.pokemon2HpLabel.Text = "HP: " + pokemon2.CurrentHP;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pokemon1.CurrentHP -= 3;
            this.hpLabel.Text = "HP: " + pokemon1.CurrentHP;
        }
    }
}