using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace TaskManage.Main
{
    internal class Init
    {
        MainForm form;

        public void initialize(MainForm form)
        {
            this.form = form;
            // アップデート確認
            CheckUpdate();
            // 設定値の初期化
            SetPropertiesValue();
            // commonをタイトルバー化する
            SetMoveForm(form);
            // 設定を反映
            RefrectSetting(form);

            Set_NowDay(form);
            Set_NowYearMonth(form);
        }

        // private
        #region private

        private static DAndDMoveForm common_MoveForm;
        private static DAndDMoveMenu menu2_1_MoveMenu;
        private static DAndDMoveMenu menu2_2_MoveMenu;

        // アップデート確認
        private async void CheckUpdate()
        {
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
                return;
            }

            // バージョンが同じ場合は抜ける
            if (version == Properties.Settings.Default.version)
            {
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
                    string currentpath = (Application.ExecutablePath).Replace(Path.GetFileName(Application.ExecutablePath), "");
                    Process.Start(currentpath + "\\UpdateTaskManage.exe");
                    form.Close();
                }
            }
        }

        // 設定値の初期化
        private void SetPropertiesValue()
        {
            //Properties.Settings.Default.first_start = false;

            // 初回起動時は初期化
            //if (!Properties.Settings.Default.first_start)
            //{
            //    Properties.Settings.Default.first_start = true;

            //    Properties.Settings.Default.common_mode = false;
            //    Properties.Settings.Default.menu2_open1 = true;
            //    Properties.Settings.Default.menu2_open2 = true;
            //    Properties.Settings.Default.form_x = Common_Const.form_x;
            //    Properties.Settings.Default.form_y = Common_Const.form_y;
            //    Properties.Settings.Default.order = new System.Collections.Specialized.StringCollection { "1", "2" };
            //    Properties.Settings.Default.menu = 1;
            //    Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.memo_height = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.task_name = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.task_memo = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.done_name = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.done_memo = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.done_time = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.done_day = new System.Collections.Specialized.StringCollection();
            //    Properties.Settings.Default.memo_wrap = new System.Collections.Specialized.StringCollection();
            //}

            // フォームサイズ x
            if (Properties.Settings.Default.form_x < Common_Const.form_x)
            {
                Properties.Settings.Default.form_x = Common_Const.form_x;
            }
            // フォームサイズ y
            if (Properties.Settings.Default.form_y < Common_Const.form_y)
            {
                Properties.Settings.Default.form_y = Common_Const.form_y;
            }

            // メニュー
            if (Properties.Settings.Default.menu < 1 || 3 < Properties.Settings.Default.menu)
            {
                Properties.Settings.Default.menu = 1;
            }

            for (int i = Properties.Settings.Default.memo_path.Count - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.memo_path[i]))
                {
                    Properties.Settings.Default.memo_path.RemoveAt(i);
                    Properties.Settings.Default.memo_height.RemoveAt(i);
                    Properties.Settings.Default.memo_wrap.RemoveAt(i);
                }
            }

            Properties.Settings.Default.Save();
        }

        // 設定を反映
        private void RefrectSetting(MainForm form)
        {
            SetForm(form);

            SetCommon(form);

            SetMenu1(form);

            SetMenu2(form);

            SetMenu2_1(form);

            SetMenu2_2(form);
        }

        // Form 設定反映
        private void SetForm(MainForm form)
        {
            form.Width = Properties.Settings.Default.form_x;
            form.Height = Properties.Settings.Default.form_y;
        }

        private void SetCommon(MainForm form)
        {
            // ダークモード
            if (Properties.Settings.Default.common_mode)
            {
                form.common_panel_setting_table_check1.Checked = true;
            }
            else
            {
                form.common_panel_setting_table_check1.Checked = false;
            }
            // メニュー切り替え
            controls_event.common_events.ChangeMenu(form);
            // 表示モード切り替え
            controls_event.common_events.ChangeDarkMode(form);
        }

        private void SetMenu1(MainForm form)
        {
            string[] date = { "日", "月", "火", "水", "木", "金", "土" };
            DateTime now = DateTime.Now;
            DayOfWeek dow = now.DayOfWeek;
            string label_day = now.ToShortDateString() + " (" + date[(int)dow] + ")";

            Common_Var.menu1_done_year = now.Year;
            Common_Var.menu1_done_month = now.Month;
            Common_Var.menu1_done_day = now.Day;

            form.menu1_done_top_label_day.Text = label_day;

            int sumtime = 0;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                Common_Var.menu1_done += 1;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                    && Properties.Settings.Default.done_day[i] == Common_Var.menu1_done_year.ToString() + "/" + Common_Var.menu1_done_month.ToString() + "/" + Common_Var.menu1_done_day.ToString())
                {
                    controls_event.menu1_events.InitAddDone(form, Properties.Settings.Default.done_name[i], Properties.Settings.Default.done_time[i]);
                    sumtime += int.Parse(Properties.Settings.Default.done_time[i]);
                }
            }

            form.menu1_done_top_label_hour.Text = "";
            form.menu1_done_top_label_hour.BackColor = Color.Transparent;
            if (sumtime / 60 != 0)
            {
                form.menu1_done_top_label_hour.Text += (sumtime / 60).ToString() + "h";
                if (sumtime / 60 >= 12)
                {
                    form.menu1_done_top_label_hour.BackColor = Common_Const.color_done2;
                }
                else
                {
                    form.menu1_done_top_label_hour.BackColor = Common_Const.color_done1;
                }
            }
            else if (sumtime > 0)
            {
                form.menu1_done_top_label_hour.BackColor = Main.Common_Const.color_done1;
            }
            if (sumtime % 60 != 0)
            {
                form.menu1_done_top_label_hour.Text += (sumtime % 60).ToString() + "m";
            }
            form.menu1_done_top_label_hour.Refresh();

            if (Common_Var.menu1_day_done == 0)
            {
                controls_event.menu1_events.ChangeDoneNum(form);
            }
        }

        // Menu2 設定反映
        private void SetMenu2(MainForm form)
        {
            if (Properties.Settings.Default.order[0] == "1")
            {
                form.menu2_1.BringToFront();
                form.menu2_2.BringToFront();
            }
            else
            {
                form.menu2_2.BringToFront();
                form.menu2_1.BringToFront();
            }
        }

        // Menu2_1 設定反映
        private void SetMenu2_1(MainForm form)
        {
            // 保存されているタスク反映
            for (int i = 0; i < Properties.Settings.Default.task_name.Count; i++)
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.task_name[i]))
                {
                    controls_event.menu2_1_events.InitAddTask(form, Properties.Settings.Default.task_name[i]);
                }
            }
            if (Common_Var.menu2_1_task == 0) // タスク数が0の時、タスク表示が更新されないため、更新
            {
                controls_event.menu2_1_events.ChangeTaskNum(form);
            }

            // menu2 1 開いているか
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            if (Properties.Settings.Default.menu2_open1)
            {
                form.menu2_1_panel_main.Visible = true;
                form.menu2_1_panel_top_button_openclose.BackgroundImage = ((Image)(resources.GetObject("menu2_1_panel_top_button_openclose_close.Image")));
                form.tooltip.SetToolTip(form.menu2_1_panel_top_button_openclose, "閉じる");
            }
            else
            {
                form.menu2_1_panel_main.Visible = false;
                form.menu2_1_panel_top_button_openclose.BackgroundImage = ((Image)(resources.GetObject("menu2_1_panel_top_button_openclose_open.Image")));
                form.tooltip.SetToolTip(form.menu2_1_panel_top_button_openclose, "開く");
            }

            menu2_1_MoveMenu = new DAndDMoveMenu(form.menu2_1_panel_top, form);
        }

        // Menu2_2 設定反映
        private void SetMenu2_2(MainForm form)
        {
            FileUtil fu = new FileUtil();
            for (int i = 0; i < Properties.Settings.Default.memo_path.Count; i++)
            {
                if (!String.IsNullOrEmpty(Properties.Settings.Default.memo_path[i]))
                {
                    controls_event.menu2_2_events.AddMemo(form, Properties.Settings.Default.memo_path[i], fu.ReadFileAll(Properties.Settings.Default.memo_path[i]), int.Parse(Properties.Settings.Default.memo_height[i]), Convert.ToBoolean(Properties.Settings.Default.memo_wrap[i]));
                    Common_Var.memo_save.Add(true);
                }
            }

            if (Common_Var.menu2_2_memo == 0) // メモ数が0の時、メモ表示が更新されないため、更新
            {
                controls_event.menu2_2_events.ChangeMemoNum(form);
            }

            // menu2 2 開いているか
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            if (Properties.Settings.Default.menu2_open2)
            {
                form.menu2_2_panel_main.Visible = true;
                form.menu2_2_panel_top_button_openclose.BackgroundImage = ((Image)(resources.GetObject("menu2_1_panel_top_button_openclose_close.Image")));
                form.tooltip.SetToolTip(form.menu2_2_panel_top_button_openclose, "閉じる");
            }
            else
            {
                form.menu2_2_panel_main.Visible = false;
                form.menu2_2_panel_top_button_openclose.BackgroundImage = ((Image)(resources.GetObject("menu2_1_panel_top_button_openclose_open.Image")));
                form.tooltip.SetToolTip(form.menu2_2_panel_top_button_openclose, "開く");
            }

            menu2_2_MoveMenu = new DAndDMoveMenu(form.menu2_2_panel_top, form);
        }

        // commonをタイトルバーにする初期化
        private void SetMoveForm(MainForm form)
        {
            common_MoveForm = new DAndDMoveForm(form.common, form);
        }

        // 現在日時を設定
        private void Set_NowDay(MainForm form)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            Common_Var.today_year = year;
            Common_Var.today_month = month;
            Common_Var.today_day = day;
            controls_event.common_events.Set_Day(form, year, month);
        }

        // カレンダーの年、月をセット
        private void Set_NowYearMonth(MainForm form)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            string[] years = new string[5];

            years[0] = DateTime.Now.AddYears(-2).Year.ToString();
            years[1] = DateTime.Now.AddYears(-1).Year.ToString();
            years[2] = DateTime.Now.Year.ToString();
            years[3] = DateTime.Now.AddYears(1).Year.ToString();
            years[4] = DateTime.Now.AddYears(2).Year.ToString();

            form.menu1_panel_yearmonth_combo_year.Items.AddRange(years);
            form.menu1_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        #endregion private
    }
}
