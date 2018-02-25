using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Web2geter
{
    class LogOutput
    {
        private readonly GetFilePath _filePath = new GetFilePath();
        private string filePath = "log";
        private string extension = ".txt";
        /**
        *  エラー調査用ログ出力
        *  @param ex catchしたエラー内容
        */
        public void OutputErrLog(Exception ex)
        {
            // 書き込み設定
            StreamWriter sw = new StreamWriter(
                _filePath.MakeFilePath(filePath) + "\\" + DateTime.Now.ToString("yyyyMMdd") + extension,   // 出力先ファイル名
                true, Encoding.GetEncoding("Shift_JIS"));                                        // 追加書き込み

            // ログ出力
            Console.SetOut(sw); // 出力先（Outプロパティ）を設定
            Console.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] message: " + ex.Message);
            Console.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] stack trace: " + ex.StackTrace);
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine();

            // ファイルを閉じる
            sw.Dispose();
        }

        public void OutputSuccessLog(string message)
        {
            File.AppendAllText(_filePath.MakeFilePath(filePath) + "\\" + DateTime.Now.ToString("yyyyMMdd") + extension,
                "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] "+ message );
        }

        public void ToOpenLog()
        {
            Process.Start("notepad.exe", _filePath.MakeFilePath(filePath) + "\\" + DateTime.Now.ToString("yyyyMMdd") + extension);
        }
        // catchの中に書いて完成！
        // try {
        //     …
        // }catch(Exception ex) {
        //     OutputErrLog(ex);
        // }


    }
}
