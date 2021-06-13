
namespace Speiseplan
{
    partial class frmSpeiseplan
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
            this.lvSpeisen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvZutaten = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblZutaten = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speisenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatenlisteÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wochenspeiseplanÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSpeisen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSpeisen
            // 
            this.lvSpeisen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2});
            this.lvSpeisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvSpeisen.HideSelection = false;
            this.lvSpeisen.Location = new System.Drawing.Point(16, 130);
            this.lvSpeisen.Margin = new System.Windows.Forms.Padding(4);
            this.lvSpeisen.Name = "lvSpeisen";
            this.lvSpeisen.Size = new System.Drawing.Size(648, 450);
            this.lvSpeisen.TabIndex = 0;
            this.lvSpeisen.UseCompatibleStateImageBehavior = false;
            this.lvSpeisen.View = System.Windows.Forms.View.Details;
            this.lvSpeisen.Click += new System.EventHandler(this.lvSpeisen_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bild";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bezeichnung";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Speiseart";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preis";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bildpfad";
            this.columnHeader2.Width = 133;
            // 
            // lvZutaten
            // 
            this.lvZutaten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10});
            this.lvZutaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvZutaten.HideSelection = false;
            this.lvZutaten.Location = new System.Drawing.Point(716, 130);
            this.lvZutaten.Margin = new System.Windows.Forms.Padding(4);
            this.lvZutaten.Name = "lvZutaten";
            this.lvZutaten.Size = new System.Drawing.Size(648, 450);
            this.lvZutaten.TabIndex = 1;
            this.lvZutaten.UseCompatibleStateImageBehavior = false;
            this.lvZutaten.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bezeichnung";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Einheit";
            this.columnHeader9.Width = 83;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kategorie";
            this.columnHeader10.Width = 95;
            // 
            // lblZutaten
            // 
            this.lblZutaten.AutoSize = true;
            this.lblZutaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblZutaten.Location = new System.Drawing.Point(712, 96);
            this.lblZutaten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZutaten.Name = "lblZutaten";
            this.lblZutaten.Size = new System.Drawing.Size(64, 20);
            this.lblZutaten.TabIndex = 2;
            this.lblZutaten.Text = "Zutaten";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speisenToolStripMenuItem,
            this.zutatenToolStripMenuItem,
            this.wochenspeiseplanÖffnenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1389, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speisenToolStripMenuItem
            // 
            this.speisenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.speisenToolStripMenuItem.Name = "speisenToolStripMenuItem";
            this.speisenToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.speisenToolStripMenuItem.Text = "Speise";
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.löschenToolStripMenuItem.Text = "Entfernen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // zutatenToolStripMenuItem
            // 
            this.zutatenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem1,
            this.entfernenToolStripMenuItem,
            this.zutatenlisteÖffnenToolStripMenuItem});
            this.zutatenToolStripMenuItem.Name = "zutatenToolStripMenuItem";
            this.zutatenToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.zutatenToolStripMenuItem.Text = "Zutat";
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(321, 26);
            this.hinzufügenToolStripMenuItem1.Text = "Zutat der Speise hinzufügen";
            this.hinzufügenToolStripMenuItem1.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem1_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.entfernenToolStripMenuItem.Text = "Zutat aus der Speise entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // zutatenlisteÖffnenToolStripMenuItem
            // 
            this.zutatenlisteÖffnenToolStripMenuItem.Name = "zutatenlisteÖffnenToolStripMenuItem";
            this.zutatenlisteÖffnenToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.zutatenlisteÖffnenToolStripMenuItem.Text = "Zutatenliste öffnen";
            this.zutatenlisteÖffnenToolStripMenuItem.Click += new System.EventHandler(this.zutatenlisteÖffnenToolStripMenuItem_Click);
            // 
            // wochenspeiseplanÖffnenToolStripMenuItem
            // 
            this.wochenspeiseplanÖffnenToolStripMenuItem.Name = "wochenspeiseplanÖffnenToolStripMenuItem";
            this.wochenspeiseplanÖffnenToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.wochenspeiseplanÖffnenToolStripMenuItem.Text = "Wochenspeiseplan öffnen";
            this.wochenspeiseplanÖffnenToolStripMenuItem.Click += new System.EventHandler(this.wochenspeiseplanÖffnenToolStripMenuItem_Click);
            // 
            // lblSpeisen
            // 
            this.lblSpeisen.AutoSize = true;
            this.lblSpeisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpeisen.Location = new System.Drawing.Point(16, 96);
            this.lblSpeisen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeisen.Name = "lblSpeisen";
            this.lblSpeisen.Size = new System.Drawing.Size(69, 20);
            this.lblSpeisen.TabIndex = 4;
            this.lblSpeisen.Text = "Speisen";
            // 
            // frmSpeiseplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 642);
            this.Controls.Add(this.lblSpeisen);
            this.Controls.Add(this.lblZutaten);
            this.Controls.Add(this.lvZutaten);
            this.Controls.Add(this.lvSpeisen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSpeiseplan";
            this.Text = "Speiseplan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSpeiseplan_FormClosing);
            this.Load += new System.EventHandler(this.frmSpeiseplan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvZutaten;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label lblZutaten;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speisenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wochenspeiseplanÖffnenToolStripMenuItem;
        private System.Windows.Forms.Label lblSpeisen;
        private System.Windows.Forms.ToolStripMenuItem zutatenlisteÖffnenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ListView lvSpeisen;
    }
}

