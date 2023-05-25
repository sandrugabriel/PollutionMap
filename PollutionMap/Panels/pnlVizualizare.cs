using PollutionMap.Controllers;
using PollutionMap.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap.Panels
{
    internal class pnlVizualizare : Panel
    {

        Form1 form;
        Utilizator utilizator;

        TabControl tabControl;
        TabPage tabHarta;
        DateTimePicker dateTime;
        Label lblHarta;
        ComboBox cmbHarta;
        TabPage tabTraseu;
        Button btnFiltru;
        PictureBox pctHarta;
        Button btnReset;
        Label lblUtilizator;
        Label lblFiltru;
        ComboBox cmbFiltru;
        Label lblData;
        PictureBox pctHartaTraseu;

        string path;
        int idHarta = 0;

        ControllerMasuri controllerMasuri;
        List<Masurare> masurareList;

        public pnlVizualizare(Form1 form1, Utilizator utilizator1)
        {
            this.Refresh();
            form = form1;
            utilizator = utilizator1;
            this.form.Size = new System.Drawing.Size(1286, 710);
            path = Application.StartupPath + @"/Harti/";
            controllerMasuri = new ControllerMasuri();
            masurareList = new List<Masurare>();
            this.SendToBack();

            // pnlVizualizare
            this.Size = new System.Drawing.Size(1286, 710);
            this.Controls.Add(this.tabControl);
            this.Name = "pnlVizualizare";

            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHarta = new System.Windows.Forms.TabPage();
            this.tabTraseu = new System.Windows.Forms.TabPage();
            this.cmbHarta = new System.Windows.Forms.ComboBox();
            this.lblHarta = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbFiltru = new System.Windows.Forms.ComboBox();
            this.lblFiltru = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pctHarta = new System.Windows.Forms.PictureBox();
            this.btnFiltru = new System.Windows.Forms.Button();
            this.pctHartaTraseu = new System.Windows.Forms.PictureBox();

            this.Controls.Add(tabControl);

            // tabControl
            this.tabControl.Controls.Add(this.tabHarta);
            this.tabControl.Controls.Add(this.tabTraseu);
            this.tabControl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Size = new System.Drawing.Size(1257, 690);
            this.tabControl.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);

            // tabHarta
            this.tabHarta.Controls.Add(this.btnFiltru);
            this.tabHarta.Controls.Add(this.pctHarta);
            this.tabHarta.Controls.Add(this.btnReset);
            this.tabHarta.Controls.Add(this.lblUtilizator);
            this.tabHarta.Controls.Add(this.lblFiltru);
            this.tabHarta.Controls.Add(this.cmbFiltru);
            this.tabHarta.Controls.Add(this.lblData);
            this.tabHarta.Controls.Add(this.dateTime);
            this.tabHarta.Controls.Add(this.lblHarta);
            this.tabHarta.Controls.Add(this.cmbHarta);
            this.tabHarta.Location = new System.Drawing.Point(4, 32);
            this.tabHarta.Padding = new System.Windows.Forms.Padding(3);
            this.tabHarta.Size = new System.Drawing.Size(1249, 654);
            this.tabHarta.Text = "Harta";
          
            // tabTraseu
            this.tabTraseu.Controls.Add(this.pctHartaTraseu);
            this.tabTraseu.Location = new System.Drawing.Point(4, 32);
            this.tabTraseu.Size = new System.Drawing.Size(1249, 654);
            this.tabTraseu.Text = "Traseu";
            
            // pctHartaTraseu
            this.pctHartaTraseu.Location = new System.Drawing.Point(0, 0);
            this.pctHartaTraseu.Size = new System.Drawing.Size(1249, 654);
            this.pctHartaTraseu.SizeMode = PictureBoxSizeMode.StretchImage;

            // cmbHarta
            this.cmbHarta.Location = new System.Drawing.Point(20, 109);
            this.cmbHarta.Size = new System.Drawing.Size(293, 31);
            this.cmbHarta.SelectedIndexChanged += new System.EventHandler(this.cmbHarta_SelectedIndexChanged);
            this.cmbHarta.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbHarta.Text = "Default";
            this.cmbHarta.Items.Add("Default");
            this.cmbHarta.Items.Add("Harta Bucuresti");
            this.cmbHarta.Items.Add("Harta Cluj");
            this.cmbHarta.Items.Add("Harta Constanta");
            this.cmbHarta.Items.Add("Harta Iasi");
            this.cmbHarta.Items.Add("Harta Sibiu");
            this.cmbHarta.SelectedIndex = 0;


            // lblHarta
            this.lblHarta.AutoSize = true;
            this.lblHarta.Location = new System.Drawing.Point(20, 83);
            this.lblHarta.Size = new System.Drawing.Size(51, 23);
            this.lblHarta.Text = "Harta";

            // dateTime
            this.dateTime.Location = new System.Drawing.Point(20, 219);
            this.dateTime.Size = new System.Drawing.Size(293, 30);
            this.dateTime.Value = new DateTime(2022, 05, 15);

            // lblData
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(20, 193);
            this.lblData.Size = new System.Drawing.Size(45, 23);
            this.lblData.Text = "Data";

            // cmbFiltru
            this.cmbFiltru.Location = new System.Drawing.Point(20, 350);
            this.cmbFiltru.Size = new System.Drawing.Size(293, 31);
            this.cmbFiltru.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFiltru.SelectedIndexChanged += new System.EventHandler(this.cmbFiltru_SelectedIndexChanged);
            this.cmbFiltru.Text = "Nici un filtru";
            this.cmbFiltru.Items.Add("Nici un filtru");
            this.cmbFiltru.Items.Add("Valoarea < 20");
            this.cmbFiltru.Items.Add("20 <= Valoarea <= 40");
            this.cmbFiltru.Items.Add("Valoarea > 40");
            this.cmbFiltru.SelectedIndex = 0;

            // lblFiltru
            this.lblFiltru.AutoSize = true;
            this.lblFiltru.Location = new System.Drawing.Point(20, 314);
            this.lblFiltru.Size = new System.Drawing.Size(44, 23);
            this.lblFiltru.Text = "Fitru";

            // lblUtilizator
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12.2F);
            this.lblUtilizator.Location = new System.Drawing.Point(20, 17);
            this.lblUtilizator.Size = new System.Drawing.Size(109, 28);
            this.lblUtilizator.Text = "Utilizator: "+utilizator.getName();

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(65, 439);
            this.btnReset.Size = new System.Drawing.Size(147, 50);
            this.btnReset.Text = "Reseteaza filtru";
            this.btnReset.Click += new EventHandler(btnReset_Click);

            // pctHarta
            this.pctHarta.Location = new System.Drawing.Point(346, 0);
            this.pctHarta.Size = new System.Drawing.Size(903, 654);
            this.pctHarta.Image = Image.FromFile(path + "default_harta.png");
            this.pctHarta.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctHarta.Paint += new PaintEventHandler(pctHarta_Paint);
            this.pctHarta.MouseClick += new MouseEventHandler(pctHarta_MouseClick);

            // btnFiltru
            this.btnFiltru.Location = new System.Drawing.Point(65, 495);
            this.btnFiltru.Size = new System.Drawing.Size(147, 50);
            this.btnFiltru.Text = "Filtreaza";
            this.btnFiltru.Click += new EventHandler(btnFiltru_Click);
        }

        private void pctHarta_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            foreach (Masurare masurare in masurareList)
            {
                int x = masurare.getPozX() - 20;
                int y = masurare.getPozY() - 20;
                //MessageBox.Show(masurare.getValoaremasurare().ToString());
                int textX = x + 5;
                int textY = y + 15;

                if (masurare.getValoaremasurare() < 20)
                {
                    g.DrawString(masurare.getValoaremasurare().ToString(), new Font("Arial", 12), Brushes.Green, textX, textY);
                    g.DrawEllipse(Pens.Green, x, y, 40, 40);

                }

                if (masurare.getValoaremasurare() >= 20 && masurare.getValoaremasurare() <= 40)
                {
                    g.DrawString(masurare.getValoaremasurare().ToString(), new Font("Arial", 12), Brushes.Orange, textX, textY);
                    g.DrawEllipse(Pens.Orange, x, y, 40, 40);

                }

                if (masurare.getValoaremasurare() > 40)
                {
                    g.DrawString(masurare.getValoaremasurare().ToString(), new Font("Arial", 12), Brushes.Red, textX, textY);
                    g.DrawEllipse(Pens.Red, x, y, 40, 40);

                }


            }


        
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabTraseu)
            {
                MessageBox.Show("Alege cu mouse-ul un punct de pe harta care sa\r\ncorespunda unei masurari existente in baza de date ca punct de plecare pentru\r\ndesenarea traseului de lungime minima, care sa treaca o singura data prin cele\r\nmai poluate 2 puncte desenate pe harta !\r\n","Traseu",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.pctHartaTraseu.Image = this.pctHarta.Image;
            }
        }

        private void cmbHarta_SelectedIndexChanged(object sender, EventArgs e)
        {

            string select = cmbHarta.SelectedItem.ToString();

            if (select == "Default")
            {
                masurareList.Clear();
                masurareList = new List<Masurare>();
                pctHarta.Image = Image.FromFile(path + "default_harta.png");
            }
            else
            {
                string text = select.Substring(select.LastIndexOf(' ') + 1).ToLower();
                pctHarta.Image = Image.FromFile(path + "harta_" + text + ".png");
                if (text == "bucuresti") idHarta = 1;
                if (text == "cluj") idHarta = 2;
                if (text == "constanta") idHarta = 3;
                if (text == "iasi") idHarta = 4;
                if (text == "sibiu") idHarta = 5;

                masurareList = controllerMasuri.getMasurare(idHarta, dateTime.Value);
                pctHarta.Refresh();
            }

        }

        private void cmbFiltru_SelectedIndexChanged(object sender, EventArgs e)
        {
            masurareList.Clear();
            if (cmbFiltru.SelectedItem.ToString() == "Nici un filtru")
            {

                masurareList = controllerMasuri.getMasurare(idHarta, dateTime.Value);
                
            }

            if (cmbFiltru.SelectedItem.ToString() == "Valoarea < 20")
            {

                masurareList = controllerMasuri.getMasurareVal20(idHarta, dateTime.Value);
                /*for (int i = 0; i < masurareList.Count; i++)
                {
                    MessageBox.Show(masurareList[i].getValoaremasurare().ToString());
                }*/
            }

            if (cmbFiltru.SelectedItem.ToString() == "20 <= Valoarea <= 40")
            {

                masurareList = controllerMasuri.getMasurareVal2040(idHarta, dateTime.Value);
            }

            if (cmbFiltru.SelectedItem.ToString() == "Valoarea > 40")
            {

                masurareList = controllerMasuri.getMasurareVal40(idHarta, dateTime.Value);
            }

        }

        private void btnFiltru_Click(object sender, EventArgs e)
        {

            pctHarta.Refresh();


        }

        private void btnReset_Click(object sender, EventArgs e) {

            masurareList = controllerMasuri.getMasurare(idHarta, dateTime.Value);
            pctHarta.Refresh();


        }

        private bool eroare(int pozx, int pozy)
        {

            foreach(Masurare masurare in masurareList)
            {

                if(masurare.getPozX() == pozx && masurare.getPozY() == pozy)
                {
                    return false;
                }

            }

            return true;
        }

        private void pctHarta_MouseClick(object sender, MouseEventArgs e)
        {

                int pozx = e.X;
                int pozy = e.Y;
            if (cmbHarta.SelectedItem.ToString() != "Default" && eroare(pozx, pozy))
            {
                this.form.Controls.Add(new pnlAddMasurare(form, utilizator, pozx, pozy, idHarta, dateTime.Value));
                this.form.removepnl("pnlVizualizare");
            }
           
        }

    }
}
