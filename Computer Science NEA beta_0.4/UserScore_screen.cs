using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NEA_Computer_Science_BETA_0._3
{
    public partial class UserScore_screen : Form
    {
        public UserScore_screen()
        {
            InitializeComponent();
            userscore_chart.Series.Clear();
            userscore_chart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            userscore_chart.ChartAreas.Add(chartArea);
            userscore_chart.ChartAreas[0].AxisY.Interval = 1;
            userscore_chart.ChartAreas[0].AxisY.LabelStyle.IsEndLabelVisible = true;
            userscore_chart.ChartAreas[0].AxisY.LabelStyle.Format = "0";
            userscore_chart.Titles.Add("User Score");
            Series series = new Series();
            series.ChartType = SeriesChartType.Bar;
            series.Points.AddXY("Very Easy", Revise_Answer_Screen.veryeasy_count);
            series.Points.AddXY("Easy", Revise_Answer_Screen.easy_count);
            series.Points.AddXY("Okay", Revise_Answer_Screen.okay_count);
            series.Points.AddXY("Difficult", Revise_Answer_Screen.difficult_count);
            series.Points.AddXY("Very Difficult", Revise_Answer_Screen.verydifficult_count);
            userscore_chart.Series.Add(series);
            DatabaseControl.AddFolderScore(Convert.ToInt32(application.folderid), Revise_Answer_Screen.veryeasy_count, Revise_Answer_Screen.easy_count, Revise_Answer_Screen.okay_count, Revise_Answer_Screen.difficult_count, Revise_Answer_Screen.verydifficult_count);
        }

        private void userscore_chart_Click(object sender, EventArgs e)
        {

        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            folder_app form = new folder_app();
            this.Close();
            form.Show();
        }
    }
}
