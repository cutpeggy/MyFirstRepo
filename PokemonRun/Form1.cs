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
        private Random random = new Random();
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
            Pokemon pokemon = Game.Generate();
            pokemons.Add(pokemon);
            PokemonBox pokemonBox = new PokemonBox(pokemon);
            pokemonBox.Size = new Size(200, 266);
            int x = random.Next(0, this.Width - pokemonBox.Width + 1);
            int y = random.Next(0, this.Height - pokemonBox.Height + 1);
            pokemonBox.Render(new Point(x, y));

            Controls.Add(pokemonBox);
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