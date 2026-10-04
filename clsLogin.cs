using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePresentationLayer
{
    internal partial class clsLogin 
    {


      
        public static clsUsersOperations LoginingIn()
        {

          clsHeaderClass. DrawHeader("Login Screen");
            int counter = 1;
            string Username;
            string Password;
            Console.WriteLine("Please Enter UserName and Password to Login  ");
                Console.Write("UserName  :  ");
            Username =  Console.ReadLine();
                Console.Write("Password  :  ");
            Password = Console.ReadLine();
            clsUsersOperations CurrentUser = clsUsersOperations.TryLogin(Username,true ,  Password  );
            clsMainScreen.CheckForErrors();
            if (CurrentUser != null)
            {
                return CurrentUser;
            }

            Console.WriteLine();
           


            while (true)
            {
                if (counter == 3) {
                    Console.WriteLine("Too Many Failed Attempts. Try again Later");
                return null;
                }

                Console.WriteLine($"Wrong Username / Password . {3- counter} Trial(s) Left  ");
                Console.Write("UserName  :  ");
                Username = Console.ReadLine().ToString();
                Console.Write("Password  :  ");
                Password = Console.ReadLine().ToString();
                CurrentUser = clsUsersOperations.TryLogin(Username, true,Password);
                Console.WriteLine();
                if (CurrentUser !=null)
                {
                    return CurrentUser;
                }
                counter++;
            }

        }



    }
}
