using MasGlobalEMSCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalEmpInfra
{
    public class EmpRepository : IEmpRepository
    {
        private IEnumerable<Emp> emplist = new List<Emp>();
        private EmpClient empClient = new EmpClient();

        public EmpRepository()
        {
            try
            {
                emplist = empClient.GetEmployeesAsync().Result;
            }
            catch (Exception ex)
            {
                string x = ex.StackTrace;
                throw ex;
            }
            

        }
        public IEnumerable<Emp> GetAll()
        {
            return emplist;
        }
        public Emp GetByID(int id)
        {
            return emplist.Where(p => p.ID == id).FirstOrDefault();
        }
        
    }
}
