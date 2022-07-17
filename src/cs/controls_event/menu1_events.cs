﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu1_events
    {
        MainForm form;

        // コンストラクタ
        public menu1_events(MainForm form)
        {
            this.form = form;
        }

        // ********** form event **********
        #region form event
        public static void menu1_panel_calendertop_button_prevmonth_Click(object sender, EventArgs e, MainForm form)
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

        public static void menu1_panel_calendertop_button_nextmonth_Click(object sender, EventArgs e, MainForm form)
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

        public static void menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e, MainForm form)
        {
            Change_YearMonth(form);
        }
        public static void menu1_panel_calendertop_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e, MainForm form)
        {
            Change_YearMonth(form);
        }

        //日付ホバー時
        public static void menu1_table_calender_panel_day_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Panel)sender).Name)]);
        }
        public static void menu1_table_calender_label_day_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)]);
        }
        //日付ホバーが離れた時
        public static void menu1_table_calender_panel_day_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            NoOverMouse(form);
        }

        public static void menu1_table_calender_label_day_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            NoOverMouse(form);
        }
        //日付クリック
        public static void menu1_table_calender_panel_day_MouseClick(object sender, EventArgs e, MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day[int.Parse(((Panel)sender).Name)], int.Parse(((Panel)sender).Name));
        }
        public static void menu1_table_calender_label_day_MouseClick(object sender, EventArgs e, MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)], int.Parse(((Label)sender).Name));
        }
        public static void menu1_table_calender_panel_day_DoubleClick(object sender, EventArgs e, MainForm form)
        {
            OpenTaskFromPanel(int.Parse(((Panel)sender).Name), form.menu1_table_calender_label_day[int.Parse(((Panel)sender).Name)].Text);
        }
        public static void menu1_table_calender_label_day_DoubleClick(object sender, EventArgs e, MainForm form)
        {
            OpenTaskFromPanel(int.Parse(((Label)sender).Name), form.menu1_table_calender_label_day[int.Parse(((Label)sender).Name)].Text);
        }

        public static void menu1_panel_done_panel_top_button_add_Click(object sender, EventArgs e, MainForm form)
        {

        }

        public void menu1_panel_done_panel_main_panel_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_panel_done_panel_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Black;
            form.menu1_panel_done_panel_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        public void menu1_panel_done_panel_main_panel_label_name_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_panel_done_panel_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Black;
            form.menu1_panel_done_panel_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        public void menu1_panel_done_panel_main_panel_label_time_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
        }
        // 実績削除ボタンホバー時
        public void menu1_panel_done_panel_main_panel_button_delete_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu2_1_panel_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 255, 128, 128);
                form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Green;
                form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
            }
        }

        public void menu1_panel_done_panel_main_panel_MouseLeave(object sender, EventArgs e)
        {
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
        }
        public void menu1_panel_done_panel_main_panel_label_name_MouseLeave(object sender, EventArgs e)
        {
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
        }
        public void menu1_panel_done_panel_main_panel_label_time_MouseLeave(object sender, EventArgs e)
        {
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
            form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
        }
        // 実績削除ボタンホバーが離れた時
        public void menu1_panel_done_panel_main_panel_button_delete_MouseLeave(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu2_1_panel_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
                form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
                form.menu1_panel_done_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
            }
        }
        public void menu1_panel_done_panel_main_panel_Click(object sender, EventArgs e)
        {
            //OpenTask(form, int.Parse(((Panel)sender).Name));
        }
        public void menu1_panel_done_panel_main_panel_label_name_Click(object sender, EventArgs e)
        {
            //OpenTask(form, int.Parse(((Panel)sender).Name));
        }
        public void menu1_panel_done_panel_main_panel_label_time_Click(object sender, EventArgs e)
        {
            //OpenTask(form, int.Parse(((Panel)sender).Name));
        }
        // 実績クリック
        public void menu1_panel_done_panel_main_panel_button_delete_Click(object sender, EventArgs e)
        {
            //RemoveTask(form, int.Parse(((Button)sender).Name));
        }
        #endregion form event
        // ********** form event **********

        // ********** private **********
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

        // 削除ボタン追加
        private static Button add_menu1_panel_done_panel_main_panel_button_delete(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu1_panel_done_panel_main_panel_button_delete = new Button();
            menu1_events events = new menu1_events(form);

            menu1_panel_done_panel_main_panel_button_delete.BackColor = Color.Transparent;
            menu1_panel_done_panel_main_panel_button_delete.Dock = DockStyle.Right;
            menu1_panel_done_panel_main_panel_button_delete.FlatStyle = FlatStyle.Flat;
            menu1_panel_done_panel_main_panel_button_delete.Image = ((Image)(resources.GetObject("menu2_1_panel_main_panel1_button_delete.Image")));
            menu1_panel_done_panel_main_panel_button_delete.Name = Main.Common_Var.menu2_1_task.ToString();
            menu1_panel_done_panel_main_panel_button_delete.Size = new Size(32, 32);
            menu1_panel_done_panel_main_panel_button_delete.UseVisualStyleBackColor = false;
            menu1_panel_done_panel_main_panel_button_delete.Click += new EventHandler(events.menu1_panel_done_panel_main_panel_button_delete_Click);
            menu1_panel_done_panel_main_panel_button_delete.MouseEnter += new EventHandler(events.menu1_panel_done_panel_main_panel_button_delete_MouseEnter);
            menu1_panel_done_panel_main_panel_button_delete.MouseLeave += new EventHandler(events.menu1_panel_done_panel_main_panel_button_delete_MouseLeave);
            menu1_panel_done_panel_main_panel_button_delete.Cursor = Cursors.Hand;

            return menu1_panel_done_panel_main_panel_button_delete;
        }
        // 実績名追加
        private static Label add_menu1_panel_done_panel_main_panel_label_name(MainForm form, string text)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu1_panel_done_panel_main_panel_label_name = new Label();
            menu1_events events = new menu1_events(form);

            menu1_panel_done_panel_main_panel_label_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu1_panel_done_panel_main_panel_label_name.Location = new Point(1, 1);
            menu1_panel_done_panel_main_panel_label_name.Name = Main.Common_Var.menu2_1_task.ToString();
            menu1_panel_done_panel_main_panel_label_name.Size = new Size(Main.Common_Const.form_x - 10
                - form.menu2_1_panel_main_panel_button_delete[Main.Common_Var.menu2_1_task].Width
                - form.menu2_1_panel_main_panel_button_finish[Main.Common_Var.menu2_1_task].Width
                - menu1_panel_done_panel_main_panel_label_name.Location.X * 2, 30);
            menu1_panel_done_panel_main_panel_label_name.Text = text;
            menu1_panel_done_panel_main_panel_label_name.TextAlign = ContentAlignment.MiddleLeft;
            menu1_panel_done_panel_main_panel_label_name.MouseEnter += new EventHandler(events.menu1_panel_done_panel_main_panel_label_name_MouseEnter);
            menu1_panel_done_panel_main_panel_label_name.MouseLeave += new EventHandler(events.menu1_panel_done_panel_main_panel_label_name_MouseLeave);
            menu1_panel_done_panel_main_panel_label_name.Click += new System.EventHandler(events.menu1_panel_done_panel_main_panel_label_name_Click);
            menu1_panel_done_panel_main_panel_label_name.Cursor = Cursors.Hand;

            return menu1_panel_done_panel_main_panel_label_name;
        }
        // 実績時間追加
        private static Label add_menu1_panel_done_panel_main_panel_label_time(MainForm form, string text)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu1_panel_done_panel_main_panel_label_name = new Label();
            menu1_events events = new menu1_events(form);

            menu1_panel_done_panel_main_panel_label_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu1_panel_done_panel_main_panel_label_name.Location = new Point(1, 1);
            menu1_panel_done_panel_main_panel_label_name.Name = Main.Common_Var.menu2_1_task.ToString();
            menu1_panel_done_panel_main_panel_label_name.Size = new Size(Main.Common_Const.form_x - 10
                - form.menu2_1_panel_main_panel_button_delete[Main.Common_Var.menu2_1_task].Width
                - form.menu2_1_panel_main_panel_button_finish[Main.Common_Var.menu2_1_task].Width
                - menu1_panel_done_panel_main_panel_label_name.Location.X * 2, 30);
            menu1_panel_done_panel_main_panel_label_name.Text = text;
            menu1_panel_done_panel_main_panel_label_name.TextAlign = ContentAlignment.MiddleLeft;
            menu1_panel_done_panel_main_panel_label_name.MouseEnter += new EventHandler(events.menu1_panel_done_panel_main_panel_label_time_MouseEnter);
            menu1_panel_done_panel_main_panel_label_name.MouseLeave += new EventHandler(events.menu1_panel_done_panel_main_panel_label_time_MouseLeave);
            menu1_panel_done_panel_main_panel_label_name.Click += new System.EventHandler(events.menu1_panel_done_panel_main_panel_label_time_Click);
            menu1_panel_done_panel_main_panel_label_name.Cursor = Cursors.Hand;

            return menu1_panel_done_panel_main_panel_label_name;
        }
        // タスクパネル追加
        private static PanelEx add_menu1_panel_done_panel_main_panel(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelEx menu1_panel_done_panel_main_panel = new PanelEx();
            menu1_events events = new menu1_events(form);

            menu1_panel_done_panel_main_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menu1_panel_done_panel_main_panel.BorderColor = Color.Black;
            menu1_panel_done_panel_main_panel.Controls.Add(form.menu2_1_panel_main_panel_label1[Main.Common_Var.menu2_1_task]);
            menu1_panel_done_panel_main_panel.Controls.Add(form.menu2_1_panel_main_panel_button_finish[Main.Common_Var.menu2_1_task]);
            menu1_panel_done_panel_main_panel.Controls.Add(form.menu2_1_panel_main_panel_button_delete[Main.Common_Var.menu2_1_task]);
            menu1_panel_done_panel_main_panel.Location = new Point(4, (form.menu1_panel_done_panel_main.Size.Height + 4) * Main.Common_Var.menu2_1_task);
            menu1_panel_done_panel_main_panel.Name = Main.Common_Var.menu2_1_task.ToString();
            menu1_panel_done_panel_main_panel.Size = new Size(form.menu2_1_panel_main.Width - form.menu1_panel_done_panel_main.Location.X * 2, 32);
            menu1_panel_done_panel_main_panel.MouseEnter += new EventHandler(events.menu1_panel_done_panel_main_panel_MouseEnter);
            menu1_panel_done_panel_main_panel.MouseLeave += new EventHandler(events.menu1_panel_done_panel_main_panel_MouseLeave);
            menu1_panel_done_panel_main_panel.Click += new EventHandler(events.menu1_panel_done_panel_main_panel_Click);
            menu1_panel_done_panel_main_panel.Cursor = Cursors.Hand;

            return menu1_panel_done_panel_main_panel;
        }

        #endregion private
        // ********** private **********
    }
}
