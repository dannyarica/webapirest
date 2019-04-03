using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Models.Dto
{
    public class UserProductsResponse
    {
        public string UserId { get; set; }
        public List<ProductBankAccountsResponse> Products { get; set; }
    }
}