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
    public partial class frmWochenspeiseplan : Form
    {
        public frmWochenspeiseplan()
        {
            InitializeComponent();
        }

        int zahl = 0;
        Random r;

        private void frmWochenspeiseplan_Load(object sender, EventArgs e)
        {
            #region Vorspeisen
            int a = 0;
            //Vorspeisen einlesen
            foreach (Speise s in frmSpeiseplan.frmSpPlan.speiseliste)
            {
                if (s.Speiseart.ToString().Equals("V"))
                {
                    cbVor1.Items.Add(s.Bezeichnung);
                    cbVor2.Items.Add(s.Bezeichnung);
                    cbVor3.Items.Add(s.Bezeichnung);
                    cbVor4.Items.Add(s.Bezeichnung);
                    cbVor5.Items.Add(s.Bezeichnung);
                    a++;
                }
            }

            //Random Vorspeisen einlesen
            try
            {
            r = new Random();
            zahl = r.Next(0, a);
            cbVor1.SelectedIndex = zahl;

            zahl = r.Next(0, a);
            cbVor2.SelectedIndex = zahl;

            zahl = r.Next(0, a);       
            cbVor3.SelectedIndex = zahl;

            zahl = r.Next(0, a);
            cbVor4.SelectedIndex = zahl;

            zahl = r.Next(0, a);
            cbVor5.SelectedIndex = zahl;
            }
            catch
            {
                MessageBox.Show("Es ist keine Vorspeise vorhanden!");
            }
    #endregion

            #region Hauptspeisen
    int b = 0;
            //Hauptspeisen einlesen
            foreach (Speise s in frmSpeiseplan.frmSpPlan.speiseliste)
            {
                if (s.Speiseart.ToString().Equals("H"))
                {
                    cbHaupt1.Items.Add(s.Bezeichnung);
                    cbHaupt2.Items.Add(s.Bezeichnung);
                    cbHaupt3.Items.Add(s.Bezeichnung);
                    cbHaupt4.Items.Add(s.Bezeichnung);
                    cbHaupt5.Items.Add(s.Bezeichnung);
                    b++;
                }
            }

            try 
            {
            zahl = r.Next(0, b);
            cbHaupt1.SelectedIndex = zahl;

            zahl = r.Next(0, b);
            cbHaupt2.SelectedIndex = zahl;

            zahl = r.Next(0, b);
            cbHaupt3.SelectedIndex = zahl;

            zahl = r.Next(0, b);
            cbHaupt4.SelectedIndex = zahl;

            zahl = r.Next(0, b);
            cbHaupt5.SelectedIndex = zahl;
            }
            catch
            {
                MessageBox.Show("Es ist keine Hauptspeise vorhanden!");
            }
    #endregion

            #region Nachspeisen
    //Nachspeisen einlesen
    int c = 0;
            foreach (Speise s in frmSpeiseplan.frmSpPlan.speiseliste)
            {
                if (s.Speiseart.ToString().Equals("N"))
                {
                    cbNach1.Items.Add(s.Bezeichnung);
                    cbNach2.Items.Add(s.Bezeichnung);
                    cbNach3.Items.Add(s.Bezeichnung);
                    cbNach4.Items.Add(s.Bezeichnung);
                    cbNach5.Items.Add(s.Bezeichnung);
                    c++;
                }
            }

            try
            {
                zahl = r.Next(0, c);
                cbNach1.SelectedIndex = zahl;

                zahl = r.Next(0, c);
                cbNach2.SelectedIndex = zahl;

                zahl = r.Next(0, c);
                cbNach3.SelectedIndex = zahl;

                zahl = r.Next(0, c);
                cbNach4.SelectedIndex = zahl;

                zahl = r.Next(0, c);
                cbNach5.SelectedIndex = zahl;
            }
            catch
            {
                MessageBox.Show("Es ist keine Nachspeise vorhanden!");
            }
            #endregion
        }

        private void btnWordDrucken_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            if (wordapp == null)
            {
                MessageBox.Show("Es konnte keine Verbindung zu Word hergestellt werden!");
                return;
            }
            wordapp.Visible = true;
            wordapp.Documents.Open(Application.StartupPath + "\\../../../Wochenspeiseplan.docx");
            wordapp.ActiveDocument.FormFields["cbVor1"].Result = cbVor1.Text;
            wordapp.ActiveDocument.FormFields["cbVor2"].Result = cbVor2.Text;
            wordapp.ActiveDocument.FormFields["cbVor3"].Result = cbVor3.Text;
            wordapp.ActiveDocument.FormFields["cbVor4"].Result = cbVor4.Text;
            wordapp.ActiveDocument.FormFields["cbVor5"].Result = cbVor5.Text;
            wordapp.ActiveDocument.FormFields["cbHaupt1"].Result = cbHaupt1.Text;
            wordapp.ActiveDocument.FormFields["cbHaupt2"].Result = cbHaupt2.Text;
            wordapp.ActiveDocument.FormFields["cbHaupt3"].Result = cbHaupt3.Text;
            wordapp.ActiveDocument.FormFields["cbHaupt4"].Result = cbHaupt4.Text;
            wordapp.ActiveDocument.FormFields["cbHaupt5"].Result = cbHaupt5.Text;
            wordapp.ActiveDocument.FormFields["cbNach1"].Result = cbNach1.Text;
            wordapp.ActiveDocument.FormFields["cbNach2"].Result = cbNach2.Text;
            wordapp.ActiveDocument.FormFields["cbNach3"].Result = cbNach3.Text;
            wordapp.ActiveDocument.FormFields["cbNach4"].Result = cbNach4.Text;
            wordapp.ActiveDocument.FormFields["cbNach5"].Result = cbNach5.Text;
            wordapp.ActiveDocument.FormFields["Datum"].Result = DateTime.Now.ToShortDateString();

            wordapp.ActiveDocument.SaveAs2(Application.StartupPath + "\\../../../" + "Wochenspeiseplan" + ".docx");
            wordapp.ActiveDocument.ExportAsFixedFormat(Application.StartupPath + "\\../../../" + "Wochenspeiseplan" + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, true);
        }
    }
}
