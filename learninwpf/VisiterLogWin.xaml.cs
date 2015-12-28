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
    /// <summary>
    /// Interaction logic for VisiterLogWin.xaml
    /// </summary>
    public partial class VisiterLogWin : MahApps.Metro.Controls.MetroWindow
    {
        VisiterLogViewModel vm;

         public VisiterLogWin()
        {
            InitializeComponent();
            vm = new VisiterLogViewModel();
            this.DataContext = vm;
        }
         private void Grid_Loaded(object sender, RoutedEventArgs e)
         {
             VisiterLogFactory visfac = new VisiterLogFactory();


         }

         public void validations()
         {
             txtpid.GetBindingExpression(TextBox.TextProperty).UpdateSource();
             txtvid.GetBindingExpression(TextBox.TextProperty).UpdateSource();
             txtvname.GetBindingExpression(TextBox.TextProperty).UpdateSource();
             txtvaddress.GetBindingExpression(TextBox.TextProperty).UpdateSource();
             txtphonenum.GetBindingExpression(TextBox.TextProperty).UpdateSource();
             txtrelation.GetBindingExpression(TextBox.TextProperty).UpdateSource();
          

         }


         private void clearform()
         {
             txtpid.Clear();
             txtvid.Clear();
             txtvname.Clear();
             txtvaddress.Clear();
             txtphonenum.Clear();
             txtrelation.Clear();
             txttime.Clear();
             datepickerdate.SelectedDate = null;

         }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(txtpid) || Validation.GetHasError(txtvid) || Validation.GetHasError(txtvname)
                || Validation.GetHasError(txtvaddress) || Validation.GetHasError(txtphonenum) || Validation.GetHasError(txtrelation))
            {
                MessageBox.Show("Please Fill the required fields.");
                return;
            }
         


            VisiterLog vis = new VisiterLog();
            vis.p_id = Convert.ToInt32(txtpid.Text.Trim());
            vis.visiter_id = txtvid.Text.Trim();
            vis.visiter_name = txtvname.Text.Trim();
            vis.visiter_address = txtvaddress.Text.Trim();
            vis.visiter_phonenum = txtphonenum.Text.Trim();
            vis.visiter_relation = txtrelation.Text.Trim();

            vis.v_date = datepickerdate.SelectedDate.Value;

            vis.v_time = txttime.Text.Trim();


            VisiterLogFactory visFactory = new VisiterLogFactory();


            if (visFactory.Insert(vis))
            {
                MessageBox.Show("Inserted");
                txtvid.Focus();
                clearform();
            }
            else
            {
                MessageBox.Show("Not Inserted");
                validations();
            }          

      
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            clearform();
        }  
    }
}
