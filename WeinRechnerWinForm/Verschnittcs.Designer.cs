using System;

namespace WeinRechnerWinForm
{
    partial class Verschnittcs
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelParameterMengeGrundwein = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Export = new System.Windows.Forms.Button();
            this.Ergebnis = new System.Windows.Forms.Label();
            this.RechnungBeschreibung = new System.Windows.Forms.Label();
            this.RechnungBeschreibung1 = new System.Windows.Forms.Label();
            this.RechnungBeschreibung2 = new System.Windows.Forms.Label();
            this.prefixErgebnis1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ErgebnisMengeverschnittWein = new System.Windows.Forms.Label();
            this.EregbnisMeneSüßwein = new System.Windows.Forms.Label();
            this.ErgebnisMengeMaxMengeVerschnittWein = new System.Windows.Forms.Label();
            this.ErgebnisMaxMengeSüßreserve2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelParameterMengeGrundwein
            // 
            this.labelParameterMengeGrundwein.AutoSize = true;
            this.labelParameterMengeGrundwein.Location = new System.Drawing.Point(3, 19);
            this.labelParameterMengeGrundwein.Name = "labelParameterMengeGrundwein";
            this.labelParameterMengeGrundwein.Size = new System.Drawing.Size(119, 13);
            this.labelParameterMengeGrundwein.TabIndex = 0;
            this.labelParameterMengeGrundwein.Text = "Menge des Grundweins";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.Export);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelParameterMengeGrundwein);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 325);
            this.panel1.TabIndex = 4;
            // 
            // Export
            // 
            this.Export.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Export.Location = new System.Drawing.Point(0, 302);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(144, 23);
            this.Export.TabIndex = 4;
            this.Export.Text = "Export als Pdf";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Visible = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Ergebnis
            // 
            this.Ergebnis.AutoSize = true;
            this.Ergebnis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ergebnis.Location = new System.Drawing.Point(3, 0);
            this.Ergebnis.Name = "Ergebnis";
            this.Ergebnis.Size = new System.Drawing.Size(658, 28);
            this.Ergebnis.TabIndex = 5;
            this.Ergebnis.Text = "Ergebnis :";
            // 
            // RechnungBeschreibung
            // 
            this.RechnungBeschreibung.AutoSize = true;
            this.RechnungBeschreibung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RechnungBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechnungBeschreibung.Location = new System.Drawing.Point(3, 28);
            this.RechnungBeschreibung.Name = "RechnungBeschreibung";
            this.RechnungBeschreibung.Size = new System.Drawing.Size(658, 28);
            this.RechnungBeschreibung.TabIndex = 6;
            this.RechnungBeschreibung.Text = "1. Verschnittberechnung: Basiswein + Verschnittwein\r\n";
            // 
            // RechnungBeschreibung1
            // 
            this.RechnungBeschreibung1.AutoSize = true;
            this.RechnungBeschreibung1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RechnungBeschreibung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechnungBeschreibung1.Location = new System.Drawing.Point(3, 84);
            this.RechnungBeschreibung1.Name = "RechnungBeschreibung1";
            this.RechnungBeschreibung1.Size = new System.Drawing.Size(658, 28);
            this.RechnungBeschreibung1.TabIndex = 7;
            this.RechnungBeschreibung1.Text = "2. Verschnittberechnung: Basiswein + Süßreserve\r\n";
            // 
            // RechnungBeschreibung2
            // 
            this.RechnungBeschreibung2.AutoSize = true;
            this.RechnungBeschreibung2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RechnungBeschreibung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechnungBeschreibung2.Location = new System.Drawing.Point(3, 140);
            this.RechnungBeschreibung2.Name = "RechnungBeschreibung2";
            this.RechnungBeschreibung2.Size = new System.Drawing.Size(658, 28);
            this.RechnungBeschreibung2.TabIndex = 8;
            this.RechnungBeschreibung2.Text = "3. Verschnittberechnung: Basiswein + Verschnittwein+Süßreserve\r\n";
            // 
            // prefixErgebnis1
            // 
            this.prefixErgebnis1.AutoSize = true;
            this.prefixErgebnis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prefixErgebnis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixErgebnis1.Location = new System.Drawing.Point(3, 56);
            this.prefixErgebnis1.Name = "prefixErgebnis1";
            this.prefixErgebnis1.Size = new System.Drawing.Size(658, 28);
            this.prefixErgebnis1.TabIndex = 9;
            this.prefixErgebnis1.Text = "max Menge Verschnittwein :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "max Menge Süßwein :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(658, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "max Menge Verschnittwein :";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(658, 129);
            this.label3.TabIndex = 12;
            this.label3.Text = "max Menge Süßreserve :";
            // 
            // ErgebnisMengeverschnittWein
            // 
            this.ErgebnisMengeverschnittWein.AutoSize = true;
            this.ErgebnisMengeverschnittWein.Dock = System.Windows.Forms.DockStyle.Left;
            this.ErgebnisMengeverschnittWein.Location = new System.Drawing.Point(667, 56);
            this.ErgebnisMengeverschnittWein.Name = "ErgebnisMengeverschnittWein";
            this.ErgebnisMengeverschnittWein.Size = new System.Drawing.Size(0, 28);
            this.ErgebnisMengeverschnittWein.TabIndex = 13;
            // 
            // EregbnisMeneSüßwein
            // 
            this.EregbnisMeneSüßwein.AutoSize = true;
            this.EregbnisMeneSüßwein.Dock = System.Windows.Forms.DockStyle.Left;
            this.EregbnisMeneSüßwein.Location = new System.Drawing.Point(667, 112);
            this.EregbnisMeneSüßwein.Name = "EregbnisMeneSüßwein";
            this.EregbnisMeneSüßwein.Size = new System.Drawing.Size(0, 28);
            this.EregbnisMeneSüßwein.TabIndex = 14;
            // 
            // ErgebnisMengeMaxMengeVerschnittWein
            // 
            this.ErgebnisMengeMaxMengeVerschnittWein.AutoSize = true;
            this.ErgebnisMengeMaxMengeVerschnittWein.Dock = System.Windows.Forms.DockStyle.Left;
            this.ErgebnisMengeMaxMengeVerschnittWein.Location = new System.Drawing.Point(667, 168);
            this.ErgebnisMengeMaxMengeVerschnittWein.Name = "ErgebnisMengeMaxMengeVerschnittWein";
            this.ErgebnisMengeMaxMengeVerschnittWein.Size = new System.Drawing.Size(0, 28);
            this.ErgebnisMengeMaxMengeVerschnittWein.TabIndex = 15;
            // 
            // ErgebnisMaxMengeSüßreserve2
            // 
            this.ErgebnisMaxMengeSüßreserve2.AutoSize = true;
            this.ErgebnisMaxMengeSüßreserve2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ErgebnisMaxMengeSüßreserve2.Location = new System.Drawing.Point(667, 196);
            this.ErgebnisMaxMengeSüßreserve2.Name = "ErgebnisMaxMengeSüßreserve2";
            this.ErgebnisMaxMengeSüßreserve2.Size = new System.Drawing.Size(0, 129);
            this.ErgebnisMaxMengeSüßreserve2.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(144, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 325);
            this.panel2.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.16187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.83813F));
            this.tableLayoutPanel1.Controls.Add(this.Ergebnis, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.RechnungBeschreibung2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RechnungBeschreibung1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.RechnungBeschreibung, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.prefixErgebnis1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ErgebnisMengeverschnittWein, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EregbnisMeneSüßwein, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ErgebnisMaxMengeSüßreserve2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ErgebnisMengeMaxMengeVerschnittWein, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 325);
            this.tableLayoutPanel1.TabIndex = 17;
            this.tableLayoutPanel1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Verschnittcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Verschnittcs";
            this.Size = new System.Drawing.Size(1005, 325);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelParameterMengeGrundwein;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ergebnis;
        private System.Windows.Forms.Label RechnungBeschreibung;
        private System.Windows.Forms.Label RechnungBeschreibung1;
        private System.Windows.Forms.Label RechnungBeschreibung2;
        private System.Windows.Forms.Label prefixErgebnis1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErgebnisMengeverschnittWein;
        private System.Windows.Forms.Label EregbnisMeneSüßwein;
        private System.Windows.Forms.Label ErgebnisMengeMaxMengeVerschnittWein;
        private System.Windows.Forms.Label ErgebnisMaxMengeSüßreserve2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
