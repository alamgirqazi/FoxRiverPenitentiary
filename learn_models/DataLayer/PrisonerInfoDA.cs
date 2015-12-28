using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace learn_models.DataLayer
{
    public class PrisonerInfoDA
    {

        FoxRiverDatabaseEntities3 dbcontext;

        public PrisonerInfoDA()
        {

            dbcontext = new FoxRiverDatabaseEntities3();

        }
        public bool Insert(prisoner_info pris)
        {

            dbcontext.prisoner_info.Add(pris);
            return dbcontext.SaveChanges() > 0;
     
        }

        //public List<prisoner_info> SelectAll()
        //{
        //    return dbcontext.prisoner_info.ToList();
        //}
        public bool Delete(int Id)
        {
            prisoner_info std = dbcontext.prisoner_info.Where(x => x.p_id == Id).FirstOrDefault();
            if (std != null)
                dbcontext.prisoner_info.Remove(std);
            return dbcontext.SaveChanges() > 0;
        }

        public List<prisoner_info> SelectAllByName(string Name)
        {
            return (from s in dbcontext.prisoner_info
                    where s.p_name == Name
                    select s).ToList();

        }

        public List<PrisonerInfoViewModel> SelectAllNamenAge()
        {
            return (from s in dbcontext.prisoner_info
                    select new PrisonerInfoViewModel
                    {
                        p_id = s.p_id,
                        p_name = s.p_name,
                        p_cnic=s.p_cnic,
                        p_maritalstatus=s.p_maritalstatus,
                        p_address=s.p_address,
                        p_homenum=s.p_homenum
                    }).ToList();
        }






    }
} 