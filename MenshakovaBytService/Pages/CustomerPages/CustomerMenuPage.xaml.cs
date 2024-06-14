using MenshakovaBytService.Classes;
using MenshakovaBytService.Models;
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

namespace MenshakovaBytService.Pages.CustomerPages
{
    /// <summary>
    /// Логика взаимодействия для CustomerMenuPage.xaml
    /// </summary>
    public partial class CustomerMenuPage : Page
    {
        public CustomerMenuPage()
        {
            InitializeComponent();
        }

        private void BtnNavigateToProfilePage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new CustomerMainPage());
        }

        private void BtnNavigateToAddRequestPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new CustomerAddRequestPage());
        }

        private void BtnNavigateToCustomerRequestsPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new CustomerRequestsPage());
        }
    }
}
