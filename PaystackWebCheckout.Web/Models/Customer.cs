namespace PaystackWebCheckout.Web.Models
{
    public class Customer
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal? Amount { get; set; }
    }
}
