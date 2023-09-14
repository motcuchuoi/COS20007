using System;

namespace ClockClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            for (int i = 0; i < 120; i++)
            {
                clock.Ticks();
                Console.WriteLine(clock.GetTime);
                Thread.Sleep(1000);
                Console.Clear();
            }
            
        }
    }
}
