using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Categorizer;
using NUnit.Framework;

namespace testCategorizer
{
    [TestFixture]
    public class A_new_cat
    {
        readonly string _validCatName = "N.N.";

        [Test] public void Gets_an_id()
        {
            var cat = new Cat(_validCatName);
            Assert.That(cat.Id, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public void Must_be_given_a_name()
        {
            Assert.That(() => new Cat(null), Throws.ArgumentException);
            Assert.That(() => new Cat(string.Empty), Throws.ArgumentException);
            Assert.That(() => new Cat(" "), Throws.ArgumentException);
        }

        [Test]
        public void Has_no_song()
        {
            Assert.That(new Cat(_validCatName).Song, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Is_untrained()
        {
            Assert.That(new Cat(_validCatName).IsTrained, Is.False);
        }

        [Test]
        public void Can_be_trained()
        {
            var cat = new Cat(_validCatName);
            cat.Train();
            Assert.That(cat.IsTrained);
        }
    }

    [TestFixture]
    public class A_trained_cat
    {
        readonly string _validCatName = "N.N.";
        private Cat trainedCat;

        [SetUp]
        public void Setup()
        {
            trainedCat = new Cat(_validCatName);
            trainedCat.Train();
        }

        [Test]
        public void Rejects_further_training()
        {
            Assert.That(() => trainedCat.Train(), Throws.InvalidOperationException);
        }

        [Test]
        public void Can_sing()
        {
            Assert.That(string.IsNullOrWhiteSpace(trainedCat.Song), Is.False);
        }
    }

    [TestFixture]
    public class A_trained_cat_named_nyan
    {
        [Test]
        public void Sings_the_Nyan_cat_song()
        {
            var nyanCat = new Cat("Nyan");
            nyanCat.Train();
            var nyancatSong = "Nyan, nyan, nyan!";
            Assert.That(nyanCat.Song, Is.EqualTo(nyancatSong));
        }
    }
}
