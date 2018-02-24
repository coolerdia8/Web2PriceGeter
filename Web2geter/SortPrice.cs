using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Web2geter
{
    class SortPrice
    {
        private IEnumerable<HotelPriceInfo> _list;

        // コンストラクタ
        public SortPrice(string filePath)
        {
            //ReadPriceInfos(filePath);
            //_list = File.ReadLines(filePath).Select(line => line.Split(',')).Where(x => x.Length > 5);
        }
#if FALSE
        public IEnumerable<KeyValuePair<string, string>> FindAll(string subs)
        {

            foreach (var item in _list)
            {
                if (item.Value.Contains(subs))
                    yield return item;
            }

         }
#endif

#if FALSE
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
#endif
    }
}
