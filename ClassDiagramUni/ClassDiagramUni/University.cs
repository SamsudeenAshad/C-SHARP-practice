using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramUni
{
    public class University
    {
        public string name { get; set; }
        public string location { get; set; }
        public University( String Name, String Location ) 
        {
            Name = name;
            Location = location;
        }

        public void addDepartment(Department dep)
        {
            department.add(dep);
        }

        public List<Department>departments { get; set; }

        public List<Department> GetDepartments()
        {
        }

        University uni1 = new University("NSBM", "Homagama");
    }
}
