using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_models
{
    public class VisiterLogFactory
    {
         VisiterLogDA _dbobj;

         public VisiterLogFactory()
        {
            _dbobj = new VisiterLogDA();

        }

        public bool Insert(VisiterLog obj)
        {
            return _dbobj.Insert(obj);
        }


    }
}
