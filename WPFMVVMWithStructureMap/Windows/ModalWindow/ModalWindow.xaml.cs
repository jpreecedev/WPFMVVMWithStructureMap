using System.Windows;

namespace WPFMVVMWithStructureMap.Windows.ModalWindow
{
    public partial class ModalWindow : Window, IModalWindow
    {
        public ModalWindow()
        {
            InitializeComponent();
        }
    }
}