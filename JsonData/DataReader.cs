

namespace CornerStoneNUnit.JsonData
{
    public class Data
    {
        public string ?WebsiteUrl { get; set; }
        public  Credentials? LoginUser { get; set; }
        public Credentials ?CartUser { get; set; }

        public List<Credentials> ?InvalidUsers { get; set; }
        public string ?ProductPage {  get; set; }
        public string ?SortOptions { get; set; }
        public  List<PaymentDetails>? PaymentDetails { get; set; }
        public string ?OrderConfirmed {  get; set; }

    }
    public class Credentials
    { 
        public string ?Email {  get; set; }
        public string ?Password { get; set; }
    }
    public class PaymentDetails
    {
        public string ?CardNumber { get; set; }
        public string ?ExpiryDate { get; set; }
        public string ?Name { get; set; }

    }

}
