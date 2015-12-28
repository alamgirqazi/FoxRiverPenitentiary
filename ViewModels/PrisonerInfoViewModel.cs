using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class PrisonerInfoViewModel : IDataErrorInfo
    {

        public int p_id { get; set; }


        public string p_name
        {
            get { return P_name; }
            set { P_name = value; }

        }
        private string P_name { get; set; }


        public string p_cnic
        {
            get { return P_cnic; }
            set { P_cnic = value; }
        }
        private string P_cnic { get; set; }


        public string p_address
        {
            get { return P_address; }
            set { P_address = value; }
        }
        private string P_address { get; set; }

        public string p_homenum
        {
            get { return P_homenum; }
            set { P_homenum = value; }
        }
        private string P_homenum { get; set; }



        public bool p_maritalstatus { get; set; }

        public string p_block
        {
            get { return P_block; }
            set { P_block = value; }
        }
        private string P_block { get; set; }


        public string p_roomnum
        {
            get { return P_roomnum; }
            set { P_roomnum = value; }
        }

        private string P_roomnum { get; set; }



        public System.DateTime p_dateofarrival
        {
            get;
            set; 
        }
     
        public System.DateTime p_dateofrelease
        {
            get;
            set; 
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

                if (propName == "p_name")
                {
                    if (string.IsNullOrEmpty(this.P_name))
                    {
                        result = "Name is required";
                    }
                }

                else if (propName == "p_address")
                {
                    if (string.IsNullOrEmpty(this.P_address))
                    {
                        result = "Address is required";
                    }
                }
                else if (propName == "p_homenum")
                {
                    if (string.IsNullOrEmpty(this.P_homenum))
                    {
                        result = "Home Number is required";
                    }
                }

                else if (propName == "p_cnic")
                {
                    if (string.IsNullOrEmpty(this.P_cnic))
                    {
                        result = "CNIC Number is required";
                    }
                }
                else if (propName == "p_roomnum")
                {
                    if (string.IsNullOrEmpty(this.P_roomnum))
                    {
                        result = "Room Number is required";
                    }
                }
                else if (propName == "p_block")
                {
                    if (string.IsNullOrEmpty(this.P_block))
                    {
                        result = "Block Number is required";
                    }
                }
        
                
                return result;
                    }
                }
            }
        }


