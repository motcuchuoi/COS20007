using NUnit.Framework;
using NUnit.Framework.Internal;
using ClockClass;

namespace ClockTest
{
    public class ClockTest
    {
        Clock clock;

        [SetUp]
        public void Setup()
        {
            clock = new Clock();   
        }

        [Test]
        public void Tick30seconds()
        {
            for(int i = 0; i < 30;  i++)
            {
                clock.Ticks();
            }
            Assert.That(clock.Seconds.Ticks, Is.EqualTo(30));
            Assert.That(clock.Minutes.Ticks, Is.EqualTo(0));
            Assert.That(clock.Hours.Ticks, Is.EqualTo(0));
        }

        [Test] 
        public void Ticks1minute()
        {
            for(int i = 0; i < 60; i++)
            {
                clock.Ticks();
            }
            Assert.That(clock.Seconds.Ticks, Is.EqualTo(0));
            Assert.That(clock.Minutes.Ticks, Is.EqualTo(1));
            Assert.That(clock.Hours.Ticks, Is.EqualTo(0));
        }
        [Test]
        public void Tick1hour()
        {
            for (int i = 0; i < 3600;  i++)
            {
                clock.Ticks();
            }
            Assert.That(clock.Seconds.Ticks, Is.EqualTo(0));
            Assert.That(clock.Minutes.Ticks, Is.EqualTo(0));
            Assert.That(clock.Hours.Ticks, Is.EqualTo(1));
        }
        [Test]
        public void Reset() // or Tick1day()
        {
            for (int i = 0; i < 864000; i++)
            {
                clock.Reset();
            }
            Assert.That(clock.Seconds.Ticks, Is.EqualTo(0));
            Assert.That(clock.Minutes.Ticks, Is.EqualTo(0));
            Assert.That(clock.Hours.Ticks, Is.EqualTo(0));
        }
    }
}