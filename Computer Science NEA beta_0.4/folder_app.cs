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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NEA_Computer_Science_BETA_0._3
{
    public partial class folder_app : Form
    {
        public static string textstatustext = "";
        public static Queue<string> cards = new Queue<string>();
        public static string cardsperround = "";

        public folder_app()
        {
            InitializeComponent();
            string foldername = application.foldername;
            string foldertype = application.foldertype;
            string tags = application.tags;
            string folderid = application.folderid;
            foldername_label.Text = ("Folder Name: " + foldername);
            foldertype_label.Text = ("Folder Type: " + foldertype);
            tags_label.Text = ("Folder Tags: \n" +  tags);
            folderid_label.Text = ("Folder ID: " + folderid);
            string folderid_ = DatabaseControl.GetFolderidFromFoldername(foldername);
            cards_datagridview.DataSource = DatabaseControl.GetCardList(folderid_);
        }
        SimpleTcpClient client;


        private void createcards_button_Click(object sender, EventArgs e)
        {
            addcard_form form = new addcard_form();
            this.Close();
            form.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            application form = new application();
            this.Close();
            form.Show();
        }
        
        private void revise_button_Click(object sender, EventArgs e)
        {
            cardsperround = cardsperround_combobox.Text;
            cards = DatabaseControl.GetCardsFromFolderID(application.folderid, cardsperround);
            if (cards.Count == 0)
            {
                MessageBox.Show("There are no cards");
            }
            else
            {
                Revise_Question_Screen form = new Revise_Question_Screen();
                this.Close();
                form.Show();

            }

        }

        private void folder_app_Load(object sender, EventArgs e)
        {
            textstatus_textbox.Text = application.textstatustext;
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataRecieved;
            if (application.server_connected == true)
            {
                client.Connect(host_textbox.Text, Convert.ToInt32(port_textbox.Text));
                connect_button.Enabled = false;;

            }
        }
  
        private void Client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            textstatus_textbox.Invoke((MethodInvoker)delegate ()
            {
                textstatus_textbox.Text += e.MessageString + "\r\n";
                textstatustext = textstatus_textbox.Text;
            });
        }

 


        private void button1_Click_1(object sender, EventArgs e)
        {
            LearnersChatRoomServer form = new LearnersChatRoomServer();
            form.Show();
        }

        private void send_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                client.WriteLineAndGetReply(message_textbox.Text, TimeSpan.FromSeconds(0.3));
            }
            catch (Exception)
            {
                MessageBox.Show("Is the IP or port correct? Have the server started yet?");
            }
        }

        private void connect_button_Click_1(object sender, EventArgs e)
        {
        
            try
            {
                client.Connect(host_textbox.Text, Convert.ToInt32(port_textbox.Text));
                connect_button.Enabled = false;
                MessageBox.Show("You have connected to the server");
            }
            catch (Exception)
            {
                MessageBox.Show("Have you started the server yet?");
            }
        }
    }
}
