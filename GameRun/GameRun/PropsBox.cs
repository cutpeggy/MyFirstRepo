using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameRunLibrary;
using EasyMathLibrary;

namespace GameRun
{
    public partial class PropsBox : UserControl
    {
        public PropsBox()
        {
            InitializeComponent();
        }

        public PropsBox(string name)
        {
            InitializeComponent();
            this.Name = name;
            this.Render(this.Name);
        }

        public void Render(string Name)
        {
            this.Name = Name;
            this.pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(Name);
            this.TabIndex = 0;
            this.Size = new Size(100, 100);
        }
    }
}