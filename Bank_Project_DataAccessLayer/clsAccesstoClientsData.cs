using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BankSystemDataAccessLayer;
using System.Xml.Schema;

namespace BankSystemBusinessLayer

{


    public static class clsAccesstoClientsData
    {

        public static string ErrorMessage = null;
        public struct stClientData
        {
            public int ID { set; get; }
            public string AccountName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string PinCode { get; set; }
            public double Balance { get; set; }

        }


        static public DataTable GetAllClients()
        {
            DataTable DT = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Select * From Clients";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { Connection.Close(); }

            return DT;
        }
        static public int AddingNewClient(string FirstName, string LastName, string Email, string Phone, string AccountName, string PinCode, double Balance)
        {
            int CurrentID = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = @"Insert into Clients ( FirstName  ,  LastName  ,  Email  , Phone  , AccountName  ,  PinCode  ,  Balance) 
                            Values (@firstname  ,  @lastname  , @email ,  @phone  , @accountname  , @pincode , @balance)
                             Select SCOPE_IDENTITY()";
            SqlCommand Command1 = new SqlCommand(Query, Connection);
            Command1.Parameters.AddWithValue("@firstname", FirstName);
            Command1.Parameters.AddWithValue("@lastname", LastName);
            Command1.Parameters.AddWithValue("@email", Email);
            Command1.Parameters.AddWithValue("@phone", Phone);
            Command1.Parameters.AddWithValue("@accountname", AccountName);
            Command1.Parameters.AddWithValue("@pincode", PinCode);
            Command1.Parameters.AddWithValue("@balance", Balance);

            try
            {
                Connection.Open();
                object result = Command1.ExecuteScalar();
                if (result != null)
                {
                    int.TryParse(result.ToString(), out CurrentID);
                }
            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { Connection.Close(); }

            return CurrentID;
        }


        public static bool FindClientByAccountName(string AccountName, ref stClientData Data)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);

            string Query = "Select * from Clients Where AccountName = @accountName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@accountName", AccountName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    Data.ID = (int)Reader["ClientID"];
                    Data.AccountName = (string)Reader["AccountName"];
                    Data.FirstName = (string)Reader["FirstName"];
                    Data.LastName = (string)Reader["LastName"];
                    Data.Phone = (string)Reader["Phone"];
                    Data.Email = (string)Reader["Email"];
                    Data.PinCode = (string)Reader["PinCode"];
                    Data.Balance = Convert.ToDouble(Reader["Balance"]);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static bool Delete(string AccounName)
        {
            int NumberofRows = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Delete from Clients Where AccountName = @account";
            SqlCommand Command1 = new SqlCommand(Query, Connection);
            Command1.Parameters.AddWithValue("@account", AccounName);
            try
            {
                Connection.Open();
                NumberofRows = Command1.ExecuteNonQuery();

            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { Connection.Close(); }

            return (NumberofRows > 0);
        }

        static public bool UpdateClient(string FirstName, string LastName, string Email, string Phone, string AccountName, string PinCode, double Balance)
        {
            bool IsUpdated = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);

            string Query = @"Update Clients 
                     Set FirstName = @firstname, 
                         LastName  = @lastname, 
                         Email     = @email, 
                         Phone     = @phone, 
                         PinCode   = @pincode, 
                         Balance   = @balance
                     Where AccountName = @accountname";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@firstname", FirstName);
            Command.Parameters.AddWithValue("@lastname", LastName);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@phone", Phone);
            Command.Parameters.AddWithValue("@accountname", AccountName);
            Command.Parameters.AddWithValue("@pincode", PinCode);
            Command.Parameters.AddWithValue("@balance", Balance);

            try
            {
                ErrorMessage = "";

                Connection.Open();

                int rowsAffected = Command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsUpdated = true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                Connection.Close();
            }

            return IsUpdated;
        }


        static public bool UpdateBalance(string AccountName, double NewBalance)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);


            string Query = "Update Clients Set Balance = @balance Where AccountName = @accountname";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@accountname", AccountName);
            Command.Parameters.AddWithValue("@balance", NewBalance);

            try
            {
                ErrorMessage = null;
                Connection.Open();

                int rowsAffected = Command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    IsUpdated = true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                Connection.Close();
            }

            return IsUpdated;
        }

        public static double AllBalances()
        {
            double Total = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Select Sum(Balance) from Clients";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                double.TryParse(Result.ToString(), out Total);

            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { Connection.Close(); }

            return Total;
        }

        public static void AddtoTransactionsTable(DateTime Date, int SenderAccount, int Recieceraccount, double amount, int UserID)
        {
           
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);

            string Query = @"Insert into Transactions (DateAndTime, SenderAccountID, RecieverAccountID, Amount, UserID) 
                     Values (@date, @sender, @receiver, @amount, @userid)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@date", Date);
            Command.Parameters.AddWithValue("@sender", SenderAccount);
            Command.Parameters.AddWithValue("@receiver", Recieceraccount);
            Command.Parameters.AddWithValue("@amount", amount);
            Command.Parameters.AddWithValue("@userid", UserID);

            try
            {
                ErrorMessage = "";
                Connection.Open();

                int rowsAffected = Command.ExecuteNonQuery();

             
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                Connection.Close();
            }

        }
        public static DataTable GetLogs ()
        {
            DataTable DT = new DataTable();
            SqlConnection sqlConnection =  new SqlConnection (clsDataAccessStatics.ConnectionString);
            string Query = @"Select Transactions.TransactionID ,Transactions.DateAndTime  ,Amount , 
Sender.AccountName as SenderAccount , Clients.AccountName as RecieverAccount
, Users.UserName 
From Transactions Inner Join Clients as Sender 
ON Transactions.SenderAccountID = Sender.ClientID
Inner  Join Clients 
On Clients.ClientID = Transactions.RecieverAccountID
Inner Join Users 
ON Users.UserID = Transactions.UserID;" ;

            SqlCommand Command = new SqlCommand (Query, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { sqlConnection.Close(); }

            return DT;
        }
    }
}
