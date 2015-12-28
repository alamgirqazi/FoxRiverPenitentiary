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
    /// Interaction logic for EmployeeWin.xaml
    /// </summary>
    public partial class EmployeeWin : MahApps.Metro.Controls.MetroWindow
    {
        EmployeeViewModel vm;

        public EmployeeWin()
        {
            InitializeComponent();
            vm = new EmployeeViewModel();
            this.DataContext = vm;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeFactory prisfac = new EmployeeFactory();


        }

        public void validations()
        {
            txtphnum.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtempnam.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtempid.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtempdesig.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtempcnic.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtempaddress.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            cbmarital.GetBindingExpression(ComboBox.TextProperty).UpdateSource();
            cbduty.GetBindingExpression(ComboBox.TextProperty).UpdateSource();

        }


        private void clearform()
        {
            txtphnum.Clear();
            txtempnam.Clear();
            txtempid.Clear();
            txtempdesig.Clear();
            txtempcnic.Clear();
            txtempaddress.Clear();
            cbmarital.SelectedValue = null;
            cbduty.SelectedValue = null;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            validations();
            if (Validation.GetHasError(txtempid) || Validation.GetHasError(txtempaddress) || Validation.GetHasError(txtempcnic)
                || Validation.GetHasError(txtempdesig) || Validation.GetHasError(txtphnum) || Validation.GetHasError(cbduty) || Validation.GetHasError(cbmarital) || Validation.GetHasError(txtempnam))
            {
                MessageBox.Show("Please Fill the required fields.");
                return;
            }
            Employee emp = new Employee();
            emp.employee_id = txtempid.Text.Trim();
            emp.emp_address = txtempaddress.Text.Trim();
            emp.emp_cnic = txtempcnic.Text.Trim();
            emp.emp_designation = txtempdesig.Text.Trim();
            emp.emp_number = txtphnum.Text.Trim();
            emp.emp_duty_timing = cbduty.Text;
            emp.emp_maritalstatus = cbmarital.Text;
            emp.employee_name = txtempnam.Text.Trim();

            EmployeeFactory empFactory = new EmployeeFactory();

            if (empFactory.Insert(emp))
            {
                MessageBox.Show("Inserted");
                txtempid.Focus();
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
