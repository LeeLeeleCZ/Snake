using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Had
{
    internal class Jídlo : Label
    {
        public Color barva = Color.Red;
        Random rnd = new Random();

        private int x;
        private int y;
        public Jídlo()
        {
            x = rnd.Next(2, 40) * 20;
            y = rnd.Next(2, 40) * 20;
            this.BackColor = barva;
            this.AutoSize = false;
            this.Width = 20;
            this.Height = 20;
            this.Location = new Point(x, y);
        }

        public void Next()
        {
            x = rnd.Next(0, 39) * 20;
            y = rnd.Next(0, 38) * 20;
            this.Location = new Point(x, y);
        }
    }
}
