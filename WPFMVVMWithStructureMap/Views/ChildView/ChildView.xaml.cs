using System.Windows.Controls;

namespace WPFMVVMWithStructureMap
{
    public partial class ChildView : UserControl, IChildView
    {
        public ChildView()
        {
            InitializeComponent();
        }
    }
}