using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EfmCasa20_21
{
    public partial class Exercice7 : UserControl
    {
        static string connexionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection connexion = new SqlConnection(connexionString);
        SqlCommand command;
        SqlDataReader reader;
        BindingSource bs = new BindingSource();
        public Exercice7()
        {
            InitializeComponent();
        }
        private void remplirCombo()
        {
            command = new SqlCommand("Select CodeEtudiant from Etudiant", connexion);
            connexion.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbxCodeEtu.Items.Add(reader[0].ToString());
            }
            
            connexion.Close();
        }
        private void Exercice7_Load(object sender, EventArgs e)
        {
            remplirCombo();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            if (cmbxCodeEtu.SelectedIndex != -1)
            {
                Exercice7Rapport ex7Rapp = new Exercice7Rapport();
                ex7Rapp.SetParameterValue("codeEtu", cmbxCodeEtu.SelectedItem);
                crystalReportViewer1.ReportSource = ex7Rapp;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
