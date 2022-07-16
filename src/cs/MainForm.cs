using System;
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
            // 設定画面非表示
            this.common_panel_setting.Visible = false;
        }

        // アクティブになった時の動作
        protected override void OnActivated(EventArgs ea)
        {
            base.OnActivated(ea);
            // メモ帳データ再読み込み
        }

        #endregion override

        // Event common
        #region Event Common

        // ダブルクリック時の動作
        private void common_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_MouseDoubleClick(sender, e, this);
        }
        // 最小化ボタン
        private void common_button_min_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_min_MouseClick(sender, e, this);
        }
        // 最大化ボタン
        private void common_button_max_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_max_MouseClick(sender, e, this);
        }
        // 閉じるボタン
        private void common_button_close_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_close_MouseClick(sender, e, this);
        }
        // 閉じるボタンホバー時の動作
        private void common_button_close_MouseEnter(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_close_MouseEnter(sender, e, this);
        }
        // 閉じるボタンLeave時の動作
        private void common_button_close_MouseLeave(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_close_MouseLeave(sender, e, this);
        }
        // 設定ボタン押下
        private void common_button_setting_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_setting_Click(sender, e, this);
        }
        // ダークモード切り替え
        private void common_panel_setting_table_check1_CheckedChanged(object sender, EventArgs e)
        {
            controls_event.common_events.common_panel_setting_table_check1_CheckedChanged(sender, e, this);
        }
        // 前メニューへ移動する時の動作
        private void common_button_prevmenu_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_prevmenu_Click(sender, e, this);
        }
        // 次メニューへ移動する時の動作
        private void common_button_nextmenu_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_nextmenu_Click(sender, e, this);
        }
        #endregion Event Common

        // Event menu1
        #region Event menu1
        private void menu1_panel_calendertop_button_prevmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_button_prevmonth_Click(sender, e, this);
        }
        private void menu1_panel_calendertop_button_nextmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_button_nextmonth_Click(sender, e, this);
        }
        private void menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(sender, e, this);
        }
        private void menu1_panel_calendertop_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(sender, e, this);
        }

        private void menu1_table_calender_panel_day_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseEnter(sender, e, this);
        }
        private void menu1_table_calender_label_day_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_MouseEnter(sender, e, this);
        }
        private void menu1_table_calender_panel_day_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseLeave(sender, e, this);
        }
        private void menu1_table_calender_label_day_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_MouseLeave(sender, e, this);
        }
        private void menu1_table_calender_panel_day_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseClick(sender, e, this);
        }
        private void menu1_table_calender_label_day_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_MouseClick(sender, e, this);
        }
        private void menu1_table_calender_panel_day_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_DoubleClick(sender, e, this);
        }
        private void menu1_table_calender_label_day_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_DoubleClick(sender, e, this);
        }
        #endregion Event menu1

        // Event menu2 1
        #region Event menu2_1
        private void menu2_1_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_openclose_Click(sender, e, this);
        }
        private void menu2_1_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_moveup_Click(sender, e, this);
        }
        private void menu2_1_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_movedown_Click(sender, e, this);
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
        private void menu2_2_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_moveup_Click(sender, e, this);
        }
        private void menu2_2_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_movedown_Click(sender, e, this);
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

        #region Event menu3
        private void menu3_panel_top_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu3_events.menu3_panel_top_panel_yearmonth_combo_year_SelectedIndexChanged(sender, e, this);
        }

        private void menu3_panel_top_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu3_events.menu3_panel_top_panel_yearmonth_combo_month_SelectedIndexChanged(sender, e, this);
        }

        private void menu3_panel_top_button_nextmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu3_events.menu3_panel_top_button_nextmonth_Click(sender, e, this);
        }

        private void menu3_panel_top_button_prevmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu3_events.menu3_panel_top_button_prevmonth_Click(sender, e, this);
        }
        #endregion Event menu3

        // Event menutask
        #region Event menutask
        private void menutask_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menutask_events.menutask_button_close_Click(sender, e, this);
        }
        private void menutask_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menutask_events.menutask_button_save_Click(sender, e, this);
        }
        #endregion Event menutask

        // Event menuachieve
        #region Event menuachieve
        private void menuachieve_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menuachieve_events.menuachieve_button_close_Click(sender, e, this);
        }
        private void menuachieve_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menuachieve_events.menuachieve_button_save_Click(sender, e, this);
        }
        #endregion Event menuachieve
    }
}
