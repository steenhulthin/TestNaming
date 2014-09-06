using System;

namespace Categorizer
{
    public class Cat
    {
        private readonly string _name;

        public Cat(string name)
        {
            _name = name;
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
            if (_name.ToLowerInvariant() == "nyan")
            {
                Song = "Nyan, nyan, nyan!";
            }
            else
            {
                Song = "Meow";
            }
        }
    }
}