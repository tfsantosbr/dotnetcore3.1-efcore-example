using System;
using System.Collections.Generic;
using EFCoreExampleApp.Domain.ValueObjects;

namespace EFCoreExampleApp.Domain
{
    public class UserEmail
    {
        public UserEmail(int id, int userId, Email email)
        {
            Id = id;
            UserId = userId;
            Email = email;
        }

        private UserEmail()
        {
        }

        public int Id { get; private set; }
        public int UserId { get; private set; }
        public Email Email { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is UserEmail email &&
                   Id == email.Id &&
                   UserId == email.UserId &&
                   EqualityComparer<Email>.Default.Equals(Email, email.Email);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UserId, Email);
        }
    }
}