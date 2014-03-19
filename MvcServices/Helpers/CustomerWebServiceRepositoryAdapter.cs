using System.Linq;

namespace MvcServices.Helpers
{
    public class CustomerWebServiceRepositoryAdapter
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerWebServiceRepositoryAdapter()
        {
            _customerRepository = new CustomerRepository();
        }

        public CustomerMin[] GetAllCustomers()
        {
            var allCustomers = _customerRepository.GetAllCustomers();

            return allCustomers
                .Select(CreateCustomerMin)
                .ToArray();
        }

        public Customer GetCustomerDetail(
            int customerId)
        {
            return _customerRepository.GetAllCustomers()
                .FirstOrDefault(c => c.CustomerId == customerId);
        }

        private CustomerMin CreateCustomerMin(Customer c)
        {
            return new CustomerMin()
                   {
                       CustomerId = c.CustomerId,
                       Name = string.Format("{0}, {1}", c.LastName, c.FirstName)
                   };
        }
    }
}