using System.Windows;
using StructureMap;
using WPFMVVMWithStructureMap.Windows.MainWindow;

namespace WPFMVVMWithStructureMap
{
    public partial class App
    {
        public App()
        {
            Bootstrapper.Initialize();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            IMainWindowViewModel window = ObjectFactory.GetInstance<IMainWindowViewModel>();
            window.Load();
            window.InitialiseCommands();

            MainWindow = (MainWindow) window.Window;
            MainWindow.ShowDialog();
        }
    }
}