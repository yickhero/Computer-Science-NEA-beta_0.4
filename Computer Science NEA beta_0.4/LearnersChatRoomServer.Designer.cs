namespace NEA_Computer_Science_BETA_0._3
{
    partial class LearnersChatRoomServer
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
            this.port_label = new System.Windows.Forms.Label();
            this.host_label = new System.Windows.Forms.Label();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.host_textbox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.textstatus_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(183, 15);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(35, 15);
            this.port_label.TabIndex = 10;
            this.port_label.Text = "Port:";
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Location = new System.Drawing.Point(30, 15);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(37, 15);
            this.host_label.TabIndex = 9;
            this.host_label.Text = "Host:";
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(230, 12);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(100, 25);
            this.port_textbox.TabIndex = 8;
            this.port_textbox.Text = "8910";
            // 
            // host_textbox
            // 
            this.host_textbox.Location = new System.Drawing.Point(73, 12);
            this.host_textbox.Name = "host_textbox";
            this.host_textbox.Size = new System.Drawing.Size(100, 25);
            this.host_textbox.TabIndex = 7;
            this.host_textbox.Text = "127.0.0.1";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(336, 15);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 11;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(417, 15);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 12;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // textstatus_textbox
            // 
            this.textstatus_textbox.Location = new System.Drawing.Point(33, 44);
            this.textstatus_textbox.Multiline = true;
            this.textstatus_textbox.Name = "textstatus_textbox";
            this.textstatus_textbox.Size = new System.Drawing.Size(459, 184);
            this.textstatus_textbox.TabIndex = 13;
            this.textstatus_textbox.TextChanged += new System.EventHandler(this.textstatus_textbox_TextChanged);
            // 
            // LearnersChatRoomServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 247);
            this.Controls.Add(this.textstatus_textbox);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.host_label);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.host_textbox);
            this.Name = "LearnersChatRoomServer";
            this.Text = "LearnersChatRoomServer";
            this.Load += new System.EventHandler(this.LearnersChatRoomServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label host_label;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.TextBox host_textbox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.TextBox textstatus_textbox;
    }
}