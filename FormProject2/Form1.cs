using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Ahmet", "Veli", "Ayşe" };

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxAddStudent.Text.Length >= 2)
            {
                students.Add(tbxAddStudent.Text);
                lbxStudentList.Items.Clear();
                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("En az 2 karakter girmelisiniz!!!");
            }
        }

        private void lbxStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();
                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Bir öğrenci seçmelisiniz!!!");
            }
        }
    }
}
