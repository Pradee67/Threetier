using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threetier_DataAccessLayer.Repository.Entities;

namespace Threetier_DataAccessLayer.IRepository
{
    public interface Iemployee
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
    }
}
