using System.Windows.Forms;

namespace Web2geter
{
    class FileSave
    {
        public void PriceMinMaxSave(string min,string max)
        {

        }

        public string GetFileName()
        {
            string fileName = "";
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "ファイルを開く";
            op.InitialDirectory = @"C:\";
            //op.FileName = @"hoge.txt";
            op.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            op.FilterIndex = 1;

            //オープンファイルダイアログを表示する
            DialogResult result = op.ShowDialog();

            if (result == DialogResult.OK)
            {
                //「開く」ボタンが選択された時の処理
                fileName = op.FileName;  //こんな感じで選択されたファイルのパスが取得できる
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」ボタンまたは「×」ボタンが選択された時の処理
                return fileName;
            }
            return fileName;
        }
    }
}
