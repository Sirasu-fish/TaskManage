using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TaskManage
{
    class FileUtil
    {
        /// <summary>
        /// ファイルを読み込み
        /// </summary>
        /// <param name="path">ファイルのパス</param>
        /// <returns>ファイルの文字列 string</returns>
        public string ReadFileAll(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding("UTF-8")))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// ファイル未保存時メッセージボックス
        /// </summary>
        /// <returns></returns>
        public DialogResult ShowOverrideFileMessage()
        {
            return MessageBox.Show("変更を保存しますか？","確認",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        }

        /// <summary>
        /// ファイルが書き込み可能かチェック
        /// </summary>
        /// <param name="path">ファイルのパス</param>
        /// <returns>true:書き込み可能 false:書き込み不可orファイルが存在しない</returns>
        public Boolean IsAbleWrite(string path)
        {
            try
            {
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// ファイルに書き込み
        /// </summary>
        /// <param name="path">ファイルのパス</param>
        /// <param name="text">書き込み内容</param>
        /// <returns>true:書き込み成功 false:書き込み失敗</returns>
        public Boolean WriteFile(string path, string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.GetEncoding("UTF-8")))
                {
                    writer.Write(text);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 「名前を付けて保存」ダイアログを表示
        /// </summary>
        /// <param name="form">フォーム</param>
        /// <param name="text">書き込み内容</param>
        /// <param name="num">trye:書き込み成功 false:書き込み失敗</param>
        /// <returns></returns>
        public Boolean OpenDialog(MainForm form, string text, int num)
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

            if (sfd.ShowDialog() == DialogResult.OK) // OKを押した時
            {
                System.IO.Stream stream;
                stream = sfd.OpenFile();

                if (stream != null)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.Write(text);
                    sw.Close();
                    stream.Close();

                    string[] path = new string[Main.Common_Const.memo_num];
                    Properties.Settings.Default.memo_path.CopyTo(path, 0);
                    path[num] = sfd.FileName;
                    Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
                    Properties.Settings.Default.memo_path.AddRange(path);

                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Text = path[num];
                    Properties.Settings.Default.Save();
                }
            }
            else // OKを押していない時
            {
                return false;
            }

            return true;
        }
    }
}
