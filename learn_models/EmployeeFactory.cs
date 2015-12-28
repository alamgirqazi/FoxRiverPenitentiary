using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
    public class EmployeeFactory
    {
         EmployeeDA _dbobj;

         public EmployeeFactory()
        {
            _dbobj = new EmployeeDA();

        }

        public bool Insert(Employee obj)
        {
            return _dbobj.Insert(obj);
        }

    }
}
