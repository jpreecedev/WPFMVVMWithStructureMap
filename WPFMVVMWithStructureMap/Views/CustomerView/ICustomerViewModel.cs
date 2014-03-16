using WPFMVVMWithStructureMap.DataModel.Models;
using WPFMVVMWithStructureMap.Library;
using WPFMVVMWithStructureMap.Library.Attributes;

namespace WPFMVVMWithStructureMap.Views.CustomerView
{
    [Title("Customers")]
    public interface ICustomerViewModel : IViewModel
    {
        IRepository<Customer> CustomersRepository { get; set; }

        Customer Customer { get; set; }
    }
}