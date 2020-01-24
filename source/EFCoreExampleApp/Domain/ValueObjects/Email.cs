using System;

namespace EFCoreExampleApp.Domain.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;
        }

        private Email()
        {
        }

        public string Address { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is Email email &&
                   Address == email.Address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Address);
        }
    }
}