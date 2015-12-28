using MahApps.Metro.Controls;
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
using MahApps.Metro.Controls.Dialogs;
using System.Threading;
using System.Windows.Threading;
namespace learninwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainMenu : MahApps.Metro.Controls.MetroWindow
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Information abc = new Information();
            abc.ShowDialog();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Heyyy!!");
        }

       

        private async void logoutBTN_Click(object sender, RoutedEventArgs e)
        {
             await Task.Delay(500);
  await this.ShowMessageAsync("LOGOUT", "Logging Out!", MessageDialogStyle.Affirmative);
            logoutBTN.Visibility = Visibility.Collapsed;
            this.Hide();
            Window1 obj = new Window1();
            obj.Show();
        }
    }
}
