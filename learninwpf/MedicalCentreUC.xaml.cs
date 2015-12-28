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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModels;

namespace learninwpf
{
    /// <summary>
    /// Interaction logic for MedicalCentreUC.xaml
    /// </summary>
    public partial class MedicalCentreUC : UserControl
    {
       MedicalCentreViewModel vm;

        public MedicalCentreUC()
        {
            InitializeComponent();
            vm = new MedicalCentreViewModel();
            this.DataContext = vm;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Prisoner_MedicalFactory prisfac = new Prisoner_MedicalFactory();
        }


        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
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
    
    }
}
