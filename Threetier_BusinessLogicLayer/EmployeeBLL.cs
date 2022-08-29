
using System;
using Threetier_DataAccessLayer.Repository.Entities;

namespace Threetier_BusinessLogicLayer
{
    public class EmployeeBLL
    {
        private Threetier_DataAccessLayer.EmployeeDAL _DAL;

        public EmployeeBLL()
        {
            _DAL = new Threetier_DataAccessLayer.EmployeeDAL();
        }

       

        public List<Employee> GetALlEmployees()
        {
            var employees= _DAL.GetEmployees();
            if(employees==null)
            {
                throw new Exception("Employees not Found");
            }

            return employees;
        }

        

        public void AddEmployees(Employee e)
        {
            _DAL.AddEmployee(e);

        }

        
    }
}