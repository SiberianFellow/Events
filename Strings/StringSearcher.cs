using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Strings
{
    internal class StringSearcher
    {
        public delegate void Handler(string result, bool stop);
        public event Handler SearchEnded;
        public void Search(List<string> list, Regex rx)
        {
            foreach (string item in list)
            {
                if (rx.IsMatch(item))
                {
                    if (item == "stop search")
                        SearchEnded?.Invoke(item, true);
                    else
                        SearchEnded?.Invoke(item, false);
                    break;
                }
            }
        }
    }
}
