
namespace Speiseplan
{
    partial class frmZutatenliste
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
            this.components = new System.ComponentModel.Container();
            this.lvZutaten = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zutatHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvZutaten
            // 
            this.lvZutaten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader1});
            this.lvZutaten.ContextMenuStrip = this.contextMenuStrip1;
            this.lvZutaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvZutaten.HideSelection = false;
            this.lvZutaten.Location = new System.Drawing.Point(43, 25);
            this.lvZutaten.Margin = new System.Windows.Forms.Padding(4);
            this.lvZutaten.Name = "lvZutaten";
            this.lvZutaten.Size = new System.Drawing.Size(619, 450);
            this.lvZutaten.TabIndex = 2;
            this.lvZutaten.UseCompatibleStateImageBehavior = false;
            this.lvZutaten.View = System.Windows.Forms.View.Details;
            this.lvZutaten.DoubleClick += new System.EventHandler(this.lvZutaten_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bezeichnung";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Einheit";
            this.columnHeader9.Width = 113;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategorie";
            this.columnHeader1.Width = 97;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zutatHinzufügenToolStripMenuItem,
            this.zutatBearbeitenToolStripMenuItem,
            this.zutatEntfernenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 76);
            // 
            // zutatHinzufügenToolStripMenuItem
            // 
            this.zutatHinzufügenToolStripMenuItem.Name = "zutatHinzufügenToolStripMenuItem";
            this.zutatHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.zutatHinzufügenToolStripMenuItem.Text = "Zutat hinzufügen";
            this.zutatHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.zutatHinzufügenToolStripMenuItem_Click);
            // 
            // zutatBearbeitenToolStripMenuItem
            // 
            this.zutatBearbeitenToolStripMenuItem.Name = "zutatBearbeitenToolStripMenuItem";
            this.zutatBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.zutatBearbeitenToolStripMenuItem.Text = "Zutat bearbeiten";
            this.zutatBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.zutatBearbeitenToolStripMenuItem_Click);
            // 
            // zutatEntfernenToolStripMenuItem
            // 
            this.zutatEntfernenToolStripMenuItem.Name = "zutatEntfernenToolStripMenuItem";
            this.zutatEntfernenToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.zutatEntfernenToolStripMenuItem.Text = "Zutat entfernen";
            this.zutatEntfernenToolStripMenuItem.Click += new System.EventHandler(this.zutatEntfernenToolStripMenuItem_Click);
            // 
            // frmZutatenliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.Controls.Add(this.lvZutaten);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmZutatenliste";
            this.Text = "Liste aller Zutaten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmZutatenliste_FormClosing);
            this.Load += new System.EventHandler(this.frmZutatenliste_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zutatHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatEntfernenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ListView lvZutaten;
    }
}