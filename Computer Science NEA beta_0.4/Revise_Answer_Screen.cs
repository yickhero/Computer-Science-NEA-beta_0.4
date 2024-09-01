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
    public partial class Revise_Answer_Screen : Form
    {
        public static int veryeasy_count = 0;
        public static int easy_count = 0;
        public static int okay_count = 0;
        public static int difficult_count = 0;
        public static int verydifficult_count = 0;
        public static string current_question = "";
        public static int current_cardid = 0;

        public Revise_Answer_Screen()
        {
            InitializeComponent();
            string cardquestion = folder_app.cards.Dequeue();
            string cardanswer = folder_app.cards.Dequeue();
            if (cardquestion.Contains("|"))
            {
                string[] parts = cardquestion.Split('|');
                string question = parts[0];
                string imagelocationfront = parts[1];
                Image image = Image.FromFile(imagelocationfront);
                InsertImageToRichTextBox(Question_richtextbox, image);
                Question_richtextbox.AppendText(Environment.NewLine + question);
                current_question = question;
            }
            else
            {
                Question_richtextbox.Text = cardquestion;
            }
            if (cardanswer.Contains("|"))
            {
                string[] parts = cardanswer.Split('|');
                string answer = parts[0];
                string imagelocationfront = parts[1];
                Image image = Image.FromFile(imagelocationfront);
                InsertImageToRichTextBox(answer_richtextbox, image);
                answer_richtextbox.Text = answer;
            }
            else
            {
                answer_richtextbox.Text = cardanswer;
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
    

        private void Question_richtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void verydifficult_button_Click(object sender, EventArgs e)
        {
            verydifficult_count++;
            current_cardid = DatabaseControl.GetCardIDFromQuestion(current_question);
            DatabaseControl.AddCardScore(current_cardid, 0, 0, 0, 0, 1);
            DatabaseControl.AddCalculatedCardScore(DatabaseControl.GetCardIDFromQuestion(current_question));

            if (folder_app.cards.Count == 0)
            {
                UserScore_screen form2 = new UserScore_screen();
                this.Close();
                form2.Show();
                veryeasy_count = 0;
                easy_count = 0;
                okay_count = 0;
                difficult_count = 0;
                verydifficult_count = 0;

            }
            else
            {
                Revise_Question_Screen form = new Revise_Question_Screen();
                this.Close();
                form.Show();

            }


        }

        private void difficult_button_Click(object sender, EventArgs e)
        {

            difficult_count++;
            current_cardid = DatabaseControl.GetCardIDFromQuestion(current_question);
            DatabaseControl.AddCardScore(current_cardid, 0, 0, 0, 1, 0);
            DatabaseControl.AddCalculatedCardScore(DatabaseControl.GetCardIDFromQuestion(current_question));
            if (folder_app.cards.Count == 0)
            {
                UserScore_screen form2 = new UserScore_screen();
                this.Close();
                form2.Show();
                veryeasy_count = 0;
                easy_count = 0;
                okay_count = 0;
                difficult_count = 0;
                verydifficult_count = 0;
            }
            else
            {
                Revise_Question_Screen form = new Revise_Question_Screen();
                this.Close();
                form.Show();
            }

        }

        private void okay_button_Click(object sender, EventArgs e)
        {

            okay_count++;
            current_cardid = DatabaseControl.GetCardIDFromQuestion(current_question);
            DatabaseControl.AddCardScore(current_cardid, 0, 0, 1, 0, 0);
            DatabaseControl.AddCalculatedCardScore(current_cardid);
            if (folder_app.cards.Count == 0)
            {
                UserScore_screen form2 = new UserScore_screen();
                this.Close();
                form2.Show();
                veryeasy_count = 0;
                easy_count = 0;
                okay_count = 0;
                difficult_count = 0;
                verydifficult_count = 0;
            }
            else
            {
                Revise_Question_Screen form = new Revise_Question_Screen();
                this.Close();
                form.Show();
            }

        }

        private void easy_button_Click(object sender, EventArgs e)
        {

            easy_count++;
            current_cardid = DatabaseControl.GetCardIDFromQuestion(current_question);
            DatabaseControl.AddCardScore(current_cardid, 0, 1, 0, 0, 0);
            DatabaseControl.AddCalculatedCardScore(DatabaseControl.GetCardIDFromQuestion(current_question));
            if (folder_app.cards.Count == 0)
            {
                UserScore_screen form2 = new UserScore_screen();
                this.Close();
                form2.Show();
                veryeasy_count = 0;
                easy_count = 0;
                okay_count = 0;
                difficult_count = 0;
                verydifficult_count = 0;
            }
            else
            {
                Revise_Question_Screen form = new Revise_Question_Screen();
                this.Close();
                form.Show();
            }

        }

        private void veryeasy_button_Click(object sender, EventArgs e)
        {

            veryeasy_count++;
            current_cardid = DatabaseControl.GetCardIDFromQuestion(current_question);
            DatabaseControl.AddCardScore(current_cardid, 1, 0, 0, 0, 0);
            DatabaseControl.AddCalculatedCardScore(DatabaseControl.GetCardIDFromQuestion(current_question));
            if (folder_app.cards.Count == 0)
            {
                UserScore_screen form2 = new UserScore_screen();
                this.Close();
                form2.Show();
                veryeasy_count = 0;
                easy_count = 0;
                okay_count = 0;
                difficult_count = 0;
                verydifficult_count = 0;
            }
            else
            {
                Revise_Question_Screen form = new Revise_Question_Screen();
                this.Close();
                form.Show();
            }
        }

        private void Revise_Answer_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
