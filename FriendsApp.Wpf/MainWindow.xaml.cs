using FriendsApp.Wpf.DataProvider;
using FriendsApp.Wpf.Model;
using System;
using System.Windows;
using System.Windows.Controls;
using Windows.Devices.Geolocation;

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

        private async void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dataGrid.SelectedItem is Friend friend)
                {
                    var basisGeoposition = new BasicGeoposition
                    {
                        Latitude = friend.Latitude,
                        Longitude = friend.Longitude
                    };

                    var geopoint = new Geopoint(basisGeoposition);

                    await mapControl.TrySetViewAsync(geopoint);

                    await mapControl.TryZoomToAsync(12);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
