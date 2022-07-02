using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu1_events
    {
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
            common_events.Set_Day(form, year, month);
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
            common_events.Set_Day(form, year, month);
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

        public static void menu1_table_calender_panel_day_MouseEnter(object sender, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Panel)sender).Name)]);
        }
        public static void menu1_table_calender_label_day_MouseEnter(object sender, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)]);
        }
        //日付ホバーが離れた時
        public static void menu1_table_calender_panel_day_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }

        public static void menu1_table_calender_label_day_MouseLeave(MainForm form)
        {
            NoOverMouse(form);
        }
        //日付クリック
        public static void menu1_table_calender_panel_day_MouseClick(object sender, MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day[int.Parse(((Panel)sender).Name)], int.Parse(((Panel)sender).Name));
        }
        public static void menu1_table_calender_label_day_MouseClick(object sender, MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)], int.Parse(((Label)sender).Name));
        }
        public static void menu1_table_calender_panel_day_DoubleClick(object sender, MainForm form)
        {
            OpenTaskFromPanel(int.Parse(((Panel)sender).Name), form.menu1_table_calender_label_day[int.Parse(((Panel)sender).Name)].Text);
        }
        public static void menu1_table_calender_label_day_DoubleClick(object sender, MainForm form)
        {
            OpenTaskFromPanel(int.Parse(((Label)sender).Name), form.menu1_table_calender_label_day[int.Parse(((Label)sender).Name)].Text);
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
            pen = new Pen(Main.Common_Var.subsub_color);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // 日付ホバーが外れた時の動作
        private static void NoOverMouse(MainForm form)
        {
            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                if (Main.Common_Var.clickpanel == i)
                {
                    continue;
                }
                form.menu1_table_calender_panel_day[i].Refresh();
            }

            Panel panel = new Panel();

            if (0 <= Main.Common_Var.clickpanel && Main.Common_Var.clickpanel <= 41)
            {
                panel = form.menu1_table_calender_panel_day[Main.Common_Var.clickpanel];
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
            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                form.menu1_table_calender_panel_day[i].Refresh();
            }

            Main.Common_Var.clickpanel = panel_num;

            Graphics g = panel.CreateGraphics();
            Pen pen;

            int r = panel.ClientRectangle.Right - 1;
            int b = panel.ClientRectangle.Bottom - 1;
            pen = new Pen(Main.Common_Var.sub_color);
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

            common_events.Set_Day(form, year, month);
            form.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        #endregion private
    }
}
