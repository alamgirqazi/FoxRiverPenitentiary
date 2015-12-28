using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
   public class Prisoner_MedicalDA
    {
       
               FoxRiverDatabaseEntities3 dbcontext;

               public Prisoner_MedicalDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }


        public bool Insert(Prisoner_Medical pris)
        {

            dbcontext.Prisoner_Medical.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }

    }
}
