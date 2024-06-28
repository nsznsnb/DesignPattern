using System.Collections.Specialized;

namespace Properties
{
    public class Properties
    {
        public static NameValueCollection Load(string filePath)
        {
            var properties = new NameValueCollection();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("#") || line.Trim() == "")
                        continue;

                    var parts = line.Split(new[] { '=' }, 2);
                    if (parts.Length == 2)
                    {
                        properties.Add(parts[0].Trim(), parts[1].Trim());
                    }
                }
            }

            return properties;
        }

        public static void Store(NameValueCollection properties, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (string key in properties.AllKeys)
                {
                    writer.WriteLine($"{key}={properties[key]}");
                }
            }
        }
    }
}
