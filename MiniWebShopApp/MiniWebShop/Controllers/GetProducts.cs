using MiniWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWebShop
{
    public static class GetProducts
    {
        public static object GetAllProducts()
        {
           
            using(var db = new WebShopModel())
            {
                var product = from p in db.Proizvods                             
                          select p;
                return product.ToList();
            }
            
        }
    }
}
