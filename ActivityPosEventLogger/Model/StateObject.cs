using System.Net.Sockets;
using System.Text;

namespace ActivityPosEventLogger.Model
{
    public class StateObject
    {
        // Client  socket.
        public Socket WorkSocket = null;
        // Size of receive buffer.
        public const int BUFFER_SIZE = 1024;
        // Receive buffer.
        public byte[] Buffer = new byte[BUFFER_SIZE];
        // Received data string.
        public StringBuilder Sb = new StringBuilder();
    }
}