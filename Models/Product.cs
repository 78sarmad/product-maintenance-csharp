using System;

namespace Product_Maintenance.Models
{
    class Product
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public String MFG_Date { get; set; }
        public String Expiry_Date { get; set; }
        public bool Discontinued { get; set; }
    }
}
