
namespace EfmCasa20_21
{
    partial class Exercice6
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
            this.crystalViewerPvNotes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImpr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalViewerPvNotes
            // 
            this.crystalViewerPvNotes.ActiveViewIndex = -1;
            this.crystalViewerPvNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalViewerPvNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalViewerPvNotes.Location = new System.Drawing.Point(0, 58);
            this.crystalViewerPvNotes.Name = "crystalViewerPvNotes";
            this.crystalViewerPvNotes.Size = new System.Drawing.Size(911, 362);
            this.crystalViewerPvNotes.TabIndex = 0;
            this.crystalViewerPvNotes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.btnImpr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnImpr
            // 
            this.btnImpr.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnImpr.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImpr.Location = new System.Drawing.Point(771, 13);
            this.btnImpr.Name = "btnImpr";
            this.btnImpr.Size = new System.Drawing.Size(128, 39);
            this.btnImpr.TabIndex = 62;
            this.btnImpr.Text = "Imprimer";
            this.btnImpr.UseVisualStyleBackColor = false;
            this.btnImpr.Click += new System.EventHandler(this.btnImpr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 34);
            this.label5.TabIndex = 59;
            this.label5.Text = "Imprimer PV des notes par cours";
            // 
            // Exercice6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalViewerPvNotes);
            this.MaximumSize = new System.Drawing.Size(903, 420);
            this.MinimumSize = new System.Drawing.Size(903, 420);
            this.Name = "Exercice6";
            this.Size = new System.Drawing.Size(903, 420);
            this.Load += new System.EventHandler(this.Exercice6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalViewerPvNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImpr;
    }
}
