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
            string LowPrice = "min";
            string HighPrice = "max";

            // 1.Seriesの追加
            chart1.Series.Clear();
            chart1.Series.Add(LowPrice);

            // 2.グラフのタイプの設定
            chart1.Series[LowPrice].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series[LowPrice].Points.AddXY("21", hotelprice);
            chart1.Series[LowPrice].Points.AddXY("22", hotelprice);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
