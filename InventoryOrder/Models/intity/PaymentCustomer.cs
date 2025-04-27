using InventoryOrder.Models.intity;
using System.ComponentModel.DataAnnotations;

namespace InventoryOrder.Models.entity
{
    public class PaymentCustomer
    {
        [Display(Name = "PaymentDate")]
        public int PaymentCustomerID { get; set; }
        [Display(Name = "PaymentDate")]
        public DateTime PaymentDate { get; set; }
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Display(Name = "CustomerID")]
        public int CustomerID { get; set; }

        [Display(Name = "Order")]
        public Order? Order { get; set; }

        [Display(Name = "Customer")]
        public Customer? Customer { get; set; }
    }
}
