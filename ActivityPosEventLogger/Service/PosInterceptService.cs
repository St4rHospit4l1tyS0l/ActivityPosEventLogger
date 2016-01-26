using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActivityPosEventLogger.Infrastructure;
using ActivityPosEventLogger.Model;
using LasaFOHLib;

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


        public void CancelAddItem(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("CancelAddItem", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetItemInfo(iCheckId, iEntryId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }


        public void ModifyItem(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iEntryId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("ModifyItem", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetItemInfo(iCheckId, iEntryId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void OrderItems(int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iModeId)
        {

        }

        public void OpenItem(int iEmployeeId, int iEntryId, int iItemId, string sDescription, double dPrice)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("OpenItem", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), new PosEventItem{Id = iItemId, Name = sDescription, Price = dPrice});
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void SpecialMessage(int iEmployeeId, int iMessageId, string sMessage)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("SpecialMessage", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), sMessage);
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void DeleteItems(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iReasonId)
        {
            try
            {
                //Se tiene que realizar de forma secuencial debido a que la información es eliminada después de terminar este evento
                var lstItemsDeleted = _alohaFunctions.GetLstItemsDeleted();

                if(lstItemsDeleted.Any())
                    _alohaFunctions.FillNameByCheckId(iCheckId, lstItemsDeleted);
                
                new TaskFactory().StartNew(() =>
                {
                    var posEvent = new PosEvent("DeleteItems", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), lstItemsDeleted, iReasonId);
                    SenderInfoService.SendInfoToTcpSocket(posEvent);
                });

            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }    
        }

        public void ApplyPayment(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iTenderId, int iPaymentId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("ApplyPayment", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetPayment(iCheckId, iTenderId, iPaymentId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void AdjustPayment(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iTenderId, int iPaymentId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("AdjustPayment", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetPayment(iCheckId, iTenderId, iPaymentId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void DeletePayment(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iTenderId, int iPaymentId)
        {
            
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("DeletePayment", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetPayment(iCheckId, iTenderId, iPaymentId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void ApplyComp(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iCompTypeId, int iCompId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("ApplyComp", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetComp(iCompTypeId, iCompId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });

        }

        public void DeleteComp(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iCompTypeId, int iCompId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("DeleteComp", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetComp(iCompTypeId, iCompId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void ApplyPromo(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iPromotionId, int iPromoId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("ApplyPromo", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetPromo(iPromotionId, iPromoId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }

        public void DeletePromo(int iManagerId, int iEmployeeId, int iQueueId, int iTableId, int iCheckId, int iPromotionId, int iPromoId)
        {
            new TaskFactory().StartNew(() =>
            {
                var posEvent = new PosEvent("DeletePromo", TerminalId, _alohaFunctions.GetEmployee(iEmployeeId), _alohaFunctions.GetPromo(iPromotionId, iPromoId));
                SenderInfoService.SendInfoToTcpSocket(posEvent);
            });
        }
    }
}
