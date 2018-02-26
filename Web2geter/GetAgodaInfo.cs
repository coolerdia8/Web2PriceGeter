using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web2geter
{
    public class GetAgodaInfo
	{
	    private readonly HttpClient _hc = new HttpClient();
	    LogOutput _logOuput = new LogOutput();
        String hPrice = "None";
		String filename = "None";

	    //価格取得メソッド
        //引数：URL
        public async Task <string> AgodaGetPrice(string tb_html)
		{
			string Sok, Smiss;

			try
			{
				//htmlタグをすべて取得
			    string html = await _hc.GetStringAsync(tb_html);

                //文字抜き出し処理:1st
			    string strT1 = "from: \"";
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
			catch (Exception ex)
			{
				//URLが正しくないとき
				Smiss = "URLが正しくない可能性があります。\r\n入力し直してください。";
			    _logOuput.OutputErrLog(ex);
                return Smiss;
			}
            //ログ出力
		    string okMessage = "GetPrice SUCCESS!\r\n";
            _logOuput.OutputSuccessLog(okMessage);
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
			catch (Exception ex)
			{
				s = "トリムできませんでした。";
			    _logOuput.OutputErrLog(ex);
                return s;
			}
            return s; //戻り値
		}

		//取得日時
		public string GetDay()
		{
			filename = DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss");
		    return filename;
		}

		//文字抜き出し処理: ホテル名
		public string GetHotelName(string html)
		{
			string strTH = "jp/";
			string strBH = "/hotel";
			string strHotel = "";
			strHotel = GetBetweenStrings(strTH, strBH, html);
			return strHotel;
		}

        // 文字抜き出し処理:CheckIN&CheckOut
	    public string GetHotelCheckIO(string html)
	    {
	        string tin = "checkin=";
	        string bin = "&los";
            string sin = "";
	        sin = GetBetweenStrings(tin, bin, html);
            /*
	        var matches = Regex.Matches(html, @"checkin=.+");
	        foreach (var smMatch in matches)
	        {
	            strHotel =
	        }
            */
            return sin;
        }

	    /// <summary>
            /// csv.Fileの保存
            /// </summary>
            /// <param name="day"></param>
        public bool CsvFileSave(string day)
		{
			string csvsave = "Save";
			if (!Directory.Exists(csvsave))
			{
				Directory.CreateDirectory(csvsave);
			}
		    filename = filename.Substring(0, 10);
		    string csvfile = filename + ".csv";
		    string filePath = Path.Combine(csvsave, csvfile);

            try
			{
			    using (var sw = new StreamWriter(filePath, true, Encoding.Default))
			    {
			        sw.Write("{0},{1}\r\n", hPrice, day);
			        sw.Close();
                }
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

        public void UrlSave(string key,string url)
	    {
	        string urlsave = "URLSave";
	        if (!Directory.Exists(urlsave))
	        {
	            Directory.CreateDirectory(urlsave);
	        }

	        string filePath = @"URLSave\HotelInfo.csv";
	        try
	        {
	            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
	            {
	                using (var reader = new StreamReader(stream))
	                using (var writer = new StreamWriter(stream, Encoding.Default))
	                {
	                    string texts = reader.ReadToEnd();
	                    stream.Position = 0;
	                    writer.WriteLine("{0},{1}", key, url);
	                    writer.Write(texts);
	                }
	            }
	        }
	        catch (Exception ex)
	        {
	            MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK,
	                MessageBoxIcon.Error);
	        }
	    }
    }
}