using FriendsApp.Wpf.DataProvider;
using FriendsApp.Wpf.Model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FriendsApp.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var customerDataProvider = new FriendsDataProvider();
            dataGrid.ItemsSource = customerDataProvider.LoadFriends();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dataGrid.SelectedItem is Friend friend)
                {
                    // TODO: Use the friend's latitude and longitude for the MapControl
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
