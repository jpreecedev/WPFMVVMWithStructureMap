using WPFMVVMWithStructureMap.DataModel.Core;
using WPFMVVMWithStructureMap.DataModel.Models;
using WPFMVVMWithStructureMap.Library;

namespace WPFMVVMWithStructureMap.Repositories
{
    public class CustomersRepository : BaseRepository, IRepository<Customer>
    {
        #region Implementation of IRepository<Customer>

        public void Add(Customer entity)
        {
            //Save logic
        }

        #endregion
    }
}