using System;
using System.IO;
using System.Windows.Forms;
using ActivityPosEventLogger.Model;

namespace ActivityPosEventLogger.Infrastructure
{

    public static class Logger
    {
        private const string FILE_PATH = "PosInterceptService.log";

        private static string FilePath
        {
            get
            {
                string value;
                if (DbReader.DicConfig.TryGetValue(Constants.PATH_FILE_LOGGER, out value))
                    return value;
                return FILE_PATH;
            }
        }

        public static void Write(string sMsg)
        {
            try
            {
                File.AppendAllText(FilePath, String.Format("{0} - {1}", DateTime.Now.ToString("G"), sMsg) + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " | " + ex.StackTrace);
            }
        }

        public static void Exception(Exception ex)
        {
            try
            {
                File.AppendAllText(FilePath, String.Format("{0} - Error: {1} -ST- {2}", DateTime.Now.ToString("G"), ex.Message, ex.StackTrace) + Environment.NewLine);
            }
            catch (Exception inEx)
            {
                MessageBox.Show(inEx.Message + " | " + inEx.StackTrace);
            }
        }
    }
}
