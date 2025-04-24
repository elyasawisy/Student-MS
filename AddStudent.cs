using ElyasWajebForms.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElyasWajebForms
{
    public partial class AddStudent : Form
    {
        
        
        public AddStudent()
        {
            InitializeComponent();
        }

        private void buttSubmite_Click(object sender, EventArgs e)
        {
           
            int tId = int.Parse(txtStudiD.Text);
            String StudName = txtName.Text;
            int age = int.Parse(txtAge.Text);
            float grade = float.Parse(txtGrade.Text);
             Student student = new Student(tId, StudName, age, grade);
            StudentManager.AddStud(student);

            this.Close();
        }

        private void buttCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
