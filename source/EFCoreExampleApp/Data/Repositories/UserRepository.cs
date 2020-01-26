using System.Linq;
using EFCoreExampleApp.Data.Context;
using EFCoreExampleApp.Domain;
using EFCoreExampleApp.Domain.Repositories;
using EFCoreExampleApp.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExampleApp.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbSet<User> _users;

        public UserRepository(SampleContext context)
        {
            _users = context.Users;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User GetUser(int userId)
        {
            return _users.Include(u => u.Emails).FirstOrDefault(u => u.Id == userId);
        }

        public bool IsAnyUserCpf(Cpf cpf)
        {
            return _users.Any(u => u.Cpf.Number == cpf.Number);
        }
    }
}