using System;

namespace Labsheet10
{
    public class Money : IStatus<decimal>
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
            current += Math.Abs(value);
        }

        public void Remove(decimal value)
        {
            var temp = (current - Math.Abs(value));
            current = temp < 0 ? 0 : temp;
        }
    }
}
