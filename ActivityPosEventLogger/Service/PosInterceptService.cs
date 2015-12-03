using System;
using System.IO;
using System.Threading.Tasks;
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
            Logger.Write("Se ha iniciado de forma correcta la interfaz de eventos");
        }

        
        public void LogIn(int iEmployeeId, string sName)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("Login", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);                
            });
        }


        public void LogOut(int iEmployeeId, string sName)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("LogOut", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }


        public void OpenCheck(int iEmployeeId, int iQueueId, int iTableId, int iCheckId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("OpenCheck", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void CloseCheck(int iEmployeeId, int iQueueId, int iTableId, int iCheckId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("CloseCheck", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void AddItem(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("AddItem", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetItemInfo(iCheckId, iEntryId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }
  
    }
}
