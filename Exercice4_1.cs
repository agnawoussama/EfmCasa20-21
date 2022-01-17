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
    public partial class Exercice4_1 : UserControl
    {
        static string connexionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection connexion = new SqlConnection(connexionString);
        SqlCommand command;
        SqlDataReader reader;
        BindingSource bs = new BindingSource();
        public Exercice4_1()
        {
            InitializeComponent();
        }

        private void labelsCountPos()
        {
            lblPos.Text = (bs.Position + 1).ToString();
            lblCount.Text = bs.Count.ToString();
        }

        private void afficher()
        {
            try
            {
                command = new SqlCommand("SELECT * FROM Cours", connexion);
                connexion.Open();
                reader = command.ExecuteReader();
                bs.DataSource = reader;
                if(reader.HasRows)
                dgvCours.DataSource = bs;
                dgvCours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void Exercice4_1_Load(object sender, EventArgs e)
        {
            afficher();
            labelsCountPos();
        }

        private bool checkInputs()
        {
            return (txtbx_NumCours.Text.Length > 0 && txtbx_NumSalle.Text.Length > 0 
                     && txtbx_MatrProf.Text.Length > 0 && txtbx_Titre.Text.Length > 0 && txtbx_Coeff.Text.Length > 0);
        }

        private void btnAjt_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkInputs())
                {
                    command = new SqlCommand("INSERT INTO Cours VALUES (@numCours, @numSalle,@matrProf,@titre,@coeff)", connexion);
                    command.Parameters.AddWithValue("@numCours", txtbx_NumCours.Text);
                    command.Parameters.AddWithValue("@numSalle", txtbx_NumSalle.Text);
                    command.Parameters.AddWithValue("@matrProf", txtbx_MatrProf.Text);
                    command.Parameters.AddWithValue("@titre", txtbx_Titre.Text);
                    command.Parameters.AddWithValue("@coeff", txtbx_Coeff.Text);
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

        private void btnMod_Click_1(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("UPDATE Cours SET NumSalle = @numSalle, MatriculeProfesseur = @matrProf, Titre = @titre, Coef = @coeff WHERE NumCours = @numCours", connexion);
                command.Parameters.AddWithValue("@numCours", txtbx_NumCours.Text);
                command.Parameters.AddWithValue("@numSalle", txtbx_NumSalle.Text);
                command.Parameters.AddWithValue("@matrProf", txtbx_MatrProf.Text);
                command.Parameters.AddWithValue("@titre", txtbx_Titre.Text);
                command.Parameters.AddWithValue("@coeff", txtbx_Coeff.Text);
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

        private void btnSupp_Click_1(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("Delete Cours WHERE NumCours = @numCours", connexion);
                command.Parameters.AddWithValue("@numCours", txtbx_NumCours.Text);
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

        private void remplirTxtbx()
        {
            int index = dgvCours.CurrentRow.Index;
            txtbx_NumCours.Text = dgvCours.Rows[index].Cells[0].Value.ToString();
            txtbx_NumSalle.Text = dgvCours.Rows[index].Cells[1].Value.ToString();
            txtbx_MatrProf.Text = dgvCours.Rows[index].Cells[2].Value.ToString();
            txtbx_Titre.Text = dgvCours.Rows[index].Cells[3].Value.ToString();
            txtbx_Coeff.Text = dgvCours.Rows[index].Cells[4].Value.ToString();

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            bs.MoveNext();
            remplirTxtbx();
            labelsCountPos();
        }

        private void btnLast_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            bs.MoveFirst();
            remplirTxtbx();
            labelsCountPos();
        }

        private void dgvCours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            remplirTxtbx();
        }
    }
}
