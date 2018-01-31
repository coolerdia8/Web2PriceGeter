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
						
						//文字抜き出し処理:1st
						string strT1 = "from: \""; //cheapestPrice:
						string strB1 = "\"";
						string strTrim = "";
						strTrim = GetBetweenStrings(strT1, strB1, html);

						//rtb_Mainのテキストに代入
						if (strTrim == "")
						{
							Price1.Text = "URLからの文字取得に失敗しました。\r\n入力し直してください。";
						}
						else
						{
							Price1.Text = "\\" + strTrim;

							//取得日
							//GetDate1.Items.Clear();
							//GetDate1.Items.Add(DateTime.Now);
						}
					}
				}
			}
			catch (Exception)
			{
				//URLが正しくないとき
				Price1.Text = "URLが正しくない可能性があります。\r\n入力し直してください。";
			}
		}

		//2つの文字列の間の文字列を返すメソッド
		//引数：1つ目の文字、2つ目の文字、原文
		public string GetBetweenStrings(string str1, string str2, string orgStr)
		{
			int orgLen = orgStr.Length; //原文の文字列の長さ
			int str1Len = str1.Length; //str1の長さ

			int str1Num = orgStr.IndexOf(str1); //str1が原文のどの位置にあるか

			string s = ""; //返す文字列(トリムされた文字)

			//例外処理
			try
			{
				s = orgStr.Remove(0, str1Num + str1Len); //原文の初めからstr1のある位置まで削除
				int str2Num = s.IndexOf(str2); //str2がsのどの位置にあるか
				s = s.Remove(str2Num); //sのstr2のある位置から最後まで削除
			}
			catch (Exception)
			{
				s = "トリムできませんでした。";
				return s;
			}

			return s; //戻り値
		}


		private void Del1_Click(object sender, EventArgs e)
		{
			Price1.Text = "";
		}

		private void URL_Clear_Click(object sender, EventArgs e)
		{
			tb_html.Text = "";
		}

		private void Save1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
