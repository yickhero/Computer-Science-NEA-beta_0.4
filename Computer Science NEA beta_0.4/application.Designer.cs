namespace NEA_Computer_Science_BETA_0._3
{
    partial class application
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
            this.components = new System.ComponentModel.Container();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.addfolder_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.folders_datagridview = new System.Windows.Forms.DataGridView();
            this.username_label = new System.Windows.Forms.Label();
            this.userid_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.textstatus_textbox = new System.Windows.Forms.TextBox();
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.chat_label = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.port_label = new System.Windows.Forms.Label();
            this.host_label = new System.Windows.Forms.Label();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.host_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.folders_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // search_textbox
            // 
            this.search_textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.search_textbox.Location = new System.Drawing.Point(155, 40);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(319, 25);
            this.search_textbox.TabIndex = 0;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // addfolder_button
            // 
            this.addfolder_button.Location = new System.Drawing.Point(631, 29);
            this.addfolder_button.Name = "addfolder_button";
            this.addfolder_button.Size = new System.Drawing.Size(70, 42);
            this.addfolder_button.TabIndex = 1;
            this.addfolder_button.Text = "Add Folder";
            this.addfolder_button.UseVisualStyleBackColor = true;
            this.addfolder_button.Click += new System.EventHandler(this.addfolder_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // folders_datagridview
            // 
            this.folders_datagridview.AllowUserToAddRows = false;
            this.folders_datagridview.AllowUserToDeleteRows = false;
            this.folders_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.folders_datagridview.Location = new System.Drawing.Point(49, 71);
            this.folders_datagridview.MultiSelect = false;
            this.folders_datagridview.Name = "folders_datagridview";
            this.folders_datagridview.ReadOnly = true;
            this.folders_datagridview.RowHeadersWidth = 51;
            this.folders_datagridview.RowTemplate.Height = 27;
            this.folders_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.folders_datagridview.Size = new System.Drawing.Size(695, 367);
            this.folders_datagridview.TabIndex = 5;
            this.folders_datagridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folders_datagridview_CellContentDoubleClick);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(0, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(63, 15);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "Username";
            // 
            // userid_label
            // 
            this.userid_label.AutoSize = true;
            this.userid_label.Location = new System.Drawing.Point(0, 15);
            this.userid_label.Name = "userid_label";
            this.userid_label.Size = new System.Drawing.Size(48, 15);
            this.userid_label.TabIndex = 7;
            this.userid_label.Text = "UserID";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(0, 30);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 15);
            this.email_label.TabIndex = 8;
            this.email_label.Text = "Email";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(480, 48);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 9;
            this.refresh_button.Text = "refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // textstatus_textbox
            // 
            this.textstatus_textbox.Location = new System.Drawing.Point(787, 71);
            this.textstatus_textbox.Multiline = true;
            this.textstatus_textbox.Name = "textstatus_textbox";
            this.textstatus_textbox.Size = new System.Drawing.Size(254, 304);
            this.textstatus_textbox.TabIndex = 11;
            // 
            // message_textbox
            // 
            this.message_textbox.Location = new System.Drawing.Point(787, 382);
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.Size = new System.Drawing.Size(254, 39);
            this.message_textbox.TabIndex = 12;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(966, 427);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 13;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // chat_label
            // 
            this.chat_label.AutoSize = true;
            this.chat_label.Location = new System.Drawing.Point(750, 74);
            this.chat_label.Name = "chat_label";
            this.chat_label.Size = new System.Drawing.Size(37, 15);
            this.chat_label.TabIndex = 14;
            this.chat_label.Text = "Chat:";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(976, 24);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(65, 26);
            this.connect_button.TabIndex = 19;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(823, 48);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(35, 15);
            this.port_label.TabIndex = 18;
            this.port_label.Text = "Port:";
            this.port_label.Click += new System.EventHandler(this.port_label_Click);
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Location = new System.Drawing.Point(821, 15);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(37, 15);
            this.host_label.TabIndex = 17;
            this.host_label.Text = "Host:";
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(870, 40);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(100, 25);
            this.port_textbox.TabIndex = 16;
            this.port_textbox.Text = "8910";
            // 
            // host_textbox
            // 
            this.host_textbox.Location = new System.Drawing.Point(870, 9);
            this.host_textbox.Name = "host_textbox";
            this.host_textbox.Size = new System.Drawing.Size(100, 25);
            this.host_textbox.TabIndex = 15;
            this.host_textbox.Text = "127.0.0.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Server_Start_app";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 450);
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
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.userid_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.folders_datagridview);
            this.Controls.Add(this.addfolder_button);
            this.Controls.Add(this.search_textbox);
            this.Name = "application";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folders_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button addfolder_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView folders_datagridview;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label userid_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.TextBox textstatus_textbox;
        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label chat_label;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label host_label;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.TextBox host_textbox;
        private System.Windows.Forms.Button button1;
    }
}