using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInClass
{
    public class Order
    {
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public List<OrderDetail> LineItems { get; set; } = new List<OrderDetail>();
        public List<Payment> Payments { get; set; } = new List<Payment>();

        public float CalcSubTotal()
        {

        }
        public float CalcTax() 
        {
                
        }
        public float CalcTotal()
        {

        }
        public float CalcTotalWeight() 
        {
        
        }
    }
}
