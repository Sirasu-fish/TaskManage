using System;

namespace TaskManage.Main
{
    internal class Init
    {
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



        // private
        #region private

        private static DAndDSizeChanger[] menu2_2_panel_main_table_memo_sizeChanger = new DAndDSizeChanger[99];
        private static DAndDSizeChanger this_sizeChanger;
        private static DAndDMoveForm common_MoveForm;




        #endregion private

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

            // メモ折り返し
            if (Properties.Settings.Default.menu2_memowrap)
            {
                form.common_panel_setting_table_check3.Checked = true;
                //form.menu2_2_panel_main_panel1_table_memo_text.WordWrap = true;
                //form.menu2_2_panel_main_panel2_table_memo_text.WordWrap = true;
                //form.menu2_2_panel_main_panel3_table_memo_text.WordWrap = true;
                //form.menu2_2_panel_main_panel4_table_memo_text.WordWrap = true;
                //form.menu2_2_panel_main_panel5_table_memo_text.WordWrap = true;
            }
            else
            {
                form.common_panel_setting_table_check3.Checked = false;
                //form.menu2_2_panel_main_panel1_table_memo_text.WordWrap = false;
                //form.menu2_2_panel_main_panel2_table_memo_text.WordWrap = false;
                //form.menu2_2_panel_main_panel3_table_memo_text.WordWrap = false;
                //form.menu2_2_panel_main_panel4_table_memo_text.WordWrap = false;
                //form.menu2_2_panel_main_panel5_table_memo_text.WordWrap = false;
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

            SetMenu2_2(form);
        }

        private void SetMenu2_2(MainForm form)
        {
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
            // メモ展開
            if (Properties.Settings.Default.memo_path == null)
            {
                Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.memo_path.AddRange(new string[99]);
                Properties.Settings.Default.Save();
            }
            else
            {
                if (Properties.Settings.Default.memo_path.Count > 99)
                {
                    Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
                    Properties.Settings.Default.memo_path.AddRange(new string[99]);
                    Properties.Settings.Default.Save();
                }
                else
                {
                    string[] paths = new string[99];
                    Properties.Settings.Default.memo_path.CopyTo(paths, 0);
                    int num = 0;
                    for (int i = 0; i < paths.Length; i++)
                    {
                        if (String.IsNullOrEmpty(paths[i]))
                        {
                            num++;
                        }
                    }
                    Properties.Settings.Default.memo_path = new System.Collections.Specialized.StringCollection();
                    Properties.Settings.Default.memo_path.AddRange(paths);
                    Properties.Settings.Default.Save();
                }
            }

            string[] path = new string[99];
            Properties.Settings.Default.memo_path.CopyTo(path, 0);
            for (int i = 0; i < path.Length; i++)
            {
                if (!String.IsNullOrEmpty(path[i]))
                {
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Text = path[i];
                    form.menu2_2_panel_main_panel_table_memo_text[i].Text = fu.ReadFileAll(path[i]);
                    form.menu2_2_panel_main_panel[i].Visible = false;
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
    }
}
