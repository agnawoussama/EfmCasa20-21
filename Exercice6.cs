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
    public partial class Exercice6 : UserControl
    {
        public Exercice6()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Exercice6_Load(object sender, EventArgs e)
        {
            
        }

        private void btnImpr_Click(object sender, EventArgs e)
        {
            Exercice6Rapport ex6Rapp = new Exercice6Rapport();
            crystalViewerPvNotes.ReportSource = ex6Rapp;
        }
    }
}
