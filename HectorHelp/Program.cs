namespace HectorHelp
{
    using System;
    using System.IO;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            string contents = null;
            using (StreamReader sr = new StreamReader("C:\\Users\\Amit Sharma\\Downloads\\803178010040688.xml", System.Text.Encoding.UTF8))
            {
                contents = sr.ReadToEnd();
            }
            doc.LoadXml(contents);


            ///// EXTRA /////
            var xmlList = doc.GetElementsByTagName("party");
            for (int i = 0; i < xmlList.Count; i++)
            {
                Console.WriteLine(xmlList[i].ChildNodes.Item(i).InnerText);
            }

            //foreach (var item in xmlList.)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(doc.GetElementsByTagName("party")[1].InnerXml);

        }
    }
}

