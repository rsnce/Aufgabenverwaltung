using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aufgabenverwaltung
{
    public partial class aufgabenverwaltungForm : Form
    {
        List<Aufgabe> aufgaben = new List<Aufgabe>();
        SqlConnection conn = new SqlConnection("Server=.;database=Aufgabenverwaltung;Trusted_Connection=True;");

        const string filePath = @"C:\data\Test\AufgabenDaten.csv";
        
        public aufgabenverwaltungForm()
        {
            InitializeComponent();           
            //DatenLadenText();
            DatenLadenSql();
        }        
        private void RefreshElements()
        {          
            aufgabenListBox.DataSource = null;
            aufgabenListBox.DataSource = aufgaben;
            
        }
        public void AddAufgabe(Aufgabe aufgabe)
        {
            aufgaben.Add(aufgabe);
            RefreshElements();
        }
        private void DatenLadenSql()
        {
            aufgaben.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id, bezeichnung, abgabedatum, mitarbeiter, erledigungsgrad from Aufgabe";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string bezeichnung = reader.GetString(1);
                DateTime abgabedatum = reader.GetDateTime(2);
                string mitarbeiter = reader.GetString(3);
                Int32 erledigungsgrad = reader.GetInt32(4);

                aufgaben.Add(new Aufgabe(id, bezeichnung, abgabedatum, mitarbeiter, erledigungsgrad));

            }
            conn.Close();
            RefreshElements();
        }
        //private void DatenLadenText()
        //{
        //    //TODO- if file exists but is empty
        //    if (!File.Exists(filePath))
        //    {               
        //        using (File.Create(filePath))
        //        {

        //        }              
        //    }
        //    else
        //    {
        //        string[] data = File.ReadAllLines(filePath);

        //        foreach (string line in data)
        //        {
        //            string[] entries = new string[4];
        //            entries = line.Split(';');
        //            AddAufgabe(new Aufgabe(entries[0], DateTime.Parse(entries[1]), entries[2], int.Parse(entries[3])));
        //        }
        //    }
        //}
        public void DatenSpeichernSql()
        {
            conn.Open();

            SqlCommand deleteTable = conn.CreateCommand();
            deleteTable.CommandText = "delete from Aufgabe";
            deleteTable.ExecuteNonQuery();

            conn.Close();

            foreach (Aufgabe aufgabe in aufgaben)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into Aufgabe (bezeichnung, abgabedatum, mitarbeiter, erledigungsgrad)" +
                    "values(@bezeichnung, @abgabedatum, @mitarbeiter, @erledigungsgrad)";
                cmd.Parameters.AddWithValue("bezeichnung",aufgabe.Bezeichnung);
                cmd.Parameters.AddWithValue("abgabedatum",aufgabe.Abgabedatum);
                cmd.Parameters.AddWithValue("mitarbeiter",aufgabe.Mitarbeiter);
                cmd.Parameters.AddWithValue("erledigungsgrad",aufgabe.Erledigungsgrad);
                
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void DatenSpeichernText()
        {
            if (aufgaben.Count == 0)
            {
                File.Delete(filePath);
            }
            else
            {
                List<string> lines = new List<string>();
                foreach (Aufgabe a in aufgaben)
                {
                    lines.Add($"{a.Bezeichnung};{a.Abgabedatum.Date};{a.Mitarbeiter};{a.Erledigungsgrad}");
                }
                File.WriteAllLines(filePath, lines);
            }
            
        }
        private void aufgabeHinzufuegenButton_Click(object sender, EventArgs e)
        {         
            AufgabenEditorForm frm = new AufgabenEditorForm(aufgaben);
            if (frm.ShowDialog()==DialogResult.OK)
            {
                //DatenSpeichernText();
                //DatenSpeichernSql();
                DatenLadenSql();
                RefreshElements();
            }           
        }
        private void aufgabeEntfernenButton_Click(object sender, EventArgs e)
        {
            if (aufgabenListBox.SelectedItem != null)
            {
                aufgaben.RemoveAt(aufgabenListBox.SelectedIndex);

                conn.Open();
                SqlCommand deleteTask = conn.CreateCommand();
                Aufgabe temp = (Aufgabe)aufgabenListBox.SelectedItem;
                deleteTask.CommandText = $"delete from Aufgabe where id = {temp.Id}";

                deleteTask.ExecuteNonQuery();
                conn.Close();

                //DatenSpeichernText();
                //DatenSpeichernSql();
                
                RefreshElements();
            }
            else
            {
                MessageBox.Show("Select an item to remove it.");
            }
        }
        private void aufgabeAendernButton_Click(object sender, EventArgs e)
        {
            if (aufgabenListBox.SelectedItem != null)
            {
                AufgabenEditorForm frm = new AufgabenEditorForm((Aufgabe)aufgabenListBox.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //DatenSpeichernText();
                    //DatenSpeichernSql();
                    DatenLadenSql();
                    RefreshElements();
                }
            }
            else
            {
                MessageBox.Show("Select an item to change it.");
            }
            
        }
    }
}
