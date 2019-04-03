using System.Collections.Generic;

namespace BasicApiResponse.Models.Dto
{
    public class ProductBankAccountsResponse
    {
        public ProductResponse Product { get; set; }
        public List<BankAccountResponse> BankAccounts { get; set; }
    }
}