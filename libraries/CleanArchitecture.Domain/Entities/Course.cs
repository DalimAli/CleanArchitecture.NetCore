using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public class Course: Audit
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
