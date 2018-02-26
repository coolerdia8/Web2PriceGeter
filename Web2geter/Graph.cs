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

            // 1.Seriesの追加
            chart1.Series.Clear();

            // グラフの表示
            DispChart();
        }

        // "グラフ表示関数"
        public void DispChart()
        {
            string low = "min";
            string high = "max";

            // 2.グラフのタイプの設定
            chart1.Series.Add(low);
            chart1.Series.Add(high);
            chart1.Series[low].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series[high].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

            string filePath = @"Save\PriceMin&Max.csv";
            var infos = new Price2Graph().ReadPrice2GraphInfos(filePath);

            //グラフのデータを追加(リストからデータのある箇所だけ)
            foreach (var graph in infos)
            {
                chart1.Series[low].Points.AddXY(graph.HotelGetdate, graph.LowPrice);
                chart1.Series[high].Points.AddXY(graph.HotelGetdate, graph.HighPrice);
            }
            chart1.BorderWidth = 3;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}