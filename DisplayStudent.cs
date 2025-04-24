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

namespace ElyasWajebForms
{
    public partial class DisplayStudent : Form
    {
        public DisplayStudent()
        {
            InitializeComponent();

        }
     
        
      

        private void DisplayStudent_Load_1(object sender, EventArgs e)
        {
            List<Student> printStudent = StudentManager.DisplayStud();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < printStudent.Count(); i++)
            {
                int rows = dataGridView1.Rows.Add();
                dataGridView1.Rows[rows].Cells["StId"].Value = printStudent[i].getID();
                dataGridView1.Rows[rows].Cells["StNm"].Value = printStudent[i].getName();
                dataGridView1.Rows[rows].Cells["Ag"].Value = printStudent[i].getAge();
                dataGridView1.Rows[rows].Cells["SemGr"].Value = printStudent[i].getSemester_Grade();


            }
        }

  

        private void buttEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
