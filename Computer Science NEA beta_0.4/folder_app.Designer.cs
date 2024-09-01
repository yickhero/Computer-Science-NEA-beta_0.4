namespace NEA_Computer_Science_BETA_0._3
{
    partial class folder_app
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createcards_button = new System.Windows.Forms.Button();
            this.cards_datagridview = new System.Windows.Forms.DataGridView();
            this.revise_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.foldername_label = new System.Windows.Forms.Label();
            this.foldertype_label = new System.Windows.Forms.Label();
            this.tags_label = new System.Windows.Forms.Label();
            this.folderid_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.port_label = new System.Windows.Forms.Label();
            this.host_label = new System.Windows.Forms.Label();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.host_textbox = new System.Windows.Forms.TextBox();
            this.chat_label = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.textstatus_textbox = new System.Windows.Forms.TextBox();
            this.cardsperround_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cards_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // createcards_button
            // 
            this.createcards_button.Location = new System.Drawing.Point(603, 33);
            this.createcards_button.Name = "createcards_button";
            this.createcards_button.Size = new System.Drawing.Size(96, 36);
            this.createcards_button.TabIndex = 0;
            this.createcards_button.Text = "Create Cards";
            this.createcards_button.UseVisualStyleBackColor = true;
            this.createcards_button.Click += new System.EventHandler(this.createcards_button_Click);
            // 
            // cards_datagridview
            // 
            this.cards_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cards_datagridview.Location = new System.Drawing.Point(119, 86);
            this.cards_datagridview.Name = "cards_datagridview";
            this.cards_datagridview.RowHeadersWidth = 51;
            this.cards_datagridview.RowTemplate.Height = 27;
            this.cards_datagridview.Size = new System.Drawing.Size(619, 311);
            this.cards_datagridview.TabIndex = 1;
            // 
            // revise_button
            // 
            this.revise_button.Location = new System.Drawing.Point(612, 403);
            this.revise_button.Name = "revise_button";
            this.revise_button.Size = new System.Drawing.Size(96, 46);
            this.revise_button.TabIndex = 2;
            this.revise_button.Text = "Revise";
            this.revise_button.UseVisualStyleBackColor = true;
            this.revise_button.Click += new System.EventHandler(this.revise_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(152, 403);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(101, 46);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // foldername_label
            // 
            this.foldername_label.AutoSize = true;
            this.foldername_label.Location = new System.Drawing.Point(12, 9);
            this.foldername_label.Name = "foldername_label";
            this.foldername_label.Size = new System.Drawing.Size(81, 15);
            this.foldername_label.TabIndex = 4;
            this.foldername_label.Text = "Folder Name";
            // 
            // foldertype_label
            // 
            this.foldertype_label.AutoSize = true;
            this.foldertype_label.Location = new System.Drawing.Point(12, 33);
            this.foldertype_label.Name = "foldertype_label";
            this.foldertype_label.Size = new System.Drawing.Size(77, 15);
            this.foldertype_label.TabIndex = 5;
            this.foldertype_label.Text = "Folder Type";
            // 
            // tags_label
            // 
            this.tags_label.AutoSize = true;
            this.tags_label.Location = new System.Drawing.Point(12, 54);
            this.tags_label.Name = "tags_label";
            this.tags_label.Size = new System.Drawing.Size(34, 15);
            this.tags_label.TabIndex = 6;
            this.tags_label.Text = "Tags";
            // 
            // folderid_label
            // 
            this.folderid_label.AutoSize = true;
            this.folderid_label.Location = new System.Drawing.Point(675, 9);
            this.folderid_label.Name = "folderid_label";
            this.folderid_label.Size = new System.Drawing.Size(63, 15);
            this.folderid_label.TabIndex = 7;
            this.folderid_label.Text = "Folder ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Server_Start_app";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(983, 16);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(65, 26);
            this.connect_button.TabIndex = 29;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click_1);
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(830, 40);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(35, 15);
            this.port_label.TabIndex = 28;
            this.port_label.Text = "Port:";
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Location = new System.Drawing.Point(828, 7);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(37, 15);
            this.host_label.TabIndex = 27;
            this.host_label.Text = "Host:";
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(877, 32);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(100, 25);
            this.port_textbox.TabIndex = 26;
            this.port_textbox.Text = "8910";
            // 
            // host_textbox
            // 
            this.host_textbox.Location = new System.Drawing.Point(877, 1);
            this.host_textbox.Name = "host_textbox";
            this.host_textbox.Size = new System.Drawing.Size(100, 25);
            this.host_textbox.TabIndex = 25;
            this.host_textbox.Text = "127.0.0.1";
            // 
            // chat_label
            // 
            this.chat_label.AutoSize = true;
            this.chat_label.Location = new System.Drawing.Point(757, 66);
            this.chat_label.Name = "chat_label";
            this.chat_label.Size = new System.Drawing.Size(37, 15);
            this.chat_label.TabIndex = 24;
            this.chat_label.Text = "Chat:";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(973, 419);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 23;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click_1);
            // 
            // message_textbox
            // 
            this.message_textbox.Location = new System.Drawing.Point(794, 374);
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.Size = new System.Drawing.Size(254, 39);
            this.message_textbox.TabIndex = 22;
            // 
            // textstatus_textbox
            // 
            this.textstatus_textbox.Location = new System.Drawing.Point(794, 63);
            this.textstatus_textbox.Multiline = true;
            this.textstatus_textbox.Name = "textstatus_textbox";
            this.textstatus_textbox.Size = new System.Drawing.Size(254, 304);
            this.textstatus_textbox.TabIndex = 21;
            // 
            // cardsperround_combobox
            // 
            this.cardsperround_combobox.FormattingEnabled = true;
            this.cardsperround_combobox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "ALL"});
            this.cardsperround_combobox.Location = new System.Drawing.Point(2, 281);
            this.cardsperround_combobox.Name = "cardsperround_combobox";
            this.cardsperround_combobox.Size = new System.Drawing.Size(111, 23);
            this.cardsperround_combobox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cards Per Round";
            // 
            // folder_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardsperround_combobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.host_label);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.host_textbox);
            this.Controls.Add(this.chat_label);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_textbox);
            this.Controls.Add(this.textstatus_textbox);
            this.Controls.Add(this.folderid_label);
            this.Controls.Add(this.tags_label);
            this.Controls.Add(this.foldertype_label);
            this.Controls.Add(this.foldername_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.revise_button);
            this.Controls.Add(this.cards_datagridview);
            this.Controls.Add(this.createcards_button);
            this.Name = "folder_app";
            this.Text = "folder_app";
            this.Load += new System.EventHandler(this.folder_app_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cards_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createcards_button;
        private System.Windows.Forms.DataGridView cards_datagridview;
        private System.Windows.Forms.Button revise_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label foldername_label;
        private System.Windows.Forms.Label foldertype_label;
        private System.Windows.Forms.Label tags_label;
        private System.Windows.Forms.Label folderid_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label host_label;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.TextBox host_textbox;
        private System.Windows.Forms.Label chat_label;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.TextBox textstatus_textbox;
        private System.Windows.Forms.ComboBox cardsperround_combobox;
        private System.Windows.Forms.Label label1;
    }
}