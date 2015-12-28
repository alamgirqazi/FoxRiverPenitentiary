using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class FoxRiverLibraryViewModel: IDataErrorInfo 
    {
        private string Book_id { get; set; }
        public string book_id
        {
            get { return Book_id; }
            set { Book_id = value; }
        }

        
        private string Book_name { get; set; }
        public string book_name
        {
            get { return Book_name; }
            set { Book_name = value; }
        }



        private string Book_author_name { get; set; }
        public string book_author_name
        {
            get { return Book_author_name; }
            set { Book_author_name = value; }
        }

        
        
        private int Book_copies { get; set; }
        public int book_copies
        {
            get { return Book_copies; }
            set { Book_copies = value; }
        }

        
        private string Book_shelf_num { get; set; }
        public string book_shelf_num
        {
            get { return Book_shelf_num; }
            set { Book_shelf_num = value; }
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

                if (propName == "book_id")
                {
                    if (string.IsNullOrEmpty(this.Book_id))
                    {
                        result = "ID is required";
                    }
                }

                else if (propName == "book_name")
                {
                    if (string.IsNullOrEmpty(this.Book_name))
                    {
                        result = "Name is required";
                    }
                }
                else if (propName == "book_author_name")
                {
                    if (string.IsNullOrEmpty(this.Book_author_name))
                    {
                        result = "Author name is required";
                    }
                }

                else if (propName == "book_copies")
                {
                    if (this.Book_copies <= 0)
                    {
                        result = "Number of copies is required (in integer)";
                    }
                }

                else if (propName == "book_shelf_num")
                {
                    if (string.IsNullOrEmpty(this.Book_shelf_num))
                    {
                        result = "Shelf Number is required";
                    }
                }
              

                return result;
            }
        }
    }
}
