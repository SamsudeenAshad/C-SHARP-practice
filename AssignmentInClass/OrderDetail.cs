using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInClass
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public string TaxStatus { get; set; }
        public Item Item { get; set; }

        public float CalcSubTotal() 
        {

        }
        public float CalcWeight() 
        {

        }
        public float CalcTax() 
        {

        }
    }
}
