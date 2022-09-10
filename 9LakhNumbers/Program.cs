namespace _9LakhNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            //string str = "";
            //for (int i = 0; i < 100000; i++)
            //{
            //    str += "+919999999999,";
            //}
            //str = str.Substring(0, str.Length - 1);
            //File.AppendAllText("C:\\Users\\Amit Sharma\\Source\\Repos\\pr1nc317\\Test\\Test\\abc.txt", str);

            List<string> list = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                list.Add("+919999999999");
                
            }
            stringBuilder = stringBuilder.AppendJoin(',', list);
            File.AppendAllText("C:\\Users\\Amit Sharma\\Source\\Repos\\pr1nc317\\Test\\Test\\abc.txt", str);
        }
    }
}
