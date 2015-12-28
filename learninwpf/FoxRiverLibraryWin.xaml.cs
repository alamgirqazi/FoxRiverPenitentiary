using learn_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewModels;

namespace learninwpf
{
   
    public partial class FoxRiverLibraryWin : MahApps.Metro.Controls.MetroWindow
    {
        FoxRiverLibraryViewModel vm;

        public FoxRiverLibraryWin()
        {
            InitializeComponent();
            vm = new FoxRiverLibraryViewModel();
            this.DataContext = vm;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            FoxRiverLibraryFactory prisfac = new FoxRiverLibraryFactory();

        }

           public void validations()
      {
          txtaname.GetBindingExpression(TextBox.TextProperty).UpdateSource();
          txtbid.GetBindingExpression(TextBox.TextProperty).UpdateSource();
          txtbname.GetBindingExpression(TextBox.TextProperty).UpdateSource();
          txtbshelfnum.GetBindingExpression(TextBox.TextProperty).UpdateSource();
          txtcopies.GetBindingExpression(TextBox.TextProperty).UpdateSource();
           
      }


        private void clearform()
        {

txtaname.Clear();      
            txtbid.Clear();
            txtbname.Clear();
            txtbshelfnum.Clear();
            txtcopies.Clear();    
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
           validations();
            if (Validation.GetHasError(txtaname) || Validation.GetHasError(txtbid) || Validation.GetHasError(txtbname)
                || Validation.GetHasError(txtbshelfnum) || Validation.GetHasError(txtcopies))
            {
                MessageBox.Show("Please Fill the required fields.");
                return;
            }

            foxriverlibrary lib = new foxriverlibrary();
            lib.book_author_name=txtaname.Text.Trim();
            lib.book_copies=int.Parse(txtcopies.Text);
            lib.book_id=txtbid.Text.Trim();
            lib.book_name=txtbname.Text.Trim();
            lib.book_shelf_num=txtbshelfnum.Text.Trim();

FoxRiverLibraryFactory libfactory = new FoxRiverLibraryFactory();

            if (libfactory.Insert(lib))
            {
                MessageBox.Show("Inserted");
                clearform();
            }
            else
                MessageBox.Show("Not Inserted");        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            clearform();
        }  
      
    }
}
