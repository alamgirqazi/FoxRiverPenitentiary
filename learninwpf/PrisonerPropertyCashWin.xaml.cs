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
    /// Interaction logic for PrisonerPropertyCashWin.xaml
    /// </summary>
    public partial class PrisonerPropertyCashWin : MahApps.Metro.Controls.MetroWindow
    {
        PrisonerPropertyCashViewModel vm;

        public PrisonerPropertyCashWin()
        {
            InitializeComponent(); 
            vm = new PrisonerPropertyCashViewModel();
            this.DataContext = vm;
        }
        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            PrisonerPropertyFactory prisfac = new PrisonerPropertyFactory();
            List<prisoner_info> list = prisfac.GetAll();

            cb_pid.ItemsSource = list;
            cb_pid.DisplayMemberPath = "p_id";
            cb_pid.ItemsSource = list;
            clearform();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            validations();
            if (Validation.GetHasError(txt_inum) || Validation.GetHasError(txt_pitems) || Validation.GetHasError(cb_pid)
                || Validation.GetHasError(txt_itemshelfnum) )
            {
                MessageBox.Show("Please Fill the required fields.");
                return;
            }
            prisoner_property_cash prisonercash = new prisoner_property_cash();
            prisonercash.p_id = int.Parse(cb_pid.Text);
            prisonercash.p_items = txt_pitems.Text.Trim();
            prisonercash.item_roomnum = Convert.ToInt32(txt_inum.Text.Trim());
            prisonercash.item_shelfnum = txt_itemshelfnum.Text.Trim();
            PrisonerPropertyFactory prisfac = new PrisonerPropertyFactory();
            if (prisfac.Insert(prisonercash))
            {
                MessageBox.Show("Inserted");

                clearform();
            }
            else
                MessageBox.Show("Not Inserted");

        }
        void clearform()
        {
            txt_inum.Clear();
            txt_itemshelfnum.Clear();
            txt_pitems.Clear();
            cb_pid.SelectedValue = null;


        }

        public void validations()
        {
          
            txt_inum.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txt_pitems.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            cb_pid.GetBindingExpression(ComboBox.TextProperty).UpdateSource();
            txt_itemshelfnum.GetBindingExpression(TextBox.TextProperty).UpdateSource();
         

        }
        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            clearform();
        }
    }
}
