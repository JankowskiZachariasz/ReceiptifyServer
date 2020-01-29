using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReceiptifyServer.Entities;
using ReceiptifyServer.Helpers;

namespace ReceiptifyServer.Services
{
    public interface ICompaniesService
    {
        Companies getById(int id);
        IEnumerable<Companies> GetAll();

    }
    public class CompaniesService : ICompaniesService
    {
        private DataContext _context;

        public CompaniesService(DataContext context)
        {
            _context = context;
        }

        public Companies getById(int id)
        {
            return _context.Companies.First(a => a.id == Convert.ToString(id));
        }
        public IEnumerable<Companies> GetAll() {

            return _context.Companies.ToArray();
        }
    }
}



