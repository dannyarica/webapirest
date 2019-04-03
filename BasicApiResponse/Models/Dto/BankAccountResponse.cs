using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BasicApiResponse.Models.Response;

namespace BasicApiResponse.Models.Dto
{
    public class BankAccountResponse
    {
        public string BankAccountNumber { get; set; }
        public BankAccountType BankAccountType { get; set; }
        public string Cci { get; set; }
        public double AccountantBalance { get; set; }
        public double AvailableBalance { get; set; }
        public Currency CurrencyType { get; set; }
    }
}