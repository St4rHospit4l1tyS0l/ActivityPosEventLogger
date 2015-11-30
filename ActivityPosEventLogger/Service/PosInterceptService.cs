using System;
using System.IO;
using System.Windows.Forms;
using ActivityPosEventLogger.Infrastructure;
using ActivityPosEventLogger.Model;

namespace ActivityPosEventLogger.Service
{
    public partial class PosInterceptService
    {
        private int _terminalId;
        private readonly AlohaFunctionsService _alohaFunctions;

        public PosInterceptService()
        {
            _alohaFunctions = new AlohaFunctionsService();
        }


        public int TerminalId
        {
            get
            {
                if (_terminalId == default(int))
                {
                    _terminalId = _alohaFunctions.GetTerminalId();
                }

                return _terminalId;
            }
        }

        public void InitializationComplete()
        {
            var fileName = Path.Combine(Environment.CurrentDirectory, Constants.FILE_NAME_CONFIG);

            if (DbReader.ReadDictionaryFromFile(fileName) == false)
            {
                var msg = String.Format("No existe el archivo de configuración {0} o no se pudo leer de forma correcta", fileName);
                Logger.Write(msg);
                MessageBox.Show(msg);
            }

            SenderInfoService.InitializeSocket(DbReader.Ip, DbReader.Port);
        }

        
        public void LogIn(int iEmployeeId, string sName)
        {
            var posEvent = new PosEvent("Login", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId));
            SenderInfoService.SendInfoToTcpSocket(posEvent);
        }
    }
}
