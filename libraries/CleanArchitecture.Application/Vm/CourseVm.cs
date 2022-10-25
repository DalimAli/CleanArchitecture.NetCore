using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Vm
{
    public class CourseVm
    {
       public IEnumerable<Course> Courses { get; set; }   
    }
}
