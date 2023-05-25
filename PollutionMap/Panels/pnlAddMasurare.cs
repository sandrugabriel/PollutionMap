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
    internal class pnlAddMasurare:Panel
    {
        Label lblMasurare;
        TextBox txtMasurare;
        Form1 form;
        ControllerMasuri controllerMasuri;
        Button btnAdd;
        int pozX, poY, idHarta;
        DateTime dateTime;
        Utilizator utilizator;
        Button btnCancel;
        public pnlAddMasurare(Form1 form1, Utilizator utilizator1 , int pozx, int poy, int idHarta1, DateTime dateTime1) {
        
            form = form1;
            controllerMasuri = new ControllerMasuri();
            pozX = pozx;
            dateTime = dateTime1;
            poY = poy;
            utilizator = utilizator1;
            idHarta = idHarta1;
            this.form.Size = new System.Drawing.Size(260, 260);
            this.form.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(260,260);
            this.BringToFront();
            this.Location = new Point(20,20);
            this.Name = "pnlAddMasurare";
            this.Font = new Font("Microsoft YaHei UI Light", 12);
        
            this.lblMasurare = new Label();
            this.txtMasurare = new TextBox();
            this.btnAdd = new Button();
            this.btnCancel = new Button();
        
            this.Controls.Add(this.lblMasurare);
            this.Controls.Add(this.txtMasurare);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);

            //lblMasurare
            this.lblMasurare.Location = new System.Drawing.Point(20, 5);
            this.lblMasurare.Text = "Masurare";
            this.lblMasurare.AutoSize = true;

            //txtMasurare
            this.txtMasurare.Location = new System.Drawing.Point(20,45);
            this.txtMasurare.Size = new System.Drawing.Size(90,30);
        
            //BtnAdd
            this.btnAdd.AutoSize = true;
            this.btnAdd.Text = "Add masurare";
            this.btnAdd.Location = new System.Drawing.Point(20,90);
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            //BtnCancel
            this.btnCancel.AutoSize = true;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(20, 130);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                this.form.removepnl("pnlAddMasurare");
                this.form.Controls.Add(new pnlVizualizare(form, utilizator));
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMasurare != null)
            {

            string textul = controllerMasuri.generareId().ToString() + "#" + idHarta.ToString() + "#" + pozX.ToString() + "#" + poY.ToString() + "#" + txtMasurare.Text + "#" + dateTime.ToString();
            controllerMasuri.save(textul);
            this.Visible = false;
                this.form.removepnl("pnlAddMasurare");
                this.form.Controls.Add(new pnlVizualizare(form,utilizator));
            }

        }

    }
}
