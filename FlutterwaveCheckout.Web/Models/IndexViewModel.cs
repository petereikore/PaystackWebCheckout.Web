namespace FlutterwaveCheckout.Web.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            DateTime date = DateTime.Now;
        }
        public Customer Customer { get; set; }
        public decimal? Amount { get; set; }
    }
}
