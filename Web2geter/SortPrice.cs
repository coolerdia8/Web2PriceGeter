using System.Collections.Generic;
using System.IO;

namespace Web2geter
{
    class SortPrice
    {
        // 日別の料金データを読み込み、HotelPriceInfoオブジェクトのリストを返す
        public IEnumerable<HotelPriceInfo> ReadPriceInfos(string filePath)
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
                    HotelGetTime = items[2]
                };
                hotelInfos.Add(hotelPriceInfo);
            }
            return hotelInfos;
        }

        #if FALSE
        public void SortMinMaxPrice()
        {
            var filesave = new FileSave();
            string filenametest = filesave.GetFileName();
            if (filenametest == "") { return; }

            try
            {
                string smin = File.ReadLines(filenametest).Select(x => int.Parse(x)).Where(n => n > 0).Min().ToString();
                string smax = File.ReadLines(filenametest).Select(x => int.Parse(x)).Where(n => n > 0).Max().ToString();

                //値を書き込み　ファイル名:x 値を:y　にする。
                filesave.PriceMinMaxSave(smin, smax, filenametest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //_logOuput.OutputErrLog(ex);
            }
        }
        #endif

        #if FALSE
        private IEnumerable<HotelPriceInfo> _list;

        // コンストラクタ
        public SortPrice(string filePath)
        {
            //ReadPriceInfos(filePath);
            //_list = File.ReadLines(filePath).Select(line => line.Split(',')).Where(x => x.Length > 5);
        }

        public IEnumerable<KeyValuePair<string, string>> FindAll(string subs)
        {

            foreach (var item in _list)
            {
                if (item.Value.Contains(subs))
                    yield return item;
            }

         }

        public void SortMinMax()
        {
            var filesave = new FileSave();
            string filenametest = filesave.GetFileName();
            if (filenametest == "") { return; }

            File.ReadLines(filenametest).Select(line => line.Split(',')).ToList(x => x[0], x => x[1], x => x[2]);
            //Where(x => x.Length > 5);
        }
        #endif
    }
}
