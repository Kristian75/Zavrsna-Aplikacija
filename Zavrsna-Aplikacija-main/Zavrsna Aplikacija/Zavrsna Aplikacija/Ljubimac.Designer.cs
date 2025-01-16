namespace Zavrsna_Aplikacija
{
    partial class FormaLjubimac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtPasmina = new System.Windows.Forms.TextBox();
            this.txtPosjetiVeterinaru = new System.Windows.Forms.TextBox();
            this.dtpDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumCijepljenja = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(127, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(127, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(127, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasmina:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(127, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum Rođenja:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(127, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum Cijepljenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(127, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Posjeti Veterinaru:";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(194, 92);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(594, 44);
            this.txtIme.TabIndex = 6;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVrsta.Location = new System.Drawing.Point(225, 145);
            this.txtVrsta.Margin = new System.Windows.Forms.Padding(4);
            this.txtVrsta.Multiline = true;
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(563, 44);
            this.txtVrsta.TabIndex = 7;
            // 
            // txtPasmina
            // 
            this.txtPasmina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPasmina.Location = new System.Drawing.Point(240, 195);
            this.txtPasmina.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasmina.Multiline = true;
            this.txtPasmina.Name = "txtPasmina";
            this.txtPasmina.Size = new System.Drawing.Size(548, 44);
            this.txtPasmina.TabIndex = 8;
            // 
            // txtPosjetiVeterinaru
            // 
            this.txtPosjetiVeterinaru.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPosjetiVeterinaru.Location = new System.Drawing.Point(394, 359);
            this.txtPosjetiVeterinaru.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosjetiVeterinaru.Multiline = true;
            this.txtPosjetiVeterinaru.Name = "txtPosjetiVeterinaru";
            this.txtPosjetiVeterinaru.Size = new System.Drawing.Size(394, 44);
            this.txtPosjetiVeterinaru.TabIndex = 9;
            // 
            // dtpDatumRodenja
            // 
            this.dtpDatumRodenja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumRodenja.Location = new System.Drawing.Point(329, 252);
            this.dtpDatumRodenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumRodenja.Name = "dtpDatumRodenja";
            this.dtpDatumRodenja.Size = new System.Drawing.Size(457, 36);
            this.dtpDatumRodenja.TabIndex = 10;
            // 
            // dtpDatumCijepljenja
            // 
            this.dtpDatumCijepljenja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumCijepljenja.Location = new System.Drawing.Point(381, 308);
            this.dtpDatumCijepljenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumCijepljenja.Name = "dtpDatumCijepljenja";
            this.dtpDatumCijepljenja.Size = new System.Drawing.Size(407, 36);
            this.dtpDatumCijepljenja.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(353, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormaLjubimac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDatumCijepljenja);
            this.Controls.Add(this.dtpDatumRodenja);
            this.Controls.Add(this.txtPosjetiVeterinaru);
            this.Controls.Add(this.txtPasmina);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaLjubimac";
            this.Text = "FormaLjubimac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtPasmina;
        private System.Windows.Forms.TextBox txtPosjetiVeterinaru;
        private System.Windows.Forms.DateTimePicker dtpDatumRodenja;
        private System.Windows.Forms.DateTimePicker dtpDatumCijepljenja;
        private System.Windows.Forms.Button button1;
    }
}