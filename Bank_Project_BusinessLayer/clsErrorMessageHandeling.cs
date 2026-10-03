using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public  static class  clsErrorMessageHandeling
    {
        public static string ErrorMessage()
        {
            if (! string.IsNullOrEmpty( clsAccesstoClientsData.ErrorMessage ) )
            {
                return clsAccesstoClientsData.ErrorMessage;
            }
            else if (!string.IsNullOrEmpty( clsAccesstoUsersData.ErrorMessage ))
            {
                return clsAccesstoUsersData.ErrorMessage;
            }
            else
            {
                return null;
            }
        }
    }
}
