using learn_models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace learn_models
{
    public class PrisonerFactory
    {

        PrisonerInfoDA _dbobj;

        public PrisonerFactory()
        {
            _dbobj = new PrisonerInfoDA();

        }

        public bool Insert(prisoner_info obj)
        {
            return _dbobj.Insert(obj);
        }
        //public List<prisoner_info> SelectAll()
        //{
        //    return _dbobj.SelectAll();
        //}

        public bool Delete(int Id)
        {
            return _dbobj.Delete(Id);
        }

        public List<prisoner_info> GetAllByName(string Name)
        {
            return _dbobj.SelectAllByName(Name);
        }


        public List<PrisonerInfoViewModel> SelectAllNamenAge()
        { return _dbobj.SelectAllNamenAge(); }
    




    


    }
}
