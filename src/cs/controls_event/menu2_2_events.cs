﻿using System;
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

            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        // 新規メモ帳を開く
        public static void menu2_2_panel_top_button_add_Click(MainForm form)
        {
            FileUtil fu = new FileUtil();
            string filename = "";
            filename = DateTime.Now.ToString("yyyyMMdd") + "_";


        }

        // キー押下時のイベント
        public static void menu2_2_panel_main_panel1_table_memo_text_KeyDown(MainForm form, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(form, Properties.Settings.Default.memo_path1, form.menu2_2_panel_main_panel1_table_memo_text.Text, 1);
            }
        }

        public static void menu2_2_panel_main_panel2_table_memo_text_KeyDown(MainForm form, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(form, Properties.Settings.Default.memo_path2, form.menu2_2_panel_main_panel1_table_memo_text.Text, 2);
            }
        }

        public static void menu2_2_panel_main_panel3_table_memo_text_KeyDown(MainForm form, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(form, Properties.Settings.Default.memo_path3, form.menu2_2_panel_main_panel1_table_memo_text.Text, 3);
            }
        }

        public static void menu2_2_panel_main_panel4_table_memo_text_KeyDown(MainForm form, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(form, Properties.Settings.Default.memo_path4, form.menu2_2_panel_main_panel1_table_memo_text.Text, 4);
            }
        }

        public static void menu2_2_panel_main_panel5_table_memo_text_KeyDown(MainForm form, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(form, Properties.Settings.Default.memo_path5, form.menu2_2_panel_main_panel1_table_memo_text.Text, 5);
            }
        }

        //保存ボタン
        public static void menu2_2_panel_main_panel1_table_memo_panel_top_button_save_Click(MainForm form)
        {
            SaveMemo(form, Properties.Settings.Default.memo_path1, form.menu2_2_panel_main_panel1_table_memo_text.Text, 1);
        }
        public static void menu2_2_panel_main_panel2_table_memo_panel_top_button_save_Click(MainForm form)
        {
            SaveMemo(form, Properties.Settings.Default.memo_path2, form.menu2_2_panel_main_panel2_table_memo_text.Text, 2);
        }
        public static void menu2_2_panel_main_panel3_table_memo_panel_top_button_save_Click(MainForm form)
        {
            SaveMemo(form, Properties.Settings.Default.memo_path3, form.menu2_2_panel_main_panel3_table_memo_text.Text, 3);
        }
        public static void menu2_2_panel_main_panel4_table_memo_panel_top_button_save_Click(MainForm form)
        {
            SaveMemo(form, Properties.Settings.Default.memo_path4, form.menu2_2_panel_main_panel4_table_memo_text.Text, 4);
        }
        public static void menu2_2_panel_main_panel5_table_memo_panel_top_button_save_Click(MainForm form)
        {
            SaveMemo(form, Properties.Settings.Default.memo_path5, form.menu2_2_panel_main_panel5_table_memo_text.Text, 5);
        }
        public static void menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax_Click(MainForm form)
        {
            if (form.menu2_2_panel_main_panel1_table_memo_text.Visible == false)
            {
                form.menu2_2_panel_main_panel1_table_memo_text.Visible = true;
                form.menu2_2_panel_main_panel1.Height = 106;
            }
            else
            {
                form.menu2_2_panel_main_panel1_table_memo_text.Visible = false;
                form.menu2_2_panel_main_panel1.Height = 28;
            }
        }
        public static void menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax_Click(MainForm form)
        {
            if (form.menu2_2_panel_main_panel2_table_memo_text.Visible == false)
            {
                form.menu2_2_panel_main_panel2_table_memo_text.Visible = true;
                form.menu2_2_panel_main_panel2.Height = 106;
            }
            else
            {
                form.menu2_2_panel_main_panel2_table_memo_text.Visible = false;
                form.menu2_2_panel_main_panel2.Height = 28;
            }
        }
        public static void menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax_Click(MainForm form)
        {
            if (form.menu2_2_panel_main_panel3_table_memo_text.Visible == false)
            {
                form.menu2_2_panel_main_panel3_table_memo_text.Visible = true;
                form.menu2_2_panel_main_panel3.Height = 106;
            }
            else
            {
                form.menu2_2_panel_main_panel3_table_memo_text.Visible = false;
                form.menu2_2_panel_main_panel3.Height = 28;
            }
        }
        public static void menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax_Click(MainForm form)
        {
            if (form.menu2_2_panel_main_panel4_table_memo_text.Visible == false)
            {
                form.menu2_2_panel_main_panel4_table_memo_text.Visible = true;
                form.menu2_2_panel_main_panel4.Height = 106;
            }
            else
            {
                form.menu2_2_panel_main_panel4_table_memo_text.Visible = false;
                form.menu2_2_panel_main_panel4.Height = 28;
            }
        }
        public static void menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax_Click(MainForm form)
        {
            if (form.menu2_2_panel_main_panel5_table_memo_text.Visible == false)
            {
                form.menu2_2_panel_main_panel5_table_memo_text.Visible = true;
                form.menu2_2_panel_main_panel5.Height = 106;
            }
            else
            {
                form.menu2_2_panel_main_panel5_table_memo_text.Visible = false;
                form.menu2_2_panel_main_panel5.Height = 28;
            }
        }

        // 閉じるボタン
        public static void menu2_2_panel_main_panel1_table_memo_panel_top_button_close_Click(MainForm form)
        {
            Properties.Settings.Default.memo_path1 = "";
            Properties.Settings.Default.Save();
            form.menu2_2_panel_main_panel1_table_memo_panel_top_text.Text = "";
            form.menu2_2_panel_main_panel1_table_memo_text.Text = "";
        }
        public static void menu2_2_panel_main_panel2_table_memo_panel_top_button_close_Click(MainForm form)
        {
            Properties.Settings.Default.memo_path2 = "";
            Properties.Settings.Default.Save();
            form.menu2_2_panel_main_panel2_table_memo_panel_top_text.Text = "";
            form.menu2_2_panel_main_panel2_table_memo_text.Text = "";
        }
        public static void menu2_2_panel_main_panel3_table_memo_panel_top_button_close_Click(MainForm form)
        {
            Properties.Settings.Default.memo_path3 = "";
            Properties.Settings.Default.Save();
            form.menu2_2_panel_main_panel3_table_memo_panel_top_text.Text = "";
            form.menu2_2_panel_main_panel3_table_memo_text.Text = "";
        }
        public static void menu2_2_panel_main_panel4_table_memo_panel_top_button_close_Click(MainForm form)
        {
            Properties.Settings.Default.memo_path4 = "";
            Properties.Settings.Default.Save();
            form.menu2_2_panel_main_panel4_table_memo_panel_top_text.Text = "";
            form.menu2_2_panel_main_panel4_table_memo_text.Text = "";
        }
        public static void menu2_2_panel_main_panel5_table_memo_panel_top_button_close_Click(MainForm form)
        {
            Properties.Settings.Default.memo_path5 = "";
            Properties.Settings.Default.Save();
            form.menu2_2_panel_main_panel5_table_memo_panel_top_text.Text = "";
            form.menu2_2_panel_main_panel5_table_memo_text.Text = "";
        }

        // private
        #region private




        // メモを保存する時の関数
        private static Boolean SaveMemo(MainForm form, string path, string text, int num)
        {
            FileUtil fu = new FileUtil();

            // パスが空の時 = 新規ファイルなので、名前をつけて保存ダイアログを表示して保存する
            if (path == "")
            {
                fu.OpenDialog(form, text, num);
            }
            // パスが空ではない時 = 既存ファイルなので、上書き保存
            else
            {
                fu.WriteFileLine(path, text);
            }

            return true;
        }

        private static Boolean CloseMemo(int num)
        {
            switch (num)
            {
                case 1:
                    Properties.Settings.Default.memo_path1 = "";
                    break;
            }


            return false;
        }

        #endregion private
    }
}
