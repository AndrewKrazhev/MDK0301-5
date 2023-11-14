using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK0301_5
{
    public class Koniki
    {
        /// <summary>
        /// Статический метод проверки правильности ввода логина и пароля
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        /// <returns>Возвращает значение типа bool</returns>
        public static bool checkPassword(string login, string password)
        {
            /*
             Здесь может и должна быть проверка запросом к базе данных
             */
            if (login == "" && password == "") { return true; } else { return false; }
        }
    }
}
