using MiniWebShop.Controllers;
using MiniWebShop.Models;
using MiniWebShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWebShop
{
    public partial class InitialView : Form
    {
        AddToCart cart = new AddToCart();
        public InitialView()
        {
            InitializeComponent();
             
        }

        private void InitialView_Load(object sender, EventArgs e)
        {
            LoadProducts();          

            
        }

        
        

        private void LoadProducts()
        {
            productsDgv.DataSource = null;
            productsDgv.DataSource = GetProducts.GetAllProducts();
            productsDgv.Columns[0].Visible = false;
            productsDgv.Columns[4].Visible = false;
            productsDgv.Columns[5].Visible = false;
            productsDgv.Columns[6].Visible = false;
            productsDgv.Columns[7].Visible = false;
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            Proizvod product = productsDgv.CurrentRow.DataBoundItem as Proizvod;
            cart.AddProductToCart(product);
            
        }

        private void viewCartBtn_Click(object sender, EventArgs e)
        {
            
            deleteProductFromCart cartView = new deleteProductFromCart(cart.ReturnProductsInCart());
            cartView.ShowDialog();
        }
    }
}
