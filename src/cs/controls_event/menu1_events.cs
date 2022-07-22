using System;
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
            ChangeDoneDay(form, int.Parse(((Panel)sender).Name));
        }
        public static void menu1_table_calender_panel_day_label_day_MouseDoubleClick(object sender, EventArgs e, MainForm form)
        {
            ChangeDoneDay(form, int.Parse(((Label)sender).Name));
        }

        public static void menu1_done_top_prevday_Click(object sender, EventArgs e, MainForm form)
        {
            DateTime day = new DateTime(Main.Common_Var.menu1_done_year, Main.Common_Var.menu1_done_month, Main.Common_Var.menu1_done_day);
            day = day.AddDays(-1);
            string[] date = { "日", "月", "火", "水", "木", "金", "土" };
            DayOfWeek dow = day.DayOfWeek;
            Main.Common_Var.menu1_done_year =  day.Year;
            Main.Common_Var.menu1_done_month = day.Month;
            Main.Common_Var.menu1_done_day = day.Day;
            form.menu1_done_top_label_day.Text = day.ToShortDateString() + " (" + date[(int)dow] + ")";

            int cnt = 0;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                if (Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    cnt++;
                }
            }
            Main.Common_Var.menu1_day_done = cnt;
        }
        public static void menu1_done_top_nextday_Click(object sender, EventArgs e, MainForm form)
        {
            DateTime day = new DateTime(Main.Common_Var.menu1_done_year, Main.Common_Var.menu1_done_month, Main.Common_Var.menu1_done_day);
            day = day.AddDays(1);
            string[] date = { "日", "月", "火", "水", "木", "金", "土" };
            DayOfWeek dow = day.DayOfWeek;
            Main.Common_Var.menu1_done_year = day.Year;
            Main.Common_Var.menu1_done_month = day.Month;
            Main.Common_Var.menu1_done_day = day.Day;
            form.menu1_done_top_label_day.Text = day.ToShortDateString() + " (" + date[(int)dow] + ")";

            int cnt = 0;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                if (Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    cnt++;
                }
            }
            Main.Common_Var.menu1_day_done = cnt;
        }
        public static void menu1_done_top_button_add_Click(object sender, EventArgs e, MainForm form)
        {
            OpenDone(form, Main.Common_Var.menu1_done);
        }

        public void menu1_done_main_panel_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].BorderColor = Color.Black;
            form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_name_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Black;
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_time_MouseEnter(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Black;
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        // 実績削除ボタンホバー時
        public void menu1_done_main_panel_button_delete_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu1_done_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 255, 128, 128);
                form.menu1_done_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Green;
                form.menu1_done_main_panel[int.Parse(((Button)sender).Name)].Refresh();
            }
        }

        public void menu1_done_main_panel_MouseLeave(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].BorderColor = Color.Black;
            form.menu1_done_main_panel[int.Parse(((PanelEx)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_name_MouseLeave(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Black;
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        public void menu1_done_main_panel_label_time_MouseLeave(object sender, EventArgs e)
        {
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Black;
            form.menu1_done_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        // 実績削除ボタンホバーが離れた時
        public void menu1_done_main_panel_button_delete_MouseLeave(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu1_done_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
                form.menu1_done_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
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
            //RemoveDone(form, int.Parse(((Button)sender).Name));
        }
        #endregion form event
        // ********** form event **********

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

            Properties.Settings.Default.done_name.Add(form.menudone_table1_text.Text);
            Properties.Settings.Default.done_prog.Add(form.menudone_table2_text.Text);
            Properties.Settings.Default.done_time.Add(form.menudone_table3_text.Text);
            Properties.Settings.Default.done_memo.Add(form.menudone_table4_text.Text);
            Properties.Settings.Default.done_day.Add(Main.Common_Var.menu1_done_year.ToString() + "/"
                + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString());

            Properties.Settings.Default.Save();


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
                Properties.Settings.Default.done_prog.Add(form.menudone_table2_text.Text);
                Properties.Settings.Default.done_time.Add(form.menudone_table3_text.Text);
                Properties.Settings.Default.done_memo.Add(form.menudone_table4_text.Text);
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
                Properties.Settings.Default.done_memo[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done] = form.menudone_table4_text.Text;

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
                form.menu1_done_main.Height = 34 + 35 * Main.Common_Var.menu1_day_done;
            }
            else // 実績数が0の時
            {
                form.menu1_done_main.Height = 34 + 18;
            }

            int num = 0;
            for (int i = 0; i < Main.Common_Var.menu1_done; i++)
            {
                if (Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    form.menu1_done_main_panel_label_name[num].Text = Properties.Settings.Default.done_name[i];
                    form.menu1_done_main_panel_label_time[num].Text = Properties.Settings.Default.done_time[i];
                    num += 1;
                }
            }

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();
        }

        #endregion public

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

        private static void ChangeDoneDay(MainForm form, int num)
        {
            int year = int.Parse(form.menu1_panel_yearmonth_combo_year.Text);
            int month = int.Parse(form.menu1_panel_yearmonth_combo_month.Text);
            DateTime firstday = new DateTime(year, month, 1);
            DayOfWeek firstdate = firstday.DayOfWeek;
            int subday = 0;
            int[] days = new int[42];
            DateTime now = DateTime.Now;
            int today = 0;
            int day = 0;

            DateTime selectDate = new DateTime();

            DayOfWeek dow = new DayOfWeek();

            common_events.Get_Calender(year, month, ref now, ref days, ref subday, ref firstday, ref today);
            day = days[num];
            if ((int)firstdate - 1 < num && num < subday) // 対象が今月中の場合
            {
                selectDate = new DateTime(year, month, day);
                dow = selectDate.DayOfWeek;
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
                selectDate = new DateTime(year, month, day);
                dow = selectDate.DayOfWeek;
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
                selectDate = new DateTime(year, month, day);
                dow = selectDate.DayOfWeek;
            }
            string[] date = { "日", "月", "火", "水", "木", "金", "土" };
            string label_day = selectDate.ToShortDateString() + " (" + date[(int)dow] + ")";

            Main.Common_Var.menu1_done_year = year;
            Main.Common_Var.menu1_done_month = month;
            Main.Common_Var.menu1_done_day = day;

            form.menu1_done_top_label_day.Text = label_day;

            int cnt = 0;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                if (Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    cnt++;
                }
            }
            Main.Common_Var.menu1_day_done = cnt;
        }

        // タスクを開く
        private static void OpenDone(MainForm form, int done_num)
        {
            Main.Common_Var.menu1_open_done = done_num;
            Main.Common_Var.menu1_delete_done = 0;
            if (done_num >= Main.Common_Var.menu1_done) // 新規タスク
            {
                form.menudone_table1_text.Text = "";
                form.menudone_table2_text.Text = "";
                form.menudone_table3_text.Text = "";
                form.menudone_table4_text.Text = "";
                form.menudone.Visible = true;
            }
            else // 既存タスク
            {
                form.menudone_table1_text.Text = Properties.Settings.Default.done_name[done_num];
                form.menudone_table2_text.Text = Properties.Settings.Default.done_memo[done_num];
                form.menudone_table3_text.Text = "";
                form.menudone_table4_text.Text = "";
                form.menudone.Visible = true;
            }

        }

        // 削除ボタン追加
        private static Button add_menu1_done_main_panel_button_delete(MainForm form)
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
        private static Label add_menu1_done_main_panel_label_time(MainForm form, string text)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu1_done_main_panel_label_time = new Label();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel_label_time.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            menu1_done_main_panel_label_time.Size = new Size(78, 30);
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
        private static Label add_menu1_done_main_panel_label_name(MainForm form, string time)
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
                - menu1_done_main_panel_label_name.Location.X * 2, 30);
            menu1_done_main_panel_label_name.Text = time;
            menu1_done_main_panel_label_name.TextAlign = ContentAlignment.MiddleLeft;
            menu1_done_main_panel_label_name.MouseEnter += new EventHandler(events.menu1_done_main_panel_label_name_MouseEnter);
            menu1_done_main_panel_label_name.MouseLeave += new EventHandler(events.menu1_done_main_panel_label_name_MouseLeave);
            menu1_done_main_panel_label_name.Click += new System.EventHandler(events.menu1_done_main_panel_label_name_Click);
            menu1_done_main_panel_label_name.Cursor = Cursors.Hand;

            return menu1_done_main_panel_label_name;
        }
        // タスクパネル追加
        private static PanelEx add_menu1_done_main_panel(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelEx menu1_done_main_panel = new PanelEx();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menu1_done_main_panel.BorderColor = Color.Black;
            menu1_done_main_panel.Controls.Add(form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_day_done]);
            menu1_done_main_panel.Controls.Add(form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_day_done]);
            menu1_done_main_panel.Controls.Add(form.menu1_done_main_panel_button_delete[Main.Common_Var.menu1_day_done]);
            menu1_done_main_panel.Location = new Point(4, (menu1_done_main_panel.Height + 4) * Main.Common_Var.menu1_day_done);
            menu1_done_main_panel.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel.Size = new Size(form.menu1_done_main.Width - menu1_done_main_panel.Location.X * 2, 32);
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
