using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] logins = { "admin", "root", "vasya" };
            string[] passwords = { "qwerty", "1234", "1111" };
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

           /* if (login == logins[0] || login == logins[1] || login == logins[2])
            {
                Console.WriteLine("Login matches");
            }
            else 
            { 
                Console.WriteLine("Wrong login");
            }
            */

            bool auth = false;
            for (int i = 0; i < logins.Length; i++)
            {
                if (logins[i] == login)
                {
                    Console.WriteLine("Login matches");
                    auth = true;
                }
            }
            if (!auth) Console.WriteLine("Wrong login");

        }
    }
}
