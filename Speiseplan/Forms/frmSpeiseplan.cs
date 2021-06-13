using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Speiseplan
{
    public partial class frmSpeiseplan : Form
    {
        internal static frmSpeiseplan frmSpPlan;
        public frmSpeiseplan()
        {
            frmSpPlan = this;
            InitializeComponent();
        }

        #region Variablen
        internal List<Speise> speiseliste;
        internal List<Zutat> zutatenliste;

        internal Speise speiseAkt;

        internal ListViewItem lvItemS;
        internal ListViewItem lvItemZ;

        private XmlSerializer serializerZutat;
        private XmlSerializer serializerSpeise;

        int inde;
        #endregion

        private void frmSpeiseplan_Load(object sender, EventArgs e)
        {
            lvSpeisen.FullRowSelect = true;
            lvZutaten.FullRowSelect = true;

            zutatenliste = new List<Zutat>();
            speiseliste = new List<Speise>();


            deserialisierenSpeisen();
            deserialisierenZutaten();
            einlesenSpeisen();
        }

        #region Methoden

        //internal void einlesenZutaten()
        //{
        //    lvZutaten.Items.Clear();
        //    foreach (Zutat z in zutatenliste)
        //    {
        //        lvItemZ = new ListViewItem(z.Bezeichung);
        //        lvItemZ.SubItems.Add(z.Einheit);
        //        lvItemZ.SubItems.Add(z.Kategorie);
        //        lvZutaten.Items.Add(lvItemZ);
        //    }
        //    lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //    lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        //}

        internal void serialisierenSpeisen()
        {
            try
            {
                serializerSpeise = new XmlSerializer(speiseliste.GetType());
                FileStream fs = new FileStream("speiseliste.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializerSpeise.Serialize(fs, speiseliste);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void serialisierenZutaten()
        {
            try
            {
                serializerZutat = new XmlSerializer(zutatenliste.GetType());
                FileStream fs = new FileStream("zutatenliste.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializerZutat.Serialize(fs, zutatenliste);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void deserialisierenZutaten()
        {
            try
            {
                serializerZutat = new XmlSerializer(zutatenliste.GetType());
                FileStream fs = new FileStream("zutatenliste.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                zutatenliste = (List<Zutat>)serializerZutat.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void deserialisierenSpeisen()
        {
            try
            {
                serializerSpeise = new XmlSerializer(speiseliste.GetType());
                FileStream fs = new FileStream("speiseliste.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                speiseliste = (List<Speise>)serializerSpeise.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void showImages()
        {
            ImageList bilderListe = new ImageList();
            bilderListe.ColorDepth = ColorDepth.Depth32Bit; //damit Bilder nicht so pixelig sind
            bilderListe.ImageSize = new System.Drawing.Size(32, 32);
            bilderListe.Images.Clear();

            foreach (Speise s in speiseliste)
            {
                try
                {
                    bilderListe.Images.Add(Image.FromFile(s.BildPfad));
                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\images\\default.jpg"));
                    continue; //??
                }
            }

            lvSpeisen.SmallImageList = bilderListe;
            //frmTeil.lvAlleGewinnspiele.SmallImageList = bilderListe;
        }

        internal void einlesenSpeisen()
        {
            showImages();
            lvSpeisen.Items.Clear();
            for (int i = 0; i < speiseliste.Count; i++)
            {
                        lvItemS = new ListViewItem();
                        lvItemS.ImageIndex = i;
                        lvItemS.SubItems.Add(speiseliste[i].Bezeichnung.ToString());
                        lvItemS.SubItems.Add(speiseliste[i].Speiseart.ToString());
                        lvItemS.SubItems.Add(speiseliste[i].Preis.ToString("c2"));
                        lvItemS.SubItems.Add(speiseliste[i].BildPfad);
                        lvSpeisen.Items.Add(lvItemS);
            }
            lvSpeisen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvSpeisen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        internal void einlesenZutaten()
        {
            lvZutaten.Items.Clear();
            foreach (Zutat z in speiseAkt.Zutaten)
            {
                lvItemZ = new ListViewItem(z.Bezeichung);
                lvItemZ.SubItems.Add(z.Einheit);
                lvItemZ.SubItems.Add(z.Kategorie);
                lvZutaten.Items.Add(lvItemZ);
            }
            lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvZutaten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpeise frmSpeise = new frmSpeise();
            frmSpeise.Text = "Speise hinzufügen";
            frmSpeise.ShowDialog();
        }

        private void zutatenlisteÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZutatenliste frmZutatenliste = new frmZutatenliste();
            frmZutatenliste.Text = "Alle zur Verfügung stehenden Zutaten";
            frmZutatenliste.ShowDialog();
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSpeisen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Speise aus!");
                return;
            }
            frmSpeise frmSpeise = new frmSpeise();
            frmSpeise.Text = "Speise bearbeiten";
            lvItemS = lvSpeisen.SelectedItems[0];
            frmSpeise.txtBezeichnung.Text = lvItemS.SubItems[1].Text;
            frmSpeise.cBSpeiseart.Text = lvItemS.SubItems[2].Text;
            frmSpeise.txtPreis.Text = lvItemS.SubItems[3].Text;
            frmSpeise.bildpfad = lvItemS.SubItems[4].Text;
            frmSpeise.pictureBox1.Image = Image.FromFile(lvItemS.SubItems[4].Text);
            frmSpeise.ShowDialog();
        }

        private void frmSpeiseplan_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialisierenSpeisen();
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSpeisen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Speise aus!");
                return;
            }
            lvItemS = lvSpeisen.SelectedItems[0];
            inde = lvItemS.Index;
            DialogResult dr = MessageBox.Show("Wollen Sie die Speise wirklich löschen?", "Achtung: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                speiseliste.RemoveAt(inde);
                einlesenSpeisen();
            }
        }

        private void hinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvSpeisen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Speise aus.");
                return;
            }
            lvItemS = lvSpeisen.SelectedItems[0];
            foreach (Speise s in speiseliste)
            {
               speiseAkt = s;
               frmZutatenliste frmZutatenliste = new frmZutatenliste();
               frmZutatenliste.Text = "Zutaten der Speise hinzufügen";
               frmZutatenliste.ShowDialog();
               serialisierenSpeisen();
               break;
            }
            
        }

        private void wochenspeiseplanÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWochenspeiseplan frmWoche = new frmWochenspeiseplan();
            frmWoche.Text = "Wochenspeiseplan";
            frmWoche.ShowDialog();
        }

        private void lvSpeisen_Click(object sender, EventArgs e)
        {
            speiseAkt = speiseliste[lvSpeisen.SelectedItems[0].Index];
            lvZutaten.Items.Clear();
                if (speiseAkt.Zutaten.Count != 0)
                {
                    foreach (Zutat z in speiseAkt.Zutaten)
                    {
                        lvItemZ = new ListViewItem(z.Bezeichung);
                        lvItemZ.SubItems.Add(z.Einheit);
                        lvItemZ.SubItems.Add(z.Kategorie);
                        lvZutaten.Items.Add(lvItemZ);
                    }
                }
        }
            

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvZutaten.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Zutat aus!");
                return;
            }
            lvItemZ = lvZutaten.SelectedItems[0];
            inde = lvItemZ.Index;
            DialogResult dr = MessageBox.Show("Wollen Sie die Zutat wirklich löschen?", "Achtung: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                speiseAkt.Zutaten.RemoveAt(inde);
                einlesenZutaten();
            }
        }
    }
}
