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

namespace MiniWebShop
{
    public partial class InitialView : Form
    {
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
    }
}
