using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace NUnitTesting.ArrayPlay
{
    [TestFixture]
    internal class HarrayTest
    {
        [Test]
        public void LinearSearch()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Harray.LinearSearch([1, 2, 4, 6, 7], 4), Is.True);
                Assert.That(Harray.LinearSearch([1, -2, 4, 6, 7], -2), Is.True);
                Assert.That(Harray.LinearSearch([1, 2, 4, 6, 7], 0), Is.False);
                Assert.That(Harray.LinearSearch([1, 2, 4, 6, 7], -4), Is.False);
            });
        }

        [Test]
        public void LinearSearch2()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Harray.LinearSearch2([1, 2, 4, 6, 7], 4), Is.True);
                Assert.That(Harray.LinearSearch2([1, -2, 4, 6, 7], -2), Is.True);
                Assert.That(Harray.LinearSearch2([1, 2, 4, 6, 7], 8), Is.False);
                Assert.That(Harray.LinearSearch2([1, 2, 4, 6, 7], -4), Is.False);
            });
        }

        [Test]
        public void BinarySearch()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Harray.BinarySearch([1, 2, 4, 6, 7], 7), Is.True);
                Assert.That(Harray.BinarySearch([-1, 2, 4, 6, 7, 10, 23, 34, 45, 67, 89, 111, 145, 234, 345, 478, 583, 633], 583), Is.True);
                Assert.That(Harray.BinarySearch([1, 2, 4, 6, 7], 8), Is.False);
                Assert.That(Harray.BinarySearch([1, 2, 4, 6, 7], -4), Is.False);
            });
        }
        //TODO:
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void FindEvenNums()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Harray.FindEvenNums([1, 2, 4, 6, 7], [1, 7, 9]), Is.EqualTo(new int[] { 2, 4, 6 }));
                Assert.That(Harray.FindEvenNums([-1, 2, 4, 6, 7, 10, 23, 34, 45, 67, 89, 111, 145, 234, 345, 478, 583, 633], [89, 97]), Is.EqualTo(new int[] { 2, 4, 6, 10, 34, 234, 478 }));
                Assert.That(Harray.FindEvenNums([1, 6, 7], [11, 13]), Is.EqualTo((int[])[6]));
                Assert.That(Harray.FindEvenNums([0], [0]), Is.EqualTo((int[])[0, 0]));
                Assert.That(Harray.FindEvenNums([1, 3, 7], []), Is.EqualTo(Array.Empty<int>()));
                Assert.That(Harray.FindEvenNums([-11, -5, 7], []), Is.EqualTo(Array.Empty<int>()));
            });
        }

        [Test]
        public void Reverse()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Harray.Reverse([1, 2, 4, 6, 7]), Is.EqualTo(new int[] { 7, 6, 4, 2, 1 }));
                Assert.That(Harray.Reverse([-1, 2, 4, 6, 7, 10, 23, 34, 45]), Is.EqualTo(new int[] { 45, 34, 23, 10, 7, 6, 4, 2, -1 }));
                Assert.That(Harray.Reverse([6]), Is.EqualTo((int[])[6]));
                Assert.That(Harray.Reverse([0, 0]), Is.EqualTo((int[])[0, 0]));
                Assert.That(Harray.Reverse([]), Is.EqualTo(Array.Empty<int>()));

            });
        }

        [Test]
        public void ReverseInPlace()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Harray.ReverseInPlace([1, 2, 4, 6, 7]), Is.EqualTo(new int[] { 2, 4, 6, 7, 1 }));
                Assert.That(Harray.ReverseInPlace([6, 1]), Is.EqualTo(new int[] { 1, 6 }));
                Assert.That(Harray.ReverseInPlace([0]), Is.EqualTo(new int[] { 0 }));
            });
        }
    }
}
