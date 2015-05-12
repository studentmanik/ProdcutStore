using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStore.BLL;
using ProductStore.Model;

namespace ProductStore
{
    public partial class ProductEntryForm : Form
    {
        public ProductEntryForm()
        {
            InitializeComponent();
        }

        Product aProduct = null;
        ProductManager productManager=new ProductManager();
        private void productSaveButton_Click(object sender, EventArgs e)
        {
            aProduct = new Product();
            string productCode = productCodeTextBox.Text;
            string productDescription = productDescriptionTextBox.Text;
            int quantity = Convert.ToInt32(productQuantityTextBox.Text);


            aProduct.ProductCode = productCode;
            aProduct.ProductDescription = productDescription;
            aProduct.Quantity = quantity;

            MessageBox.Show(productManager.InsertProduct(aProduct));
             EmptyTextField();

           
             LoadAllProducts(productManager.GetAllProduct());
        }
        public void LoadAllProducts(List<Product> products)
        {

          
            productShowListView.Items.Clear();
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.ProductCode);
                item.SubItems.Add(product.ProductCode);
                item.SubItems.Add(product.ProductDescription);
                item.SubItems.Add(product.Quantity.ToString());
                productShowListView.Items.Add(item);

            }
        }

        public void EmptyTextField()
        {
            productCodeTextBox.Text = String.Empty;
            productDescriptionTextBox.Text = String.Empty;
            productQuantityTextBox.Text = String.Empty;
            
        }

        private void ProductEntryForm_Load(object sender, EventArgs e)
        {
            LoadAllProducts(productManager.GetAllProduct());
        }
    }
}
