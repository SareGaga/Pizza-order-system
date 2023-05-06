using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _20210305502SareGaga
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Order_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(String key)
        {
            var result = _productDal.GetByName(key);    // veritabanından arama yoluyla çekiyoruz.
            dgwProducts.DataSource = result;
        }



        private void Btn_Click(object sender, EventArgs e)
        {
            {
                // Diğer formu oluştur
                last last = new last();

                // Diğer formu göster
                last.Show();

                // Mevcut formu gizle
                this.Hide();


                LoadProducts();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),    
                PizzaName= tbxNameUpdate.Text,
                Ingredients = tbxIngredientsUpdate.Text,
                //Price= Convert.ToDecimal(tbxPriceUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated");
        }

        private void DgwProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxIngredientsUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            //tbxPriceUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void DgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
