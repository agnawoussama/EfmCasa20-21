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
    public partial class Exercice5_2 : UserControl
    {
        static string connexionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection connexion = new SqlConnection(connexionString);
        SqlCommand command;
        SqlDataReader reader;
        BindingSource bs = new BindingSource();

        public Exercice5_2()
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

        private void btnRech_Click(object sender, EventArgs e)
        {
            try
            {
                //command = new SqlCommand("Select  Note From Examen WHERE CodeEtudiant = @codeEtu", connexion);
                command = new SqlCommand("Select Titre as Titre_de_Cours, Note From Examen INNER JOIN Cours ON Examen.NumCours = Cours.NumCours WHERE CodeEtudiant = @codeEtu", connexion);
                command.Parameters.AddWithValue("@codeEtu", cmbxCodeEtu.Text);
                connexion.Open();
                reader = command.ExecuteReader();
                bs.DataSource = reader;
                if (reader.HasRows)
                    dgvExamen.DataSource = bs;
                dgvExamen.CurrentRow.Selected = false;

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

        private void Exercice5_2_Load(object sender, EventArgs e)
        {
            remplirCombo();
            dgvExamen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
