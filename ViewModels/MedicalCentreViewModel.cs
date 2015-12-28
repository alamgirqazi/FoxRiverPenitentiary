using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class MedicalCentreViewModel: IDataErrorInfo

   {
       private int P_id { get; set; }
       public int p_id
       {
           get { return P_id; }
           set { P_id = value; }
       }


       public System.DateTime p_med_date { get; set; }
    
    
       private string P_disease { get; set; }
       public string p_disease
       {
           get { return P_disease; }
           set { P_disease = value; }
       }

       private int Medicalward_num { get; set; }
       
       public int medicalward_num
       {
           get { return Medicalward_num; }
           set { Medicalward_num = value; }
       }

       private int Bed_num { get; set; }
       public int bed_num
       {
           get { return Bed_num; }
           set { Bed_num = value; }
       }

       private int Numberofdaysspent { get; set; }
       public int numberofdaysspent
       {
           get { return Numberofdaysspent; }
           set { Numberofdaysspent = value; }
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

               else if (propName == "p_disease")
               {
                   if (string.IsNullOrEmpty(this.P_disease))
                   {
                       result = "Description of Disease is required";
                   }
               }

               else if (propName == "medicalward_num")
               {
                   if (this.Medicalward_num<=0)
                   {
                       result = "Medical Ward Number is required (in integer)";
                   }
               }
               else if (propName == "bed_num")
               {
                   if (this.Bed_num <=0)
                   {
                       result = "Bed Number is required (in integer)";
                   }
               }
               else if (propName == "numberofdaysspent")
               {
                   if (this.Numberofdaysspent <= 0)
                   {
                       result = "Number of days spent is required (in integer)";
                   }
               }
               return result;
           }
       }
   }
}
