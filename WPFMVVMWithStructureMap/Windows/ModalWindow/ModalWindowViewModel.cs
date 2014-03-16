using StructureMap;
using WPFMVVMWithStructureMap.Core;

namespace WPFMVVMWithStructureMap.Windows.ModalWindow
{
    public class ModalWindowViewModel : BaseWindowViewModel, IModalWindowViewModel
    {
        public ModalWindowViewModel(IModalWindow window, IContainer container)
            : base(window, container)
        {
        }
    }
}