using System;

namespace EFCoreExampleApp.Domain.ValueObjects
{
    public class CompleteName
    {
        public CompleteName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private CompleteName()
        {
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is CompleteName name &&
                   FirstName == name.FirstName &&
                   LastName == name.LastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}