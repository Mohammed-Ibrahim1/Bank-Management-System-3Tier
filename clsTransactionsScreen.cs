using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePresentationLayer
{
    public  class clsTransactionsScreen
    {
        static bool ConfirmationFunction ()
        {
            Console.Write("\nAre you Sure to do this Transaction ? (YES = 1 / NO = 0) ? ");
            return (Console.ReadLine().ToString() != "1");
        }
        static void ReturntoMain()
        {
            Console.WriteLine("\n\nPress any key to go back to transactions screen ...");
            Console.ReadKey();
            Console.Clear();
            PerformTransactionsScreenOptions();

        }
        enum enOptions   {Desposit =1  , Wirhdraw = 2  , TotalBalances = 3 , Transfer = 4 , TransferLog = 5 , MainMenu = 6}

        static clsUsersOperations _User  = null;
        private static enOptions SelectedOption;

          private static int CheckInteredNumber ()
        {
            do
            { 
                int Number = 0;
                Console.Clear();
                DrawSceen();
                Console.Write($"{"",-50}Choose what to do [1 to 6]?");
                if ((int.TryParse(Console.ReadLine(), out Number) && Number >0 && Number <=6) )
                {
                    return Number;
                }

            } while (true);

        }

       static private void DespositFunction()
        {
            int counter = 0;
            
            string Message = "Please Enter Amount to Deposit : ";
            double Amount = 0;
            clsClientsOperations Client = clsCleintsInterface.FindClientFunction();
            if (Client == null) { return; }
            do
            {
                if (counter != 0) { Message = "Incorrect Amount Try another : "; }

                Console.Write("\n" + Message);
                Amount = Convert.ToDouble(Console.ReadLine());
                counter = 1;

            } while (  Amount <=0);

          if (ConfirmationFunction())
            {
                Console.WriteLine("\nOperation Canceled");
                return;
            }

            Client.Balance += Amount;
            bool Balance = Client.UpdateBalance();
     
            clsMainScreen.CheckForErrors();
            if (Balance) { Console.WriteLine("\nBalance Updated Successfully"); }
            else { Console.WriteLine("\nBalance is NOT Updated"); }
        }

        static private void WithdrawFunction()
        {
            int counter = 0;
            string Message = "Please Enter Amount to Withdraw : ";
            double Amount = 0;

          
            clsClientsOperations Client = clsCleintsInterface.FindClientFunction();
            if (Client == null) { return; }

            do
            {
                if (counter != 0) { Message = "Incorrect Amount! (Must be > 0 and <= Balance). Try another : "; }

                Console.Write("\n" + Message);

              
                if (double.TryParse(Console.ReadLine(), out Amount))
                {
                    counter = 1;
                }
                else
                {
                    Amount = 0; 
                    counter = 1;
                }

            } while (Amount > Client.Balance || Amount <= 0);

            
            if (ConfirmationFunction())
            {
                Console.WriteLine("\nOperation Canceled");
                return;
            }

           
            Client.Balance -= Amount;

            bool Balance = Client.UpdateBalance();

            clsMainScreen.CheckForErrors();

            if (Balance)
            {
                Console.WriteLine("\nBalance Updated Successfully");
            }
            else
            {
                Console.WriteLine("\nBalance is NOT Updated");
            }
        }

        public static void GetTotalBalances ()
        {
            double Amount  = clsClientsOperations.GetTotalAmount();
            clsMainScreen.CheckForErrors();
            Console.WriteLine($"\n\n{"",-50}Total Balances in the System = ({Amount})");

        }
        public static void DrawSceen()
        {
            clsHeaderClass.DrawHeader("Transactions Screen" , _User.UserName);
            Console.WriteLine($"{"",-50}===========================================");
            Console.WriteLine($"{"",-50}            Transactions Menue");
            Console.WriteLine($"{"",-50}===========================================");
            Console.WriteLine($"{"",-50}[1] Deposit.");
            Console.WriteLine($"{"",-50}[2] Withdraw.");
            Console.WriteLine($"{"",-50}[3] Total Balances.");
            Console.WriteLine($"{"",-50}[4] Transfer.");
            Console.WriteLine($"{"",-50}[5] Transfer Logs.");
            Console.WriteLine($"{"",-50}[6] Main Menue.");
            Console.WriteLine($"{"",-50}===========================================");

        }

        public static void TransferFunction()
        {
            Console.WriteLine($"{"",-50}Sender ...");
            clsClientsOperations Client1 = clsCleintsInterface.FindClientFunction();
            Console.WriteLine("\n\n");
            Console.WriteLine($"{"",-50}Reciever ...");
            clsClientsOperations Client2 = clsCleintsInterface.FindClientFunction();
            string Message = "Please Enter Amount to Transfer : ";
            int counter = 0;
            double Amount = 0;
            do
            {
                if (counter != 0) { Message = "Incorrect Amount Try another : "; }

                Console.Write("\n" + Message);
                Amount = Convert.ToDouble(Console.ReadLine());
                counter = 1;

            } while (Amount <=0 || Amount >Client1.Balance );

          
            if (ConfirmationFunction())
            {
                Console.WriteLine("\nOperation Canceled");
                return;
            }
            Client1.Balance -= Amount;
            Client2.Balance += Amount;
            Client1.UpdateBalance();
            Client2.UpdateBalance();
            Console.WriteLine("\nTransaction Successeded");
            clsClientsOperations.CreateTransferLog(Client1.ID ,  Client2.ID , Amount , _User.UserID);
            clsMainScreen.CheckForErrors();
        }
        public static void ShowTransactionLog()
        {
            
            DataTable DT = clsClientsOperations.GetLogs();

            
            clsMainScreen.CheckForErrors();

            
            Console.WriteLine("\n\n");
            Console.WriteLine($"{"",-15}-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"",-15}| {"ID",-5} | {"Date & Time",-22} | {"Sender Account",-15} | {"Receiver Account",-16} | {"Amount",-10} | {"User",-12} |");
            Console.WriteLine($"{"",-15}-----------------------------------------------------------------------------------------------------------");

            foreach (DataRow Row in DT.Rows)
            {
                Console.WriteLine($"{"",-15}| {Row["TransactionID"],-5} | {Row["DateAndTime"],-22} | {Row["SenderAccount"],-15} | {Row["RecieverAccount"],-16} | {Row["Amount"],-10} | {Row["UserName"],-12} |");
            }

            Console.WriteLine($"{"",-15}-----------------------------------------------------------------------------------------------------------");
        }
        public static void PerformTransactionsScreenOptions ()
        {
            _User = clsMainScreen._User;
            DrawSceen();
            SelectedOption = (enOptions)CheckInteredNumber();

            switch (SelectedOption)
            {
                case enOptions.Desposit:
                    {
                        clsHeaderClass.DrawHeader("Deposit Screen", _User.UserName);
                        DespositFunction();
                        ReturntoMain();
                        break;
                    }
                case enOptions.Wirhdraw:
                    {
                        clsHeaderClass.DrawHeader("Withdraw Screen", _User.UserName);
                    WithdrawFunction();
                        ReturntoMain();
                        break;
                    }
                case enOptions.TotalBalances:
                    {
                        clsHeaderClass.DrawHeader("Total Balances Screen", _User.UserName);
                   GetTotalBalances();
                        ReturntoMain();
                        break;
                    }
                case enOptions.Transfer:
                    {
                        clsHeaderClass.DrawHeader("Transfer Screen", _User.UserName);
                        TransferFunction();
                        ReturntoMain();
                        break;
                    }
                case enOptions.TransferLog:
                    {
                        clsHeaderClass.DrawHeader("Transfer Log Screen", _User.UserName);
                       ShowTransactionLog();
                        ReturntoMain();
                        break;
                    }
                case enOptions.MainMenu:
                    {
                        clsMainScreen.PerformMainScreenActions(_User);
                        break;
                    }
            }


        }







    }
}
