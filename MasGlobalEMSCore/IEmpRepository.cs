using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalEMSCore
{
    public interface IEmpRepository
    {
        IEnumerable<Emp> GetAll();
        Emp GetByID(int id);

    }
}
