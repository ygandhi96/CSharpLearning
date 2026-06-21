using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSamples.Entities
{
    public class SalesEmployee : Employee
    {
        public SalesEmployee(int EmployeeId, string FirstName, string LastName) : base(EmployeeId, FirstName, LastName)
        {
        }

        public override double CalculateExpense(double value)
        {
            return base.CalculateExpense(value) * 1.3;
        }
    }
}
