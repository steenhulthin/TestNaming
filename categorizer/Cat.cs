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
            IsTrained = false;
        }

        public Guid Id { get; private set; }
        public string Song { get; private set; }
        public bool IsTrained { get; private set; }

        public void Train()
        {
            if (IsTrained) { throw new InvalidOperationException("A cat can only be trained once.");}
            IsTrained = true;
        }
    }
}