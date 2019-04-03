using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Models.Dto
{
    public class ProductBankAccountsResponse
    {
        public ProductResponse Product { get; set; }
        public List<BankAccountResponse> BankAccounts { get; set; }
    }
}