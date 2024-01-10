using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4Phase4
{
    public class Product
    {
        public string PName { get; set; }
        public double PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        //public string PName { get; }
        //public double PPrice { get; }
        //public string PBrand { get; }
        //public string ManufacturingDate { get; }
        //public string ExpiryDate { get; }

        //public Product(string name, double price, string brand, string manufacturingDate, string expiryDate)
        //{
        //    PName = name;
        //    PPrice = price;
        //    PBrand = brand;
        //    ManufacturingDate = manufacturingDate;
        //    ExpiryDate = expiryDate;
        //}
    }
}
