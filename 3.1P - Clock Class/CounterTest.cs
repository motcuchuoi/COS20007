using NUnit.Framework;
using NUnit.Framework.Internal;
using CounterClass;

namespace CounterClassTest
{
    public class CounterClassTest
    {
        Counter _count;
        [SetUp]
        public void Setup()
        {
            _count = new Counter("count");
        }
        [Test]
        public void TestInitialise()
        {
            Assert.That(0, Is.EqualTo(_count.Ticks)); // or Assert.True (0 == _count.Ticks);
        }

        [Test]
        public void Increment()
        {
            _count.Increment();
            Assert.True(1 == _count.Ticks);
        }
        [Test]
        public void IncrementMultipleTimes()
        {
            for (int i = 0; i < 100;  i++)
            {
                _count.Increment();
            }
            Assert.True(100 == _count.Ticks);
        }
        [Test]
        public void Reset()
        {
            _count.Reset();
            Assert.True(0 == _count.Ticks);
        }
    }
}