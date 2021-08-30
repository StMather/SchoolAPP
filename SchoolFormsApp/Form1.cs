using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var testSchool = new SchoolLibrary.School();
            testSchool.name = txtBoxName.Text;
            testSchool.address = txtBoxAddress.Text;
            testSchool.city = txtBoxCity.Text;
            testSchool.state = txtBoxState.Text;
            testSchool.zip = txtBoxZip.Text;
            testSchool.phoneNumber = txtBoxPhoneNumber.Text;
            try
            {
                testSchool.twitterAddress = txtBoxTwitter.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testSchool.ToString());

            var teacher = new Teacher();//testing teacher student and person
        }

        private void btnTeach_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("The Teachers grade average is:" + gp);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.ComputeGradeAverage();
            MessageBox.Show("The Students grade average is:" + gp);
        }
    }
}
