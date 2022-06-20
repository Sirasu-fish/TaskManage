using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu1_events
    {
        private static int clickpanel = -1; //カレンダーでクリックされたパネル //MainForm.csで宣言して共有する

        static readonly Color dark = Color.FromArgb(40, 40, 40); //ダークモード 基本色
        static readonly Color white = Color.FromArgb(240, 240, 240); //ライトモード 基本色
        static readonly Color subdark = Color.FromArgb(80, 80, 80); //ダークモード サブ色
        static readonly Color subwhite = Color.FromArgb(220, 220, 220); //ライトモード サブ色
        private static Color main_color = dark;
        private static Color sub_color = white;
        private static Color submain_color = subdark;
        private static Color subsub_color = subwhite;

        public static void menu1_panel_calendertop_button_prevmonth_Click(MainForm form)
        {
            int year = 0;
            int month = 0;

            Get_YearMonth(form, ref year, ref month);
            month = (month + 10) % 12 + 1;
            if (month == 12)
            {
                year = year - 1;
            }
            Set_Day(form, year, month);
            form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        public static void menu1_panel_calendertop_button_nextmonth_Click(MainForm form)
        {
            int year = 0;
            int month = 0;
            Get_YearMonth(form, ref year, ref month);
            month = month % 12 + 1;
            if (month == 1)
            {
                year = year + 1;
            }
            Set_Day(form, year, month);
            form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        public static void menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(MainForm form)
        {
            Change_YearMonth(form);
        }
        public static void menu1_panel_calendertop_panel_yearmonth_combo_month_SelectedIndexChanged(MainForm form)
        {
            Change_YearMonth(form);
        }

        //日付ホバー時
        public static void menu1_table_calender_panel_day1_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day1);
        }
        public static void menu1_table_calender_panel_day2_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day2);
        }
        public static void menu1_table_calender_panel_day3_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day3);
        }
        public static void menu1_table_calender_panel_day4_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day4);
        }
        public static void menu1_table_calender_panel_day5_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day5);
        }
        public static void menu1_table_calender_panel_day6_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day6);
        }
        public static void menu1_table_calender_panel_day7_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day7);
        }
        public static void menu1_table_calender_panel_day8_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day8);
        }
        public static void menu1_table_calender_panel_day9_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day9);
        }
        public static void menu1_table_calender_panel_day10_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day10);
        }
        public static void menu1_table_calender_panel_day11_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day11);
        }
        public static void menu1_table_calender_panel_day12_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day12);
        }
        public static void menu1_table_calender_panel_day13_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day13);
        }
        public static void menu1_table_calender_panel_day14_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day14);
        }
        public static void menu1_table_calender_panel_day15_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day15);
        }
        public static void menu1_table_calender_panel_day16_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day16);
        }
        public static void menu1_table_calender_panel_day17_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day17);
        }
        public static void menu1_table_calender_panel_day18_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day18);
        }
        public static void menu1_table_calender_panel_day19_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day19);
        }
        public static void menu1_table_calender_panel_day20_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day20);
        }
        public static void menu1_table_calender_panel_day21_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day21);
        }
        public static void menu1_table_calender_panel_day22_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day22);
        }
        public static void menu1_table_calender_panel_day23_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day23);
        }
        public static void menu1_table_calender_panel_day24_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day24);
        }
        public static void menu1_table_calender_panel_day25_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day25);
        }
        public static void menu1_table_calender_panel_day26_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day26);
        }
        public static void menu1_table_calender_panel_day27_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day27);
        }
        public static void menu1_table_calender_panel_day28_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day28);
        }
        public static void menu1_table_calender_panel_day29_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day29);
        }
        public static void menu1_table_calender_panel_day30_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day30);
        }
        public static void menu1_table_calender_panel_day31_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day31);
        }
        public static void menu1_table_calender_panel_day32_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day32);
        }
        public static void menu1_table_calender_panel_day33_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day33);
        }
        public static void menu1_table_calender_panel_day34_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day34);
        }
        public static void menu1_table_calender_panel_day35_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day35);
        }
        public static void menu1_table_calender_panel_day36_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day36);
        }
        public static void menu1_table_calender_panel_day37_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day37);
        }
        public static void menu1_table_calender_panel_day38_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day38);
        }
        public static void menu1_table_calender_panel_day39_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day39);
        }
        public static void menu1_table_calender_panel_day40_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day40);
        }
        public static void menu1_table_calender_panel_day41_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day41);
        }
        public static void menu1_table_calender_panel_day42_MouseEnter(MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day42);
        }

        //日付ホバーが離れた時
        public static void menu1_table_calender_panel_day1_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day2_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day3_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day4_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day5_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day6_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day7_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day8_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day9_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day10_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day11_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day12_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day13_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day14_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day15_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day16_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day17_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day18_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day19_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day20_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day21_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day22_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day23_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day24_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day25_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day26_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day27_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day28_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day29_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day30_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day31_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day32_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day33_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day34_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day35_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day36_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day37_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day38_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day39_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day40_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day41_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day42_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        //日付クリック
        public static void menu1_table_calender_panel_day1_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day1, 0);
        }
        public static void menu1_table_calender_panel_day2_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day2, 1);
        }
        public static void menu1_table_calender_panel_day3_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day3, 2);
        }
        public static void menu1_table_calender_panel_day4_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day4, 3);
        }
        public static void menu1_table_calender_panel_day5_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day5, 4);
        }
        public static void menu1_table_calender_panel_day6_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day6, 5);
        }
        public static void menu1_table_calender_panel_day7_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day7, 6);
        }
        public static void menu1_table_calender_panel_day8_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day8, 7);
        }
        public static void menu1_table_calender_panel_day9_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day9, 8);
        }
        public static void menu1_table_calender_panel_day10_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day10, 9);
        }
        public static void menu1_table_calender_panel_day11_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day11, 10);
        }
        public static void menu1_table_calender_panel_day12_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day12, 11);
        }
        public static void menu1_table_calender_panel_day13_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day13, 12);
        }
        public static void menu1_table_calender_panel_day14_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day14, 13);
        }
        public static void menu1_table_calender_panel_day15_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day15, 14);
        }
        public static void menu1_table_calender_panel_day16_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day16, 15);
        }
        public static void menu1_table_calender_panel_day17_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day17, 16);
        }
        public static void menu1_table_calender_panel_day18_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day18, 17);
        }
        public static void menu1_table_calender_panel_day19_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day19, 18);
        }
        public static void menu1_table_calender_panel_day20_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day20, 19);
        }
        public static void menu1_table_calender_panel_day21_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day21, 20);
        }
        public static void menu1_table_calender_panel_day22_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day22, 21);
        }
        public static void menu1_table_calender_panel_day23_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day23, 22);
        }
        public static void menu1_table_calender_panel_day24_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day24, 23);
        }
        public static void menu1_table_calender_panel_day25_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day25, 24);
        }
        public static void menu1_table_calender_panel_day26_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day26, 25);
        }
        public static void menu1_table_calender_panel_day27_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day27, 26);
        }
        public static void menu1_table_calender_panel_day28_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day28, 27);
        }
        public static void menu1_table_calender_panel_day29_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day29, 28);
        }
        public static void menu1_table_calender_panel_day30_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day30, 29);
        }
        public static void menu1_table_calender_panel_day31_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day31, 30);
        }
        public static void menu1_table_calender_panel_day32_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day32, 31);
        }
        public static void menu1_table_calender_panel_day33_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day33, 32);
        }
        public static void menu1_table_calender_panel_day34_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day34, 33);
        }
        public static void menu1_table_calender_panel_day35_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day35, 34);
        }
        public static void menu1_table_calender_panel_day36_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day36, 35);
        }
        public static void menu1_table_calender_panel_day37_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day37, 36);
        }
        public static void menu1_table_calender_panel_day38_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day38, 37);
        }
        public static void menu1_table_calender_panel_day39_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day39, 38);
        }
        public static void menu1_table_calender_panel_day40_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day40, 39);
        }
        public static void menu1_table_calender_panel_day41_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day41, 40);
        }
        public static void menu1_table_calender_panel_day42_MouseClick(MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day42, 41);
        }

        public static void menu1_table_calender_panel_day1_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(0, form.menu1_table_calender_label_day1.Text);
        }
        public static void menu1_table_calender_panel_day2_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(1, form.menu1_table_calender_label_day2.Text);
        }
        public static void menu1_table_calender_panel_day3_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(2, form.menu1_table_calender_label_day3.Text);
        }
        public static void menu1_table_calender_panel_day4_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(3, form.menu1_table_calender_label_day4.Text);
        }
        public static void menu1_table_calender_panel_day5_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(4, form.menu1_table_calender_label_day5.Text);
        }
        public static void menu1_table_calender_panel_day6_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(5, form.menu1_table_calender_label_day6.Text);
        }
        public static void menu1_table_calender_panel_day7_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(6, form.menu1_table_calender_label_day7.Text);
        }
        public static void menu1_table_calender_panel_day8_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(7, form.menu1_table_calender_label_day8.Text);
        }
        public static void menu1_table_calender_panel_day9_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(8, form.menu1_table_calender_label_day9.Text);
        }
        public static void menu1_table_calender_panel_day10_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(9, form.menu1_table_calender_label_day10.Text);
        }
        public static void menu1_table_calender_panel_day11_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(10, form.menu1_table_calender_label_day11.Text);
        }
        public static void menu1_table_calender_panel_day12_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(11, form.menu1_table_calender_label_day12.Text);
        }
        public static void menu1_table_calender_panel_day13_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(12, form.menu1_table_calender_label_day13.Text);
        }
        public static void menu1_table_calender_panel_day14_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(13, form.menu1_table_calender_label_day14.Text);
        }
        public static void menu1_table_calender_panel_day15_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(14, form.menu1_table_calender_label_day15.Text);
        }
        public static void menu1_table_calender_panel_day16_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(15, form.menu1_table_calender_label_day16.Text);
        }
        public static void menu1_table_calender_panel_day17_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(16, form.menu1_table_calender_label_day17.Text);
        }
        public static void menu1_table_calender_panel_day18_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(17, form.menu1_table_calender_label_day18.Text);
        }
        public static void menu1_table_calender_panel_day19_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(18, form.menu1_table_calender_label_day19.Text);
        }
        public static void menu1_table_calender_panel_day20_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(19, form.menu1_table_calender_label_day20.Text);
        }
        public static void menu1_table_calender_panel_day21_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(20, form.menu1_table_calender_label_day21.Text);
        }
        public static void menu1_table_calender_panel_day22_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(21, form.menu1_table_calender_label_day22.Text);
        }
        public static void menu1_table_calender_panel_day23_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(22, form.menu1_table_calender_label_day23.Text);
        }
        public static void menu1_table_calender_panel_day24_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(23, form.menu1_table_calender_label_day24.Text);
        }
        public static void menu1_table_calender_panel_day25_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(24, form.menu1_table_calender_label_day25.Text);
        }
        public static void menu1_table_calender_panel_day26_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(25, form.menu1_table_calender_label_day26.Text);
        }
        public static void menu1_table_calender_panel_day27_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(26, form.menu1_table_calender_label_day27.Text);
        }
        public static void menu1_table_calender_panel_day28_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(27, form.menu1_table_calender_label_day28.Text);
        }
        public static void menu1_table_calender_panel_day29_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(28, form.menu1_table_calender_label_day29.Text);
        }
        public static void menu1_table_calender_panel_day30_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(29, form.menu1_table_calender_label_day30.Text);
        }
        public static void menu1_table_calender_panel_day31_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(30, form.menu1_table_calender_label_day31.Text);
        }
        public static void menu1_table_calender_panel_day32_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(31, form.menu1_table_calender_label_day32.Text);
        }
        public static void menu1_table_calender_panel_day33_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(32, form.menu1_table_calender_label_day33.Text);
        }
        public static void menu1_table_calender_panel_day34_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(33, form.menu1_table_calender_label_day34.Text);
        }
        public static void menu1_table_calender_panel_day35_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(34, form.menu1_table_calender_label_day35.Text);
        }
        public static void menu1_table_calender_panel_day36_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(35, form.menu1_table_calender_label_day36.Text);
        }
        public static void menu1_table_calender_panel_day37_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(36, form.menu1_table_calender_label_day37.Text);
        }
        public static void menu1_table_calender_panel_day38_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(37, form.menu1_table_calender_label_day38.Text);
        }
        public static void menu1_table_calender_panel_day39_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(38, form.menu1_table_calender_label_day39.Text);
        }
        public static void menu1_table_calender_panel_day40_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(39, form.menu1_table_calender_label_day40.Text);
        }
        public static void menu1_table_calender_panel_day41_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(40, form.menu1_table_calender_label_day41.Text);
        }
        public static void menu1_table_calender_panel_day42_DoubleClick(MainForm form)
        {
            OpenTaskFromPanel(41, form.menu1_table_calender_label_day42.Text);
        }





        //private
        #region private

        // 日付ホバー時の動作
        private static void OverMouse(Panel panel)
        {
            panel.Refresh();
            Graphics g = panel.CreateGraphics();
            Pen pen;

            int r = panel.ClientRectangle.Right - 1;
            int b = panel.ClientRectangle.Bottom - 1;
            pen = new Pen(subsub_color);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // 日付ホバーが外れた時の動作
        private static void NoOverMouse(MainForm form)
        {
            if (clickpanel != 0)
            {
                form.menu1_table_calender_panel_day1.Refresh();
            }
            if (clickpanel != 1)
            {
                form.menu1_table_calender_panel_day2.Refresh();
            }
            if (clickpanel != 2)
            {
                form.menu1_table_calender_panel_day3.Refresh();
            }
            if (clickpanel != 3)
            {
                form.menu1_table_calender_panel_day4.Refresh();
            }
            if (clickpanel != 4)
            {
                form.menu1_table_calender_panel_day5.Refresh();
            }
            if (clickpanel != 5)
            {
                form.menu1_table_calender_panel_day6.Refresh();
            }
            if (clickpanel != 6)
            {
                form.menu1_table_calender_panel_day7.Refresh();
            }
            if (clickpanel != 7)
            {
                form.menu1_table_calender_panel_day8.Refresh();
            }
            if (clickpanel != 8)
            {
                form.menu1_table_calender_panel_day9.Refresh();
            }
            if (clickpanel != 9)
            {
                form.menu1_table_calender_panel_day10.Refresh();
            }
            if (clickpanel != 10)
            {
                form.menu1_table_calender_panel_day11.Refresh();
            }
            if (clickpanel != 11)
            {
                form.menu1_table_calender_panel_day12.Refresh();
            }
            if (clickpanel != 12)
            {
                form.menu1_table_calender_panel_day13.Refresh();
            }
            if (clickpanel != 13)
            {
                form.menu1_table_calender_panel_day14.Refresh();
            }
            if (clickpanel != 14)
            {
                form.menu1_table_calender_panel_day15.Refresh();
            }
            if (clickpanel != 15)
            {
                form.menu1_table_calender_panel_day16.Refresh();
            }
            if (clickpanel != 16)
            {
                form.menu1_table_calender_panel_day17.Refresh();
            }
            if (clickpanel != 17)
            {
                form.menu1_table_calender_panel_day18.Refresh();
            }
            if (clickpanel != 18)
            {
                form.menu1_table_calender_panel_day19.Refresh();
            }
            if (clickpanel != 19)
            {
                form.menu1_table_calender_panel_day20.Refresh();
            }
            if (clickpanel != 20)
            {
                form.menu1_table_calender_panel_day21.Refresh();
            }
            if (clickpanel != 21)
            {
                form.menu1_table_calender_panel_day22.Refresh();
            }
            if (clickpanel != 22)
            {
                form.menu1_table_calender_panel_day23.Refresh();
            }
            if (clickpanel != 23)
            {
                form.menu1_table_calender_panel_day24.Refresh();
            }
            if (clickpanel != 24)
            {
                form.menu1_table_calender_panel_day25.Refresh();
            }
            if (clickpanel != 25)
            {
                form.menu1_table_calender_panel_day26.Refresh();
            }
            if (clickpanel != 26)
            {
                form.menu1_table_calender_panel_day27.Refresh();
            }
            if (clickpanel != 27)
            {
                form.menu1_table_calender_panel_day28.Refresh();
            }
            if (clickpanel != 28)
            {
                form.menu1_table_calender_panel_day29.Refresh();
            }
            if (clickpanel != 29)
            {
                form.menu1_table_calender_panel_day30.Refresh();
            }
            if (clickpanel != 30)
            {
                form.menu1_table_calender_panel_day31.Refresh();
            }
            if (clickpanel != 31)
            {
                form.menu1_table_calender_panel_day32.Refresh();
            }
            if (clickpanel != 32)
            {
                form.menu1_table_calender_panel_day33.Refresh();
            }
            if (clickpanel != 33)
            {
                form.menu1_table_calender_panel_day34.Refresh();
            }
            if (clickpanel != 34)
            {
                form.menu1_table_calender_panel_day35.Refresh();
            }
            if (clickpanel != 35)
            {
                form.menu1_table_calender_panel_day36.Refresh();
            }
            if (clickpanel != 36)
            {
                form.menu1_table_calender_panel_day37.Refresh();
            }
            if (clickpanel != 37)
            {
                form.menu1_table_calender_panel_day38.Refresh();
            }
            if (clickpanel != 38)
            {
                form.menu1_table_calender_panel_day39.Refresh();
            }
            if (clickpanel != 39)
            {
                form.menu1_table_calender_panel_day40.Refresh();
            }
            if (clickpanel != 40)
            {
                form.menu1_table_calender_panel_day41.Refresh();
            }
            if (clickpanel != 41)
            {
                form.menu1_table_calender_panel_day42.Refresh();
            }

            Panel panel = new Panel();

            switch (clickpanel)
            {
                case 0:
                    panel = form.menu1_table_calender_panel_day1;
                    break;
                case 1:
                    panel = form.menu1_table_calender_panel_day2;
                    break;
                case 2:
                    panel = form.menu1_table_calender_panel_day3;
                    break;
                case 3:
                    panel = form.menu1_table_calender_panel_day4;
                    break;
                case 4:
                    panel = form.menu1_table_calender_panel_day5;
                    break;
                case 5:
                    panel = form.menu1_table_calender_panel_day6;
                    break;
                case 6:
                    panel = form.menu1_table_calender_panel_day7;
                    break;
                case 7:
                    panel = form.menu1_table_calender_panel_day8;
                    break;
                case 8:
                    panel = form.menu1_table_calender_panel_day9;
                    break;
                case 9:
                    panel = form.menu1_table_calender_panel_day10;
                    break;
                case 10:
                    panel = form.menu1_table_calender_panel_day11;
                    break;
                case 11:
                    panel = form.menu1_table_calender_panel_day12;
                    break;
                case 12:
                    panel = form.menu1_table_calender_panel_day13;
                    break;
                case 13:
                    panel = form.menu1_table_calender_panel_day14;
                    break;
                case 14:
                    panel = form.menu1_table_calender_panel_day15;
                    break;
                case 15:
                    panel = form.menu1_table_calender_panel_day16;
                    break;
                case 16:
                    panel = form.menu1_table_calender_panel_day17;
                    break;
                case 17:
                    panel = form.menu1_table_calender_panel_day18;
                    break;
                case 18:
                    panel = form.menu1_table_calender_panel_day19;
                    break;
                case 19:
                    panel = form.menu1_table_calender_panel_day20;
                    break;
                case 20:
                    panel = form.menu1_table_calender_panel_day21;
                    break;
                case 21:
                    panel = form.menu1_table_calender_panel_day22;
                    break;
                case 22:
                    panel = form.menu1_table_calender_panel_day23;
                    break;
                case 23:
                    panel = form.menu1_table_calender_panel_day24;
                    break;
                case 24:
                    panel = form.menu1_table_calender_panel_day25;
                    break;
                case 25:
                    panel = form.menu1_table_calender_panel_day26;
                    break;
                case 26:
                    panel = form.menu1_table_calender_panel_day27;
                    break;
                case 27:
                    panel = form.menu1_table_calender_panel_day28;
                    break;
                case 28:
                    panel = form.menu1_table_calender_panel_day29;
                    break;
                case 29:
                    panel = form.menu1_table_calender_panel_day30;
                    break;
                case 30:
                    panel = form.menu1_table_calender_panel_day31;
                    break;
                case 31:
                    panel = form.menu1_table_calender_panel_day32;
                    break;
                case 32:
                    panel = form.menu1_table_calender_panel_day33;
                    break;
                case 33:
                    panel = form.menu1_table_calender_panel_day34;
                    break;
                case 34:
                    panel = form.menu1_table_calender_panel_day35;
                    break;
                case 35:
                    panel = form.menu1_table_calender_panel_day36;
                    break;
                case 36:
                    panel = form.menu1_table_calender_panel_day37;
                    break;
                case 37:
                    panel = form.menu1_table_calender_panel_day38;
                    break;
                case 38:
                    panel = form.menu1_table_calender_panel_day39;
                    break;
                case 39:
                    panel = form.menu1_table_calender_panel_day40;
                    break;
                case 40:
                    panel = form.menu1_table_calender_panel_day41;
                    break;
                case 41:
                    panel = form.menu1_table_calender_panel_day42;
                    break;
                default:
                    return;
            }

            Graphics g = panel.CreateGraphics();
            Pen pen;

            int r = panel.ClientRectangle.Right - 1;
            int b = panel.ClientRectangle.Bottom - 1;
            pen = new Pen(Color.Black);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // 日付クリック時の動作
        private static void ClickPanel(MainForm form, Panel panel, int panel_num)
        {
            form.menu1_table_calender_panel_day1.Refresh();
            form.menu1_table_calender_panel_day2.Refresh();
            form.menu1_table_calender_panel_day3.Refresh();
            form.menu1_table_calender_panel_day4.Refresh();
            form.menu1_table_calender_panel_day5.Refresh();
            form.menu1_table_calender_panel_day6.Refresh();
            form.menu1_table_calender_panel_day7.Refresh();
            form.menu1_table_calender_panel_day8.Refresh();
            form.menu1_table_calender_panel_day9.Refresh();
            form.menu1_table_calender_panel_day10.Refresh();
            form.menu1_table_calender_panel_day11.Refresh();
            form.menu1_table_calender_panel_day12.Refresh();
            form.menu1_table_calender_panel_day13.Refresh();
            form.menu1_table_calender_panel_day14.Refresh();
            form.menu1_table_calender_panel_day15.Refresh();
            form.menu1_table_calender_panel_day16.Refresh();
            form.menu1_table_calender_panel_day17.Refresh();
            form.menu1_table_calender_panel_day18.Refresh();
            form.menu1_table_calender_panel_day19.Refresh();
            form.menu1_table_calender_panel_day20.Refresh();
            form.menu1_table_calender_panel_day21.Refresh();
            form.menu1_table_calender_panel_day22.Refresh();
            form.menu1_table_calender_panel_day23.Refresh();
            form.menu1_table_calender_panel_day24.Refresh();
            form.menu1_table_calender_panel_day25.Refresh();
            form.menu1_table_calender_panel_day26.Refresh();
            form.menu1_table_calender_panel_day27.Refresh();
            form.menu1_table_calender_panel_day28.Refresh();
            form.menu1_table_calender_panel_day29.Refresh();
            form.menu1_table_calender_panel_day30.Refresh();
            form.menu1_table_calender_panel_day31.Refresh();
            form.menu1_table_calender_panel_day32.Refresh();
            form.menu1_table_calender_panel_day33.Refresh();
            form.menu1_table_calender_panel_day34.Refresh();
            form.menu1_table_calender_panel_day35.Refresh();
            form.menu1_table_calender_panel_day36.Refresh();
            form.menu1_table_calender_panel_day37.Refresh();
            form.menu1_table_calender_panel_day38.Refresh();
            form.menu1_table_calender_panel_day39.Refresh();
            form.menu1_table_calender_panel_day40.Refresh();
            form.menu1_table_calender_panel_day41.Refresh();
            form.menu1_table_calender_panel_day42.Refresh();

            clickpanel = panel_num;

            Graphics g = panel.CreateGraphics();
            Pen pen;

            int r = panel.ClientRectangle.Right - 1;
            int b = panel.ClientRectangle.Bottom - 1;
            pen = new Pen(sub_color);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        //日付ダブルクリック
        private static void OpenTaskFromPanel(int panel_num, string label_day)
        {

        }

        // セレクトボックスの年、月を取得
        private static void Get_YearMonth(MainForm form, ref int year, ref int month)
        {
            if (Int32.TryParse(form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem.ToString(), out int y))
            {
                if (!(Int32.Parse(form.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[0].ToString()) <= year && year <= Int32.Parse(form.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[4].ToString())))
                {
                    year = DateTime.Now.Year;
                }
                else
                {
                    year = y;
                }
            }
            else
            {
                year = DateTime.Now.Year;
            }


            month = Int32.Parse(form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem.ToString());
            if (Int32.TryParse(form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem.ToString(), out int m))
            {
                if (!(1 <= month && month <= 12))
                {
                    month = DateTime.Now.Month;
                }
                else
                {
                    month = m;
                }
            }
            else
            {
                month = DateTime.Now.Month;
            }
        }

        // 年月変更時イベント
        private static void Change_YearMonth(MainForm form)
        {
            int year = 0;
            int month = 0;
            if (form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem == null)
            {
                year = DateTime.Now.Year;
            }
            else
            {
                year = Int32.Parse(form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem.ToString());
                if (!(Int32.Parse(form.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[0].ToString()) <= year && year <= Int32.Parse(form.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[4].ToString())))
                {
                    year = DateTime.Now.Year;
                }
            }

            if (form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem == null)
            {
                month = DateTime.Now.Month;
            }
            else
            {
                month = Int32.Parse(form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem.ToString());
                if (!(1 <= month && month <= 12))
                {
                    month = DateTime.Now.Month;
                }
            }

            Set_Day(form, year, month);
            form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
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
