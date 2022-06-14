using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskManege
{
    class FileUtil
    {
        string foldername = "datas";

        /// <summary>
        /// ファイルを1行ずつ読み込み,ファイルが存在しない場合は空のファイルを作成する
        /// </summary>
        /// <param name="filename">ファイル名</param>
        /// <returns>ファイルの文字列の配列 List</returns>
        public List<string> ReadFileLine(string filename)
        {
            List<string> list = new List<string>();

            if (ExistsFile(filename))
            {
            }
            else
            {
                CreateFile(filename);
                return list;
            }

            using (StreamReader sr = new StreamReader(foldername + "\\" + filename + ".txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = "";
                // 1個飛ばしになっているので、なんとかする
                while((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            return list;
        }

        /// <summary>
        /// ファイルを全て読み込み,ファイルが存在しない場合は空のファイルを作成する
        /// </summary>
        /// <param name="filename">ファイル名</param>
        /// <returns>ファイルの文字列 string</returns>
        public string ReadFileAll(string filename)
        {
            if (ExistsFile(filename))
            {
            }
            else
            {
                CreateFile(filename);
                return "";
            }
            using (StreamReader sr = new StreamReader(foldername + "\\" + filename + ".txt", Encoding.GetEncoding("UTF-8")))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        /// ファイルに書き込みを行う 行,ファイルが存在しない場合はスキップ
        /// </summary>
        /// <param name="filename">ファイル名</param>
        /// <param name="filedata">ファイルに書き込むデータ</param>
        /// <param name="overwrite">上書きするかどうか true:上書きしない false:上書きする</param>
        public Boolean WriteFileLine(string filename, List<string> filedata, Boolean overwrite)
        {
            try
            {
                if (!ExistsFile(filename))
                {
                    CreateFile(filename);
                }
                using (StreamWriter writer = new StreamWriter(foldername + "\\" + filename + ".txt", false, Encoding.GetEncoding("UTF-8")))
                {
                    foreach (string item in filedata)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// ファイルに書き込みを行う 全て,ファイルが存在しない場合はファイルを作成してから書き込み
        /// </summary>
        /// <param name="filename">ファイル名</param>
        /// <param name="filedata">ファイルに書き込む文字列</param>
        /// <param name="overwrite">上書きするかどうか true:上書きしない false:上書きする</param>
        public Boolean WriteFileAll(string filename, string filedata, Boolean overwrite)
        {
            try
            {
                if (!ExistsFile(filename))
                {
                    CreateFile(filename);
                }
                using (StreamWriter writer = new StreamWriter(foldername + "\\" + filename + ".txt", false, Encoding.GetEncoding("UTF-8")))
                {
                    writer.Write(filedata);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Boolean ExistsFile(string filename)
        {
            if (System.IO.File.Exists(foldername + "\\" + filename + ".txt"))
            {
                return true;
            }
            else
            {
                return false ;
            }
        }

        /// <summary>
        /// テキストファイルを作成する
        /// </summary>
        /// <param name="filename">ファイル名</param>
        /// <returns>true:正常 false:異常</returns>
        public Boolean CreateFile(string filename)
        {
            try
            {
                if (ExistsFile(filename))
                {
                    return false;
                }
                using (FileStream fx = File.Create(foldername + "\\" + filename + ".txt"))
                {
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
