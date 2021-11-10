using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main()
        {
            //amazon , azonam-> true
            //amazon, azanam-> false
            //amazon, aozman-> false
            //amazon , onamaz-> true
            //amazon, amonaz-> false

            // length should be same
            var input1 = "amazon";
            var input2 = "amonaz";
            
            if (input1.Length.Equals(input2.Length))
            {
                for (int i = 0; i < input2.Length; i++)
                {
                    var character = input2.Substring(input2.Length - 1);
                    var interimStr = input2.Substring(0, input2.Length - 1).ToList<char>();
                    interimStr.Insert(0, character.ToCharArray()[0]);
                    var str = string.Empty;
                    foreach(var item in interimStr)
                    {
                        str += item;
                    }
                    input2 = str;
                    if (input2.Equals(input1))
                        Console.WriteLine("true");

                    else Console.WriteLine("false");
                    // switch the char position
                    //for (int j = 0)
                }
            }
            // instance of the charaters should be same



        }
    }
}
