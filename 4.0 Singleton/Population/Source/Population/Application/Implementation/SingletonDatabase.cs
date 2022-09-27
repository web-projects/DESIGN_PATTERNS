using DesignPatterns.Interfaces;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DesignPatterns.Implementation
{
    public class SingletonDatabase : IDatabase
    {
        private const string asset = @"Assets\capitals.xml";
        private Dictionary<string, int> Capitals;

        private static Lazy<SingletonDatabase> instance
            = new Lazy<SingletonDatabase>(() => new SingletonDatabase());


        private static int instanceCount;
        public static int Count => instanceCount;

        public static SingletonDatabase Instance
            => instance.Value;

        private SingletonDatabase()
        {
            Console.WriteLine("Initializing database...");
            ReadXmlAsset();
            instanceCount++;
        }

        /// <summary>
        /// ## Byte-Order Mark
        // The BOM is the character returned by `Encoding.UTF8.GetPreamble()`. Microsoft&#8217;s
        // <a href="http://msdn.microsoft.com/en-us/library/system.text.encoding.getpreamble(v=vs.110).aspx" title="Encoding.UTF8.GetPreamble on Microsoft" target="_blank">documentation</a> explains:
        // The Unicode byte order mark(BOM) is serialized as follows(in hexadecimal) :
        // * UTF-8: EF BB BF
        // * UTF-16 big endian byte order: FE FF
        // * UTF-16 little endian byte order: FF FE
        // * UTF-32 big endian byte order: 00 00 FE FF
        // * UTF-32 little endian byte order: FF FE 00 00
        // Converting these bytes to a string (`Encoding.UTF8.GetString`) allows us to check if the xml string starts with the BOM
        // or not.The code then removes that BOM from the xml string.
        /// </summary>
        // 
        private void ReadXmlAsset()
        {
            XDocument database = XDocument.Load(asset);

            try
            {
                //UTF8Encoding encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
                //string byteOrderMarkUtf8 = Encoding.UTF8.GetString(encoding.GetPreamble());
                //if (xml.StartsWith(byteOrderMarkUtf8))
                //{
                //    var lastIndexOfUtf8 = byteOrderMarkUtf8.Length - 1;
                //    xml = xml.Remove(0, lastIndexOfUtf8);
                //}

                //using (FileStream fs = new FileStream(asset, FileMode.Open, FileAccess.Read))
                //{
                //XDocument xml = XDocument.Load(fs);
                //IEnumerable<XElement> rootNodes = xml.Root.DescendantNodes().OfType<XElement>();
                //var allItems = rootNodes.ToDictionary(n => n.Name.ToString(), n => n.Value);

                Capitals =
                    (from x in database.Root.Descendants("City")
                     select new
                     {
                         TagName = x.Element("Name").Value,
                         TagValue = x.Element("Population").Value
                     }).ToDictionary(v => v.TagName.ToString(), v => Convert.ToInt32(v.TagValue));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ReadAllLines exception={ex.Message}");
            }
        }

        private void ReadTextAsset()
        {
            try
            {
                Capitals = File.ReadAllLines(asset)
                    .Batch(2)
                    .ToDictionary(
                        list => list.ElementAt(0).Trim(),
                        list => int.Parse(list.ElementAt(1))
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ReadAllLines exception={ex.Message}");
            }
        }

        public int GetPopulation(string name)
        {
            return Capitals[name];
        }
    }
}
