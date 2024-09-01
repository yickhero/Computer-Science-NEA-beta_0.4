using SimpleTCP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Computer_Science_BETA_0._3
{
    public partial class application : Form
    {
        //List<List<string>> folderList = DatabaseControl.GetFolderList();
        public static string foldername = "";
        public static string foldertype = "";
        public static string folderid = "";
        public static string tags = "";
        public static string email = "";
        public static string username = "";
        public static string userid = "";
        public static bool server_connected = false;
        public static string textstatustext = "";

        public application()
        {
            InitializeComponent();
            string search = search_textbox.Text;
            int search_length = search_textbox.Text.Length;
            email = Form1.email_login;
            string[] users = DatabaseControl.GetUserFromEmail(email);
            userid = users[0];
            username = users[1];
            username_label.Text = ("username: " + username);
            userid_label.Text = ("userid: " + userid);
            email_label.Text = ("email: " + email);
            DataTable dataTable = ConvertToDataTable(DatabaseControl.GetFolderList());
            folders_datagridview.DataSource = dataTable;
            



        }
        SimpleTcpClient client;

        private void addfolder_button_Click(object sender, EventArgs e)
        {
            this.Close();
            folder_add form = new folder_add();
            form.Show();
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            string searchtext = search_textbox.Text;
            List<string> matchingFolders = foldernames(DatabaseControl.GetFolderList()).FindAll(folder => folder.IndexOf(searchtext, StringComparison.OrdinalIgnoreCase) >= 0);
            if (matchingFolders.Count > 0)
            {
                DataTable dataTable = ConvertToDataTable(DatabaseControl.GetFolderListSearched(matchingFolders));
                folders_datagridview.DataSource = dataTable;
                folders_datagridview.Refresh();
            }
            else if (matchingFolders.Count == 0)
            {
                DataTable dataTable = ConvertToDataTable(DatabaseControl.GetFolderList());
                folders_datagridview.DataSource = dataTable;
                folders_datagridview.Refresh();
            }

        }


        //chatgpt code
        public static DataTable ConvertToDataTable(List<List<string>> list)
        {
            DataTable table = new DataTable();

            // Add columns to the DataTable
            table.Columns.Add("Folder Name");
            table.Columns.Add("Folder Type");
            table.Columns.Add("Tags");
            table.Columns.Add("Folder ID");
            table.Columns.Add("Folder Score");

            // Add rows to the DataTable
            foreach (var row in list)
            {
                DataRow dataRow = table.NewRow();
                dataRow["Folder Name"] = row[0];
                dataRow["Folder Type"] = row[1];
                dataRow["Tags"] = row[2];
                dataRow["Folder ID"] = row[3];
                dataRow["Folder Score"] = row[4];
                table.Rows.Add(dataRow);
            }

            return table;
        }
        //chatgpt code
        private List<string> foldernames(List<List<string>> list)
        {
            List<string> foldernames = new List<string>();
            foreach (var row in list)
            {
                foldernames.Add(row[0]);  
            }
            return foldernames;
        }

        private void folders_datagridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = folders_datagridview.Rows[e.RowIndex];
                foldername = row.Cells["Folder Name"].Value.ToString();
                foldertype = row.Cells["Folder Type"].Value.ToString();
                tags = row.Cells["tags"].Value.ToString();
                folderid = row.Cells["Folder ID"].Value.ToString();
                DataStore.cards.Clear();
                folder_app form = new folder_app();
                this.Close();
                form.Show();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            folders_datagridview.Refresh();
        }

        private void application_Load(object sender, EventArgs e)
        {
            textstatus_textbox.Text = folder_app.textstatustext;
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataRecieved;

        }


        private void port_label_Click(object sender, EventArgs e)
        {

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(host_textbox.Text, Convert.ToInt32(port_textbox.Text));
                connect_button.Enabled = false;
                MessageBox.Show("You have connected to the server");
                server_connected = true;
            }
            catch(Exception )
            {
                MessageBox.Show("Have you started the server yet?");
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

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteLineAndGetReply(message_textbox.Text, TimeSpan.FromSeconds(0.3));
            }
            catch(Exception )
            {
                MessageBox.Show("Is the IP or port correct? Have the server started yet?");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LearnersChatRoomServer form = new LearnersChatRoomServer();
            form.Show();
        }
    }
}
