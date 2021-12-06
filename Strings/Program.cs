using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<string> list = new List<string>();
                list.Add("911");
                list.Add("раз");
                list.Add("stop search");
                list.Add("abracadabra");
                list.Add("target");
                Console.WriteLine("Список включает в себя: ");
                foreach (string s in list)
                    Console.WriteLine(s);
                Console.WriteLine();

                StringSearcher searcher = new StringSearcher();
                searcher.SearchEnded += EventHandler;
                while (true)
                {
                    Console.WriteLine("Введите шаблон для поиска в формате Regex. Если по шаблону будет найдена строка \"stop search\", то отключится возможность вести дальнейший поиск.");
                    searcher.Search(list, new Regex(Console.ReadLine()));
                    Console.WriteLine();
                }

                void EventHandler(string s, bool stop)
                {
                    Console.WriteLine($"Найденная строка: {s}");
                    if (stop == true)
                        searcher.SearchEnded -= EventHandler;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        
    }
}