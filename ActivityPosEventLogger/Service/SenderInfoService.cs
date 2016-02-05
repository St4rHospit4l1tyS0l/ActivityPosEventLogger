using System;
using ActivityPosEventLogger.Infrastructure;
using ActivityPosEventLogger.LogicLayer;

namespace ActivityPosEventLogger.Service
{
    public static class SenderInfoService
    {
        private static TcpClientSocket _socket;

        public static void SendInfoToTcpSocket(PosEvent posEvent)
        {
            try
            {
                var sPosEvent = posEvent.Serialize();
                _socket.Send(sPosEvent);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }

        public static void InitializeSocket(string ip, int port)
        {
            _socket = new TcpClientSocket(ip, port);
        }
    }
}
