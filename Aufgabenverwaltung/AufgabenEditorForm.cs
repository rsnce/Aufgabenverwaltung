using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabenverwaltung
{
    public partial class AufgabenEditorForm : Form
    {
        SqlConnection conn = new SqlConnection("Server=.;database=Aufgabenverwaltung;Trusted_Connection=True;");
        public List<Aufgabe> AufgabenNeu  { get; set; }
        public Aufgabe Aufgabe { get; set; }
        public AufgabenEditorForm(List<Aufgabe> aufgabenAlt)
        {
            InitializeComponent();
            AufgabenNeu = aufgabenAlt;
            aufgabeErstellenButton.Tag = true;
        }
        public AufgabenEditorForm(Aufgabe aufgabe)
        {
            InitializeComponent();
            Aufgabe = aufgabe;
            aufgabeErstellenButton.Tag = false;
            aufgabeErstellenButton.Text = "Änderung speichern";
            TextBoxenBefuellen();            
        }
        private void TextBoxenBefuellen()
        {
            aufgabeBezeichnungTextBox.Text = Aufgabe.Bezeichnung;
            aufgabeAbgabedatumTextBox.Text = Aufgabe.Abgabedatum.Date.ToString();
            aufgabeMitarbeiterTextBox.Text = Aufgabe.Mitarbeiter;
            aufgabeErledigungsgradTextBox.Text = Aufgabe.Erledigungsgrad.ToString();
        }
        private void aufgabeErstellenButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if ((bool)aufgabeErstellenButton.Tag)
                {
                    //AufgabenNeu.Add(new Aufgabe(aufgabeBezeichnungTextBox.Text,
                    //                                 DateTime.Parse(aufgabeAbgabedatumTextBox.Text),
                    //                                 aufgabeMitarbeiterTextBox.Text,
                    //                                 int.Parse(aufgabeErledigungsgradTextBox.Text)));

                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into Aufgabe (bezeichnung,abgabedatum,mitarbeiter,erledigungsgrad) values(@bezeichnung,@abgabedatum,@mitarbeiter,@erledigungsgrad)";

                    cmd.Parameters.AddWithValue("bezeichnung", aufgabeBezeichnungTextBox.Text);
                    cmd.Parameters.AddWithValue("abgabedatum", DateTime.Parse(aufgabeAbgabedatumTextBox.Text));
                    cmd.Parameters.AddWithValue("mitarbeiter", aufgabeMitarbeiterTextBox.Text);
                    cmd.Parameters.AddWithValue("erledigungsgrad", int.Parse(aufgabeErledigungsgradTextBox.Text));

                    
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
                else if(!(bool)aufgabeErstellenButton.Tag)
                {
                    Aufgabe.Bezeichnung = aufgabeBezeichnungTextBox.Text;
                    Aufgabe.Abgabedatum = DateTime.Parse(aufgabeAbgabedatumTextBox.Text);
                    Aufgabe.Mitarbeiter = aufgabeMitarbeiterTextBox.Text;
                    Aufgabe.Erledigungsgrad = int.Parse(aufgabeErledigungsgradTextBox.Text);

                    conn.Open();
                    SqlCommand deleteEntry = conn.CreateCommand();
                    deleteEntry.CommandText = $"delete from Aufgabe where id = {Aufgabe.Id}";
                    deleteEntry.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into Aufgabe (bezeichnung,abgabedatum,mitarbeiter,erledigungsgrad) values(@bezeichnung,@abgabedatum,@mitarbeiter,@erledigungsgrad)";

                    cmd.Parameters.AddWithValue("bezeichnung", aufgabeBezeichnungTextBox.Text);
                    cmd.Parameters.AddWithValue("abgabedatum", DateTime.Parse(aufgabeAbgabedatumTextBox.Text));
                    cmd.Parameters.AddWithValue("mitarbeiter", aufgabeMitarbeiterTextBox.Text);
                    cmd.Parameters.AddWithValue("erledigungsgrad", int.Parse(aufgabeErledigungsgradTextBox.Text));

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Bitte gültige Daten eingeben!");
                aufgabeBezeichnungTextBox.Text = "";
                aufgabeAbgabedatumTextBox.Text = "";
                aufgabeMitarbeiterTextBox.Text = "";
                aufgabeErledigungsgradTextBox.Text = "";
            }
            
        }
        private bool ValidateForm()
        {
            DateTime temp;
            int tempInt;
            if (aufgabeBezeichnungTextBox.Text.Length== 0 || !DateTime.TryParse(aufgabeAbgabedatumTextBox.Text, out temp)
                || aufgabeMitarbeiterTextBox.Text.Length== 0||!int.TryParse(aufgabeErledigungsgradTextBox.Text, out tempInt) || !(tempInt>=0&&tempInt<=100))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
