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

        public class ItemSet
        {
            // DisplayMemberとValueMemberにはプロパティで指定する仕組み
            public String ItemDisp { get; set; }
            public String ItemUrl { get; set; }

            // プロパティをコンストラクタでセット
            public ItemSet(String s, String u)
            {
                ItemDisp = s;
                ItemUrl = u;
            }
        }

	    public void SetUrl2Box()
	    {
	        var hSetUrl = new SetURL("HotelInfo.csv");
	        var setUrldDictionary = hSetUrl.SetUrldDictionary();

	        // List インターフェイスまたは IListSource インターフェイスを実装する、DataSet または Array などのオブジェクト。
            List<ItemSet> src = new List<ItemSet>();
            foreach (var obj in setUrldDictionary)
	        {
	           src.Add(new ItemSet(obj.Key, obj.Value));
	        }
	        // ComboBoxに表示と値をセット
	        comboBox1.DataSource = src;
	        comboBox1.DisplayMember = "ItemDisp";
	        comboBox1.ValueMember = "ItemUrl";
        }

        public void button1_Click(object sender, EventArgs e)
		{
			Price1.Text = _agodaInfo.AgodaGetPrice(tb_html1.Text);
		    day1.Text = _agodaInfo.GetDay();
            Name1.Text = _agodaInfo.HotelName(tb_html1.Text);
            _sound.PlaySound();
		    _sound.StopSound();
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
        }

	    private void URLSet_Click(object sender, EventArgs e)
	    {
	        SetUrl2Box();
	        
            //MessageBox
        }

        private void URLadd_Click(object sender, EventArgs e)
        {
            ItemSet tmp = (ItemSet)comboBox1.SelectedItem;//表示名はキャストして取りだす
            tb_html1.Text = tmp.ItemUrl;
        }

        
    }
}