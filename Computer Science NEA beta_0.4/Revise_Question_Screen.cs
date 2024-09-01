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
    public partial class Revise_Question_Screen : Form
    {
        
        
        public Revise_Question_Screen()
        {
            InitializeComponent();
            string cardquestion = folder_app.cards.Peek();
            if (cardquestion.Contains("|"))
            {
                string[] parts = cardquestion.Split('|');
                string question = parts[0];
                string imagelocationfront = parts[1];
                Image image = Image.FromFile(imagelocationfront);
                MessageBox.Show(imagelocationfront);
                InsertImageToRichTextBox(question_richtextbox, image);
                question_richtextbox.AppendText(Environment.NewLine + question);
            }
            else
            {
                question_richtextbox.Text = cardquestion;
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

        private void question_richtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showanswer_button_Click(object sender, EventArgs e)
        {
            Revise_Answer_Screen form = new Revise_Answer_Screen();
            this.Close();
            form.Show();
        }

        private void Revise_Question_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
