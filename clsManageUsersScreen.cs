using BankSystemBusinessLayer;
using System;
using System.Data;

namespace ConsolePresentationLayer
{
    public class clsManageUsersScreen
    {

        enum enOptions { ListUsers = 1, AddNewUser = 2, DeleteUser = 3, UpdateUser = 4, FindUser = 5, MainMenu = 6 }

        static void ReturnToManageUsersMenu()
        {
            Console.WriteLine("\n\nPress any key to go back to Manage Users Menue ...");
            Console.ReadKey();
            PerformManageUsersScreenOptions();
        }

        private static int CheckEnteredNumber()
        {
            int Number = 0;
            do
            {
                Console.Clear();
                DrawScreen();
                Console.Write($"{"",-50}Choose what do you want to do? [1 to 6]? ");

                if (int.TryParse(Console.ReadLine(), out Number) && Number >= 1 && Number <= 6)
                {
                    return Number;
                }

            } while (true);
        }
     static   bool getAcceptionFromUser ()
        {
            if (Console.ReadLine() == "1")
            {
                return true;
            }
            return false;
        }

      static  int GetAccessibilityes  ()
        {
            Console.WriteLine("\nPermisstions : ");
            Console.WriteLine("\nDo You Want to Give this User Full Access to System ? (YES = 1 / NO = 0) ? ");
            if (getAcceptionFromUser())
            {
                return -1;
            }
            Console.WriteLine("\n\nGive Acces to : \n\n");
            int Permisstions = 0;
            Console.Write("List Clients (YES = 1 / NO = 0) ?    ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.ShowClientList;
            }

            Console.Write("Add Clients (YES = 1 / NO = 0) ?     ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.AddNew;
            }

            Console.Write("Delete Clients (YES = 1 / NO = 0) ?  ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.Delete;
            }

            Console.Write("Update Clients (YES = 1 / NO = 0) ?  ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.Update;
            }

            Console.Write("Find Clients (YES = 1 / NO = 0) ?    ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.Find;
            }

            Console.Write("Transactions (YES = 1 / NO = 0) ?    ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.Tansactions;
            }

            Console.Write("Manage Users (YES = 1 / NO = 0) ?    ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.Manageusers;
            }

            Console.Write("LoginLogs (YES = 1 / NO = 0) ?      ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.Logs;
            }

            Console.Write("Currencies (YES = 1 / NO = 0) ?     ");
            if (getAcceptionFromUser())
            {
                Permisstions = Permisstions | (int)clsUsersOperations.enAccessiblitiesList.CurrenciesEx;
            }


            return Permisstions;
        }

        static void  FillData (clsUsersOperations User)
        {
            Console.WriteLine("\n\nPlease Enter FirstName ? ");
            User.FirstName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter LastName ? ");
            User.LastName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter UserName ? ");
            User.UserName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Password ? ");
            User.Password = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Email ? ");
            User.Email = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Phone ? ");
            User.Phone = Console.ReadLine();

            User.Accessibilities = GetAccessibilityes();
           
        }
        static clsUsersOperations FindUser ()
        {
            string CurrentUser;
            Console.Write($"\n\n{"", -50}Please Enter User Name to Find : ");
            CurrentUser =  Console.ReadLine();

            
            clsUsersOperations User = clsUsersOperations.TryLogin(CurrentUser , false);
            clsMainScreen.CheckForErrors();

            if (User == null)
            {
                Console.WriteLine($"\n\n{"",-50}User with UserName [{CurrentUser}] was not found!");
                return null;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"{"",-50}------------------------------------------------");
            Console.WriteLine($"{"",-50}                  User Details");
            Console.WriteLine($"{"",-50}------------------------------------------------");

            Console.WriteLine($"{"",-50} {"User ID",-17}: {User.UserID}");
            Console.WriteLine($"{"",-50} {"User Name",-17}: {User.UserName}");
            Console.WriteLine($"{"",-50} {"First Name",-17}: {User.FirstName}");
            Console.WriteLine($"{"",-50} {"Last Name",-17}: {User.LastName}");
            Console.WriteLine($"{"",-50} {"Phone",-17}: {User.Phone}");
            Console.WriteLine($"{"",-50} {"Email",-17}: {User.Email}");
            Console.WriteLine($"{"",-50} {"Password",-17}: {User.Password}");
            Console.WriteLine($"{"",-50} {"Accessibilities",-17}: {User.Accessibilities}");

            Console.WriteLine($"{"",-50}------------------------------------------------\n");

            return User;

        }

