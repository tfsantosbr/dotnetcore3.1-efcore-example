using System;
using System.Text.Json;
using EFCoreExampleApp.Data.Context;
using EFCoreExampleApp.Data.Repositories;
using EFCoreExampleApp.Domain;
using EFCoreExampleApp.Domain.Repositories;
using EFCoreExampleApp.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddUser();
            GetUser(2);
        }

        private static void GetUser(int userId)
        {
            using (var context = new SampleContext())
            {
                IUserRepository repository = new UserRepository(context);

                var user = repository.GetUser(userId);

                if (user == null)
                {
                    Console.WriteLine("ERRO: Usuário não encontrado");
                }

                var userSerialized = JsonSerializer.Serialize(user);

                Console.WriteLine(userSerialized);
            }
        }

        private static void AddUser()
        {
            using (var context = new SampleContext())
            {
                IUserRepository repository = new UserRepository(context);

                var user = new User(new CompleteName("Tiago", "Santos"), new Cpf("11111111111"));
                user.AddEmail(new UserEmail(new Email("tiagosantos@email.com")));
                user.AddEmail(new UserEmail(new Email("santostiago@email.com")));

                if (repository.IsAnyUserCpf(user.Cpf))
                {
                    Console.WriteLine("ERRO: Cpf já está sendo usado");
                    return;
                }

                repository.AddUser(user);

                context.SaveChanges();

                Console.WriteLine("Usuário cadastrado com sucesso.");
            }
        }
    }
}
