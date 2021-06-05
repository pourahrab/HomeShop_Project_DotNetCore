using System;

namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public class CustomerDiscountViewModel
    {
        public long Id { get; set; } 
        public long ProductId { get; set; }
        public string Product { get; set; } 
        public int DiscountRate { get; set; }
        public string StartDateFa { get; set; }
        public string EndDateFa { get; set; }
        public DateTime StartDateEn { get; set; }
        public DateTime EndDateEn { get; set; }
        public string Reason { get; set; }
        public string CreationDate { get; set; } 
    }
}