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