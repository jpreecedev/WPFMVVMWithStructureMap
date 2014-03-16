using System;
using WPFMVVMWithStructureMap.Core;
using WPFMVVMWithStructureMap.Models;

namespace WPFMVVMWithStructureMap.Repositories
{
    public class CustomersRepository : IRepository<Customer>
    {
        private readonly Random _random = new Random();

        public int Count
        {
            get { return _random.Next(3, 10); }
        }
    }
}