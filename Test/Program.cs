using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Length);

            char[] chararray = input.ToCharArray();
            int count = 0;
            List<char> list = new List<char>();
            for (var item = 0; item < chararray.Length; item++)
            {
                if (!list.Contains(chararray[item]))
                {
                    list.Add(chararray[item]);
                }
            }

            List<char> charlist = new List<char>();
            foreach (var i in list)
            {
                for (int a = 0; a < chararray.Length; a++)
                {
                    if (i == chararray[a])
                    {
                        count++;
                    }
                }
                Console.WriteLine(i + " - " + count);
                if (count > 1)
                {
                    charlist.Add(i);
                }
                count = 0;
            }
            if (charlist.Count > 1)
            {
                Console.Write("Second Repeater - " + charlist[1]);
            }
            else Console.WriteLine("There is no second repeated character");
            Console.ReadLine();

            Dictionary<int, int> Dict = new Dictionary<int, int>();
            Dict.Add(1, 2);
            Dict.Add(2, 3);

        }
    }
}
