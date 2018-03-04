using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web2geter
{
    public class GetAgodaInfo
	{
	    private static readonly HttpClient Hc = new HttpClient();
	    readonly LogOutput _logOuput = new LogOutput();

	    //価格取得メソッド
        //引数：URL
        public async Task <string> AgodaGetPrice(string tb_html)
		{
		    string agodaPrice;
            string Smiss;

            try
			{
				//htmlタグをすべて取得
			    string html = await Hc.GetStringAsync(tb_html);

                //文字抜き出し処理:1st
			    string strT1 = "from: \"";
			    string strB1 = "\"";
			    //string hPrice = "";
                agodaPrice = GetBetweenStrings(strT1, strB1, html);

				//rtb_Mainのテキストに代入
				if (String.IsNullOrEmpty(agodaPrice))
				{
					Smiss = "Miss!\r\n入力し直してください。";
					return Smiss;
				}
				//hPrice = strTrim.Replace(",", "");
				//Sok = "\\" + strTrim;
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
            return agodaPrice;
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
				//s = "トリムできませんでした。";
			    _logOuput.OutputErrLog(ex);
                return s;
			}
            return s; //戻り値
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
    }
}