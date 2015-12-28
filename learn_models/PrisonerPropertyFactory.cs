using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
  public  class PrisonerPropertyFactory
    {
        prisoner_property_cashDA _dbobj;

        public PrisonerPropertyFactory()
        {
            _dbobj = new prisoner_property_cashDA();

        }

        public bool Insert(prisoner_property_cash obj)
        {
            return _dbobj.Insert(obj);
        }
        public List<prisoner_info> GetAll()
        {
            return _dbobj.SelectAll();
        }

    }
}
