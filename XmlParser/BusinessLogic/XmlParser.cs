using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Xml;

namespace XmlParser.BusinessLogic
{
    public static class XmlParser
    {
        public static T? ParseXmlFile<T>(string root)
        {
            if (string.IsNullOrWhiteSpace(root))
            {
                throw new ArgumentNullException(nameof(root));
            }

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(root);

            var json = JsonConvert.SerializeXmlNode(xmlDoc);

            json = Regex.Replace(json, "(?<=\")(@)(?!.*\":\\s )", string.Empty, RegexOptions.IgnoreCase);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
