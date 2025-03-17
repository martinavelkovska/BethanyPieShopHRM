using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM.Accounting
{
    //public record Account
    //{
    //    private string accountNumber;

    //    public string AccountNumber
    //    {
    //        get { return accountNumber; }
    //        set
    //        {
    //            accountNumber = value;
    //        }

    //    }
    //}

    //position records:
    public record Account(string AccountNumber); //primary constrcotr syntax
}
