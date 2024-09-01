using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Computer_Science_BETA_0._3
{
    public partial class LearnersChatRoomServer : Form
    {
        public LearnersChatRoomServer()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void LearnersChatRoomServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataRecieved;
        }
        private void Server_DataRecieved (object sender, SimpleTCP.Message e)
        {
            textstatus_textbox.Invoke((MethodInvoker)delegate ()
            {
                textstatus_textbox.Text += e.MessageString + "\r\n";
                e.ReplyLine(string.Format("{0} said: {1}", application.username, e.MessageString)); 
            });
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            textstatus_textbox.Text += "Server is starting------";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(host_textbox.Text);
            server.Start(ip, Convert.ToInt32(port_textbox.Text));
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }

        private void textstatus_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
