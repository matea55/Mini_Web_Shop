﻿using MiniWebShop.Controllers;
using MiniWebShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWebShop.Views
{
    public partial class deleteProductFromCart : Form
    {
        List<Proizvod> products;
        
        public deleteProductFromCart (List<Proizvod> products)
        {
            InitializeComponent();
            
            this.products = products;
            
        }

        private void CartView_Load(object sender, EventArgs e)
        {
            ShowProductsInCart();
            ShowTotalPrice();
        }

        private void ShowTotalPrice()
        {
            decimal total = 0;
            foreach (var item in products)
            {
                total += item.Cijena;

            }
            totalAmountLbl.Text = total.ToString();
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            

            RemoveProductFromCart();
            
            ShowProductsInCart();

            ShowTotalPrice();

        }

        private void RemoveProductFromCart()
        {
            Proizvod product = productListInCartDgv.CurrentRow.DataBoundItem as Proizvod;
            products.Remove(product);
            product.Kolicina++;
        }

        private void ShowProductsInCart()
        {
            productListInCartDgv.DataSource = null;
            productListInCartDgv.DataSource = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            payBtn orderView = new payBtn(products);
            orderView.Show();
        }
    }
}
