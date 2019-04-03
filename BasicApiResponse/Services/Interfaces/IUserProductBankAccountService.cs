using BasicApiResponse.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApiResponse.Services
{
    public interface IUserProductBankAccountService
    {
        UserProductsResponse GetProductsByUserId(string userid);
        ProductBankAccountsResponse GetBankAccountsByProductId(string userid, int productid);
    }
}
