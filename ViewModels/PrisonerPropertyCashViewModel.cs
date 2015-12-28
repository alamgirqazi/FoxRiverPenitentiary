using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
  public  class PrisonerPropertyCashViewModel: IDataErrorInfo 
    {
        private int P_id { get; set; }
        public int p_id
        {
            get { return P_id; }
            set { P_id = value; }
        }


        private string P_items { get; set; }
        public string p_items
        {
            get { return P_items; }
            set { P_items = value; }
        }


        private int Item_roomnum { get; set; }
        public int item_roomnum
        {
            get { return Item_roomnum; }
            set { Item_roomnum = value; }
        }

        public string Item_shelfnum { get; set; }

        public string item_shelfnum
        {
            get { return Item_shelfnum; }
            set { Item_shelfnum = value; }
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

                else if (propName == "p_items")
                {
                    if (string.IsNullOrEmpty(this.P_items))
                    {
                        result = "Items are required";
                    }
                }

                else if (propName == "item_roomnum")
                {
                    if (this.Item_roomnum <= 0)
                    {
                        result = "Room Number is required (in integers)";
                    }
                }
               
                else if (propName == "item_shelfnum")
                {
                    if (string.IsNullOrEmpty(this.Item_shelfnum))
                    {
                        result = "Shelf Number is required";
                    }
                }
                return result;
            }
        }
    }
}
