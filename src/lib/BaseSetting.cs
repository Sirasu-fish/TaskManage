using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManage;

namespace TaskManage.lib
{
    //設定を別ファイルに持ち、参照する
    class BaseSetting
    {
        static public Dictionary<string, string> setting = new Dictionary<string, string>();

        public BaseSetting()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location + "/../config/";
            string extension = "cfg";

            FileUtil fu = new FileUtil();
            List<string> lines = new List<string>();

            string name_pattern = "name=\"*?\"";
            string value_pattern = "value=\"*?\"";

            // フォルダ内のファイル名を取得
            List<string> files = new List<string>();
            files.AddRange(System.IO.Directory.GetFiles(path, "*." + extension, System.IO.SearchOption.AllDirectories));

            // 全ファイルの行を読み込み
            foreach (string file in files)
            {
                Debug.WriteLine("filename:" + file);
                lines.AddRange(fu.ReadFileLine(file));
                Debug.WriteLine("file99");
            }

            Debug.WriteLine("test3");

            foreach (string line in lines)
            {
                string tmpstr = System.Text.RegularExpressions.Regex.Match(line, name_pattern).Value;
                Debug.WriteLine("tmpstr1:" + tmpstr);
                string name = tmpstr.Substring(6, tmpstr.Length - 1); // name="***" -> ***
                tmpstr = System.Text.RegularExpressions.Regex.Match(line, value_pattern).Value;
                Debug.WriteLine("tmpstr2:" + tmpstr);
                string value = tmpstr.Substring(7, tmpstr.Length - 1); // value="***" -> ***
                setting.Add(name, value);
            }

        }
    }
}
