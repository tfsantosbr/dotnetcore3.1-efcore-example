using EFCoreExampleApp.Domain;
using EFCoreExampleApp.Domain.Repositories;
using EFCoreExampleApp.Domain.ValueObjects;

namespace EFCoreExampleApp.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public bool IsAnyUserCpf(Cpf cpf)
        {
            throw new System.NotImplementedException();
        }
    }
}