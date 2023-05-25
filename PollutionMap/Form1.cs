using PollutionMap.Models;
using PollutionMap.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utilizator utilizator1 = new Utilizator("1432787538#Gabi#Gabi1234!#gabi@gmail.com#5/25/2023 12:16:21 PM");
            this.Controls.Add(new pnlVizualizare(this,utilizator1));
        }

        public void removepnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }

    }
}