        static void DeleteUser ()
        {
            clsUsersOperations User = FindUser();
            if (User == null)
            {
                return;
            }
            Console.Write($"\n{"",-50}Are you Sure to Delete this User ? (YES = 1 / NO = 0) ? ");
            if (Console.ReadLine()== "1")
            {
                 if(User._DeleteUser())
                {
                    Console.WriteLine("\n\nUser Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("\n\nError , Opertion didn't Complete");
                }

            }
            else
            {
                Console.WriteLine("\n\nOperation Canceled");
            }

        }
        
        public static void ListUsers()
        {
    
            DataTable DT = clsUsersOperations.ListUsers();

            clsMainScreen.CheckForErrors();

            Console.WriteLine("\n\n");
            Console.WriteLine($"{"",-15}---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"",-15}| {"ID",-4} | {"User Name",-12} | {"Full Name",-19} | {"Phone",-12} | {"Email",-30} | {"Password",-10} | {"Accessibilities",-15} |");
            Console.WriteLine($"{"",-15}---------------------------------------------------------------------------------------------------------------------------");

            foreach (DataRow Row in DT.Rows)
            {
                string fullname = (string)Row["FirstName"] + " " + Row["LastName"];

                Console.WriteLine($"{"",-15}| {Row["UserID"],-4} | {Row["UserName"],-12} | {fullname,-19} | {Row["PhoneNumber"],-12} | {Row["Email"],-30} | {clsUsersOperations._Decription( (string)Row["Password"],2),-10} | {Row["Accessibilities"],-15} |");
            }

            Console.WriteLine($"{"",-15}---------------------------------------------------------------------------------------------------------------------------");
        }

        private static void AddNewUser ()
        {
            bool Isaded = false;
            clsUsersOperations NewUser = new clsUsersOperations ();
            FillData(NewUser);
            Isaded = NewUser.Save();
            clsMainScreen.CheckForErrors ();

            if (Isaded)
            {
                Console.WriteLine("User Added Successfully");
            }
            else
            {
                Console.WriteLine("An Error Occured while Adding New User ");
            }
        }


        public static void DrawScreen()
        {
            
            clsUsersOperations CurrentUser = clsMainScreen._User;

            Console.Clear();
            clsHeaderClass.DrawHeader("Manage Users Screen", CurrentUser.UserName);

            Console.WriteLine($"{"",-50}===========================================");
            Console.WriteLine($"{"",-50}            Manage Users Menue");
            Console.WriteLine($"{"",-50}===========================================");
            Console.WriteLine($"{"",-50}[1] List Users.");
            Console.WriteLine($"{"",-50}[2] Add New User.");
            Console.WriteLine($"{"",-50}[3] Delete User.");
            Console.WriteLine($"{"",-50}[4] Update User.");
            Console.WriteLine($"{"",-50}[5] Find User.");
            Console.WriteLine($"{"",-50}[6] Main Menue.");
            Console.WriteLine($"{"",-50}===========================================");
        }
        
        static void UpdateUser ()
        {
            clsUsersOperations User = FindUser();
            Console.WriteLine("\n\n");
            FillData(User);
            Console.Write("\n\nConfirm Modifications ? (YES = 1 / NO = 0) ? ");
            if (Console.ReadLine() == "1")
            {
                bool Save = User.Save();
                clsMainScreen.CheckForErrors();
                if (Save) { Console.WriteLine("\nUser Updated Successfully"); }
                else { Console.WriteLine("\nOperation Didn't Complete"); }
            }
            else
            {
                Console.WriteLine("\nOperation Canceled");
            }
        }
         
        public static void PerformManageUsersScreenOptions()
        {
            clsUsersOperations CurrentUser = clsMainScreen._User;

            enOptions SelectedOption = (enOptions)CheckEnteredNumber();

            switch (SelectedOption)
            {
                case enOptions.ListUsers:
                    {
                        clsHeaderClass.DrawHeader("List Users Screen", CurrentUser.UserName);
                        ListUsers();
                        ReturnToManageUsersMenu();
                        break;
                    }
                case enOptions.AddNewUser:
                    {
                        clsHeaderClass.DrawHeader("Add New User Screen", CurrentUser.UserName);
                        AddNewUser();
                        ReturnToManageUsersMenu();
                        break;
                    }
                case enOptions.DeleteUser:
                    {
                        clsHeaderClass.DrawHeader("Delete User Screen", CurrentUser.UserName);
                        DeleteUser();
                        ReturnToManageUsersMenu();
                        break;
                    }
                case enOptions.UpdateUser:
                    {
                        clsHeaderClass.DrawHeader("Update User Screen", CurrentUser.UserName);
                        UpdateUser();
                        ReturnToManageUsersMenu();
                        break;
                    }
                case enOptions.FindUser:
                    {
                        clsHeaderClass.DrawHeader("Find User Screen", CurrentUser.UserName);
                        FindUser();
                        ReturnToManageUsersMenu();
                        break;
                    }
                case enOptions.MainMenu:
                    {
                        clsMainScreen.PerformMainScreenActions(CurrentUser);
                        break;
                    }
            }
        }
    }
}