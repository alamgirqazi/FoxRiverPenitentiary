using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class PrisonerWorkAllotmentViewModel : IDataErrorInfo
    {

       private int P_id { get; set; }

        public int p_id 
        
        {
        get { return P_id; }
        set { P_id = value; }
        }

        private string Work_type { get; set; }
        public string work_type
        {
            get { return Work_type; }
            set { Work_type = value; }
        }

        private string Work_shifttime { get; set; }
        public string work_shifttime
        {
            get { return Work_shifttime; }
            set { Work_shifttime = value; }
        }


        public string Error
        {
            get
            {
                return null;
            }
        }

            public string this[string propName]
            {
                get
                {

                    string result = null;

                    if (propName == "p_id")
                    {
                        if (this.P_id <= 0)
                        {
                            result = "ID is required";
                        }
                    }

                    else if (propName == "work_type")
                    {
                        if (string.IsNullOrEmpty(this.Work_type))
                        {
                            result = "Work Type is required";
                        }
                    }

                    else if (propName == "work_shifttime")
                    {
                        if (string.IsNullOrEmpty(this.Work_shifttime))
                        {
                            result = "Shift Type is required";
                        }
                    }



                    return result;
                }
            }
    }
}
