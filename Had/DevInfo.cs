using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Had
{
    
    public partial class DevInfo : Form
    {
        Form1 data;
        public DevInfo(Form1 parent)
        {
            InitializeComponent();
            data = parent;
            data.DataSent += Aktualizuj;
            //Point Start = this.Location;
            //this.Location = new Point(Start.X =- 0, Start.Y =- 0);
        }

        private void Aktualizuj(string msg)
        {
            string type = msg.Split(' ')[0];
            string data = msg.Split(' ')[1];

            if (type == "Skore")
            {
                lblScore.Text = data;
            }
            else if (type == "Head")
            {
                lblHL.Text = data;
            }
            else if (type == "Food")
            {
                lblFL.Text = data;
            }
            else if (type == "Lenght")
            {
                lblLenght.Text = data;
            }
        }

        private void DevInfo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
