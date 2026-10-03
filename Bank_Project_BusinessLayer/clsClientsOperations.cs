using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class clsClientsOperations
    {
        public enum enMode { AddNew = 1, Update = 2 }


     public  enMode Mode = enMode.Update;
        public int ID { get; set; }
        public string AccountName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PinCode { get; set; }
        public double Balance { get; set; }

        public clsClientsOperations()
        {

            Mode = enMode.AddNew;
            ID = -1;
            LastName = "";
            FirstName = "";
            Balance = 0;
            Email = "";
            Phone = "";
            PinCode = "";
        }
        private clsClientsOperations ( int ID, string FirstName  ,  string LastName  ,  string AccountNumber  ,string Phone  ,  string Email , string PinCode , double Balance )
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName   = LastName;
            this.Balance = Balance;
            this.PinCode = PinCode;
            this.Email  = Email;
            this.Phone = Phone;
            this.AccountName = AccountNumber;
        }

        static public DataTable GetClientList()
        {
            return clsAccesstoClientsData.GetAllClients();
        }

        public static clsClientsOperations FindClient(string AccountName)
        {
            clsAccesstoClientsData.stClientData ClientData = new clsAccesstoClientsData.stClientData();

            if (clsAccesstoClientsData.FindClientByAccountName(AccountName, ref ClientData))
            {
                return new clsClientsOperations(ClientData.ID, ClientData.FirstName, ClientData.LastName,
                                                ClientData.AccountName, ClientData.Phone, ClientData.Email,
                                                ClientData.PinCode, ClientData.Balance);
            }
            else
            { return null;  }
        }

        private bool _AddNewClient()
        {
            this.ID = clsAccesstoClientsData.AddingNewClient(FirstName, LastName, Email, Phone, AccountName, PinCode, Balance);
            return (this.ID != -1);

        }

        public bool  _DeleteClient()
        {
            return clsAccesstoClientsData.Delete(this.AccountName);
        }

        public bool _UpdateClient ()
        {
            return clsAccesstoClientsData.UpdateClient(FirstName , LastName , Email , Phone , AccountName , PinCode , Balance);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return (_AddNewClient());

                    }
                case enMode.Update:
                    {
                        return _UpdateClient();
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        public static double GetTotalAmount ()
        {
            return clsAccesstoClientsData.AllBalances();
        }
        public bool UpdateBalance()
        {
            return clsAccesstoClientsData.UpdateBalance(this.AccountName, this.Balance);
        }

        public static void CreateTransferLog (int SenderAccount , int Recieceraccount , double amount  , int UserID )
        {
            clsAccesstoClientsData.AddtoTransactionsTable(DateTime.Now, SenderAccount, Recieceraccount, amount, UserID);

        }
        public static DataTable GetLogs ()
        {
            return clsAccesstoClientsData.GetLogs();
        }
    }
}
