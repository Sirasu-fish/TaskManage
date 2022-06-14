using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManege.lib
{
    class Setting
    {
        private string filename = "Setting"; // 設定ファイル名
        public Boolean common_mode = true; // ダークモード
        public Boolean menu1_taskshow = true; // タスク表示
        public int menu2_fontsize = 14; // メモ文字サイズ
        public Boolean menu2_memowrap = true; //メモ折り返し
        public Boolean menu2_open1 = true; //menu2 1 開いているか
        public Boolean menu2_open2 = true; //menu2 2 開いているか
        public Boolean menu2_open3 = true; //menu2 3 開いているか
        public int form_x = 698; // フォームサイズ x
        public int form_y = 637; // フォームサイズ y
        public string memo_name1 = ""; //メモファイル名1
        public string memo_name2 = ""; //メモファイル名2
        public string memo_name3 = ""; //メモファイル名3
        public string memo_name4 = ""; //メモファイル名4
        public string memo_name5 = ""; //メモファイル名5
        public int order = 0; //menu2 並び順

        /// <summary>
        /// 設定を読み込む
        /// </summary>
        public Setting()
        {
            FileUtil fu = new FileUtil();
            List<string> list = new List<string>();
            list = fu.ReadFileLine(filename);

            // ダークモード
            if (list.Count > 0)
            {
                if (list[0].Contains("True") || list[0].Contains("False"))
                {
                    common_mode = System.Convert.ToBoolean(list[0]);
                }
                else
                {
                }
            }
            else
            {
            }

            // タスク表示
            if (list.Count > 1)
            {
                if (list[1].Contains("True") || list[1].Contains("False"))
                {
                    menu1_taskshow = System.Convert.ToBoolean(list[1]);
                }
                else
                {
                }
            }
            else
            {
            }

            // メモ文字サイズ
            if (list.Count > 2)
            {
                if (Int32.TryParse(list[2], out int fontsize))
                {
                    menu2_fontsize = fontsize;
                }
                else
                {
                }
            }
            else
            {
            }

            // メモ折り返し
            if (list.Count > 3)
            {
                if (list[3].Contains("True") || list[3].Contains("False"))
                {
                    menu2_memowrap = System.Convert.ToBoolean(list[3]);
                }
                else
                {
                }
            }
            else
            {
            }

            // menu2 1 開いているか
            if (list.Count > 4)
            {
                if (list[4].Contains("True") || list[4].Contains("False"))
                {
                    menu2_open1 = System.Convert.ToBoolean(list[4]);
                }
                else
                {
                }
            }
            else
            {
            }

            // menu2 2 開いているか
            if (list.Count > 5)
            {
                if (list[5].Contains("True") || list[5].Contains("False"))
                {
                    menu2_open2 = System.Convert.ToBoolean(list[5]);
                }
                else
                {
                }
            }
            else
            {
            }

            // menu2 3 開いているか
            if (list.Count > 6)
            {
                if (list[6].Contains("True") || list[6].Contains("False"))
                {
                    menu2_open3 = System.Convert.ToBoolean(list[6]);
                }
                else
                {
                }
            }
            else
            {
            }

            // フォームサイズ x
            if (list.Count > 7)
            {
                if (Int32.TryParse(list[7], out int x))
                {
                    form_x = x;
                }
                else
                {
                }
            }
            else
            {
            }

            // フォームサイズ y
            if (list.Count > 8)
            {
                if (Int32.TryParse(list[8], out int y))
                {
                    form_y = y;
                }
                else
                {
                }
            }
            else
            {
            }

            // メモファイル名1
            if (list.Count > 9)
            {
                if (list[9] != "")
                {
                    memo_name1 = list[9];
                }
            }

            // メモファイル名2
            if (list.Count > 10)
            {
                if (list[10] != "")
                {
                    memo_name2 = list[10];
                }
            }

            // メモファイル名3
            if (list.Count > 11)
            {
                if (list[11] != "")
                {
                    memo_name3 = list[11];
                }
            }

            // メモファイル名4
            if (list.Count > 12)
            {
                if (list[12] != "")
                {
                    memo_name4 = list[12];
                }
            }

            // メモファイル名5
            if (list.Count > 13)
            {
                if (list[13] != "")
                {
                    memo_name1 = list[13];
                }
            }

            if (list.Count > 14)
            {
                if (Int32.TryParse(list[14], out int o))
                {
                    if (o == 123 || o == 132 || o == 213 || o == 231 || o == 312 || o == 321)
                    {
                        order = o;
                    }
                    order = 123;
                }
                order = 123;
            }

            SaveSetting();
        }

        /// <summary>
        /// 設定を保存
        /// </summary>
        public void SaveSetting()
        {
            List<string> list = new List<string>();
            list.Add(common_mode.ToString());
            list.Add(menu1_taskshow.ToString());
            list.Add(menu2_fontsize.ToString());
            list.Add(menu2_memowrap.ToString());
            list.Add(menu2_open1.ToString());
            list.Add(menu2_open2.ToString());
            list.Add(menu2_open3.ToString());
            list.Add(form_x.ToString());
            list.Add(form_y.ToString());
            list.Add(memo_name1);
            list.Add(memo_name2);
            list.Add(memo_name3);
            list.Add(memo_name4);
            list.Add(memo_name5);
            list.Add(order.ToString());

            FileUtil fu = new FileUtil();
            fu.WriteFileLine(filename, list, false, true);
        }
    }
}
