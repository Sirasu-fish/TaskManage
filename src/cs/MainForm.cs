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
            controls_event.common_events.common_MouseDoubleClick(this);
        }
        // 最小化ボタン
        private void common_button_min_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_min_MouseClick(this);
        }
        // 最大化ボタン
        private void common_button_max_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_max_MouseClick(this);
        }
        // 閉じるボタン
        private void common_button_close_MouseClick(object sender, MouseEventArgs e)
        {
            controls_event.common_events.common_button_close_MouseClick(this);
        }
        // 閉じるボタンホバー時の動作
        private void common_button_close_MouseEnter(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_close_MouseEnter(this);
        }
        // 閉じるボタンLeave時の動作
        private void common_button_close_MouseLeave(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_close_MouseLeave(this);
        }
        // 設定ボタン押下
        private void common_button_setting_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_setting_Click(this);
        }
        // ダークモード切り替え
        private void common_panel_setting_table_check1_CheckedChanged(object sender, EventArgs e)
        {
            controls_event.common_events.common_panel_setting_table_check1_CheckedChanged(this);
        }
        // 前メニューへ移動する時の動作
        private void common_button_prevmenu_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_prevmenu_Click(this);
        }
        // 次メニューへ移動する時の動作
        private void common_button_nextmenu_Click(object sender, EventArgs e)
        {
            controls_event.common_events.common_button_nextmenu_Click(this);
        }
        #endregion Event Common

        // Event menu1
        #region Event menu1
        private void menu1_panel_calendertop_button_prevmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_button_prevmonth_Click(this);
        }
        private void menu1_panel_calendertop_button_nextmonth_Click(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_button_nextmonth_Click(this);
        }
        private void menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(this);
        }
        private void menu1_panel_calendertop_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(this);
        }

        private void menu1_table_calender_panel_day_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseEnter(sender, this);
        }
        private void menu1_table_calender_label_day_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_MouseEnter(sender, this);
        }
        private void menu1_table_calender_panel_day_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseLeave(this);
        }
        private void menu1_table_calender_label_day_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_MouseClick(sender, this);
        }
        private void menu1_table_calender_label_day_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_MouseClick(sender, this);
        }
        private void menu1_table_calender_panel_day_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day_DoubleClick(sender, this);
        }
        private void menu1_table_calender_label_day_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_label_day_DoubleClick(sender, this);
        }
        #endregion Event menu1

        // Event menu2 1
        #region Event menu2_1
        private void menu2_1_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_openclose_Click(this);
        }
        private void menu2_1_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_moveup_Click(this);
        }
        private void menu2_1_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_movedown_Click(this);
        }
        private void menu2_1_panel_top_button_add_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_add_Click(sender, this);
        }
        private void menu2_1_panel_main_panel_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_button_finish_Click(sender, this);
        }
        private void menu2_1_panel_main_panel_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_button_delete_Click(sender, this);
        }
        private void menu2_1_panel_main_panel_button_delete_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_button_delete_MouseEnter(sender, this);
        }
        private void menu2_1_panel_main_panel_button_delete_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_button_delete_MouseLeave(sender, this);
        }
        private void menu2_1_panel_main_panel_button_finish_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_button_finish_MouseEnter(sender, this);
        }
        private void menu2_1_panel_main_panel_button_finish_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_button_finish_MouseLeave(sender, this);
        }
        private void menu2_1_panel_main_panel_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_Click(sender, this);
        }
        private void menu2_1_panel_main_panel_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_label1_Click(sender, this);
        }
        private void menu2_1_panel_main_panel_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel_label2_Click(sender, this);
        }
        #endregion Event menu2_1

        // Event menu2 2
        #region Event menu2 2
        private void menu2_2_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_openclose_Click(this);
        }
        private void menu2_2_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_moveup_Click(this);
        }
        private void menu2_2_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_movedown_Click(this);
        }
        private void menu2_2_panel_top_button_open_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_open_Click(this);
        }
        private void menu2_2_panel_top_button_add_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_top_button_add_Click(this);
        }
        private void menu2_2_panel_main_panel_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel_table_memo_text_KeyDown(sender, this, e);
        }
        private void menu2_2_panel_main_panel_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel_table_memo_panel_top_button_save_Click(sender, this);
        }
        private void menu2_2_panel_main_panel_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax_Click(sender, this);
        }
        private void menu2_2_panel_main_panel_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel1_table_memo_panel_top_button_close_Click(sender, this);
        }
        #endregion Event menu2 2

        // Event menu2 3
        #region Event menu2_3
        private void menu2_3_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_top_button_openclose_Click(this);
        }
        private void menu2_3_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_top_button_moveup_Click(this);
        }
        private void menu2_3_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_top_button_movedown_Click(this);
        }
        private void menu2_3_panel_top_button_add_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_top_button_add_Click(this);
        }
        private void menu2_3_panel_main_panel1_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel1_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel2_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel2_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel3_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel3_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel4_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel4_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel5_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel5_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel6_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel6_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel7_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel7_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel8_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel8_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel9_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel9_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel10_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel10_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel11_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel11_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel12_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel12_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel13_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel13_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel14_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel14_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel15_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel15_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel16_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel16_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel17_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel17_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel18_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel18_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel19_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel19_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel20_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel20_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel21_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel21_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel22_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel22_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel23_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel23_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel24_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel24_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel25_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel25_button_delete_Click(this);
        }
        private void menu2_3_panel_main_panel1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel1_Click(this);
        }
        private void menu2_3_panel_main_panel1_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel1_label1_Click(this);
        }
        private void menu2_3_panel_main_panel2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel2_Click(this);
        }
        private void menu2_3_panel_main_panel2_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel2_label1_Click(this);
        }
        private void menu2_3_panel_main_panel3_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel3_Click(this);
        }
        private void menu2_3_panel_main_panel3_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel3_label1_Click(this);
        }
        private void menu2_3_panel_main_panel4_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel4_Click(this);
        }
        private void menu2_3_panel_main_panel4_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel4_label1_Click(this);
        }
        private void menu2_3_panel_main_panel5_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel5_Click(this);
        }
        private void menu2_3_panel_main_panel5_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel5_label1_Click(this);
        }
        private void menu2_3_panel_main_panel6_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel6_Click(this);
        }
        private void menu2_3_panel_main_panel6_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel6_label1_Click(this);
        }
        private void menu2_3_panel_main_panel7_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel7_Click(this);
        }
        private void menu2_3_panel_main_panel7_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel7_label1_Click(this);
        }
        private void menu2_3_panel_main_panel8_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel8_Click(this);
        }
        private void menu2_3_panel_main_panel8_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel8_label1_Click(this);
        }
        private void menu2_3_panel_main_panel9_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel9_Click(this);
        }
        private void menu2_3_panel_main_panel9_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel9_label1_Click(this);
        }
        private void menu2_3_panel_main_panel10_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel10_Click(this);
        }
        private void menu2_3_panel_main_panel10_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel10_label1_Click(this);
        }
        private void menu2_3_panel_main_panel11_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel11_Click(this);
        }
        private void menu2_3_panel_main_panel11_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel11_label1_Click(this);
        }
        private void menu2_3_panel_main_panel12_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel12_Click(this);
        }
        private void menu2_3_panel_main_panel12_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel12_label1_Click(this);
        }
        private void menu2_3_panel_main_panel13_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel13_Click(this);
        }
        private void menu2_3_panel_main_panel13_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel13_label1_Click(this);
        }
        private void menu2_3_panel_main_panel14_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel14_Click(this);
        }
        private void menu2_3_panel_main_panel14_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel14_label1_Click(this);
        }
        private void menu2_3_panel_main_panel15_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel15_Click(this);
        }
        private void menu2_3_panel_main_panel15_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel15_label1_Click(this);
        }
        private void menu2_3_panel_main_panel16_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel16_Click(this);
        }
        private void menu2_3_panel_main_panel16_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel16_label1_Click(this);
        }
        private void menu2_3_panel_main_panel17_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel17_Click(this);
        }
        private void menu2_3_panel_main_panel17_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel17_label1_Click(this);
        }
        private void menu2_3_panel_main_panel18_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel18_Click(this);
        }
        private void menu2_3_panel_main_panel18_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel18_label1_Click(this);
        }
        private void menu2_3_panel_main_panel19_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel19_Click(this);
        }
        private void menu2_3_panel_main_panel19_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel19_label1_Click(this);
        }
        private void menu2_3_panel_main_panel20_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel20_Click(this);
        }
        private void menu2_3_panel_main_panel20_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel20_label1_Click(this);
        }
        private void menu2_3_panel_main_panel21_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel21_Click(this);
        }
        private void menu2_3_panel_main_panel21_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel21_label1_Click(this);
        }
        private void menu2_3_panel_main_panel22_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel22_Click(this);
        }
        private void menu2_3_panel_main_panel22_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel22_label1_Click(this);
        }
        private void menu2_3_panel_main_panel23_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel23_Click(this);
        }
        private void menu2_3_panel_main_panel23_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel23_label1_Click(this);
        }
        private void menu2_3_panel_main_panel24_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel24_Click(this);
        }
        private void menu2_3_panel_main_panel24_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel24_label1_Click(this);
        }
        private void menu2_3_panel_main_panel25_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel25_Click(this);
        }
        private void menu2_3_panel_main_panel25_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_3_events.menu2_3_panel_main_panel25_label1_Click(this);
        }
        #endregion Event menu2_3

        // Event menutask
        #region Event menutask
        private void menutask_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menutask_events.menutask_button_close_Click(this);
        }
        private void menutask_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menutask_events.menutask_button_save_Click(this);
        }
        #endregion Event menutask

        // Event menuachieve
        #region Event menuachieve
        private void menuachieve_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menuachieve_events.menuachieve_button_close_Click(this);
        }
        private void menuachieve_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menuachieve_events.menuachieve_button_save_Click(this);
        }
        #endregion Event menuachieve
    }
}
