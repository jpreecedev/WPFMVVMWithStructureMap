using StructureMap;
using WPFMVVMWithStructureMap.Library.Core;

namespace WPFMVVMWithStructureMap
{
    public class ChildViewModel : BaseViewModel, IChildViewModel
    {
        #region Constructor

        public ChildViewModel(IChildView view, IContainer container)
            : base(view, container)
        {
        }

        #endregion
    }
}