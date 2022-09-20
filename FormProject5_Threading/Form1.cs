using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject5_Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        }

        private void btnprocess1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            MessageBox.Show("İşlem 1 çalıştı. " + $"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        }

        private void btnprocess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı. " + $"Thread No: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
