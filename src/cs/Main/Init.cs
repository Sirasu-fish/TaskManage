using System;

namespace TaskManage.Main
{
    internal class Init
    {
        public void initialize(MainForm form)
        {
            // 設定値の初期化
            SetPropertiesValue();
            // commonをタイトルバー化する
            SetMoveForm(form);
            // 設定を反映
            RefrectSetting(form);

            // menu2 panel3 のメモのサイズ変更イベント定義
            SetSizeChanger(form);

            Set_NowDay(form);
            Set_NowYearMonth(form);
        }

        // private
        #region private

        private static DAndDSizeChanger[] menu2_2_panel_main_table_memo_sizeChanger = new DAndDSizeChanger[99];
        private static DAndDSizeChanger this_sizeChanger;
        private static DAndDMoveForm common_MoveForm;

        private void SetPropertiesValue()
        {
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

            // メモのパス
            if (Properties.Settings.Default.memo_path == null || Properties.Settings.Default.memo_path.Count > Common_Const.memo_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.memo_path.AddRange(new string[Common_Const.memo_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.memo_num];
                Properties.Settings.Default.memo_path.CopyTo(tmp, 0);
                Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.memo_path.AddRange(tmp);
            }

            // メモの高さ
            if (Properties.Settings.Default.memo_height == null || Properties.Settings.Default.memo_height.Count > Common_Const.memo_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.memo_height = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.memo_height.AddRange(new string[Common_Const.memo_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.memo_num];
                Properties.Settings.Default.memo_height.CopyTo(tmp, 0);
                Properties.Settings.Default.memo_height = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.memo_height.AddRange(tmp);
            }

            // タスク名
            if (Properties.Settings.Default.task_name == null || Properties.Settings.Default.task_name.Count > Common_Const.task_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.task_name = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.task_name.AddRange(new string[Common_Const.task_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.task_num];
                Properties.Settings.Default.task_name.CopyTo(tmp, 0);
                Properties.Settings.Default.task_name = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.task_name.AddRange(tmp);
            }

            // タスク備考
            if (Properties.Settings.Default.task_memo == null || Properties.Settings.Default.task_memo.Count > Common_Const.task_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.task_memo = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.task_memo.AddRange(new string[Common_Const.task_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.task_num];
                Properties.Settings.Default.task_memo.CopyTo(tmp, 0);
                Properties.Settings.Default.task_memo = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.task_memo.AddRange(tmp);
            }

            // 実績名
            if (Properties.Settings.Default.done_name == null || Properties.Settings.Default.done_name.Count > Common_Const.done_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.done_name = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_name.AddRange(new string[Common_Const.done_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.done_num];
                Properties.Settings.Default.done_name.CopyTo(tmp, 0);
                Properties.Settings.Default.done_name = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_name.AddRange(tmp);
            }

            // 実績備考
            if (Properties.Settings.Default.done_memo == null || Properties.Settings.Default.done_memo.Count > Common_Const.done_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.done_memo = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_memo.AddRange(new string[Common_Const.done_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.done_num];
                Properties.Settings.Default.done_memo.CopyTo(tmp, 0);
                Properties.Settings.Default.done_memo = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_memo.AddRange(tmp);
            }

            // 実績進捗
            if (Properties.Settings.Default.done_prog == null || Properties.Settings.Default.done_prog.Count > Common_Const.done_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.done_prog = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_prog.AddRange(new string[Common_Const.done_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.done_num];
                Properties.Settings.Default.done_prog.CopyTo(tmp, 0);
                Properties.Settings.Default.done_prog = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_prog.AddRange(tmp);
            }

            // 実績時間
            if (Properties.Settings.Default.done_time == null || Properties.Settings.Default.done_time.Count > Common_Const.done_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.done_time = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_time.AddRange(new string[Common_Const.done_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.done_num];
                Properties.Settings.Default.done_time.CopyTo(tmp, 0);
                Properties.Settings.Default.done_time = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_time.AddRange(tmp);
            }

            // 実績日
            if (Properties.Settings.Default.done_day == null || Properties.Settings.Default.done_day.Count > Common_Const.done_num) //null or 指定数以上ある場合は初期化
            {
                Properties.Settings.Default.done_day = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_day.AddRange(new string[Common_Const.done_num]);
            }
            else
            {
                string[] tmp = new string[Common_Const.done_num];
                Properties.Settings.Default.done_day.CopyTo(tmp, 0);
                Properties.Settings.Default.done_day = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.done_day.AddRange(tmp);
            }

            Properties.Settings.Default.Save();
        }

        // 設定を反映
        private void RefrectSetting(MainForm form)
        {
            SetForm(form);

            SetCommon(form);

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

        // Menu2 設定反映
        private void SetMenu2(MainForm form)
        {
            controls_event.menu2_events.RefrectMoveControl(form);
        }

        // Menu2_1 設定反映
        private void SetMenu2_1(MainForm form)
        {
            // menu2 1 開いているか
            if (Properties.Settings.Default.menu2_open1)
            {
                form.menu2_1_panel_main.Visible = true;
                form.menu2_1_panel.Height = 936;
                form.menu2_1.Height = 944;
            }
            else
            {
                form.menu2_1_panel_main.Visible = false;
                form.menu2_1_panel.Height = 34;
                form.menu2_1.Height = 42;
            }
        }

        // Menu2_2 設定反映
        private void SetMenu2_2(MainForm form)
        {
            for (int i = 0; i < Common_Var.memo_save.Length; i++)
            {
                Common_Var.memo_save[i] = false;
            }

            // menu2 2 開いているか
            if (Properties.Settings.Default.menu2_open2)
            {
                form.menu2_2_panel_main.Visible = true;
                form.menu2_2_panel.Height = 562;
                form.menu2_2.Height = 570;
            }
            else
            {
                form.menu2_2_panel_main.Visible = false;
                form.menu2_2_panel.Height = 34;
                form.menu2_2.Height = 42;
            }

            FileUtil fu = new FileUtil();
            string[] path = new string[Common_Const.memo_num];
            Properties.Settings.Default.memo_path.CopyTo(path, 0);
            for (int i = 0; i < path.Length; i++)
            {
                if (!String.IsNullOrEmpty(path[i]))
                {
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = path[i]; // タイトル
                    form.menu2_2_panel_main_panel_table_memo_text[i].Text = fu.ReadFileAll(path[i]); // 内容
                    form.menu2_2_panel_main_panel[i].Visible = true; // 非表示
                    Common_Var.memo_save[i] = true;
                }
                else
                {
                    form.menu2_2_panel_main_panel[i].Visible = false; // 非表示
                }
            }

            // メモ折り返し
            if (Properties.Settings.Default.menu2_memowrap)
            {
                form.common_panel_setting_table_check3.Checked = true;
                for (int i = 0; i < path.Length; i++)
                {
                    form.menu2_2_panel_main_panel_table_memo_text[i].WordWrap = true;
                }
            }
            else
            {
                form.common_panel_setting_table_check3.Checked = false;
                for (int i = 0; i < path.Length; i++)
                {
                    form.menu2_2_panel_main_panel_table_memo_text[i].WordWrap = false;
                }
            }
        }

        // commonをタイトルバーにする初期化
        private void SetMoveForm(MainForm form)
        {
            common_MoveForm = new DAndDMoveForm(form.common, form);
        }

        // menu2 panel2 のメモのサイズ変更イベント定義
        private void SetSizeChanger(MainForm form)
        {
            for (int i = 0; i < menu2_2_panel_main_table_memo_sizeChanger.Length; i++)
            {
                menu2_2_panel_main_table_memo_sizeChanger[i] = new DAndDSizeChanger(form.menu2_2_panel_main_panel_table_memo_text[i], form.menu2_2_panel_main_panel[i], DAndDArea.Bottom, 12, form.menu2_2);
            }
            this_sizeChanger = new DAndDSizeChanger(form, form, DAndDArea.All, 24);
        }

        // 現在日時を設定
        private void Set_NowDay(MainForm form)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
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

            form.menu1_panel_calendertop_panel_yearmonth_combo_year.Items.AddRange(years);
            form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }


        #endregion private


    }
}
