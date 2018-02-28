using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Web2geter
{
    // クラス
    public class SetURL {
        private Dictionary<string, string> _dict;
        //
        // コンストラクタ
        public SetURL(string filePath) {
            _dict = File.ReadLines(filePath,Encoding.Default).Select(line => line.Split(',')).ToDictionary(x => x[0], x => x[1]); ;
        }

        public IEnumerable<KeyValuePair<string, string>> FindAll(string subs)
        {
            foreach (var item in _dict)
            {
                if (item.Value.Contains(subs))
                    yield return item;
            }
        }
    }
}