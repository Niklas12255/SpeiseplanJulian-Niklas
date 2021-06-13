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
    public partial class frmSpeise : Form
    {
        public frmSpeise()
        {
            InitializeComponent();
        }

        internal string bildpfad;
        ListView lvItem;

        private void frmSpeise_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtBezeichnung.Text.Equals("") || cBSpeiseart.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie eine Bezeichnung und die Speiseart an!");
                return;
            }
            try
            {
                Convert.ToDouble(txtPreis.Text);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein!");
                return;
            }
            if (this.Text.Equals("Speise hinzufügen"))
            {
                Speise s = new Speise();
                s.Bezeichnung = txtBezeichnung.Text;
                s.Speiseart = Convert.ToChar(cBSpeiseart.Text);
                s.Preis = Convert.ToDouble(txtPreis.Text);
                s.BildPfad = bildpfad;
                frmSpeiseplan.frmSpPlan.speiseliste.Add(s);
            }
            else
            {
                frmSpeiseplan.frmSpPlan.lvItemS = frmSpeiseplan.frmSpPlan.lvSpeisen.SelectedItems[0];
                int inde = frmSpeiseplan.frmSpPlan.lvItemS.Index;
                frmSpeiseplan.frmSpPlan.speiseliste[inde].Bezeichnung = txtBezeichnung.Text;
                frmSpeiseplan.frmSpPlan.speiseliste[inde].Speiseart = Convert.ToChar(cBSpeiseart.Text);
                frmSpeiseplan.frmSpPlan.speiseliste[inde].Preis = Convert.ToDouble(txtPreis.Text);
                frmSpeiseplan.frmSpPlan.speiseliste[inde].BildPfad = bildpfad;
            }
            frmSpeiseplan.frmSpPlan.einlesenSpeisen();
            frmSpeiseplan.frmSpPlan.serialisierenSpeisen();
            this.Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Images Files (*.jpg; *.jpeg; *.bmp; *.gif; *.png)|*.jpg; *.jpeg; *.bmp; *.gif; *.png";
                ofd.InitialDirectory = "C:\\Fotos";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    bildpfad = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
