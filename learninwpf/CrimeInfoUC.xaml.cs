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
    /// Interaction logic for CrimeInfoUC.xaml
    /// </summary>
    public partial class CrimeInfoUC : UserControl
    {

        CrimeInformationViewModel vm;

        public CrimeInfoUC()
        {
            InitializeComponent();
            vm = new CrimeInformationViewModel();
            this.DataContext = vm;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CrimeInformationFactory prisfac = new CrimeInformationFactory();


        }

 
        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
            Crime_Information prisoner = new Crime_Information();
            prisoner.crime_id = Convert.ToInt32(txtid.Text.Trim());
            prisoner.crime_punishment = txtcrimepunishment.Text.Trim();
            prisoner.crime_title = txtcrimetitle.Text.Trim();

            if (cbbail.IsChecked ?? false)
                prisoner.crime_bail = true;
            else
                prisoner.crime_bail = false;
            prisoner.crime_fine = txtcrimefine.Text.Trim();
            CrimeInformationFactory prisFactory = new CrimeInformationFactory();

            if (prisFactory.Insert(prisoner))
                MessageBox.Show("Inserted");
            else
                MessageBox.Show("Not Inserted");
        

        }
    }
}
