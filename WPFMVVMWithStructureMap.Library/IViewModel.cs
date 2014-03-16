namespace WPFMVVMWithStructureMap.Library
{
    public interface IViewModel
    {
        IView View { get; set; }

        void Load();
        void Save();
    }
}