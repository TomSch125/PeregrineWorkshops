using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        const int portNo = 25000;
        TcpClient client;
        byte[] data;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.Form_Closing);

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (btnSignIn.Text == "Sign In")
            {
                try
                {
                    client = new TcpClient();
                    client.Connect("127.0.0.1", portNo);
                    data = new byte[client.ReceiveBufferSize];

                    // read from server
                    SendMessage(txtNick.Text);
                    client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(client.ReceiveBufferSize), ReceiveMessage, null);
                    btnSignIn.Text = "Sign Out";
                    btnSend.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                Disconnect();
                btnSignIn.Text = "Sign In";
                btnSend.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage(txtMessage.Text);
            txtMessage.Clear();
        }

        public void SendMessage(string message)
        {
            try
            {
                NetworkStream ns = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(message);
                ns.Write(data, 0, data.Length);
                ns.Flush();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ReceiveMessage(IAsyncResult ar)
        {
            try
            {
                int bytesRead;
                bytesRead = client.GetStream().EndRead(ar);
                if (bytesRead < 1)
                {
                    return; // no messages to read
                }
                else
                {
                    //object[] para = { Encoding.ASCII.GetString(data, 0, bytesRead) };
                    //this.Invoke(new delUpdateHistory(UpdateHistory), para);

                    string messageReceived = Encoding.ASCII.GetString(data, 0, bytesRead);
                    UpdateHistory(messageReceived);
                }
                client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(client.ReceiveBufferSize), ReceiveMessage, null);
            }
            catch (Exception ex)
            {

            }
        }

        //public delegate void delUpdateHistory(object para);
        public void UpdateHistory(string str)
        {

            //txtMessageHistory.AppendText(str + Environment.NewLine);
            txtMessageHistory.Text = txtMessageHistory.Text + str;
        }

        public void Disconnect()
        {
            try
            {
                if (client != null)
                {
                    client.GetStream().Close();
                    client.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txtMessageHistory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
