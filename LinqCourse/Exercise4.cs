using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public static class Exercise4
    {
        // Comparison of LINQ queries.
        public static void Run()
        {
            var list = new List<Person>();
            int seed = 200000000;

            for (int i = 0; i < seed; i++)  list.Add(new Person());

            Console.WriteLine("Start - list.Where(c => c.balance > 1000000).Count() > 0");
            var time = DateTime.Now;
            if (list.Where(c => c.balance > 1000000).Count() > 0)
            {
                Console.WriteLine(String.Format("End - {0} ms", DateTime.Now.Subtract(time).TotalMilliseconds));
                
            }

            time = DateTime.Now;
            Console.WriteLine("Start - list.Any(c => c.balance > 1000000)");
            if (list.Any(c => c.balance > 1000000))
            {
                Console.WriteLine(String.Format("End - {0} ms", DateTime.Now.Subtract(time).TotalMilliseconds));
            }

            time = DateTime.Now;
            Console.WriteLine("Start - list.Any(c => c.station == 1)");
            if (list.Any(c => c.station == 1))
            {
                Console.WriteLine(String.Format("End - {0} ms", DateTime.Now.Subtract(time).TotalMilliseconds));
            }

            time = DateTime.Now;
            Console.WriteLine("Start - list.Where(c => c.station == 1).Count() > 0");
            if (list.Where(c => c.station == 1).Count() > 0)
            {
                Console.WriteLine(String.Format("End - {0} ms", DateTime.Now.Subtract(time).TotalMilliseconds));
            }

        }
    }

    class Person
    {
        public Guid Id = Guid.NewGuid();
        public int station = Random.Shared.Next(1, 10);
        public int balance = Random.Shared.Next(1, 1000000000);

    }

}