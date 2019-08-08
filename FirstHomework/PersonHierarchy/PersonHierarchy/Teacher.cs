using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    public class Teacher : Person
    {

        public Teacher(String firstName, String lastName, String address, TeacherRank teacherRank) : base(firstName, lastName, address)
        {
            this.teacherRank = teacherRank;
        }



        TeacherRank teacherRank { get; set; }
    }
}
