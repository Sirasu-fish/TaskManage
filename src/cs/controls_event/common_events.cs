﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class common_events
    {
        // ダブルクリック時の動作
        public static void common_MouseDoubleClick(MainForm form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        // 最小化ボタン
        public static void common_button_min_MouseClick(MainForm form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        // 最大化ボタン
        public static void common_button_max_MouseClick(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                form.common_button_max.Image = ((System.Drawing.Image)(resources.GetObject("common_button_max.Image"))); ;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
                form.common_button_max.Image = ((System.Drawing.Image)(resources.GetObject("common_button_min.Image")));
            }
        }

        // 閉じるボタン
        public static void common_button_close_MouseClick(MainForm form)
        {
            form.Close();
        }

        // 閉じるボタンホバー時の動作
        public static void common_button_close_MouseEnter(MainForm form)
        {
            form.common_button_close.BackColor = Color.FromArgb(50, 255, 128, 128);
        }

        // 閉じるボタンLeave時の動作
        public static void common_button_close_MouseLeave(MainForm form)
        {
            form.common_button_close.BackColor = Color.Transparent;
        }

        // 設定ボタン押下
        public static void common_button_setting_Click(MainForm form)
        {
            if (form.common_panel_setting.Visible == false)
            {
                form.common_panel_setting.Visible = true;
            }
            else
            {
                form.common_panel_setting.Visible = false;
            }
        }

        // ダークモード切り替え
        public static void common_panel_setting_table_check1_CheckedChanged(MainForm form)
        {
            if (form.common_panel_setting_table_check1.Checked)
            {
                Properties.Settings.Default.common_mode = true;
            }
            else
            {
                Properties.Settings.Default.common_mode = false;
            }
            ChangeDarkMode(form);
        }

        // 前メニューへ移動する時の動作
        public static void common_button_prevmenu_Click(MainForm form)
        {

            form.common_panel_setting.Visible = false;
            Main.Common_Var.menu -= 1;
            ChangeMenu(form);
        }

        // 次メニューへ移動する時の動作
        public static void common_button_nextmenu_Click(MainForm form)
        {
            form.common_panel_setting.Visible = false;
            Main.Common_Var.menu += 1;
            ChangeMenu(form);
        }

        // private
        #region private

        // 表示モード切り替え
        public static void ChangeDarkMode(MainForm form)
        {
            if (Properties.Settings.Default.common_mode)
            {
                Main.Common_Var.main_color = Properties.Settings.Default.dark;
                Main.Common_Var.sub_color = Properties.Settings.Default.white;
                Main.Common_Var.submain_color = Properties.Settings.Default.subdark;
                Main.Common_Var.subsub_color = Properties.Settings.Default.subwhite;
            }
            else
            {
                Main.Common_Var.main_color = Properties.Settings.Default.white;
                Main.Common_Var.sub_color = Properties.Settings.Default.dark;
                Main.Common_Var.submain_color = Properties.Settings.Default.subwhite;
                Main.Common_Var.subsub_color = Properties.Settings.Default.subdark;
            }

            // 全体
            form.BackColor = Main.Common_Var.main_color;

            // common
            form.common_panel_setting_table_setting.BackColor = Main.Common_Var.main_color;
            form.common_panel_setting.BackColor = Main.Common_Var.sub_color;
            form.common_panel_setting_table_label1.ForeColor = Main.Common_Var.sub_color;
            form.common_panel_setting_table_label2.ForeColor = Main.Common_Var.sub_color;
            form.common_panel_setting_table_label3.ForeColor = Main.Common_Var.sub_color;

            // 〇menu1
            // カレンダーの日にちの背景色を変更
            form.menu1_panel_calendertop_panel_yearmonth_label_year.ForeColor = Main.Common_Var.sub_color;
            form.menu1_panel_calendertop_panel_yearmonth_label_month.ForeColor = Main.Common_Var.sub_color;

            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                form.menu1_table_calender_panel_day[i].BackColor = Main.Common_Var.submain_color;
            }

            // カレンダーの曜日の文字色を変更
            form.menu1_table_calender_label_sunday.ForeColor = Main.Common_Var.sub_color;
            form.menu1_table_calender_label_monday.ForeColor = Main.Common_Var.sub_color;
            form.menu1_table_calender_label_tuesday.ForeColor = Main.Common_Var.sub_color;
            form.menu1_table_calender_label_wednesday.ForeColor = Main.Common_Var.sub_color;
            form.menu1_table_calender_label_thursday.ForeColor = Main.Common_Var.sub_color;
            form.menu1_table_calender_label_friday.ForeColor = Main.Common_Var.sub_color;
            form.menu1_table_calender_label_saturday.ForeColor = Main.Common_Var.sub_color;

            int year = DateTime.Now.Year; // 問題あり　月変更後モード変えるとおかしい
            int month = DateTime.Now.Month; // 問題あり　月変更後モード変えるとおかしい
            Set_Day(form, year, month);

            // menu2
            form.menu2_1_panel_top_label_title.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel1_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel1_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel2_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel2_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel3_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel3_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel4_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel4_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel5_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel5_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel6_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel6_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel7_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel7_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel8_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel8_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel9_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel9_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel10_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel10_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel11_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel11_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel12_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel12_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel13_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel13_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel14_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel14_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel15_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel15_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel16_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel16_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel17_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel17_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel18_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel18_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel19_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel19_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel20_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel20_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel21_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel21_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel22_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel22_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel23_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel23_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel24_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel24_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel25_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel25_label2.ForeColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel1.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel2.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel3.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel4.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel5.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel6.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel7.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel8.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel9.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel10.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel11.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel12.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel13.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel14.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel15.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel16.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel17.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel18.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel19.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel20.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel21.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel22.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel23.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel24.BorderColor = Main.Common_Var.sub_color;
            form.menu2_1_panel_main_panel25.BorderColor = Main.Common_Var.sub_color;

            form.menu2_2_panel_top_label_title.ForeColor = Main.Common_Var.sub_color;

            form.menu2_3_panel_top_label_title.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel1_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel2_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel3_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel4_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel5_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel6_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel7_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel8_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel9_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel10_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel11_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel12_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel13_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel14_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel15_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel16_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel17_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel18_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel19_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel20_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel21_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel22_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel23_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel24_label1.ForeColor = Main.Common_Var.sub_color;
            form.menu2_3_panel_main_panel25_label1.ForeColor = Main.Common_Var.sub_color;
        }

        // メニュー切り替え
        public static void ChangeMenu(MainForm form)
        {
            switch (Main.Common_Var.menu)
            {
                case 1: //メイン画面
                    form.menu1.Visible = true;
                    form.menu2.Visible = false;
                    form.menutask.Visible = false;
                    form.menuachieve.Visible = false;
                    form.menu3.Visible = false;
                    form.common_button_prevmenu.Visible = false;
                    form.common_button_nextmenu.Visible = true;
                    break;
                case 2: //タスク画面
                    form.menu1.Visible = false;
                    form.menu2.Visible = true;
                    form.menutask.Visible = false;
                    form.menuachieve.Visible = false;
                    form.menu3.Visible = false;
                    form.common_button_prevmenu.Visible = true;
                    form.common_button_nextmenu.Visible = true;
                    break;
                case 3: //実績画面
                    form.menu1.Visible = false;
                    form.menu2.Visible = false;
                    form.menutask.Visible = false;
                    form.menuachieve.Visible = false;
                    form.menu3.Visible = true;
                    form.common_button_prevmenu.Visible = true;
                    form.common_button_nextmenu.Visible = false;
                    break;
                default:
                    Main.Common_Var.menu = 1;
                    ChangeMenu(form);
                    break;
            }
        }

        // カレンダーに日にちをセット
        public static void Set_Day(MainForm form, int year, int month)
        {
            DateTime today = DateTime.Now;
            int[] days = new int[42];
            int sub_day = 0;
            DateTime firstday = new DateTime(year, month, 1);
            int today_int = -1;
            Get_Calender(year, month, ref today, ref days, ref sub_day, ref firstday, ref today_int);

            DayOfWeek firstdate = firstday.DayOfWeek;

            Color today_color = Color.FromArgb(255, 128, 0);
            Color panel_color = Main.Common_Var.submain_color;
            Color main_text_color = Main.Common_Var.sub_color;
            Color sub_text_color = Main.Common_Var.subsub_color;

            Font main_font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Font sub_font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                form.menu1_table_calender_label_day[i].Text = days[i].ToString();　// 日付をセットする
            }


            for (int i = 0; i < form.menu1_table_calender_label_day.Length; i++)
            {
                form.menu1_table_calender_label_day[i].ForeColor = main_text_color; // カレンダーの全ての文字色を変更する
                form.menu1_table_calender_label_day[i].Font = main_font; // カレンダーの全てのフォントを変更する
            }

            // 前の月の文字色、フォントを変更する
            for (int i = 0; i <= (int)firstdate - 1; i++)
            {
                form.menu1_table_calender_label_day[i].ForeColor = sub_text_color;
                form.menu1_table_calender_label_day[i].Font = sub_font;
            }

            // 次の月の文字色、フォントを変更する
            for (int i = 41; i >= sub_day; i--)
            {
                form.menu1_table_calender_label_day[i].Font = sub_font;
            }

            // カレンダーの日にちの背景色を変更
            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                form.menu1_table_calender_panel_day[i].BackColor = Main.Common_Var.submain_color;
            }

            // 現在日がカレンダーに存在する場合はパネルの色を変更する
            if (0 <= today_int && today_int <= 41)
            {
                form.menu1_table_calender_panel_day[today_int].BackColor = today_color;
            }
        }

        // カレンダーの日にちと今月ではない日を取得
        private static void Get_Calender(int year, int month, ref DateTime today, ref int[] days, ref int sub_day, ref DateTime firstday, ref int today_int)
        {
            today = DateTime.Now;
            today_int = -1;

            firstday = new DateTime(year, month, 1);
            DayOfWeek firstdate = firstday.DayOfWeek;
            days = new int[42];

            sub_day = 0;
            Boolean subday_flg = false;

            DateTime inputday = firstday.AddDays(-1);

            for (int i = (int)firstdate - 1; i >= 0; i--)
            {
                days[i] = inputday.Day;
                if (today.Year == inputday.Year && today.Month == inputday.Month && today.Day == inputday.Day)
                {
                    today_int = i;
                }
                inputday = inputday.AddDays(-1);
            }
            inputday = firstday;
            for (int i = (int)firstdate; i <= 41; i++)
            {
                days[i] = inputday.Day;
                if (today.Year == inputday.Year && today.Month == inputday.Month && today.Day == inputday.Day)
                {
                    today_int = i;
                }
                if (month != inputday.Month && subday_flg == false)
                {
                    sub_day = i;
                    subday_flg = true;
                }
                inputday = inputday.AddDays(1);
            }
        }

        #endregion private

    }
}
