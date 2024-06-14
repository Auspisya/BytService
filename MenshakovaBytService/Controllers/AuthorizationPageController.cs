using MenshakovaBytService.Classes;
using MenshakovaBytService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenshakovaBytService.Controllers
{
    public class AuthorizationPageController
    {
        public User Authorization(string login, string password)
        {
            User user;

            if (login == "")
            {
                throw new Exception("Поле логина не заполнено!");
                
            }

            if (password == "")
            {
                throw new Exception("Поле пароля не заполнено!");
            }

            try
            {
                user = DBConnection.DBConnect.User.FirstOrDefault( u => u.Login == login && u.Password == password);
            }
            catch
            {
                throw new Exception("Соединение с базой данных отсутствует"); ;
            }

            if (user == null)
            {
                throw new Exception("Введены неверные логин или пароль!");
            }

            return user;
         
        }
    }
}
