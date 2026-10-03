using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ConsolePresentationLayer
{
   

        internal class clsCurrenciesInterface
        {

        static void PrintCurrencyCard(DataTable Dt)
        {
            DataRow Row = Dt.Rows[0];

            Console.WriteLine("\n\n");
            Console.WriteLine($"{"",-50}---------------------------------------------------");
            Console.WriteLine($"{"",-50}                 Currency Details");
            Console.WriteLine($"{"",-50}---------------------------------------------------");

            Console.WriteLine($"{"",-50} {"Country",-17} : {Row["Country"]}");
            Console.WriteLine($"{"",-50} {"Code",-17} : {Row["CurrencyCode"]}");
            Console.WriteLine($"{"",-50} {"Name",-17} : {Row["CurrencyName"]}");
            Console.WriteLine($"{"",-50} {"Rate",-17} : {Row["Rate"]}");

            Console.WriteLine($"{"",-50}---------------------------------------------------\n");
        }
        static float CheckInteredRate ()
        {
            float CurrentRate = 0;
            do
            {
                Console.Write($"\n\n{"" , -50}Enter The New Rate : ");
                string Rate = Console.ReadLine();
                if (float.TryParse(Rate , out CurrentRate) && CurrentRate >0 )
                {
                    return CurrentRate;
                }

            } while (true);
        }
        
       

        static DataTable FindTheCurrency ()
        {
            Console.Write($"\n{"",-50}Enter Currency Code to Find ? ");
            string Code   = Console.ReadLine ();
            DataTable Dt = clsCurrenciesOperation.FindCurrency(Code);
            clsMainScreen.CheckForErrors();
            if (Dt.Rows.Count == 0) {
            Console.WriteLine($"\n\n{"",-50}Currency With Code [" + Code + "] NOT Found");
            return null;
            }
            PrintCurrencyCard(Dt);

            return Dt;
        }

        static void UpdateRate ()
        {
            DataTable  Dt = FindTheCurrency();
            if (Dt == null)
            {
                return;
            }
            DataRow DR = Dt.Rows[0];

            float Rate = CheckInteredRate();
            Console.Write($"{"",-50}Are you sure to update this Rate ? (YES = 1 / NO = 0) ? ");
            if (Console.ReadLine() == "1")
            {
                if (clsCurrenciesOperation.UpdateRate((string)DR["CurrencyCode"], Rate))
                {
                    Console.WriteLine($"\n{"",-50}Rate Updated Successfully");
                }
                else
                {
                    Console.WriteLine($"\n{"",-50}Error  ,  Rate was NOT Updated");
                }

            }
            else
            {
                Console.WriteLine($"\n{"",-50}Operation Canceled");
            }

        }

        static void PerformCurrenciesCalculator()
        {
            Console.WriteLine($"\n{"",-50}Transfer This : ");
            DataTable Currency1 = FindTheCurrency();
            if (Currency1 == null) { return; }
            DataRow Rate1 = Currency1.Rows[0];
            Console.WriteLine($"\n{"",-50}To : ");
            DataTable Currency2 = FindTheCurrency();
            if (Currency2 == null) { return; }
            DataRow Rate2 = Currency2.Rows[0];


            Console.Write($"{"",-50}Amount to Transfer : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            double Result = ((double)Rate2["Rate"] * Amount / (double)Rate1["Rate"]);

            Console.WriteLine($"\n{"" ,-50}{Amount} {Rate1["CurrencyCode"]} Equals {Result} {Rate2["CurrencyCode"]}");
        }

        public static clsUsersOperations _CurrentUser = null;
            enum enOptions { ListCurrencies = 1, FindCurrency = 2, UpdateRate = 3, CurrencyCalculator = 4, MainMenu = 5 }

            static void ReturnToCurrenciesMenu()
            {
                Console.WriteLine("\n\nPress any key to go back to Currencies Menue ...");
                Console.ReadKey();
                Console.Clear();
                PerformCurrenciesExchangeOptions();
            }


        static void ListCurrencies()
        {
            DataTable Dt = clsCurrenciesOperation.AllCurrencies();

            clsMainScreen.CheckForErrors();

            Console.WriteLine("\n\n");
            Console.WriteLine($"{"",-15}----------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"",-15}| {"Country",-30} | {"Code",-5} | {"Currency Name",-40} | {"Rate",-12} |");
            Console.WriteLine($"{"",-15}----------------------------------------------------------------------------------------------------");

            foreach (DataRow Row in Dt.Rows)
            {
                Console.WriteLine($"{"",-15}| {Row["Country"],-30} | {Row["CurrencyCode"],-5} | {Row["CurrencyName"],-40} | {Row["Rate"],-12} |");
            }

            Console.WriteLine($"{"",-15}----------------------------------------------------------------------------------------------------");
        }
        public static void DrawScreen()
            {
            clsHeaderClass.DrawHeader("Currencies Main Menu", _CurrentUser.UserName);
            Console.WriteLine($"{"",-50}=================================================");
                Console.WriteLine($"{"",-50}           Exchange Currencies Main Screen");
                Console.WriteLine($"{"",-50}=================================================");
                Console.WriteLine($"{"",-50}[1] List Currencies.");
                Console.WriteLine($"{"",-50}[2] Find Currency.");
                Console.WriteLine($"{"",-50}[3] Update Rate.");
                Console.WriteLine($"{"",-50}[4] Currency Calculator.");
                Console.WriteLine($"{"",-50}[5] Main Menu.");
                Console.WriteLine($"{"",-50}=================================================");
            }

            private static int CheckEnteredNumber()
            {
                int Number = 0;
                do
                {
               
                    DrawScreen();

                    Console.Write($"{"",-50}Choose what do you want to do ? [1 to 5] ? ");

                    if (int.TryParse(Console.ReadLine(), out Number) && Number >= 1 && Number <= 5)
                    {
                        return Number;
                    }

                } while (true);
            }

            public static void PerformCurrenciesExchangeOptions()
            {

            clsUsersOperations CurrentUser = clsMainScreen._User;
            _CurrentUser = CurrentUser;
            DrawScreen();
            enOptions SelectedOption = (enOptions)CheckEnteredNumber();

                switch (SelectedOption)
                {
                    case enOptions.ListCurrencies:
                        {
                        clsHeaderClass.DrawHeader("List Currencies Screen", CurrentUser.UserName);
                        ListCurrencies();
                        ReturnToCurrenciesMenu();
                            break;
                        }
                    case enOptions.FindCurrency:
                        {
                        clsHeaderClass.DrawHeader("Find Currency Screen", CurrentUser.UserName);
                        FindTheCurrency();
                        ReturnToCurrenciesMenu();
                            break;
                        }
                    case enOptions.UpdateRate:
                        {
                        clsHeaderClass.DrawHeader("Update Rate Screen", CurrentUser.UserName);
                        UpdateRate();
                        ReturnToCurrenciesMenu(); 

                            break;
                        }
                    case enOptions.CurrencyCalculator:
                        {
                        clsHeaderClass.DrawHeader("Transfer Currencies Screen", CurrentUser.UserName);
                        PerformCurrenciesCalculator();
                        ReturnToCurrenciesMenu();
                            break;
                        }
                    case enOptions.MainMenu:
                        {
                             clsMainScreen.PerformMainScreenActions(clsMainScreen._User);
                            break;
                        }
                }


            }
        }
    }

