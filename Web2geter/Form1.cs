using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Web2geter
{
	public partial class form_Main : Form
	{
		String filename = "None";
		String hPrice = "None";

		public form_Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Price1.Text = AgodaGetPrice(tb_html1.Text);
			filename = DateTime.Now.ToString("s");//取得日時
			filename = filename.Replace("T", ",");
			day1.Text = filename;
		}

		//価格取得メソッド
		//引数：URL
		public string AgodaGetPrice(string tb_html)
		{
			string Sok;
			string Smiss;

			//WebClient型のインスタンス化
			WebClient wc = new WebClient();

			try
			{
				//OpenReadメソッドでリソースを取得するためのStreamインスタンスを作成
				using (Stream st = wc.OpenRead(tb_html))
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
							Smiss = "Miss!\r\n入力し直してください。";
							return Smiss;
						}
						
						hPrice = strTrim.Replace(",","");
						Sok = "\\" + strTrim;
						
					}
				}
			}
			catch (Exception)
			{
				//URLが正しくないとき
				Smiss = "URLが正しくない可能性があります。\r\n入力し直してください。";
				return Smiss;
			}

			return Sok;
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

		/// <summary>
		/// csv.Fileの保存
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void Del1_Click(object sender, EventArgs e)
		{
			Price1.Text = "";
		}

		private void URL_Clear_Click(object sender, EventArgs e)
		{
			tb_html1.Text = "";
		}

		private void Save1_Click(object sender, EventArgs e)
		{
			string S = "Save";
			if (!Directory.Exists(S)){
				Directory.CreateDirectory(S);
			}
			try
			{
				filename = filename.Substring(0, 10);
				string csvfile = filename + ".csv";
				string filePath = Path.Combine(S, csvfile);
				
				StreamWriter sw = null;
				sw = new StreamWriter(filePath, true, Encoding.Default);//Encoding.ASCII
				sw.Write("{0},{1}\r\n", hPrice, day1);
				sw.Close();

				MessageBox.Show("完了", "完了。", MessageBoxButtons.OK,
					MessageBoxIcon.None);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー",MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}
}
