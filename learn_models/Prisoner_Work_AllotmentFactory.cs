using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
   public class Prisoner_Work_AllotmentFactory
    {
      Prisoner_WorkAllotmentDA _dbobj;

      public Prisoner_Work_AllotmentFactory()
        {
            _dbobj = new Prisoner_WorkAllotmentDA();

        }

        public bool Insert(prisoner_work_allotment obj)
        {
            return _dbobj.Insert(obj);
        }


    }
}
