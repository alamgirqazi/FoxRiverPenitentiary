using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
    public class InventoryFactory
    {

         InventoryDA _dbobj;

         public InventoryFactory()
        {
            _dbobj = new InventoryDA();

        }

        public bool Insert(inventory obj)
        {
            return _dbobj.Insert(obj);
        }


    }
}
