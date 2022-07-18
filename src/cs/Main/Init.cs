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

        // 設定値の初期化
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
            if (Properties.Settings.Default.menu2_open1)
            {
                form.menu2_1_panel_main.Visible = true;
            }
            else
            {
                form.menu2_1_panel_main.Visible = false;
            }
        }

        // Menu2_2 設定反映
        private void SetMenu2_2(MainForm form)
        {
            for (int i = 0; i < Common_Var.memo_save.Length; i++)
            {
                Common_Var.memo_save[i] = false;
            }

            FileUtil fu = new FileUtil();
            for (int i = 0; i < Properties.Settings.Default.memo_path.Count - 1; i++)
            {
                if (!String.IsNullOrEmpty(Properties.Settings.Default.memo_path[i]))
                {
                    controls_event.menu2_2_events.AddMemo(form, Properties.Settings.Default.memo_path[i], fu.ReadFileAll(Properties.Settings.Default.memo_path[i]));
                    Common_Var.memo_save[i] = true;
                }
            }

            if (Common_Var.menu2_2_memo == 0) // メモ数が0の時、メモ表示が更新されないため、更新
            {
                controls_event.menu2_2_events.ChangeMemoNum(form);
            }

            // menu2 2 開いているか
            if (Properties.Settings.Default.menu2_open2)
            {
                form.menu2_2_panel_main.Visible = true;
            }
            else
            {
                form.menu2_2_panel_main.Visible = false;
            }

            // メモ折り返し
            if (Properties.Settings.Default.menu2_memowrap)
            {
                form.common_panel_setting_table_check2.Checked = true;
                for (int i = 0; i < Properties.Settings.Default.memo_path.Count - 1; i++)
                {
                    //form.menu2_2_panel_main_panel_table_memo_text[i].WordWrap = true;
                }
            }
            else
            {
                form.common_panel_setting_table_check2.Checked = false;
                for (int i = 0; i < Properties.Settings.Default.memo_path.Count - 1; i++)
                {
                    //form.menu2_2_panel_main_panel_table_memo_text[i].WordWrap = false;
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
                //menu2_2_panel_main_table_memo_sizeChanger[i] = new DAndDSizeChanger(form.menu2_2_panel_main_panel_table_memo_text[i], form.menu2_2_panel_main_panel[i], DAndDArea.Bottom, 12, form.menu2_2);
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

            form.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.Items.AddRange(years);
            form.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        #endregion private


    }
}
