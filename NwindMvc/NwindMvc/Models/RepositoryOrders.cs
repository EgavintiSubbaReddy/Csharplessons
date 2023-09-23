using System.Linq;
using static NuGet.Packaging.PackagingConstants;
namespace NwindMvc.Models
{
    public class RepositoryOrders
    {
        private readonly NorthWindContext _context;
        public RepositoryOrders(NorthWindContext context)
        {
            _context = context;

        }

        public List<Order> AllOrders()
        {
            return _context.Orders.ToList();
        }
        public List<int> GetAllOrdersId()
        {

            return _context.Orders.Select(order => order.OrderId).ToList();
        }

        public Order FindOrdersById(int id)
        {

            return _context.Orders.FirstOrDefault(order => order.OrderId == id);
        }

        public List<Order> FindOrderByCustomerID(string customerID)
        {

            return _context.Orders.Where(order => order.CustomerId == customerID).ToList();
        }
        public List<OrderDetail> FindOrderByOrderId(int id)
        {

            return _context.OrderDetails.Where(detail => detail.OrderId == id).ToList();
        }

        public Product GetProductById(int productId)
        {


            return _context.Products.FirstOrDefault(product => product.ProductId == productId);
        }


    }
}
