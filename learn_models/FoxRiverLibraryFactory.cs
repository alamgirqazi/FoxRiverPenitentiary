using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
    public class FoxRiverLibraryFactory
    {

         FoxRiverLibraryDA _dbobj;

         public FoxRiverLibraryFactory()
        {
            _dbobj = new FoxRiverLibraryDA();

        }

        public bool Insert(foxriverlibrary obj)
        {
            return _dbobj.Insert(obj);
        }


    }
}
