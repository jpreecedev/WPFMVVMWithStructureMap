using System.Windows;

namespace WPFMVVMWithStructureMap.Windows.MainWindow
{
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosed(System.EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}