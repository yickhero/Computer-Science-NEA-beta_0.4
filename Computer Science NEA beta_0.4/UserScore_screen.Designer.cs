namespace NEA_Computer_Science_BETA_0._3
{
    partial class UserScore_screen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.userscore_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.back_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userscore_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // userscore_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.userscore_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.userscore_chart.Legends.Add(legend1);
            this.userscore_chart.Location = new System.Drawing.Point(0, 0);
            this.userscore_chart.Name = "userscore_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.userscore_chart.Series.Add(series1);
            this.userscore_chart.Size = new System.Drawing.Size(799, 386);
            this.userscore_chart.TabIndex = 0;
            this.userscore_chart.Text = "User Score";
            this.userscore_chart.Click += new System.EventHandler(this.userscore_chart_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(112, 403);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(123, 35);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // continue_button
            // 
            this.continue_button.Location = new System.Drawing.Point(562, 403);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(123, 35);
            this.continue_button.TabIndex = 2;
            this.continue_button.Text = "Continue";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // UserScore_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.userscore_chart);
            this.Name = "UserScore_screen";
            this.Text = "UserScore_screen";
            ((System.ComponentModel.ISupportInitialize)(this.userscore_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart userscore_chart;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button continue_button;
    }
}