using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
    public class EmployeeDA
    {
        
        FoxRiverDatabaseEntities3 dbcontext;

        public EmployeeDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }

        public bool Insert(Employee pris)
        {

            dbcontext.Employees.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }
    }
}
