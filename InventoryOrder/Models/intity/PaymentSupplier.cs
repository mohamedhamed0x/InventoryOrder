using System.ComponentModel.DataAnnotations;

namespace InventoryOrder.Models.intity
{
    public class PaymentSupplier
    {

        [Display(Name = "PaymentSupplierID")]
        public int PaymentSupplierID { get; set; }

        [Display(Name = "Paymentdate")]
        public DateTime Paymentdate { get; set; }

        [Display(Name = "Amount")]
        public decimal Amount { get; set; }


        [Display(Name = "PurchaseID")]
        public int PurchaseID { get; set; }

        [Display(Name = "SupplierID")]
        public int SupplierID { get; set; }

        [Display(Name = "Purchase")]
        public Purchase? Purchase { get; set; }

        [Display(Name = "Supplier")]
        public Supplier? Supplier { get; set; }

    }

}
