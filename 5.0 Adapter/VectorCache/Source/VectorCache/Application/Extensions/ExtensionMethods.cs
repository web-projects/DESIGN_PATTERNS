using System.IO;
using System.Xml.Serialization;

namespace DesignPatternsPrototype
{
    public static class ExtensionMethods
    {
        public static T DeepCopyXml<T>(this T self)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(ms, self);
                ms.Position = 0;
                return (T)xs.Deserialize(ms);
            }
        }
    }
}
