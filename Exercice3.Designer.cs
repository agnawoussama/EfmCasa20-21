
namespace EfmCasa20_21
{
    partial class Exercice3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEtudiant = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_Prnm = new System.Windows.Forms.TextBox();
            this.txtbx_nom = new System.Windows.Forms.TextBox();
            this.txtbx_CodeEtu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjt = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEtudiant
            // 
            this.dgvEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiant.Location = new System.Drawing.Point(291, 56);
            this.dgvEtudiant.MultiSelect = false;
            this.dgvEtudiant.Name = "dgvEtudiant";
            this.dgvEtudiant.ReadOnly = true;
            dataGridViewCellStyle3.NullValue = null;
            this.dgvEtudiant.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEtudiant.RowTemplate.DefaultCellStyle.Format = "d";
            this.dgvEtudiant.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvEtudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtudiant.Size = new System.Drawing.Size(609, 352);
            this.dgvEtudiant.TabIndex = 0;
            this.dgvEtudiant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtudiant_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Etudiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Naissance";
            // 
            // txtbx_Prnm
            // 
            this.txtbx_Prnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Prnm.Location = new System.Drawing.Point(151, 155);
            this.txtbx_Prnm.Name = "txtbx_Prnm";
            this.txtbx_Prnm.Size = new System.Drawing.Size(134, 24);
            this.txtbx_Prnm.TabIndex = 8;
            // 
            // txtbx_nom
            // 
            this.txtbx_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nom.Location = new System.Drawing.Point(151, 103);
            this.txtbx_nom.Name = "txtbx_nom";
            this.txtbx_nom.Size = new System.Drawing.Size(134, 24);
            this.txtbx_nom.TabIndex = 9;
            // 
            // txtbx_CodeEtu
            // 
            this.txtbx_CodeEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_CodeEtu.Location = new System.Drawing.Point(151, 56);
            this.txtbx_CodeEtu.Name = "txtbx_CodeEtu";
            this.txtbx_CodeEtu.Size = new System.Drawing.Size(134, 24);
            this.txtbx_CodeEtu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(93, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Etudiant";
            // 
            // btnAjt
            // 
            this.btnAjt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAjt.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjt.Location = new System.Drawing.Point(17, 309);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(128, 39);
            this.btnAjt.TabIndex = 12;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = false;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSupp.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupp.Location = new System.Drawing.Point(17, 369);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(128, 39);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMod.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMod.Location = new System.Drawing.Point(151, 309);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(128, 39);
            this.btnMod.TabIndex = 14;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(291, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrv.Font = new System.Drawing.Font("Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrv.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrv.Location = new System.Drawing.Point(406, 12);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(109, 38);
            this.btnPrv.TabIndex = 16;
            this.btnPrv.Text = "<<";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(676, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 38);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLast.ForeColor = System.Drawing.Color.Transparent;
            this.btnLast.Location = new System.Drawing.Point(791, 9);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(109, 38);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = ">";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "/";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(538, 18);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(0, 27);
            this.lblPos.TabIndex = 20;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(630, 19);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 27);
            this.lblCount.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "reda",
            "mouad",
            "chaimae"});
            this.comboBox1.Location = new System.Drawing.Point(151, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "ComboTest";
            // 
            // Exercice3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_CodeEtu);
            this.Controls.Add(this.txtbx_nom);
            this.Controls.Add(this.txtbx_Prnm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEtudiant);
            this.MaximumSize = new System.Drawing.Size(903, 420);
            this.MinimumSize = new System.Drawing.Size(903, 420);
            this.Name = "Exercice3";
            this.Size = new System.Drawing.Size(903, 420);
            this.Load += new System.EventHandler(this.Exercice3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_Prnm;
        private System.Windows.Forms.TextBox txtbx_nom;
        private System.Windows.Forms.TextBox txtbx_CodeEtu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}
