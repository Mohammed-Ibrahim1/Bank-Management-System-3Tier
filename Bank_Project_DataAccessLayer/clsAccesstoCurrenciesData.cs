using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BankSystemDataAccessLayer;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace BankSystemBusinessLayer
{
    public static  class clsAccesstoCurrenciesData
    {

        static public string ErrorMessage = null;
        public static DataTable GetAllCurrencies ()
        {
            DataTable Dt = new DataTable ();
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Select *  from Currencies";
            SqlCommand Command = new SqlCommand (Query, Connection);
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

       public static DataTable GetCurrency (string Code )
        {

            DataTable Dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Select *  from Currencies Where CurrencyCode  = @code";
            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@code", Code);
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
        public static bool RateUpdate (string CurrencyCode ,  float NewRate)
        {
            int NumberofRows = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessStatics.ConnectionString);
            string Query = "Update  Currencies Set Rate  = @rate Where CurrencyCode  = @code";
        SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@code", CurrencyCode);
            Command.Parameters.AddWithValue("@rate", NewRate);


            try
            {
                Connection.Open();
                NumberofRows = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { ErrorMessage = ex.Message; }
        finally { Connection.Close(); }
            return NumberofRows > 0;
        }
    }
}
