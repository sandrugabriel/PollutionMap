namespace PollutionMap.Mockups
{
    partial class MockupLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLogare = new System.Windows.Forms.Button();
            this.btnContNou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblNume.Location = new System.Drawing.Point(135, 158);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(98, 38);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.8F);
            this.lblTitlu.Location = new System.Drawing.Point(267, 32);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(136, 57);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Login";
            this.lblTitlu.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.8F);
            this.lblParola.Location = new System.Drawing.Point(135, 292);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(98, 38);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(142, 199);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(388, 38);
            this.txtNume.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(142, 333);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(388, 38);
            this.txtParola.TabIndex = 4;
            // 
            // btnLogare
            // 
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(167, 440);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(155, 64);
            this.btnLogare.TabIndex = 5;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            // 
            // btnContNou
            // 
            this.btnContNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContNou.Location = new System.Drawing.Point(337, 440);
            this.btnContNou.Name = "btnContNou";
            this.btnContNou.Size = new System.Drawing.Size(155, 64);
            this.btnContNou.TabIndex = 6;
            this.btnContNou.Text = "Cont Nou";
            this.btnContNou.UseVisualStyleBackColor = true;
            // 
            // MockupLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 640);
            this.Controls.Add(this.btnContNou);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblNume);
            this.Name = "MockupLogin";
            this.Text = "MockupLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Button btnContNou;
    }
}