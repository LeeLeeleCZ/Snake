using static Had.smìr;

namespace Had
{
    public delegate void DataSentHandler(string msg);
    public partial class Form1 : Form
    {
        public event DataSentHandler DataSent;

        int skore = 0;
        hlava head = new hlava(Color.Purple, 400, 400);
        Jídlo food = new Jídlo();
        bool DeveloperInfo = true;
        DevInfo devInfo;
        List<Telo> telo = new List<Telo>();
        public Form1()
        {
            InitializeComponent();
            Controls.Add(head);
            Controls.Add(food);
            if(DeveloperInfo)
            {
                devInfo = new DevInfo(this);
                devInfo.Show();
                Point point = food.Location;
                DataSent("Food " + Convert.ToString(point.X / 10) + ";" + Convert.ToString(point.Y / 10));
            }
            PøidatDíl();
            PøidatDíl();
        }

        void PøidatDíl()
        {
            Telo lbl = new Telo();
            lbl.AutoSize = false;
            lbl.Width = 20;
            lbl.Height = 20;
            lbl.BackColor = Color.Blue;
            if(telo.Count == 0)
                lbl.Location = head.Location;
            else
            {
                lbl.Location = telo.Last().Location;
            }
            telo.Add(lbl);
            Controls.Add(lbl);
            DataSent("Lenght " + Convert.ToString(telo.Count));
        }

        private void PohybTela()
        {
            int i = 0;
            foreach(Telo lbl in telo)
            {
                lbl.StaraLokace = lbl.Location;
                if (lbl == telo.First())
                    lbl.Location = head.StaraLokace;
                else
                {
                    lbl.Location = telo[i - 1].StaraLokace;
                }   
                i++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            head.StaraLokace = head.Location;
            switch(head.Smer)
            {
                case smer.nahoru:
                    head.Y -= 20;
                    break;
                case smer.doprava:
                    head.X += 20;
                    break;
                case smer.dolu:
                    head.Y += 20;
                    break;
                case smer.doleva:
                    head.X -= 20;
                    break;
                default:
                    break;
            }
            PohybTela();
            Point point = head.Location;
            DataSent("Head "+Convert.ToString(point.X / 10) +";"+ Convert.ToString(point.Y / 10));
            if (head.X < 0 || head.X > 760 || head.Y < 0 || head.Y > 740)
            {
                timer1.Enabled = false;
                MessageBox.Show("Prohráli jste!" + "\n" + $"Vaše skóre: {skore}");
                Application.Restart();
                Environment.Exit(0);
            }
            if(head.Location == food.Location)
            {
                skore++;
                PøidatDíl();
                food.Next();
                point = food.Location;
                DataSent("Food "+Convert.ToString(point.X/10)+";"+Convert.ToString(point.Y/10));
                DataSent("Skore " + Convert.ToString(skore));
            }
            this.Text = Convert.ToString(skore);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            switch(e.KeyCode)
            {
                case Keys.Up:
                    if(head.Smer != smer.dolu)
                        head.Smer = smer.nahoru;
                    break;
                case Keys.Down:
                    if (head.Smer != smer.nahoru)
                        head.Smer = smer.dolu;
                    break;
                case Keys.Right:
                    if (head.Smer != smer.doleva)
                        head.Smer = smer.doprava;
                    break;
                case Keys.Left:
                    if (head.Smer != smer.doprava)
                        head.Smer = smer.doleva;
                    break;
            }
        }
    }
}