using System;
using System.Data;
using System.Linq;
using BankSystemBusinessLayer;

namespace ConsolePresentationLayer
{
    public class MainProgram
    {
        public static void LaunchSystem ()
           {
            clsUsersOperations User = clsLogin.LoginingIn();
            if (User != null)
            {
                User.SaveLogin();
                clsMainScreen.PerformMainScreenActions(User);

            }
        }


        public static void Main(string[] args)
        {
            LaunchSystem();
            Console.ReadKey();
        }

       
    }
}


