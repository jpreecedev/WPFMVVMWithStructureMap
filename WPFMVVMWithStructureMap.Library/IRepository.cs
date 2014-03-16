namespace WPFMVVMWithStructureMap.Library
{
    public interface IRepository
    {
        void Save();
    }

    public interface IRepository<T> : IRepository
    {
        void Add(T entity);
    }
}