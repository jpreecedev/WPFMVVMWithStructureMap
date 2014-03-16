using StructureMap;
using WPFMVVMWithStructureMap.Library;
using WPFMVVMWithStructureMap.Windows.ModalWindow;

namespace WPFMVVMWithStructureMap.Core
{
    public class BaseWindowViewModel : Library.Core.BaseWindowViewModel
    {
        public BaseWindowViewModel(IWindow window, IContainer container)
            : base(window, container)
        {
        }

        protected override bool? ShowModalView<T>()
        {
            IModalWindowViewModel modalWindow = Container.GetInstance<IModalWindowViewModel>();
            IViewModel viewModel = Container.GetInstance<T>();

            modalWindow.View = viewModel.View;
            modalWindow.InitialiseCommands();

            viewModel.Load();

            return modalWindow.Window.ShowDialog();
        }
    }
}