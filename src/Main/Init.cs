using System;

namespace TaskManage.Main
{
    internal class Init
    {
        private static DAndDSizeChanger menu2_2_panel_main_table_memo1_sizeChanger;
        private static DAndDSizeChanger menu2_2_panel_main_table_memo2_sizeChanger;
        private static DAndDSizeChanger menu2_2_panel_main_table_memo3_sizeChanger;
        private static DAndDSizeChanger menu2_2_panel_main_table_memo4_sizeChanger;
        private static DAndDSizeChanger menu2_2_panel_main_table_memo5_sizeChanger;
        private static DAndDSizeChanger this_sizeChanger;
        private static DAndDMoveForm common_MoveForm;

        public void initialize(MainForm form)
        {

            // commonをタイトルバー化する
            SetMoveForm(form);
            // 設定を反映
            RefrectSetting(form);
            // メニュー切り替え
            controls_event.common_events.ChangeMenu(form);
            // 表示モード切り替え
            controls_event.common_events.ChangeDarkMode(form);
            // menu2 panel3 のメモのサイズ変更イベント定義
            SetSizeChanger(form);

            Set_NowDay(form);
            Set_NowYearMonth(form);
        }

        // 設定を反映
        private void RefrectSetting(MainForm form)
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

            // メモ文字サイズ
            if (Properties.Settings.Default.menu2_fontsize != 0)
            {

            }
            else
            {

            }

            // メモ折り返し
            if (Properties.Settings.Default.menu2_memowrap)
            {
                form.common_panel_setting_table_check3.Checked = true;
                form.menu2_2_panel_main_panel1_table_memo_text.WordWrap = true;
                form.menu2_2_panel_main_panel2_table_memo_text.WordWrap = true;
                form.menu2_2_panel_main_panel3_table_memo_text.WordWrap = true;
                form.menu2_2_panel_main_panel4_table_memo_text.WordWrap = true;
                form.menu2_2_panel_main_panel5_table_memo_text.WordWrap = true;
            }
            else
            {
                form.common_panel_setting_table_check3.Checked = false;
                form.menu2_2_panel_main_panel1_table_memo_text.WordWrap = false;
                form.menu2_2_panel_main_panel2_table_memo_text.WordWrap = false;
                form.menu2_2_panel_main_panel3_table_memo_text.WordWrap = false;
                form.menu2_2_panel_main_panel4_table_memo_text.WordWrap = false;
                form.menu2_2_panel_main_panel5_table_memo_text.WordWrap = false;
            }

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

            // menu2 3 開いているか
            if (Properties.Settings.Default.menu2_open3)
            {
                form.menu2_3_panel_main.Visible = true;
                form.menu2_3_panel.Height = 934;
                form.menu2_3.Height = 942;
            }
            else
            {
                form.menu2_3_panel_main.Visible = false;
                form.menu2_3_panel.Height = 34;
                form.menu2_3.Height = 42;
            }

            // フォームサイズ x
            if (Properties.Settings.Default.form_x != 0)
            {
                form.Width = Properties.Settings.Default.form_x;
            }
            else
            {
            }

            // フォームサイズ y
            if (Properties.Settings.Default.form_y != 0)
            {
                form.Height = Properties.Settings.Default.form_y;
            }
            else
            {
            }

            FileUtil fu = new FileUtil();
            // メモ1展開
            if (Properties.Settings.Default.memo_path1 != "")
            {
                form.menu2_2_panel_main_panel1_table_memo_panel_top_text.Text = Properties.Settings.Default.memo_path1;
                form.menu2_2_panel_main_panel1_table_memo_text.Text = fu.ReadFileAll(Properties.Settings.Default.memo_path1);
            }
            if (Properties.Settings.Default.memo_path2 != "")
            {
                form.menu2_2_panel_main_panel2_table_memo_panel_top_text.Text = Properties.Settings.Default.memo_path2;
                form.menu2_2_panel_main_panel2_table_memo_text.Text = fu.ReadFileAll(Properties.Settings.Default.memo_path2);
            }
            if (Properties.Settings.Default.memo_path3 != "")
            {
                form.menu2_2_panel_main_panel3_table_memo_panel_top_text.Text = Properties.Settings.Default.memo_path3;
                form.menu2_2_panel_main_panel3_table_memo_text.Text = fu.ReadFileAll(Properties.Settings.Default.memo_path3);
            }
            if (Properties.Settings.Default.memo_path4 != "")
            {
                form.menu2_2_panel_main_panel4_table_memo_panel_top_text.Text = Properties.Settings.Default.memo_path4;
                form.menu2_2_panel_main_panel4_table_memo_text.Text = fu.ReadFileAll(Properties.Settings.Default.memo_path4);
            }
            if (Properties.Settings.Default.memo_path5 != "")
            {
                form.menu2_2_panel_main_panel5_table_memo_panel_top_text.Text = Properties.Settings.Default.memo_path5;
                form.menu2_2_panel_main_panel5_table_memo_text.Text = fu.ReadFileAll(Properties.Settings.Default.memo_path5);
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
            menu2_2_panel_main_table_memo1_sizeChanger = new DAndDSizeChanger(form.menu2_2_panel_main_panel1_table_memo_text, form.menu2_2_panel_main_panel1, DAndDArea.Bottom, 12, form.menu2_2);
            menu2_2_panel_main_table_memo2_sizeChanger = new DAndDSizeChanger(form.menu2_2_panel_main_panel2_table_memo_text, form.menu2_2_panel_main_panel2, DAndDArea.Bottom, 12, form.menu2_2);
            menu2_2_panel_main_table_memo3_sizeChanger = new DAndDSizeChanger(form.menu2_2_panel_main_panel3_table_memo_text, form.menu2_2_panel_main_panel3, DAndDArea.Bottom, 12, form.menu2_2);
            menu2_2_panel_main_table_memo4_sizeChanger = new DAndDSizeChanger(form.menu2_2_panel_main_panel4_table_memo_text, form.menu2_2_panel_main_panel4, DAndDArea.Bottom, 12, form.menu2_2);
            menu2_2_panel_main_table_memo5_sizeChanger = new DAndDSizeChanger(form.menu2_2_panel_main_panel5_table_memo_text, form.menu2_2_panel_main_panel5, DAndDArea.Bottom, 12, form.menu2_2);
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
    }
}
