using System;
using System.Data;
using BankSystemDataAccessLayer;
using Microsoft.SqlServer.Server;

namespace BankSystemBusinessLayer
{
    public class clsUsersOperations
    {
        public enum enAccessiblitiesList {ShowClientList = 1 , AddNew = 2 , Delete = 4  ,Update = 8 , Find = 16  ,  Tansactions = 32 , Manageusers  = 64,
        Logs=  128 , CurrenciesEx = 256}

        public enum enMode  {AddNew = 1  , Update  = 2}
        private enMode Mode = enMode.Update; 
      public static string GetErrorMessage  ()
        {
            return clsAccesstoUsersData.ErrorMessage;
        }
        private static string _SwapLettersinString(string Word)
        {
            if (Word.Length <= 2)
            {
                return "";
            }
            char[] Cword = Word.ToCharArray();
            char Temp = Cword[0];
            Cword[0] = Cword[Word.Length - 1];
            Cword[Word.Length - 1] = Temp;

            return new string(Cword);
        }

        private static string _Encription(string password, int EncrptionKey)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "";
            }
            string AfterEncription = "";
            for (int i = 0; i < password.Length; i++)
            {
                AfterEncription += Convert.ToChar(((int)password[i] + EncrptionKey));

            }

            return _SwapLettersinString(AfterEncription);

        }
        public static string _Decription (string password, int EncrptionKey)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "";
            }
            string AfterEncription = "";
            for (int i = 0; i < password.Length; i++)
            {
                AfterEncription += Convert.ToChar(((int)password[i] - EncrptionKey));

            }

            return _SwapLettersinString(AfterEncription);

        }
        public int UserID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int Accessibilities { set; get; }

        public clsUsersOperations ()
        {
            UserID = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
            Phone = "";
            UserName = "";
            Accessibilities = 0;
            Mode = enMode.AddNew;
        }
        private clsUsersOperations(int userid, string firstname, string lastname, string email, string phone, string username, string password, int access)
        {
            this.UserID = userid;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Accessibilities = access;
            this.UserName = username;
            this.Password = password;
            Mode = enMode.Update;
        }
        public static clsUsersOperations TryLogin(string username,bool LoginIndicator ,string password ="")
        {
            clsAccesstoUsersData.stUserData UserData = new clsAccesstoUsersData.stUserData();
            if (clsAccesstoUsersData.CheckingLoginINDetails(username,  ref UserData ,LoginIndicator , _Encription(password, 2)))
            {
                return new clsUsersOperations(UserData.UserID, UserData.FirstName, UserData.LastName, UserData.Email, UserData.Phone
                    , UserData.UserName,_Decription( UserData.Password ,2), UserData.Accessibilities);
            }
            else
            {
                return null;
            }
        }

        public bool CheckAccessibility( enAccessiblitiesList Access )
        {
            if (Accessibilities == -1)
            {
                return true;
            }
            int TrasformtoInt = (int)Access;
            if ((Accessibilities & TrasformtoInt) == TrasformtoInt)
            {
                return true;
                    }
            else { return false; }

        }
        public static DataTable ListUsers ()
        {
           return clsAccesstoUsersData.GetAllUsers();
        }
        public  void SaveLogin ()
        {
            clsAccesstoUsersData.RegisterLogin(this.UserName, _Encription(this.Password ,2), this.Accessibilities);
        }

        bool _AddnewUser ()
        {
            return clsAccesstoUsersData.AddNewUser(FirstName, LastName, Email, _Encription( Password ,2), Phone, Accessibilities, UserName);
        }

        bool _UpdateUser ()
        {
            return clsAccesstoUsersData.UpdateUser(UserName, Password, FirstName, LastName, Email, Phone, Accessibilities);
        }
        public bool Save ()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return (_AddnewUser());
                    }
                case enMode.Update:
                    {
                        return _UpdateUser();
                    }
                default:
                    {
                        return false;
                    }

            }


        }
        public static DataTable GetLogs ()
        {
            return clsAccesstoUsersData.LoginLogs();
        }
      public   bool _DeleteUser ()
        {
           return   clsAccesstoUsersData.DeleteUser(this.UserName);

        }

       
    }
}