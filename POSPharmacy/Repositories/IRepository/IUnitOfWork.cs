namespace OnlineBookOrderManagementSystem.Repositories.IRepository
{
    public interface IUnitOfWork
    {
        IProductReposiory Product { get; }
        //void Save();
        Task Save();
    }
}
