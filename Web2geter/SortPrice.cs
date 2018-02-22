using System.Collections.Generic;
using System.IO;

namespace Web2geter
{
    class SortPrice
    {
        private IEnumerable<HotelPriceInfo> _hotelPriceInfos;

        // コンストラクタ
        public SortPrice(string filePath)
        {
            //ReadPriceInfos(filePath);
            _hotelPriceInfos = ReadPriceInfos(filePath);
        }

        // 売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<HotelPriceInfo> ReadPriceInfos(string filePath)
        {
            var hotelInfos = new List<HotelPriceInfo>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var items = line.Split(',');
                var hotelPriceInfo = new HotelPriceInfo
                {
                    HotelPrice = int.Parse(items[0]),
                    HotelGetdate = items[1],
                    //HighPrice = items[2]
                };
                hotelInfos.Add(hotelPriceInfo);
            }
            return hotelInfos;
        }
    }
}
