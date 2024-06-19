using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace NUnitTesting.StringPlay
{
    [TestFixture]
    internal class StringDataTest
    {
        [Test]
        public void IsUpperCase()
        {
            Assert.Multiple(() =>
            {
                Assert.That(StringData.IsUpperCase("TEST"), Is.True);
                Assert.That(StringData.IsUpperCase("Test"), Is.False);
                Assert.That(StringData.IsUpperCase("234234"), Is.False);
                Assert.That(StringData.IsUpperCase(""), Is.False);
            });
        }

        [Test]
        public void IsPasswordComplex()
        {
            Assert.Multiple(() =>
            {
                Assert.That(StringData.IsPasswordComplex("Thisprojectistest$23"), Is.True);
                Assert.That(StringData.IsPasswordComplex("Test$12"), Is.False);
                Assert.That(StringData.IsPasswordComplex("234234"), Is.False);
                Assert.That(StringData.IsPasswordComplex(""), Is.False);
                Assert.That(StringData.IsPasswordComplex("Test"), Is.False);
            });
        }

        [Test]
        public void Reverse()
        {
            Assert.Multiple(() =>
            {
                Assert.That(StringData.Reverse("gfdsa"), Is.EqualTo("asdfg"));
                Assert.That(StringData.Reverse("mom"), Is.EqualTo("mom"));
                Assert.That(StringData.Reverse("racecar"), Is.EqualTo("racecar"));
                Assert.That(StringData.Reverse("asdasd"), Is.Not.EqualTo("sdfsdf"));
                Assert.That(StringData.Reverse("123123"), Is.Not.EqualTo("435345"));
            });
        }

        [Test]
        public void ReverseSentence()
        {
            Assert.Multiple(() =>
            {
                Assert.That(StringData.ReverseSentence("was it a cat I saw"), Is.EqualTo("saw ti a tac I was"));
                Assert.That(StringData.ReverseSentence(""), Is.EqualTo(""));
                Assert.That(StringData.ReverseSentence("taco cat"), Is.EqualTo("ocat tac"));
                Assert.That(StringData.ReverseSentence("asdasd"), Is.Not.EqualTo("sdfsdf"));
                Assert.That(StringData.ReverseSentence("123123"), Is.Not.EqualTo("435345"));
            });
        }
    }
}
