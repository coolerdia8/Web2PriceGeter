using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Web2geter
{
    public partial class FormMain : Form
	{
	    readonly GetAgodaInfo _agodaInfo = new GetAgodaInfo();
        readonly FileSave _file = new FileSave();
	    readonly Sound _sound = new Sound();

        public FormMain()
	    {
	        InitializeComponent();
	    }

	    public class HotelUrlInfo
	    {
	        // URL用
	        public string HotelName { get; set; }
	        public string HotelURL { get; set; }

            // プロパティをコンストラクタでセット
            public HotelUrlInfo(String s, String u)
	        {
	            HotelName = s;
	            HotelURL = u;
            }
	    }

	    public void SetUrl2Box()
	    {
	        string filePath = @"URLSave\HotelInfo.csv";
            var hSetUrl = new SetURL(filePath);

	        // List インターフェイスまたは IListSource インターフェイスを実装する、DataSet または Array などのオブジェクト。
            List<HotelUrlInfo> src = new List<HotelUrlInfo>();
            foreach (var obj in hSetUrl.FindAll("http"))
	        {
	           src.Add(new HotelUrlInfo(obj.Key, obj.Value));
	        }
	        // ComboBoxに表示と値をセット
	        comboBox1.DataSource = src;
	        comboBox1.DisplayMember = "HotelName";
	        comboBox1.ValueMember = "HotelURL";
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "取得中...";

            string price = await _agodaInfo.AgodaGetPrice(tb_html1.Text);
            Price1.Text = "\\" + price;

            _sound.PlaySound();
		    _sound.StopSound();
            day1.Text = DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss");

            Name1.Text = _agodaInfo.GetHotelName(tb_html1.Text);
            //_agodaInfo.GetHotelCheckIO;
            _file.CsvFileSave(day1.Text, price.Replace(",", ""));
            toolStripStatusLabel1.Text = "取得完了";
        }

		private void Del1_Click(object sender, EventArgs e)
		{
			Price1.ResetText();
			day1.ResetText();
		    //ClearTextBox(this);
        }

		private void URL_Clear_Click(object sender, EventArgs e)
		{
			tb_html1.ResetText();
		}

		private void Save1_Click(object sender, EventArgs e)
		{
		    if (String.IsNullOrEmpty(day1.Text) || day1.Text == "日時")
		    {
		        MessageBox.Show("まず値段取得してください", "エラー", MessageBoxButtons.OK,
		            MessageBoxIcon.Error);
                return;
		    }
		    _file.CsvFileSave(day1.Text,Price1.Text);
		}

        private void URLSave_Click(object sender, EventArgs e)
        {
            string uInput = Interaction.InputBox("ホテル名を入力", "URL保存");
            _file.UrlSave(uInput, tb_html1.Text);
        }

	    private void URLSet_Click(object sender, EventArgs e)
	    {
	        SetUrl2Box();
        }

        private void URLadd_Click(object sender, EventArgs e)
        {
            HotelUrlInfo tmp = (HotelUrlInfo)comboBox1.SelectedItem;//表示名はキャストして取りだす
            tb_html1.Text = tmp.HotelURL;
        }

        private void GraphBtn_Click(object sender, EventArgs e)
        {
            var graph = new Graph();
            graph.ShowDialog(this);
            graph.Dispose();
            Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            try
            {
                var filesave = new FileSave();
                string filenametest = filesave.GetFileName();
                if (filenametest == "")
                {
                    return;
                }

                var sort = new SortPrice().ReadPriceInfos(filenametest);

                string smin = sort.Min(n => n.HotelPrice).ToString();
                string smax = sort.Max(n => n.HotelPrice).ToString();

                //値を書き込み　ファイル名:x 値を:y　にする。
                filesave.PriceMinMaxSave(smin, smax, filenametest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new LogOutput().ToOpenLog();
        }

	    /// <summary>
	    ///     指定したコントロール内に含まれる TextBox の Text をクリアします。</summary>
	    /// <param name="hParent">
	    ///     検索対象となる親コントロール。</param>
	    /// --------------------------------------------------------------------------------
	    public static void ClearTextBox(Control hParent)
	    {
	        // hParent 内のすべてのコントロールを列挙する
	        foreach (Control cControl in hParent.Controls)
	        {
	            // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
	            if (cControl.HasChildren == true)
	            {
	                ClearTextBox(cControl);
	            }

	            // コントロールの型が TextBoxBase からの派生型の場合は Text をクリアする
	            if (cControl is TextBoxBase)
	            {
	                cControl.Text = string.Empty;
	            }
	        }
	    }
    }
}