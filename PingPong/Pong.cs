using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    internal class Pong
    {
        public delegate void Handler(int number);
        public event Handler OnPong;
        public void OnPing(int number)
        {
            Console.WriteLine("Pong получил Ping");
            if (number == 0)
            {
                Console.WriteLine("Ping победил! Pong промахнулся");
            }
            else
            {
                number --;
                OnPong?.Invoke(number);
            }
        }
    }
}
