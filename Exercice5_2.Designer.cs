
namespace EfmCasa20_21
{
    partial class Exercice5_2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbxCodeEtu = new System.Windows.Forms.ComboBox();
            this.btnRech = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExamen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxCodeEtu
            // 
            this.cmbxCodeEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCodeEtu.FormattingEnabled = true;
            this.cmbxCodeEtu.Location = new System.Drawing.Point(622, 15);
            this.cmbxCodeEtu.Name = "cmbxCodeEtu";
            this.cmbxCodeEtu.Size = new System.Drawing.Size(144, 28);
            this.cmbxCodeEtu.TabIndex = 60;
            // 
            // btnRech
            // 
            this.btnRech.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRech.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRech.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRech.Location = new System.Drawing.Point(772, 9);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(128, 39);
            this.btnRech.TabIndex = 59;
            this.btnRech.Text = "Rechercher";
            this.btnRech.UseVisualStyleBackColor = false;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 34);
            this.label5.TabIndex = 58;
            this.label5.Text = "Rechercher Examen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "Code Etudiant";
            // 
            // dgvExamen
            // 
            this.dgvExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamen.Location = new System.Drawing.Point(3, 59);
            this.dgvExamen.Name = "dgvExamen";
            this.dgvExamen.Size = new System.Drawing.Size(897, 348);
            this.dgvExamen.TabIndex = 61;
            // 
            // Exercice5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.dgvExamen);
            this.Controls.Add(this.cmbxCodeEtu);
            this.Controls.Add(this.btnRech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(903, 420);
            this.MinimumSize = new System.Drawing.Size(903, 420);
            this.Name = "Exercice5_2";
            this.Size = new System.Drawing.Size(903, 420);
            this.Load += new System.EventHandler(this.Exercice5_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxCodeEtu;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExamen;
    }
}
