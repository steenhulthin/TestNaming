using System;

namespace Categorizer
{
    public class Cat
    {
        public Cat(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name");
            Id = Guid.NewGuid();
            Song = string.Empty;
        }

        public Guid Id { get; private set; }
        public string Song { get; private set; }
    }
}