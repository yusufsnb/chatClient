using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace chatClient
{
    public partial class Form1 : Form
    {
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] receivedBuf = new byte[1024];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(ConnectToServer);
            t.Start();
        }


        private void ConnectToServer()
        {
            while (!_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Connect(txtIP.Text, int.Parse(txtPort.Text));
                }
                catch (SocketException)
                {
                    Debug.WriteLine("trying to connect: ");
                }
            }

            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + txtNickname.Text);
            _clientSocket.Send(buffer);
            label3.Text = ("Connected to server!");
            txtNickname.Enabled = false;
            txtIP.Enabled = false;
            txtPort.Enabled = false;
        }

        private void ReceiveData(IAsyncResult ar)
        {
            int exists_in_list = 0;
            try
            {
                Socket socket = (Socket)ar.AsyncState;
                int received = socket.EndReceive(ar);
                byte[] dataBuf = new byte[received];
                Array.Copy(receivedBuf, dataBuf, received);
                string recvMsg = Encoding.ASCII.GetString(dataBuf).ToString();
                if (recvMsg.Contains("remove*"))
                {
                    string smashMsg = recvMsg.Substring(4, (recvMsg.Length - 4));
                    for (int j = 0; j < listClients.Items.Count; j++)
                    {
                        if (listClients.Items[j].Equals(smashMsg))
                            listClients.Items.RemoveAt(j);
                    }
                }
                else if (recvMsg.Contains("@"))
                {
                    for (int i = 0; i < listClients.Items.Count; i++)
                    {
                        if (listClients.Items[i].ToString().Equals(recvMsg))
                            exists_in_list = 1;
                    }
                    if (exists_in_list == 0)
                    {
                        string user = "@" + txtNickname.Text;
                        if (!user.Equals(recvMsg))
                            listClients.Items.Add(recvMsg);
                    }
                }
                else
                    txtMessages.AppendText(recvMsg + "\n");

                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);

            }
            catch (Exception e)
            {
                Console.WriteLine("receiving error," + e.Message);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)
            {
                string client = "";
                foreach (var item in listClients.SelectedItems)
                {
                    client = listClients.GetItemText(item);
                    byte[] buffer = Encoding.ASCII.GetBytes(client + " :" + txtMsg.Text + "*" + txtNickname.Text);
                    _clientSocket.Send(buffer);
                    Thread.Sleep(20);

                }
                if (client.Equals(""))
                    MessageBox.Show("Please select a user from list");
                else
                    txtMessages.AppendText("\n" + txtNickname.Text + ": " + txtMsg.Text + "\n");
                txtMsg.Text = string.Empty;
            }
        }
    }
}