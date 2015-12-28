using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
   public class Prisoner_Crime_InformationDA
    {
                  FoxRiverDatabaseEntities3 dbcontext;

                  public Prisoner_Crime_InformationDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }


        public bool Insert(Crime_Information pris)
        {

            dbcontext.Crime_Information.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }


    }
}
