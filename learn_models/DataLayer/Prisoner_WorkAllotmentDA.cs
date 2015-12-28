using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
   public class Prisoner_WorkAllotmentDA
    {

               FoxRiverDatabaseEntities3 dbcontext;

               public Prisoner_WorkAllotmentDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }


        public bool Insert(prisoner_work_allotment pris)
        {

            dbcontext.prisoner_work_allotment.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }


    }
}
