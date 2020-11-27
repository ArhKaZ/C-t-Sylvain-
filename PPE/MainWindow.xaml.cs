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
using PPE;
using ModelLayer.Business;
using ModelLayer.Data;

namespace PPE
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Finir le tuto : https://www.c-sharpcorner.com/UploadFile/mahesh/datagrid-in-wpf/#:~:text=WPF%20DataGrid.,display%20data%20from%20a%20collection.&text=In%20this%20article%2C%20you%20will,load%20data%20from%20a%20collection
            InitializeComponent();
           // DG_Client.ItemsSource = LoadCollectionData();
        }
        

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
