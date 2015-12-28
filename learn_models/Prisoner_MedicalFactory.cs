using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
    public class Prisoner_MedicalFactory
    {

        Prisoner_MedicalDA _dbobj;

        public Prisoner_MedicalFactory()
        {
            _dbobj = new Prisoner_MedicalDA();

        }

        public bool Insert(Prisoner_Medical obj)
        {
            return _dbobj.Insert(obj);
        }

    }
}
