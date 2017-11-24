using System;

namespace Labsheet10
{
    class Money : IStatus<decimal>
    {
        decimal current;

        public decimal Current => current;


        public Money(decimal value)
        {
            current = value;
        }

        public void FullRestore()
        {

        }

        public void Clear()
        {
            current = 0;
        }

        public void Restore(decimal value)
        {
            current += value;
        }

        public void Remove(decimal value)
        {
            current = (current - value) < 0 ? 0 : current - value;
        }
    }
}
