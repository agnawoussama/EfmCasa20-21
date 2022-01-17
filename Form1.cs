using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfmCasa20_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void miseAJourEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercice3 ex3 = new Exercice3();
            panel1.Controls.Add(ex3);
            ex3.BringToFront();
        }

        private void miseAJoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercice4_1 ex4 = new Exercice4_1();
            panel1.Controls.Add(ex4);
            ex4.BringToFront();
        }

        private void rechercheEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercice5_1 ex5_1 = new Exercice5_1();
            panel1.Controls.Add(ex5_1);
            ex5_1.BringToFront();
        }

        private void rechercheExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercice5_2 ex5_2 = new Exercice5_2();
            panel1.Controls.Add(ex5_2);
            ex5_2.BringToFront();
        }

        private void imprimerPvDesNotesParCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercice6 ex6 = new Exercice6();
            panel1.Controls.Add(ex6);
            ex6.BringToFront();
        }

        private void imprimernotesDunEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercice7 ex7 = new Exercice7();
            panel1.Controls.Add(ex7);
            ex7.BringToFront();
        }
    }
}
