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
    public partial class addcard_form : Form
    {
        public static string imagelocationfront = "";
        public static string imagelocationback = "";
        public addcard_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            string answer = back_richtextbox.Text;
            string question = front_richtextbox.Text;
            int folderid = DatabaseControl.GetFolderIDFromFolderName(application.foldername);
            int userid = Convert.ToInt32(application.userid);
            DatabaseControl.CreateCards(folderid, userid, imagelocationfront, imagelocationback , question, answer);
            folder_app form = new folder_app();
            this.Close();
            form.Show();
        }

        private void aicreatecard_button_Click(object sender, EventArgs e)
        {

        }

        private void addcard_form_Load(object sender, EventArgs e)
        {

        }
        //chatgpt
        private void uploadimage_button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    Image image = Image.FromFile(imageLocation);
                    InsertImageToRichTextBox(front_richtextbox, image);
                    imagelocationfront = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
      

        private void InsertImageToRichTextBox(RichTextBox richTextBox, Image image)
        {
            Clipboard.SetImage(image);

            if (Clipboard.ContainsImage())
            {
                richTextBox.Paste();
            }
            else
            {
                MessageBox.Show("Image could not be copied to clipboard.");
            }
        }

        private void uploadimage_button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    Image image = Image.FromFile(imageLocation);
                    InsertImageToRichTextBox(back_richtextbox, image);
                    imagelocationback = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //chatgpt

    }
}
