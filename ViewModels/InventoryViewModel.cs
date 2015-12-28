using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class InventoryViewModel: IDataErrorInfo
    {

        private string Item_id { get; set; }
        public string item_id
        {
            get { return Item_id; }
            set { Item_id = value; }
        }


        private string Item_name { get; set; }
        public string item_name
        {
            get { return Item_name; }
            set { Item_name = value; }
        }


        private int Item_quantity { get; set; }
        public int item_quantity
        {
            get { return Item_quantity; }
            set { Item_quantity = value; }
        }


        public Nullable<System.DateTime> item_expiry { get; set; }


        private string Item_type { get; set; }
        public string item_type
        {
            get { return Item_type; }
            set { Item_type = value; }
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

                if (propName == "item_quantity")
                {
                    if (this.Item_quantity <= 0)
                    {
                        result = "Quantity is required";
                    }
                }

                else if (propName == "item_id")
                {
                    if (string.IsNullOrEmpty(this.Item_id))
                    {
                        result = "Item ID is required";
                    }
                }

                else if (propName == "item_name")
                {
                    if (string.IsNullOrEmpty(this.Item_name))
                    {
                        result = "Item Name is required";
                    }
                }

                else if (propName == "item_type")
                {
                    if (string.IsNullOrEmpty(this.Item_type))
                    {
                        result = "Item type is required";
                    }
                }



                return result;
            }
        }





    }
}
