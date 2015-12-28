using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class EmployeeViewModel : IDataErrorInfo
    {



        private string Employee_id { get; set; }
        public string employee_id
        {
            get { return Employee_id; }
            set { Employee_id = value; }
        }


        private string Employee_name { get; set; }
        public string employee_name
        {
            get { return Employee_name; }
            set { Employee_name = value; }
        }

        
        private string Emp_designation { get; set; }
        public string emp_designation
        {
            get { return Emp_designation; }
            set { Emp_designation = value; }
        }


        private string Emp_duty_timing { get; set; }
        public string emp_duty_timing
        {
            get { return Emp_duty_timing; }
            set { Emp_duty_timing = value; }
        }


        private string Emp_cnic { get; set; }
        public string emp_cnic
        {
            get { return Emp_cnic; }
            set { Emp_cnic = value; }
        }


        private string Emp_address { get; set; }
        public string emp_address
        {
            get { return Emp_address; }
            set { Emp_address = value; }
        }


        private string Emp_maritalstatus { get; set; }
        public string emp_maritalstatus
        {
            get { return Emp_maritalstatus; }
            set { Emp_maritalstatus = value; }
        }


        private string Emp_number { get; set; }
        public string emp_number
        {
            get { return Emp_number; }
            set { Emp_number = value; }
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

                if (propName == "employee_id")
                {
                    if (string.IsNullOrEmpty(this.Employee_id))
                    {
                        result = "ID is required";
                    }
                }

                else if (propName == "employee_name")
                {
                    if (string.IsNullOrEmpty(this.Employee_name))
                    {
                        result = "Name is required";
                    }
                }
                else if (propName == "emp_designation")
                {
                    if (string.IsNullOrEmpty(this.Emp_designation))
                    {
                        result = "Designation is required";
                    }
                }

                else if (propName == "emp_duty_timing")
                {
                    if (string.IsNullOrEmpty(this.Emp_duty_timing))
                    {
                        result = "Required";
                    }
                }
                else if (propName == "emp_cnic")
                {
                    if (string.IsNullOrEmpty(this.Emp_cnic))
                    {
                        result = "CNIC Number is required";
                    }
                }
                else if (propName == "emp_address")
                {
                    if (string.IsNullOrEmpty(this.Emp_address))
                    {
                        result = "Address is required";
                    }
                }
                else if (propName == "emp_maritalstatus")
                {
                    if (string.IsNullOrEmpty(this.Emp_maritalstatus))
                    {
                        result = "Required";
                    }
                }
                else if (propName == "emp_number")
                {
                    if (string.IsNullOrEmpty(this.Emp_number))
                    {
                        result = "Phone Number is required";
                    }
                }


                return result;
            }
        }
    }
}
