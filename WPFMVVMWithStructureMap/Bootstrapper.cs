using StructureMap;
using StructureMap.Configuration.DSL;
using WPFMVVMWithStructureMap.DataModel.Models;
using WPFMVVMWithStructureMap.Library;
using WPFMVVMWithStructureMap.Repositories;
using WPFMVVMWithStructureMap.Views.CustomerView;
using WPFMVVMWithStructureMap.Windows.MainWindow;
using WPFMVVMWithStructureMap.Windows.ModalWindow;

namespace WPFMVVMWithStructureMap
{
    public static class Bootstrapper
    {
        #region Public Methods

        public static void Initialize()
        {
            ObjectFactory.Initialize(OnInitialize);
        }

        #endregion

        #region Private Methods

        private static void OnInitialize(IInitializationExpression x)
        {
            AddSingleton<IMainWindow, MainWindow>(x);
            AddSingleton<IMainWindowViewModel, MainWindowViewModel>(x);

            Add<IModalWindow, ModalWindow>(x);
            Add<IModalWindowViewModel, ModalWindowViewModel>(x);

            Add<IChildView, ChildView>(x);
            Add<IChildViewModel, ChildViewModel>(x);

            Add<ISecondChildView, SecondChildView>(x);
            Add<ISecondChildViewModel, SecondChildViewModel>(x);

            Add<ICustomerView, CustomerView>(x);
            Add<ICustomerViewModel, CustomerViewModel>(x);

            AddSingleton<IRepository<Customer>, CustomersRepository>(x);
            Inject<IRepository<Customer>>(x);
        }

        private static void Add<T, T2>(IRegistry x) where T2 : T
        {
            x.For<T>().Use<T2>();
        }

        private static void AddSingleton<T, T2>(IRegistry x) where T2 : T
        {
            x.For<T>().Singleton().Use<T2>();
        }

        private static void Inject<T>(IRegistry x)
        {
            x.SetAllProperties(y => y.OfType<T>());
        }

        #endregion
    }
}