using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ActivityPosEventLogger.Infrastructure
{
    public static class GenericSerializer
    {
        public static string Serialize<T>(this T value) where T : class
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                using (var stringWriter = new StringWriter())
                {
                    using (var writer = XmlWriter.Create(stringWriter))
                    {
                        xmlserializer.Serialize(writer, value);
                        return stringWriter.ToString();
                    }
                }
                
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                return "No fue posible generar la cadena XML";
            }
        }
    }
}
