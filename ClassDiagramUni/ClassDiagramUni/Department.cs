using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramUni
{
    public class Department
    {
        public string name { get; set; }
        public string code { get; set; }

        public Department(string Name, string code)
        {
            this.name = Name;
            this.code = code;
        }

        public void addCourse(Course course)
        {
            course.Add(course);
        }
    }
}
