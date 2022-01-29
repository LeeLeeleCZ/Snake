using static Had.směr;

namespace Had
{
    internal class hlava : Label
    {
        Color barva { get; set; }

        private smer _Smer = smer.nikam;
        public smer Smer {
            get { return _Smer; }
            set { _Smer = value; }
        }

        private int x;
        private int y;
        public Point StaraLokace { get; set; }

        public int X {
            get { return x; }
            set {
                x = value;
                Location = new Point(x, y);
            }
        }

        public int Y
        {
            get { return y; }
            set { 
                y = value; 
                Location = new Point(x, y); 
            }
        }

        public hlava(Color barva, int x, int y)
        {
            this.AutoSize = false;
            this.Width = 20;
            this.Height = 20;
            this.barva = barva;
            this.x = x;
            this.y = y;

            this.Location = new Point(x, y);

            this.BackColor = this.barva;
        }
    }
}
