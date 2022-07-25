using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu1_events
    {
        MainForm form;
        static int done_x = 4; // 実績のX位置
        static int done_height = 32;
        static int done_space = -1; // 実績と実績の隙間

        // コンストラクタ
        public menu1_events(MainForm form)
        {
            this.form = form;
        }

        // ********** form event **********
        #region form event
        public static void menu1_panel_yearmonth_button_prevmonth_Click(object sender, EventArgs e, MainForm form)
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
            form.menu1_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        public static void menu1_panel_yearmonth_button_nextmonth_Click(object sender, EventArgs e, MainForm form)
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
            form.menu1_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        public static void menu1_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e, MainForm form)
        {
            Change_YearMonth(form);
        }
        public static void menu1_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e, MainForm form)
        {
            Change_YearMonth(form);
        }

        //日付ホバー時
        public static void menu1_table_calender_panel_day_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Panel)sender).Name)]);
        }
        public static void menu1_table_calender_panel_day_label_day_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)]);
        }
        //日付ホバーが離れた時
        public static void menu1_table_calender_panel_day_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            NoOverMouse(form);
        }

        public static void menu1_table_calender_panel_day_label_day_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            NoOverMouse(form);
        }
        //日付クリック
        public static void menu1_table_calender_panel_day_MouseClick(object sender, EventArgs e, MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day[int.Parse(((Panel)sender).Name)], int.Parse(((Panel)sender).Name));
        }
        public static void menu1_table_calender_panel_day_label_day_MouseClick(object sender, EventArgs e, MainForm form)
        {
            ClickPanel(form, form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)], int.Parse(((Label)sender).Name));
        }
        public static void menu1_table_calender_panel_day_MouseDoubleClick(object sender, EventArgs e, MainForm form)
        {
            SetDoneDay(form, int.Parse(((Panel)sender).Name));
        }
        public static void menu1_table_calender_panel_day_label_day_MouseDoubleClick(object sender, EventArgs e, MainForm form)
        {
            SetDoneDay(form, int.Parse(((Label)sender).Name));
        }

        public static void menu1_done_top_prevday_Click(object sender, EventArgs e, MainForm form)
        {
            DateTime day = new DateTime(Main.Common_Var.menu1_done_year, Main.Common_Var.menu1_done_month, Main.Common_Var.menu1_done_day);
            day = day.AddDays(-1);

            ChangeDoneDay(form, day.Year, day.Month, day.Day);
        }
        public static void menu1_done_top_nextday_Click(object sender, EventArgs e, MainForm form)
        {
            DateTime day = new DateTime(Main.Common_Var.menu1_done_year, Main.Common_Var.menu1_done_month, Main.Common_Var.menu1_done_day);
            day = day.AddDays(1);

            ChangeDoneDay(form, day.Year, day.Month, day.Day);
        }
        public static void menu1_done_top_button_add_Click(object sender, EventArgs e, MainForm form)
        {
            OpenDone(form, Main.Common_Var.menu1_done);
        }

        public void menu1_done_main_panel_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].BackColor = Main.Common_Const.color2;
            form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_name_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BackColor = Main.Common_Const.color2;
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_time_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BackColor = Main.Common_Const.color2;
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        // 実績削除ボタンホバー時
        public void menu1_done_main_panel_button_delete_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu1_done_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 255, 128, 128);
                form.menu1_done_main_panel[int.Parse(((Button)sender).Name)].BackColor = Main.Common_Const.color2;
                form.menu1_done_main_panel[int.Parse(((Button)sender).Name)].Refresh();
            }
        }

        public void menu1_done_main_panel_MouseLeave(object sender, EventArgs e)
        {
            if (Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done != int.Parse(((PanelEx)sender).Name))
            {
                form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].BackColor = Color.Transparent;
            }
            form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_name_MouseLeave(object sender, EventArgs e)
        {
            if (Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done != int.Parse(((Label)sender).Name))
            {
                form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BackColor = Color.Transparent;
            }
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_time_MouseLeave(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BackColor = Color.Transparent;
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        // 実績削除ボタンホバーが離れた時
        public void menu1_done_main_panel_button_delete_MouseLeave(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu1_done_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
                if (Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done != int.Parse(((Button)sender).Name))
                {
                    form.menu1_done_main_panel[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
                }
                form.menu1_done_main_panel[int.Parse(((Button)sender).Name)].Refresh();
            }
        }
        public void menu1_done_main_panel_Click(object sender, EventArgs e)
        {
            OpenDone(form, int.Parse(((PanelEx)sender).Name));
        }
        public void menu1_done_main_panel_label_name_Click(object sender, EventArgs e)
        {
            OpenDone(form, int.Parse(((Label)sender).Name));
        }
        public void menu1_done_main_panel_label_time_Click(object sender, EventArgs e)
        {
            OpenDone(form, int.Parse(((Label)sender).Name));
        }
        // 実績クリック
        public void menu1_done_main_panel_button_delete_Click(object sender, EventArgs e)
        {
            RemoveDone(form, int.Parse(((Button)sender).Name));
        }
        #endregion form event
        // ********** form event **********

        // ********** public **********
        #region public
        public static void InitAddDone(MainForm form, String text, String time)
        {
            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            form.menu1_done_main_panel_button_delete.Add(add_menu1_done_main_panel_button_delete(form));
            form.menu1_done_main_panel_label_time.Add(add_menu1_done_main_panel_label_time(form, time));
            form.menu1_done_main_panel_label_name.Add(add_menu1_done_main_panel_label_name(form, text));
            form.menu1_done_main_panel.Add(add_menu1_done_main_panel(form));
            form.menu1_done_main.Controls.Add(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done]);

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();

            Main.Common_Var.menu1_day_done += 1;

            ChangeDoneNum(form);
        }
        public static void AddDone(MainForm form, String text, String time)
        {
            if (Main.Common_Var.menu1_day_done <= Main.Common_Var.menu1_open_done) // 新規追加
            {
                form.SuspendLayout();
                form.menu1.SuspendLayout();
                form.menu1_done_main.SuspendLayout();

                form.menu1_done_main_panel_button_delete.Add(add_menu1_done_main_panel_button_delete(form));
                form.menu1_done_main_panel_label_time.Add(add_menu1_done_main_panel_label_time(form, time));
                form.menu1_done_main_panel_label_name.Add(add_menu1_done_main_panel_label_name(form, text));
                form.menu1_done_main_panel.Add(add_menu1_done_main_panel(form));
                form.menu1_done_main.Controls.Add(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done]);

                form.ResumeLayout();
                form.menu1.ResumeLayout();
                form.menu1_done_main.ResumeLayout();

                Properties.Settings.Default.done_name.Add(form.menudone_table1_text.Text);
                Properties.Settings.Default.done_time.Add(form.menudone_table2_text.Text);
                Properties.Settings.Default.done_memo.Add(form.menudone_table3_text.Text);
                Properties.Settings.Default.done_day.Add(Main.Common_Var.menu1_done_year.ToString() + "/"
                    + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString());

                Properties.Settings.Default.Save();

                Main.Common_Var.menu1_done += 1;
                Main.Common_Var.menu1_day_done += 1;

                Main.Common_Var.menu1_open_done += 1;

                ChangeDoneNum(form);
            }
            else // 既存更新
            {
                form.menu1_done_main_panel[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Text = form.menudone_table1_text.Text;
                Properties.Settings.Default.done_name[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done] = form.menudone_table1_text.Text;
                Properties.Settings.Default.done_time[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done] = form.menudone_table2_text.Text;
                Properties.Settings.Default.done_memo[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done] = form.menudone_table3_text.Text;

                Properties.Settings.Default.Save();
            }
        }

        public static void ChangeDoneNum(MainForm form)
        {
            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            if (Main.Common_Var.menu1_day_done != 0) // 実績数が0以外の時
            {
                form.menu1_done_main.Height = (done_height + done_space) * Main.Common_Var.menu1_day_done + 4;
            }
            else // 実績数が0の時
            {
                form.menu1_done_main.Height = 0;
            }

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();
        }

        #endregion public
        // ********** public **********

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

        // セレクトボックスの年、月を取得
        private static void Get_YearMonth(MainForm form, ref int year, ref int month)
        {
            if (Int32.TryParse(form.menu1_panel_yearmonth_combo_year.SelectedItem.ToString(), out int y))
            {
                if (!(Int32.Parse(form.menu1_panel_yearmonth_combo_year.Items[0].ToString()) <= year && year <= Int32.Parse(form.menu1_panel_yearmonth_combo_year.Items[4].ToString())))
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


            month = Int32.Parse(form.menu1_panel_yearmonth_combo_month.SelectedItem.ToString());
            if (Int32.TryParse(form.menu1_panel_yearmonth_combo_month.SelectedItem.ToString(), out int m))
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
            if (form.menu1_panel_yearmonth_combo_year.SelectedItem == null)
            {
                year = DateTime.Now.Year;
            }
            else
            {
                year = Int32.Parse(form.menu1_panel_yearmonth_combo_year.SelectedItem.ToString());
                if (!(Int32.Parse(form.menu1_panel_yearmonth_combo_year.Items[0].ToString()) <= year && year <= Int32.Parse(form.menu1_panel_yearmonth_combo_year.Items[4].ToString())))
                {
                    year = DateTime.Now.Year;
                }
            }

            if (form.menu1_panel_yearmonth_combo_month.SelectedItem == null)
            {
                month = DateTime.Now.Month;
            }
            else
            {
                month = Int32.Parse(form.menu1_panel_yearmonth_combo_month.SelectedItem.ToString());
                if (!(1 <= month && month <= 12))
                {
                    month = DateTime.Now.Month;
                }
            }

            common_events.Set_Day(form, year, month);
            form.menu1_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        private static void SetDoneDay(MainForm form, int num)
        {
            int year = int.Parse(form.menu1_panel_yearmonth_combo_year.Text);
            int month = int.Parse(form.menu1_panel_yearmonth_combo_month.Text);
            DayOfWeek firstdate = (new DateTime(year, month, 1)).DayOfWeek; // 前月と当月の判定用
            int subday = 0;
            int[] days = new int[42];
            int today = 0;

            common_events.Get_Calender(year, month, ref days, ref subday, ref today);
            int day = days[num];
            if ((int)firstdate - 1 < num && num < subday) // 対象が今月中の場合
            {

            }
            else if (subday <= num) // 対象が来月
            {
                if (month == 12)
                {
                    year += 1;
                    month = 1;
                }
                else
                {
                    month += 1;
                }
            }
            else if (num < (int)firstdate) // 対象が先月
            {
                if (month == 1)
                {
                    year -= 1;
                    month = 12;
                }
                else
                {
                    month -= 1;
                }
            }

            ChangeDoneDay(form, year, month, day);
        }

        private static void ChangeDoneDay(MainForm form, int year, int month, int day)
        {
            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            form.menudone.Visible = false;
            for (int i = 0; i < Main.Common_Var.menu1_day_done; i++)
            {
                form.menu1_done_main_panel[i].BackColor = Color.Transparent;
            }

            string[] date = { "日", "月", "火", "水", "木", "金", "土" };

            DateTime time = new DateTime(year, month, day);

            DayOfWeek dow = time.DayOfWeek;
            form.menu1_done_top_label_day.Text = time.ToShortDateString() + " (" + date[(int)dow] + ")";

            // 現在表示している実績を非表示
            for (int i = 0; i < Main.Common_Var.menu1_day_done; i++)
            {
                form.menu1_done_main.Controls.Remove(form.menu1_done_main_panel[i]);
            }
            form.menu1_done_main_panel_button_delete.Clear();
            form.menu1_done_main_panel_label_time.Clear();
            form.menu1_done_main_panel_label_name.Clear();
            form.menu1_done_main_panel.Clear();

            Main.Common_Var.menu1_done_year = year;
            Main.Common_Var.menu1_done_month = month;
            Main.Common_Var.menu1_done_day = day;

            Main.Common_Var.menu1_day_done = 0;

            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                Main.Common_Var.menu1_done += 1;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                    && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    InitAddDone(form, Properties.Settings.Default.done_name[i], Properties.Settings.Default.done_time[i]);
                }
            }

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();
        }

        // 実績を開く
        private static void OpenDone(MainForm form, int done_num)
        {
            Main.Common_Var.menu1_open_done = done_num;
            Main.Common_Var.menu1_delete_done = 0;

            for (int i = 0; i < Main.Common_Var.menu1_day_done; i++)
            {
                form.menu1_done_main_panel[i].BackColor = Color.Transparent;
            }

            int cnt = -1;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                    && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    cnt++;
                    if (cnt < Main.Common_Var.menu1_day_done && cnt == done_num)
                    {
                        form.menudone_table1_text.Text = Properties.Settings.Default.done_name[i];
                        form.menudone_table2_text.Text = "";
                        form.menudone_table3_text.Text = Properties.Settings.Default.done_memo[i];
                        form.menudone.Visible = true;
                        form.menu1_done_main_panel[done_num].BackColor = Main.Common_Const.color2;
                        return;
                    }
                }
            }

            if (done_num >= Main.Common_Var.menu1_day_done) // 新規実績
            {
                form.menudone_table1_text.Text = "";
                form.menudone_table2_text.Text = "";
                form.menudone_table3_text.Text = "";
                form.menudone.Visible = true;
            }
        }

        /// <summary>
        /// 実績削除
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private void RemoveDone(MainForm form, int num)
        {
            if (num <= Main.Common_Var.menu1_open_done) // 削除する実績が保存した番号より前の時、回数をカウント
            {
                Main.Common_Var.menu1_delete_done += 1;
            }
            //開いていたタスクを削除する前に、タスク画面を非表示
            if (form.menudone.Visible == true && (Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done + 1) == num)
            {
                form.menudone.Visible = false;
                for (int i = 0; i < Main.Common_Var.menu1_day_done; i++)
                {
                    form.menu1_done_main_panel[i].BackColor = Color.Transparent;
                }
            }
            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            menu1_events events = new menu1_events(form);

            // コントロール削除時に削除ボタンのイベントを除去
            if (num < Main.Common_Var.menu1_day_done - 1)
            {
                form.menu1_done_main_panel_button_delete[num].MouseLeave -= new EventHandler(events.menu1_done_main_panel_button_delete_MouseLeave);
            }

            //
            for (int i = num; i < Main.Common_Var.menu1_day_done; i++)
            {
                // 位置更新
                form.menu1_done_main_panel[i].Location = new Point(done_x, (form.menu1_done_main_panel[i].Size.Height + done_space) * (i - 1));
                // コントロール名更新
                form.menu1_done_main_panel_label_name[i].Name = (i - 1).ToString();
                form.menu1_done_main_panel_label_time[i].Name = (i - 1).ToString();
                form.menu1_done_main_panel_button_delete[i].Name = (i - 1).ToString();
                form.menu1_done_main_panel[i].Name = (i - 1).ToString();
            }

            // コントロール削除
            form.menu1_done_main_panel_label_name.RemoveAt(num);
            form.menu1_done_main_panel_label_time.RemoveAt(num);
            form.menu1_done_main_panel_button_delete.RemoveAt(num);
            form.menu1_done_main_panel.RemoveAt(num);

            // 削除ボタンのイベントを戻す
            if (num < Main.Common_Var.menu1_day_done - 1)
            {
                form.menu1_done_main_panel_button_delete[num].BackColor = Color.Transparent;
                form.menu1_done_main_panel_button_delete[num].MouseLeave += new EventHandler(events.menu1_done_main_panel_button_delete_MouseLeave);
            }

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();

            int cnt = -1;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                    && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    cnt++;
                }
                if (cnt == num)
                {
                    Properties.Settings.Default.done_name.RemoveAt(i);
                    Properties.Settings.Default.done_time.RemoveAt(i);
                    Properties.Settings.Default.done_day.RemoveAt(i);

                    break;
                }
            }

            Properties.Settings.Default.Save();

            Main.Common_Var.menu1_day_done -= 1;
            Main.Common_Var.menu1_done -= 1;

            ChangeDoneNum(form);
        }

        // 削除ボタン追加
        public static Button add_menu1_done_main_panel_button_delete(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu1_done_main_panel_button_delete = new Button();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel_button_delete.BackColor = Color.Transparent;
            menu1_done_main_panel_button_delete.Dock = DockStyle.Right;
            menu1_done_main_panel_button_delete.FlatStyle = FlatStyle.Flat;
            menu1_done_main_panel_button_delete.Image = ((Image)(resources.GetObject("menu2_1_panel_main_panel1_button_delete.Image")));
            menu1_done_main_panel_button_delete.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel_button_delete.Size = new Size(32, 32);
            menu1_done_main_panel_button_delete.UseVisualStyleBackColor = false;
            menu1_done_main_panel_button_delete.Click += new EventHandler(events.menu1_done_main_panel_button_delete_Click);
            menu1_done_main_panel_button_delete.MouseEnter += new EventHandler(events.menu1_done_main_panel_button_delete_MouseEnter);
            menu1_done_main_panel_button_delete.MouseLeave += new EventHandler(events.menu1_done_main_panel_button_delete_MouseLeave);
            menu1_done_main_panel_button_delete.Cursor = Cursors.Hand;

            return menu1_done_main_panel_button_delete;
        }
        // 実績時間追加
        public static Label add_menu1_done_main_panel_label_time(MainForm form, string text)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu1_done_main_panel_label_time = new Label();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel_label_time.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            menu1_done_main_panel_label_time.Size = new Size(78, done_height - 2);
            menu1_done_main_panel_label_time.Location = new Point(form.menu1_done_main_panel_button_delete[Main.Common_Var.menu1_day_done].Location.X
                - menu1_done_main_panel_label_time.Width, 1);
            menu1_done_main_panel_label_time.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel_label_time.Text = text;
            menu1_done_main_panel_label_time.TextAlign = ContentAlignment.MiddleLeft;
            menu1_done_main_panel_label_time.MouseEnter += new EventHandler(events.menu1_done_main_panel_label_time_MouseEnter);
            menu1_done_main_panel_label_time.MouseLeave += new EventHandler(events.menu1_done_main_panel_label_time_MouseLeave);
            menu1_done_main_panel_label_time.Click += new System.EventHandler(events.menu1_done_main_panel_label_time_Click);
            menu1_done_main_panel_label_time.Cursor = Cursors.Hand;

            return menu1_done_main_panel_label_time;
        }
        // 実績名追加
        public static Label add_menu1_done_main_panel_label_name(MainForm form, string time)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu1_done_main_panel_label_name = new Label();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel_label_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu1_done_main_panel_label_name.Location = new Point(1, 1);
            menu1_done_main_panel_label_name.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel_label_name.Size = new Size(Main.Common_Const.form_x - 10
                - form.menu1_done_main_panel_button_delete[Main.Common_Var.menu1_day_done].Width
                - form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_day_done].Width
                - menu1_done_main_panel_label_name.Location.X * 2, done_height - 2);
            menu1_done_main_panel_label_name.Text = time;
            menu1_done_main_panel_label_name.TextAlign = ContentAlignment.MiddleLeft;
            menu1_done_main_panel_label_name.MouseEnter += new EventHandler(events.menu1_done_main_panel_label_name_MouseEnter);
            menu1_done_main_panel_label_name.MouseLeave += new EventHandler(events.menu1_done_main_panel_label_name_MouseLeave);
            menu1_done_main_panel_label_name.Click += new System.EventHandler(events.menu1_done_main_panel_label_name_Click);
            menu1_done_main_panel_label_name.Cursor = Cursors.Hand;

            return menu1_done_main_panel_label_name;
        }
        // タスクパネル追加
        public static PanelEx add_menu1_done_main_panel(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelEx menu1_done_main_panel = new PanelEx();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menu1_done_main_panel.BorderColor = Color.Black;
            menu1_done_main_panel.Controls.Add(form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_day_done]);
            menu1_done_main_panel.Controls.Add(form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_day_done]);
            menu1_done_main_panel.Controls.Add(form.menu1_done_main_panel_button_delete[Main.Common_Var.menu1_day_done]);
            menu1_done_main_panel.Location = new Point(done_x, (menu1_done_main_panel.Height + done_space) * Main.Common_Var.menu1_day_done);
            menu1_done_main_panel.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel.Size = new Size(form.menu1_done_main.Width - menu1_done_main_panel.Location.X * 2, done_height);
            menu1_done_main_panel.MouseEnter += new EventHandler(events.menu1_done_main_panel_MouseEnter);
            menu1_done_main_panel.MouseLeave += new EventHandler(events.menu1_done_main_panel_MouseLeave);
            menu1_done_main_panel.Click += new EventHandler(events.menu1_done_main_panel_Click);
            menu1_done_main_panel.Cursor = Cursors.Hand;

            return menu1_done_main_panel;
        }

        #endregion private
        // ********** private **********
    }
}
