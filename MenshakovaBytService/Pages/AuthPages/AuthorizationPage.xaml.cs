using MenshakovaBytService.Classes;
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
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void BtnAuthorize_Click(object sender, RoutedEventArgs e)
        {
            string login = TxbLogin.Text;
            string password = PsbPassword.Password;

            if (login == "")
            {
                MessageBox.Show("Пожалуйста, введите логин!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Пожалуйста, введите пароль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            User user = DBConnection.DBConnect.User.FirstOrDefault( u => u.Login == login && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Введены неверные логин или пароль! Повторите попытку.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            GlobalUser.User = user;

            switch (user.UserType.Id)
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
                    Navigation.frameNav.Navigate(new CustomerMainPage(user));
                    break;
            }
        }
    }
}
