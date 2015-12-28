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
    /// Interaction logic for datagridprisinfo.xaml
    /// </summary>
    public partial class datagridprisinfo : Window
    {
        public datagridprisinfo()
        {
            InitializeComponent();
        }

        private void dgStudents_Loaded(object sender, RoutedEventArgs e)
        {
            PrisonerFactory prisFac = new PrisonerFactory();
            List<PrisonerInfoViewModel> list = prisFac.SelectAllNamenAge();
            dg.ItemsSource = list;
       
        }
        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            PrisonerFactory AppFac = new PrisonerFactory();
            dg.ItemsSource = AppFac.GetAllByName(txtname.Text);
        }
    }
}
