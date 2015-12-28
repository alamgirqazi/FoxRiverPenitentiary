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
    /// Interaction logic for MedicalCentreWin.xaml
    /// </summary>
    public partial class MedicalCentreWin : MahApps.Metro.Controls.MetroWindow
    {
        MedicalCentreViewModel vm;
        public MedicalCentreWin()
        {
            InitializeComponent();
            vm = new MedicalCentreViewModel();
            this.DataContext = vm;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Prisoner_MedicalFactory prisfac = new Prisoner_MedicalFactory();
            clearform();

        }

        public void validations()
        {
            
            txtid.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtwardnum.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtdisease.GetBindingExpression(TextBox.TextProperty).UpdateSource();
             txtdaysspent.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtbednum.GetBindingExpression(TextBox.TextProperty).UpdateSource();

        }
        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
            validations();
            if (Validation.GetHasError(txtid) || Validation.GetHasError(txtwardnum) || Validation.GetHasError(txtdisease)
                || Validation.GetHasError(txtdaysspent) || Validation.GetHasError(txtbednum))
            {
                MessageBox.Show("Please Fill the required fields.");
                return;
            }
            Prisoner_Medical prisoner = new Prisoner_Medical();
            prisoner.p_id = Convert.ToInt32(txtid.Text.Trim());
            prisoner.p_disease = txtdisease.Text.Trim();
            prisoner.p_med_date = datepicker.SelectedDate.Value;
            prisoner.numberofdaysspent = Convert.ToInt32(txtdaysspent.Text.Trim());
            prisoner.medicalward_num = Convert.ToInt32(txtwardnum.Text.Trim());
            prisoner.bed_num = Convert.ToInt32(txtwardnum.Text.Trim());
            Prisoner_MedicalFactory prisFactory = new Prisoner_MedicalFactory();

            if (prisFactory.Insert(prisoner))
                MessageBox.Show("Inserted");
            else
                MessageBox.Show("Not Inserted");
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            clearform();
        }
        public void clearform()
        {
            txtbednum.Clear();
            txtdaysspent.Clear();
            txtdisease.Clear();
            txtid.Clear();
            txtwardnum.Clear();

            datepicker.SelectedDate = null;

        }
    }
}
