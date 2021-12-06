using System;
using System.Collections.Generic;
using System.Linq;

namespace Counter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Counter counter = new Counter();
                Handler1 handler1 = new Handler1();
                Handler2 handler2 = new Handler2();
                counter.TimeToStop += handler1.H1Reaction;
                counter.TimeToStop += handler2.H2Reaction;
                counter.Count();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}