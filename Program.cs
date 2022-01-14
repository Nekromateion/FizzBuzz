using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Program
    {
        private const char Nl = '\n';
        private const int numberLimit = 30; // Total amount of numbers to loop over
        private const int sizeOfNumber = 2; // Max amount of characters the numbers would have -> 30:2 | 1234:4
        private const int sizeOfText = 8;   // This is always 8 since the biggest text is "FizzBuzz"

        public static void Main()
        {
            int useForLoop = (sizeOfNumber > sizeOfText) ? sizeOfNumber : sizeOfText;
            bool f;
            bool b;
            int _fizz = 3;
            int _buzz = 5;
            CustomArray<char> buffer = new CustomArray<char>(useForLoop*numberLimit);
            for (ushort i = 1; i <= 30; i++)
            {
                f = i == _fizz;
                b = i == _buzz;
                if (f)
                {
                    buffer.Add('F');
                    buffer.Add('i');
                    buffer.Add('z');
                    buffer.Add('z');
                    _fizz += 3;
                }

                if (b)
                {
                    buffer.Add('B');
                    buffer.Add('u');
                    buffer.Add('z');
                    buffer.Add('z');
                    _buzz += 5;
                }
                else if (!f) buffer.AddRange(i.ToString());
                buffer.Add(Nl);
            }
            Console.Out.Write(buffer.ToArray, 0, buffer.Count);
        }
    }

    public class CustomArray<T>
    {
        private int _index;
        private readonly T[] _array;

        public int Count => _index + 1;
        public T[] ToArray => _array;
        
        public CustomArray(int size)
        {
            _array = new T[size];
        }

        public void Add(T item)
        {
            _array[_index] = item;
            _index++;
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }
    }
}
