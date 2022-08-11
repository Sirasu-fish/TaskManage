using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menudone_events
    {
        public static void menudone_table1_text_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.KeyCode == Keys.Return) // Enter
            {
                SaveDone(form);
            }
        }

        public static void menudone_table2_text_h_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.KeyCode == Keys.Return) // Enter
            {
                SaveDone(form);
            }
        }

        public static void menudone_table2_text_m_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.KeyCode == Keys.Return) // Enter
            {
                SaveDone(form);
            }
        }

        public static void menudone_table2_text_year_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.KeyCode == Keys.Return) // Enter
            {
                SaveDone(form);
            }
        }

        public static void menudone_table2_text_month_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.KeyCode == Keys.Return) // Enter
            {
                SaveDone(form);
            }
        }

        public static void menudone_table2_text_day_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.KeyCode == Keys.Return) // Enter
            {
                SaveDone(form);
            }
        }

        public static void menudone_button_close_Click(object sender, EventArgs e, MainForm form)
        {
            form.menudone.Visible = false;
            if (Main.Common_Var.menu1_open_done < Main.Common_Var.menu1_day_done)
            {
                form.menu1_done_main_panel[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].BackColor = Color.Transparent;
                form.menu1_done_main_panel[Main.Common_Var.menu1_open_done - Main.Common_Var.menu1_delete_done].Refresh();
            }
            Main.Common_Var.menu1_open_done = -1;
        }

        public static void menudone_button_save_Click(object sender, EventArgs e, MainForm form)
        {
            SaveDone(form);
        }


        // ********** private **********
        #region private

        private static bool SaveDone(MainForm form)
        {
            int hour = 0;
            int minute = 0;
            int year = 0;
            int month = 0;
            int day = 0;
            // 入力内容チェック処理
            if (!CheckDoneInput(form, ref hour, ref minute, ref year, ref month, ref day))
            {
                return false;
            }

            // 登録処理
            menu1_events.AddDone(form, hour, minute, year, month, day);

            // 実績画面初期化処理
            form.menudone_table1_text.Text = "";
            form.menudone_table2_text_h.Text = "0";
            form.menudone_table2_text_m.Text = "0";
            form.menudone_table2_text_year.Text = Main.Common_Var.menu1_done_year.ToString();
            form.menudone_table2_text_month.Text = Main.Common_Var.menu1_done_month.ToString();
            form.menudone_table2_text_day.Text = Main.Common_Var.menu1_done_day.ToString();
            form.menudone_table3_text.Text = "";

            return true;
        }

        // チェック処理
        private static bool CheckDoneInput(MainForm form, ref int hour, ref int minute, ref int year, ref int month, ref int day)
        {
            string str_hour = form.menudone_table2_text_h.Text;
            string str_minute = form.menudone_table2_text_m.Text;
            string str_year = form.menudone_table2_text_year.Text;
            string str_month = form.menudone_table2_text_month.Text;
            string str_day = form.menudone_table2_text_day.Text;
            // 実績名
            if (string.IsNullOrEmpty(form.menudone_table1_text.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(str_hour))
            {
                str_hour = "0";
            }
            if (string.IsNullOrEmpty(str_minute))
            {
                str_minute = "0";
            }
            if (string.IsNullOrEmpty(str_year))
            {
                str_year = Main.Common_Var.menu1_done_year.ToString();
            }
            if (string.IsNullOrEmpty(str_month))
            {
                str_month = Main.Common_Var.menu1_done_month.ToString();
            }
            if (string.IsNullOrEmpty(str_day))
            {
                str_day = Main.Common_Var.menu1_done_day.ToString();
            }
            if (!int.TryParse(str_hour, out int h))
            {
                return false;
            }
            if (!int.TryParse(str_minute, out int m))
            {
                return false;
            }
            if (!int.TryParse(str_year, out int y))
            {
                return false;
            }
            if (!int.TryParse(str_month, out int mo))
            {
                return false;
            }
            if (!int.TryParse(str_day, out int d))
            {
                return false;
            }
            if (int.Parse(str_hour) < 0)
            {
                return false;
            }
            if (24 < int.Parse(str_hour))
            {
                return false;
            }
            if (int.Parse(str_minute) >= 60)
            {
                return false;
            }
            if (int.Parse(str_minute) < 0)
            {
                return false;
            }
            if (!DateTime.TryParse(str_year + "/" + str_month + "/" + str_day, out DateTime dt))
            {
                return false;
            }
            int sumtime = 0;
            for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                    && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                {
                    sumtime += int.Parse(Properties.Settings.Default.done_time[i]);
                    if (sumtime > 24 * 60)
                    {
                        return false;
                    }
                }
            }
            hour = int.Parse(str_hour);
            minute = int.Parse(str_minute);
            year = int.Parse(str_year);
            month = int.Parse(str_month);
            day = int.Parse(str_day);
            return true;
        }

        #endregion private
        // ********** private **********
    }
}
