using System;

namespace testCategorizer
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