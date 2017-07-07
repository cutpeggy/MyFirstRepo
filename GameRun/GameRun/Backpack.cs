using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameRunLibrary;

namespace GameRun
{
    public partial class Backpack : Form
    {
        private Player player = new Player();
        private Point start = new Point(275, 10);
        private int gutter = 15;
        private int numberOfColumn = 3;

        public Backpack()
        {
            InitializeComponent();

            for (int index = 0; index < player.PropsName.Count; index++)
            {
                PropsBox propsBox = new PropsBox(player.PropsName[index]);
                propsBox.Size = new Size(100, 100);
                int x = start.X + (index % numberOfColumn) * (propsBox.Width + gutter);
                int y = start.Y + (index / numberOfColumn) * (propsBox.Height + gutter);
                propsBox.Location = new Point(x, y);
            }
        }
    }
}