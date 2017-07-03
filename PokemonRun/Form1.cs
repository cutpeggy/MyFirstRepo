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
using EasyMathLibrary;

namespace PokemonRun
{
    public partial class Form1 : Form  //partial讓一個類別可以拆分成好幾個
    {
        private GameController Game = new GameController();
        private List<Pokemon> pokemons = new List<Pokemon>();

        public Form1()//建構式
        {
            InitializeComponent();
            Game.Initailize();
        }

        /*public Form1() : this(0){}
         會等於
         public Form1()
         {
            this.x = 0
            Inittaliz...();
         }*/

        private void GeneratePokemonBox()
        {
            // 在隨機地點產生隨機pokemonBox
            Pokemon pokemon = PokemonFactory.Generate();
            pokemons.Add(pokemon);
            PokemonBox pokemonBox = new PokemonBox(pokemon);
            pokemonBox.Render(this.Size);
            this.Controls.Add(pokemonBox);
        }

        //每隔多少秒會執行一次
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pokemons.Count < 10)
            {
                GeneratePokemonBox();
            }
        }

        private void pokemonBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("遇見野生的寶可夢");
        }
    }
}