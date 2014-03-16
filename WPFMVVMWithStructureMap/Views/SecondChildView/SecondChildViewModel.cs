using StructureMap;
using System.Windows;
using WPFMVVMWithStructureMap.Core;
using WPFMVVMWithStructureMap.Library.Core;

namespace WPFMVVMWithStructureMap
{
    public class SecondChildViewModel : BaseViewModel, ISecondChildViewModel
    {
        public SecondChildViewModel(ISecondChildView view, IContainer container)
            : base(view, container)
        {
        }

        public override void Save()
        {
            MessageBox.Show("Saved");
        }
    }
}