using Threetier_DataAccessLayer.IRepository;
using Threetier_DataAccessLayer.Repository;
using Threetier_DataAccessLayer.Repository.Entities;

namespace Threetier_DataAccessLayer
{
    public class EmployeeDAL : Iemployee
    {
        public void AddEmployee(Employee employee)
        {
            var db = new EmployeeDbContext();
            db.Add(employee);
            db.SaveChanges();
        }

        public List<Employee> GetEmployees()
        {
            var db = new EmployeeDbContext();
            var list = db.employees.ToList();
            return list;

        }



    }
}