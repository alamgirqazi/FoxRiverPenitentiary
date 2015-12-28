using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class VisiterLogViewModel : IDataErrorInfo
    {

        private string Visiter_id { get; set; }
        public string visiter_id
        {
            get { return Visiter_id; }
            set { Visiter_id = value; }
        }


        private string Visiter_name { get; set; }
        public string visiter_name
        {
            get { return Visiter_name; }
            set { Visiter_name = value; }
        }


        public int P_id { get; set; }
        public int p_id
        {
            get { return P_id; }
            set { P_id = value; }
        }

        private string Visiter_address { get; set; }
        public string visiter_address
        {
            get { return Visiter_address; }
            set { Visiter_address = value; }
        }

        private string Visiter_phonenum { get; set; }
        public string visiter_phonenum
        {
            get { return Visiter_phonenum; }
            set { Visiter_phonenum = value; }
        }



        private string Visiter_relation { get; set; }
        public string visiter_relation
        {
            get { return Visiter_relation; }
            set { Visiter_relation = value; }
        }




        public Nullable<System.DateTime> v_date { get; set; }
        public string v_time { get; set; }

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

                if (propName == "visiter_id")
                {
                    if (string.IsNullOrEmpty(this.Visiter_id))
                    {
                        result = "ID is required";
                    }
                }

                else if (propName == "visiter_name")
                {
                    if (string.IsNullOrEmpty(this.Visiter_name))
                    {
                        result = "Name is required";
                    }
                }
           

                else if (propName == "p_id")
                {
                    if (this.P_id <= 0)
                    {
                        result = "ID is required (in integer)";
                    }
                }



                else if (propName == "visiter_address")
                {
                    if (string.IsNullOrEmpty(this.Visiter_address))
                    {
                        result = "Address is required";
                    }
                }

                else if (propName == "visiter_phonenum")
                {
                    if (string.IsNullOrEmpty(this.Visiter_phonenum))
                    {
                        result = "Phone Number is required";
                    }
                }


                else if (propName == "visiter_relation")
                {
                    if (string.IsNullOrEmpty(this.Visiter_relation))
                    {
                        result = "required";
                    }
                }


                return result;
            }
        }



    }
}
