using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class common_events
    {
        MainForm form;
        // ********** form event **********
        #region form event

        public static void common_panel_setting_button_checkupdate_Click(object sender, EventArgs e, MainForm form)
        {
            common_events common_Events = new common_events();
            common_Events.CheckUpdate(form);
        }
        // ダブルクリック時の動作
        public static void common_MouseDoubleClick(object sender, MouseEventArgs e, MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            if (form.WindowState == FormWindowState.Maximized) // 最大化されている時
            {
                form.WindowState = FormWindowState.Normal; // 通常化
                form.common_button_max.BackgroundImage = ((Image)(resources.GetObject("common_button_max.Image")));
            }
            else
            {
                form.WindowState = FormWindowState.Maximized; // 最大化
                form.common_button_max.BackgroundImage = ((Image)(resources.GetObject("common_button_dis_max.Image")));
            }
        }

        // 最小化ボタン
        public static void common_button_min_MouseClick(object sender, MouseEventArgs e, MainForm form)
        {
            form.WindowState = FormWindowState.Minimized; // 最小化
        }

        // 最大化ボタン
        public static void common_button_max_MouseClick(object sender, MouseEventArgs e, MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            if (form.WindowState == FormWindowState.Maximized) // 最大化されている時
            {
                form.WindowState = FormWindowState.Normal; // 通常化
                form.common_button_max.BackgroundImage = ((Image)(resources.GetObject("common_button_max.Image")));
            }
            else
            {
                form.WindowState = FormWindowState.Maximized; // 最大化
                form.common_button_max.BackgroundImage = ((Image)(resources.GetObject("common_button_dis_max.Image")));
            }
        }

        // 閉じるボタン
        public static void common_button_close_MouseClick(object sender, MouseEventArgs e, MainForm form)
        {
            // 保存されていないメモの確認
            for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
            {
                if (!Main.Common_Var.memo_save[i])
                {
                    if (!menu2_2_events.FormCloseMemo(form, i))
                    {
                        return;
                    }
                }
            }

            Properties.Settings.Default.form_x = form.Width;
            Properties.Settings.Default.form_y = form.Height;
            for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
            {
                if (form.menu2_2_panel_main_panel[i].Height > 34)
                {
                    Properties.Settings.Default.memo_height[i] = form.menu2_2_panel_main_panel[i].Height.ToString();
                }
            }
            Properties.Settings.Default.Save();
            form.Close(); // formを閉じる
        }

        // 閉じるボタンホバー時の動作
        public static void common_button_close_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            form.common_button_close.BackColor = Color.FromArgb(50, 255, 128, 128); // 閉じるボタンの背景色を赤(255, 128, 128)にする
        }

        // 閉じるボタンLeave時の動作
        public static void common_button_close_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            form.common_button_close.BackColor = Color.Transparent; // 元の色に戻す
        }

        // 設定ボタン押下
        public static void common_button_setting_Click(object sender, EventArgs e, MainForm form)
        {
            if (form.common_panel_setting.Visible == false) // 設定画面が非表示の時
            {
                form.common_panel_setting.Visible = true; // 設定画面表示
            }
            else
            {
                form.common_panel_setting.Visible = false; // 設定画面非表示
            }
        }

        // 前メニューへ移動する時の動作
        public static void common_button_prevmenu_Click(object sender, EventArgs e, MainForm form)
        {
            Main.Common_Var.menu -= 1;
            ChangeMenu(form);
        }

        // 次メニューへ移動する時の動作
        public static void common_button_nextmenu_Click(object sender, EventArgs e, MainForm form)
        {
            Main.Common_Var.menu += 1;
            ChangeMenu(form);
        }
        #endregion form event
        // ********** form event **********


        // ********** public **********
        #region public

        // メニュー切り替え
        public static void ChangeMenu(MainForm form)
        {
            switch (Main.Common_Var.menu)
            {
                case 1: //メイン画面
                    form.common_panel_setting.Visible = false;
                    form.menu1.Visible = true;
                    form.menu2.Visible = false;
                    form.menutask.Visible = false;
                    for (int i = 0; i < Main.Common_Var.menu2_1_task; i++) // タスクの背景色を元に戻す
                    {
                        form.menu2_1_panel_main_panel[i].BackColor = Color.Transparent;
                    }
                    form.menudone.Visible = false;
                    form.common_button_prevmenu.Visible = false;
                    form.common_button_nextmenu.Visible = true;
                    Main.Common_Var.menu2_1_open_task = -1;
                    Main.Common_Var.menu2_1_delete_task = 0;
                    break;
                case 2: //タスク画面
                    form.common_panel_setting.Visible = false;
                    form.menu1.Visible = false;
                    form.menu2.Visible = true;
                    form.menutask.Visible = false;
                    form.menudone.Visible = false;
                    for (int i = 0; i < Main.Common_Var.menu1_day_done; i++) // 実績の背景色を元に戻す
                    {
                        form.menu1_done_main_panel[i].BackColor = Color.Transparent;
                    }
                    form.common_button_prevmenu.Visible = true;
                    form.common_button_nextmenu.Visible = false;
                    Main.Common_Var.menu1_open_done = -1;
                    Main.Common_Var.menu1_delete_done = 0;
                    break;
                default:
                    Main.Common_Var.menu = 1;
                    ChangeMenu(form);
                    break;
            }
            Properties.Settings.Default.Save(); // 開いているメニューを保存
        }

        // カレンダーに日にちをセット
        public static void Set_Day(MainForm form, int year, int month)
        {
            DayOfWeek firstdate = (new DateTime(year, month, 1)).DayOfWeek; // 前月と当月の判定用
            int[] days = new int[42]; // 日付のための箱
            int sub_day = 0; // 次月と当月の判定用
            int today_int = -1; // 現在日の判定用

            Get_Calender(year, month, ref days, ref sub_day, ref today_int); // 表示内容を取得

            Font main_font = new Font("Yu Gothic UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point); // 共通変数にする?
            Font sub_font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);

            int sumtime = 0;
            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                sumtime = 0;

                if ((int)firstdate - 1 < i && i < sub_day) // 当月
                {
                    form.menu1_table_calender_panel_day_label_day[i].Text = days[i].ToString();　// 日付
                    form.menu1_table_calender_panel_day_label_day[i].BackColor = Color.Transparent; // ラベル背景色
                    form.menu1_table_calender_panel_day[i].BackColor = Main.Common_Const.color_gray1; // パネル背景色
                    form.menu1_table_calender_panel_day_label_day[i].Font = main_font; // フォント

                    for (int j = 0; j < Properties.Settings.Default.done_name.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[j])
                        && Properties.Settings.Default.done_day[j] == year.ToString() + "/" + month.ToString() + "/" + days[i].ToString())
                        {
                            sumtime += int.Parse(Properties.Settings.Default.done_time[j]);
                        }
                    }
                }
                else if (sub_day <= i) // 次月
                {
                    int nextmonth = 0;
                    int nextyear = year;
                    if (month == 12)
                    {
                        nextmonth = 1;
                        nextyear = year + 1;
                    }
                    else
                    {
                        nextmonth = month + 1;
                    }
                    form.menu1_table_calender_panel_day_label_day[i].Text = nextmonth.ToString() + "/" + days[i].ToString(); // 日付 次月の場合は月の表示も追加
                    form.menu1_table_calender_panel_day_label_day[i].BackColor = Color.Transparent; // ラベル背景色
                    form.menu1_table_calender_panel_day[i].BackColor = Main.Common_Const.color_calender_out; // パネル背景色
                    form.menu1_table_calender_panel_day_label_day[i].Font = sub_font; // フォント

                    for (int j = 0; j < Properties.Settings.Default.done_name.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[j])
                        && Properties.Settings.Default.done_day[j] == nextyear.ToString() + "/" + nextmonth.ToString() + "/" + days[i].ToString())
                        {
                            sumtime += int.Parse(Properties.Settings.Default.done_time[j]);
                        }
                    }
                }
                else if (i <= (int)firstdate - 1) // 前月
                {
                    int prevmonth = 0;
                    int prevyear = year;
                    if (month == 1)
                    {
                        prevmonth = 12;
                        prevyear = year - 1;
                    }
                    else
                    {
                        prevmonth = month - 1;
                    }
                    form.menu1_table_calender_panel_day_label_day[i].Text = prevmonth.ToString() + "/" + days[i].ToString(); // 日付 前月の場合は月の表示も追加
                    form.menu1_table_calender_panel_day_label_day[i].BackColor = Color.Transparent; // ラベル背景色
                    form.menu1_table_calender_panel_day[i].BackColor = Main.Common_Const.color_calender_out; // パネル背景色
                    form.menu1_table_calender_panel_day_label_day[i].Font = sub_font; // フォント

                    for (int j = 0; j < Properties.Settings.Default.done_name.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[j])
                        && Properties.Settings.Default.done_day[j] == prevyear.ToString() + "/" + prevmonth.ToString() + "/" + days[i].ToString())
                        {
                            sumtime += int.Parse(Properties.Settings.Default.done_time[j]);
                        }
                    }
                }

                if (i == today_int) // 現在日がカレンダーに存在する場合はパネルの色を変更する
                {
                    form.menu1_table_calender_panel_day_label_day[today_int].BackColor = Main.Common_Const.color_calender_today; // ラベル背景色 黄色
                }

                // 実績時間を表示
                form.menu1_table_calender_panel_day_label_done[i].Text = "";
                form.menu1_table_calender_panel_day_label_done[i].Visible = false;
                if (sumtime / 60 != 0)
                {
                    form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime / 60).ToString() + "h";
                    form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                    if (sumtime / 60 >= 12)
                    {
                        form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done2;
                    }
                    else
                    {
                        form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                    }
                }
                else if (sumtime > 0)
                {
                    form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                }
                if (sumtime % 60 != 0)
                {
                    form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime % 60).ToString() + "m";
                    form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                }
            }
        }

        // カレンダーの日にちと今月ではない日を取得
        public static void Get_Calender(int year, int month, ref int[] days, ref int sub_day, ref int today_int)
        {
            DateTime today = DateTime.Now;
            today_int = -1;

            DateTime firstday = new DateTime(year, month, 1);
            DayOfWeek firstdate = firstday.DayOfWeek; // 前月と当月の判定用

            sub_day = 0;
            Boolean subday_flg = false;

            DateTime inputday = firstday.AddDays(-1);

            for (int i = (int)firstdate - 1; i >= 0; i--) // 前月
            {
                days[i] = inputday.Day; // 日付を保存
                if (today.Year == inputday.Year && today.Month == inputday.Month && today.Day == inputday.Day)
                {
                    today_int = i; // 現在日がある場合は保存
                }
                inputday = inputday.AddDays(-1); // 日付を1日前に変更する
            }
            inputday = firstday;
            for (int i = (int)firstdate; i <= 41; i++) // 当月 次月
            {
                days[i] = inputday.Day; // 日付を保存
                if (today.Year == inputday.Year && today.Month == inputday.Month && today.Day == inputday.Day)
                {
                    today_int = i; // 現在日がある場合は保存
                }
                if (month != inputday.Month && subday_flg == false)
                {
                    sub_day = i; // 当月と次月の判定用変数に保存
                    subday_flg = true;
                }
                inputday = inputday.AddDays(1); // 日付を1日後に変更する
            }
        }

        #endregion public
        // ********** public **********

        // ********** private **********
        // アップデート確認
        private async void CheckUpdate(MainForm form)
        {
            this.form = form;
            // GitHub API
            string url = "https://api.github.com/repos/Sirasu-fish/TaskManage/releases/latest";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "ToDoList");
            HttpResponseMessage result = new HttpResponseMessage();
            string json = "";
            string version = "";
            try
            {
                result = await client.GetAsync(url);
                json = await result.Content.ReadAsStringAsync();
                version = (JsonSerializer.Deserialize<git_info>(json).tag_name).Replace("v", "");
            }
            catch (Exception)
            {
                MessageBox.Show("最新版です。", "確認", MessageBoxButtons.OK);
                return;
            }

            // バージョンが同じ場合は抜ける
            if (version == Properties.Settings.Default.version)
            {
                MessageBox.Show("最新版です。", "確認", MessageBoxButtons.OK);
                return;
            }

            // exeのパス取得
            string currentpath = (Application.ExecutablePath).Replace(Path.GetFileName(Application.ExecutablePath), "");
            // zipのダウンロードURL
            Uri zipurl = new Uri("https://github.com/Sirasu-fish/TaskManage/releases/download/v" + version + "/TaskManage.zip");

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(webClient_DownLoadFileCompleted);

            webClient.DownloadFileAsync(zipurl, currentpath + "\\TaskManage.zip");
        }

        private class git_info
        {
            public string tag_name { get; set; }
        }

        private void webClient_DownLoadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null) // エラー
            {
                return;
            }
            else // ダウンロード正常完了
            {
                DialogResult result = MessageBox.Show("アップデートがあります。適用しますか？", "TaskManage", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    // 保存されていないメモの確認
                    for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
                    {
                        if (!Main.Common_Var.memo_save[i])
                        {
                            if (!menu2_2_events.FormCloseMemo(form, i))
                            {
                                return;
                            }
                        }
                    }

                    Properties.Settings.Default.form_x = form.Width;
                    Properties.Settings.Default.form_y = form.Height;
                    for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
                    {
                        if (form.menu2_2_panel_main_panel[i].Height > 34)
                        {
                            Properties.Settings.Default.memo_height[i] = form.menu2_2_panel_main_panel[i].Height.ToString();
                        }
                    }
                    Properties.Settings.Default.Save();

                    string currentpath = (Application.ExecutablePath).Replace(Path.GetFileName(Application.ExecutablePath), "");
                    Process.Start(currentpath + "\\UpdateTaskManage.exe");
                    form.Close();
                }
            }
        }

    }
}
