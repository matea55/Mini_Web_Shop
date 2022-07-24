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
    public partial class payBtn : Form
    {
        List<Proizvod> products;
        public payBtn(List<Proizvod> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            cardTxt.Visible = false;
            
        }

        

        

        private void CheckForPaymentMethod()
        {
            if(paymentTxt.Text.Equals("Kartica") || paymentTxt.Text.Equals("kartica"))
            {
                cardTxt.Visible = true;
                label5.Visible=true;
            }
            else if(paymentTxt.Text.Equals("Gotovina") || paymentTxt.Text.Equals("gotvina"))
            {
                cardTxt.Visible = false;
            }
            else
            {
                MessageBox.Show("Krivi unos, molim unesite nacin placanja u ispravnom formatu");
            }
            
        }
        

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            CheckForPaymentMethod();
        }

        private void cardTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuponBtn_Click(object sender, EventArgs e)
        {
            ValidateCupon();
        }

        private void ValidateCupon()
        {
            string enteredCupon = cuponTxt.Text;
            using (var db = new WebShopModel())
            {
                var cupon = from k in db.Popust_kodovi
                            where k.Kod.Equals(enteredCupon)
                            && k.Iskoristen==0
                              select k;
                if (cupon == null)
                {
                    MessageBox.Show("Taj kupon je vec iskoristen");
                }
                else
                {
                    MessageBox.Show("Kupon je ispravan");
                }
            }
            
            
        }
    }
}
