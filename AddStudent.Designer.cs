namespace ElyasWajebForms
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudiD = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttSubmite = new System.Windows.Forms.Button();
            this.buttCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // txtStudiD
            // 
            this.txtStudiD.Location = new System.Drawing.Point(34, 55);
            this.txtStudiD.Name = "txtStudiD";
            this.txtStudiD.Size = new System.Drawing.Size(177, 20);
            this.txtStudiD.TabIndex = 1;
            this.txtStudiD.Text = "Your ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(34, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name  :";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(378, 55);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(56, 20);
            this.txtAge.TabIndex = 5;
            this.txtAge.Text = "Your Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age  :";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(378, 171);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(177, 20);
            this.txtGrade.TabIndex = 7;
            this.txtGrade.Text = "Your Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Semester Grade  :";
            // 
            // buttSubmite
            // 
            this.buttSubmite.Location = new System.Drawing.Point(311, 330);
            this.buttSubmite.Name = "buttSubmite";
            this.buttSubmite.Size = new System.Drawing.Size(75, 23);
            this.buttSubmite.TabIndex = 8;
            this.buttSubmite.Text = "Submite";
            this.buttSubmite.UseVisualStyleBackColor = true;
            this.buttSubmite.Click += new System.EventHandler(this.buttSubmite_Click);
            // 
            // buttCancle
            // 
            this.buttCancle.Location = new System.Drawing.Point(191, 330);
            this.buttCancle.Name = "buttCancle";
            this.buttCancle.Size = new System.Drawing.Size(75, 23);
            this.buttCancle.TabIndex = 9;
            this.buttCancle.Text = "Cancle";
            this.buttCancle.UseVisualStyleBackColor = true;
            this.buttCancle.Click += new System.EventHandler(this.buttCancle_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 365);
            this.Controls.Add(this.buttCancle);
            this.Controls.Add(this.buttSubmite);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudiD);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudiD;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttSubmite;
        private System.Windows.Forms.Button buttCancle;
    }
}