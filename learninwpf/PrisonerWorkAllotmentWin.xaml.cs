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
    /// Interaction logic for PrisonerWorkAllotmentWin.xaml
    /// </summary>
    public partial class PrisonerWorkAllotmentWin : MahApps.Metro.Controls.MetroWindow
    {
        PrisonerWorkAllotmentViewModel vm;
        public PrisonerWorkAllotmentWin()
        {
            InitializeComponent();
            vm = new PrisonerWorkAllotmentViewModel();
            this.DataContext = vm;
        }
        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            clearform();
        }

        public void clearform()
        {
            txtid.Clear();
         comboshifttype.SelectedValue=null ;
         comboworktype.SelectedValue = null;


        }

        public void validations()
        {
             
            txtid.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            comboworktype.GetBindingExpression(ComboBox.TextProperty).UpdateSource();
            comboshifttype.GetBindingExpression(ComboBox.TextProperty).UpdateSource();


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            validations();
            if (Validation.GetHasError(txtid) || Validation.GetHasError(comboworktype) || Validation.GetHasError(comboshifttype)
               )
            {
                MessageBox.Show("Please Fill the required fields.");
                return;
            }
            prisoner_work_allotment prisoner = new prisoner_work_allotment();
            prisoner.p_id = Convert.ToInt32(txtid.Text.Trim());
            prisoner.work_type = comboworktype.Text;
            prisoner.work_shifttime = comboshifttype.Text;

            Prisoner_Work_AllotmentFactory prisFactory = new Prisoner_Work_AllotmentFactory();

            if (prisFactory.Insert(prisoner))
                MessageBox.Show("Inserted");
            else
                MessageBox.Show("Not Inserted");

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            Prisoner_Work_AllotmentFactory prisfac = new Prisoner_Work_AllotmentFactory();
            clearform();

        }

    }
}
