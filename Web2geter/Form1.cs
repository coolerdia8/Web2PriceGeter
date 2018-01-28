using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Web2geter
{
	public partial class form_Main : Form
	{
		//WebClient型のインスタンス化
		WebClient wc = new WebClient();

		public form_Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//例外処理
			try
			{
				//OpenReadメソッドでリソースを取得するためのStreamインスタンスを作成
				using (Stream st = wc.OpenRead(tb_html.Text))
				{
					//StreamReaderクラスのインスタンスを作成（ストリームとエンコーディングを指定）
					using (StreamReader sr = new StreamReader(st, Encoding.UTF8))
					{
						//htmlタグをすべて取得
						string html = sr.ReadToEnd();
						//rtb_Mainのテキストに代入
						Price1.Text = html;
					}
				}
			}
			catch (Exception)
			{
				//URLが正しくないとき
				Price1.Text = "URLが正しくない可能性があります。\r\n入力し直してください。";
			}
		}

		private void Del1_Click(object sender, EventArgs e)
		{

		}
	}
}
