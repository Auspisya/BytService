using MenshakovaBytService.Classes;
using MenshakovaBytService.Controllers;
using MenshakovaBytService.Models;
using MenshakovaBytService.Pages.CustomerPages;
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

namespace MenshakovaBytService.Pages.AuthPages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        private AuthorizationPageController _authorizationPageController;
        public AuthorizationPage()
        {
            InitializeComponent();
            _authorizationPageController = new AuthorizationPageController();
        }

        private void BtnAuthorize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = TxbLogin.Text;
                string password = PsbPassword.Password;

                GlobalUser.User = _authorizationPageController.Authorization(login, password);

                switch (GlobalUser.User.UserType.Id)
                {
                    case 1:
                        //Navigation.frameNav.Navigate(new Page());
                        break;
                    case 2:
                        //Navigation.frameNav.Navigate(new Page());
                        break;
                    case 3:
                        //Navigation.frameNav.Navigate(new Page());
                        break;
                    case 4:
                        MessageBox.Show("Авторизация выполнена успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Navigation.frameNav.Navigate(new CustomerMainPage());
                        MenuNavigation.frameNav.Navigate(new CustomerMenuPage());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
