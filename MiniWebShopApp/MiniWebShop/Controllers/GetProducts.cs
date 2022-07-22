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
        public static List<Proizvod> GetAllProducts()
        {
           List<Proizvod> product;
            using(var db = new WebShopModel())
            {
                product = db.Proizvods.ToList();
            }
            return product;
        }
    }
}
