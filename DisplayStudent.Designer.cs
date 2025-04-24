namespace ElyasWajebForms
{
    partial class DisplayStudent
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayStudent));
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemGr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataSource = typeof(ElyasWajebForms.AddStudent);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StId,
            this.StNm,
            this.Ag,
            this.SemGr});
            this.dataGridView1.Location = new System.Drawing.Point(217, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // StId
            // 
            this.StId.HeaderText = "Student ID";
            this.StId.Name = "StId";
            this.StId.ReadOnly = true;
            // 
            // StNm
            // 
            this.StNm.HeaderText = "Student Name";
            this.StNm.Name = "StNm";
            this.StNm.ReadOnly = true;
            // 
            // Ag
            // 
            this.Ag.HeaderText = "Age";
            this.Ag.Name = "Ag";
            this.Ag.ReadOnly = true;
            // 
            // SemGr
            // 
            this.SemGr.HeaderText = "Semester Grade";
            this.SemGr.Name = "SemGr";
            this.SemGr.ReadOnly = true;
            // 
            // buttEx
            // 
            this.buttEx.Location = new System.Drawing.Point(354, 399);
            this.buttEx.Name = "buttEx";
            this.buttEx.Size = new System.Drawing.Size(146, 40);
            this.buttEx.TabIndex = 1;
            this.buttEx.Text = "Exit";
            this.buttEx.UseVisualStyleBackColor = true;
            this.buttEx.Click += new System.EventHandler(this.buttEx_Click);
            // 
            // DisplayStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 481);
            this.Controls.Add(this.buttEx);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayStudent";
            this.Text = "DisplayStudent";
            this.Load += new System.EventHandler(this.DisplayStudent_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ag;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemGr;
        private System.Windows.Forms.Button buttEx;
    }
}