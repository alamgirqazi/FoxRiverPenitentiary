using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class CrimeInformationViewModel: IDataErrorInfo 
    {

        private int Crime_id { get; set; }
        public int crime_id
        {
            get { return Crime_id; }
            set { Crime_id = value; }
        }

        private string Crime_title { get; set; }
        public string crime_title
        {
            get { return Crime_title; }
            set { Crime_title = value; }
        }

        private string Crime_punishment { get; set; }
        public string crime_punishment
        {
            get { return Crime_punishment; }
            set { Crime_punishment = value; }
        }

        private string Crime_fine { get; set; }
        public string crime_fine
        {
            get { return Crime_fine; }
            set { Crime_fine = value; }
        }

        public bool crime_bail { get; set; }


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

                if (propName == "crime_id")
                {
                    if (this.Crime_id <= 0)
                    {
                        result = "Crime ID is required";
                    }
                }

                else if (propName == "crime_title")
                {
                    if (string.IsNullOrEmpty(this.Crime_title))
                    {
                        result = "Title is required";
                    }
                }

                else if (propName == "crime_punishment")
                {
                    if (string.IsNullOrEmpty(this.Crime_punishment))
                    {
                        result = "required field";
                    }
                }

                else if (propName == "crime_fine")
                {
                    if (string.IsNullOrEmpty(this.Crime_fine))
                    {
                        result = "required field";
                    }
                }
                return result;
            }
        }
    }
}

