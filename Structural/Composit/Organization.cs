using System.Collections.Generic;

namespace Composit
{
    public class Organization
    {
        private List<IEmployee> _employees = new List<IEmployee>();

        public List<IEmployee> GetEmployees => _employees;
        public void AddEmployee(IEmployee employee) => _employees.Add(employee);
    }
}