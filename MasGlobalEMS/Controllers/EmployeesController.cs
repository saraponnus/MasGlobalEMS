using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MasGlobalEMSCore;
using MasGlobalEMSBL;
using MasGlobalEmpInfra;
using System.Collections;

namespace MasGlobalEMS.Controllers
{
    public class EmployeesController : ApiController
    {
        EmpRepository rep;
        EmpAdapter ada;
        public EmployeesController()
        {
            rep = new EmpRepository();
            ada = new EmpAdapter();
        }
        //public Employee GetEmployee(int id)
        //{
        //    Emp emp = rep.GetByID(id);
        //    Employee employee = ada.MatchEmployee(emp);
        //    return employee;
        //}

        public IEnumerable<Employee> GetEmployee(int id)
        {
            Emp emp = rep.GetByID(id);
            Employee employee = ada.MatchEmployee(emp);

            List<Employee> emplist = new List<Employee>();
            emplist.Add(employee);
            return emplist;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            IEnumerable<Emp> emplist = rep.GetAll();
            IEnumerable<Employee> employeelist = ada.MatchEmployees(emplist);
            return employeelist;
        }
    }
}
