using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryPassword
{
    public class PasswordChecker
    {
        public static bool ValidatePassword(string password)
        {

            if (password.Length < 8 || password.Length > 20) //Условия длины строки
                return false;
            if (!password.Any(Char.IsLower)) //Нижний регистр
                return false;
            if (!password.Any(Char.IsUpper)) //Верхний регистр
                return false;
            if (!password.Any(Char.IsDigit)) //Цифры
                return false;
            if (password.Intersect("!@#$%^&*?.,-_").Count() == 0) //Спецсивмолы 
                return false;




           return true;
        }
        public static bool IsNullOrEmpty(string value) // Проверка на пустую строку
        {
            return false;

        }

        public static string GeneratePassword()
        {
            string password;
            string up = "QWERTYUIOPASDFGHJKLZXCVBNM";
            char[] upArray = up.ToCharArray();
            string down = "qwertyuiopasdfghjklzxcvbnm";
            char[] downArray = down.ToCharArray();
            string digit = "1234567890";
            char[] digitArray = digit.ToCharArray();
            string symbols = "!@#$%.,^&*()-=_+/?";
            char[] symbolsArray = symbols.ToCharArray();
            Random rnd = new Random();
            int lenght = rnd.Next(8, 15);
            char[] pass = new char[lenght];
            do
            {
                for (int i = 0; i < lenght; i++)
                {
                    int a = rnd.Next(0, 4);
                    if (a == 0)
                    {
                        int x = rnd.Next(0, upArray.Length);
                        pass[i] = upArray[x];
                    }
                    if (a == 1)
                    {
                        int x = rnd.Next(0, downArray.Length);
                        pass[i] = downArray[x];
                    }
                    if (a == 2)
                    {
                        int x = rnd.Next(0, digitArray.Length);
                        pass[i] = digitArray[x];
                    }
                    if (a == 3)
                    {
                        int x = rnd.Next(0, symbolsArray.Length);
                        pass[i] = symbolsArray[x];
                    }

                }
                password = string.Concat(pass);
            }
            while (!ValidatePassword(password));
          
            return password;
        }

    }
}















