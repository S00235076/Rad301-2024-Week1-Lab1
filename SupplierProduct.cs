using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class SupplierProduct
    {
        public int SupplierID { get; set; }

        public int ProductID { get; set; }

        public DateTime DateFirstSupplied { get; set; }
    }

    List<int> spSupplierID = new List<int> { 1, 1, 2, 2 };
    List<int>  spProductID = new List<int> { "9 inch nails", "9 inch bolts", "Chimney Hoover", "Washing Machine" };
    List<DateTime> DateFirstOffered = new List<DateTime> { 12/12/2012, 13/08/2017, 09/09/2022,11/04/2024 };
}
