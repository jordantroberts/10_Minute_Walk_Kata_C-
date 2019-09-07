using System;

namespace TenMinWalk
{
    public class Walk
    {
        static void Main(string[] args)
        {
            
        }

        public string Walking(char[] newWalk)
        {
            if (newWalk.Length == 10)
            {
                return "true";
            }
            return "false";
        }

    }
}
