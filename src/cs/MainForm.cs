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
        private void menu1_table_calender_panel_day1_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day1_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day2_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day2_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day3_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day3_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day4_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day4_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day5_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day5_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day6_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day6_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day7_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day7_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day8_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day8_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day9_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day9_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day10_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day10_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day11_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day11_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day12_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day12_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day13_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day13_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day14_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day14_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day15_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day15_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day16_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day16_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day17_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day17_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day18_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day18_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day19_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day19_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day20_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day20_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day21_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day21_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day22_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day22_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day23_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day23_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day24_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day24_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day25_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day25_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day26_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day26_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day27_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day27_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day28_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day28_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day29_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day29_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day30_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day30_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day31_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day31_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day32_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day32_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day33_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day33_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day34_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day34_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day35_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day35_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day36_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day36_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day37_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day37_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day38_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day38_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day39_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day39_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day40_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day40_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day41_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day41_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day42_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day42_MouseEnter(this);
        }
        private void menu1_table_calender_panel_day1_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day1_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day2_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day2_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day3_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day3_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day4_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day4_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day5_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day5_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day6_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day6_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day7_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day7_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day8_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day8_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day9_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day9_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day10_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day10_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day11_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day11_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day12_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day12_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day13_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day13_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day14_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day14_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day15_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day15_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day16_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day16_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day17_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day17_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day18_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day18_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day19_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day19_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day20_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day20_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day21_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day21_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day22_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day22_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day23_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day23_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day24_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day24_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day25_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day25_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day26_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day26_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day27_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day27_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day28_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day28_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day29_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day29_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day30_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day30_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day31_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day31_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day32_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day32_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day33_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day33_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day34_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day34_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day35_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day35_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day36_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day36_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day37_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day37_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day38_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day38_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day39_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day39_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day40_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day40_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day41_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day41_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day42_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day42_MouseLeave(this);
        }
        private void menu1_table_calender_panel_day1_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day1_MouseClick(this);
        }
        private void menu1_table_calender_panel_day2_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day2_MouseClick(this);
        }
        private void menu1_table_calender_panel_day3_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day3_MouseClick(this);
        }
        private void menu1_table_calender_panel_day4_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day4_MouseClick(this);
        }
        private void menu1_table_calender_panel_day5_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day5_MouseClick(this);
        }
        private void menu1_table_calender_panel_day6_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day6_MouseClick(this);
        }
        private void menu1_table_calender_panel_day7_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day7_MouseClick(this);
        }
        private void menu1_table_calender_panel_day8_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day8_MouseClick(this);
        }
        private void menu1_table_calender_panel_day9_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day9_MouseClick(this);
        }
        private void menu1_table_calender_panel_day10_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day10_MouseClick(this);
        }
        private void menu1_table_calender_panel_day11_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day11_MouseClick(this);
        }
        private void menu1_table_calender_panel_day12_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day12_MouseClick(this);
        }
        private void menu1_table_calender_panel_day13_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day13_MouseClick(this);
        }
        private void menu1_table_calender_panel_day14_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day14_MouseClick(this);
        }
        private void menu1_table_calender_panel_day15_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day15_MouseClick(this);
        }
        private void menu1_table_calender_panel_day16_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day16_MouseClick(this);
        }
        private void menu1_table_calender_panel_day17_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day17_MouseClick(this);
        }
        private void menu1_table_calender_panel_day18_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day18_MouseClick(this);
        }
        private void menu1_table_calender_panel_day19_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day19_MouseClick(this);
        }
        private void menu1_table_calender_panel_day20_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day20_MouseClick(this);
        }
        private void menu1_table_calender_panel_day21_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day21_MouseClick(this);
        }
        private void menu1_table_calender_panel_day22_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day22_MouseClick(this);
        }
        private void menu1_table_calender_panel_day23_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day23_MouseClick(this);
        }
        private void menu1_table_calender_panel_day24_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day24_MouseClick(this);
        }
        private void menu1_table_calender_panel_day25_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day25_MouseClick(this);
        }
        private void menu1_table_calender_panel_day26_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day26_MouseClick(this);
        }
        private void menu1_table_calender_panel_day27_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day27_MouseClick(this);
        }
        private void menu1_table_calender_panel_day28_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day28_MouseClick(this);
        }
        private void menu1_table_calender_panel_day29_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day29_MouseClick(this);
        }
        private void menu1_table_calender_panel_day30_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day30_MouseClick(this);
        }
        private void menu1_table_calender_panel_day31_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day31_MouseClick(this);
        }
        private void menu1_table_calender_panel_day32_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day32_MouseClick(this);
        }
        private void menu1_table_calender_panel_day33_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day33_MouseClick(this);
        }
        private void menu1_table_calender_panel_day34_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day34_MouseClick(this);
        }
        private void menu1_table_calender_panel_day35_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day35_MouseClick(this);
        }
        private void menu1_table_calender_panel_day36_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day36_MouseClick(this);
        }
        private void menu1_table_calender_panel_day37_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day37_MouseClick(this);
        }
        private void menu1_table_calender_panel_day38_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day38_MouseClick(this);
        }
        private void menu1_table_calender_panel_day39_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day39_MouseClick(this);
        }
        private void menu1_table_calender_panel_day40_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day40_MouseClick(this);
        }
        private void menu1_table_calender_panel_day41_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day41_MouseClick(this);
        }
        private void menu1_table_calender_panel_day42_MouseClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day42_MouseClick(this);
        }
        private void menu1_table_calender_panel_day1_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day1_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day2_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day2_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day3_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day3_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day4_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day4_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day5_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day5_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day6_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day6_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day7_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day7_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day8_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day8_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day9_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day9_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day10_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day10_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day11_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day11_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day12_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day12_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day13_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day13_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day14_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day14_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day15_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day15_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day16_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day16_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day17_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day17_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day18_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day18_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day19_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day19_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day20_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day20_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day21_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day21_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day22_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day22_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day23_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day23_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day24_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day24_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day25_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day25_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day26_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day26_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day27_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day27_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day28_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day28_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day29_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day29_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day30_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day30_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day31_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day31_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day32_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day32_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day33_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day33_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day34_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day34_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day35_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day35_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day36_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day36_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day37_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day37_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day38_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day38_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day39_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day39_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day40_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day40_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day41_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day41_DoubleClick(this);
        }
        private void menu1_table_calender_panel_day42_DoubleClick(object sender, EventArgs e)
        {
            controls_event.menu1_events.menu1_table_calender_panel_day42_DoubleClick(this);
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
        private void menu2_1_panel_main_panel1_button_delete_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_button_delete_MouseEnter(this);
        }
        private void menu2_1_panel_main_panel1_button_delete_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_button_delete_MouseLeave(this);
        }
        private void menu2_1_panel_main_panel1_button_finish_MouseEnter(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_button_finish_MouseEnter(this);
        }
        private void menu2_1_panel_main_panel1_button_finish_MouseLeave(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_button_finish_MouseLeave(this);
        }
        private void menu2_1_panel_top_button_add_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_top_button_add_Click(this);
        }
        private void menu2_1_panel_main_panel1_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel2_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel2_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel3_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel3_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel4_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel4_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel5_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel5_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel6_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel6_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel7_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel7_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel8_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel8_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel9_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel9_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel10_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel10_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel11_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel11_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel12_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel12_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel13_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel13_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel14_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel14_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel15_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel15_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel16_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel16_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel17_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel17_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel18_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel18_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel19_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel19_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel20_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel20_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel21_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel21_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel22_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel22_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel23_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel23_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel24_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel24_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel25_button_finish_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel25_button_finish_Click(this);
        }
        private void menu2_1_panel_main_panel1_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel2_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel2_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel3_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel3_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel4_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel4_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel5_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel5_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel6_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel6_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel7_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel7_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel8_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel8_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel9_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel9_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel10_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel10_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel11_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel11_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel12_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel12_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel13_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel13_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel14_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel14_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel15_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel15_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel16_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel16_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel17_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel17_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel18_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel18_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel19_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel19_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel20_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel20_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel21_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel21_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel22_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel22_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel23_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel23_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel24_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel24_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel25_button_delete_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel25_button_delete_Click(this);
        }
        private void menu2_1_panel_main_panel1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_Click(this);
        }
        private void menu2_1_panel_main_panel1_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_label1_Click(this);
        }
        private void menu2_1_panel_main_panel1_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel1_label2_Click(this);
        }
        private void menu2_1_panel_main_panel2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel2_Click(this);
        }
        private void menu2_1_panel_main_panel2_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel2_label1_Click(this);
        }
        private void menu2_1_panel_main_panel2_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel2_label2_Click(this);
        }
        private void menu2_1_panel_main_panel3_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel3_Click(this);
        }
        private void menu2_1_panel_main_panel3_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel3_label1_Click(this);
        }
        private void menu2_1_panel_main_panel3_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel3_label2_Click(this);
        }
        private void menu2_1_panel_main_panel4_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel4_Click(this);
        }
        private void menu2_1_panel_main_panel4_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel4_label1_Click(this);
        }
        private void menu2_1_panel_main_panel4_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel4_label2_Click(this);
        }
        private void menu2_1_panel_main_panel5_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel5_Click(this);
        }
        private void menu2_1_panel_main_panel5_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel5_label1_Click(this);
        }
        private void menu2_1_panel_main_panel5_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel5_label2_Click(this);
        }
        private void menu2_1_panel_main_panel6_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel6_Click(this);
        }
        private void menu2_1_panel_main_panel6_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel6_label1_Click(this);
        }
        private void menu2_1_panel_main_panel6_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel6_label2_Click(this);
        }
        private void menu2_1_panel_main_panel7_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel7_Click(this);
        }
        private void menu2_1_panel_main_panel7_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel7_label1_Click(this);
        }
        private void menu2_1_panel_main_panel7_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel7_label2_Click(this);
        }
        private void menu2_1_panel_main_panel8_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel8_Click(this);
        }
        private void menu2_1_panel_main_panel8_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel8_label1_Click(this);
        }
        private void menu2_1_panel_main_panel8_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel8_label2_Click(this);
        }
        private void menu2_1_panel_main_panel9_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel9_Click(this);
        }
        private void menu2_1_panel_main_panel9_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel9_label1_Click(this);
        }
        private void menu2_1_panel_main_panel9_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel9_label2_Click(this);
        }
        private void menu2_1_panel_main_panel10_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel10_Click(this);
        }
        private void menu2_1_panel_main_panel10_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel10_label1_Click(this);
        }
        private void menu2_1_panel_main_panel10_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel10_label2_Click(this);
        }
        private void menu2_1_panel_main_panel11_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel11_Click(this);
        }
        private void menu2_1_panel_main_panel11_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel11_label1_Click(this);
        }
        private void menu2_1_panel_main_panel11_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel11_label2_Click(this);
        }
        private void menu2_1_panel_main_panel12_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel12_Click(this);
        }
        private void menu2_1_panel_main_panel12_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel12_label1_Click(this);
        }
        private void menu2_1_panel_main_panel12_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel12_label2_Click(this);
        }
        private void menu2_1_panel_main_panel13_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel13_Click(this);
        }
        private void menu2_1_panel_main_panel13_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel13_label1_Click(this);
        }
        private void menu2_1_panel_main_panel13_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel13_label2_Click(this);
        }
        private void menu2_1_panel_main_panel14_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel14_Click(this);
        }
        private void menu2_1_panel_main_panel14_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel14_label1_Click(this);
        }
        private void menu2_1_panel_main_panel14_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel14_label2_Click(this);
        }
        private void menu2_1_panel_main_panel15_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel15_Click(this);
        }
        private void menu2_1_panel_main_panel15_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel15_label1_Click(this);
        }
        private void menu2_1_panel_main_panel15_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel15_label2_Click(this);
        }
        private void menu2_1_panel_main_panel16_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel16_Click(this);
        }
        private void menu2_1_panel_main_panel16_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel16_label1_Click(this);
        }
        private void menu2_1_panel_main_panel16_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel16_label2_Click(this);
        }
        private void menu2_1_panel_main_panel17_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel17_Click(this);
        }
        private void menu2_1_panel_main_panel17_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel17_label1_Click(this);
        }
        private void menu2_1_panel_main_panel17_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel17_label2_Click(this);
        }
        private void menu2_1_panel_main_panel18_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel18_Click(this);
        }
        private void menu2_1_panel_main_panel18_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel18_label1_Click(this);
        }
        private void menu2_1_panel_main_panel18_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel18_label2_Click(this);
        }
        private void menu2_1_panel_main_panel19_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel18_Click(this);
        }
        private void menu2_1_panel_main_panel19_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel19_label1_Click(this);
        }
        private void menu2_1_panel_main_panel19_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel19_label2_Click(this);
        }
        private void menu2_1_panel_main_panel20_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel20_Click(this);
        }
        private void menu2_1_panel_main_panel20_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel20_label1_Click(this);
        }
        private void menu2_1_panel_main_panel20_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel20_label2_Click(this);
        }
        private void menu2_1_panel_main_panel21_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel21_Click(this);
        }
        private void menu2_1_panel_main_panel21_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel21_label1_Click(this);
        }
        private void menu2_1_panel_main_panel21_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel21_label2_Click(this);
        }
        private void menu2_1_panel_main_panel22_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel22_Click(this);
        }
        private void menu2_1_panel_main_panel22_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel22_label1_Click(this);
        }
        private void menu2_1_panel_main_panel22_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel22_label2_Click(this);
        }
        private void menu2_1_panel_main_panel23_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel23_Click(this);
        }
        private void menu2_1_panel_main_panel23_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel23_label1_Click(this);
        }
        private void menu2_1_panel_main_panel23_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel23_label2_Click(this);
        }
        private void menu2_1_panel_main_panel24_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel24_Click(this);
        }
        private void menu2_1_panel_main_panel24_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel24_label1_Click(this);
        }
        private void menu2_1_panel_main_panel24_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel24_label2_Click(this);
        }
        private void menu2_1_panel_main_panel25_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel25_Click(this);
        }
        private void menu2_1_panel_main_panel25_label1_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel25_label1_Click(this);
        }
        private void menu2_1_panel_main_panel25_label2_Click(object sender, EventArgs e)
        {
            controls_event.menu2_1_events.menu2_1_panel_main_panel25_label2_Click(this);
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
