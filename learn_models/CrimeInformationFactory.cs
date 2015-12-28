using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
  public  class CrimeInformationFactory
    {
        
        Prisoner_Crime_InformationDA _dbobj;

        public CrimeInformationFactory()
        {
            _dbobj = new Prisoner_Crime_InformationDA();

        }

        public bool Insert(Crime_Information obj)
        {
            return _dbobj.Insert(obj);
        }

    }
}
