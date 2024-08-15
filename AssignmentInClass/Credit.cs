using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInClass
{
    public class Credit : Payment
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime ExpDate { get; set; }

        public bool Authorized() 
        {
            return true; 
        }
    }
}
