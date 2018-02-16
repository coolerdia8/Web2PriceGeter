using System;
using System.IO;
using System.Text;

namespace Web2geter
{
    class LogOutput
    {
        /**
 *  エラー調査用ログ出力
 *  @param ex catchしたエラー内容
 */
        public void OutputErrLog(Exception ex)
        {
            string filePath = @"C:\Users\Y.KATO\source\repos\Web2geter\log\";
            // 書き込み設定
            StreamWriter sw = new StreamWriter(
                filePath + DateTime.Now.ToString("yyyyMMdd") + ".txt",   // 出力先ファイル名
                true,                                                           // 追加書き込み
                Encoding.GetEncoding("Shift_JIS"));                 // 文字コード

            // ログ出力
            Console.SetOut(sw); // 出力先（Outプロパティ）を設定
            Console.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] message: " + ex.Message);
            Console.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] stack trace: " + ex.StackTrace);
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine();

            // ファイルを閉じる
            sw.Dispose();
        }

        // catchの中に書いて完成！
        // try {
        //     …
        // }catch(Exception ex) {
        //     OutputErrLog(ex);
        // }


    }
}
