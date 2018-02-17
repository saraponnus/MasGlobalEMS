using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalEMSCore
{
    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public float HourlySalary { get; set; }
        public float MonthlySalary { get; set; }
  
    }
}
