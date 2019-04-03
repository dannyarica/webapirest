using System.Collections.Generic;

namespace BasicApiResponse.Models.Dto
{
    public class UserProductsResponse
    {
        public string UserId { get; set; }
        public List<ProductBankAccountsResponse> Products { get; set; }
    }
}