using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF.Models
{
    public class FullTimeEmployee : Employee
    {
        public decimal? Salary { get; set; }
    }
}
