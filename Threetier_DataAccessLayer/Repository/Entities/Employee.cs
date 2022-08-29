using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threetier_DataAccessLayer.Repository.Entities
{
    public class Employee
    {
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }
        public int salary{ get; set; }
    }
}
