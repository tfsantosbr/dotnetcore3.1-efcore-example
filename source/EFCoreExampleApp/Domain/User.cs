using System.Collections.Generic;
using EFCoreExampleApp.Domain.ValueObjects;

namespace EFCoreExampleApp.Domain
{
    public class User
    {
        private readonly List<UserEmail> _emails = new List<UserEmail>();

        public User(CompleteName completeName, Email email, Cpf cpf)
        {
            CompleteName = completeName;
            Email = email;
            Cpf = cpf;
        }

        private User()
        {
        }

        public int Id { get; private set; }
        public CompleteName CompleteName { get; private set; }
        public Email Email { get; private set; }
        public Cpf Cpf { get; private set; }
        public IReadOnlyCollection<UserEmail> Emails => _emails.AsReadOnly();

        public void AddEmail(UserEmail userEmail)
        {
            _emails.Add(userEmail);
        }
    }
}