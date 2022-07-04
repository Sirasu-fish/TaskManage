using System;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu2_2_events
    {
        // menu2 panel2を開いたり閉じたりする時の動作
        public static void menu2_2_panel_top_button_openclose_Click(MainForm form)
        {
            if (form.menu2_2_panel_main.Visible == false)
            {
                form.menu2_2_panel_main.Visible = true;
                form.menu2_2_panel.Height = 1002;
                form.menu2_2.Height = 1010;
                Properties.Settings.Default.menu2_open2 = true;
            }
            else
            {
                form.menu2_2_panel_main.Visible = false;
                form.menu2_2_panel.Height = 34;
                form.menu2_2.Height = 42;
                Properties.Settings.Default.menu2_open2 = false;
            }
            Properties.Settings.Default.Save();
        }

        // 要素順を入れ替える
        public static void menu2_2_panel_top_button_moveup_Click(MainForm form)
        {
            switch (Properties.Settings.Default.order)
            {
                case 123:
                    Properties.Settings.Default.order = 213;
                    break;
                case 132:
                    Properties.Settings.Default.order = 123;
                    break;
                case 312:
                    Properties.Settings.Default.order = 321;
                    break;
                case 321:
                    Properties.Settings.Default.order = 213;
                    break;
            }

            menu2_events.RefrectMoveControl(form); //要素順反映
        }

        public static void menu2_2_panel_top_button_movedown_Click(MainForm form)
        {
            switch (Properties.Settings.Default.order)
            {
                case 123:
                    Properties.Settings.Default.order = 132;
                    break;
                case 213:
                    Properties.Settings.Default.order = 123;
                    break;
                case 231:
                    Properties.Settings.Default.order = 321;
                    break;
                case 321:
                    Properties.Settings.Default.order = 312;
                    break;
            }

            menu2_events.RefrectMoveControl(form); //要素順反映
        }

        // menu2_2 ファイルを開くダイアログを開く
        public static void menu2_2_panel_top_button_open_Click(MainForm form)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txtファイル(*.txt;*.log;*.oml)|*.txt;*.log;*.oml";
            ofd.FilterIndex = 1;
            ofd.Title = "ファイルを選択してください";
            ofd.RestoreDirectory = true;

            FileUtil fu = new FileUtil();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] path = new string[99];
                Properties.Settings.Default.memo_path.CopyTo(path, 0);
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] == ofd.FileName)
                    {
                        form.menu2_2_panel_main_panel_table_memo_text[i].Text = fu.ReadFileAll(ofd.FileName);
                        break;
                    }
                    if (string.IsNullOrEmpty(path[i]))
                    {
                        form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = ofd.FileName;
                        form.menu2_2_panel_main_panel_table_memo_text[i].Text = fu.ReadFileAll(ofd.FileName);
                        form.menu2_2_panel_main_panel[i].Visible = true;
                        Main.Common_Var.memo_save[i] = true;
                        path[i] = ofd.FileName;
                        Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
                        Properties.Settings.Default.memo_path.AddRange(path);
                        Properties.Settings.Default.Save();
                        break;
                    }
                }
            }
        }

        // メモの追加
        public static void menu2_2_panel_top_button_add_Click(MainForm form)
        {
            FileUtil fu = new FileUtil();
            string filename = "";

            for (int i = 0; i < form.menu2_2_panel_main_panel_table_memo_panel_top_text.Length; i++)
            {
                if (form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text == "")
                {
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = filename + " *";
                    form.menu2_2_panel_main_panel_table_memo_text[i].Text = "";
                    form.menu2_2_panel_main_panel[i].Visible = true;
                    break;
                }
            }
        }

        // キー押下時のイベント
        public static void menu2_2_panel_main_panel_table_memo_text_KeyDown(object sender, MainForm form, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(form, ((TextBox)sender).Text, int.Parse(((TextBox)sender).Name));
            }
        }

        // テキスト変更時イベント
        public static void menu2_2_panel_main_panel_table_memo_text_TextChanged(object sender, MainForm form)
        {
            if (Main.Common_Var.memo_save[int.Parse(((TextBox)sender).Name)] == true)
            {
                form.menu2_2_panel_main_panel_table_memo_panel_top_text[int.Parse(((TextBox)sender).Name)].Text += " *";
                Main.Common_Var.memo_save[int.Parse(((TextBox)sender).Name)] = false;
            }
        }

        //保存ボタン
        public static void menu2_2_panel_main_panel_table_memo_panel_top_button_save_Click(object sender, MainForm form)
        {
            SaveMemo(form, form.menu2_2_panel_main_panel_table_memo_text[int.Parse(((Button)sender).Name)].Text, int.Parse(((Button)sender).Name));
        }

        // 最小化、最大化ボタン
        public static void menu2_2_panel_main_panel_table_memo_panel_top_button_minmax_Click(object sender, MainForm form)
        {
            int i = int.Parse(((Button)sender).Name);
            if (form.menu2_2_panel_main_panel_table_memo_text[i].Visible == false)
            {
                form.menu2_2_panel_main_panel_table_memo_text[i].Visible = true;
                form.menu2_2_panel_main_panel[i].Height = 106;
            }
            else
            {
                form.menu2_2_panel_main_panel_table_memo_text[i].Visible = false;
                form.menu2_2_panel_main_panel[i].Height = 28;
            }
        }

        // 閉じるボタン
        public static void menu2_2_panel_main_panel_table_memo_panel_top_button_close_Click(object sender, MainForm form)
        {
            int i = int.Parse(((Button)sender).Name);

            // 変更したファイルを保存していない時
            if (Main.Common_Var.memo_save[i] == false)
            {
                FileUtil fu = new FileUtil();

                string[] paths = new string[99];
                Properties.Settings.Default.memo_path.CopyTo(paths, 0);
                string save_path = paths[i];

                // パスが空の時 = 新規ファイルなので、名前をつけて保存ダイアログを表示して保存する
                if (String.IsNullOrEmpty(save_path))
                {
                    if (fu.OpenDialog(form, form.menu2_2_panel_main_panel_table_memo_text[i].Text, i))
                    {
                        Main.Common_Var.memo_save[i] = true;
                        form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = Properties.Settings.Default.memo_path[i];
                    }
                    else
                    {
                        return;
                    }
                }
                // パスが空ではない時 = 既存ファイル
                else
                {
                    switch (fu.ShowOverrideFileMessage())
                    {
                        case DialogResult.Yes: // はい
                            if (fu.IsAbleWrite(save_path)) //書き込み可能な時
                            {
                                if (fu.WriteFile(save_path, form.menu2_2_panel_main_panel_table_memo_text[i].Text))
                                {
                                    Main.Common_Var.memo_save[i] = true;
                                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = Properties.Settings.Default.memo_path[i];
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                if (fu.OpenDialog(form, form.menu2_2_panel_main_panel_table_memo_text[i].Text, i))
                                {
                                    Main.Common_Var.memo_save[i] = true;
                                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = Properties.Settings.Default.memo_path[i];
                                }
                                else
                                {
                                    return;
                                }
                            }
                            break;
                        case DialogResult.No: // いいえ
                            break;
                        case DialogResult.Cancel: // キャンセル
                            return;
                    }
                }
            }

            string[] path = new string[99];
            Properties.Settings.Default.memo_path.CopyTo(path, 0);
            path[i] = "";
            Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.memo_path.AddRange(path);
            Properties.Settings.Default.Save();
            form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = "";
            form.menu2_2_panel_main_panel_table_memo_text[i].Text = "";
            form.menu2_2_panel_main_panel[i].Visible = false;
        }

        // private
        #region private

        // メモを保存する時の関数
        private static Boolean SaveMemo(MainForm form, string text, int num)
        {
            FileUtil fu = new FileUtil();

            string[] paths = new string[99];
            Properties.Settings.Default.memo_path.CopyTo(paths, 0);
            string path = paths[num];

            if (!String.IsNullOrEmpty(path) && Main.Common_Var.memo_save[num] == true) // 空じゃないかつ、変更されていない場合は保存する必要がないためスキップ
            {
                return true;
            }

            // パスが空の時 = 新規ファイルなので、名前をつけて保存ダイアログを表示して保存する
            if (String.IsNullOrEmpty(path))
            {
                if (fu.OpenDialog(form, text, num))
                {
                    Main.Common_Var.memo_save[num] = true;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Text = Properties.Settings.Default.memo_path[num];
                }
            }
            // パスが空ではない時 = 既存ファイルなので、上書き保存
            else
            {
                if (fu.WriteFile(path, text))
                {
                    Main.Common_Var.memo_save[num] = true;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Text = Properties.Settings.Default.memo_path[num];
                }
            }

            return true;
        }

        #endregion private
    }
}
