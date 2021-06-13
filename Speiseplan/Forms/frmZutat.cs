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
    public partial class frmZutat : Form
    {
        internal static frmZutat frmZ;
        public frmZutat()
        {
            frmZ = this;
            InitializeComponent();
        }

        internal ListViewItem lvItem;

        private void frmZutat_Load(object sender, EventArgs e)
        {

        }

        internal void einlesenZutaten()
        {
            frmZutatenliste.frmZListe.lvZutaten.Items.Clear();
            foreach (Zutat z in frmSpeiseplan.frmSpPlan.zutatenliste)
            {
                lvItem = new ListViewItem(z.Bezeichung);
                lvItem.SubItems.Add(z.Einheit);
                lvItem.SubItems.Add(z.Kategorie);
                frmZutatenliste.frmZListe.lvZutaten.Items.Add(lvItem);
            }
            frmZutatenliste.frmZListe.lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            frmZutatenliste.frmZListe.lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtBezeichnung.Text.Equals("") || txtEinheit.Text.Equals("") || txtKategorie.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie sowohl die Bezeichnung, die Einheit und die Kategorie der Speise aus!");
                return;
            }

            if (frmZ.Text == "Zutat hinzufügen")
            {
                Zutat z = new Zutat();
                z.Bezeichung = txtBezeichnung.Text;
                z.Einheit = txtEinheit.Text;
                z.Kategorie = txtKategorie.Text;
                frmSpeiseplan.frmSpPlan.zutatenliste.Add(z);
                MessageBox.Show("Neue Zutat hinzugefügt!");            }
            else
            {
                lvItem = frmZutatenliste.frmZListe.lvZutaten.SelectedItems[0];
                int inde = lvItem.Index;
                frmSpeiseplan.frmSpPlan.zutatenliste[inde].Bezeichung = txtBezeichnung.Text;
                frmSpeiseplan.frmSpPlan.zutatenliste[inde].Einheit = txtEinheit.Text;
                frmSpeiseplan.frmSpPlan.zutatenliste[inde].Kategorie = txtKategorie.Text;

            }
            einlesenZutaten();
            frmZutatenliste.frmZListe.lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            frmZutatenliste.frmZListe.lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Close();
        }
    }
}
