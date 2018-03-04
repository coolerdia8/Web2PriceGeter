using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Web2geter
{
    class FileSave
    {
        /// <summary> csv.Fileの保存 </summary>
        /// <param name="day"></param>
        public bool CsvFileSave(string day, string hPrice)
        {
            if (hPrice.StartsWith("<!DOCTYPE")) { return false; }
            string csvsave = "Save";
            if (!Directory.Exists(csvsave))
            {
                Directory.CreateDirectory(csvsave);
            }
            string filename = day.Substring(0, 10);
            string csvfile = filename + ".csv";
            string filePath = Path.Combine(csvsave, csvfile);

            try
            {
                using (var sw = new StreamWriter(filePath, true, Encoding.Default))
                {
                    sw.Write("{0},{1}\r\n", hPrice, day);
                }
                MessageBox.Show("完了", "完了。", MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return true;
        }

        public void UrlSave(string key, string url)
        {
            string urlsave = "URLSave";
            if (!Directory.Exists(urlsave))
            {
                Directory.CreateDirectory(urlsave);
            }

            string filePath = @"URLSave\HotelInfo.csv";
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                using (var reader = new StreamReader(stream))
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    string texts = reader.ReadToEnd();
                    stream.Position = 0;
                    writer.WriteLine("{0},{1}", key, url);
                    writer.Write(texts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

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
