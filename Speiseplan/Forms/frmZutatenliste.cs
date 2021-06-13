using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speiseplan
{
    public partial class frmZutatenliste : Form
    {
        internal static frmZutatenliste frmZListe;
        public frmZutatenliste()
        {
            frmZListe = this;
            InitializeComponent();
        }

        int inde;
        ListViewItem lvItem;

        private void frmZutatenliste_Load(object sender, EventArgs e)
        {
            lvZutaten.FullRowSelect = true;
            lvZutaten.Items.Clear();
            foreach (Zutat z in frmSpeiseplan.frmSpPlan.zutatenliste)
            {
                lvItem = new ListViewItem(z.Bezeichung);
                lvItem.SubItems.Add(z.Einheit);
                lvItem.SubItems.Add(z.Kategorie);
                lvZutaten.Items.Add(lvItem);
            }
            lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void zutatHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZutat frmZutat = new frmZutat();
            frmZutat.Text = "Zutat hinzufügen";
            frmZutat.ShowDialog();
        }

        private void zutatBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvZutaten.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Zutat aus!");
            }
            else
            {
                lvItem = lvZutaten.SelectedItems[0];
                inde = lvItem.Index;
                frmZutat frmZutat = new frmZutat();
                frmZutat.Text = "Zutat bearbeiten";
                frmZutat.txtBezeichnung.Text = lvItem.SubItems[0].Text;
                frmZutat.txtEinheit.Text = lvItem.SubItems[1].Text;
                frmZutat.txtKategorie.Text = lvItem.SubItems[2].Text;
                frmZutat.ShowDialog();
            }
        }

        private void zutatEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmZutatenliste.frmZListe.lvZutaten.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Zutat aus!");
                return;
            }
            lvItem = frmZutatenliste.frmZListe.lvZutaten.SelectedItems[0];
            inde = lvItem.Index;
            DialogResult dr = MessageBox.Show("Wollen Sie die Zutat wirklich löschen?", "Achtung: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                frmSpeiseplan.frmSpPlan.zutatenliste.RemoveAt(inde);
                frmZutat.frmZ.einlesenZutaten();
            }
        }

        private void frmZutatenliste_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSpeiseplan.frmSpPlan.serialisierenZutaten();
        }

        private void lvZutaten_DoubleClick(object sender, EventArgs e)
        {
            if (frmZutatenliste.frmZListe.Equals("Zutaten der Speise hinzufügen"))
            {
                int inde = lvZutaten.SelectedItems[0].Index;
                frmSpeiseplan.frmSpPlan.speiseAkt.Zutaten.Add(frmSpeiseplan.frmSpPlan.zutatenliste[inde]);
                frmSpeiseplan.frmSpPlan.einlesenZutaten();
            }
            else
            {
                MessageBox.Show("Bitte fügen Sie Zutaten über den Button Zutat zur Speise hinzufügen hinzu");
                return;
            }
        }
    }
}

