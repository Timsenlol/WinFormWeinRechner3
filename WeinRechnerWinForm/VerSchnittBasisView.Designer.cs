namespace WeinRechnerWinForm
{
    partial class VerSchnittBasisView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRestzuckerSüßreserve = new System.Windows.Forms.Label();
            this.textBoxRestzuckerBasiswein = new System.Windows.Forms.TextBox();
            this.labelRestzuckerBasiswein = new System.Windows.Forms.Label();
            this.textBoxMengeBasiswein = new System.Windows.Forms.TextBox();
            this.labelMengeBasiswein = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelRestzuckerSüßreserve);
            this.panel1.Controls.Add(this.textBoxRestzuckerBasiswein);
            this.panel1.Controls.Add(this.labelRestzuckerBasiswein);
            this.panel1.Controls.Add(this.textBoxMengeBasiswein);
            this.panel1.Controls.Add(this.labelMengeBasiswein);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 600);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wieviel Restzucker soll der \r\nfertige Verschnitt haben?";
            // 
            // labelRestzuckerSüßreserve
            // 
            this.labelRestzuckerSüßreserve.AutoSize = true;
            this.labelRestzuckerSüßreserve.Location = new System.Drawing.Point(7, 160);
            this.labelRestzuckerSüßreserve.Name = "labelRestzuckerSüßreserve";
            this.labelRestzuckerSüßreserve.Size = new System.Drawing.Size(141, 26);
            this.labelRestzuckerSüßreserve.TabIndex = 4;
            this.labelRestzuckerSüßreserve.Text = "Wie hoch ist der Restzucker\r\nder Süßreserver?";
            // 
            // textBoxRestzuckerBasiswein
            // 
            this.textBoxRestzuckerBasiswein.Location = new System.Drawing.Point(7, 114);
            this.textBoxRestzuckerBasiswein.Name = "textBoxRestzuckerBasiswein";
            this.textBoxRestzuckerBasiswein.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestzuckerBasiswein.TabIndex = 3;
            // 
            // labelRestzuckerBasiswein
            // 
            this.labelRestzuckerBasiswein.AutoSize = true;
            this.labelRestzuckerBasiswein.Location = new System.Drawing.Point(4, 74);
            this.labelRestzuckerBasiswein.Name = "labelRestzuckerBasiswein";
            this.labelRestzuckerBasiswein.Size = new System.Drawing.Size(142, 26);
            this.labelRestzuckerBasiswein.TabIndex = 2;
            this.labelRestzuckerBasiswein.Text = "Wie hoch ist der \r\nRestzucker des Basisweins?";
            // 
            // textBoxMengeBasiswein
            // 
            this.textBoxMengeBasiswein.Location = new System.Drawing.Point(4, 47);
            this.textBoxMengeBasiswein.Name = "textBoxMengeBasiswein";
            this.textBoxMengeBasiswein.Size = new System.Drawing.Size(100, 20);
            this.textBoxMengeBasiswein.TabIndex = 1;
            // 
            // labelMengeBasiswein
            // 
            this.labelMengeBasiswein.AutoSize = true;
            this.labelMengeBasiswein.Location = new System.Drawing.Point(0, 17);
            this.labelMengeBasiswein.Name = "labelMengeBasiswein";
            this.labelMengeBasiswein.Size = new System.Drawing.Size(122, 26);
            this.labelMengeBasiswein.TabIndex = 0;
            this.labelMengeBasiswein.Text = "Wie hoch ist die Menge \r\ndes Basisweins?\r\n";
            // 
            // VerSchnittBasisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VerSchnittBasisView";
            this.Size = new System.Drawing.Size(1005, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMengeBasiswein;
        private System.Windows.Forms.TextBox textBoxRestzuckerBasiswein;
        private System.Windows.Forms.Label labelRestzuckerBasiswein;
        private System.Windows.Forms.TextBox textBoxMengeBasiswein;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRestzuckerSüßreserve;
    }
}
