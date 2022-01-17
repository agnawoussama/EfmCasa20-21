
namespace EfmCasa20_21
{
    partial class Exercice7
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
            this.btnImp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cmbxCodeEtu
            // 
            this.cmbxCodeEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCodeEtu.FormattingEnabled = true;
            this.cmbxCodeEtu.Location = new System.Drawing.Point(622, 17);
            this.cmbxCodeEtu.Name = "cmbxCodeEtu";
            this.cmbxCodeEtu.Size = new System.Drawing.Size(144, 28);
            this.cmbxCodeEtu.TabIndex = 65;
            // 
            // btnImp
            // 
            this.btnImp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnImp.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImp.Location = new System.Drawing.Point(772, 11);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(128, 39);
            this.btnImp.TabIndex = 64;
            this.btnImp.Text = "Imprimer";
            this.btnImp.UseVisualStyleBackColor = false;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 34);
            this.label5.TabIndex = 63;
            this.label5.Text = "Imprimer notes d\'un etudiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 62;
            this.label1.Text = "Code Etudiant";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(903, 364);
            this.crystalReportViewer1.TabIndex = 66;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Exercice7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cmbxCodeEtu);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(903, 420);
            this.MinimumSize = new System.Drawing.Size(903, 420);
            this.Name = "Exercice7";
            this.Size = new System.Drawing.Size(903, 420);
            this.Load += new System.EventHandler(this.Exercice7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbxCodeEtu;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
