using System.Collections.Generic;
using System.IO;

namespace Web2geter
{
    class Price2Graph
    {
        // 日別の料金データを読み込み、HotelGraphオブジェクトのリストを返す
        public IEnumerable<HotelGraph> ReadPrice2GraphInfos(string filePath)
        {
            var hotelGraphs = new List<HotelGraph>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var items = line.Split(',');
                var HotelGraph = new HotelGraph
                {
                    HotelGetdate = items[0],
                    LowPrice = items[1],
                    HighPrice = items[2]
                };
                hotelGraphs.Add(HotelGraph);
            }
            return hotelGraphs;
        }
    }
}