using System;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Runtime.Remoting.Metadata;
using System.Diagnostics.Contracts;

namespace BankSystemDataAccessLayer
{
public static class clsAccesstoUsersData
    {

        public static string ErrorMessage = null;
        public struct stUserData
        {
            public int UserID { set; get; }
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public string Email { set; get; }
            public string Phone { set; get; }
            public string UserName { set; get; }
            public string Password { set; get; }
            public int Accessibilities { set; get; }
        }

        
       
        public static bool CheckingLoginINDetails (string username  , ref stUserData Data,bool LoginIndicator  , string password )
        {
            bool IsExists  = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = @"Select * from Users Where UserName  = @username  and Password = @password";
            string Query2 = @"Select * from Users Where UserName  = @username  ";
            SqlCommand Command = new SqlCommand (Query2, Connection);
            Command.Parameters.AddWithValue("@username", username);

            if (LoginIndicator)
            {
               
                Command  = new SqlCommand (Query, Connection);
                Command.Parameters.AddWithValue("@password", password);
                Command.Parameters.AddWithValue("@username", username);
            }
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                     IsExists = true;
                    Data.UserID = (int)Reader["UserID"];
                    Data.FirstName = (string)Reader["FirstName"];
                    Data.LastName = (string)Reader["LastName"];
                    Data.Email = (string)Reader["Email"];
                    Data.Phone = (string)Reader["PhoneNumber"];
                    Data.UserName = (string)Reader["UserName"];
                    Data.Accessibilities = (int)Reader["Accessibilities"];
                    Data.Password= (string)Reader["Password"];

                }
                Reader.Close();

            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { Connection.Close(); }

            return IsExists;
        }

        public static void RegisterLogin(string username, string password, int access)
        {
            DateTime Dateandtime = DateTime.Now;

            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);

           
            string Query = @"INSERT INTO LoginLogs (LoginDateTime, SystemUser, Password, Accessibilities) 
                     VALUES (@dateandtime, @username, @password, @access)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            
            Command.Parameters.AddWithValue("@dateandtime", Dateandtime);
            Command.Parameters.AddWithValue("@username", username);
            Command.Parameters.AddWithValue("@password", password);
            Command.Parameters.AddWithValue("@access", access);

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

        public static DataTable GetAllUsers()
        {
            DataTable Dt = new DataTable();
           SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Select *  From Users";
            SqlCommand Command = new SqlCommand (Query ,  Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    Dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { Connection.Close(); }

            return Dt;
        }

        public static bool AddNewUser(string Firstname, string lastname, string email, string password, string phone, int accessibilities, string username)
        {
            int CurrentID = 0;
            bool IsInserted = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);

            string Query = @"INSERT INTO Users (FirstName, LastName, Email, PhoneNumber, UserName, Password, Accessibilities) 
                     VALUES (@firstname, @lastname, @email, @phone, @username, @password, @access)
                      Select SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@firstname", Firstname);
            Command.Parameters.AddWithValue("@lastname", lastname);
            Command.Parameters.AddWithValue("@email", email);
            Command.Parameters.AddWithValue("@phone", phone);
            Command.Parameters.AddWithValue("@username", username);
            Command.Parameters.AddWithValue("@password", password);
            Command.Parameters.AddWithValue("@access", accessibilities);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out CurrentID))
                {
                    IsInserted = true;
                }
            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { Connection.Close(); }

            return IsInserted;
        }

        public static bool DeleteUser (string username )
        {
            int Rows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Delete From Users Where UserName = @username";
            SqlCommand Command=  new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue ("@username", username);
            try
            {
                connection.Open();
                Rows = Command.ExecuteNonQuery();
            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
            finally { connection.Close(); }
            return (Rows > 0);
        }

        public static bool UpdateUser (string username  , string password  ,  string firstnaem  ,  string lastname , string email , string phone ,int Access)
        {
            int Rows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessStatics.ConnectionString);

            string Query = @"UPDATE Users 
                     SET FirstName = @firstname, 
                         LastName = @lastname, 
                         Email = @email, 
                         PhoneNumber = @phone, 
                         Password = @password, 
                         Accessibilities = @access 
                     WHERE UserName = @username";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@username", username);
            Command.Parameters.AddWithValue("@password", password);
            Command.Parameters.AddWithValue("@firstname", firstnaem);
            Command.Parameters.AddWithValue("@lastname", lastname);
            Command.Parameters.AddWithValue("@email", email);
            Command.Parameters.AddWithValue("@phone", phone);
            Command.Parameters.AddWithValue("@access", Access);

            try
            {
                ErrorMessage = ""; 
                connection.Open();

                Rows = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return (Rows > 0);


        }

        public static DataTable LoginLogs ()
        {
            DataTable DT = new DataTable();
            SqlConnection Connection  = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Select *  from LoginLogs";
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
    }

}