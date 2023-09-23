using Microsoft.EntityFrameworkCore;
using NwindMvc.Models;

namespace NwindMVC.Models
{
    public class RepositoryCustomer
    {
        private readonly NorthWindContext _context;
        public RepositoryCustomer(NorthWindContext context)
        {
            _context = context;
        }
        public List<string> GetAllCustomerIDs()
        {
            return _context.Customers.Select(c => c.CustomerId).ToList();
        }
        public Customer FindCustomerByID(string customerId)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }
        public List<Order> GetCustomerOrders(string customerId)
        {
            return _context.Orders.Where(o => o.CustomerId == customerId).ToList();
        }
        public List<Customer> FindCustomerDetailByCustomerId(string id)
        {
            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer customer = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);

            return customer.Customers.ToList();
        }
    }
}
