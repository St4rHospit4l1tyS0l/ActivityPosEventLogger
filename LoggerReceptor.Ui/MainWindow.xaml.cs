using System;
using System.Collections.ObjectModel;
using System.Windows;
using ActivityPosEventLogger.LogicLayer;

namespace LoggerReceptor.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        readonly ObservableCollection<string> _lstData = new ObservableCollection<string>();
        readonly TcpServerSocket _tcpServer;
        

        public MainWindow()
        {
            InitializeComponent();
            LstLogs.ItemsSource = _lstData;
            _tcpServer = new TcpServerSocket
            {
                Ip = IpTxt.Text,
                Port = int.Parse(PortTxt.Text)
            };
            _tcpServer.DataReceived += OnDataReceived;
            var response = _tcpServer.CreateTcpSocket();
            if (response.IsSuccess == false)
                MessageBox.Show(response.Message, "Emulador cámara", MessageBoxButton.OK, MessageBoxImage.Error);

            IpTxt.Focus();
        }

        private void OnDataReceived(string obj)
        {
            Dispatcher.Invoke(new Action(() => _lstData.Insert(0, obj)));
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            int port;

            if (int.TryParse(PortTxt.Text, out port) == false)
            {
                MessageBox.Show("El puerto no es válido", "Emulador cámara", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var response = _tcpServer.ResetConnection();
            if (response.IsSuccess == false)
                MessageBox.Show(response.Message, "Emulador cámara", MessageBoxButton.OK, MessageBoxImage.Error);

            _tcpServer.Ip = IpTxt.Text;
            _tcpServer.Port = port;
            response = _tcpServer.CreateTcpSocket();

            if (response.IsSuccess == false)
            {
                MessageBox.Show(response.Message, "Emulador cámara", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show("Servidor iniciado", "Emulador cámara", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
                var response = _tcpServer.ResetConnection();
                if(response.IsSuccess == false)
                    MessageBox.Show(response.Message, "Emulador cámara", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
