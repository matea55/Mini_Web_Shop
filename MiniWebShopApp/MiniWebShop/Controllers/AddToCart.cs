using MiniWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWebShop.Controllers
{
    public class AddToCart
    {
        private List<Proizvod> productsInCart = new List<Proizvod>();
       
        public void AddProductToCart(Proizvod product)
        {
            bool hasEnough = CheckForQuantity(product);
            if (hasEnough)
            {
                productsInCart.Add(product);
                product.Kolicina--;
            }
            else
            {
                MessageBox.Show("Nema vise raspolozivih proizvoda");
            }
            
        }

        private bool CheckForQuantity(Proizvod product)
        {
            if (product.Kolicina > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Proizvod> ReturnProductsInCart()
        {
            return productsInCart;
        }

        



    }
}
