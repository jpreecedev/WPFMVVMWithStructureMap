using StructureMap;
using System;
using System.Linq;
using System.Reflection;
using WPFMVVMWithStructureMap.Library.Attributes;

namespace WPFMVVMWithStructureMap.Library.Core
{
    public class BaseWindowViewModel : BaseNotification, IWindowViewModel
    {
        private string _title;

        #region Constructor

        public BaseWindowViewModel(IWindow window, IContainer container)
        {
            Window = window;
            Window.DataContext = this;

            Container = container;
        }

        #endregion

        #region Public Properties

        public IContainer Container { get; set; }

        public IView View { get; set; }

        public IWindow Window { get; set; }

        public string Title
        {
            get { return _title ?? (_title = GetTitle()); }
        }

        #endregion

        #region Public Methods

        public virtual void Load()
        {
        }

        public virtual void InitialiseCommands()
        {
            SaveCommand = new DelegateCommand<object>(OnSave);
            CancelCommand = new DelegateCommand<object>(OnCancel);
        }

        #endregion

        #region Protected Methods

        protected void ShowView<T>() where T : IViewModel
        {
            IViewModel viewModel = Container.GetInstance<T>();
            View = viewModel.View;
            viewModel.Load();
        }

        protected virtual bool? ShowModalView<T>() where T : IViewModel
        {
            return false;
        }

        #endregion

        #region Commands

        #region Command : Save

        public DelegateCommand<object> SaveCommand { get; set; }

        private void OnSave(object arg)
        {
            IViewModel viewModel = (IViewModel) View.DataContext;
            viewModel.Save();
            SaveRepositories(viewModel);

            Window.DialogResult = true;
            Close();
        }

        #endregion

        #region Command : Cancel

        public DelegateCommand<object> CancelCommand { get; set; }

        private void OnCancel(object arg)
        {
            Window.DialogResult = false;
            Close();
        }

        #endregion

        #endregion

        #region Private Methods

        private static void SaveRepositories(IViewModel viewModel)
        {
            PropertyInfo[] properties = viewModel.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties.Where(prop => prop.PropertyType.GetInterfaces().Any(i => i == (typeof (IRepository)))))
            {
                IRepository repository = viewModel.GetType().GetProperty(property.Name).GetValue(viewModel) as IRepository;
                if (repository != null)
                {
                    repository.Save();
                }
            }
        }

        private string GetTitle()
        {
            if (View == null || View.DataContext == null)
                return null;

            Type type = View.DataContext.GetType().GetInterfaces().FirstOrDefault(t => t.GetCustomAttributes(typeof (TitleAttribute), false).Any());
            if (type != null)
            {
                TitleAttribute attribute = type.GetCustomAttributes(typeof (TitleAttribute), false).FirstOrDefault() as TitleAttribute;
                if (attribute != null)
                {
                    return attribute.Title;
                }
            }

            return null;
        }

        private void Close()
        {
            Window.Close();
        }

        #endregion
    }
}