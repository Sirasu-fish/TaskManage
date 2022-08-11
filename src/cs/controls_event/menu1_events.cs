using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu1_events
    {
        private MainForm form;
        static private int done_x = 4; // 実績のX位置
        static private int done_height = 32; // 実績の高さ
        static private int done_space = -1; // 実績と実績の隙間
        static private Color color_select_done = Main.Common_Const.color_gray1; // 選択、ホバーした実績の色

        // コンストラクタ
        public menu1_events(MainForm form)
        {
            this.form = form;
        }

        // ********** form event **********
        #region form event

        // 前の月に移動するボタン押下
        public static void menu1_panel_yearmonth_button_prevmonth_Click(object sender, EventArgs e, MainForm form)
        {
            int year = 0; // 年
            int month = 0; // 月

            Get_YearMonth(form, ref year, ref month); // 年、月を取得
            month = (month + 10) % 12 + 1; // 前月を取得 例：12 → 10 + 1 = 11 | 1 → 11 + 1 = 12
            if (month == 12) // 12月の時
            {
                year = year - 1; // 1年前
            }
            common_events.Set_Day(form, year, month); // カレンダーに設定
            form.menu1_panel_yearmonth_combo_year.SelectedItem = year.ToString(); // 年を更新している可能性があるため、更新
            form.menu1_panel_yearmonth_combo_month.SelectedItem = month.ToString(); // 月を更新している可能性があるため、更新
        }

        //次の月に移動するボタン押下
        public static void menu1_panel_yearmonth_button_nextmonth_Click(object sender, EventArgs e, MainForm form)
        {
            int year = 0;
            int month = 0;
            Get_YearMonth(form, ref year, ref month);
            month = month % 12 + 1;
            if (month == 1) // 1月の時
            {
                year = year + 1; // 1年後
            }
            common_events.Set_Day(form, year, month); // カレンダーに設定
            form.menu1_panel_yearmonth_combo_year.SelectedItem = year.ToString(); // 年を更新している可能性があるため、更新
            form.menu1_panel_yearmonth_combo_month.SelectedItem = month.ToString(); // 月を更新している可能性があるため、更新
        }

        // 年のセレクトボックス変更時
        public static void menu1_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e, MainForm form)
        {
            Change_YearMonth(form);
        }
        // 月のセレクトボックス変更時
        public static void menu1_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e, MainForm form)
        {
            Change_YearMonth(form);
        }

        // 日付ホバー時
        public static void menu1_table_calender_panel_day_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Panel)sender).Name)]);
        }
        public static void menu1_table_calender_panel_day_label_day_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)]);
        }
        public static void menu1_table_calender_panel_day_label_done_MouseEnter(object sender, EventArgs e, MainForm form)
        {
            OverMouse(form.menu1_table_calender_panel_day[int.Parse(((Label)sender).Name)]);
        }
        // 日付ホバーが離れた時
        public static void menu1_table_calender_panel_day_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day_label_day_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            NoOverMouse(form);
        }
        public static void menu1_table_calender_panel_day_label_done_MouseLeave(object sender, EventArgs e, MainForm form)
        {
            NoOverMouse(form);
        }
        // 日付クリック
        public static void menu1_table_calender_panel_day_MouseClick(object sender, EventArgs e, MainForm form)
        {
            ClickPanel(form, int.Parse(((Panel)sender).Name));
            SetDoneDay(form, int.Parse(((Panel)sender).Name));
        }
        public static void menu1_table_calender_panel_day_label_day_MouseClick(object sender, EventArgs e, MainForm form)
        {
            ClickPanel(form, int.Parse(((Label)sender).Name));
            SetDoneDay(form, int.Parse(((Label)sender).Name));
        }
        public static void menu1_table_calender_panel_day_label_done_MouseClick(object sender, EventArgs e, MainForm form)
        {
            ClickPanel(form, int.Parse(((Label)sender).Name));
            SetDoneDay(form, int.Parse(((Label)sender).Name));
        }

        // 実績 1日戻るボタン押下
        public static void menu1_done_top_prevday_Click(object sender, EventArgs e, MainForm form)
        {
            // 選択済みの日付を取得して1日戻る
            DateTime day = new DateTime(Main.Common_Var.menu1_done_year, Main.Common_Var.menu1_done_month, Main.Common_Var.menu1_done_day).AddDays(-1);

            ChangeDoneDay(form, day.Year, day.Month, day.Day);
        }
        // 実績 1日進むボタン押下
        public static void menu1_done_top_nextday_Click(object sender, EventArgs e, MainForm form)
        {
            // 選択済みの日付を取得して1日進む
            DateTime day = new DateTime(Main.Common_Var.menu1_done_year, Main.Common_Var.menu1_done_month, Main.Common_Var.menu1_done_day).AddDays(1);

            ChangeDoneDay(form, day.Year, day.Month, day.Day);
        }

        // 実績マウスホバー時
        public void menu1_done_main_panel_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterDone(int.Parse(((PanelEx)sender).Name));
        }
        public void menu1_done_main_panel_label_name_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterDone(int.Parse(((Label)sender).Name));
        }
        public void menu1_done_main_panel_label_time_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterDone(int.Parse(((Label)sender).Name));
        }
        // 実績削除ボタンホバー時
        public void menu1_done_main_panel_button_delete_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) < 0 || Main.Common_Var.menu1_day_done <= int.Parse(((Button)sender).Name))
            {
                return;
            }
            form.menu1_done_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 255, 128, 128);
            MouseEnterDone(int.Parse(((Button)sender).Name));
        }

        // 実績マウスホバーが離れた時
        public void menu1_done_main_panel_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveDone(int.Parse(((PanelEx)sender).Name));
        }
        public void menu1_done_main_panel_label_name_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveDone(int.Parse(((Label)sender).Name));
        }
        public void menu1_done_main_panel_label_time_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveDone(int.Parse(((Label)sender).Name));
        }
        // 実績削除ボタンホバーが離れた時
        public void menu1_done_main_panel_button_delete_MouseLeave(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) < 0 || Main.Common_Var.menu1_day_done <= int.Parse(((Button)sender).Name))
            {
                return;
            }
            form.menu1_done_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
            MouseLeaveDone(int.Parse(((Button)sender).Name));
        }

        // 実績追加ボタン押下
        public static void menu1_done_top_button_add_Click(object sender, EventArgs e, MainForm form)
        {
            OpenDone(form, Main.Common_Var.menu1_day_done);
        }
        // 実績押下
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
         // 実績削除ボタン押下
        public void menu1_done_main_panel_button_delete_Click(object sender, EventArgs e)
        {
            RemoveDone(form, int.Parse(((Button)sender).Name));
        }
        #endregion form event
        // ********** form event **********

        // ********** public **********
        #region public
        // 年月変更時イベント
        public static void Change_YearMonth(MainForm form)
        {
            int year;
            int month;
            if (form.menu1_panel_yearmonth_combo_year.SelectedItem == null)
            {
                year = DateTime.Now.Year;
            }
            else
            {
                year = int.Parse(form.menu1_panel_yearmonth_combo_year.SelectedItem.ToString());
                if (!(int.Parse(form.menu1_panel_yearmonth_combo_year.Items[0].ToString()) <= year && year <= int.Parse(form.menu1_panel_yearmonth_combo_year.Items[4].ToString())))
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
                month = int.Parse(form.menu1_panel_yearmonth_combo_month.SelectedItem.ToString());
                if (!(1 <= month && month <= 12))
                {
                    month = DateTime.Now.Month;
                }
            }
            form.menu1_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            form.menu1_panel_yearmonth_combo_month.SelectedItem = month.ToString();
            common_events.Set_Day(form, year, month);
        }

        // 初期 実績追加
        public static void InitAddDone(MainForm form, String text, String time)
        {
            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            form.menu1_done_main_panel_button_delete.Add(add_menu1_done_main_panel_button_delete(form));
            form.menu1_done_main_panel.Add(add_menu1_done_main_panel(form));
            form.menu1_done_main_panel_label_name.Add(add_menu1_done_main_panel_label_name(form, text));
            form.menu1_done_main_panel_label_time.Add(add_menu1_done_main_panel_label_time(form, time));
            form.menu1_done_main_panel[Main.Common_Var.menu1_day_done].Controls.Add(form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_day_done]);
            form.menu1_done_main_panel[Main.Common_Var.menu1_day_done].Controls.Add(form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_day_done]);
            form.menu1_done_main.Controls.Add(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done]);

            DAndDMoveDone menu1_MoveDone_label_name;
            menu1_MoveDone_label_name = new DAndDMoveDone(form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_day_done], form);
            DAndDMoveDone menu1_MoveDone_label_time;
            menu1_MoveDone_label_time = new DAndDMoveDone(form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_day_done], form);
            DAndDMoveDone menu1_MoveDone_panel;
            menu1_MoveDone_panel = new DAndDMoveDone(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done], form);

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();

            Main.Common_Var.menu1_done += 1;
            Main.Common_Var.menu1_day_done += 1;

            ChangeDoneNum(form);
        }
        public static void AddDone(MainForm form, int hour, int minute, int year, int month, int day)
        {
            if (Main.Common_Var.menu1_day_done <= Main.Common_Var.menu1_open_done) // 新規追加
            {
                if (year == Main.Common_Var.menu1_done_year && month == Main.Common_Var.menu1_done_month && day == Main.Common_Var.menu1_done_day)
                {
                    form.SuspendLayout();
                    form.menu1.SuspendLayout();
                    form.menu1_done_main.SuspendLayout();

                    form.menu1_done_main_panel_button_delete.Add(add_menu1_done_main_panel_button_delete(form));
                    form.menu1_done_main_panel.Add(add_menu1_done_main_panel(form));
                    form.menu1_done_main_panel_label_name.Add(add_menu1_done_main_panel_label_name(form, form.menudone_table1_text.Text));
                    form.menu1_done_main_panel_label_time.Add(add_menu1_done_main_panel_label_time(form, (hour * 60 + minute).ToString()));
                    form.menu1_done_main_panel[Main.Common_Var.menu1_day_done].Controls.Add(form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_day_done]);
                    form.menu1_done_main_panel[Main.Common_Var.menu1_day_done].Controls.Add(form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_day_done]);
                    form.menu1_done_main.Controls.Add(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done]);

                    DAndDMoveDone menu1_MoveDone_label_name;
                    menu1_MoveDone_label_name = new DAndDMoveDone(form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_day_done], form);
                    DAndDMoveDone menu1_MoveDone_label_time;
                    menu1_MoveDone_label_time = new DAndDMoveDone(form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_day_done], form);
                    DAndDMoveDone menu1_MoveDone_panel;
                    menu1_MoveDone_panel = new DAndDMoveDone(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done], form);

                    form.ResumeLayout();
                    form.menu1.ResumeLayout();
                    form.menu1_done_main.ResumeLayout();
                }

                Properties.Settings.Default.done_name.Add(form.menudone_table1_text.Text);
                Properties.Settings.Default.done_time.Add((hour * 60 + minute).ToString());
                Properties.Settings.Default.done_memo.Add(form.menudone_table3_text.Text);
                Properties.Settings.Default.done_day.Add(year.ToString() + "/"
                    + month.ToString() + "/" + day.ToString());

                Properties.Settings.Default.Save();

                Main.Common_Var.menu1_done += 1;
                if (year == Main.Common_Var.menu1_done_year && month == Main.Common_Var.menu1_done_month && day == Main.Common_Var.menu1_done_day)
                {
                    Main.Common_Var.menu1_day_done += 1;
                }

                Main.Common_Var.menu1_open_done = Main.Common_Var.menu1_day_done;

                ChangeDoneNum(form);

                int sumtime = 0;
                for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
                {
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                    && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                    {
                        sumtime += int.Parse(Properties.Settings.Default.done_time[i]);
                    }
                }

                UpdateDoneTime(form, sumtime);
            }
            else // 既存更新
            {
                if (year == Main.Common_Var.menu1_done_year && month == Main.Common_Var.menu1_done_month && day == Main.Common_Var.menu1_done_day)
                {
                    form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Text = form.menudone_table1_text.Text;
                    form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Text = "";
                    if (hour != 0)
                    {
                        form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Text += hour + "h";
                    }
                    if (minute != 0)
                    {
                        form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Text += minute + "m";
                    }
                    form.menu1_done_main_panel_label_name[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Refresh();
                    form.menu1_done_main_panel_label_time[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Refresh();

                    int cnt = -1;
                    int sumtime = 0;
                    for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                        && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                        {
                            cnt++;
                            if (cnt == Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done)
                            {
                                Properties.Settings.Default.done_name[i] = form.menudone_table1_text.Text;
                                Properties.Settings.Default.done_time[i] = (hour * 60 + minute).ToString();
                                Properties.Settings.Default.done_memo[i] = form.menudone_table3_text.Text;
                                Properties.Settings.Default.done_day[i] = (year.ToString() + "/"
                                + month.ToString() + "/" + day.ToString());
                                Properties.Settings.Default.Save();
                            }
                            sumtime += int.Parse(Properties.Settings.Default.done_time[i]);
                        }
                    }

                    UpdateDoneTime(form, sumtime);

                    form.menu1_done_main_panel[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].BackColor = Color.Transparent;
                }
                else
                {
                    int cnt = -1;
                    for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                        && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                        {
                            cnt++;
                        }
                        if (cnt == Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done)
                        {
                            Properties.Settings.Default.done_name[i] = form.menudone_table1_text.Text;
                            Properties.Settings.Default.done_time[i] = (hour * 60 + minute).ToString();
                            Properties.Settings.Default.done_memo[i] = form.menudone_table3_text.Text;
                            Properties.Settings.Default.done_day[i] = (year.ToString() + "/"
                            + month.ToString() + "/" + day.ToString());
                            Properties.Settings.Default.Save();

                            break;
                        }
                    }

                    form.SuspendLayout();
                    form.menu1.SuspendLayout();
                    form.menu1_done_main.SuspendLayout();

                    for (int i = cnt; i < Main.Common_Var.menu1_day_done; i++)
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
                    form.menu1_done_main.Controls.Remove(form.menu1_done_main_panel[cnt]);
                    form.menu1_done_main_panel_label_name.RemoveAt(cnt);
                    form.menu1_done_main_panel_label_time.RemoveAt(cnt);
                    form.menu1_done_main_panel_button_delete.RemoveAt(cnt);
                    form.menu1_done_main_panel.RemoveAt(cnt);

                    form.ResumeLayout();
                    form.menu1.ResumeLayout();
                    form.menu1_done_main.ResumeLayout();

                    Main.Common_Var.menu1_day_done -= 1;
                }

                Main.Common_Var.menu1_open_done = Main.Common_Var.menu1_day_done;
                Main.Common_Var.menu1_delete_done = 0;
            }
        }

        // 実績変更時高さ調整
        public static void ChangeDoneNum(MainForm form)
        {
            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            form.menu1_done_main.Height = (done_height + done_space) * Main.Common_Var.menu1_day_done + 4; // 高さ調整

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();
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
            menu1_done_main_panel_button_delete.BackgroundImage = ((Image)(resources.GetObject("menu1_done_main_panel_button_delete.Image")));
            menu1_done_main_panel_button_delete.BackgroundImageLayout = ImageLayout.Center;
            menu1_done_main_panel_button_delete.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel_button_delete.Size = new Size(32, 32);
            menu1_done_main_panel_button_delete.UseVisualStyleBackColor = false;
            menu1_done_main_panel_button_delete.Click += new EventHandler(events.menu1_done_main_panel_button_delete_Click);
            menu1_done_main_panel_button_delete.MouseEnter += new EventHandler(events.menu1_done_main_panel_button_delete_MouseEnter);
            menu1_done_main_panel_button_delete.MouseLeave += new EventHandler(events.menu1_done_main_panel_button_delete_MouseLeave);
            menu1_done_main_panel_button_delete.Cursor = Cursors.Hand;
            form.tooltip.SetToolTip(menu1_done_main_panel_button_delete, "削除");

            return menu1_done_main_panel_button_delete;
        }
        // 実績時間追加
        public static Label add_menu1_done_main_panel_label_time(MainForm form, string time)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu1_done_main_panel_label_time = new Label();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel_label_time.AutoSize = false;
            menu1_done_main_panel_label_time.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            menu1_done_main_panel_label_time.Size = new Size(48, 14);
            menu1_done_main_panel_label_time.Location = new Point(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done].Width - 32 - 48 - 2, 9);
            menu1_done_main_panel_label_time.Text = (int.Parse(time) / 60).ToString() + "h" + (int.Parse(time) % 60).ToString() + "m";
            menu1_done_main_panel_label_time.Text = "";
            if (int.Parse(time) / 60 != 0)
            {
                menu1_done_main_panel_label_time.Text += (int.Parse(time) / 60).ToString() + "h";
            }
            if (int.Parse(time) % 60 != 0)
            {
                menu1_done_main_panel_label_time.Text += (int.Parse(time) % 60).ToString() + "m";
            }
            menu1_done_main_panel_label_time.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel_label_time.TextAlign = ContentAlignment.MiddleRight;
            menu1_done_main_panel_label_time.MouseEnter += new EventHandler(events.menu1_done_main_panel_label_time_MouseEnter);
            menu1_done_main_panel_label_time.MouseLeave += new EventHandler(events.menu1_done_main_panel_label_time_MouseLeave);
            menu1_done_main_panel_label_time.Click += new System.EventHandler(events.menu1_done_main_panel_label_time_Click);
            menu1_done_main_panel_label_time.Cursor = Cursors.Hand;

            return menu1_done_main_panel_label_time;
        }
        // 実績名追加
        public static Label add_menu1_done_main_panel_label_name(MainForm form, string text)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu1_done_main_panel_label_name = new Label();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel_label_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu1_done_main_panel_label_name.Location = new Point(1, 9);
            menu1_done_main_panel_label_name.Name = Main.Common_Var.menu1_day_done.ToString();
            menu1_done_main_panel_label_name.AutoSize = false;
            menu1_done_main_panel_label_name.AutoEllipsis = true;
            menu1_done_main_panel_label_name.Size = new Size(form.menu1_done_main_panel[Main.Common_Var.menu1_day_done].Width - 32 - 48 - 2, 14);
            menu1_done_main_panel_label_name.Text = text;
            menu1_done_main_panel_label_name.TextAlign = ContentAlignment.MiddleLeft;
            menu1_done_main_panel_label_name.MouseEnter += new EventHandler(events.menu1_done_main_panel_label_name_MouseEnter);
            menu1_done_main_panel_label_name.MouseLeave += new EventHandler(events.menu1_done_main_panel_label_name_MouseLeave);
            menu1_done_main_panel_label_name.Click += new System.EventHandler(events.menu1_done_main_panel_label_name_Click);
            menu1_done_main_panel_label_name.Cursor = Cursors.Hand;

            return menu1_done_main_panel_label_name;
        }
        // 実績パネル追加
        public static PanelEx add_menu1_done_main_panel(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelEx menu1_done_main_panel = new PanelEx();
            menu1_events events = new menu1_events(form);

            menu1_done_main_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menu1_done_main_panel.BorderColor = Color.Black;
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
            pen = new Pen(Main.Common_Const.color_main);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // 日付ホバーが外れた時の動作
        private static void NoOverMouse(MainForm form)
        {
            // ホバーしていた日付の表示更新(クリックしたもの以外)
            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                if (Main.Common_Var.clickpanel == i)
                {
                    continue;
                }
                form.menu1_table_calender_panel_day[i].Refresh();
            }

            Panel panel = new Panel();

            // クリックしたものが範囲外の時は抜ける
            if (Main.Common_Var.clickpanel < 0 || 41 < Main.Common_Var.clickpanel)
            {
                return;
            }

            // クリックしているパネル
            Graphics g = form.menu1_table_calender_panel_day[Main.Common_Var.clickpanel].CreateGraphics();
            Pen pen;

            int r = form.menu1_table_calender_panel_day[Main.Common_Var.clickpanel].ClientRectangle.Right - 1;
            int b = form.menu1_table_calender_panel_day[Main.Common_Var.clickpanel].ClientRectangle.Bottom - 1;
            pen = new Pen(Main.Common_Const.color_main);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // 日付クリック時の動作
        private static void ClickPanel(MainForm form, int panel_num)
        {
            Main.Common_Var.clickpanel = panel_num;

            Graphics g = form.menu1_table_calender_panel_day[panel_num].CreateGraphics();
            Pen pen;

            int r = form.menu1_table_calender_panel_day[panel_num].ClientRectangle.Right - 1;
            int b = form.menu1_table_calender_panel_day[panel_num].ClientRectangle.Bottom - 1;
            pen = new Pen(Main.Common_Const.color_main);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // セレクトボックスの年、月を取得
        private static void Get_YearMonth(MainForm form, ref int year, ref int month)
        {
            if (int.TryParse(form.menu1_panel_yearmonth_combo_year.SelectedItem.ToString(), out int y)) // 年が整数に変換可能な時
            {
                if (!(int.Parse(form.menu1_panel_yearmonth_combo_year.Items[0].ToString()) <= y && y <= int.Parse(form.menu1_panel_yearmonth_combo_year.Items[4].ToString()))) // 範囲外の年
                {
                    year = DateTime.Now.Year; // 今年
                }
                else
                {
                    year = y; // 入力された年
                }
            }
            else
            {
                year = DateTime.Now.Year; // 今年
            }

            if (int.TryParse(form.menu1_panel_yearmonth_combo_month.SelectedItem.ToString(), out int m)) // 月が整数に変換可能な時
            {
                if (!(1 <= m && m <= 12)) // 範囲外の月
                {
                    month = DateTime.Now.Month; // 今月
                }
                else
                {
                    month = m; // 入力された月
                }
            }
            else
            {
                month = DateTime.Now.Month; // 今月
            }
        }

        // カレンダーから実績の日付を設定
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

        // 実績の日付変更時
        private static void ChangeDoneDay(MainForm form, int year, int month, int day)
        {
            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            form.menudone.Visible = false;

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

            int sumtime = 0;

            // 対象の日付の実績を追加、表示
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                Main.Common_Var.menu1_done += 1;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                    && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    sumtime += int.Parse(Properties.Settings.Default.done_time[i]);
                    InitAddDone(form, Properties.Settings.Default.done_name[i], Properties.Settings.Default.done_time[i]);
                }
            }

            form.menu1_done_top_label_hour.Text = "";
            form.menu1_done_top_label_hour.BackColor = Color.Transparent;
            if (sumtime / 60 != 0)
            {
                form.menu1_done_top_label_hour.Text += (sumtime / 60).ToString() + "h";
                if (sumtime / 60 >= 12)
                {
                    form.menu1_done_top_label_hour.BackColor = Main.Common_Const.color_done2;
                }
                else
                {
                    form.menu1_done_top_label_hour.BackColor = Main.Common_Const.color_done1;
                }
            }
            else if (sumtime > 0)
            {
                form.menu1_done_top_label_hour.BackColor = Main.Common_Const.color_done1;
            }
            if (sumtime % 60 != 0)
            {
                form.menu1_done_top_label_hour.Text += (sumtime % 60).ToString() + "m";
            }

            form.menu1_done_top_label_hour.Refresh();

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();
        }

        // 実績を開く
        private static void OpenDone(MainForm form, int done_num)
        {
            Main.Common_Var.menu1_open_done = done_num;
            Main.Common_Var.menu1_delete_done = 0;

            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_panel_yearmonth.SuspendLayout();
            form.menu1_table_calender.SuspendLayout();
            form.menu1_done_top.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

            // 実績の背景色リセット
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
                    if (cnt < Main.Common_Var.menu1_day_done && cnt == done_num) // 既存実績
                    {
                        form.menudone_table1_text.Text = Properties.Settings.Default.done_name[i];
                        form.menudone_table2_text_h.Text = (int.Parse(Properties.Settings.Default.done_time[i]) / 60).ToString();
                        form.menudone_table2_text_m.Text = (int.Parse(Properties.Settings.Default.done_time[i]) % 60).ToString();
                        form.menudone_table2_text_year.Text = Main.Common_Var.menu1_done_year.ToString();
                        form.menudone_table2_text_month.Text = Main.Common_Var.menu1_done_month.ToString();
                        form.menudone_table2_text_day.Text = Main.Common_Var.menu1_done_day.ToString();
                        form.menudone_table3_text.Text = Properties.Settings.Default.done_memo[i];
                        form.menudone.Visible = true;
                        form.menu1_done_main_panel[done_num].BackColor = color_select_done;

                        form.ResumeLayout();
                        form.menu1.ResumeLayout();
                        form.menu1_panel_yearmonth.ResumeLayout();
                        form.menu1_table_calender.ResumeLayout();
                        form.menu1_done_top.ResumeLayout();
                        form.menu1_done_main.ResumeLayout();
                        return;
                    }
                }
            }

            if (done_num >= Main.Common_Var.menu1_day_done) // 新規実績
            {
                form.menudone_table1_text.Text = "";
                form.menudone_table2_text_h.Text = "0";
                form.menudone_table2_text_m.Text = "0";
                form.menudone_table2_text_year.Text = Main.Common_Var.menu1_done_year.ToString();
                form.menudone_table2_text_month.Text = Main.Common_Var.menu1_done_month.ToString();
                form.menudone_table2_text_day.Text = Main.Common_Var.menu1_done_day.ToString();
                form.menudone_table3_text.Text = "";
                form.menudone.Visible = true;
            }

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_panel_yearmonth.ResumeLayout();
            form.menu1_table_calender.ResumeLayout();
            form.menu1_done_top.ResumeLayout();
            form.menu1_done_main.ResumeLayout();
        }

        // 実績削除ボタン押下
        private void RemoveDone(MainForm form, int num)
        {
            if (num <= Main.Common_Var.menu1_open_done) // 削除する実績が保存した番号より前の時、回数をカウント
            {
                Main.Common_Var.menu1_delete_done += 1;
            }
            //開いていたタスクを削除する前に、タスク画面を非表示
            if (form.menudone.Visible == true && (Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done + 1) == num)
            {
                Main.Common_Var.menu1_open_done = -1;
                Main.Common_Var.menu1_delete_done = 0;
                form.menudone.Visible = false;
                for (int i = 0; i < Main.Common_Var.menu1_day_done; i++)
                {
                    form.menu1_done_main_panel[i].BackColor = Color.Transparent;
                }
            }

            form.SuspendLayout();
            form.menu1.SuspendLayout();
            form.menu1_done_main.SuspendLayout();

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
            form.menu1_done_main.Controls.Remove(form.menu1_done_main_panel[num]);
            form.menu1_done_main_panel_label_name.RemoveAt(num);
            form.menu1_done_main_panel_label_time.RemoveAt(num);
            form.menu1_done_main_panel_button_delete.RemoveAt(num);
            form.menu1_done_main_panel.RemoveAt(num);

            form.ResumeLayout();
            form.menu1.ResumeLayout();
            form.menu1_done_main.ResumeLayout();

            // 設定から実績削除処理
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

            int sumtime = 0;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    sumtime += int.Parse(Properties.Settings.Default.done_time[i]);
                }
            }

            UpdateDoneTime(form, sumtime);

            Main.Common_Var.menu1_day_done -= 1;
            Main.Common_Var.menu1_done -= 1;

            ChangeDoneNum(form);
        }

        // 実績マウスホバー時
        private void MouseEnterDone(int num)
        {
            if (num < 0 || Main.Common_Var.menu1_day_done <= num)
            {
                return;
            }
            for (int i = 0; i < Main.Common_Var.menu1_day_done; i++)
            {
                if (Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done == i)
                {
                    continue;
                }
                form.menu1_done_main_panel[i].BackColor = Color.Transparent;
            }
            form.menu1_done_main_panel[num].BackColor = color_select_done;
            form.menu1_done_main_panel[num].Refresh();
        }

        // 実績マウスホバーが離れた時
        private void MouseLeaveDone(int num)
        {
            if (Main.Common_Var.menu1_open_done > Main.Common_Var.menu1_day_done)
            {
                return;
            }
            if (form.menudone.Visible == false && Main.Common_Var.menu1_open_done != -1)
            {
                form.menu1_done_main_panel[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].BackColor = Color.Transparent;
                form.menu1_done_main_panel[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Refresh();
                Main.Common_Var.menu1_open_done = -1;
                return;
            }
            if (ExistClientContainState(form.menu1_done_main_panel[num]))
            {
                return;
            }
            if (form.menudone.Visible == true && Main.Common_Var.menu1_open_done == Main.Common_Var.menu1_day_done)
            {
                form.menu1_done_main_panel[num].BackColor = Color.Transparent;
                form.menu1_done_main_panel[num].Refresh();
                return;
            }
            if (num < 0 || Main.Common_Var.menu1_day_done <= num)
            {
                return;
            }
            if (num == Main.Common_Var.menu1_open_done)
            {
                return;
            }
            if (Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done != num)
            {
                form.menu1_done_main_panel[num].BackColor = Color.Transparent;
                form.menu1_done_main_panel[num].Refresh();
            }
        }

        private bool ExistClientContainState(Control ctrl)
        {
            Rectangle rect = ctrl.ClientRectangle;
            return GetContainState(ctrl, rect);
        }

        private bool GetContainState(Control ctrl, Rectangle rect)
        {
            // マウス座標（スクリーン座標系）の取得
            Point mouseScreenPos = Control.MousePosition;
            // マウス座標をクライアント座標系へ変換
            Point mouseClientPos = ctrl.PointToClient(mouseScreenPos);
            // マウス座標（クライアント座標系）が領域内かどうか
            bool inside = rect.Contains(mouseClientPos);
            return inside;
        }

        // 実績の合計時間の表示更新
        private static void UpdateDoneTime(MainForm form, int sumtime)
        {
            // カレンダー更新
            int year = int.Parse(form.menu1_panel_yearmonth_combo_year.SelectedItem.ToString());
            int month = int.Parse(form.menu1_panel_yearmonth_combo_month.SelectedItem.ToString());
            DayOfWeek firstdate = (new DateTime(year, month, 1)).DayOfWeek; // 前月と当月の判定用
            int[] days = new int[42]; // 日付のための箱
            int sub_day = 0; // 次月と当月の判定用
            int today_int = -1; // 現在日の判定用

            common_events.Get_Calender(year, month, ref days, ref sub_day, ref today_int); // 表示内容を取得

            for (int i = 0; i < form.menu1_table_calender_panel_day.Length; i++)
            {
                if ((int)firstdate - 1 < i && i < sub_day) // 当月
                {
                    if (year == Main.Common_Var.menu1_done_year && month == Main.Common_Var.menu1_done_month && days[i] == Main.Common_Var.menu1_done_day)
                    {
                        form.menu1_table_calender_panel_day_label_done[i].Text = "";
                        form.menu1_table_calender_panel_day_label_done[i].Visible = false;
                        if (sumtime / 60 != 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime / 60).ToString() + "h";
                            form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                            if (sumtime / 60 >= 12)
                            {
                                form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done2;
                            }
                            else
                            {
                                form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                            }
                        }
                        else if (sumtime > 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                        }
                        if (sumtime % 60 != 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime % 60).ToString() + "m";
                            form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                        }
                        form.menu1_table_calender_panel_day_label_done[i].Refresh();
                        break;
                    }
                }
                else if (sub_day <= i) // 次月
                {
                    int nextmonth = 0;
                    int nextyear = year;
                    if (month == 12)
                    {
                        nextmonth = 1;
                        nextyear = year + 1;
                    }
                    else
                    {
                        nextmonth = month + 1;
                    }
                    if (nextyear == Main.Common_Var.menu1_done_year && nextmonth == Main.Common_Var.menu1_done_month && days[i] == Main.Common_Var.menu1_done_day)
                    {
                        form.menu1_table_calender_panel_day_label_done[i].Text = "";
                        form.menu1_table_calender_panel_day_label_done[i].Visible = false;
                        if (sumtime / 60 != 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime / 60).ToString() + "h";
                            form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                            if (sumtime / 60 >= 12)
                            {
                                form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done2;
                            }
                            else
                            {
                                form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                            }
                        }
                        else if (sumtime > 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                        }
                        if (sumtime % 60 != 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime % 60).ToString() + "m";
                            form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                        }
                        form.menu1_table_calender_panel_day_label_done[i].Refresh();
                        break;
                    }
                }
                else if (i <= (int)firstdate - 1) // 前月
                {
                    int prevmonth = 0;
                    int prevyear = year;
                    if (month == 1)
                    {
                        prevmonth = 12;
                        prevyear = year - 1;
                    }
                    else
                    {
                        prevmonth = month - 1;
                    }
                    if (prevyear == Main.Common_Var.menu1_done_year && prevmonth == Main.Common_Var.menu1_done_month && days[i] == Main.Common_Var.menu1_done_day)
                    {
                        form.menu1_table_calender_panel_day_label_done[i].Text = "";
                        form.menu1_table_calender_panel_day_label_done[i].Visible = false;
                        if (sumtime / 60 != 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime / 60).ToString() + "h";
                            form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                            if (sumtime / 60 >= 12)
                            {
                                form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done2;
                            }
                            else
                            {
                                form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                            }
                        }
                        else if (sumtime > 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].BackColor = Main.Common_Const.color_done1;
                        }
                        if (sumtime % 60 != 0)
                        {
                            form.menu1_table_calender_panel_day_label_done[i].Text += (sumtime % 60).ToString() + "m";
                            form.menu1_table_calender_panel_day_label_done[i].Visible = true;
                        }
                        form.menu1_table_calender_panel_day_label_done[i].Refresh();
                        break;
                    }
                }
            }

            form.menu1_done_top_label_hour.Text = "";
            form.menu1_done_top_label_hour.BackColor = Color.Transparent;
            if (sumtime / 60 != 0)
            {
                form.menu1_done_top_label_hour.Text += (sumtime / 60).ToString() + "h";
                if (sumtime / 60 >= 12)
                {
                    form.menu1_done_top_label_hour.BackColor = Main.Common_Const.color_done2;
                }
                else
                {
                    form.menu1_done_top_label_hour.BackColor = Main.Common_Const.color_done1;
                }
            }
            else if (sumtime > 0)
            {
                form.menu1_done_top_label_hour.BackColor = Main.Common_Const.color_done1;
            }
            if (sumtime % 60 != 0)
            {
                form.menu1_done_top_label_hour.Text += (sumtime % 60).ToString() + "m";
            }
            form.menu1_done_top_label_hour.Refresh();
        }

        #endregion private
        // ********** private **********
    }
}
