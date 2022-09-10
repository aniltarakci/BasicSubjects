using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject4_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();
        Customer customer = new Customer();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = customerManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customer.Id = Convert.ToInt32(tbxId.Text);
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.Age = Convert.ToInt32(tbxAge.Text);
            customer.Mail = tbxMail.Text;

            customerManager.Add(customer);
            dgvCustomerList.DataSource = null;
            dgvCustomerList.DataSource = customerManager.GetAll();
            MessageBox.Show("Başarıyla eklendi.");
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
