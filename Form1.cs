﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttAddstud_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();  
            
            addStudent.ShowDialog();
            
        }

        private void buttDisplaystu_Click(object sender, EventArgs e)
        {
           
        }



        private void buttDisplaystu_Click_1(object sender, EventArgs e)
        {
             DisplayStudent displayStudent = new DisplayStudent();  

                  displayStudent.ShowDialog();
        }

        private void buttCalcuSemgrade_Click_1(object sender, EventArgs e)
        {
                CalculateGrade calculateGrade = new CalculateGrade();
                     calculateGrade.ShowDialog();
        }
    }
}
