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
    public partial class Exercice5_1 : UserControl
    {
        static string connexionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection connexion = new SqlConnection(connexionString);
        SqlCommand command;
        SqlDataReader reader;
        BindingSource bs = new BindingSource();


        public Exercice5_1()
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

        private void Exercice5_1_Load(object sender, EventArgs e)
        {
            remplirCombo();
            dgvEtudiant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("Select * From Etudiant WHERE CodeEtudiant = @codeEtu", connexion);
                command.Parameters.AddWithValue("@codeEtu", cmbxCodeEtu.SelectedItem.ToString());
                connexion.Open();
                reader = command.ExecuteReader();
                bs.DataSource = reader;
                if(reader.HasRows)
                dgvEtudiant.DataSource = bs;
                dgvEtudiant.CurrentRow.Selected = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
            }
        }
    }
}
