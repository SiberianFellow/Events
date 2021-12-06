using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    internal class Ping
    {
        public delegate void Handler(int number);
        public event Handler OnPing;
        public void OnPong(int number)
        {
            Console.WriteLine("Ping получил Pong");
            if (number == 0)
            {
                Console.WriteLine("Pong победил! Ping промахнулся");
            }
            else
            {
                number --;
                OnPing?.Invoke(number);
            }
        }
        public void StartGame(int number)
        {
            Console.WriteLine("Ping начинает игру, сделав подачу...");
            number --;
            OnPing?.Invoke(number);
        }

    }
}
