using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject3_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students;
        private void Form1_Load(object sender, EventArgs e)
        {

            dgvStudentsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Student student1 = new Student();
            {
                student1.FirstName = "Ali";
                student1.LastName = "Çukur";
                student1.Age = 18;
                student1.Mail = "ali@mail.com";
            }

            Student student2 = new Student();
            {
                student2.FirstName = "Mehmet";
                student2.LastName = "Akif";
                student2.Age = 19;
                student2.Mail = "mehmet@mail.com";
            }

            Student student3 = new Student();
            {
                student3.FirstName = "Veli";
                student3.LastName = "Kırım";
                student3.Age = 20;
                student3.Mail = "veli@mail.com";
            }

            students = new List<Student>()
            {
                student1, student2, student3
            };
        }

        private void btnGetStudentsLbx_Click(object sender, EventArgs e)
        {
            foreach (Student student in students)
            {
                lbxStudentsList.Items.Add(student.FirstName + " " + student.LastName + " " + student.Age + " " + student.Mail);
            }
        }

        private void btnGetStudentsDgv_Click(object sender, EventArgs e)
        {
            dgvStudentsList.DataSource = students;
        }
    }
}
