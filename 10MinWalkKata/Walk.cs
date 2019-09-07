using System;
using System.Linq;

namespace TenMinWalk
{
    public class Walk
    {
        static void Main(string[] args)
        {
            
        }

        public string Walking(char[] newWalk)
        {
            var NSMatch = newWalk.Count(direction => direction == 'n') == newWalk.Count(direction => direction == 's');
            var EWMatch = newWalk.Count(direction => direction == 'w') == newWalk.Count(direction => direction == 'e');
            {
                if (newWalk.Length == 10 && NSMatch && EWMatch)
            {
                return "true";
            }
            }

            return "false";
        }

    }
}
