using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Web2geter
{
    public partial class FormMain : Form
	{
		GetAgodaInfo _agodaInfo = new GetAgodaInfo();
	    readonly Sound _sound = new Sound();

	    public FormMain()
	    {
	        InitializeComponent();
	    }

	    public class HotelInfo
	    {
	        // 店舗名
	        public string HotelName { get; set; }

	        public string HotelURL { get; set; }

            // プロパティをコンストラクタでセット
            public HotelInfo(String s, String u)
	        {
	            HotelName = s;
	            HotelURL = u;
                //throw new NotImplementedException();
            }
	    }

	    public void SetUrl2Box()
	    {
	        string filePath = @"URLSave\HotelInfo.csv";

            var hSetUrl = new SetURL(filePath);
	        
	        // List インターフェイスまたは IListSource インターフェイスを実装する、DataSet または Array などのオブジェクト。
            List<HotelInfo> src = new List<HotelInfo>();
            foreach (var obj in hSetUrl.FindAll("http"))
	        {
	           src.Add(new HotelInfo(obj.Key, obj.Value));
	        }
	        // ComboBoxに表示と値をセット
	        comboBox1.DataSource = src;
	        comboBox1.DisplayMember = "HotelName";
	        comboBox1.ValueMember = "HotelURL";
        }

        public async void button1_Click(object sender, EventArgs e)
		{
		    Price1.Text = await _agodaInfo.AgodaGetPrice(tb_html1.Text);
		     
            _sound.PlaySound();
		    _sound.StopSound();
            day1.Text = _agodaInfo.GetDay();
            Name1.Text = _agodaInfo.HotelName(tb_html1.Text);
        }

		private void Del1_Click(object sender, EventArgs e)
		{
			Price1.Text = "";
			day1.Text = "";
		}

		private void URL_Clear_Click(object sender, EventArgs e)
		{
			tb_html1.Text = "";
		}

		private void Save1_Click(object sender, EventArgs e)
		{
			_agodaInfo.CsvFileSave(day1.Text);
		}

        private void URLSave_Click(object sender, EventArgs e)
        {
            string uInput = Interaction.InputBox("ホテル名を入力", "URL保存");
            _agodaInfo.UrlSave(uInput, tb_html1.Text);
        }

	    private void URLSet_Click(object sender, EventArgs e)
	    {
	        SetUrl2Box();
            //MessageBox
        }

        private void URLadd_Click(object sender, EventArgs e)
        {
            HotelInfo tmp = (HotelInfo)comboBox1.SelectedItem;//表示名はキャストして取りだす
            tb_html1.Text = tmp.HotelURL;
        }
    }
}