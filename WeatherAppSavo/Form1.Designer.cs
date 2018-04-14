namespace WeatherAppSavo
{
    partial class Form1
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
            this.lDrzava = new System.Windows.Forms.Label();
            this.lGrad = new System.Windows.Forms.Label();
            this.pbSlikaPravcaVetra = new System.Windows.Forms.PictureBox();
            this.lPritisak = new System.Windows.Forms.Label();
            this.lBrzinaVetra = new System.Windows.Forms.Label();
            this.lTemperaturaMax = new System.Windows.Forms.Label();
            this.lTemperaturaMin = new System.Windows.Forms.Label();
            this.lTemperatura = new System.Windows.Forms.Label();
            this.lOpis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaPravcaVetra)).BeginInit();
            this.SuspendLayout();
            // 
            // lDrzava
            // 
            this.lDrzava.AutoSize = true;
            this.lDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDrzava.Location = new System.Drawing.Point(53, 59);
            this.lDrzava.Name = "lDrzava";
            this.lDrzava.Size = new System.Drawing.Size(134, 39);
            this.lDrzava.TabIndex = 1;
            this.lDrzava.Text = "Drzava";
            // 
            // lGrad
            // 
            this.lGrad.AutoSize = true;
            this.lGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrad.Location = new System.Drawing.Point(212, 59);
            this.lGrad.Name = "lGrad";
            this.lGrad.Size = new System.Drawing.Size(98, 39);
            this.lGrad.TabIndex = 2;
            this.lGrad.Text = "Grad";
            // 
            // pbSlikaPravcaVetra
            // 
            this.pbSlikaPravcaVetra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbSlikaPravcaVetra.Location = new System.Drawing.Point(60, 323);
            this.pbSlikaPravcaVetra.Name = "pbSlikaPravcaVetra";
            this.pbSlikaPravcaVetra.Size = new System.Drawing.Size(155, 155);
            this.pbSlikaPravcaVetra.TabIndex = 9;
            this.pbSlikaPravcaVetra.TabStop = false;
            // 
            // lPritisak
            // 
            this.lPritisak.AutoSize = true;
            this.lPritisak.Location = new System.Drawing.Point(255, 444);
            this.lPritisak.Name = "lPritisak";
            this.lPritisak.Size = new System.Drawing.Size(86, 13);
            this.lPritisak.TabIndex = 24;
            this.lPritisak.Text = "Vazdusni pritisak";
            // 
            // lBrzinaVetra
            // 
            this.lBrzinaVetra.AutoSize = true;
            this.lBrzinaVetra.Location = new System.Drawing.Point(255, 418);
            this.lBrzinaVetra.Name = "lBrzinaVetra";
            this.lBrzinaVetra.Size = new System.Drawing.Size(63, 13);
            this.lBrzinaVetra.TabIndex = 23;
            this.lBrzinaVetra.Text = "Brzina vetra";
            // 
            // lTemperaturaMax
            // 
            this.lTemperaturaMax.AutoSize = true;
            this.lTemperaturaMax.Location = new System.Drawing.Point(255, 387);
            this.lTemperaturaMax.Name = "lTemperaturaMax";
            this.lTemperaturaMax.Size = new System.Drawing.Size(90, 13);
            this.lTemperaturaMax.TabIndex = 22;
            this.lTemperaturaMax.Text = "Temperatura Max";
            // 
            // lTemperaturaMin
            // 
            this.lTemperaturaMin.AutoSize = true;
            this.lTemperaturaMin.Location = new System.Drawing.Point(255, 352);
            this.lTemperaturaMin.Name = "lTemperaturaMin";
            this.lTemperaturaMin.Size = new System.Drawing.Size(87, 13);
            this.lTemperaturaMin.TabIndex = 21;
            this.lTemperaturaMin.Text = "Temperatura Min";
            // 
            // lTemperatura
            // 
            this.lTemperatura.AutoSize = true;
            this.lTemperatura.Location = new System.Drawing.Point(255, 323);
            this.lTemperatura.Name = "lTemperatura";
            this.lTemperatura.Size = new System.Drawing.Size(67, 13);
            this.lTemperatura.TabIndex = 20;
            this.lTemperatura.Text = "Temperatura";
            // 
            // lOpis
            // 
            this.lOpis.AutoSize = true;
            this.lOpis.Location = new System.Drawing.Point(259, 469);
            this.lOpis.Name = "lOpis";
            this.lOpis.Size = new System.Drawing.Size(28, 13);
            this.lOpis.TabIndex = 25;
            this.lOpis.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(131, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(214, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(131, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(26, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "W";
            // 
            // cbGrad
            // 
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Location = new System.Drawing.Point(541, 31);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(161, 21);
            this.cbGrad.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Grad";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(743, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 56);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Preuzmi informacije za grad";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 539);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGrad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lOpis);
            this.Controls.Add(this.lPritisak);
            this.Controls.Add(this.lBrzinaVetra);
            this.Controls.Add(this.lTemperaturaMax);
            this.Controls.Add(this.lTemperaturaMin);
            this.Controls.Add(this.lTemperatura);
            this.Controls.Add(this.pbSlikaPravcaVetra);
            this.Controls.Add(this.lGrad);
            this.Controls.Add(this.lDrzava);
            this.Name = "Form1";
            this.Text = "Vremenska prognoza by Savo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaPravcaVetra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDrzava;
        private System.Windows.Forms.Label lGrad;
        private System.Windows.Forms.PictureBox pbSlikaPravcaVetra;
        private System.Windows.Forms.Label lPritisak;
        private System.Windows.Forms.Label lBrzinaVetra;
        private System.Windows.Forms.Label lTemperaturaMax;
        private System.Windows.Forms.Label lTemperaturaMin;
        private System.Windows.Forms.Label lTemperatura;
        private System.Windows.Forms.Label lOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
    }
}

