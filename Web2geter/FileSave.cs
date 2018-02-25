using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Web2geter
{
    class FileSave
    {
        public bool PriceMinMaxSave(string min,string max,string daycsv)
        {
            LogOutput logOuput = new LogOutput();
            string csvsave = "Save";
            if (!Directory.Exists(csvsave))
            {
                Directory.CreateDirectory(csvsave);
            }
            string dayfile = Path.GetFileNameWithoutExtension(daycsv);//2018-02-**.csv
            string filename = "PriceMin&Max.csv";
            string filePath = Path.Combine(csvsave, filename);

            try
            {
                using (var sw = new StreamWriter(filePath, true, Encoding.Default))
                {
                    sw.Write("{0},{1},{2}\r\n", dayfile, min , max );
                    sw.Close();
                }
                string message = "Write_Min/Max_Price SUCCESS!\r\n";
                logOuput.OutputSuccessLog(message);
                MessageBox.Show("保存完了", "完了。", MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return true;
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
