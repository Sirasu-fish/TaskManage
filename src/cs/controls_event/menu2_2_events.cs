using System;
using System.Drawing;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            if (form.menu2_2_panel_main.Visible == false)
            {
                form.menu2_2_panel_main.Visible = true;
                form.menu2_2_panel_top_button_openclose.BackgroundImage = ((Image)(resources.GetObject("menu2_1_panel_top_button_openclose_close.Image")));
                form.tooltip.SetToolTip(form.menu2_2_panel_top_button_openclose, "閉じる");
                if (Main.Common_Var.menu2_2_memo != 0)
                {
                    form.menu2_2_panel.Height = form.menu2_2_panel_top.Height + 2;
                    form.menu2_2.Height = form.menu2_2_panel_top.Height + 2 + 8;
                    for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
                    {
                        form.menu2_2_panel.Height += form.menu2_2_panel_main_panel[i].Height;
                        form.menu2_2.Height += form.menu2_2_panel_main_panel[i].Height;
                    }
                }
                else
                {
                    form.menu2_2_panel.Height = form.menu2_2_panel_top.Height + 2 + 10;
                    form.menu2_2.Height = form.menu2_2_panel_top.Height + 2 + 8 + 10;
                }
                Properties.Settings.Default.menu2_open2 = true;
            }
            else
            {
                form.menu2_2_panel_main.Visible = false;
                form.menu2_2_panel_top_button_openclose.BackgroundImage = ((Image)(resources.GetObject("menu2_1_panel_top_button_openclose_open.Image")));
                form.tooltip.SetToolTip(form.menu2_2_panel_top_button_openclose, "開く");
                form.menu2_2_panel.Height = form.menu2_2_panel_top.Height + 2;
                form.menu2_2.Height = form.menu2_2_panel_top.Height + 2 + 8;
                Properties.Settings.Default.menu2_open2 = false;
            }

            Properties.Settings.Default.Save();
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
                for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
                {
                    if (Properties.Settings.Default.memo_path[i] == ofd.FileName) // 既存メモに選択ファイルがある場合
                    {
                        form.menu2_2_panel_main_panel_table_memo_text[i].Text = fu.ReadFileAll(ofd.FileName); // 既存メモの内容を更新する
                        return;
                    }
                }
                // 既存メモに選択ファイルがなかった場合
                AddMemo(form, ofd.FileName, fu.ReadFileAll(ofd.FileName), Main.Common_Const.memo_height, true);
                Main.Common_Var.memo_save.Add(true); // 保存フラグをtrueにする
                Properties.Settings.Default.memo_path.Add(ofd.FileName); // ファイル名を保存
                Properties.Settings.Default.memo_height.Add(Main.Common_Const.memo_height.ToString()); // メモの高さ保存
                Properties.Settings.Default.memo_wrap.Add("true"); // メモの折り返し保存
                Properties.Settings.Default.Save();
            }
        }

        // メモの追加
        public static void menu2_2_panel_top_button_add_Click(object sender, EventArgs e, MainForm form)
        {
            AddMemo(form, "", "", Main.Common_Const.memo_height, true);
            Main.Common_Var.memo_save.Add(true);
            Properties.Settings.Default.memo_path.Add(""); // ファイル名を保存
            Properties.Settings.Default.memo_height.Add(Main.Common_Const.memo_height.ToString()); // メモの高さ保存
            Properties.Settings.Default.memo_wrap.Add("true"); // メモの折り返し保存
            Properties.Settings.Default.Save();
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
                form.menu2_2_panel_main_panel_table_memo_panel_top_text[int.Parse(((TextBox)sender).Name)].BackColor = Main.Common_Const.color5;
                Main.Common_Var.memo_save[int.Parse(((TextBox)sender).Name)] = false;
            }
        }

        // 折り返しボタン
        public void menu2_2_panel_main_panel_table_memo_panel_top_button_wrap_Click(object sender, EventArgs e)
        {
            ChangeWordWrap(form, int.Parse(((Button)sender).Name));
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
                form.menu2_2_panel_main_panel[i].Height = int.Parse(Properties.Settings.Default.memo_height[i]);
            }
            else
            {
                Properties.Settings.Default.memo_height[i] = form.menu2_2_panel_main_panel[i].Height.ToString();
                Properties.Settings.Default.Save();
                form.menu2_2_panel_main_panel_table_memo_text[i].Visible = false;
                form.menu2_2_panel_main_panel[i].Height = 34;
            }
        }

        // 閉じるボタン
        public void menu2_2_panel_main_panel_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            RemoveMemo(form, int.Parse(((Button)sender).Name));
        }
        #endregion form event
        // ********** form event **********

        // ********** public **********
        #region public
        // メモ追加
        public static void AddMemo(MainForm form, string memo_title, string memo_text, int memo_height, bool memo_wrap)
        {
            // 登録処理
            form.SuspendLayout();
            form.menu2.SuspendLayout();
            form.menu2_2.SuspendLayout();
            form.menu2_2_panel.SuspendLayout();
            form.menu2_2_panel_main.SuspendLayout();

            form.menu2_2_panel_main_panel_table_memo_text.Add(add_menu2_2_panel_main_panel_table_memo_text(form, memo_text, memo_wrap));
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_button_wrap(form));
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_save.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_button_save(form));
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_button_minmax(form));
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_close.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_button_close(form));
            form.menu2_2_panel_main_panel_table_memo_panel_top_text.Add(add_menu2_2_panel_main_panel_table_memo_panel_top_text(form, memo_title));
            form.menu2_2_panel_main_panel_table_memo_panel_top.Add(add_menu2_2_panel_main_panel_table_memo_panel_top(form));
            form.menu2_2_panel_main_panel.Add(add_menu2_2_panel_main_panel(form, memo_height));
            form.menu2_2_panel_main_panel_table_memo.Add(add_menu2_2_panel_main_panel_table_memo(form, memo_height));
            form.menu2_2_panel_main_panel[Main.Common_Var.menu2_2_memo].Controls.Add(form.menu2_2_panel_main_panel_table_memo[Main.Common_Var.menu2_2_memo]);
            form.menu2_2_panel_main.Controls.Add(form.menu2_2_panel_main_panel[Main.Common_Var.menu2_2_memo]);

            for (int i = Main.Common_Var.menu2_2_memo; i >= 0; i--)
            {
                form.menu2_2_panel_main.Controls.Remove(form.menu2_2_panel_main_panel[i]);
            }
            for (int i = Main.Common_Var.menu2_2_memo; i >= 0; i--)
            {
                form.menu2_2_panel_main.Controls.Add(form.menu2_2_panel_main_panel[i]);
            }

            form.menu2_2_panel_main_panel[Main.Common_Var.menu2_2_memo].SuspendLayout();
            form.menu2_2_panel_main_panel_table_memo[Main.Common_Var.menu2_2_memo].SuspendLayout();
            form.menu2_2_panel_main_panel_table_memo_panel_top[Main.Common_Var.menu2_2_memo].SuspendLayout();

            Main.Common_Var.menu2_2_panel_main_table_memo_sizeChanger.Add(new DAndDSizeChanger(form.menu2_2_panel_main_panel_table_memo_text[Main.Common_Var.menu2_2_memo], form.menu2_2_panel_main_panel[Main.Common_Var.menu2_2_memo], DAndDArea.Bottom, 12, form.menu2_2, form.menu2_2_panel));

            form.ResumeLayout();
            form.menu2.ResumeLayout();
            form.menu2_2.ResumeLayout();
            form.menu2_2_panel.ResumeLayout();
            form.menu2_2_panel_main.ResumeLayout();
            form.menu2_2_panel_main_panel[Main.Common_Var.menu2_2_memo].ResumeLayout();
            form.menu2_2_panel_main_panel_table_memo[Main.Common_Var.menu2_2_memo].ResumeLayout();
            form.menu2_2_panel_main_panel_table_memo_panel_top[Main.Common_Var.menu2_2_memo].ResumeLayout();

            Main.Common_Var.menu2_2_memo += 1;

            ChangeMemoNum(form);
        }

        // メモ数更新
        public static void ChangeMemoNum(MainForm form)
        {
            form.SuspendLayout();
            form.menu2.SuspendLayout();
            form.menu2_2.SuspendLayout();
            form.menu2_2_panel.SuspendLayout();
            form.menu2_2_panel_top.SuspendLayout();

            form.menu2_2_panel_top_label_num.CustomText = Main.Common_Var.menu2_2_memo.ToString();
            form.menu2_2_panel_top_label_num.Refresh();
            if (Properties.Settings.Default.menu2_open2)
            {
                if (Main.Common_Var.menu2_2_memo != 0) // メモ数が0以外の時
                {
                    form.menu2_2_panel.Height = form.menu2_2_panel_top.Height + 2;
                    form.menu2_2.Height = form.menu2_2_panel_top.Height + 2 + 8;
                    for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
                    {
                        form.menu2_2_panel.Height += form.menu2_2_panel_main_panel[i].Height;
                        form.menu2_2.Height += form.menu2_2_panel_main_panel[i].Height;
                    }
                }
                else
                {
                    form.menu2_2_panel.Height = form.menu2_2_panel_top.Height + 2 + 10;
                    form.menu2_2.Height = form.menu2_2_panel_top.Height + 2 + 8 + 10;
                }
            }
            else
            {
                form.menu2_2_panel.Height = form.menu2_2_panel_top.Height + 2;
                form.menu2_2.Height = form.menu2_2_panel_top.Height + 2 + 8;
            }

            form.ResumeLayout();
            form.menu2.ResumeLayout();
            form.menu2_2.ResumeLayout();
            form.menu2_2_panel.ResumeLayout();
            form.menu2_2_panel_top.ResumeLayout();
        }

        // メモ削除
        public static bool FormCloseMemo(MainForm form, int num)
        {
            // 変更したファイルを保存していない時
            if (Main.Common_Var.memo_save[num] == false)
            {
                FileUtil fu = new FileUtil();

                string save_path = Properties.Settings.Default.memo_path[num];

                switch (fu.ShowOverrideFileMessage())
                {
                    case DialogResult.Yes: // はい
                        if (fu.IsAbleWrite(save_path)) //書き込み可能な時
                        {
                            if (fu.WriteFile(save_path, form.menu2_2_panel_main_panel_table_memo_text[num].Text)) // 上書き
                            {
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (fu.OpenDialog(form, form.menu2_2_panel_main_panel_table_memo_text[num].Text, num)) // 名前をつけて保存
                            {
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case DialogResult.No: // いいえ
                        break;
                    case DialogResult.Cancel: // キャンセル
                        return false;
                }
            }

            return true;
        }

        #endregion public
        // ********** public **********

        // ********** private **********
        #region private

        // メモの折り返し設定を切り替える
        private static void ChangeWordWrap(MainForm form, int num)
        {
            if (form.menu2_2_panel_main_panel_table_memo_text[num].WordWrap)
            {
                form.menu2_2_panel_main_panel_table_memo_text[num].WordWrap = false;
                Properties.Settings.Default.memo_wrap[num] = "false";
            }
            else
            {
                form.menu2_2_panel_main_panel_table_memo_text[num].WordWrap = true;
                Properties.Settings.Default.memo_wrap[num] = "true";
            }
            Properties.Settings.Default.Save();
        }

        // メモを保存する時の関数
        private static Boolean SaveMemo(MainForm form, string text, int num)
        {
            FileUtil fu = new FileUtil();

            if (!String.IsNullOrEmpty(Properties.Settings.Default.memo_path[num]) && Main.Common_Var.memo_save[num] == true) // 空じゃないかつ、変更されていない場合は保存する必要がないためスキップ
            {
                return true;
            }

            // パスが空の時 = 新規ファイルなので、名前をつけて保存ダイアログを表示して保存する
            if (String.IsNullOrEmpty(Properties.Settings.Default.memo_path[num]))
            {
                if (fu.OpenDialog(form, text, num))
                {
                    Main.Common_Var.memo_save[num] = true;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].BackColor = Main.Common_Const.color3;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Text = Properties.Settings.Default.memo_path[num];
                }
            }
            // パスが空ではない時 = 既存ファイルなので、上書き保存
            else
            {
                if (fu.WriteFile(Properties.Settings.Default.memo_path[num], text))
                {
                    Main.Common_Var.memo_save[num] = true;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].BackColor = Main.Common_Const.color3;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Text = Properties.Settings.Default.memo_path[num];
                }
            }

            return true;
        }

        // メモ削除
        private static void RemoveMemo(MainForm form, int num)
        {
            // 変更したファイルを保存していない時
            if (Main.Common_Var.memo_save[num] == false)
            {
                FileUtil fu = new FileUtil();

                string save_path = Properties.Settings.Default.memo_path[num];
                switch (fu.ShowOverrideFileMessage())
                {
                    case DialogResult.Yes: // はい
                        if (fu.IsAbleWrite(save_path)) //書き込み可能な時
                        {
                            if (fu.WriteFile(save_path, form.menu2_2_panel_main_panel_table_memo_text[num].Text)) // 上書き
                            {
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (fu.OpenDialog(form, form.menu2_2_panel_main_panel_table_memo_text[num].Text, num)) // 名前をつけて保存
                            {
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

            form.menu2_2_panel_main.Controls.Remove(form.menu2_2_panel_main_panel[num]);
            form.menu2_2_panel_main_panel_table_memo_panel_top_text.RemoveAt(num);
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.RemoveAt(num);
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_save.RemoveAt(num);
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.RemoveAt(num);
            form.menu2_2_panel_main_panel_table_memo_panel_top_button_close.RemoveAt(num);
            form.menu2_2_panel_main_panel_table_memo_panel_top.RemoveAt(num);
            form.menu2_2_panel_main_panel_table_memo_text.RemoveAt(num);
            form.menu2_2_panel_main_panel_table_memo.RemoveAt(num);
            form.menu2_2_panel_main_panel.RemoveAt(num);
            Properties.Settings.Default.memo_path.RemoveAt(num);
            Properties.Settings.Default.memo_height.RemoveAt(num);
            Properties.Settings.Default.memo_wrap.RemoveAt(num);
            Main.Common_Var.memo_save.RemoveAt(num);

            Main.Common_Var.menu2_2_memo -= 1;

            for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
            {
                form.menu2_2_panel_main_panel_table_memo_text[i].Name = i.ToString();
                form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[i].Name = i.ToString();
                form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].Name = i.ToString();
                form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].Name = i.ToString();
                form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].Name = i.ToString();
            }

            ChangeMemoNum(form);
        }

        // メモ内容
        private static TextBox add_menu2_2_panel_main_panel_table_memo_text(MainForm form, string memo_text, bool wrap)
        {
            TextBox menu2_2_panel_main_panel_table_memo_text = new TextBox();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_text.AcceptsReturn = true;
            menu2_2_panel_main_panel_table_memo_text.AcceptsTab = true;
            menu2_2_panel_main_panel_table_memo_text.Dock = DockStyle.Fill;
            menu2_2_panel_main_panel_table_memo_text.Multiline = true;
            menu2_2_panel_main_panel_table_memo_text.ScrollBars = ScrollBars.Both;
            menu2_2_panel_main_panel_table_memo_text.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_text.WordWrap = wrap;
            menu2_2_panel_main_panel_table_memo_text.Text = memo_text;
            menu2_2_panel_main_panel_table_memo_text.Margin = new Padding(0);
            menu2_2_panel_main_panel_table_memo_text.KeyDown += new KeyEventHandler(events.menu2_2_panel_main_panel_table_memo_text_KeyDown);
            menu2_2_panel_main_panel_table_memo_text.TextChanged += new EventHandler(events.menu2_2_panel_main_panel_table_memo_text_TextChanged);

            return menu2_2_panel_main_panel_table_memo_text;
        }
        // 折り返しボタン
        private static Button add_menu2_2_panel_main_panel_table_memo_panel_top_button_wrap(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu2_2_panel_main_panel_table_memo_panel_top_button_wrap = new Button();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.Cursor = Cursors.Hand;
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.Dock = DockStyle.Right;
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.FlatStyle = FlatStyle.Flat;
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.BackgroundImage = ((Image)(resources.GetObject("menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.Image")));
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.BackgroundImageLayout = ImageLayout.Center;
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.Size = new Size(32, 22);
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.UseVisualStyleBackColor = true;
            menu2_2_panel_main_panel_table_memo_panel_top_button_wrap.Click += new EventHandler(events.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap_Click);
            form.tooltip.SetToolTip(menu2_2_panel_main_panel_table_memo_panel_top_button_wrap, "右端で折り返す");

            return menu2_2_panel_main_panel_table_memo_panel_top_button_wrap;
        }
        // 保存ボタン
        private static Button add_menu2_2_panel_main_panel_table_memo_panel_top_button_save(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu2_2_panel_main_panel_table_memo_panel_top_button_save = new Button();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Cursor = Cursors.Hand;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Dock = DockStyle.Right;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.FlatStyle = FlatStyle.Flat;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.BackgroundImage = ((Image)(resources.GetObject("menu2_2_panel_main_panel_table_memo_panel_top_button_save.Image")));
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.BackgroundImageLayout = ImageLayout.Center;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Size = new Size(32, 22);
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.UseVisualStyleBackColor = true;
            menu2_2_panel_main_panel_table_memo_panel_top_button_save.Click += new EventHandler(events.menu2_2_panel_main_panel_table_memo_panel_top_button_save_Click);
            form.tooltip.SetToolTip(menu2_2_panel_main_panel_table_memo_panel_top_button_save, "保存(Ctrl + S)");

            return menu2_2_panel_main_panel_table_memo_panel_top_button_save;
        }
        // 閉じるボタン
        private static Button add_menu2_2_panel_main_panel_table_memo_panel_top_button_close(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu2_2_panel_main_panel_table_memo_panel_top_button_close = new Button();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Cursor = Cursors.Hand;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Dock = DockStyle.Right;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.FlatStyle = FlatStyle.Flat;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.BackgroundImage = ((Image)(resources.GetObject("menu2_2_panel_main_panel_table_memo_panel_top_button_close.Image")));
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.BackgroundImageLayout = ImageLayout.Center;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Size = new Size(32, 22);
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.UseVisualStyleBackColor = true;
            menu2_2_panel_main_panel_table_memo_panel_top_button_close.Click += new EventHandler(events.menu2_2_panel_main_panel_table_memo_panel_top_button_close_Click);
            form.tooltip.SetToolTip(menu2_2_panel_main_panel_table_memo_panel_top_button_close, "閉じる");

            return menu2_2_panel_main_panel_table_memo_panel_top_button_close;
        }
        // 最小化、最大化ボタン
        private static Button add_menu2_2_panel_main_panel_table_memo_panel_top_button_minmax(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu2_2_panel_main_panel_table_memo_panel_top_button_minmax = new Button();
            menu2_2_events events = new menu2_2_events(form);

            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Cursor = Cursors.Hand;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Dock = DockStyle.Right;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.FlatStyle = FlatStyle.Flat;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.BackgroundImage = ((Image)(resources.GetObject("menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Image")));
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.BackgroundImageLayout = ImageLayout.Center;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Size = new Size(32, 22);
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Name = Main.Common_Var.menu2_2_memo.ToString();
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.UseVisualStyleBackColor = true;
            menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Click += new EventHandler(events.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax_Click);
            form.tooltip.SetToolTip(menu2_2_panel_main_panel_table_memo_panel_top_button_minmax, "最小化");

            return menu2_2_panel_main_panel_table_memo_panel_top_button_minmax;
        }
        // メモ名
        private static TextBox add_menu2_2_panel_main_panel_table_memo_panel_top_text(MainForm form, string memo_name)
        {
            TextBox menu2_2_panel_main_panel_table_memo_panel_top_text = new TextBox();

            menu2_2_panel_main_panel_table_memo_panel_top_text.Dock = DockStyle.Fill;
            menu2_2_panel_main_panel_table_memo_panel_top_text.BackColor = Main.Common_Const.color3;
            menu2_2_panel_main_panel_table_memo_panel_top_text.Location = new Point(0, 0);
            menu2_2_panel_main_panel_table_memo_panel_top_text.ReadOnly = true;
            menu2_2_panel_main_panel_table_memo_panel_top_text.Text = memo_name;

            return menu2_2_panel_main_panel_table_memo_panel_top_text;
        }
        // メモ上部
        private static Panel add_menu2_2_panel_main_panel_table_memo_panel_top(MainForm form)
        {
            Panel menu2_2_panel_main_panel_table_memo_panel_top = new Panel();

            menu2_2_panel_main_panel_table_memo_panel_top.Dock = DockStyle.Fill;
            menu2_2_panel_main_panel_table_memo_panel_top.Margin = new Padding(0);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_text[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[Main.Common_Var.menu2_2_memo]);
            menu2_2_panel_main_panel_table_memo_panel_top.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[Main.Common_Var.menu2_2_memo]);

            return menu2_2_panel_main_panel_table_memo_panel_top;
        }
        // メモテーブル
        private static TableLayoutPanel add_menu2_2_panel_main_panel_table_memo(MainForm form, int memo_height)
        {
            TableLayoutPanel menu2_2_panel_main_panel_table_memo = new TableLayoutPanel();

            menu2_2_panel_main_panel_table_memo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu2_2_panel_main_panel_table_memo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            menu2_2_panel_main_panel_table_memo.ColumnCount = 1;
            menu2_2_panel_main_panel_table_memo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            menu2_2_panel_main_panel_table_memo.Controls.Add(form.menu2_2_panel_main_panel_table_memo_panel_top[Main.Common_Var.menu2_2_memo], 0, 0);
            menu2_2_panel_main_panel_table_memo.Controls.Add(form.menu2_2_panel_main_panel_table_memo_text[Main.Common_Var.menu2_2_memo], 0, 1);
            menu2_2_panel_main_panel_table_memo.Location = new System.Drawing.Point(4, 0);
            menu2_2_panel_main_panel_table_memo.RowCount = 2;
            menu2_2_panel_main_panel_table_memo.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            menu2_2_panel_main_panel_table_memo.RowStyles.Add(new RowStyle(SizeType.Percent, 78F));
            menu2_2_panel_main_panel_table_memo.Size = new System.Drawing.Size(form.menu2_2_panel_main_panel[Main.Common_Var.menu2_2_memo].Width - 8, memo_height - 10);

            return menu2_2_panel_main_panel_table_memo;
        }
        // メモパネル
        private static Panel add_menu2_2_panel_main_panel(MainForm form, int memo_height)
        {
            Panel menu2_2_panel_main_panel = new Panel();


            menu2_2_panel_main_panel.Dock = DockStyle.Top;
            menu2_2_panel_main_panel.Size = new System.Drawing.Size(Properties.Settings.Default.form_x, memo_height);

            return menu2_2_panel_main_panel;
        }

        #endregion private
        // ********** private **********
    }
}
