using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPassword;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PasswordChecker.GeneratePassword());
            Console.ReadKey();
        }
    }
}
