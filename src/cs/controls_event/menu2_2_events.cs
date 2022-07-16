﻿using System;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu2_2_events
    {
        MainForm form;

        // コンストラクタ
        public menu2_2_events(MainForm form)
        {
            this.form = form;
        }

        // ********** form event **********
        #region form event
        // menu2 panel2を開いたり閉じたりする時の動作
        public static void menu2_2_panel_top_button_openclose_Click(object sender, EventArgs e, MainForm form)
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
        public static void menu2_2_panel_top_button_moveup_Click(object sender, EventArgs e, MainForm form)
        {
            int order_num = -1;

            for (int i = 0; i < Main.Common_Const.menu2_num; i++)
            {
                if (Properties.Settings.Default.order[i] == "2")
                {
                    order_num = i;
                    break;
                }
            }
            if (!(order_num <= 0))
            {
                string tmp;
                // 入れ替え
                tmp = Properties.Settings.Default.order[order_num - 1];
                Properties.Settings.Default.order[order_num - 1] = Properties.Settings.Default.order[order_num];
                Properties.Settings.Default.order[order_num] = tmp;

                Properties.Settings.Default.Save();

                menu2_events.RefrectMoveControl(form);
            }
        }
        public static void menu2_2_panel_top_button_movedown_Click(object sender, EventArgs e, MainForm form)
        {
            int order_num = -1;

            for (int i = 0; i < Main.Common_Const.menu2_num; i++)
            {
                if (Properties.Settings.Default.order[i] == "2")
                {
                    order_num = i;
                    break;
                }
            }
            if (!(order_num >= Main.Common_Const.menu2_num - 1))
            {
                string tmp;
                // 入れ替え
                tmp = Properties.Settings.Default.order[order_num + 1];
                Properties.Settings.Default.order[order_num + 1] = Properties.Settings.Default.order[order_num];
                Properties.Settings.Default.order[order_num] = tmp;

                Properties.Settings.Default.Save();

                menu2_events.RefrectMoveControl(form);
            }
        }

        // menu2_2 ファイルを開くダイアログを開く
        public static void menu2_2_panel_top_button_open_Click(object sender, EventArgs e, MainForm form)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txtファイル(*.txt;*.log;*.oml)|*.txt;*.log;*.oml";
            ofd.FilterIndex = 1;
            ofd.Title = "ファイルを選択してください";
            ofd.RestoreDirectory = true;

            FileUtil fu = new FileUtil();

            if (ofd.ShowDialog() == DialogResult.OK) // ファイルを選択した時
            {
                for (int i = 0; i < Properties.Settings.Default.memo_path.Count - 1; i++)
                {
                    if (Properties.Settings.Default.memo_path[i] == ofd.FileName) // 既存メモに選択ファイルがある場合
                    {
                        form.menu2_2_panel_main_panel_table_memo_text[i].Text = fu.ReadFileAll(ofd.FileName); // 既存メモの内容を更新する
                        return;
                    }
                }
                // 既存メモに選択ファイルがなかった場合
                form.menu2_2_panel_main_panel_table_memo_panel_top_text[Properties.Settings.Default.memo_path.Count].Text = ofd.FileName; // ファイル名を更新
                form.menu2_2_panel_main_panel_table_memo_text[Properties.Settings.Default.memo_path.Count].Text = fu.ReadFileAll(ofd.FileName); // 内容を更新
                form.menu2_2_panel_main_panel[Properties.Settings.Default.memo_path.Count].Visible = true; //パネルの表示
                Main.Common_Var.memo_save[Properties.Settings.Default.memo_path.Count] = true; // 保存フラグをtrueにする
                Properties.Settings.Default.memo_path[Properties.Settings.Default.memo_path.Count] = ofd.FileName; // ファイル名を保存
                Properties.Settings.Default.Save();
            }
        }

        // メモの追加
        public static void menu2_2_panel_top_button_add_Click(object sender, EventArgs e, MainForm form)
        {
            AddMemo(form, " *", "");
        }

        // キー押下時のイベント
        public void menu2_2_panel_main_panel_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(form, ((TextBox)sender).Text, int.Parse(((TextBox)sender).Name));
            }
        }

        // テキスト変更時イベント
        public void menu2_2_panel_main_panel_table_memo_text_TextChanged(object sender, EventArgs e)
        {
            if (Main.Common_Var.memo_save[int.Parse(((TextBox)sender).Name)] == true)
            {
                form.menu2_2_panel_main_panel_table_memo_panel_top_text[int.Parse(((TextBox)sender).Name)].Text += " *";
                Main.Common_Var.memo_save[int.Parse(((TextBox)sender).Name)] = false;
            }
        }

        //保存ボタン
        public void menu2_2_panel_main_panel_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            SaveMemo(form, form.menu2_2_panel_main_panel_table_memo_text[int.Parse(((Button)sender).Name)].Text, int.Parse(((Button)sender).Name));
        }

        // 最小化、最大化ボタン
        public void menu2_2_panel_main_panel_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
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
        public void menu2_2_panel_main_panel_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            int i = int.Parse(((Button)sender).Name);

            // 変更したファイルを保存していない時
            if (Main.Common_Var.memo_save[i] == false)
            {
                FileUtil fu = new FileUtil();

                string[] paths = new string[Main.Common_Const.memo_num];
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

            string[] path = new string[Main.Common_Const.memo_num];
            Properties.Settings.Default.memo_path.CopyTo(path, 0);
            path[i] = "";
            Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.memo_path.AddRange(path);
            Properties.Settings.Default.Save();
            form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = "";
            form.menu2_2_panel_main_panel_table_memo_text[i].Text = "";
            form.menu2_2_panel_main_panel[i].Visible = false;
        }
        #endregion form event
        // ********** form event **********

        // ********** public **********
        #region public
        // メモ追加
        public static void AddMemo(MainForm form, String memo_title, string memo_text)
        {
            // 登録処理
            form.SuspendLayout();
            form.menu2.SuspendLayout();
            form.menu2_2.SuspendLayout();
            form.menu2_2_panel.SuspendLayout();
            form.menu2_2_panel_main.SuspendLayout();

            form.menu2_2_panel_main_panel_table_memo_panel_top_button_save.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_button_save(form));
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_button_minmax(form));
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_close.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_button_close(form));
            form.menu2_2_panel_main_panel_table_memo_text.Add(add_menu2_2_panel_main_panel_table_memo_text(form, memo_text));
            form.menu2_2_panel_main_panel_table_memo_panel_top_text.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_text(form, memo_title));
            form.menu2_2_panel_main_panel_table_memo_panel_top.Add(add_menu2_2_panel_main_panel_table_memo_panel_top(form));
            form.menu2_2_panel_main_panel_table_memo.Add(add_menu2_2_panel_main_panel_table_memo(form));
            form.menu2_2_panel_main_panel.Add(add_menu2_2_panel_main_panel(form));
            form.menu2_2_panel_main.Controls.Add(form.menu2_2_panel_main_panel[Main.Common_Var.menu2_2_memo]);

            form.ResumeLayout();
            form.menu2.ResumeLayout();
            form.menu2_2.ResumeLayout();
            form.menu2_2_panel.ResumeLayout();
            form.menu2_2_panel_main.ResumeLayout();

            Main.Common_Var.menu2_2_memo += 1;

            ChangeMemoNum(form);
        }


        #endregion public
        // ********** public **********

        // ********** private **********
        #region private

        // メモを保存する時の関数
        private static Boolean SaveMemo(MainForm form, string text, int num)
        {
            FileUtil fu = new FileUtil();

            string[] paths = new string[Main.Common_Const.memo_num];
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

        // 保存ボタン
        private static Button add_menu2_2_panel_main_panel_table_memo_panel_top_button_save(MainForm form)
        {
            Button menu2_2_panel_main_panel_table_memo_panel_top_button_save = new Button();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Dock = DockStyle.Right;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.FlatStyle = FlatStyle.Flat;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Size = new System.Drawing.Size(32, 22);
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.UseVisualStyleBackColor = true;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Click += new EventHandler(events.menu2_2_panel_main_panel_table_memo_panel_top_button_save_Click);

            return menu2_2_panel_main_panel_table_memo_panel_top_button_save;
        }
        // 閉じるボタン
        private static Button add_menu2_2_panel_main_panel_table_memo_panel_top_button_close(MainForm form)
        {
            Button menu2_2_panel_main_panel_table_memo_panel_top_button_close = new Button();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Dock = DockStyle.Right;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.FlatStyle = FlatStyle.Flat;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Size = new System.Drawing.Size(32, 22);
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.UseVisualStyleBackColor = true;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Click += new EventHandler(events.menu2_2_panel_main_panel_table_memo_panel_top_button_close_Click);

            return menu2_2_panel_main_panel_table_memo_panel_top_button_close;
        }
        // 最小化、最大化ボタン
        private static Button add_menu2_2_panel_main_panel_table_memo_panel_top_button_minmax(MainForm form)
        {
            Button menu2_2_panel_main_panel_table_memo_panel_top_button_minmax = new Button();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Dock = DockStyle.Right;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.FlatStyle = FlatStyle.Flat;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Size = new System.Drawing.Size(32, 22);
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.UseVisualStyleBackColor = true;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Click += new EventHandler(events.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax_Click);

            return menu2_2_panel_main_panel_table_memo_panel_top_button_minmax;
        }
        // メモ名
        private static TextBox add_menu2_2_panel_main_panel_table_memo_panel_top_text(MainForm form, string memo_name)
        {
            TextBox menu2_2_panel_main_panel_table_memo_panel_top_text = new TextBox();

            menu2_2_panel_main_panel_table_memo_panel_top_text.BackColor = System.Drawing.SystemColors.Control;
            menu2_2_panel_main_panel_table_memo_panel_top_text.Dock = DockStyle.Fill;
            menu2_2_panel_main_panel_table_memo_panel_top_text.ReadOnly = true;
            menu2_2_panel_main_panel_table_memo_panel_top_text.Text = memo_name;
            menu2_2_panel_main_panel_table_memo_panel_top_text.Size = new System.Drawing.Size(
                Main.Common_Const.form_x - 10
                - form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[Main.Common_Var.menu2_2_memo].Width
                - form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[Main.Common_Var.menu2_2_memo].Width
                - form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[Main.Common_Var.menu2_2_memo].Width, 23);

            return menu2_2_panel_main_panel_table_memo_panel_top_text;
        }
        // メモ内容
        private static TextBox add_menu2_2_panel_main_panel_table_memo_text(MainForm form, string memo_text)
        {
            TextBox menu2_2_panel_main_panel_table_memo_text = new TextBox();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_text.AcceptsReturn = true;
            menu2_2_panel_main_panel_table_memo_text.AcceptsTab = true;
            menu2_2_panel_main_panel_table_memo_text.Dock = DockStyle.Fill;
            menu2_2_panel_main_panel_table_memo_text.Multiline = true;
            menu2_2_panel_main_panel_table_memo_text.ScrollBars = ScrollBars.Both;
            menu2_2_panel_main_panel_table_memo_text.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_text.Text = memo_text;
            menu2_2_panel_main_panel_table_memo_text.Margin = new Padding(0);
            menu2_2_panel_main_panel_table_memo_text.KeyDown += new KeyEventHandler(events.menu2_2_panel_main_panel_table_memo_text_KeyDown);
            menu2_2_panel_main_panel_table_memo_text.TextChanged += new EventHandler(events.menu2_2_panel_main_panel_table_memo_text_TextChanged);

            return menu2_2_panel_main_panel_table_memo_text;
        }
        // メモ上部
        private static Panel add_menu2_2_panel_main_panel_table_memo_panel_top(MainForm form)
        {
            Panel menu2_2_panel_main_panel_table_memo_panel_top = new Panel();

            menu2_2_panel_main_panel_table_memo_panel_top.Dock = DockStyle.Fill;
            menu2_2_panel_main_panel_table_memo_panel_top.Margin = new Padding(0);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_text[Main.Common_Var.menu2_2_memo]);

            return menu2_2_panel_main_panel_table_memo_panel_top;
        }
        // メモテーブル
        private static TableLayoutPanel add_menu2_2_panel_main_panel_table_memo(MainForm form)
        {
            TableLayoutPanel menu2_2_panel_main_panel_table_memo = new TableLayoutPanel();

            menu2_2_panel_main_panel_table_memo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu2_2_panel_main_panel_table_memo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            menu2_2_panel_main_panel_table_memo.ColumnCount = 1;
            menu2_2_panel_main_panel_table_memo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            menu2_2_panel_main_panel_table_memo.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top[Main.Common_Var.menu2_2_memo], 0, 0);
            menu2_2_panel_main_panel_table_memo.Controls.Add(form.menu2_2_panel_main_panel_table_memo_text[Main.Common_Var.menu2_2_memo], 0, 1);
            menu2_2_panel_main_panel_table_memo.Location = new System.Drawing.Point(4, 0);
            menu2_2_panel_main_panel_table_memo.RowCount = 2;
            menu2_2_panel_main_panel_table_memo.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            menu2_2_panel_main_panel_table_memo.RowStyles.Add(new RowStyle(SizeType.Percent, 78F));
            menu2_2_panel_main_panel_table_memo.Size = new System.Drawing.Size(Main.Common_Const.form_x - 8, 102);

            return menu2_2_panel_main_panel_table_memo;
        }
        // メモパネル
        private static Panel add_menu2_2_panel_main_panel(MainForm form)
        {
            Panel menu2_2_panel_main_panel = new Panel();

            menu2_2_panel_main_panel.Controls.Add(form.menu2_2_panel_main_panel_table_memo[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel.Dock = DockStyle.Top;
            menu2_2_panel_main_panel.Size = new System.Drawing.Size(Main.Common_Const.form_x, 106);

            return menu2_2_panel_main_panel;
        }
        // メモ数更新
        private static void ChangeMemoNum(MainForm form)
        {
            form.SuspendLayout();
            form.menu2.SuspendLayout();
            form.menu2_2.SuspendLayout();
            form.menu2_2_panel.SuspendLayout();
            form.menu2_2_panel_top.SuspendLayout();

            form.menu2_2_panel_top_label_num.CustomText = Properties.Settings.Default.memo_path.Count.ToString();
            if (Properties.Settings.Default.menu2_open2)
            {
                form.menu2_2_panel.Height = 34 + 150 * Properties.Settings.Default.memo_path.Count;
                form.menu2_2.Height = 42 + 150 * Properties.Settings.Default.memo_path.Count;
            }
            else
            {
                form.menu2_2_panel.Height = 34;
                form.menu2_2.Height = 42;
            }

            form.ResumeLayout();
            form.menu2.ResumeLayout();
            form.menu2_2.ResumeLayout();
            form.menu2_2_panel.ResumeLayout();
            form.menu2_2_panel_top.ResumeLayout();
        }

        #endregion private
        // ********** private **********
    }
}
