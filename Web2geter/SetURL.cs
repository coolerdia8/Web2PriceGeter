using System.Collections.Generic;
using System.IO;

namespace Web2geter
{

    // 売り上げ集計クラス
    public class SetURL {
        private IEnumerable<HotelInfo> _hotelInfos;

        // コンストラクタ
        public SetURL(string filePath) {
            _hotelInfos = ReadURLInfos(filePath);
        }

        // 売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<HotelInfo> ReadURLInfos(string filePath) {
            var hotelInfos = new List<HotelInfo>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');
                var hotelinfo = new HotelInfo {
                    HotelName = items[0],
                    HotelURL = items[1]
                };
                hotelInfos.Add(hotelinfo);
            }
            return hotelInfos;
        }

        // 
        public IDictionary<string, string> SetUrldDictionary() {
            var dict = new Dictionary<string, string>();
            foreach (var hInfo in _hotelInfos) {
                
                    dict[hInfo.HotelName] = hInfo.HotelURL;
            }
            return dict;
        }
    }
}