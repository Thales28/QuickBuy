using QuickBuy.Dominio.Entities;

namespace QuickBuy.Dominio.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetUser(string email, string password);
    }
}
