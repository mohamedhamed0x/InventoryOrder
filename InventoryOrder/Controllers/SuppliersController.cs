using InventoryOrder.Models.intity;
using InventoryOrder.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InventoryOrder.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly IRepository<Supplier> _supplierRepository;
        private readonly IRepository<PaymentSupplier> _paymentRepository;

        private readonly IRepository<Purchase> _purchaseRepository;

        public SuppliersController(IRepository<Supplier> SupplierRepository, IRepository<Purchase> PurchaseRepository,
            IRepository<PaymentSupplier> PaymentRepository)
        {
            _supplierRepository = SupplierRepository;
            _purchaseRepository = PurchaseRepository;
            _paymentRepository = PaymentRepository;
        }

        // GET: SuppliersController
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Supplirs";
            var supplist = _supplierRepository.GetAll();

            if (supplist == null)
                return NotFound();


            return View(supplist);
        }

        // GET: SuppliersController/Details/5
        public IActionResult Details(int id)
        {
            ViewData["ActivePage"] = "Supplirs";

            var supplier = _supplierRepository.GetById(id);
            if (supplier == null)
            {
                return NotFound();
            }


            supplier.Purchases = _purchaseRepository.GetAll().Where(x => x.SupplierID == id).ToList();


            supplier.PaymentSuppliers = _paymentRepository.GetAll().Where(x => x.SupplierID == id).ToList();

            return View(supplier);
        }

        // GET: SuppliersController/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ActivePage"] = "Supplirs";

            return View("Create");
        }

        // POST: SuppliersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Supplier Supplier)
        {
            ViewData["ActivePage"] = "Supplirs";

            try
            {
                _supplierRepository.Add(Supplier);
                _supplierRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Create", Supplier);
            }
        }

        // GET: SuppliersController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["ActivePage"] = "Supplirs";

            var Cus = _supplierRepository.GetById(id);
            if (Cus == null)
                return NotFound();
            return View("Edit", Cus);
        }

        // POST: SuppliersController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Supplier Supplier)
        {
            ViewData["ActivePage"] = "Supplirs";

            if (id != Supplier.SupplierID)
            {
                return BadRequest();
            }

            try
            {
                // استدعاء الفانكشن Update لتحديث بيانات العميل
                _supplierRepository.Update(Supplier);
                _supplierRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(Supplier);
            }
        }
        // GET: SuppliersController/Delete/5
        public IActionResult Delete(int id)
        {
            ViewData["ActivePage"] = "Supplirs";

            var Cus = _supplierRepository.GetById(id);
            if (Cus == null)
                return NotFound();
            return View("Delete", Cus);
        }

        // POST: SuppliersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Supplier Supplier)
        {
            ViewData["ActivePage"] = "Supplirs";

            try
            {

                if (Supplier == null)
                    return NotFound();

                _supplierRepository.Delete(id);
                _supplierRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View("Delete", Supplier);
            }
        }



    }
}
