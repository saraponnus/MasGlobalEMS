using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalEMSBL
{
  
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public float HourlySalary { get; set; }
        public float MonthlySalary { get; set; }
        public float AnnualSalary { get; set; }
        public virtual float GetAnnualSalary()
        {
            return AnnualSalary;
        }
    }
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee()
        {
           
        }
        public override float GetAnnualSalary()
        {
            AnnualSalary = 120 * 12 * HourlySalary;
            return AnnualSalary;
        }
    }

    public class MonthlyEmployee : Employee
    {
        public MonthlyEmployee()
        {
            
        }
        public override float GetAnnualSalary()
        {
            AnnualSalary = 12 * MonthlySalary;
            return AnnualSalary;
        }
    }

    public class EmployeeFactory
    {
        public Employee ChooseEmployee(string contractType)
        {
            if (string.IsNullOrEmpty(contractType))
                contractType = "MonthlySalaryEmployee";
            switch (contractType)
            {
                case "HourlySalaryEmployee":
                    return new HourlyEmployee();
                default:
                    return new MonthlyEmployee();
            }
           
        }
    }
}
