using StructureMap;

namespace WPFMVVMWithStructureMap.Library.Core
{
    public class BaseViewModel : BaseNotification, IViewModel
    {
        #region Constructor

        public BaseViewModel(IView view, IContainer container)
        {
            View = view;
            View.DataContext = this;

            Container = container;
        }

        #endregion

        #region Public Properties

        public IContainer Container { get; set; }

        public IView View { get; set; }

        #endregion

        #region Public Methods

        public virtual void Load()
        {

        }

        public virtual void Save()
        {
            
        }

        #endregion
    }
}