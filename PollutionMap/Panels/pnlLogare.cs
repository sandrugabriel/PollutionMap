using PollutionMap.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap.Panels
{
    internal class pnlLogare:Panel
    {

        private Label lblNume;
        private Label lblTitlu;
        private Label lblParola;
        private TextBox txtNume;
        private TextBox txtParola;
        private Button btnLogare;
        private Button btnContNou;

        Form1 form;
        ControllerUtilizator controllerUtilizator;

        public pnlLogare(Form1 form1) {

            form = form1;
            controllerUtilizator = new ControllerUtilizator();
            this.form.Size = new System.Drawing.Size(725, 640);
            Random random = new Random();
            int nr = random.Next(1,20);
            // pnlLogin
            this.Size = new System.Drawing.Size(725, 640);
            string path = "/Background/back" + nr.ToString() + ".jpg";
            this.BackgroundImage = Image.FromFile(Application.StartupPath + path);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Name = "pnlLogare";
            this.Text = "Login";

            this.lblNume = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLogare = new System.Windows.Forms.Button();
            this.btnContNou = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnContNou);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblNume);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblNume.Location = new System.Drawing.Point(135, 158);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(98, 38);
            this.lblNume.Text = "Nume";
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.8F);
            this.lblTitlu.Location = new System.Drawing.Point(267, 32);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(136, 57);
            this.lblTitlu.Text = "Login";

            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblParola.Location = new System.Drawing.Point(135, 292);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(98, 38);
            this.lblParola.Text = "Parola";
             
            // txtNume
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.txtNume.Location = new System.Drawing.Point(142, 199);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(388, 38);
            
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.txtParola.Location = new System.Drawing.Point(142, 333);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(388, 38);
            
            // btnLogare
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.btnLogare.Location = new System.Drawing.Point(167, 440);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(155, 64);
            this.btnLogare.Text = "Logare";
            this.btnLogare.Click += new EventHandler(btnLogare_Click);
             
            // btnContNou
            this.btnContNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.btnContNou.Location = new System.Drawing.Point(337, 440);
            this.btnContNou.Name = "btnContNou";
            this.btnContNou.Size = new System.Drawing.Size(155, 64);
            this.btnContNou.Text = "Cont Nou";
            this.btnContNou.Click += new EventHandler(btnContNou_Click);



        }

        private void btnLogare_Click(object sender, EventArgs e)
        {

            if (controllerUtilizator.verification(txtParola.Text, txtNume.Text))
            {

                int id = controllerUtilizator.idBynamePass(txtParola.Text, txtNume.Text);
                string name = txtNume.Text;
                string pass = txtParola.Text;
                string email = controllerUtilizator.emailBynamePass(txtParola.Text, txtNume.Text);
                controllerUtilizator.setDateTime(id,DateTime.Now);
                controllerUtilizator.update();
                this.form.removepnl("pnlLogare");
            }
            else
            {

                MessageBox.Show("Nume de utilizator si/sau parola invalida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Text = "";
                txtParola.Text = "";

            }

        }

        private void btnContNou_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlLogare");
            this.form.Controls.Add(new pnlContNou(form));

        }

    }
}
