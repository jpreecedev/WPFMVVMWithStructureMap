using System.Windows.Controls;

namespace WPFMVVMWithStructureMap.Views.CustomerView
{
    public partial class CustomerView : UserControl, ICustomerView
    {
        public CustomerView()
        {
            InitializeComponent();
        }
    }
}