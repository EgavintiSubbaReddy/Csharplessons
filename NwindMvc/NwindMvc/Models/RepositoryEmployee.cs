using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace NwindMvc.Models
{
    public class RepositoryEmployee
    {
        private NorthWindContext _context;
        public RepositoryEmployee(NorthWindContext context)
        {
            _context = context;
        }
        public List<Employee> AllEmployees()
        {
            return _context.Employees.ToList();
        }


    }
}
