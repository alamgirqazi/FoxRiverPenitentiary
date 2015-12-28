using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
   public class InventoryDA
    {

           FoxRiverDatabaseEntities3 dbcontext;

           public InventoryDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }
        public bool Insert(inventory pris)
        {
            dbcontext.inventories.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }

    }
}
