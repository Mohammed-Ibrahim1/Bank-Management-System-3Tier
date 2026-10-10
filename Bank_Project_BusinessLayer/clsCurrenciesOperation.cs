using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{

   
    public class clsCurrenciesOperation
    {

       
        static public DataTable  FindCurrency(string code)
        {
            return clsAccesstoCurrenciesData.GetCurrency(code);
        }
        public static DataTable AllCurrencies ()
        {
            return clsAccesstoCurrenciesData.GetAllCurrencies ();
        }

        public static bool UpdateRate (string code  ,  double rate)
        {
            return clsAccesstoCurrenciesData.RateUpdate(code, rate);

        }
        
    }
}
