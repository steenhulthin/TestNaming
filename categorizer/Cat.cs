using System;

namespace Categorizer
{
    public class Cat
    {
        public Cat(string name)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}