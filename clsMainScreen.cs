using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePresentationLayer
{

    internal class clsMainScreen  
    {
        public static void CheckForErrors ()
        {
            if (!string.IsNullOrEmpty( clsErrorMessageHandeling.ErrorMessage() ))
            {
                Console.Clear();
                Console.WriteLine("Error : " +  clsErrorMessageHandeling.ErrorMessage());
                Console.WriteLine("\nPress any key to exit...");

                Console.ReadKey();
                Environment.Exit(1);
            }


        }

        public static void ShowDenietionScreen ()
        {
            Console.Clear();
            Console.WriteLine("\nAccess Denied...!!");
            Console.WriteLine("Contact Your Admin for More Information");
            Console.ReadKey();
            PerformMainScreenActions(_User);
        }
        public static void ReternToMainSceenMessage ()
            {
            Console.WriteLine("\nPress any key to go back to main menu...");
            Console.WriteLine();
            Console.ReadKey();
            PerformMainScreenActions (_User);
            }

        public static void ShowLoginLogs()
        {
            DataTable DT = clsUsersOperations.GetLogs();

            CheckForErrors();

            Console.WriteLine("\n\n");
            Console.WriteLine($"{"",-15}-----------------------------------------------------------------------------------------");
            Console.WriteLine($"{"",-15}| {"ID",-5} | {"Date & Time",-23} | {"System User",-15} | {"Password",-10} | {"Accessibilities",-15} |");
            Console.WriteLine($"{"",-15}-----------------------------------------------------------------------------------------");

            foreach (DataRow Row in DT.Rows)
            {
                string decryptedPassword = clsUsersOperations._Decription((string)Row["Password"], 2);

                string formattedDate = Convert.ToDateTime(Row["LoginDateTime"]).ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine($"{"",-15}| {Row["LoginID"],-5} | {formattedDate,-23} | {Row["SystemUser"],-15} | {decryptedPassword,-10} | {Row["Accessibilities"],-15} |");
            }

            Console.WriteLine($"{"",-15}-----------------------------------------------------------------------------------------");
        }
        static public clsUsersOperations _User;
        private static int CheckInteredNumber ()
        {
            
            do
            {

                int Number = 0;
                Console.Clear();
                PrintMainScreen(_User.UserName);
                Console.Write($"{"",-50}Choose what to do [1 to 10]?");
                if ((int.TryParse(Console.ReadLine(), out Number) && Number >0 && Number <=10) )
                {

                    return Number;
                }

            } while (true);

        }

        [Flags]
        public enum enSelection {ShowClientlist = 1 , AddNewCleint =2 ,Delete= 3 , Update = 4 , Find=5 , Transactions = 6 , manageUsers  = 7 , 
              Logs = 8 , Currency = 9 , logout =10}

        private static enSelection SelectedOption;

        public static void PrintMainScreen (string User)
        {
           
            Console.Clear();

            clsHeaderClass.DrawHeader("Main Screen", User);
            Console.WriteLine($"{"",-50}===========================================           ");
            Console.WriteLine($"{"",-50}               Main Menu");
            Console.WriteLine($"{"",-50}===========================================           ");
            Console.WriteLine($"{"",-50}[1]  Show Client List.");
            Console.WriteLine($"{"",-50}[2]  Add New Client.");
            Console.WriteLine($"{"",-50}[3]  Delete Client.");
            Console.WriteLine($"{"",-50}[4]  Update Client Info.");
            Console.WriteLine($"{"",-50}[5]  Find Client.");
            Console.WriteLine($"{"",-50}[6]  Transactions.");
            Console.WriteLine($"{"",-50}[7]  Manage Users.");
            Console.WriteLine($"{"",-50}[8]  Login Logs.");
            Console.WriteLine($"{"",-50}[9]  Currencies Exchange.");
            Console.WriteLine($"{"",-50}[10] Logout.");
            Console.WriteLine($"{"",-50}===========================================           ");
                              
        }

        static public void PerformMainScreenActions(clsUsersOperations CurrentUser)
        {
            _User = CurrentUser;
            PrintMainScreen(CurrentUser.UserName);
            SelectedOption = (enSelection)CheckInteredNumber();
       
            switch (SelectedOption)
            {
               
                case enSelection.ShowClientlist:
                    {
                      if( CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.ShowClientList ))
                        {
                            clsHeaderClass.DrawHeader("List Clients Screen", CurrentUser.UserName);
                            clsCleintsInterface.ListClients();
                            ReternToMainSceenMessage();
                        }
                        else { ShowDenietionScreen(); }
                        break;
                    }
                case enSelection.AddNewCleint:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.AddNew))
                        {
                            clsHeaderClass.DrawHeader("Add New Client Screen", CurrentUser.UserName);
                            clsCleintsInterface.AddNewClient();
                            ReternToMainSceenMessage();}

                        else { ShowDenietionScreen(); }

                            break;
                    }
                case enSelection.Delete:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.Delete))
                        {
                            clsHeaderClass.DrawHeader("Delete Client Screen", CurrentUser.UserName);
                            clsCleintsInterface.DeleteClientFunction();
                            ReternToMainSceenMessage();
                        }
                        else { ShowDenietionScreen(); }
                        break;
                    }
                case enSelection.Update:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.Update))
                        {
                            clsHeaderClass.DrawHeader("Update Client Screen", CurrentUser.UserName);
                            clsCleintsInterface.UpdateClientFunction();
                            ReternToMainSceenMessage();
                        }
                        else { ShowDenietionScreen(); }
                        break;
                    }
                case enSelection.Find:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.Find))
                        {
                            clsHeaderClass.DrawHeader("Find Client Screen", CurrentUser.UserName);
                            clsCleintsInterface.FindClientFunction();
                            ReternToMainSceenMessage();
                        }
                        else { ShowDenietionScreen(); }

                        break;
                    }
                case enSelection.Transactions:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.Tansactions))
                        {
                            clsTransactionsScreen.PerformTransactionsScreenOptions();
                        }
                        else { ShowDenietionScreen(); }

                            break;
                    }
                case enSelection.manageUsers:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.Manageusers))
                        {
                           clsManageUsersScreen.PerformManageUsersScreenOptions();
                        }
                        else { ShowDenietionScreen(); }

                        break;
                    }
                case enSelection.Logs:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.Logs))
                        {
                            clsHeaderClass.DrawHeader("Login Logs Screen", CurrentUser.UserName);
                            ShowLoginLogs();
                            ReternToMainSceenMessage();
                        }
                        else { ShowDenietionScreen(); }
                        break;
                    }
                case enSelection.Currency:
                    {
                        if (CurrentUser.CheckAccessibility(clsUsersOperations.enAccessiblitiesList.CurrenciesEx))
                        {
                           clsCurrenciesInterface.PerformCurrenciesExchangeOptions();
                        }
                        else { ShowDenietionScreen(); }
                        break;
                    }
                case enSelection.logout:
                    {
                        Console.Clear();

                        MainProgram.LaunchSystem();
                  
                        break;
                    }
                   
            }


        }

    }
}
