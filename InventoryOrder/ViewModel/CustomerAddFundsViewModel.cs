using System.ComponentModel.DataAnnotations;

namespace InventoryOrder.ViewModel
{
    public class CustomerAddFundsViewModel
    {

        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Display(Name = "CustomerID")]
        public int CustomerID { get; set; }

        [Display(Name = "CustomerName")]
        public string? CustomerName { get; set; }

        [Display(Name = "TotalAmount")]
        public decimal? TotalAmount { get; set; }

        [Display(Name = "TotalPay")]
        public decimal? TotalPay { get; set; }

        [Display(Name = "TotalRefund")]

        public decimal? TotalRefund { get; set; }

        [Display(Name = "AmountToAdd"), Required(ErrorMessage = "Required")]
        public decimal AmountToAdd { get; set; }
    }

}
