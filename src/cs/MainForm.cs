﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage
{
    public partial class MainForm : Form
    {
        // コンストラクタ
        public MainForm()
        {
            // コントロールの初期設定
            InitializeComponent();

            Main.Init init = new Main.Init();
            init.initialize(this);
        }

        // override
        #region override

        // 非アクティブになった時の動作
        protected override void OnDeactivate(EventArgs ea)
        {
            base.OnDeactivate(ea);
            CheckExistsScreen(this);

            // 設定画面非表示
            this.common_panel_setting.Visible = false;
        }

        // アクティブになった時の動作
        protected override void OnActivated(EventArgs ea)
        {
            base.OnActivated(ea);

            CheckExistsScreen(this);

            // カレンダー更新
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            if (year != Main.Common_Var.today_year || month != Main.Common_Var.today_month || day != Main.Common_Var.today_day)
            {
                Main.Common_Var.today_year = year;
                Main.Common_Var.today_month = month;
                Main.Common_Var.today_day = day;
                controls_event.menu1_events.Change_YearMonth(this);
            }
        }

        #endregion override

        private void CheckExistsScreen(MainForm form)
        {
            bool isScreen = false;

            foreach (Screen scr in Screen.AllScreens)
            {
                if (scr.WorkingArea.Contains(form.Left, form.Top) == true)
                {
                    isScreen = true;
                    break;
                }
                else
                {

                }
            }

            if (isScreen == true)
            {
                form.Location = new Point(form.Left, form.Top);
            }
        }

        // Event common
        #region Event Common

        private void common_panel_setting_button_checkupdate_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_panel_setting_button_checkupdate_Click(sender, e, this);
        }
        private void common_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_MouseDoubleClick(sender, e, this);
        }
        private void common_button_min_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_min_MouseClick(sender, e, this);
        }
        private void common_button_max_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_max_MouseClick(sender, e, this);
        }
        private void common_button_close_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_close_MouseClick(sender, e, this);
        }
        private void common_button_close_MouseEnter(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_close_MouseEnter(sender, e, this);
        }
        private void common_button_close_MouseLeave(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_close_MouseLeave(sender, e, this);
        }
        private void common_button_setting_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_setting_Click(sender, e, this);
        }
        private void common_panel_setting_combobox_delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.common_events.common_panel_setting_combobox_delete_SelectedIndexChanged(sender, e, this);
        }
        private void common_button_prevmenu_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_prevmenu_Click(sender, e, this);
        }
        private void common_button_nextmenu_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_nextmenu_Click(sender, e, this);
        }
        #endregion Event Common

        // Event menu1
        #region Event menu1
        private void menu1_panel_yearmonth_button_prevmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_yearmonth_button_prevmonth_Click(sender, e, this);
        }
        private void menu1_panel_yearmonth_button_nextmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_yearmonth_button_nextmonth_Click(sender, e, this);
        }
        private void menu1_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_yearmonth_combo_year_SelectedIndexChanged(sender, e, this);
        }
        private void menu1_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_yearmonth_combo_month_SelectedIndexChanged(sender, e, this);
        }

        private void menu1_table_calender_panel_day_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseEnter(sender, e, this);
        }
        private void menu1_table_calender_panel_day_label_day_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_label_day_MouseEnter(sender, e, this);
        }
        private void menu1_table_calender_panel_day_label_done_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_label_done_MouseEnter(sender, e, this);
        }
        private void menu1_table_calender_panel_day_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseLeave(sender, e, this);
        }
        private void menu1_table_calender_panel_day_label_day_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_label_day_MouseLeave(sender, e, this);
        }
        private void menu1_table_calender_panel_day_label_done_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_label_done_MouseLeave(sender, e, this);
        }
        private void menu1_table_calender_panel_day_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseClick(sender, e, this);
        }
        private void menu1_table_calender_panel_day_label_day_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_label_day_MouseClick(sender, e, this);
        }
        private void menu1_table_calender_panel_day_label_done_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_label_done_MouseClick(sender, e, this);
        }
        private void menu1_done_top_prevday_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_done_top_prevday_Click(sender, e, this);
        }
        private void menu1_done_top_nextday_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_done_top_nextday_Click(sender, e, this);
        }
        private void menu1_done_top_button_add_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_done_top_button_add_Click(sender, e, this);
        }
        #endregion Event menu1

        // Event menu2 1
        #region Event menu2_1
        private void menu2_1_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_openclose_Click(sender, e, this);
        }
        private void menu2_1_panel_top_button_add_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_add_Click(sender, e, this);
        }
        #endregion Event menu2_1

        // Event menu2 2
        #region Event menu2 2
        private void menu2_2_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_openclose_Click(sender, e, this);
        }
        private void menu2_2_panel_top_button_open_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_open_Click(sender, e, this);
        }
        private void menu2_2_panel_top_button_add_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_add_Click(sender, e, this);
        }
        #endregion Event menu2 2

        // Event menutask
        #region Event menutask
        private void menutask_table1_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menutask_events.menutask_table1_text_KeyDown(sender, e, this);
        }
        private void menutask_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menutask_events.menutask_button_close_Click(sender, e, this);
        }
        private void menutask_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menutask_events.menutask_button_save_Click(sender, e, this);
        }
        #endregion Event menutask

        // Event menudone
        #region Event menudone
        private void menudone_table1_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menudone_events.menudone_table1_text_KeyDown(sender, e, this);
        }
        private void menudone_table2_text_h_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menudone_events.menudone_table2_text_h_KeyDown(sender, e, this);
        }
        private void menudone_table2_text_m_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menudone_events.menudone_table2_text_m_KeyDown(sender, e, this);
        }
        private void menudone_table2_text_year_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menudone_events.menudone_table2_text_year_KeyDown(sender, e, this);
        }
        private void menudone_table2_text_month_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menudone_events.menudone_table2_text_month_KeyDown(sender, e, this);
        }
        private void menudone_table2_text_day_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menudone_events.menudone_table2_text_day_KeyDown(sender, e, this);
        }
        private void menudone_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menudone_events.menudone_button_close_Click(sender, e, this);
        }
        private void menudone_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menudone_events.menudone_button_save_Click(sender, e, this);
        }
        #endregion Event menudone
    }
}
