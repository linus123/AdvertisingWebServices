using System.Web.Mvc;
using MvcServices.Helpers;

namespace MvcServices.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerWebServiceRepositoryAdapter _customerWebServiceRepositoryAdapter;

        public CustomerController()
        {
            _customerWebServiceRepositoryAdapter = new CustomerWebServiceRepositoryAdapter();
        }

        public JsonResult GetAll()
        {
            var allCustomers = _customerWebServiceRepositoryAdapter.GetAllCustomers();

            return Json(allCustomers, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDetail(
            int customerId)
        {
            var allCustomers = _customerWebServiceRepositoryAdapter.GetCustomerDetail(customerId);

            return Json(allCustomers, JsonRequestBehavior.AllowGet);
        }
    }
}