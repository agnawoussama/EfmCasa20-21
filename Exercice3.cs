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
    public partial class Exercice3 : UserControl
    {
        static string connexionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection connexion = new SqlConnection(connexionString);
        SqlCommand command;
        SqlDataReader reader;
        BindingSource bs = new BindingSource();


        public Exercice3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void labelsCountPos()
        {
            lblPos.Text = (bs.Position+1).ToString();
            lblCount.Text = bs.Count.ToString();
        }

        private void afficher()
        {
            try
            {
                command = new SqlCommand("SELECT * FROM Etudiant", connexion);
                connexion.Open();
                reader = command.ExecuteReader();
                bs.DataSource = reader;
                dgvEtudiant.DataSource = bs;
                dgvEtudiant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgvEtudiant.Columns[3].DefaultCellStyle.Format = "y"; // Short date
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


        private void Exercice3_Load(object sender, EventArgs e)
        {
            afficher();
            labelsCountPos();
        }

        private bool checkInputs()
        {
            return (txtbx_CodeEtu.Text.Length > 0 && txtbx_nom.Text.Length > 0 && txtbx_Prnm.Text.Length > 0);
        }

        private void btnAjt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbx_CodeEtu.Text != "" && txtbx_CodeEtu.Text != "" && txtbx_CodeEtu.Text != "")
                {
                    command = new SqlCommand("INSERT INTO Etudiant VALUES (@codeEtu, @nom,@prenom,@dateNaiss)", connexion);
                    command.Parameters.AddWithValue("@codeEtu", txtbx_CodeEtu.Text);
                    command.Parameters.AddWithValue("@nom", txtbx_nom.Text);
                    command.Parameters.AddWithValue("@prenom", txtbx_Prnm.Text);
                    command.Parameters.AddWithValue("@dateNaiss", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@combo", comboBox1.SelectedItem.ToString());
                    connexion.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ajout Reussi");
                }
                else
                {
                    MessageBox.Show("Veuillez Remplir tous les infos");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
                afficher();
                labelsCountPos();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("UPDATE Etudiant SET Nom = @nom, Prenom = @prenom, Date_naiss = @dateNaiss WHERE CodeEtudiant = @codeEtu", connexion);
                command.Parameters.AddWithValue("@codeEtu", txtbx_CodeEtu.Text);
                command.Parameters.AddWithValue("@nom", txtbx_nom.Text);
                command.Parameters.AddWithValue("@prenom", txtbx_Prnm.Text);
                command.Parameters.AddWithValue("@dateNaiss", dateTimePicker1.Value.ToString());
                connexion.Open();
                command.ExecuteNonQuery();              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
                afficher();
                labelsCountPos();
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("Delete Etudiant WHERE CodeEtudiant = @codeEtu", connexion);
                command.Parameters.AddWithValue("@codeEtu", txtbx_CodeEtu.Text);
                connexion.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
                afficher();
                labelsCountPos();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            remplirTxtbx();
            labelsCountPos();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            remplirTxtbx();
            labelsCountPos();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            remplirTxtbx();
            labelsCountPos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            remplirTxtbx();
            labelsCountPos();
        }
        private void remplirTxtbx()
        {
            int index = dgvEtudiant.CurrentRow.Index;
            txtbx_CodeEtu.Text = dgvEtudiant.Rows[index].Cells[0].Value.ToString();
            txtbx_nom.Text = dgvEtudiant.Rows[index].Cells[1].Value.ToString();
            txtbx_Prnm.Text = dgvEtudiant.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dgvEtudiant.Rows[index].Cells[3].Value.ToString();            
        }


        private void dgvEtudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            remplirTxtbx();
            labelsCountPos();
        }

        
    }
}
