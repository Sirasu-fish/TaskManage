using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TaskManage
{
    class FileUtil
    {
        /// <summary>
        /// ファイルを全て読み込み,ファイルが存在しない場合は空のファイルを作成する
        /// </summary>
        /// <param name="path">パス</param>
        /// <returns>ファイルの文字列 string</returns>
        public string ReadFileAll(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding("UTF-8")))
            {
                return sr.ReadToEnd();
            }
        }

        public Boolean WriteFileLine(string path, string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.GetEncoding("UTF-8")))
                {
                    writer.Write(text);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Boolean OpenDialog(string text, int num)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            // ファイル名で表示される文字列
            sfd.FileName = num.ToString() +  ".txt";
            // ファイルの種類　に表示される選択肢
            sfd.Filter = "TXTファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            // TXTファイル
            sfd.FilterIndex = 1;
            // タイトルを設定する
            sfd.Title = "保存先を設定してください。";
            // ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            // すでに存在するファイル名を指定したとき警告する
            sfd.OverwritePrompt = true;
            // 存在しないパスが指定されたとき警告を表示する
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream stream;
                stream = sfd.OpenFile();

                if (stream != null)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.Write(text);
                    sw.Close();
                    stream.Close();
                    switch (num)
                    {
                        case 1:
                            Properties.Settings.Default.memo_path1 = sfd.FileName;
                            break;
                        case 2:
                            Properties.Settings.Default.memo_path2 = sfd.FileName;
                            break;
                        case 3:
                            Properties.Settings.Default.memo_path3 = sfd.FileName;
                            break;
                        case 4:
                            Properties.Settings.Default.memo_path4 = sfd.FileName;
                            break;
                        case 5:
                            Properties.Settings.Default.memo_path5 = sfd.FileName;
                            break;
                    }
                    Properties.Settings.Default.Save();
                }
            }

            return true;
        }
    }
}
