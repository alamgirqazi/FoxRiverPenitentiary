using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
    public class VisiterLogDA
    {


            FoxRiverDatabaseEntities3 dbcontext;

            public VisiterLogDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }
        public bool Insert(VisiterLog pris)
        {
            dbcontext.VisiterLogs.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }
    }
}
