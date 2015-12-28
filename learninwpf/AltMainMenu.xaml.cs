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
using System.Windows.Threading;

namespace learninwpf
{
    /// <summary>
    /// Interaction logic for AltMainMenu.xaml
    /// </summary>
    public partial class AltMainMenu : MahApps.Metro.Controls.MetroWindow
    {
        public AltMainMenu()
        {
            InitializeComponent();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            progressring.Visibility = Visibility.Collapsed;

        }
    
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Information abc = new Information();
            abc.ShowDialog();

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListBox)sender).SelectedIndex)
            {
                case 0:
                    PrisonerInfoWin objTile = new PrisonerInfoWin();
        
                    objTile.ShowDialog();

                    break;
                case 1:
                    PrisonerPropertyCashWin objDialog = new PrisonerPropertyCashWin();
                  
                    objDialog.ShowDialog();

                    break;
                case 2:
                    PrisonerWorkAllotmentWin objFlyout = new PrisonerWorkAllotmentWin();
           
                    objFlyout.ShowDialog();

                    break;
                case 3:
                    CrimeInfoWin objDynamicTiles = new CrimeInfoWin();
          
                    objDynamicTiles.ShowDialog();

                    break;
                case 4:
                    MedicalCentreWin objProgress = new MedicalCentreWin();
           
                    objProgress.ShowDialog();

                    break;
                case 5:
                    EmployeeWin objTab = new EmployeeWin();
         
                    objTab.ShowDialog();

                    break;
                case 6:
                    FoxRiverLibraryWin objDataGrid = new FoxRiverLibraryWin();
           
                    objDataGrid.ShowDialog();

                    break;
                case 7:
                    VisiterLogWin objOtherControls = new VisiterLogWin();
          
                    objOtherControls.ShowDialog();

                    break;
                case 8:
                    InventoryWin obj = new InventoryWin();

                    obj.ShowDialog();
                    break;
            }
        }
    }
}
