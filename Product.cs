using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class Product
    {
        public int ProductId { get; set; }

        public string Description { get; set; }

        public int QuantityInStock { get; set; }

        public float UnitPrice { get; set; }

        public int CategoryID { get; set; }
    }

    List<int> ProductID = new List<int> { 1, 2, 3, 4 };
    List<string> pDescription = new List<string> { "9 inch nails", "9 inch bolts", "Chimney Hoover", "Washing Machine" };
    List<int> pQuantity = new List<int> { 200,120,10,7 };
    List<double> pUnitPrice = new List<double> { 0.1,0.2,100.30,399.50 };
    List<int> pCategoryID = new List<int> { 1, 1, 2, 2};
}
