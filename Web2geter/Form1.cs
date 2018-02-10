using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Web2geter
{
	public partial class FormMain : Form
	{
		GetHotelInfo hotelInfo = new GetHotelInfo();
	    readonly Sound _sound = new Sound();

        public class ItemSet
        {
            // DisplayMemberとValueMemberにはプロパティで指定する仕組み
            public String ItemDisp { get; set; }
            public String ItemUrl { get; set; }

            // プロパティをコンストラクタでセット
            public ItemSet(String u, String s)
            {
                ItemDisp = s;
                ItemUrl = u;
            }
        }

        public FormMain()
		{
			InitializeComponent();

		    // ComboBox用データ作成 //ListでOK //IList インターフェイスまたは IListSource インターフェイスを実装する、DataSet または Array などのオブジェクト。
		    List<ItemSet> src = new List<ItemSet>();
		    src.Add(new ItemSet("http", "Number1"));/// 1つでItem１つ分となる
		    //src.Add(new ItemSet(200, "Number2"));
		    //src.Add(new ItemSet(300, "Number3"));

		    // ComboBoxに表示と値をセット
		    comboBox1.DataSource = src;
		    comboBox1.DisplayMember = "ItemDisp";
		    comboBox1.ValueMember = "ItemUrl";

		    // 初期値セット
		    comboBox1.SelectedIndex = 0;
		    //comboBox1_SelectedIndexChanged(null, null);
        }

		public void button1_Click(object sender, EventArgs e)
		{
			Price1.Text = hotelInfo.AgodaGetPrice(tb_html1.Text);
		    day1.Text = hotelInfo.GetDay();
            Name1.Text = hotelInfo.HotelName(tb_html1.Text);
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
			hotelInfo.CsvFileSave(day1.Text);
		}

        private void URLSave_Click(object sender, EventArgs e)
        {
            string uInput = Interaction.InputBox("ホテル名を入力", "URL保存");
            comboBox1.Items.Add(Text = uInput);
        }

        private void URLadd_Click(object sender, EventArgs e)
        {
            ItemSet tmp = ((ItemSet)comboBox1.SelectedItem);//表示名はキャストして取りだす
            tb_html1.Text = tmp.ItemDisp;
        }

     
    }
}