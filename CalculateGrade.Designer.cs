namespace ElyasWajebForms
{
    partial class CalculateGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateGrade));
            this.buttCl = new System.Windows.Forms.Button();
            this.labCalc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttCl
            // 
            this.buttCl.Location = new System.Drawing.Point(197, 227);
            this.buttCl.Name = "buttCl";
            this.buttCl.Size = new System.Drawing.Size(75, 23);
            this.buttCl.TabIndex = 1;
            this.buttCl.Text = "Close";
            this.buttCl.UseVisualStyleBackColor = true;
            this.buttCl.Click += new System.EventHandler(this.buttCl_Click);
            // 
            // labCalc
            // 
            this.labCalc.AutoSize = true;
            this.labCalc.Location = new System.Drawing.Point(215, 112);
            this.labCalc.Name = "labCalc";
            this.labCalc.Size = new System.Drawing.Size(0, 13);
            this.labCalc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "The Avarege is :";
            // 
            // CalculateGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labCalc);
            this.Controls.Add(this.buttCl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateGrade";
            this.Text = "CalculateGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttCl;
        private System.Windows.Forms.Label labCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}