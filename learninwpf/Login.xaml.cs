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
using MahApps.Metro.Controls.Dialogs;
using System.Threading;
using System.Windows.Threading;

namespace learninwpf
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : MahApps.Metro.Controls.MetroWindow
    {
        public Window1()
        {
            InitializeComponent();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            progressring.Visibility = Visibility.Collapsed;
       
        }
    
        private async void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
       progressring.Visibility = Visibility.Visible;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += timer_Tick;
            timer.Start();
            await Task.Delay(2000);


            if (!usernameTB.Text.Equals("") && !PasswordBoxPB.Password.Equals(""))
            {
                if (usernameTB.Text.Equals("alamgir") && PasswordBoxPB.Password.Equals("4783"))
                {

                    this.Hide();
                    AltMainMenu obj = new AltMainMenu();
                    obj.Show();
                }
                else
                    await this.ShowMessageAsync("LOGIN", "Wrong Username or Password ", MessageDialogStyle.Affirmative);
            }
            else
                await this.ShowMessageAsync("LOGIN", "Please enter both Username and Password ", MessageDialogStyle.Affirmative);
            
        }

        private async void logoutBTN_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(500);
  await this.ShowMessageAsync("LOGOUT", "Logging Out!", MessageDialogStyle.Affirmative);
            LoginBTN.Visibility = Visibility.Visible;
            logoutBTN.Visibility = Visibility.Collapsed;

        }
     

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            usernameTB.Text = "Enter Your Username";
        }

        private void usernameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void usernameTB_GotFocus(object sender, RoutedEventArgs e)
        {

            if (usernameTB.Text == "Enter Your Username")
            {
                usernameTB.Text = "";
            }       

        }

        private void usernameTB_LostFocus(object sender, RoutedEventArgs e)
        {
if (usernameTB.Text=="")
{
    usernameTB.Text = "Enter Your Username";
}        
}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Information abc = new Information();
            abc.ShowDialog();
         
        }


    }

}
