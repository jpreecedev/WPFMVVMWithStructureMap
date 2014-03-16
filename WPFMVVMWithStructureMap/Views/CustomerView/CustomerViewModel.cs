using StructureMap;
using WPFMVVMWithStructureMap.DataModel.Models;
using WPFMVVMWithStructureMap.Library;
using WPFMVVMWithStructureMap.Library.Core;

namespace WPFMVVMWithStructureMap.Views.CustomerView
{
    public class CustomerViewModel : BaseViewModel, ICustomerViewModel
    {
        #region Constructor

        public CustomerViewModel(ICustomerView view, IContainer container)
            : base(view, container)
        {
        }

        #endregion

        #region ICustomerViewModel Members

        public IRepository<Customer> CustomersRepository { get; set; }

        public Customer Customer { get; set; }

        public override void Load()
        {
            Customer = new Customer();
        }

        public override void Save()
        {
            CustomersRepository.Add(Customer);
        }

        #endregion
    }
}