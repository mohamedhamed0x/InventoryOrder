using System.ComponentModel.DataAnnotations;

namespace InventoryOrder.ViewModel
{
    public class SupplierAddFundsViewModel
    {

        [Display(Name = "PurchaseID")]
        public int PurchaseID { get; set; }

        [Display(Name = "SupplierID")]
        public int SupplierID { get; set; }

        [Display(Name = "SupplierName")]
        public string SupplierName { get; set; }

        [Display(Name = "TotalAmount")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "TotalPay")]
        public decimal TotalPay { get; set; }

        [Display(Name = "TotalRefund")]

        public decimal TotalRefund { get; set; }

        [Display(Name = "AmountToAdd"), Required(ErrorMessage = "Required")]
        public decimal AmountToAdd { get; set; }
    }

}
