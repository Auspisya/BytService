using MenshakovaBytService.Classes;
using MenshakovaBytService.Models;
using MenshakovaBytService.Pages.AuthPages;
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
    /// Логика взаимодействия для CustomerMainPage.xaml
    /// </summary>
    public partial class CustomerMainPage : Page
    {
        public CustomerMainPage(User user)
        {
            InitializeComponent();
            TxbUserName.Text = "Добро пожаловать, " + user.FullName + "!";
            TxbPhoneNumber.Text = "Ваш номер телефона: " + user.PhoneNumber + ".";
            TxbUserType.Text = "Вы зашли под ролью: " + user.UserType.Name + ".";
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new AuthorizationPage());
            MenuNavigation.frameNav.Navigate(new Page());
        }
    }
}
