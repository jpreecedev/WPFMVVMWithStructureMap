using System.Windows;
using StructureMap;
using WPFMVVMWithStructureMap.Core;
using WPFMVVMWithStructureMap.Library;
using WPFMVVMWithStructureMap.Views.CustomerView;

namespace WPFMVVMWithStructureMap.Windows.MainWindow
{
    public class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        #region Constructor

        public MainWindowViewModel(IMainWindow view, IContainer container)
            : base(view, container)
        {
            ShowFirstChildCommand = new DelegateCommand<object>(OnShowFirstChild);
            ShowSecondChildCommand = new DelegateCommand<object>(OnShowSecondChild);
            ShowModalWindowCommand = new DelegateCommand<object>(OnShowModalWindow);
            ExitCommand = new DelegateCommand<object>(OnExit);
        }

        #endregion

        #region Public Properties

        public DelegateCommand<object> ShowFirstChildCommand { get; set; }

        public DelegateCommand<object> ShowSecondChildCommand { get; set; }

        public DelegateCommand<object> ShowModalWindowCommand { get; set; }

        public DelegateCommand<object> ExitCommand { get; set; }

        #endregion

        #region Private Methods

        private static void OnExit(object obj)
        {
            Application.Current.Shutdown();
        }

        private void OnShowSecondChild(object obj)
        {
            ShowView<ISecondChildViewModel>();
        }

        private void OnShowFirstChild(object obj)
        {
            ShowView<IChildViewModel>();
        }

        private void OnShowModalWindow(object obj)
        {
            ShowModalView<ICustomerViewModel>();
        }

        #endregion
    }
}