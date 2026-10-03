using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePresentationLayer
{
    public static class  clsCleintsInterface
    {
        static clsClientsOperations _CurrentClient = null;
    
       static  void  FillData (clsClientsOperations Client)
        {
            

            Console.Write("Enter First Name ? ");
            Client.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name ? ");
            Client.LastName = Console.ReadLine();

            if (Client.Mode == clsClientsOperations.enMode.AddNew)
            {
                Console.Write("Enter Account Name ? ");
                Client.AccountName = Console.ReadLine();
            }
            Console.Write("Enter Email ? ");
            Client.Email = Console.ReadLine();

            Console.Write("Enter Phone ? ");
            Client.Phone = Console.ReadLine();

            Console.Write("Enter PinCode ? ");
            Client.PinCode = Console.ReadLine();

            Console.Write("Enter Balance ? ");
            Client  .Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n\n");
        }
         static void PrintClientCard(clsClientsOperations Client)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{"",-50}---------------------------------------------------");
            Console.WriteLine($"{"",-50}                 Client Details");
            Console.WriteLine($"{"",-50}---------------------------------------------------");
                                     
            Console.WriteLine($"{"",-50} {"Client ID",-17} : {Client.ID}");
            Console.WriteLine($"{"",-50} {"Account Number",-17} : {Client.AccountName}");
            Console.WriteLine($"{"",-50} {"First Name",-17} : {Client.FirstName}");
            Console.WriteLine($"{"",-50} {"Last Name",-17} : {Client.LastName}");
            Console.WriteLine($"{"",-50} {"Phone",-17} : {Client.Phone}");
            Console.WriteLine($"{"",-50} {"Email",-17} : {Client.Email}");
            Console.WriteLine($"{"",-50} {"Pin Code",-17} : {Client.PinCode}");
            Console.WriteLine($"{"",-50} {"Balance",-17} : {Client.Balance}");
                                     
            Console.WriteLine($"{"",-50}---------------------------------------------------\n");
        }

        public static void ListClients ()
        {

           
            DataTable DT = clsClientsOperations.GetClientList();
            clsMainScreen.CheckForErrors();
            Console.WriteLine("\n\n");
            Console.WriteLine($"{"",-15}----------------------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine($"{"",-15}| ID   | Account Number  | Client Name         | Phone        | Email                          | Pin Code    | Balance     |\n");
            Console.WriteLine($"{"",-15}----------------------------------------------------------------------------------------------------------------------------");

            foreach (DataRow Row in DT.Rows)
            {
                string fullname =(string)Row["FirstName"] + " " + Row["LastName"];
                Console.WriteLine($"{"",-15}| {Row["ClientID"],-4} | {Row["AccountName"],-15} | {fullname,-19}" +
                    $" | {Row["Phone"],-12} | {Row["Email"],-30} | {Row["PinCode"],-11} | {Row["Balance"],-11} |");
            }

            Console.WriteLine($"{"",-15}----------------------------------------------------------------------------------------------------------------------------");
           
        }
        
        public static void AddNewClient ()
        {
           clsClientsOperations NewClient = new clsClientsOperations();
            FillData( NewClient );

            if (NewClient.Save())
            {
                clsMainScreen.CheckForErrors();
                Console.WriteLine("Client Added Successfully :-)");
            }
            else
            {
                Console.WriteLine("Operation Canceled . Error Occured while Adding The Client  :-(");
            }
        }

        public static void DeleteClientFunction ()
        {
        
            int Number = 0;
            FindClientFunction();
            if (_CurrentClient == null)
            {
                return;
            }
            do
            {
             
                Console.Write("\nAre You Sure to Delete this Client ? (YES = 1 / NO = 0) ? ");
                if (int.TryParse(Console.ReadLine(), out Number) &&( Number == 1 || Number == 0 ))
                {
                    break;
                }
            }
            while (true);
            
          if (  _CurrentClient._DeleteClient() )
            {
                Console.WriteLine("Client Deleted Successfully");
            }


        }
        public static clsClientsOperations FindClientFunction ()
        {
            Console.Write($"{"",-50}Please Enter Account Name Are you Serching For ? ");
            string AccountNumber = Console.ReadLine();
            Console.WriteLine();
            clsClientsOperations Client = clsClientsOperations.FindClient(AccountNumber);
            clsMainScreen.CheckForErrors();
            _CurrentClient  = Client;
           
            if (Client != null)
            {
                PrintClientCard(Client);
            }
            else
            {
                Console.WriteLine($"{"",-50}Client with Account Name [{AccountNumber}] was not found!");
            }

            return Client;
        }

        public static void UpdateClientFunction()
        {int Number = 0;
            FindClientFunction();
            if (_CurrentClient == null)
            {
                return;
            }
            Console.WriteLine("\nUpdate Data   ... \n");
            FillData(_CurrentClient);
            do
            {

                Console.WriteLine("\nAre You Sure to Update this Client? (YES = 1 / NO = 0) ? ");
                if (int.TryParse(Console.ReadLine(), out Number) && (Number == 1 || Number == 0))
                {
                    break;
                }
            }
            while (true);
            if ( _CurrentClient.Save() )
            {
                Console.WriteLine("\nClient Updated Successfully");
            }
           else
            {
                Console.WriteLine("An Error Occured  ,  Operation Canceled");
            }
        }

  
    }
}
