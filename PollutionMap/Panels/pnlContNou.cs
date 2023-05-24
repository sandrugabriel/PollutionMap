using PollutionMap.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PollutionMap.Panels
{
    internal class pnlContNou : Panel
    {
        Form1 form;

        private Label lblNume;
        private Label lblTitlu;
        private Label lblParola;
        private TextBox txtNume;
        private TextBox txtParola;
        private Button btnSanvare;
        private Button btnBack;
        private TextBox txtParolaConf;
        private Label lblparolaConf;
        private TextBox txtEmail;
        private Label lblEmail;

        List<string> erori;

        ControllerUtilizator controllerUtilizator;

        public pnlContNou(Form1 form1)
        {

            form = form1;
            erori = new List<string>();
            controllerUtilizator = new ControllerUtilizator();

            // MockupLogin
            this.form.Size = new System.Drawing.Size(760, 804);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Size = new System.Drawing.Size(760, 804);
            this.Name = "MockupLogin";
            this.Text = "MockupLogin";

            this.lblNume = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnSanvare = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtParolaConf = new System.Windows.Forms.TextBox();
            this.lblparolaConf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();

            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtParolaConf);
            this.Controls.Add(this.lblparolaConf);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSanvare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblNume);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblNume.Location = new System.Drawing.Point(166, 142);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(92, 36);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.8F);
            this.lblTitlu.Location = new System.Drawing.Point(242, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(208, 57);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Cont nou";
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblParola.Location = new System.Drawing.Point(167, 382);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(94, 36);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
             
            // txtNume
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(173, 183);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(388, 38);
            this.txtNume.TabIndex = 3;
             
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(174, 423);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(388, 38);
            this.txtParola.TabIndex = 4;
             
            // btnSanvare
            this.btnSanvare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanvare.Location = new System.Drawing.Point(200, 685);
            this.btnSanvare.Name = "btnSanvare";
            this.btnSanvare.Size = new System.Drawing.Size(155, 64);
            this.btnSanvare.TabIndex = 5;
            this.btnSanvare.Text = "Salvare";
            this.btnSanvare.UseVisualStyleBackColor = true;
            this.btnSanvare.Click += new EventHandler(btnSanvare_Click); 

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(370, 685);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 64);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Renunta";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new EventHandler(btnBack_Click); 

            // txtParolaConf
            this.txtParolaConf.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParolaConf.Location = new System.Drawing.Point(173, 556);
            this.txtParolaConf.Name = "txtParolaConf";
            this.txtParolaConf.Size = new System.Drawing.Size(388, 38);
            this.txtParolaConf.TabIndex = 8;
            
            // lblparolaConf
            this.lblparolaConf.AutoSize = true;
            this.lblparolaConf.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblparolaConf.Location = new System.Drawing.Point(166, 515);
            this.lblparolaConf.Name = "lblparolaConf";
            this.lblparolaConf.Size = new System.Drawing.Size(243, 36);
            this.lblparolaConf.TabIndex = 7;
            this.lblparolaConf.Text = "Confirmare Parola";
            
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(173, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 38);
            this.txtEmail.TabIndex = 10;
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblEmail.Location = new System.Drawing.Point(166, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 36);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
          

        }

        private void errors()
        {
            erori.Clear();

            if (txtNume.Text.Equals(""))
            {
                erori.Add("You have not entered the username");
            }


            if (txtEmail.Text.Equals(""))
            {
                erori.Add("You have not entered the email");
            }

            if (txtParola.Text.Equals(""))
            {
                erori.Add("You have not entered the password");
            }
            else
            {
                if (controllerUtilizator.verificationPassword(txtParola.Text) == false)
                {
                    txtParola.Focus();
                    erori.Add("Password is invalid");

                }

                if (txtParola.Text.Equals(txtParolaConf.Text))
                {
                    erori.Add("Password does not match");
                }

            }


        }

        private void btnSanvare_Click(object sender, EventArgs e)
        {


            errors();

            if (erori.Count > 0)
            {
                for (int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {


                int id = controllerUtilizator.generareId();
                string name = txtNume.Text;
                string password = txtParola.Text;
                string email = txtEmail.Text;

                string textul = id.ToString() + "#" + name + "#" + password + "#" + email + "#" + DateTime.Now.ToString();

                controllerUtilizator.save(textul);

                controllerUtilizator.load();

            }


        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlContNou");
            this.form.Controls.Add(new pnlLogare(form));

        }



    }
}
