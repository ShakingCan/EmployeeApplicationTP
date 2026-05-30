using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeApplicationTP
{
    internal interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }
        void computeSalary(int hoursWorked, double rate);

    }
}
