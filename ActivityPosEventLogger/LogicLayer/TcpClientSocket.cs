using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ActivityPosEventLogger.Infrastructure;

namespace ActivityPosEventLogger.LogicLayer
{
    public class TcpClientSocket
    {
        private readonly string _ip;
        private readonly int _port;

        public TcpClientSocket(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        private Socket CreateAndConnectSocket()
        {
            try
            {
                var ipAddress = IPAddress.Parse(_ip);
                var remoteEndPoint = new IPEndPoint(ipAddress, _port);
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(remoteEndPoint);
                return socket;
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                return null;
            }
        }


        public void Send(string sPosEvent)
        {
            try
            {
                Logger.Write("Inicia Send");
                var socket = CreateAndConnectSocket();
                if (socket == null)
                    return;

                socket.Send(Encoding.ASCII.GetBytes(sPosEvent));
                Logger.Write("Envía");

                socket.Close(20);
                Logger.Write("Cierra");

            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }
    }
}
