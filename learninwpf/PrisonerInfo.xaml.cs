using learn_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModels;

namespace learninwpf
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class PrisonerInfo   : UserControl
    {
        PrisonerInfoViewModel vm;

        public PrisonerInfo()
        {
            InitializeComponent();
            vm = new PrisonerInfoViewModel();
            this.DataContext = vm;

        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            PrisonerFactory prisfac = new PrisonerFactory();
        

        }
        private void clearform()
        {
            txtaddress.Clear();
            txtblocknum.Clear();
            txtcnic.Clear();
            txthomenum.Clear();
            txtname.Clear();
            txtroomnum.Clear();
            dateofarrivalpicker.SelectedDate = null;
            dateofdeparturepicker.SelectedDate = null;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            prisoner_info prisoner = new prisoner_info();
            prisoner.p_name = txtname.Text.Trim();
            prisoner.p_cnic = txtcnic.Text.Trim();
            prisoner.p_homenum = txthomenum.Text.Trim();

            if (rbYes.IsChecked ?? false)
                prisoner.p_maritalstatus = true;
            else
                prisoner.p_maritalstatus = false;
            prisoner.p_address = txtaddress.Text.Trim();
            prisoner.p_roomnum = txtroomnum.Text.Trim();
            prisoner.p_block = txtblocknum.Text.Trim();
            prisoner.p_dateofarrival = dateofarrivalpicker.SelectedDate.Value;
            prisoner.p_dateofrelease = dateofdeparturepicker.SelectedDate.Value;

            PrisonerFactory prisFactory = new PrisonerFactory();

            if (prisFactory.Insert(prisoner))
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
