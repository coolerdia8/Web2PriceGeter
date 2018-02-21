using System;
using System.Windows.Forms;

namespace Web2geter
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            //画面タイトルの表示
            TitleName.Text = "Hotel";
            int hotelprice = 5000;
            // 1.Seriesの追加
            chart1.Series.Clear();
            chart1.Series.Add("sin");

            // 2.グラフのタイプの設定
            chart1.Series["sin"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["sin"].Points.AddXY("21", hotelprice);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
