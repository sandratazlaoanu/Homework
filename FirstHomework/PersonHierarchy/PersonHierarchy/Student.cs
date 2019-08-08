using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    public class Student : Person
    {
        public Student(String firstName, String lastName, String address, String id, double average) : base(firstName, lastName, address)
        {
            this.ID = id;
            this.Average = average;
        }

        String ID { get; set; }
        double Average { get; set; }
    }
}
