using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    internal static class Program
    {
        private static readonly char[] Fizz = {'F', 'i', 'z', 'z'};
        private static readonly char[] Buzz = {'B', 'u', 'z', 'z'};
        private const char Nl = '\n';

        public static void Main()
        {
            bool f;
            bool b;
            int _fizz = 3;
            int _buzz = 5;
            List<char> buffer = new List<char>();
            for (ushort i = 1; i <= 30; i++)
            {
                f = i == _fizz;
                b = i == _buzz;
                if (f)
                {
                    buffer.AddRange(Fizz);
                    _fizz += 3;
                }

                if (b)
                {
                    buffer.AddRange(Buzz);
                    _buzz += 5;
                }
                else if (!f) buffer.AddRange(i.ToString());
                buffer.Add(Nl);
            }
            Console.Out.Write(buffer.ToArray(), 0, buffer.Count);
        }
    }
}
