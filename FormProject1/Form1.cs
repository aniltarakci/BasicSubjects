using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lblproductsText = "ÜRÜNLER";
            string addToCartBtnText = "Sepete Ekle";
            var deleteCartBtnText = "Sepetten Sil";
            var lblCartText = "SEPET";

            lblProducts.Text = lblproductsText;
            btnAddToCart.Text = addToCartBtnText;
            btnDeleteCart.Text = deleteCartBtnText;
            lblCart.Text = lblCartText;

            //Direkt olarak listbox'a item ekleme
            lbxProducts.Items.Add("Laptop");
            lbxProducts.Items.Add("Masaüstü");
            lbxProducts.Items.Add("Telefon");

            //products array(dizi)
            string[] products = new string[]
            {
                "Kitap", "Defter", "Kalem"
            };

            string[] products2 = new string[]
            {
                "Kulaklık", "Klavye", "Mouse"
            };

            string[] products3 = new string[]
            {
                "T-Shirt", "Pantolon", "Boxer"
            };

            //for loop ile listbox item ekleme
            for (int i = 0; i < products.Length; i++)
            {
                lbxProducts.Items.Add(products[i]);
            }

            //foreach loop ile listbox item ekleme
            foreach (var product in products2)
            {
                lbxProducts.Items.Add(product);
            }

            //while loop ile listbox item ekleme
            int counter = 0;
            while (counter < products3.Length)
            {
                lbxProducts.Items.Add(products3[counter]);
                counter++;
            }

            if (lbxProducts.SelectedItem == null)
            {
                btnAddToCart.Enabled = false;
            }

            if (lbxCart.Items.Count == 0)
            {
                btnDeleteCart.Enabled = false;
            }
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnDeleteCart.Enabled = true;
                lbxProducts.Items.Remove(lbxProducts.SelectedItem);
                btnAddToCart.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bir ürün seçiniz.");
            }
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxProducts.Items.Add(lbxCart.SelectedItem);
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Bir ürün seçiniz.");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnDeleteCart.Enabled = false;
            }
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                btnAddToCart.Enabled = true;
            }
        }
    }
}
