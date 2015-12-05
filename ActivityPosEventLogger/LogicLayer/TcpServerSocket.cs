using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ActivityPosEventLogger.Model;

namespace ActivityPosEventLogger.LogicLayer
{
    public class TcpServerSocket
    {
        public string Ip { get; set; }
        public int Port { get; set; }

        private Task _listenTask;
        private CancellationTokenSource _cancellationToken;
        private Socket _listener;
        public event Action<string> DataReceived;

        protected virtual void OnDataReceived(string obj)
        {
            var handler = DataReceived;
            if (handler != null) handler(obj);
        }

        public ResponseMessage CreateTcpSocket()
        {
            IPAddress ipAddress;
            try
            {
                ipAddress = IPAddress.Parse(Ip);
            }
            catch (Exception)
            {
                return new ResponseMessage { IsSuccess = false, Message = "IP no válida o no pertence al equipo" };
            }
            
            try
            {
                var localEndPoint = new IPEndPoint(ipAddress, Port);
                _listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _listener.Bind(localEndPoint);
                _listener.Listen(100);

                _cancellationToken = new CancellationTokenSource();
                _listenTask = new TaskFactory().StartNew(() => StartListen(_listener), _cancellationToken.Token);


                return new ResponseMessage{IsSuccess = true};
            }
            catch (Exception ex)
            {
                return new ResponseMessage { IsSuccess = false, Message = ex.Message};
            }
        }

        public ResponseMessage ResetConnection()
        {
            try
            {
                if (_listener != null)
                {
                    _listener.Close();
                    _listener = null;
                }

                if (_cancellationToken != null)
                    _cancellationToken.Cancel();

                return new ResponseMessage { IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new ResponseMessage { IsSuccess = false, Message = ex.Message };
            }
        }

        private void StartListen(Socket listener)
        {
            while (true)
            {
                try
                {
                    Accept(listener.Accept());
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void Accept(Socket handler)
        {
            var state = new StateObject {WorkSocket = handler};
            handler.BeginReceive(state.Buffer, 0, StateObject.BUFFER_SIZE, 0, ReadCallback, state);
        }

        private void ReadCallback(IAsyncResult ar)
        {
            var state = (StateObject)ar.AsyncState;
            var handler = state.WorkSocket;

            var bytesRead = handler.EndReceive(ar);

            if (bytesRead <= 0)
            {
                var contentIn = state.Sb.ToString();
                if (String.IsNullOrEmpty(contentIn) == false)
                    ExtractReceivedData(state.Sb.ToString(), state);
            }

            state.Sb.Append(Encoding.ASCII.GetString(state.Buffer, 0, bytesRead));

            var content = state.Sb.ToString();
            if (content.IndexOf("<EOF>", StringComparison.Ordinal) > -1 || content.IndexOf("\n", StringComparison.Ordinal) > -1)
            {
                ExtractReceivedData(content, state);
                handler.BeginReceive(state.Buffer, 0, StateObject.BUFFER_SIZE, 0, ReadCallback, state);
            }
            else
            {
                // Not all data received. Get more.
                handler.BeginReceive(state.Buffer, 0, StateObject.BUFFER_SIZE, 0, ReadCallback, state);
            }
        }

        private void ExtractReceivedData(string content, StateObject state)
        {
            content = content.Replace("<EOF>", "");
            content = content.Replace("\n", "");
            content = content.Replace("\r", "");
            DataReceived(String.Format("Conexión entrante: {2}, Info: {0} | Tamaño: {1}", content, content.Length,
                state.WorkSocket.RemoteEndPoint.ToString()));
            state.Sb.Remove(0, state.Sb.Length);
        }
    }
}
