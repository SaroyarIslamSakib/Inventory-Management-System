using IMS.Domain.Repositories;
namespace IMS.Domain
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
    }
}