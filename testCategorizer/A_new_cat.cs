﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace testCategorizer
{
    [TestFixture]
    public class A_new_cat
    {
        [Test] public void Gets_an_id() { }
        [Test] public void Must_be_given_a_name() { }
        [Test] public void Has_no_song() { }
        [Test] public void Can_be_trained() { }
    }

    [TestFixture]
    public class A_trained_cat
    {
        [Test] public void Rejects_further_training() { }
        [Test] public void Can_sing() { }
    }

    [TestFixture]
    public class A_cat_named_nyan
    {
        [Test] public void Sings_the_Nyan_cat_song() { }
    }
}
