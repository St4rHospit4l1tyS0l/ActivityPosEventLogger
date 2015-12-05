using System;
using System.Collections.Generic;
using System.IO;
using ActivityPosEventLogger.Model;

namespace ActivityPosEventLogger.Infrastructure
{
    public static class DbReader
    {
        public static Dictionary<string, string> DicConfig = new Dictionary<string, string>();

        public static string Ip
        {
            get
            {
                string file;
                return DicConfig.TryGetValue(Constants.IP, out file) ? file : "127.0.0.1";
            }
        }

        public static int Port
        {
            get
            {
                string file;
                var sPort = DicConfig.TryGetValue(Constants.PORT, out file) ? file : "2500";
                int iPort;
                return int.TryParse(sPort, out iPort) ? iPort : 2500;
            }
        }

        public static bool ReadDictionaryFromFile(string file)
        {
            if (DicConfig.Count > 0)
                return true;

            DicConfig = new Dictionary<string, string>();

            if (!File.Exists(file))
            {
                Logger.Write(String.Format("El archivo '{0}' no existe", file));
                return false;
            }

            var lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line))
                    continue;

                var keyVal = line.Split('=');

                if (keyVal.Length != 2)
                {
                    Logger.Write(String.Format("El archivo '{0}' no tiene el formato correcto, debe ser llave=valor", file));
                    return false;
                }

                try
                {
                    DicConfig.Add(keyVal[0], keyVal[1]);
                }
                catch (Exception ex)
                {
                    Logger.Write(String.Format("La cadena '{0}' no tiene el formato correcto, debe ser llave(entero)=valor. Error: {1}", line, ex.Message));
                    return false;
                }
            }

            if (DicConfig.Count < 2)
            {
                Logger.Write("No fue posible leer toda la información del archivo");
                return false;
            }

            return true;
        }
    }
}
