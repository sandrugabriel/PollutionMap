namespace PollutionMap.Mockups
{
    partial class MockupVizualizare
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
            this.tabControl.SuspendLayout();
            this.tabHarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHarta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHarta);
            this.tabControl.Controls.Add(this.tabTraseu);
            this.tabControl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1257, 690);
            this.tabControl.TabIndex = 0;
            // 
            // tabHarta
            // 
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
            this.tabHarta.Name = "tabHarta";
            this.tabHarta.Padding = new System.Windows.Forms.Padding(3);
            this.tabHarta.Size = new System.Drawing.Size(1249, 654);
            this.tabHarta.TabIndex = 0;
            this.tabHarta.Text = "Harta";
            this.tabHarta.UseVisualStyleBackColor = true;
            // 
            // tabTraseu
            // 
            this.tabTraseu.Location = new System.Drawing.Point(4, 32);
            this.tabTraseu.Name = "tabTraseu";
            this.tabTraseu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraseu.Size = new System.Drawing.Size(1249, 654);
            this.tabTraseu.TabIndex = 1;
            this.tabTraseu.Text = "Traseu";
            this.tabTraseu.UseVisualStyleBackColor = true;
            // 
            // cmbHarta
            // 
            this.cmbHarta.FormattingEnabled = true;
            this.cmbHarta.Location = new System.Drawing.Point(20, 109);
            this.cmbHarta.Name = "cmbHarta";
            this.cmbHarta.Size = new System.Drawing.Size(293, 31);
            this.cmbHarta.TabIndex = 0;
            this.cmbHarta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblHarta
            // 
            this.lblHarta.AutoSize = true;
            this.lblHarta.Location = new System.Drawing.Point(20, 83);
            this.lblHarta.Name = "lblHarta";
            this.lblHarta.Size = new System.Drawing.Size(51, 23);
            this.lblHarta.TabIndex = 1;
            this.lblHarta.Text = "Harta";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(20, 219);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(293, 30);
            this.dateTime.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(20, 193);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 23);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // cmbFiltru
            // 
            this.cmbFiltru.FormattingEnabled = true;
            this.cmbFiltru.Location = new System.Drawing.Point(20, 350);
            this.cmbFiltru.Name = "cmbFiltru";
            this.cmbFiltru.Size = new System.Drawing.Size(293, 31);
            this.cmbFiltru.TabIndex = 4;
            this.cmbFiltru.Text = "Nici un filtru";
            // 
            // lblFiltru
            // 
            this.lblFiltru.AutoSize = true;
            this.lblFiltru.Location = new System.Drawing.Point(20, 314);
            this.lblFiltru.Name = "lblFiltru";
            this.lblFiltru.Size = new System.Drawing.Size(44, 23);
            this.lblFiltru.TabIndex = 5;
            this.lblFiltru.Text = "Fitru";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12.2F);
            this.lblUtilizator.Location = new System.Drawing.Point(20, 17);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(109, 28);
            this.lblUtilizator.TabIndex = 6;
            this.lblUtilizator.Text = "Utilizator: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(65, 439);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 50);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reseteaza filtru";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // pctHarta
            // 
            this.pctHarta.Location = new System.Drawing.Point(346, 0);
            this.pctHarta.Name = "pctHarta";
            this.pctHarta.Size = new System.Drawing.Size(903, 654);
            this.pctHarta.TabIndex = 8;
            this.pctHarta.TabStop = false;
            // 
            // btnFiltru
            // 
            this.btnFiltru.Location = new System.Drawing.Point(65, 495);
            this.btnFiltru.Name = "btnFiltru";
            this.btnFiltru.Size = new System.Drawing.Size(147, 50);
            this.btnFiltru.TabIndex = 9;
            this.btnFiltru.Text = "Filtreaza";
            this.btnFiltru.UseVisualStyleBackColor = true;
            // 
            // MockupVizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 710);
            this.Controls.Add(this.tabControl);
            this.Name = "MockupVizualizare";
            this.Text = "MockupVizualizare";
            this.tabControl.ResumeLayout(false);
            this.tabHarta.ResumeLayout(false);
            this.tabHarta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHarta;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lblHarta;
        private System.Windows.Forms.ComboBox cmbHarta;
        private System.Windows.Forms.TabPage tabTraseu;
        private System.Windows.Forms.Button btnFiltru;
        private System.Windows.Forms.PictureBox pctHarta;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblFiltru;
        private System.Windows.Forms.ComboBox cmbFiltru;
        private System.Windows.Forms.Label lblData;
    }
}