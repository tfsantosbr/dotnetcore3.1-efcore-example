using System;

namespace EFCoreExampleApp.Domain.ValueObjects
{
    public class Cpf
    {
        public Cpf(string number)
        {
            Number = number;
        }

        private Cpf()
        {
        }

        public string Number { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is Cpf cpf &&
                   Number == cpf.Number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number);
        }
    }
}