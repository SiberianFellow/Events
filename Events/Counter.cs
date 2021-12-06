using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class Counter
    {
        public delegate void Handler(int number);
        public event Handler TimeToStop;

        public void Count()
        {
            //Random rnd = new Random();
            //int stopNumber = rnd.Next(100);
            int stopNumber = 77;
            for (int i = 0; i < 100; i++)
            {
                if (i == stopNumber)
                {
                    TimeToStop?.Invoke(stopNumber);
                }
            }
        }
    }
}
