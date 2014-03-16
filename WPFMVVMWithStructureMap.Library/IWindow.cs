namespace WPFMVVMWithStructureMap.Library
{
    public interface IWindow
    {
        object DataContext { get; set; }

        bool? DialogResult { get; set; }
        bool? ShowDialog();

        void Close();
    }
}