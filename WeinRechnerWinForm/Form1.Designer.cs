namespace WeinRechnerWinForm
{
    partial class Weinrechner
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weinrechner));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboAuswahlRechnung = new System.Windows.Forms.ToolStripComboBox();
            this.InfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutzungsbedingungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboAuswahlRechnung,
            this.InfoItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboAuswahlRechnung
            // 
            this.comboAuswahlRechnung.Items.AddRange(new object[] {
            "Verschnitt gernerell",
            "Verschnitt Basis"});
            this.comboAuswahlRechnung.Name = "comboAuswahlRechnung";
            this.comboAuswahlRechnung.Size = new System.Drawing.Size(140, 40);
            this.comboAuswahlRechnung.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChangedcomboAuswahlRechnung);
            // 
            // InfoItem
            // 
            this.InfoItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.InfoItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressumToolStripMenuItem,
            this.nutzungsbedingungenToolStripMenuItem});
            this.InfoItem.Name = "InfoItem";
            this.InfoItem.Size = new System.Drawing.Size(40, 40);
            this.InfoItem.Text = "Info";
            // 
            // impressumToolStripMenuItem
            // 
            this.impressumToolStripMenuItem.Name = "impressumToolStripMenuItem";
            this.impressumToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.impressumToolStripMenuItem.Text = "Impressum";
            this.impressumToolStripMenuItem.Click += new System.EventHandler(this.impressumToolStripMenuItem_Click);
            // 
            // nutzungsbedingungenToolStripMenuItem
            // 
            this.nutzungsbedingungenToolStripMenuItem.Name = "nutzungsbedingungenToolStripMenuItem";
            this.nutzungsbedingungenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nutzungsbedingungenToolStripMenuItem.Text = "Nutzungsbedingungen";
            this.nutzungsbedingungenToolStripMenuItem.Click += new System.EventHandler(this.nutzungsbedingungenToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(989, 561);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 1;
            // 
            // Weinrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 561);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Weinrechner";
            this.Text = "Weinrechner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox comboAuswahlRechnung;
        private System.Windows.Forms.ToolStripMenuItem InfoItem;
        private System.Windows.Forms.ToolStripMenuItem impressumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutzungsbedingungenToolStripMenuItem;
        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}

