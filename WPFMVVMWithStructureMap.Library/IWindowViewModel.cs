namespace WPFMVVMWithStructureMap.Library
{
    public interface IWindowViewModel
    {
        IWindow Window { get; set; }
        IView View { get; set; }

        string Title { get; }

        void Load();

        void InitialiseCommands();
    }
}