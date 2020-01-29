using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReceiptifyServer.Entities;
using ReceiptifyServer.Helpers;

namespace ReceiptifyServer.Services
{
    public interface ITestService {
        Example getById(int id);
        
    }
    public class TestService : ITestService
    {
        private DataContext _context;

        public TestService(DataContext context)
        {
            _context = context;
        }

        public Example getById(int id)
        {
            return _context.Example.First(a => a.id==Convert.ToString(id));
        }

    }
}
