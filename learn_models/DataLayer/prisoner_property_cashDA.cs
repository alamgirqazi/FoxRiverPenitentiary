using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models.DataLayer
{
   public class prisoner_property_cashDA
    {


        FoxRiverDatabaseEntities3 dbcontextproperty;

        public prisoner_property_cashDA()
        {

            dbcontextproperty = new FoxRiverDatabaseEntities3();

        }


        public bool Insert(prisoner_property_cash pris)
        {

            dbcontextproperty.prisoner_property_cash.Add(pris);
            return dbcontextproperty.SaveChanges() > 0;
     
        }
        public List<prisoner_info> SelectAll()
        {
            return dbcontextproperty.prisoner_info.ToList();
        }


    }
}
