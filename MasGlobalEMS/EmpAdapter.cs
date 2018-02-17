using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MasGlobalEMSCore;
using MasGlobalEMSBL;
using MasGlobalEmpInfra;
namespace MasGlobalEMS
{
    public class EmpAdapter
    {
        public Employee MatchEmployee(Emp emp)
        {
            EmployeeFactory fac = new EmployeeFactory();
            string contractType = emp.ContractTypeName;
            Employee employee = fac.ChooseEmployee(contractType);
            employee.ID = emp.ID;
            employee.Name = emp.Name;
            employee.ContractTypeName = emp.ContractTypeName;
            employee.RoleId = emp.RoleId;
            employee.RoleName = emp.RoleName;
            employee.RoleDescription = emp.RoleDescription;
            employee.HourlySalary = emp.HourlySalary;
            employee.MonthlySalary = emp.MonthlySalary;
            employee.AnnualSalary = employee.GetAnnualSalary();

            return employee;

        }

        public IList<Employee> MatchEmployees(IEnumerable<Emp> emplist)
        {
            IList<Employee> employeelist = new List<Employee>(); 
            foreach (Emp emp in emplist )
            {
                employeelist.Add(MatchEmployee(emp));
            }
            return employeelist;
        }
    }
}