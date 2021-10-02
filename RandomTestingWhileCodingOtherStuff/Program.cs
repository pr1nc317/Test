namespace RandomTestingWhileCodingOtherStuff
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 0, 0 };
            var output = list.RemoveAll(x=> x==0);
            
            double test;
            double.TryParse("10.0", out double test1);
            Console.WriteLine(test1);
            Console.WriteLine(Convert.ToDouble("1"));
            Console.WriteLine(int.TryParse("2.0", out int test2));
            Console.WriteLine(test2);
            Console.WriteLine(int.Parse("2.1"));

            //var id = "10c91e695907489480580ca38d32eb66";
            var fileContents = File.ReadAllText(Environment.CurrentDirectory + @"\TestJson.json");
            //var jsonArray = Convert.ToDateTime(JObject.Parse(fileContents)["NSTS"]).AddMinutes(300).ToString("MM/dd/yyyy HH:mm:ss");
            var time = Convert.ToDateTime(JObject.Parse(fileContents)["Data"]["TimeOfCharge"]).ToString("MM/dd/yyyy HH:mm:ss");

            //foreach (var item in jsonArray)
            //{
            //    if (item["Id"].ToString().Equals(id)) break;
            //    else continue;
            //}
        }
    }
}
