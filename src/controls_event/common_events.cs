using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class common_events
    {
        static readonly Color dark = Color.FromArgb(40, 40, 40); //ダークモード 基本色
        static readonly Color white = Color.FromArgb(240, 240, 240); //ライトモード 基本色
        static readonly Color subdark = Color.FromArgb(80, 80, 80); //ダークモード サブ色
        static readonly Color subwhite = Color.FromArgb(220, 220, 220); //ライトモード サブ色
        private static Color main_color = dark;
        private static Color sub_color = white;
        private static Color submain_color = subdark;
        private static Color subsub_color = subwhite;
        private static int menu = -1;

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
            ChangeDarkMode(form, Properties.Settings.Default.common_mode);
        }

        // 前メニューへ移動する時の動作
        public static void common_button_prevmenu_Click(MainForm form)
        {

            form.common_panel_setting.Visible = false;
            menu -= 1;
            ChangeMenu(form, menu);
        }

        // 次メニューへ移動する時の動作
        public static void common_button_nextmenu_Click(MainForm form)
        {
            form.common_panel_setting.Visible = false;
            menu += 1;
            ChangeMenu(form, menu);
        }

        // private
        #region private

        // 表示モード切り替え
        private static void ChangeDarkMode(MainForm form, Boolean darkmode)
        {
            if (darkmode)
            {
                main_color = dark;
                sub_color = white;
                submain_color = subdark;
                subsub_color = subwhite;
            }
            else
            {
                main_color = white;
                sub_color = dark;
                submain_color = subwhite;
                subsub_color = subdark;
            }

            // 全体
            form.BackColor = main_color;

            // common
            form.common_panel_setting_table_setting.BackColor = main_color;
            form.common_panel_setting.BackColor = sub_color;
            form.common_panel_setting_table_label1.ForeColor = sub_color;
            form.common_panel_setting_table_label2.ForeColor = sub_color;
            form.common_panel_setting_table_label3.ForeColor = sub_color;

            // 〇menu1
            // カレンダーの日にちの背景色を変更
            form.menu1_panel_calendertop_panel_yearmonth_label_year.ForeColor = sub_color;
            form.menu1_panel_calendertop_panel_yearmonth_label_month.ForeColor = sub_color;

            form.menu1_table_calender_panel_day1.BackColor = submain_color;
            form.menu1_table_calender_panel_day2.BackColor = submain_color;
            form.menu1_table_calender_panel_day3.BackColor = submain_color;
            form.menu1_table_calender_panel_day4.BackColor = submain_color;
            form.menu1_table_calender_panel_day5.BackColor = submain_color;
            form.menu1_table_calender_panel_day6.BackColor = submain_color;
            form.menu1_table_calender_panel_day7.BackColor = submain_color;
            form.menu1_table_calender_panel_day8.BackColor = submain_color;
            form.menu1_table_calender_panel_day9.BackColor = submain_color;
            form.menu1_table_calender_panel_day10.BackColor = submain_color;
            form.menu1_table_calender_panel_day11.BackColor = submain_color;
            form.menu1_table_calender_panel_day12.BackColor = submain_color;
            form.menu1_table_calender_panel_day13.BackColor = submain_color;
            form.menu1_table_calender_panel_day14.BackColor = submain_color;
            form.menu1_table_calender_panel_day15.BackColor = submain_color;
            form.menu1_table_calender_panel_day16.BackColor = submain_color;
            form.menu1_table_calender_panel_day17.BackColor = submain_color;
            form.menu1_table_calender_panel_day18.BackColor = submain_color;
            form.menu1_table_calender_panel_day19.BackColor = submain_color;
            form.menu1_table_calender_panel_day20.BackColor = submain_color;
            form.menu1_table_calender_panel_day21.BackColor = submain_color;
            form.menu1_table_calender_panel_day22.BackColor = submain_color;
            form.menu1_table_calender_panel_day23.BackColor = submain_color;
            form.menu1_table_calender_panel_day24.BackColor = submain_color;
            form.menu1_table_calender_panel_day25.BackColor = submain_color;
            form.menu1_table_calender_panel_day26.BackColor = submain_color;
            form.menu1_table_calender_panel_day27.BackColor = submain_color;
            form.menu1_table_calender_panel_day28.BackColor = submain_color;
            form.menu1_table_calender_panel_day29.BackColor = submain_color;
            form.menu1_table_calender_panel_day30.BackColor = submain_color;
            form.menu1_table_calender_panel_day31.BackColor = submain_color;
            form.menu1_table_calender_panel_day32.BackColor = submain_color;
            form.menu1_table_calender_panel_day33.BackColor = submain_color;
            form.menu1_table_calender_panel_day34.BackColor = submain_color;
            form.menu1_table_calender_panel_day35.BackColor = submain_color;
            form.menu1_table_calender_panel_day36.BackColor = submain_color;
            form.menu1_table_calender_panel_day37.BackColor = submain_color;
            form.menu1_table_calender_panel_day38.BackColor = submain_color;
            form.menu1_table_calender_panel_day39.BackColor = submain_color;
            form.menu1_table_calender_panel_day40.BackColor = submain_color;
            form.menu1_table_calender_panel_day41.BackColor = submain_color;
            form.menu1_table_calender_panel_day42.BackColor = submain_color;

            // カレンダーの曜日の文字色を変更
            form.menu1_table_calender_label_sunday.ForeColor = sub_color;
            form.menu1_table_calender_label_monday.ForeColor = sub_color;
            form.menu1_table_calender_label_tuesday.ForeColor = sub_color;
            form.menu1_table_calender_label_wednesday.ForeColor = sub_color;
            form.menu1_table_calender_label_thursday.ForeColor = sub_color;
            form.menu1_table_calender_label_friday.ForeColor = sub_color;
            form.menu1_table_calender_label_saturday.ForeColor = sub_color;

            int year = DateTime.Now.Year; // 問題あり　月変更後モード変えるとおかしい
            int month = DateTime.Now.Month; // 問題あり　月変更後モード変えるとおかしい
            Set_Day(form, year, month);

            // menu2
            form.menu2_1_panel_top_label_title.ForeColor = sub_color;
            form.menu2_1_panel_main_panel1_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel1_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel2_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel2_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel3_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel3_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel4_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel4_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel5_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel5_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel6_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel6_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel7_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel7_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel8_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel8_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel9_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel9_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel10_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel10_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel11_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel11_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel12_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel12_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel13_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel13_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel14_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel14_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel15_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel15_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel16_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel16_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel17_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel17_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel18_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel18_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel19_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel19_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel20_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel20_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel21_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel21_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel22_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel22_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel23_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel23_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel24_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel24_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel25_label1.ForeColor = sub_color;
            form.menu2_1_panel_main_panel25_label2.ForeColor = sub_color;
            form.menu2_1_panel_main_panel1.BorderColor = sub_color;
            form.menu2_1_panel_main_panel2.BorderColor = sub_color;
            form.menu2_1_panel_main_panel3.BorderColor = sub_color;
            form.menu2_1_panel_main_panel4.BorderColor = sub_color;
            form.menu2_1_panel_main_panel5.BorderColor = sub_color;
            form.menu2_1_panel_main_panel6.BorderColor = sub_color;
            form.menu2_1_panel_main_panel7.BorderColor = sub_color;
            form.menu2_1_panel_main_panel8.BorderColor = sub_color;
            form.menu2_1_panel_main_panel9.BorderColor = sub_color;
            form.menu2_1_panel_main_panel10.BorderColor = sub_color;
            form.menu2_1_panel_main_panel11.BorderColor = sub_color;
            form.menu2_1_panel_main_panel12.BorderColor = sub_color;
            form.menu2_1_panel_main_panel13.BorderColor = sub_color;
            form.menu2_1_panel_main_panel14.BorderColor = sub_color;
            form.menu2_1_panel_main_panel15.BorderColor = sub_color;
            form.menu2_1_panel_main_panel16.BorderColor = sub_color;
            form.menu2_1_panel_main_panel17.BorderColor = sub_color;
            form.menu2_1_panel_main_panel18.BorderColor = sub_color;
            form.menu2_1_panel_main_panel19.BorderColor = sub_color;
            form.menu2_1_panel_main_panel20.BorderColor = sub_color;
            form.menu2_1_panel_main_panel21.BorderColor = sub_color;
            form.menu2_1_panel_main_panel22.BorderColor = sub_color;
            form.menu2_1_panel_main_panel23.BorderColor = sub_color;
            form.menu2_1_panel_main_panel24.BorderColor = sub_color;
            form.menu2_1_panel_main_panel25.BorderColor = sub_color;

            form.menu2_2_panel_top_label_title.ForeColor = sub_color;

            form.menu2_3_panel_top_label_title.ForeColor = sub_color;
            form.menu2_3_panel_main_panel1_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel2_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel3_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel4_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel5_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel6_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel7_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel8_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel9_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel10_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel11_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel12_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel13_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel14_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel15_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel16_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel17_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel18_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel19_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel20_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel21_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel22_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel23_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel24_label1.ForeColor = sub_color;
            form.menu2_3_panel_main_panel25_label1.ForeColor = sub_color;
        }

        // メニュー切り替え
        private static void ChangeMenu(MainForm form, int menu)
        {
            switch (menu)
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
            }
        }

        // カレンダーに日にちをセット
        private static void Set_Day(MainForm form, int year, int month)
        {
            DateTime today = DateTime.Now;
            int[] days = new int[42];
            int sub_day = 0;
            DateTime firstday = new DateTime(year, month, 1);
            int today_int = -1;
            Get_Calender(year, month, ref today, ref days, ref sub_day, ref firstday, ref today_int);

            DayOfWeek firstdate = firstday.DayOfWeek;

            Color today_color = Color.FromArgb(255, 128, 0);
            Color panel_color = submain_color;
            Color main_text_color = sub_color;
            Color sub_text_color = subsub_color;

            Font main_font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Font sub_font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            form.menu1_table_calender_label_day1.Text = days[0].ToString();
            form.menu1_table_calender_label_day2.Text = days[1].ToString();
            form.menu1_table_calender_label_day3.Text = days[2].ToString();
            form.menu1_table_calender_label_day4.Text = days[3].ToString();
            form.menu1_table_calender_label_day5.Text = days[4].ToString();
            form.menu1_table_calender_label_day6.Text = days[5].ToString();
            form.menu1_table_calender_label_day7.Text = days[6].ToString();
            form.menu1_table_calender_label_day8.Text = days[7].ToString();
            form.menu1_table_calender_label_day9.Text = days[8].ToString();
            form.menu1_table_calender_label_day10.Text = days[9].ToString();
            form.menu1_table_calender_label_day11.Text = days[10].ToString();
            form.menu1_table_calender_label_day12.Text = days[11].ToString();
            form.menu1_table_calender_label_day13.Text = days[12].ToString();
            form.menu1_table_calender_label_day14.Text = days[13].ToString();
            form.menu1_table_calender_label_day15.Text = days[14].ToString();
            form.menu1_table_calender_label_day16.Text = days[15].ToString();
            form.menu1_table_calender_label_day17.Text = days[16].ToString();
            form.menu1_table_calender_label_day18.Text = days[17].ToString();
            form.menu1_table_calender_label_day19.Text = days[18].ToString();
            form.menu1_table_calender_label_day20.Text = days[19].ToString();
            form.menu1_table_calender_label_day21.Text = days[20].ToString();
            form.menu1_table_calender_label_day22.Text = days[21].ToString();
            form.menu1_table_calender_label_day23.Text = days[22].ToString();
            form.menu1_table_calender_label_day24.Text = days[23].ToString();
            form.menu1_table_calender_label_day25.Text = days[24].ToString();
            form.menu1_table_calender_label_day26.Text = days[25].ToString();
            form.menu1_table_calender_label_day27.Text = days[26].ToString();
            form.menu1_table_calender_label_day28.Text = days[27].ToString();
            form.menu1_table_calender_label_day29.Text = days[28].ToString();
            form.menu1_table_calender_label_day30.Text = days[29].ToString();
            form.menu1_table_calender_label_day31.Text = days[30].ToString();
            form.menu1_table_calender_label_day32.Text = days[31].ToString();
            form.menu1_table_calender_label_day33.Text = days[32].ToString();
            form.menu1_table_calender_label_day34.Text = days[33].ToString();
            form.menu1_table_calender_label_day35.Text = days[34].ToString();
            form.menu1_table_calender_label_day36.Text = days[35].ToString();
            form.menu1_table_calender_label_day37.Text = days[36].ToString();
            form.menu1_table_calender_label_day38.Text = days[37].ToString();
            form.menu1_table_calender_label_day39.Text = days[38].ToString();
            form.menu1_table_calender_label_day40.Text = days[39].ToString();
            form.menu1_table_calender_label_day41.Text = days[40].ToString();
            form.menu1_table_calender_label_day42.Text = days[41].ToString();

            // カレンダーの全ての文字色を変更する
            form.menu1_table_calender_label_day1.ForeColor = main_text_color;
            form.menu1_table_calender_label_day2.ForeColor = main_text_color;
            form.menu1_table_calender_label_day3.ForeColor = main_text_color;
            form.menu1_table_calender_label_day4.ForeColor = main_text_color;
            form.menu1_table_calender_label_day5.ForeColor = main_text_color;
            form.menu1_table_calender_label_day6.ForeColor = main_text_color;
            form.menu1_table_calender_label_day7.ForeColor = main_text_color;
            form.menu1_table_calender_label_day8.ForeColor = main_text_color;
            form.menu1_table_calender_label_day9.ForeColor = main_text_color;
            form.menu1_table_calender_label_day10.ForeColor = main_text_color;
            form.menu1_table_calender_label_day11.ForeColor = main_text_color;
            form.menu1_table_calender_label_day12.ForeColor = main_text_color;
            form.menu1_table_calender_label_day13.ForeColor = main_text_color;
            form.menu1_table_calender_label_day14.ForeColor = main_text_color;
            form.menu1_table_calender_label_day15.ForeColor = main_text_color;
            form.menu1_table_calender_label_day16.ForeColor = main_text_color;
            form.menu1_table_calender_label_day17.ForeColor = main_text_color;
            form.menu1_table_calender_label_day18.ForeColor = main_text_color;
            form.menu1_table_calender_label_day19.ForeColor = main_text_color;
            form.menu1_table_calender_label_day20.ForeColor = main_text_color;
            form.menu1_table_calender_label_day21.ForeColor = main_text_color;
            form.menu1_table_calender_label_day22.ForeColor = main_text_color;
            form.menu1_table_calender_label_day23.ForeColor = main_text_color;
            form.menu1_table_calender_label_day24.ForeColor = main_text_color;
            form.menu1_table_calender_label_day25.ForeColor = main_text_color;
            form.menu1_table_calender_label_day26.ForeColor = main_text_color;
            form.menu1_table_calender_label_day27.ForeColor = main_text_color;
            form.menu1_table_calender_label_day28.ForeColor = main_text_color;
            form.menu1_table_calender_label_day29.ForeColor = main_text_color;
            form.menu1_table_calender_label_day30.ForeColor = main_text_color;
            form.menu1_table_calender_label_day31.ForeColor = main_text_color;
            form.menu1_table_calender_label_day32.ForeColor = main_text_color;
            form.menu1_table_calender_label_day33.ForeColor = main_text_color;
            form.menu1_table_calender_label_day34.ForeColor = main_text_color;
            form.menu1_table_calender_label_day35.ForeColor = main_text_color;
            form.menu1_table_calender_label_day36.ForeColor = main_text_color;
            form.menu1_table_calender_label_day37.ForeColor = main_text_color;
            form.menu1_table_calender_label_day38.ForeColor = main_text_color;
            form.menu1_table_calender_label_day39.ForeColor = main_text_color;
            form.menu1_table_calender_label_day40.ForeColor = main_text_color;
            form.menu1_table_calender_label_day41.ForeColor = main_text_color;
            form.menu1_table_calender_label_day42.ForeColor = main_text_color;

            // カレンダーの全てのフォントを変更する
            form.menu1_table_calender_label_day1.Font = main_font;
            form.menu1_table_calender_label_day2.Font = main_font;
            form.menu1_table_calender_label_day3.Font = main_font;
            form.menu1_table_calender_label_day4.Font = main_font;
            form.menu1_table_calender_label_day5.Font = main_font;
            form.menu1_table_calender_label_day6.Font = main_font;
            form.menu1_table_calender_label_day7.Font = main_font;
            form.menu1_table_calender_label_day8.Font = main_font;
            form.menu1_table_calender_label_day9.Font = main_font;
            form.menu1_table_calender_label_day10.Font = main_font;
            form.menu1_table_calender_label_day11.Font = main_font;
            form.menu1_table_calender_label_day12.Font = main_font;
            form.menu1_table_calender_label_day13.Font = main_font;
            form.menu1_table_calender_label_day14.Font = main_font;
            form.menu1_table_calender_label_day15.Font = main_font;
            form.menu1_table_calender_label_day16.Font = main_font;
            form.menu1_table_calender_label_day17.Font = main_font;
            form.menu1_table_calender_label_day18.Font = main_font;
            form.menu1_table_calender_label_day19.Font = main_font;
            form.menu1_table_calender_label_day20.Font = main_font;
            form.menu1_table_calender_label_day21.Font = main_font;
            form.menu1_table_calender_label_day22.Font = main_font;
            form.menu1_table_calender_label_day23.Font = main_font;
            form.menu1_table_calender_label_day24.Font = main_font;
            form.menu1_table_calender_label_day25.Font = main_font;
            form.menu1_table_calender_label_day26.Font = main_font;
            form.menu1_table_calender_label_day27.Font = main_font;
            form.menu1_table_calender_label_day28.Font = main_font;
            form.menu1_table_calender_label_day29.Font = main_font;
            form.menu1_table_calender_label_day30.Font = main_font;
            form.menu1_table_calender_label_day31.Font = main_font;
            form.menu1_table_calender_label_day32.Font = main_font;
            form.menu1_table_calender_label_day33.Font = main_font;
            form.menu1_table_calender_label_day34.Font = main_font;
            form.menu1_table_calender_label_day35.Font = main_font;
            form.menu1_table_calender_label_day36.Font = main_font;
            form.menu1_table_calender_label_day37.Font = main_font;
            form.menu1_table_calender_label_day38.Font = main_font;
            form.menu1_table_calender_label_day39.Font = main_font;
            form.menu1_table_calender_label_day40.Font = main_font;
            form.menu1_table_calender_label_day41.Font = main_font;
            form.menu1_table_calender_label_day42.Font = main_font;

            // 前の月の文字色、フォントを変更する
            switch ((int)firstdate - 1)
            {
                case 0:
                    form.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day1.Font = sub_font;
                    break;
                case 1:
                    form.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day1.Font = sub_font;
                    form.menu1_table_calender_label_day2.Font = sub_font;
                    break;
                case 2:
                    form.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day1.Font = sub_font;
                    form.menu1_table_calender_label_day2.Font = sub_font;
                    form.menu1_table_calender_label_day3.Font = sub_font;
                    break;
                case 3:
                    form.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day4.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day1.Font = sub_font;
                    form.menu1_table_calender_label_day2.Font = sub_font;
                    form.menu1_table_calender_label_day3.Font = sub_font;
                    form.menu1_table_calender_label_day4.Font = sub_font;
                    break;
                case 4:
                    form.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day4.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day5.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day1.Font = sub_font;
                    form.menu1_table_calender_label_day2.Font = sub_font;
                    form.menu1_table_calender_label_day3.Font = sub_font;
                    form.menu1_table_calender_label_day4.Font = sub_font;
                    form.menu1_table_calender_label_day5.Font = sub_font;
                    break;
                case 5:
                    form.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day4.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day5.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day6.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day1.Font = sub_font;
                    form.menu1_table_calender_label_day2.Font = sub_font;
                    form.menu1_table_calender_label_day3.Font = sub_font;
                    form.menu1_table_calender_label_day4.Font = sub_font;
                    form.menu1_table_calender_label_day5.Font = sub_font;
                    form.menu1_table_calender_label_day6.Font = sub_font;
                    break;
            }

            // 次の月の文字色、フォントを変更する
            switch (sub_day)
            {
                case 28:
                    form.menu1_table_calender_label_day29.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day30.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day31.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day29.Font = sub_font;
                    form.menu1_table_calender_label_day30.Font = sub_font;
                    form.menu1_table_calender_label_day31.Font = sub_font;
                    form.menu1_table_calender_label_day32.Font = sub_font;
                    form.menu1_table_calender_label_day33.Font = sub_font;
                    form.menu1_table_calender_label_day34.Font = sub_font;
                    form.menu1_table_calender_label_day35.Font = sub_font;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 29:
                    form.menu1_table_calender_label_day30.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day31.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day30.Font = sub_font;
                    form.menu1_table_calender_label_day31.Font = sub_font;
                    form.menu1_table_calender_label_day32.Font = sub_font;
                    form.menu1_table_calender_label_day33.Font = sub_font;
                    form.menu1_table_calender_label_day34.Font = sub_font;
                    form.menu1_table_calender_label_day35.Font = sub_font;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 30:
                    form.menu1_table_calender_label_day31.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day31.Font = sub_font;
                    form.menu1_table_calender_label_day32.Font = sub_font;
                    form.menu1_table_calender_label_day33.Font = sub_font;
                    form.menu1_table_calender_label_day34.Font = sub_font;
                    form.menu1_table_calender_label_day35.Font = sub_font;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 31:
                    form.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day32.Font = sub_font;
                    form.menu1_table_calender_label_day33.Font = sub_font;
                    form.menu1_table_calender_label_day34.Font = sub_font;
                    form.menu1_table_calender_label_day35.Font = sub_font;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 32:
                    form.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day33.Font = sub_font;
                    form.menu1_table_calender_label_day34.Font = sub_font;
                    form.menu1_table_calender_label_day35.Font = sub_font;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 33:
                    form.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day34.Font = sub_font;
                    form.menu1_table_calender_label_day35.Font = sub_font;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 34:
                    form.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day35.Font = sub_font;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 35:
                    form.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day36.Font = sub_font;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 36:
                    form.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day37.Font = sub_font;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 37:
                    form.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day38.Font = sub_font;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 38:
                    form.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day39.Font = sub_font;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 39:
                    form.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day40.Font = sub_font;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 40:
                    form.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day41.Font = sub_font;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 41:
                    form.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    form.menu1_table_calender_label_day42.Font = sub_font;
                    break;
            }

            // カレンダーの日にちの背景色を変更
            form.menu1_table_calender_panel_day1.BackColor = submain_color;
            form.menu1_table_calender_panel_day2.BackColor = submain_color;
            form.menu1_table_calender_panel_day3.BackColor = submain_color;
            form.menu1_table_calender_panel_day4.BackColor = submain_color;
            form.menu1_table_calender_panel_day5.BackColor = submain_color;
            form.menu1_table_calender_panel_day6.BackColor = submain_color;
            form.menu1_table_calender_panel_day7.BackColor = submain_color;
            form.menu1_table_calender_panel_day8.BackColor = submain_color;
            form.menu1_table_calender_panel_day9.BackColor = submain_color;
            form.menu1_table_calender_panel_day10.BackColor = submain_color;
            form.menu1_table_calender_panel_day11.BackColor = submain_color;
            form.menu1_table_calender_panel_day12.BackColor = submain_color;
            form.menu1_table_calender_panel_day13.BackColor = submain_color;
            form.menu1_table_calender_panel_day14.BackColor = submain_color;
            form.menu1_table_calender_panel_day15.BackColor = submain_color;
            form.menu1_table_calender_panel_day16.BackColor = submain_color;
            form.menu1_table_calender_panel_day17.BackColor = submain_color;
            form.menu1_table_calender_panel_day18.BackColor = submain_color;
            form.menu1_table_calender_panel_day19.BackColor = submain_color;
            form.menu1_table_calender_panel_day20.BackColor = submain_color;
            form.menu1_table_calender_panel_day21.BackColor = submain_color;
            form.menu1_table_calender_panel_day22.BackColor = submain_color;
            form.menu1_table_calender_panel_day23.BackColor = submain_color;
            form.menu1_table_calender_panel_day24.BackColor = submain_color;
            form.menu1_table_calender_panel_day25.BackColor = submain_color;
            form.menu1_table_calender_panel_day26.BackColor = submain_color;
            form.menu1_table_calender_panel_day27.BackColor = submain_color;
            form.menu1_table_calender_panel_day28.BackColor = submain_color;
            form.menu1_table_calender_panel_day29.BackColor = submain_color;
            form.menu1_table_calender_panel_day30.BackColor = submain_color;
            form.menu1_table_calender_panel_day31.BackColor = submain_color;
            form.menu1_table_calender_panel_day32.BackColor = submain_color;
            form.menu1_table_calender_panel_day33.BackColor = submain_color;
            form.menu1_table_calender_panel_day34.BackColor = submain_color;
            form.menu1_table_calender_panel_day35.BackColor = submain_color;
            form.menu1_table_calender_panel_day36.BackColor = submain_color;
            form.menu1_table_calender_panel_day37.BackColor = submain_color;
            form.menu1_table_calender_panel_day38.BackColor = submain_color;
            form.menu1_table_calender_panel_day39.BackColor = submain_color;
            form.menu1_table_calender_panel_day40.BackColor = submain_color;
            form.menu1_table_calender_panel_day41.BackColor = submain_color;
            form.menu1_table_calender_panel_day42.BackColor = submain_color;

            // 現在日がカレンダーに存在する場合はパネルの色を変更する
            switch (today_int)
            {
                case 0:
                    form.menu1_table_calender_panel_day1.BackColor = today_color;
                    break;
                case 1:
                    form.menu1_table_calender_panel_day2.BackColor = today_color;
                    break;
                case 2:
                    form.menu1_table_calender_panel_day3.BackColor = today_color;
                    break;
                case 3:
                    form.menu1_table_calender_panel_day4.BackColor = today_color;
                    break;
                case 4:
                    form.menu1_table_calender_panel_day5.BackColor = today_color;
                    break;
                case 5:
                    form.menu1_table_calender_panel_day6.BackColor = today_color;
                    break;
                case 6:
                    form.menu1_table_calender_panel_day7.BackColor = today_color;
                    break;
                case 7:
                    form.menu1_table_calender_panel_day8.BackColor = today_color;
                    break;
                case 8:
                    form.menu1_table_calender_panel_day9.BackColor = today_color;
                    break;
                case 9:
                    form.menu1_table_calender_panel_day10.BackColor = today_color;
                    break;
                case 10:
                    form.menu1_table_calender_panel_day11.BackColor = today_color;
                    break;
                case 11:
                    form.menu1_table_calender_panel_day12.BackColor = today_color;
                    break;
                case 12:
                    form.menu1_table_calender_panel_day13.BackColor = today_color;
                    break;
                case 13:
                    form.menu1_table_calender_panel_day14.BackColor = today_color;
                    break;
                case 14:
                    form.menu1_table_calender_panel_day15.BackColor = today_color;
                    break;
                case 15:
                    form.menu1_table_calender_panel_day16.BackColor = today_color;
                    break;
                case 16:
                    form.menu1_table_calender_panel_day17.BackColor = today_color;
                    break;
                case 17:
                    form.menu1_table_calender_panel_day18.BackColor = today_color;
                    break;
                case 18:
                    form.menu1_table_calender_panel_day19.BackColor = today_color;
                    break;
                case 19:
                    form.menu1_table_calender_panel_day20.BackColor = today_color;
                    break;
                case 20:
                    form.menu1_table_calender_panel_day21.BackColor = today_color;
                    break;
                case 21:
                    form.menu1_table_calender_panel_day22.BackColor = today_color;
                    break;
                case 22:
                    form.menu1_table_calender_panel_day23.BackColor = today_color;
                    break;
                case 23:
                    form.menu1_table_calender_panel_day24.BackColor = today_color;
                    break;
                case 24:
                    form.menu1_table_calender_panel_day25.BackColor = today_color;
                    break;
                case 25:
                    form.menu1_table_calender_panel_day26.BackColor = today_color;
                    break;
                case 26:
                    form.menu1_table_calender_panel_day27.BackColor = today_color;
                    break;
                case 27:
                    form.menu1_table_calender_panel_day28.BackColor = today_color;
                    break;
                case 28:
                    form.menu1_table_calender_panel_day29.BackColor = today_color;
                    break;
                case 29:
                    form.menu1_table_calender_panel_day30.BackColor = today_color;
                    break;
                case 30:
                    form.menu1_table_calender_panel_day31.BackColor = today_color;
                    break;
                case 31:
                    form.menu1_table_calender_panel_day32.BackColor = today_color;
                    break;
                case 32:
                    form.menu1_table_calender_panel_day33.BackColor = today_color;
                    break;
                case 33:
                    form.menu1_table_calender_panel_day34.BackColor = today_color;
                    break;
                case 34:
                    form.menu1_table_calender_panel_day35.BackColor = today_color;
                    break;
                case 35:
                    form.menu1_table_calender_panel_day36.BackColor = today_color;
                    break;
                case 36:
                    form.menu1_table_calender_panel_day37.BackColor = today_color;
                    break;
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
