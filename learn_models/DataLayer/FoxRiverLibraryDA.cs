using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
    public class FoxRiverLibraryDA
    {
            FoxRiverDatabaseEntities3 dbcontext;

            public FoxRiverLibraryDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }
        public bool Insert(foxriverlibrary pris)
        {

            dbcontext.foxriverlibraries.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }


    }
}
