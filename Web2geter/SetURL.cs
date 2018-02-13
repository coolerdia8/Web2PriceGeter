using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Web2geter
{
    // クラス
    public class SetURL {
        private Dictionary<string, string> _dict = new Dictionary<string, string>();
        //
        // コンストラクタ
        public SetURL(string filePath) {
            var lines = File.ReadAllLines(filePath);
            _dict = lines.Select(line => line.Split(',')).ToDictionary(x => x[0], x => x[1]);
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