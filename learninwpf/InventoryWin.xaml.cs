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
    /// Interaction logic for InventoryWin.xaml
    /// </summary>
    public partial class InventoryWin : MahApps.Metro.Controls.MetroWindow
    {

        InventoryViewModel vm;

        public InventoryWin()
        {
            InitializeComponent();
            vm = new InventoryViewModel();
            this.DataContext = vm;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            InventoryFactory invfac = new InventoryFactory();
        }

        public void validations()
        {

            txtiid.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtiname.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtiqty.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtitemtype.GetBindingExpression(TextBox.TextProperty).UpdateSource();
           

        }


        private void clearform()
        {
            txtiid.Clear();
            txtiname.Clear();
            txtiqty.Clear();
            txtitemtype.Clear();
        
            datepickerexpiry.SelectedDate = null;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            validations();
            if (Validation.GetHasError(txtiid) || Validation.GetHasError(txtiname) || Validation.GetHasError(txtiqty)
                || Validation.GetHasError(txtitemtype))
            {
                MessageBox.Show("Please Fill the required fields.");
                return;
            }

            inventory inv = new inventory();
            inv.item_id = txtiid.Text.Trim();
            inv.item_name = txtiname.Text.Trim();
            inv.item_quantity = Convert.ToInt32(txtiqty.Text.Trim());
            inv.item_type = txtitemtype.Text.Trim();

            inv.item_expiry = datepickerexpiry.SelectedDate.Value;


            InventoryFactory invFactory = new InventoryFactory();

            if (invFactory.Insert(inv))
            {
                MessageBox.Show("Inserted");
                clearform();
            }
            else
                MessageBox.Show("Not Inserted");
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            clearform();
        }  
    
    
    
    }
}
