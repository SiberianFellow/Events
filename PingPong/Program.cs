using System;
using System.Collections.Generic;
using System.Linq;

namespace PingPong
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Ping ping = new Ping();
                Pong pong = new Pong();
                Random rnd = new Random();
                int magicNumber = rnd.Next(2, 10);
                Console.WriteLine($"Начинает игру Ping, будет сделано {magicNumber} подач.");
                ping.OnPing += pong.OnPing;
                pong.OnPong += ping.OnPong;
                ping.StartGame(magicNumber);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());
            }  
        }
    }
}