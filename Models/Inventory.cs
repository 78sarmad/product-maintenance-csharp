using Product_Maintenance.Models;
using System.Collections.Generic;

namespace Product_Maintenance
{
    class Inventory
    {
        public List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }
    }
}
