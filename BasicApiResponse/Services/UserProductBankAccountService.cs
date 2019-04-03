using BasicApiResponse.Models.Dto;
using System.Collections.Generic;
using System.Linq;

namespace BasicApiResponse.Services
{
    public class UserProductBankAccountService : IUserProductBankAccountService
    {
        private List<User> userList = new List<User>();
        private List<ProductResponse> ProductList = new List<ProductResponse>();
        private List<BankAccountResponse> BankAccountList = new List<BankAccountResponse>();
        private List<ProductBankAccountsResponse> ProductBankAccountList = new List<ProductBankAccountsResponse>();
        private List<UserProductsResponse> UserProductBankAccountList = new List<UserProductsResponse>();

        public UserProductBankAccountService()
        {
            LoadUsers();
            LoadProducts();
            LoadBankAccounts();
            LoadProductsBankAccounts();
            LoadUserProductsBankAccounts();
        }

        private void LoadUsers()
        {
            userList.Add(new User
            {
                Id = "1234567890",
                FirstName = "Alfredo",
                LastName = "Sánchez",
                Email = "alfredo.sanchez@avantica.net"
            });
        }

        private void LoadProducts()
        {
            ProductList.Add(new ProductResponse
            {
                Id = 231,
                Name = "Ahorros"
            });

            ProductList.Add(new ProductResponse
            {
                Id = 232,
                Name = "CTS"
            });
        }

        private void LoadBankAccounts()
        {
            BankAccountList.Add(new BankAccountResponse
            {
                BankAccountNumber = "7483920388192236",
                Cci = "145274589658236514",
                BankAccountType = new BankAccountType { Id = 1, Name = "Mini Ahorro" },
                CurrencyType = new Currency { Id = 1, Name = "Soles" },
                AccountantBalance = 4697.19,
                AvailableBalance = 4678.54
            });

            BankAccountList.Add(new BankAccountResponse
            {
                BankAccountNumber = "1856745841252365",
                Cci = "253312574885698775451421",
                BankAccountType = new BankAccountType { Id = 2, Name = "Sueldo" },
                CurrencyType = new Currency { Id = 1, Name = "Soles" },
                AccountantBalance = 7822.89,
                AvailableBalance = 7815.63
            });

            BankAccountList.Add(new BankAccountResponse
            {
                BankAccountNumber = "159354785236448",
                Cci = "2365152474756985647",
                BankAccountType = new BankAccountType { Id = 2, Name = "CTS" },
                CurrencyType = new Currency { Id = 1, Name = "Soles" },
                AccountantBalance = 2233.62,
                AvailableBalance = 2218.45
            });
        }

        private void LoadProductsBankAccounts()
        {
            ProductBankAccountList.Add(new ProductBankAccountsResponse
            {
                Product = ProductList[0],
                BankAccounts = new List<BankAccountResponse>()
                {
                    BankAccountList[0],
                    BankAccountList[1]
                }
            });

            ProductBankAccountList.Add(new ProductBankAccountsResponse
            {
                Product = ProductList[1],
                BankAccounts = new List<BankAccountResponse>()
                {
                    BankAccountList[2]
                }
            });
        }

        private void LoadUserProductsBankAccounts()
        {
            UserProductBankAccountList.Add(new UserProductsResponse
            {
                UserId = userList[0].Id,
                Products = ProductBankAccountList
            });
        }

        public UserProductsResponse GetProductsByUserId(string userid)
        {
            UserProductsResponse userProduct = null;

            try
            {
                userProduct = UserProductBankAccountList.Where(x => x.UserId == userid).First();
            }
            catch { }

            return userProduct;
        }

        public ProductBankAccountsResponse GetBankAccountsByProductId(string userid, int productid)
        {
            ProductBankAccountsResponse productBankAccount = null;
            try
            {
                UserProductsResponse userProduct = GetProductsByUserId(userid);
                if (userProduct != null)
                {
                    productBankAccount = userProduct.Products.Where(x => x.Product.Id == productid).First();
                }
            }
            catch { }

            return productBankAccount;
        }
    }
}