using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1
{
    internal class Supplier
    {
        public int SupplierID { get; set; }

        public string SupplierName { get; set; }

        public string SupplierAddressLine1 { get; set;}

        public string AddressLine2 { get;}
    }

    List<int> sID = new List<int> { 1,2 };
    List<string> sName = new List<string> { "ACME", "Swift Electric" };
    List<string> sAddLine1 = new List<string> { "Collooney", "Finglas" };
    List<string> sAddLine2 = new List<string> { "Sligo", "Dublin" };
}
