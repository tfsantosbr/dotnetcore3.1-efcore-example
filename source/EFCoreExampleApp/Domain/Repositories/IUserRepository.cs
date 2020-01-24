using EFCoreExampleApp.Domain.ValueObjects;

namespace EFCoreExampleApp.Domain.Repositories
{
    public interface IUserRepository
    {
         void AddUser(User user);
         User GetUser(int userId);

         bool IsAnyUserCpf(Cpf cpf);
    }
}