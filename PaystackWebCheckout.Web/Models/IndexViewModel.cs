using System;

namespace PaystackWebCheckout.Web.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            DateTime date= DateTime.Now;
            Reference = $"{date.ToString("yyMMddhhmmss")}{date.Millisecond}";
            PublicKey = "pk_live_23e35566bf8353a4d5f438ef8a51d100009ddb00";
        }
        public Customer Person { get; set; }
        public string PublicKey {  get; set; }
        public string Reference { get;set; }
    }
}
