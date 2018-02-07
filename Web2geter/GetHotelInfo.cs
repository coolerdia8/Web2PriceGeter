using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Web2geter
{
	public class GetHotelInfo
	{
		String hPrice = "None";
		String filename = "None";
		
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

						hPrice = strTrim.Replace(",", "");
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
            string s = ""; //返す文字列(トリムされた文字)

            //例外処理
            try
			{
                int str1Len = str1.Length; //str1の長さ
                int str1Num = orgStr.IndexOf(str1); //str1が原文のどの位置にあるか
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

		//取得日時
		public string GetDay()
		{
			string date = DateTime.Now.ToString("s");
			date = date.Replace("T", ",");
			filename = date;
			return date;
		}

		//文字抜き出し処理: ホテル名
		public string HotelName(string html)
		{			
			string strTH = "jp/";
			string strBH = "/hotel";
			string strHotel = "";
			strHotel = GetBetweenStrings(strTH, strBH, html);
			return strHotel;
		}

		/// <summary>
		/// csv.Fileの保存
		/// </summary>
		/// <param name="day"></param>
		public bool CsvFileSave(string day)
		{
			string s = "Save";
			if (!Directory.Exists(s))
			{
				Directory.CreateDirectory(s);
			}
			try
			{
				filename = filename.Substring(0, 10);
				string csvfile = filename + ".csv";
				string filePath = Path.Combine(s, csvfile);

			    var sw = new StreamWriter(filePath, true, Encoding.Default);
				sw.Write("{0},{1}\r\n", hPrice, day);
				sw.Close();

				MessageBox.Show("完了", "完了。", MessageBoxButtons.OK,
					MessageBoxIcon.None);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			return true;
		}
	}
}