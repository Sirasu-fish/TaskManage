using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManage
{
    public partial class MainForm : Form
    {
        private int clickpanel = -1; //カレンダーでクリックされたパネル
        private int menu = 1; //閲覧中のメニュー
        lib.Setting setting = new lib.Setting(); //設定項目クラス

        DAndDSizeChanger menu2_2_panel_main_table_memo1_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo2_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo3_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo4_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo5_sizeChanger;
        DAndDSizeChanger this_sizeChanger;
        DAndDMoveForm common_MoveForm;

        static readonly Color dark = Color.FromArgb(40, 40, 40); //ダークモード 基本色
        static readonly Color white = Color.FromArgb(240, 240, 240); //ライトモード 基本色
        static readonly Color subdark = Color.FromArgb(80, 80, 80); //ダークモード サブ色
        static readonly Color subwhite = Color.FromArgb(220, 220, 220); //ライトモード サブ色
        Color main_color = dark;
        Color sub_color = white;
        Color submain_color = subdark;
        Color subsub_color = subwhite;

        // メモの保存先パス
        string memo1_path = "";
        string memo2_path = "";
        string memo3_path = "";
        string memo4_path = "";
        string memo5_path = "";

        // menu2の高さ初期値
        int menu2_1_panel_o = 936;
        int menu2_1_o = 944;
        int menu2_2_panel_o = 562;
        int menu2_2_o = 570;
        int menu2_3_panel_o = 934;
        int menu2_3_o = 942;
        int menu2_1_panel_c = 34;


        // コンストラクタ
        public MainForm()
        {
            // コントロールの初期設定
            InitializeComponent();
            // フォームロード時の設定
            MainForm_Load();

            lib.BaseSetting baseSetting = new lib.BaseSetting();
        }

        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★
         * common start
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★
         */
        #region Event Common
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

        // ダブルクリック時の動作
        private void common_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        // 最小化ボタン
        private void common_button_min_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 最大化ボタン
        private void common_button_max_MouseClick(object sender, MouseEventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.common_button_max.Image = ((System.Drawing.Image)(resources.GetObject("common_button_max.Image"))); ;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.common_button_max.Image = ((System.Drawing.Image)(resources.GetObject("common_button_min.Image")));
            }
        }

        // 閉じるボタン
        private void common_button_close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        // 閉じるボタンホバー時の動作
        private void common_button_close_MouseEnter(object sender, EventArgs e)
        {
            this.common_button_close.BackColor = Color.FromArgb(50, 255, 128, 128);
        }

        // 閉じるボタンLeave時の動作
        private void common_button_close_MouseLeave(object sender, EventArgs e)
        {
            this.common_button_close.BackColor = Color.Transparent;
        }

        // 設定ボタン押下
        private void common_button_setting_Click(object sender, EventArgs e)
        {
            if (this.common_panel_setting.Visible == false)
            {
                this.common_panel_setting.Visible = true;
            }
            else
            {
                this.common_panel_setting.Visible = false;
            }
        }

        // ダークモード切り替え
        private void common_panel_setting_table_check1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.common_panel_setting_table_check1.Checked)
            {
                setting.common_mode = true; ;
            }
            else
            {
                setting.common_mode = false;
            }
            setting.SaveSetting();
            ChangeDarkMode(setting.common_mode);
        }

        // 前メニューへ移動する時の動作
        private void common_button_prevmenu_Click(object sender, EventArgs e)
        {
            
            this.common_panel_setting.Visible = false;
            menu -= 1;
            ChangeMenu(menu);
        }

        // 次メニューへ移動する時の動作
        private void common_button_nextmenu_Click(object sender, EventArgs e)
        {
            this.common_panel_setting.Visible = false;
            menu += 1;
            ChangeMenu(menu);
        }
        #endregion Event Common
        /* 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★
         * common end
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★
         */

        /* 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu1 start
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */
        #region Event menu1
        // 前の月に移動する時の動作
        private void menu1_panel_calendertop_button_prevmonth_Click(object sender, EventArgs e)
        {
            int year = 0;
            int month = 0;
            Get_YearMonth(ref year, ref month);
            month = (month + 10) % 12 + 1;
            if (month == 12)
            {
                year = year - 1;
            }
            Set_Day(year, month);
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        // 次の月に移動する時の動作
        private void menu1_panel_calendertop_button_nextmonth_Click(object sender, EventArgs e)
        {
            int year = 0;
            int month = 0;
            Get_YearMonth(ref year, ref month);
            month = month % 12 + 1;
            if (month == 1)
            {
                year = year + 1;
            }
            Set_Day(year, month);
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        // 年を変更した時の動作
        private void menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_YearMonth();
        }
        
        // 月を変更した時の動作
        private void menu1_panel_calendertop_panel_yearmonth_combo_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_YearMonth();
        }

        //日付ホバーと離れた時
        private void menu1_table_calender_panel_day1_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day1);
        }
        private void menu1_table_calender_panel_day1_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day1);
        }
        private void menu1_table_calender_panel_day2_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day2);
        }
        private void menu1_table_calender_panel_day2_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day2);
        }
        private void menu1_table_calender_panel_day3_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day3);
        }
        private void menu1_table_calender_panel_day3_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day3);
        }
        private void menu1_table_calender_panel_day4_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day4);
        }
        private void menu1_table_calender_panel_day4_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day4);
        }
        private void menu1_table_calender_panel_day5_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day5);
        }
        private void menu1_table_calender_panel_day5_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day5);
        }
        private void menu1_table_calender_panel_day6_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day6);
        }
        private void menu1_table_calender_panel_day6_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day6);
        }
        private void menu1_table_calender_panel_day7_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day7);
        }
        private void menu1_table_calender_panel_day7_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day7);
        }
        private void menu1_table_calender_panel_day8_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day8);
        }
        private void menu1_table_calender_panel_day8_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day8);
        }
        private void menu1_table_calender_panel_day9_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day9);
        }
        private void menu1_table_calender_panel_day9_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day9);
        }
        private void menu1_table_calender_panel_day10_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day10);
        }
        private void menu1_table_calender_panel_day10_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day10);
        }
        private void menu1_table_calender_panel_day11_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day11);
        }
        private void menu1_table_calender_panel_day11_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day11);
        }
        private void menu1_table_calender_panel_day12_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day12);
        }
        private void menu1_table_calender_panel_day12_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day12);
        }
        private void menu1_table_calender_panel_day13_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day13);
        }
        private void menu1_table_calender_panel_day13_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day13);
        }
        private void menu1_table_calender_panel_day14_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day14);
        }
        private void menu1_table_calender_panel_day14_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day14);
        }
        private void menu1_table_calender_panel_day15_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day15);
        }
        private void menu1_table_calender_panel_day15_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day15);
        }
        private void menu1_table_calender_panel_day16_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day16);
        }
        private void menu1_table_calender_panel_day16_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day16);
        }
        private void menu1_table_calender_panel_day17_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day17);
        }
        private void menu1_table_calender_panel_day17_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day17);
        }
        private void menu1_table_calender_panel_day18_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day18);
        }
        private void menu1_table_calender_panel_day18_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day18);
        }
        private void menu1_table_calender_panel_day19_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day19);
        }
        private void menu1_table_calender_panel_day19_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day19);
        }
        private void menu1_table_calender_panel_day20_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day20);
        }
        private void menu1_table_calender_panel_day20_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day20);
        }
        private void menu1_table_calender_panel_day21_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day21);
        }
        private void menu1_table_calender_panel_day21_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day21);
        }
        private void menu1_table_calender_panel_day22_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day22);
        }
        private void menu1_table_calender_panel_day22_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day22);
        }
        private void menu1_table_calender_panel_day23_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day23);
        }
        private void menu1_table_calender_panel_day23_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day23);
        }
        private void menu1_table_calender_panel_day24_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day24);
        }
        private void menu1_table_calender_panel_day24_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day24);
        }
        private void menu1_table_calender_panel_day25_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day25);
        }
        private void menu1_table_calender_panel_day25_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day25);
        }
        private void menu1_table_calender_panel_day26_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day26);
        }
        private void menu1_table_calender_panel_day26_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day26);
        }
        private void menu1_table_calender_panel_day27_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day27);
        }
        private void menu1_table_calender_panel_day27_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day27);
        }
        private void menu1_table_calender_panel_day28_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day28);
        }
        private void menu1_table_calender_panel_day28_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day28);
        }
        private void menu1_table_calender_panel_day29_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day29);
        }
        private void menu1_table_calender_panel_day29_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day29);
        }
        private void menu1_table_calender_panel_day30_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day30);
        }
        private void menu1_table_calender_panel_day30_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day30);
        }
        private void menu1_table_calender_panel_day31_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day31);
        }
        private void menu1_table_calender_panel_day31_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day31);
        }
        private void menu1_table_calender_panel_day32_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day32);
        }
        private void menu1_table_calender_panel_day32_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day32);
        }
        private void menu1_table_calender_panel_day33_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day33);
        }
        private void menu1_table_calender_panel_day33_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day33);
        }
        private void menu1_table_calender_panel_day34_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day34);
        }
        private void menu1_table_calender_panel_day34_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day34);
        }
        private void menu1_table_calender_panel_day35_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day35);
        }
        private void menu1_table_calender_panel_day35_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day35);
        }
        private void menu1_table_calender_panel_day36_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day36);
        }
        private void menu1_table_calender_panel_day36_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day36);
        }
        private void menu1_table_calender_panel_day37_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day37);
        }
        private void menu1_table_calender_panel_day37_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day37);
        }
        private void menu1_table_calender_panel_day38_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day38);
        }
        private void menu1_table_calender_panel_day38_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day38);
        }
        private void menu1_table_calender_panel_day39_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day39);
        }
        private void menu1_table_calender_panel_day39_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day39);
        }
        private void menu1_table_calender_panel_day40_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day40);
        }
        private void menu1_table_calender_panel_day40_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day40);
        }
        private void menu1_table_calender_panel_day41_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day41);
        }
        private void menu1_table_calender_panel_day41_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day41);
        }
        private void menu1_table_calender_panel_day42_MouseEnter(object sender, EventArgs e)
        {
            OverMouse(this.menu1_table_calender_panel_day42);
        }
        private void menu1_table_calender_panel_day42_MouseLeave(object sender, EventArgs e)
        {
            NoOverMouse(this.menu1_table_calender_panel_day42);
        }

        //日付クリック
        private void menu1_table_calender_panel_day1_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day1, 0);
        }
        private void menu1_table_calender_panel_day2_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day2, 1);
        }
        private void menu1_table_calender_panel_day3_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day3, 2);
        }
        private void menu1_table_calender_panel_day4_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day4, 3);
        }
        private void menu1_table_calender_panel_day5_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day5, 4);
        }
        private void menu1_table_calender_panel_day6_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day6, 5);
        }
        private void menu1_table_calender_panel_day7_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day7, 6);
        }
        private void menu1_table_calender_panel_day8_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day8, 7);
        }
        private void menu1_table_calender_panel_day9_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day9, 8);
        }
        private void menu1_table_calender_panel_day10_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day10, 9);
        }
        private void menu1_table_calender_panel_day11_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day11, 10);
        }
        private void menu1_table_calender_panel_day12_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day12, 11);
        }
        private void menu1_table_calender_panel_day13_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day13, 12);
        }
        private void menu1_table_calender_panel_day14_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day14, 13);
        }
        private void menu1_table_calender_panel_day15_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day15, 14);
        }
        private void menu1_table_calender_panel_day16_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day16, 15);
        }
        private void menu1_table_calender_panel_day17_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day17, 16);
        }
        private void menu1_table_calender_panel_day18_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day18, 17);
        }
        private void menu1_table_calender_panel_day19_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day19, 18);
        }
        private void menu1_table_calender_panel_day20_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day20, 19);
        }
        private void menu1_table_calender_panel_day21_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day21, 20);
        }
        private void menu1_table_calender_panel_day22_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day22, 21);
        }
        private void menu1_table_calender_panel_day23_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day23, 22);
        }
        private void menu1_table_calender_panel_day24_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day24, 23);
        }
        private void menu1_table_calender_panel_day25_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day25, 24);
        }
        private void menu1_table_calender_panel_day26_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day26, 25);
        }
        private void menu1_table_calender_panel_day27_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day27, 26);
        }
        private void menu1_table_calender_panel_day28_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day28, 27);
        }
        private void menu1_table_calender_panel_day29_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day29, 28);
        }
        private void menu1_table_calender_panel_day30_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day30, 29);
        }
        private void menu1_table_calender_panel_day31_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day31, 30);
        }
        private void menu1_table_calender_panel_day32_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day32, 31);
        }
        private void menu1_table_calender_panel_day33_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day33, 32);
        }
        private void menu1_table_calender_panel_day34_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day34, 33);
        }
        private void menu1_table_calender_panel_day35_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day35, 34);
        }
        private void menu1_table_calender_panel_day36_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day36, 35);
        }
        private void menu1_table_calender_panel_day37_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day37, 36);
        }
        private void menu1_table_calender_panel_day38_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day38, 37);
        }
        private void menu1_table_calender_panel_day39_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day39, 38);
        }
        private void menu1_table_calender_panel_day40_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day40, 39);
        }
        private void menu1_table_calender_panel_day41_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day41, 40);
        }
        private void menu1_table_calender_panel_day42_MouseClick(object sender, EventArgs e)
        {
            ClickPanel(this.menu1_table_calender_panel_day42, 41);
        }


        private void menu1_table_calender_panel_day1_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(0, this.menu1_table_calender_label_day1.Text);
        }
        private void menu1_table_calender_panel_day2_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(1, this.menu1_table_calender_label_day2.Text);
        }
        private void menu1_table_calender_panel_day3_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(2, this.menu1_table_calender_label_day3.Text);
        }
        private void menu1_table_calender_panel_day4_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(3, this.menu1_table_calender_label_day4.Text);
        }
        private void menu1_table_calender_panel_day5_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(4, this.menu1_table_calender_label_day5.Text);
        }
        private void menu1_table_calender_panel_day6_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(5, this.menu1_table_calender_label_day6.Text);
        }
        private void menu1_table_calender_panel_day7_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(6, this.menu1_table_calender_label_day7.Text);
        }
        private void menu1_table_calender_panel_day8_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(7, this.menu1_table_calender_label_day8.Text);
        }
        private void menu1_table_calender_panel_day9_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(8, this.menu1_table_calender_label_day9.Text);
        }
        private void menu1_table_calender_panel_day10_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(9, this.menu1_table_calender_label_day10.Text);
        }
        private void menu1_table_calender_panel_day11_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(10, this.menu1_table_calender_label_day11.Text);
        }
        private void menu1_table_calender_panel_day12_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(11, this.menu1_table_calender_label_day12.Text);
        }
        private void menu1_table_calender_panel_day13_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(12, this.menu1_table_calender_label_day13.Text);
        }
        private void menu1_table_calender_panel_day14_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(13, this.menu1_table_calender_label_day14.Text);
        }
        private void menu1_table_calender_panel_day15_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(14, this.menu1_table_calender_label_day15.Text);
        }
        private void menu1_table_calender_panel_day16_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(15, this.menu1_table_calender_label_day16.Text);
        }
        private void menu1_table_calender_panel_day17_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(16, this.menu1_table_calender_label_day17.Text);
        }
        private void menu1_table_calender_panel_day18_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(17, this.menu1_table_calender_label_day18.Text);
        }
        private void menu1_table_calender_panel_day19_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(18, this.menu1_table_calender_label_day19.Text);
        }
        private void menu1_table_calender_panel_day20_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(19, this.menu1_table_calender_label_day20.Text);
        }
        private void menu1_table_calender_panel_day21_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(20, this.menu1_table_calender_label_day21.Text);
        }
        private void menu1_table_calender_panel_day22_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(21, this.menu1_table_calender_label_day22.Text);
        }
        private void menu1_table_calender_panel_day23_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(22, this.menu1_table_calender_label_day23.Text);
        }
        private void menu1_table_calender_panel_day24_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(23, this.menu1_table_calender_label_day24.Text);
        }
        private void menu1_table_calender_panel_day25_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(24, this.menu1_table_calender_label_day25.Text);
        }
        private void menu1_table_calender_panel_day26_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(25, this.menu1_table_calender_label_day26.Text);
        }
        private void menu1_table_calender_panel_day27_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(26, this.menu1_table_calender_label_day27.Text);
        }
        private void menu1_table_calender_panel_day28_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(27, this.menu1_table_calender_label_day28.Text);
        }
        private void menu1_table_calender_panel_day29_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(28, this.menu1_table_calender_label_day29.Text);
        }
        private void menu1_table_calender_panel_day30_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(29, this.menu1_table_calender_label_day30.Text);
        }
        private void menu1_table_calender_panel_day31_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(30, this.menu1_table_calender_label_day31.Text);
        }
        private void menu1_table_calender_panel_day32_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(31, this.menu1_table_calender_label_day32.Text);
        }
        private void menu1_table_calender_panel_day33_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(32, this.menu1_table_calender_label_day33.Text);
        }
        private void menu1_table_calender_panel_day34_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(33, this.menu1_table_calender_label_day34.Text);
        }
        private void menu1_table_calender_panel_day35_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(34, this.menu1_table_calender_label_day35.Text);
        }
        private void menu1_table_calender_panel_day36_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(35, this.menu1_table_calender_label_day36.Text);
        }
        private void menu1_table_calender_panel_day37_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(36, this.menu1_table_calender_label_day37.Text);
        }
        private void menu1_table_calender_panel_day38_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(37, this.menu1_table_calender_label_day38.Text);
        }
        private void menu1_table_calender_panel_day39_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(38, this.menu1_table_calender_label_day39.Text);
        }
        private void menu1_table_calender_panel_day40_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(39, this.menu1_table_calender_label_day40.Text);
        }
        private void menu1_table_calender_panel_day41_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(40, this.menu1_table_calender_label_day41.Text);
        }
        private void menu1_table_calender_panel_day42_DoubleClick(object sender, EventArgs e)
        {
            OpenTaskFromPanel(41, this.menu1_table_calender_label_day42.Text);
        }
        #endregion Event menu1
        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu1 end 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */

        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu2_1 start 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */
        #region Event menu2_1
        // menu2 panel1を開いたり閉じたりする時の動作
        private void menu2_1_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            if (this.menu2_1_panel_main.Visible == false)
            {
                this.menu2_1_panel_main.Visible = true;
                this.menu2_1_panel.Height = 936;
                this.menu2_1.Height = 944;
                setting.menu2_open1 = true;
            }
            else
            {
                this.menu2_1_panel_main.Visible = false;
                this.menu2_1_panel.Height = 34;
                this.menu2_1.Height = 42;
                setting.menu2_open1 = false;
            }
            setting.SaveSetting();
        }

        // 要素順を入れ替える
        private void menu2_1_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            switch (setting.order)
            {
                case 213:
                    setting.order = 123;
                    break;
                case 231:
                    setting.order = 213;
                    break;
                case 312:
                    setting.order = 132;
                    break;
                case 321:
                    setting.order = 312;
                    break;
            }

            RefrectMoveControl();
        }

        private void menu2_1_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            switch (setting.order)
            {
                case 123:
                    setting.order = 213;
                    break;
                case 132:
                    setting.order = 312;
                    break;
                case 213:
                    setting.order = 231;
                    break;
                case 312:
                    setting.order = 321;
                    break;
            }

            RefrectMoveControl();
        }

        private void menu2_1_panel_main_panel1_button_delete_MouseEnter(object sender, EventArgs e)
        {
            this.menu2_1_panel_main_panel1_button_delete.BackColor = Color.FromArgb(50, 255, 128, 128);
        }

        private void menu2_1_panel_main_panel1_button_delete_MouseLeave(object sender, EventArgs e)
        {
            this.menu2_1_panel_main_panel1_button_delete.BackColor = Color.Transparent;
        }

        private void menu2_1_panel_main_panel1_button_finish_MouseEnter(object sender, EventArgs e)
        {
            this.menu2_1_panel_main_panel1_button_finish.BackColor = Color.FromArgb(50, 128, 255, 128);
        }

        private void menu2_1_panel_main_panel1_button_finish_MouseLeave(object sender, EventArgs e)
        {
            this.menu2_1_panel_main_panel1_button_finish.BackColor = Color.Transparent;
        }

        // menu2 panel1のタスクを追加するボタン
        private void menu2_1_panel_top_button_add_Click(object sender, EventArgs e)
        {
            OpenTask(-1);
        }

        private void menu2_1_panel_main_panel1_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel1_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(1);
        }

        private void menu2_1_panel_main_panel2_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel2_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(2);
        }

        private void menu2_1_panel_main_panel3_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel3_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(3);
        }

        private void menu2_1_panel_main_panel4_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel4_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(4);
        }

        private void menu2_1_panel_main_panel5_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel5_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(5);
        }

        private void menu2_1_panel_main_panel6_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel6_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(6);
        }

        private void menu2_1_panel_main_panel7_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel7_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(7);
        }

        private void menu2_1_panel_main_panel8_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel8_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(8);
        }

        private void menu2_1_panel_main_panel9_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel9_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(9);
        }

        private void menu2_1_panel_main_panel10_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel10_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(10);
        }

        private void menu2_1_panel_main_panel11_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel11_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(11);
        }

        private void menu2_1_panel_main_panel12_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel12_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(12);
        }

        private void menu2_1_panel_main_panel13_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel13_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(13);
        }

        private void menu2_1_panel_main_panel14_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel14_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(14);
        }

        private void menu2_1_panel_main_panel15_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel15_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(15);
        }

        private void menu2_1_panel_main_panel16_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel16_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(16);
        }

        private void menu2_1_panel_main_panel17_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel17_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(17);
        }

        private void menu2_1_panel_main_panel18_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel18_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(18);
        }

        private void menu2_1_panel_main_panel19_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel19_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(19);
        }

        private void menu2_1_panel_main_panel20_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel20_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(20);
        }

        private void menu2_1_panel_main_panel21_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel21_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(21);
        }

        private void menu2_1_panel_main_panel22_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel22_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(22);
        }

        private void menu2_1_panel_main_panel23_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel23_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(23);
        }

        private void menu2_1_panel_main_panel24_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel24_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(24);
        }

        private void menu2_1_panel_main_panel25_button_finish_Click(object sender, EventArgs e)
        {

        }

        private void menu2_1_panel_main_panel25_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(25);
        }

        private void menu2_1_panel_main_panel1_Click(object sender, EventArgs e)
        {
            OpenTask(1);
        }

        private void menu2_1_panel_main_panel1_label1_Click(object sender, EventArgs e)
        {
            OpenTask(1);
        }

        private void menu2_1_panel_main_panel1_label2_Click(object sender, EventArgs e)
        {
            OpenTask(1);
        }

        private void menu2_1_panel_main_panel2_Click(object sender, EventArgs e)
        {
            OpenTask(2);
        }

        private void menu2_1_panel_main_panel2_label1_Click(object sender, EventArgs e)
        {
            OpenTask(2);
        }

        private void menu2_1_panel_main_panel2_label2_Click(object sender, EventArgs e)
        {
            OpenTask(2);
        }

        private void menu2_1_panel_main_panel3_Click(object sender, EventArgs e)
        {
            OpenTask(3);
        }

        private void menu2_1_panel_main_panel3_label1_Click(object sender, EventArgs e)
        {
            OpenTask(3);
        }

        private void menu2_1_panel_main_panel3_label2_Click(object sender, EventArgs e)
        {
            OpenTask(3);
        }

        private void menu2_1_panel_main_panel4_Click(object sender, EventArgs e)
        {
            OpenTask(4);
        }

        private void menu2_1_panel_main_panel4_label1_Click(object sender, EventArgs e)
        {
            OpenTask(4);
        }

        private void menu2_1_panel_main_panel4_label2_Click(object sender, EventArgs e)
        {
            OpenTask(4);
        }

        private void menu2_1_panel_main_panel5_Click(object sender, EventArgs e)
        {
            OpenTask(5);
        }

        private void menu2_1_panel_main_panel5_label1_Click(object sender, EventArgs e)
        {
            OpenTask(5);
        }

        private void menu2_1_panel_main_panel5_label2_Click(object sender, EventArgs e)
        {
            OpenTask(5);
        }

        private void menu2_1_panel_main_panel6_Click(object sender, EventArgs e)
        {
            OpenTask(6);
        }

        private void menu2_1_panel_main_panel6_label1_Click(object sender, EventArgs e)
        {
            OpenTask(6);
        }

        private void menu2_1_panel_main_panel6_label2_Click(object sender, EventArgs e)
        {
            OpenTask(6);
        }

        private void menu2_1_panel_main_panel7_Click(object sender, EventArgs e)
        {
            OpenTask(7);
        }

        private void menu2_1_panel_main_panel7_label1_Click(object sender, EventArgs e)
        {
            OpenTask(7);
        }

        private void menu2_1_panel_main_panel7_label2_Click(object sender, EventArgs e)
        {
            OpenTask(7);
        }

        private void menu2_1_panel_main_panel8_Click(object sender, EventArgs e)
        {
            OpenTask(8);
        }

        private void menu2_1_panel_main_panel8_label1_Click(object sender, EventArgs e)
        {
            OpenTask(8);
        }

        private void menu2_1_panel_main_panel8_label2_Click(object sender, EventArgs e)
        {
            OpenTask(8);
        }

        private void menu2_1_panel_main_panel9_Click(object sender, EventArgs e)
        {
            OpenTask(9);
        }

        private void menu2_1_panel_main_panel9_label1_Click(object sender, EventArgs e)
        {
            OpenTask(9);
        }

        private void menu2_1_panel_main_panel9_label2_Click(object sender, EventArgs e)
        {
            OpenTask(9);
        }

        private void menu2_1_panel_main_panel10_Click(object sender, EventArgs e)
        {
            OpenTask(10);
        }

        private void menu2_1_panel_main_panel10_label1_Click(object sender, EventArgs e)
        {
            OpenTask(10);
        }

        private void menu2_1_panel_main_panel10_label2_Click(object sender, EventArgs e)
        {
            OpenTask(10);
        }

        private void menu2_1_panel_main_panel11_Click(object sender, EventArgs e)
        {
            OpenTask(11);
        }

        private void menu2_1_panel_main_panel11_label1_Click(object sender, EventArgs e)
        {
            OpenTask(11);
        }

        private void menu2_1_panel_main_panel11_label2_Click(object sender, EventArgs e)
        {
            OpenTask(11);
        }

        private void menu2_1_panel_main_panel12_Click(object sender, EventArgs e)
        {
            OpenTask(12);
        }

        private void menu2_1_panel_main_panel12_label1_Click(object sender, EventArgs e)
        {
            OpenTask(12);
        }

        private void menu2_1_panel_main_panel12_label2_Click(object sender, EventArgs e)
        {
            OpenTask(12);
        }

        private void menu2_1_panel_main_panel13_Click(object sender, EventArgs e)
        {
            OpenTask(13);
        }

        private void menu2_1_panel_main_panel13_label1_Click(object sender, EventArgs e)
        {
            OpenTask(13);
        }

        private void menu2_1_panel_main_panel13_label2_Click(object sender, EventArgs e)
        {
            OpenTask(13);
        }

        private void menu2_1_panel_main_panel14_Click(object sender, EventArgs e)
        {
            OpenTask(14);
        }

        private void menu2_1_panel_main_panel14_label1_Click(object sender, EventArgs e)
        {
            OpenTask(14);
        }

        private void menu2_1_panel_main_panel14_label2_Click(object sender, EventArgs e)
        {
            OpenTask(14);
        }

        private void menu2_1_panel_main_panel15_Click(object sender, EventArgs e)
        {
            OpenTask(15);
        }

        private void menu2_1_panel_main_panel15_label1_Click(object sender, EventArgs e)
        {
            OpenTask(15);
        }

        private void menu2_1_panel_main_panel15_label2_Click(object sender, EventArgs e)
        {
            OpenTask(15);
        }

        private void menu2_1_panel_main_panel16_Click(object sender, EventArgs e)
        {
            OpenTask(16);
        }

        private void menu2_1_panel_main_panel16_label1_Click(object sender, EventArgs e)
        {
            OpenTask(16);
        }

        private void menu2_1_panel_main_panel16_label2_Click(object sender, EventArgs e)
        {
            OpenTask(16);
        }

        private void menu2_1_panel_main_panel17_Click(object sender, EventArgs e)
        {
            OpenTask(17);
        }

        private void menu2_1_panel_main_panel17_label1_Click(object sender, EventArgs e)
        {
            OpenTask(17);
        }

        private void menu2_1_panel_main_panel17_label2_Click(object sender, EventArgs e)
        {
            OpenTask(17);
        }

        private void menu2_1_panel_main_panel18_Click(object sender, EventArgs e)
        {
            OpenTask(18);
        }

        private void menu2_1_panel_main_panel18_label1_Click(object sender, EventArgs e)
        {
            OpenTask(18);
        }

        private void menu2_1_panel_main_panel18_label2_Click(object sender, EventArgs e)
        {
            OpenTask(18);
        }

        private void menu2_1_panel_main_panel19_Click(object sender, EventArgs e)
        {
            OpenTask(18);
        }

        private void menu2_1_panel_main_panel19_label1_Click(object sender, EventArgs e)
        {
            OpenTask(19);
        }

        private void menu2_1_panel_main_panel19_label2_Click(object sender, EventArgs e)
        {
            OpenTask(19);
        }

        private void menu2_1_panel_main_panel20_Click(object sender, EventArgs e)
        {
            OpenTask(20);
        }

        private void menu2_1_panel_main_panel20_label1_Click(object sender, EventArgs e)
        {
            OpenTask(20);
        }

        private void menu2_1_panel_main_panel20_label2_Click(object sender, EventArgs e)
        {
            OpenTask(20);
        }

        private void menu2_1_panel_main_panel21_Click(object sender, EventArgs e)
        {
            OpenTask(21);
        }

        private void menu2_1_panel_main_panel21_label1_Click(object sender, EventArgs e)
        {
            OpenTask(21);
        }

        private void menu2_1_panel_main_panel21_label2_Click(object sender, EventArgs e)
        {
            OpenTask(21);
        }

        private void menu2_1_panel_main_panel22_Click(object sender, EventArgs e)
        {
            OpenTask(22);
        }

        private void menu2_1_panel_main_panel22_label1_Click(object sender, EventArgs e)
        {
            OpenTask(22);
        }

        private void menu2_1_panel_main_panel22_label2_Click(object sender, EventArgs e)
        {
            OpenTask(22);
        }

        private void menu2_1_panel_main_panel23_Click(object sender, EventArgs e)
        {
            OpenTask(23);
        }

        private void menu2_1_panel_main_panel23_label1_Click(object sender, EventArgs e)
        {
            OpenTask(23);
        }

        private void menu2_1_panel_main_panel23_label2_Click(object sender, EventArgs e)
        {
            OpenTask(23);
        }

        private void menu2_1_panel_main_panel24_Click(object sender, EventArgs e)
        {
            OpenTask(24);
        }

        private void menu2_1_panel_main_panel24_label1_Click(object sender, EventArgs e)
        {
            OpenTask(24);
        }

        private void menu2_1_panel_main_panel24_label2_Click(object sender, EventArgs e)
        {
            OpenTask(24);
        }

        private void menu2_1_panel_main_panel25_Click(object sender, EventArgs e)
        {
            OpenTask(25);
        }

        private void menu2_1_panel_main_panel25_label1_Click(object sender, EventArgs e)
        {
            OpenTask(25);
        }

        private void menu2_1_panel_main_panel25_label2_Click(object sender, EventArgs e)
        {
            OpenTask(25);
        }
        #endregion Event menu2_1
        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu2_1 end 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */

        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu2_2 start 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */
        #region Event menu2_2
        // menu2 panel2を開いたり閉じたりする時の動作
        private void menu2_2_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            if (this.menu2_2_panel_main.Visible == false)
            {
                this.menu2_2_panel_main.Visible = true;
                this.menu2_2_panel.Height = 1002;
                this.menu2_2.Height = 1010;
                setting.menu2_open2 = true;
            }
            else
            {
                this.menu2_2_panel_main.Visible = false;
                this.menu2_2_panel.Height = 34;
                this.menu2_2.Height = 42;
                setting.menu2_open2 = false;
            }
            setting.SaveSetting();
        }

        // 要素順を入れ替える
        private void menu2_2_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            switch (setting.order)
            {
                case 123:
                    setting.order = 213;
                    break;
                case 132:
                    setting.order = 123;
                    break;
                case 312:
                    setting.order = 321;
                    break;
                case 321:
                    setting.order = 213;
                    break;
            }

            RefrectMoveControl(); //要素順反映
        }
        private void menu2_2_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            switch (setting.order)
            {
                case 123:
                    setting.order = 132;
                    break;
                case 213:
                    setting.order = 123;
                    break;
                case 231:
                    setting.order = 321;
                    break;
                case 321:
                    setting.order = 312;
                    break;
            }

            RefrectMoveControl(); //要素順反映
        }

        // menu2_2 ファイルを開くダイアログを開く
        private void menu2_2_panel_top_button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txtファイル(*.txt;*.log;*.oml)|*.txt;*.log;*.oml";
            ofd.FilterIndex = 1;
            ofd.Title = "ファイルを選択してください";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        // 新規メモ帳を開く
        private void menu2_2_panel_top_button_add_Click(object sender, EventArgs e)
        {
            FileUtil fu = new FileUtil();
            string filename = "";
            filename = DateTime.Now.ToString("yyyyMMdd") + "_";

            for (int i = 0; i < 999; i++)
            {
                if (fu.CreateFile(filename + i.ToString()))
                {
                    break;
                }
            }
        }

        // キー押下時のイベント
        private void menu2_2_panel_main_panel1_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(memo1_path, this.menu2_2_panel_main_panel1_table_memo_text.Text);
            }
        }

        private void menu2_2_panel_main_panel2_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(memo2_path, this.menu2_2_panel_main_panel1_table_memo_text.Text);
            }
        }

        private void menu2_2_panel_main_panel3_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(memo3_path, this.menu2_2_panel_main_panel1_table_memo_text.Text);
            }
        }

        private void menu2_2_panel_main_panel4_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(memo4_path, this.menu2_2_panel_main_panel1_table_memo_text.Text);
            }
        }

        private void menu2_2_panel_main_panel5_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                SaveMemo(memo5_path, this.menu2_2_panel_main_panel1_table_memo_text.Text);
            }
        }

        private void menu2_2_panel_main_panel1_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            FileUtil fu = new FileUtil();
            if (!fu.WriteFileAll(setting.memo_name1, menu2_2_panel_main_panel1_table_memo_text.Text, false))
            {
                MessageBox.Show("保存できませんでした。", "エラー", MessageBoxButtons.OK);
            }
        }

        private void menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            if (this.menu2_2_panel_main_panel1_table_memo_text.Visible == false)
            {
                this.menu2_2_panel_main_panel1_table_memo_text.Visible = true;
                this.menu2_2_panel_main_panel1.Height = 106;
            }
            else
            {
                this.menu2_2_panel_main_panel1_table_memo_text.Visible = false;
                this.menu2_2_panel_main_panel1.Height = 28;
            }
        }

        private void menu2_2_panel_main_panel1_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {

        }

        private void menu2_2_panel_main_panel2_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            FileUtil fu = new FileUtil();
            if (!fu.WriteFileAll(setting.memo_name2, menu2_2_panel_main_panel2_table_memo_text.Text, false))
            {
                MessageBox.Show("保存できませんでした。", "エラー", MessageBoxButtons.OK);
            }
        }

        private void menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            if (this.menu2_2_panel_main_panel2_table_memo_text.Visible == false)
            {
                this.menu2_2_panel_main_panel2_table_memo_text.Visible = true;
                this.menu2_2_panel_main_panel2.Height = 106;
            }
            else
            {
                this.menu2_2_panel_main_panel2_table_memo_text.Visible = false;
                this.menu2_2_panel_main_panel2.Height = 28;
            }
        }

        private void menu2_2_panel_main_panel2_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {

        }

        private void menu2_2_panel_main_panel3_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            FileUtil fu = new FileUtil();
            if (!fu.WriteFileAll(setting.memo_name3, menu2_2_panel_main_panel3_table_memo_text.Text, false))
            {
                MessageBox.Show("保存できませんでした。", "エラー", MessageBoxButtons.OK);
            }
        }

        private void menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            if (this.menu2_2_panel_main_panel3_table_memo_text.Visible == false)
            {
                this.menu2_2_panel_main_panel3_table_memo_text.Visible = true;
                this.menu2_2_panel_main_panel3.Height = 106;
            }
            else
            {
                this.menu2_2_panel_main_panel3_table_memo_text.Visible = false;
                this.menu2_2_panel_main_panel3.Height = 28;
            }
        }

        private void menu2_2_panel_main_panel3_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {

        }

        private void menu2_2_panel_main_panel4_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            FileUtil fu = new FileUtil();
            if (!fu.WriteFileAll(setting.memo_name4, menu2_2_panel_main_panel4_table_memo_text.Text, false))
            {
                MessageBox.Show("保存できませんでした。", "エラー", MessageBoxButtons.OK);
            }
        }

        private void menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            if (this.menu2_2_panel_main_panel4_table_memo_text.Visible == false)
            {
                this.menu2_2_panel_main_panel4_table_memo_text.Visible = true;
                this.menu2_2_panel_main_panel4.Height = 106;
            }
            else
            {
                this.menu2_2_panel_main_panel4_table_memo_text.Visible = false;
                this.menu2_2_panel_main_panel4.Height = 28;
            }
        }

        private void menu2_2_panel_main_panel4_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {

        }

        private void menu2_2_panel_main_panel5_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            FileUtil fu = new FileUtil();
            if (!fu.WriteFileAll(setting.memo_name5, menu2_2_panel_main_panel5_table_memo_text.Text, false))
            {
                MessageBox.Show("保存できませんでした。", "エラー", MessageBoxButtons.OK);
            }
        }

        private void menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            if (this.menu2_2_panel_main_panel5_table_memo_text.Visible == false)
            {
                this.menu2_2_panel_main_panel5_table_memo_text.Visible = true;
                this.menu2_2_panel_main_panel5.Height = 106;
            }
            else
            {
                this.menu2_2_panel_main_panel5_table_memo_text.Visible = false;
                this.menu2_2_panel_main_panel5.Height = 28;
            }
        }

        private void menu2_2_panel_main_panel5_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {

        }
        #endregion Event menu2_2
        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu2_2 end 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */

        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu2_3 start 
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */
        #region Event menu2_3
        // menu2 panel3を開いたり閉じたりする時の動作
        private void menu2_3_panel_top_button_openclose_Click(object sender, EventArgs e)
        {
            if (this.menu2_3_panel_main.Visible == false)
            {
                this.menu2_3_panel_main.Visible = true;
                this.menu2_3_panel.Height = 934;
                this.menu2_3.Height = 942;
                setting.menu2_open3 = true;
            }
            else
            {
                this.menu2_3_panel_main.Visible = false;
                this.menu2_3_panel.Height = 34;
                this.menu2_3.Height = 42;
                setting.menu2_open3 = false;
            }
            setting.SaveSetting();
        }
        
        // 要素順を入れ替える
        private void menu2_3_panel_top_button_moveup_Click(object sender, EventArgs e)
        {
            switch (setting.order)
            {
                case 123:
                    setting.order = 132;
                    break;
                case 132:
                    setting.order = 312;
                    break;
                case 213:
                    setting.order = 231;
                    break;
                case 231:
                    setting.order = 321;
                    break;
            }

            RefrectMoveControl();
        }
        private void menu2_3_panel_top_button_movedown_Click(object sender, EventArgs e)
        {
            switch (setting.order)
            {
                case 132:
                    setting.order = 123;
                    break;
                case 231:
                    setting.order = 213;
                    break;
                case 312:
                    setting.order = 132;
                    break;
                case 321:
                    setting.order = 231;
                    break;
            }

            RefrectMoveControl();
        }

        private void menu2_3_panel_top_button_add_Click(object sender, EventArgs e)
        {
            OpenAchieve(-1);
        }

        private void menu2_3_panel_main_panel1_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(1);
        }

        private void menu2_3_panel_main_panel2_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(2);
        }

        private void menu2_3_panel_main_panel3_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(3);
        }

        private void menu2_3_panel_main_panel4_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(4);
        }

        private void menu2_3_panel_main_panel5_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(5);
        }

        private void menu2_3_panel_main_panel6_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(6);
        }

        private void menu2_3_panel_main_panel7_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(7);
        }

        private void menu2_3_panel_main_panel8_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(8);
        }

        private void menu2_3_panel_main_panel9_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(9);
        }

        private void menu2_3_panel_main_panel10_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(10);
        }

        private void menu2_3_panel_main_panel11_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(11);
        }

        private void menu2_3_panel_main_panel12_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(12);
        }

        private void menu2_3_panel_main_panel13_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(13);
        }

        private void menu2_3_panel_main_panel14_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(14);
        }

        private void menu2_3_panel_main_panel15_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(15);
        }

        private void menu2_3_panel_main_panel16_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(16);
        }

        private void menu2_3_panel_main_panel17_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(17);
        }

        private void menu2_3_panel_main_panel18_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(18);
        }

        private void menu2_3_panel_main_panel19_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(19);
        }

        private void menu2_3_panel_main_panel20_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(20);
        }

        private void menu2_3_panel_main_panel21_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(21);
        }

        private void menu2_3_panel_main_panel22_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(22);
        }

        private void menu2_3_panel_main_panel23_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(23);
        }

        private void menu2_3_panel_main_panel24_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(24);
        }

        private void menu2_3_panel_main_panel25_button_delete_Click(object sender, EventArgs e)
        {
            RemoveAchieve(25);
        }

        private void menu2_3_panel_main_panel1_Click(object sender, EventArgs e)
        {
            OpenAchieve(1);
        }

        private void menu2_3_panel_main_panel1_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(1);
        }

        private void menu2_3_panel_main_panel2_Click(object sender, EventArgs e)
        {
            OpenAchieve(2);
        }

        private void menu2_3_panel_main_panel2_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(2);
        }

        private void menu2_3_panel_main_panel3_Click(object sender, EventArgs e)
        {
            OpenAchieve(3);
        }

        private void menu2_3_panel_main_panel3_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(3);
        }

        private void menu2_3_panel_main_panel4_Click(object sender, EventArgs e)
        {
            OpenAchieve(4);
        }

        private void menu2_3_panel_main_panel4_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(4);
        }

        private void menu2_3_panel_main_panel5_Click(object sender, EventArgs e)
        {
            OpenAchieve(5);
        }

        private void menu2_3_panel_main_panel5_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(5);
        }

        private void menu2_3_panel_main_panel6_Click(object sender, EventArgs e)
        {
            OpenAchieve(6);
        }

        private void menu2_3_panel_main_panel6_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(6);
        }

        private void menu2_3_panel_main_panel7_Click(object sender, EventArgs e)
        {
            OpenAchieve(7);
        }

        private void menu2_3_panel_main_panel7_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(7);
        }

        private void menu2_3_panel_main_panel8_Click(object sender, EventArgs e)
        {
            OpenAchieve(8);
        }

        private void menu2_3_panel_main_panel8_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(8);
        }

        private void menu2_3_panel_main_panel9_Click(object sender, EventArgs e)
        {
            OpenAchieve(9);
        }

        private void menu2_3_panel_main_panel9_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(9);
        }

        private void menu2_3_panel_main_panel10_Click(object sender, EventArgs e)
        {
            OpenAchieve(10);
        }

        private void menu2_3_panel_main_panel10_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(10);
        }

        private void menu2_3_panel_main_panel11_Click(object sender, EventArgs e)
        {
            OpenAchieve(11);
        }

        private void menu2_3_panel_main_panel11_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(11);
        }

        private void menu2_3_panel_main_panel12_Click(object sender, EventArgs e)
        {
            OpenAchieve(12);
        }

        private void menu2_3_panel_main_panel12_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(12);
        }

        private void menu2_3_panel_main_panel13_Click(object sender, EventArgs e)
        {
            OpenAchieve(13);
        }

        private void menu2_3_panel_main_panel13_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(13);
        }

        private void menu2_3_panel_main_panel14_Click(object sender, EventArgs e)
        {
            OpenAchieve(14);
        }

        private void menu2_3_panel_main_panel14_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(14);
        }

        private void menu2_3_panel_main_panel15_Click(object sender, EventArgs e)
        {
            OpenAchieve(15);
        }

        private void menu2_3_panel_main_panel15_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(15);
        }

        private void menu2_3_panel_main_panel16_Click(object sender, EventArgs e)
        {
            OpenAchieve(16);
        }

        private void menu2_3_panel_main_panel16_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(16);
        }

        private void menu2_3_panel_main_panel17_Click(object sender, EventArgs e)
        {
            OpenAchieve(17);
        }

        private void menu2_3_panel_main_panel17_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(17);
        }

        private void menu2_3_panel_main_panel18_Click(object sender, EventArgs e)
        {
            OpenAchieve(18);
        }

        private void menu2_3_panel_main_panel18_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(18);
        }

        private void menu2_3_panel_main_panel19_Click(object sender, EventArgs e)
        {
            OpenAchieve(19);
        }

        private void menu2_3_panel_main_panel19_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(19);
        }

        private void menu2_3_panel_main_panel20_Click(object sender, EventArgs e)
        {
            OpenAchieve(20);
        }

        private void menu2_3_panel_main_panel20_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(20);
        }

        private void menu2_3_panel_main_panel21_Click(object sender, EventArgs e)
        {
            OpenAchieve(21);
        }

        private void menu2_3_panel_main_panel21_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(21);
        }

        private void menu2_3_panel_main_panel22_Click(object sender, EventArgs e)
        {
            OpenAchieve(22);
        }

        private void menu2_3_panel_main_panel22_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(22);
        }

        private void menu2_3_panel_main_panel23_Click(object sender, EventArgs e)
        {
            OpenAchieve(23);
        }

        private void menu2_3_panel_main_panel23_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(23);
        }

        private void menu2_3_panel_main_panel24_Click(object sender, EventArgs e)
        {
            OpenAchieve(24);
        }

        private void menu2_3_panel_main_panel24_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(24);
        }

        private void menu2_3_panel_main_panel25_Click(object sender, EventArgs e)
        {
            OpenAchieve(25);
        }

        private void menu2_3_panel_main_panel25_label1_Click(object sender, EventArgs e)
        {
            OpenAchieve(25);
        }
        #endregion Event menu2_3
        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menu2_3 end
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */

        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menutask start
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */
        #region Event menutask
        private void menutask_button_close_Click(object sender, EventArgs e)
        {
            menutask.Visible = false;
        }
        
        private void menutask_button_save_Click(object sender, EventArgs e)
        {

        }
        #endregion Event menutask
        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menutask end
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */

        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menuachieve start
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */
        #region Event menuachieve
        private void menuachieve_button_close_Click(object sender, EventArgs e)
        {
            this.menuachieve.Visible = false;
        }

        private void menuachieve_button_save_Click(object sender, EventArgs e)
        {

        }
        #endregion Event menuachieve
        /*
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         * menuachieve end
         * ★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★ 
         */

        //●Event End●

        /*
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
         * common start 
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□ 
         */
        #region common
        // フォームロード時の動作
        private void MainForm_Load()
        {
            //タスクの初期化
            Inittask();
            //実績の初期化
            InitAchieve();
            // commonをタイトルバー化する
            SetMoveForm();
            // 設定を反映
            RefrectSetting();
            // メニュー切り替え
            ChangeMenu(menu);
            // 表示モード切り替え
            ChangeDarkMode(setting.common_mode);
            // menu2 panel3 のメモのサイズ変更イベント定義
            SetSizeChanger();
            // 現在日時を設定
            Set_NowDay();
            Set_NowYearMonth();
        }

        // 設定を反映
        private void RefrectSetting()
        {
            // ダークモード
            if (setting.common_mode)
            {
                this.common_panel_setting_table_check1.Checked = true;
            }
            else
            {
                this.common_panel_setting_table_check1.Checked = false;
            }

            // タスク表示
            if (setting.menu1_taskshow)
            {

            }
            else
            {
            }

            // メモ文字サイズ
            if (setting.menu2_fontsize != 0)
            {

            }
            else
            {

            }

            // メモ折り返し
            if (setting.menu2_memowrap)
            {
                this.common_panel_setting_table_check3.Checked = true;
                this.menu2_2_panel_main_panel1_table_memo_text.WordWrap = true;
                this.menu2_2_panel_main_panel2_table_memo_text.WordWrap = true;
                this.menu2_2_panel_main_panel3_table_memo_text.WordWrap = true;
                this.menu2_2_panel_main_panel4_table_memo_text.WordWrap = true;
                this.menu2_2_panel_main_panel5_table_memo_text.WordWrap = true;
            }
            else
            {
                this.common_panel_setting_table_check3.Checked = false;
                this.menu2_2_panel_main_panel1_table_memo_text.WordWrap = false;
                this.menu2_2_panel_main_panel2_table_memo_text.WordWrap = false;
                this.menu2_2_panel_main_panel3_table_memo_text.WordWrap = false;
                this.menu2_2_panel_main_panel4_table_memo_text.WordWrap = false;
                this.menu2_2_panel_main_panel5_table_memo_text.WordWrap = false;
            }

            // menu2 1 開いているか
            if (setting.menu2_open1)
            {
                this.menu2_1_panel_main.Visible = true;
                this.menu2_1_panel.Height = 936;
                this.menu2_1.Height = 944;
            }
            else
            {
                this.menu2_1_panel_main.Visible = false;
                this.menu2_1_panel.Height = 34;
                this.menu2_1.Height = 42;
            }

            // menu2 2 開いているか
            if (setting.menu2_open2)
            {
                this.menu2_2_panel_main.Visible = true;
                this.menu2_2_panel.Height = 562;
                this.menu2_2.Height = 570;
            }
            else
            {
                this.menu2_2_panel_main.Visible = false;
                this.menu2_2_panel.Height = 34;
                this.menu2_2.Height = 42;
            }

            // menu2 3 開いているか
            if (setting.menu2_open3)
            {
                this.menu2_3_panel_main.Visible = true;
                this.menu2_3_panel.Height = 934;
                this.menu2_3.Height = 942;
            }
            else
            {
                this.menu2_3_panel_main.Visible = false;
                this.menu2_3_panel.Height = 34;
                this.menu2_3.Height = 42;
            }

            // フォームサイズ x
            if (setting.form_x != 0)
            {
                this.Width = setting.form_x;
            }
            else
            {
            }

            // フォームサイズ y
            if (setting.form_y != 0)
            {
                this.Height = setting.form_y;
            }
            else
            {
            }
        }

        // メニュー切り替え
        private void ChangeMenu(int menu)
        {
            switch (menu)
            {
                case 1: //メイン画面
                    this.menu1.Visible = true;
                    this.menu2.Visible = false;
                    this.menutask.Visible = false;
                    this.menuachieve.Visible = false;
                    this.menu3.Visible = false;
                    this.common_button_prevmenu.Visible = false;
                    this.common_button_nextmenu.Visible = true;
                    break;
                case 2: //タスク画面
                    this.menu1.Visible = false;
                    this.menu2.Visible = true;
                    this.menutask.Visible = false;
                    this.menuachieve.Visible = false;
                    this.menu3.Visible = false;
                    this.common_button_prevmenu.Visible = true;
                    this.common_button_nextmenu.Visible = true;
                    break;
                case 3: //実績画面
                    this.menu1.Visible = false;
                    this.menu2.Visible = false;
                    this.menutask.Visible = false;
                    this.menuachieve.Visible = false;
                    this.menu3.Visible = true;
                    this.common_button_prevmenu.Visible = true;
                    this.common_button_nextmenu.Visible = false;
                    break;
            }
        }

        // 表示モード切り替え
        private void ChangeDarkMode(Boolean darkmode)
        {
            if (darkmode)
            {
                main_color = dark;
                sub_color = white;
                submain_color = subdark;
                subsub_color = subwhite;
            }
            else
            {
                main_color = white;
                sub_color = dark;
                submain_color = subwhite;
                subsub_color = subdark;
            }

            // 全体
            this.BackColor = main_color;

            // common
            this.common_panel_setting_table_setting.BackColor = main_color;
            this.common_panel_setting.BackColor = sub_color;
            this.common_panel_setting_table_label1.ForeColor = sub_color;
            this.common_panel_setting_table_label2.ForeColor = sub_color;
            this.common_panel_setting_table_label3.ForeColor = sub_color;

            // 〇menu1
            // カレンダーの日にちの背景色を変更
            this.menu1_panel_calendertop_panel_yearmonth_label_year.ForeColor = sub_color;
            this.menu1_panel_calendertop_panel_yearmonth_label_month.ForeColor = sub_color;

            this.menu1_table_calender_panel_day1.BackColor = submain_color;
            this.menu1_table_calender_panel_day2.BackColor = submain_color;
            this.menu1_table_calender_panel_day3.BackColor = submain_color;
            this.menu1_table_calender_panel_day4.BackColor = submain_color;
            this.menu1_table_calender_panel_day5.BackColor = submain_color;
            this.menu1_table_calender_panel_day6.BackColor = submain_color;
            this.menu1_table_calender_panel_day7.BackColor = submain_color;
            this.menu1_table_calender_panel_day8.BackColor = submain_color;
            this.menu1_table_calender_panel_day9.BackColor = submain_color;
            this.menu1_table_calender_panel_day10.BackColor = submain_color;
            this.menu1_table_calender_panel_day11.BackColor = submain_color;
            this.menu1_table_calender_panel_day12.BackColor = submain_color;
            this.menu1_table_calender_panel_day13.BackColor = submain_color;
            this.menu1_table_calender_panel_day14.BackColor = submain_color;
            this.menu1_table_calender_panel_day15.BackColor = submain_color;
            this.menu1_table_calender_panel_day16.BackColor = submain_color;
            this.menu1_table_calender_panel_day17.BackColor = submain_color;
            this.menu1_table_calender_panel_day18.BackColor = submain_color;
            this.menu1_table_calender_panel_day19.BackColor = submain_color;
            this.menu1_table_calender_panel_day20.BackColor = submain_color;
            this.menu1_table_calender_panel_day21.BackColor = submain_color;
            this.menu1_table_calender_panel_day22.BackColor = submain_color;
            this.menu1_table_calender_panel_day23.BackColor = submain_color;
            this.menu1_table_calender_panel_day24.BackColor = submain_color;
            this.menu1_table_calender_panel_day25.BackColor = submain_color;
            this.menu1_table_calender_panel_day26.BackColor = submain_color;
            this.menu1_table_calender_panel_day27.BackColor = submain_color;
            this.menu1_table_calender_panel_day28.BackColor = submain_color;
            this.menu1_table_calender_panel_day29.BackColor = submain_color;
            this.menu1_table_calender_panel_day30.BackColor = submain_color;
            this.menu1_table_calender_panel_day31.BackColor = submain_color;
            this.menu1_table_calender_panel_day32.BackColor = submain_color;
            this.menu1_table_calender_panel_day33.BackColor = submain_color;
            this.menu1_table_calender_panel_day34.BackColor = submain_color;
            this.menu1_table_calender_panel_day35.BackColor = submain_color;
            this.menu1_table_calender_panel_day36.BackColor = submain_color;
            this.menu1_table_calender_panel_day37.BackColor = submain_color;
            this.menu1_table_calender_panel_day38.BackColor = submain_color;
            this.menu1_table_calender_panel_day39.BackColor = submain_color;
            this.menu1_table_calender_panel_day40.BackColor = submain_color;
            this.menu1_table_calender_panel_day41.BackColor = submain_color;
            this.menu1_table_calender_panel_day42.BackColor = submain_color;

            // カレンダーの曜日の文字色を変更
            this.menu1_table_calender_label_sunday.ForeColor = sub_color;
            this.menu1_table_calender_label_monday.ForeColor = sub_color;
            this.menu1_table_calender_label_tuesday.ForeColor = sub_color;
            this.menu1_table_calender_label_wednesday.ForeColor = sub_color;
            this.menu1_table_calender_label_thursday.ForeColor = sub_color;
            this.menu1_table_calender_label_friday.ForeColor = sub_color;
            this.menu1_table_calender_label_saturday.ForeColor = sub_color;

            int year = DateTime.Now.Year; // 問題あり　月変更後モード変えるとおかしい
            int month = DateTime.Now.Month; // 問題あり　月変更後モード変えるとおかしい
            Set_Day(year, month);

            // menu2
            this.menu2_1_panel_top_label_title.ForeColor = sub_color;
            this.menu2_1_panel_main_panel1_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel1_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel2_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel2_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel3_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel3_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel4_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel4_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel5_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel5_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel6_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel6_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel7_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel7_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel8_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel8_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel9_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel9_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel10_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel10_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel11_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel11_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel12_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel12_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel13_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel13_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel14_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel14_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel15_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel15_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel16_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel16_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel17_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel17_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel18_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel18_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel19_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel19_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel20_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel20_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel21_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel21_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel22_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel22_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel23_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel23_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel24_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel24_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel25_label1.ForeColor = sub_color;
            this.menu2_1_panel_main_panel25_label2.ForeColor = sub_color;
            this.menu2_1_panel_main_panel1.BorderColor = sub_color;
            this.menu2_1_panel_main_panel2.BorderColor = sub_color;
            this.menu2_1_panel_main_panel3.BorderColor = sub_color;
            this.menu2_1_panel_main_panel4.BorderColor = sub_color;
            this.menu2_1_panel_main_panel5.BorderColor = sub_color;
            this.menu2_1_panel_main_panel6.BorderColor = sub_color;
            this.menu2_1_panel_main_panel7.BorderColor = sub_color;
            this.menu2_1_panel_main_panel8.BorderColor = sub_color;
            this.menu2_1_panel_main_panel9.BorderColor = sub_color;
            this.menu2_1_panel_main_panel10.BorderColor = sub_color;
            this.menu2_1_panel_main_panel11.BorderColor = sub_color;
            this.menu2_1_panel_main_panel12.BorderColor = sub_color;
            this.menu2_1_panel_main_panel13.BorderColor = sub_color;
            this.menu2_1_panel_main_panel14.BorderColor = sub_color;
            this.menu2_1_panel_main_panel15.BorderColor = sub_color;
            this.menu2_1_panel_main_panel16.BorderColor = sub_color;
            this.menu2_1_panel_main_panel17.BorderColor = sub_color;
            this.menu2_1_panel_main_panel18.BorderColor = sub_color;
            this.menu2_1_panel_main_panel19.BorderColor = sub_color;
            this.menu2_1_panel_main_panel20.BorderColor = sub_color;
            this.menu2_1_panel_main_panel21.BorderColor = sub_color;
            this.menu2_1_panel_main_panel22.BorderColor = sub_color;
            this.menu2_1_panel_main_panel23.BorderColor = sub_color;
            this.menu2_1_panel_main_panel24.BorderColor = sub_color;
            this.menu2_1_panel_main_panel25.BorderColor = sub_color;

            this.menu2_2_panel_top_label_title.ForeColor = sub_color;

            this.menu2_3_panel_top_label_title.ForeColor = sub_color;
            this.menu2_3_panel_main_panel1_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel2_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel3_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel4_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel5_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel6_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel7_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel8_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel9_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel10_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel11_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel12_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel13_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel14_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel15_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel16_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel17_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel18_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel19_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel20_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel21_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel22_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel23_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel24_label1.ForeColor = sub_color;
            this.menu2_3_panel_main_panel25_label1.ForeColor = sub_color;
        }

        // commonをタイトルバーにする初期化
        private void SetMoveForm()
        {
            common_MoveForm = new DAndDMoveForm(this.common, this);
        }
        #endregion common
        /* 
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
         * common end
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□ 
         */

        /* 
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
         * menu1 start
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□ 
         */
        #region menu1
        // 現在日時を設定
        private void Set_NowDay()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            Set_Day(year, month);
        }

        // セレクトボックスの年、月を取得
        private void Get_YearMonth(ref int year, ref int month)
        {
            if (Int32.TryParse(this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem.ToString(), out int y))
            {
                if (!(Int32.Parse(this.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[0].ToString()) <= year && year <= Int32.Parse(this.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[4].ToString())))
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
            

            month = Int32.Parse(this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem.ToString());
            if (Int32.TryParse(this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem.ToString(), out int m))
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

        // カレンダーの年、月をセット
        private void Set_NowYearMonth()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            string[] years = new string[5];

            years[0] = DateTime.Now.AddYears(-2).Year.ToString();
            years[1] = DateTime.Now.AddYears(-1).Year.ToString();
            years[2] = DateTime.Now.Year.ToString();
            years[3] = DateTime.Now.AddYears(1).Year.ToString();
            years[4] = DateTime.Now.AddYears(2).Year.ToString();

            this.menu1_panel_calendertop_panel_yearmonth_combo_year.Items.AddRange(years);
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        // カレンダーの日にちと今月ではない日を取得
        private void Get_Calender(int year, int month, ref DateTime today, ref int[] days, ref int sub_day, ref DateTime firstday, ref int today_int)
        {
            today = DateTime.Now;
            today_int = -1;

            firstday = new DateTime(year, month, 1);
            DayOfWeek firstdate = firstday.DayOfWeek;
            days = new int[42];

            sub_day = 0;
            Boolean subday_flg = false;

            DateTime inputday = firstday.AddDays(-1);

            for (int i = (int)firstdate - 1; i >= 0; i--)
            {
                days[i] = inputday.Day;
                if (today.Year == inputday.Year && today.Month == inputday.Month && today.Day == inputday.Day)
                {
                    today_int = i;
                }
                inputday = inputday.AddDays(-1);
            }
            inputday = firstday;
            for (int i = (int)firstdate; i <= 41; i++)
            {
                days[i] = inputday.Day;
                if (today.Year == inputday.Year && today.Month == inputday.Month && today.Day == inputday.Day)
                {
                    today_int = i;
                }
                if (month != inputday.Month && subday_flg == false)
                {
                    sub_day = i;
                    subday_flg = true;
                }
                inputday = inputday.AddDays(1);
            }
        }

        // カレンダーに日にちをセット
        private void Set_Day(int year, int month)
        {
            DateTime today = DateTime.Now;
            int[] days = new int[42];
            int sub_day = 0;
            DateTime firstday = new DateTime(year, month, 1);
            int today_int = -1;
            Get_Calender(year, month, ref today, ref days, ref sub_day, ref firstday, ref today_int);

            DayOfWeek firstdate = firstday.DayOfWeek;

            Color today_color = Color.FromArgb(255, 128, 0);
            Color panel_color = submain_color;
            Color main_text_color = sub_color;
            Color sub_text_color = subsub_color;

            Font main_font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Font sub_font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.menu1_table_calender_label_day1.Text = days[0].ToString();
            this.menu1_table_calender_label_day2.Text = days[1].ToString();
            this.menu1_table_calender_label_day3.Text = days[2].ToString();
            this.menu1_table_calender_label_day4.Text = days[3].ToString();
            this.menu1_table_calender_label_day5.Text = days[4].ToString();
            this.menu1_table_calender_label_day6.Text = days[5].ToString();
            this.menu1_table_calender_label_day7.Text = days[6].ToString();
            this.menu1_table_calender_label_day8.Text = days[7].ToString();
            this.menu1_table_calender_label_day9.Text = days[8].ToString();
            this.menu1_table_calender_label_day10.Text = days[9].ToString();
            this.menu1_table_calender_label_day11.Text = days[10].ToString();
            this.menu1_table_calender_label_day12.Text = days[11].ToString();
            this.menu1_table_calender_label_day13.Text = days[12].ToString();
            this.menu1_table_calender_label_day14.Text = days[13].ToString();
            this.menu1_table_calender_label_day15.Text = days[14].ToString();
            this.menu1_table_calender_label_day16.Text = days[15].ToString();
            this.menu1_table_calender_label_day17.Text = days[16].ToString();
            this.menu1_table_calender_label_day18.Text = days[17].ToString();
            this.menu1_table_calender_label_day19.Text = days[18].ToString();
            this.menu1_table_calender_label_day20.Text = days[19].ToString();
            this.menu1_table_calender_label_day21.Text = days[20].ToString();
            this.menu1_table_calender_label_day22.Text = days[21].ToString();
            this.menu1_table_calender_label_day23.Text = days[22].ToString();
            this.menu1_table_calender_label_day24.Text = days[23].ToString();
            this.menu1_table_calender_label_day25.Text = days[24].ToString();
            this.menu1_table_calender_label_day26.Text = days[25].ToString();
            this.menu1_table_calender_label_day27.Text = days[26].ToString();
            this.menu1_table_calender_label_day28.Text = days[27].ToString();
            this.menu1_table_calender_label_day29.Text = days[28].ToString();
            this.menu1_table_calender_label_day30.Text = days[29].ToString();
            this.menu1_table_calender_label_day31.Text = days[30].ToString();
            this.menu1_table_calender_label_day32.Text = days[31].ToString();
            this.menu1_table_calender_label_day33.Text = days[32].ToString();
            this.menu1_table_calender_label_day34.Text = days[33].ToString();
            this.menu1_table_calender_label_day35.Text = days[34].ToString();
            this.menu1_table_calender_label_day36.Text = days[35].ToString();
            this.menu1_table_calender_label_day37.Text = days[36].ToString();
            this.menu1_table_calender_label_day38.Text = days[37].ToString();
            this.menu1_table_calender_label_day39.Text = days[38].ToString();
            this.menu1_table_calender_label_day40.Text = days[39].ToString();
            this.menu1_table_calender_label_day41.Text = days[40].ToString();
            this.menu1_table_calender_label_day42.Text = days[41].ToString();

            // カレンダーの全ての文字色を変更する
            this.menu1_table_calender_label_day1.ForeColor = main_text_color;
            this.menu1_table_calender_label_day2.ForeColor = main_text_color;
            this.menu1_table_calender_label_day3.ForeColor = main_text_color;
            this.menu1_table_calender_label_day4.ForeColor = main_text_color;
            this.menu1_table_calender_label_day5.ForeColor = main_text_color;
            this.menu1_table_calender_label_day6.ForeColor = main_text_color;
            this.menu1_table_calender_label_day7.ForeColor = main_text_color;
            this.menu1_table_calender_label_day8.ForeColor = main_text_color;
            this.menu1_table_calender_label_day9.ForeColor = main_text_color;
            this.menu1_table_calender_label_day10.ForeColor = main_text_color;
            this.menu1_table_calender_label_day11.ForeColor = main_text_color;
            this.menu1_table_calender_label_day12.ForeColor = main_text_color;
            this.menu1_table_calender_label_day13.ForeColor = main_text_color;
            this.menu1_table_calender_label_day14.ForeColor = main_text_color;
            this.menu1_table_calender_label_day15.ForeColor = main_text_color;
            this.menu1_table_calender_label_day16.ForeColor = main_text_color;
            this.menu1_table_calender_label_day17.ForeColor = main_text_color;
            this.menu1_table_calender_label_day18.ForeColor = main_text_color;
            this.menu1_table_calender_label_day19.ForeColor = main_text_color;
            this.menu1_table_calender_label_day20.ForeColor = main_text_color;
            this.menu1_table_calender_label_day21.ForeColor = main_text_color;
            this.menu1_table_calender_label_day22.ForeColor = main_text_color;
            this.menu1_table_calender_label_day23.ForeColor = main_text_color;
            this.menu1_table_calender_label_day24.ForeColor = main_text_color;
            this.menu1_table_calender_label_day25.ForeColor = main_text_color;
            this.menu1_table_calender_label_day26.ForeColor = main_text_color;
            this.menu1_table_calender_label_day27.ForeColor = main_text_color;
            this.menu1_table_calender_label_day28.ForeColor = main_text_color;
            this.menu1_table_calender_label_day29.ForeColor = main_text_color;
            this.menu1_table_calender_label_day30.ForeColor = main_text_color;
            this.menu1_table_calender_label_day31.ForeColor = main_text_color;
            this.menu1_table_calender_label_day32.ForeColor = main_text_color;
            this.menu1_table_calender_label_day33.ForeColor = main_text_color;
            this.menu1_table_calender_label_day34.ForeColor = main_text_color;
            this.menu1_table_calender_label_day35.ForeColor = main_text_color;
            this.menu1_table_calender_label_day36.ForeColor = main_text_color;
            this.menu1_table_calender_label_day37.ForeColor = main_text_color;
            this.menu1_table_calender_label_day38.ForeColor = main_text_color;
            this.menu1_table_calender_label_day39.ForeColor = main_text_color;
            this.menu1_table_calender_label_day40.ForeColor = main_text_color;
            this.menu1_table_calender_label_day41.ForeColor = main_text_color;
            this.menu1_table_calender_label_day42.ForeColor = main_text_color;

            // カレンダーの全てのフォントを変更する
            this.menu1_table_calender_label_day1.Font = main_font;
            this.menu1_table_calender_label_day2.Font = main_font;
            this.menu1_table_calender_label_day3.Font = main_font;
            this.menu1_table_calender_label_day4.Font = main_font;
            this.menu1_table_calender_label_day5.Font = main_font;
            this.menu1_table_calender_label_day6.Font = main_font;
            this.menu1_table_calender_label_day7.Font = main_font;
            this.menu1_table_calender_label_day8.Font = main_font;
            this.menu1_table_calender_label_day9.Font = main_font;
            this.menu1_table_calender_label_day10.Font = main_font;
            this.menu1_table_calender_label_day11.Font = main_font;
            this.menu1_table_calender_label_day12.Font = main_font;
            this.menu1_table_calender_label_day13.Font = main_font;
            this.menu1_table_calender_label_day14.Font = main_font;
            this.menu1_table_calender_label_day15.Font = main_font;
            this.menu1_table_calender_label_day16.Font = main_font;
            this.menu1_table_calender_label_day17.Font = main_font;
            this.menu1_table_calender_label_day18.Font = main_font;
            this.menu1_table_calender_label_day19.Font = main_font;
            this.menu1_table_calender_label_day20.Font = main_font;
            this.menu1_table_calender_label_day21.Font = main_font;
            this.menu1_table_calender_label_day22.Font = main_font;
            this.menu1_table_calender_label_day23.Font = main_font;
            this.menu1_table_calender_label_day24.Font = main_font;
            this.menu1_table_calender_label_day25.Font = main_font;
            this.menu1_table_calender_label_day26.Font = main_font;
            this.menu1_table_calender_label_day27.Font = main_font;
            this.menu1_table_calender_label_day28.Font = main_font;
            this.menu1_table_calender_label_day29.Font = main_font;
            this.menu1_table_calender_label_day30.Font = main_font;
            this.menu1_table_calender_label_day31.Font = main_font;
            this.menu1_table_calender_label_day32.Font = main_font;
            this.menu1_table_calender_label_day33.Font = main_font;
            this.menu1_table_calender_label_day34.Font = main_font;
            this.menu1_table_calender_label_day35.Font = main_font;
            this.menu1_table_calender_label_day36.Font = main_font;
            this.menu1_table_calender_label_day37.Font = main_font;
            this.menu1_table_calender_label_day38.Font = main_font;
            this.menu1_table_calender_label_day39.Font = main_font;
            this.menu1_table_calender_label_day40.Font = main_font;
            this.menu1_table_calender_label_day41.Font = main_font;
            this.menu1_table_calender_label_day42.Font = main_font;

            // 前の月の文字色、フォントを変更する
            switch ((int)firstdate - 1)
            {
                case 0:
                    this.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day1.Font = sub_font;
                    break;
                case 1:
                    this.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day1.Font = sub_font;
                    this.menu1_table_calender_label_day2.Font = sub_font;
                    break;
                case 2:
                    this.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day1.Font = sub_font;
                    this.menu1_table_calender_label_day2.Font = sub_font;
                    this.menu1_table_calender_label_day3.Font = sub_font;
                    break;
                case 3:
                    this.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day4.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day1.Font = sub_font;
                    this.menu1_table_calender_label_day2.Font = sub_font;
                    this.menu1_table_calender_label_day3.Font = sub_font;
                    this.menu1_table_calender_label_day4.Font = sub_font;
                    break;
                case 4:
                    this.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day4.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day5.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day1.Font = sub_font;
                    this.menu1_table_calender_label_day2.Font = sub_font;
                    this.menu1_table_calender_label_day3.Font = sub_font;
                    this.menu1_table_calender_label_day4.Font = sub_font;
                    this.menu1_table_calender_label_day5.Font = sub_font;
                    break;
                case 5:
                    this.menu1_table_calender_label_day1.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day2.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day3.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day4.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day5.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day6.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day1.Font = sub_font;
                    this.menu1_table_calender_label_day2.Font = sub_font;
                    this.menu1_table_calender_label_day3.Font = sub_font;
                    this.menu1_table_calender_label_day4.Font = sub_font;
                    this.menu1_table_calender_label_day5.Font = sub_font;
                    this.menu1_table_calender_label_day6.Font = sub_font;
                    break;
            }

            // 次の月の文字色、フォントを変更する
            switch (sub_day)
            {
                case 28:
                    this.menu1_table_calender_label_day29.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day30.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day31.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day29.Font = sub_font;
                    this.menu1_table_calender_label_day30.Font = sub_font;
                    this.menu1_table_calender_label_day31.Font = sub_font;
                    this.menu1_table_calender_label_day32.Font = sub_font;
                    this.menu1_table_calender_label_day33.Font = sub_font;
                    this.menu1_table_calender_label_day34.Font = sub_font;
                    this.menu1_table_calender_label_day35.Font = sub_font;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 29:
                    this.menu1_table_calender_label_day30.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day31.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day30.Font = sub_font;
                    this.menu1_table_calender_label_day31.Font = sub_font;
                    this.menu1_table_calender_label_day32.Font = sub_font;
                    this.menu1_table_calender_label_day33.Font = sub_font;
                    this.menu1_table_calender_label_day34.Font = sub_font;
                    this.menu1_table_calender_label_day35.Font = sub_font;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 30:
                    this.menu1_table_calender_label_day31.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day31.Font = sub_font;
                    this.menu1_table_calender_label_day32.Font = sub_font;
                    this.menu1_table_calender_label_day33.Font = sub_font;
                    this.menu1_table_calender_label_day34.Font = sub_font;
                    this.menu1_table_calender_label_day35.Font = sub_font;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 31:
                    this.menu1_table_calender_label_day32.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day32.Font = sub_font;
                    this.menu1_table_calender_label_day33.Font = sub_font;
                    this.menu1_table_calender_label_day34.Font = sub_font;
                    this.menu1_table_calender_label_day35.Font = sub_font;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 32:
                    this.menu1_table_calender_label_day33.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day33.Font = sub_font;
                    this.menu1_table_calender_label_day34.Font = sub_font;
                    this.menu1_table_calender_label_day35.Font = sub_font;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 33:
                    this.menu1_table_calender_label_day34.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day34.Font = sub_font;
                    this.menu1_table_calender_label_day35.Font = sub_font;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 34:
                    this.menu1_table_calender_label_day35.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day35.Font = sub_font;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 35:
                    this.menu1_table_calender_label_day36.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day36.Font = sub_font;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 36:
                    this.menu1_table_calender_label_day37.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day37.Font = sub_font;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 37:
                    this.menu1_table_calender_label_day38.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day38.Font = sub_font;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 38:
                    this.menu1_table_calender_label_day39.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day39.Font = sub_font;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 39:
                    this.menu1_table_calender_label_day40.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day40.Font = sub_font;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 40:
                    this.menu1_table_calender_label_day41.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day41.Font = sub_font;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
                case 41:
                    this.menu1_table_calender_label_day42.ForeColor = sub_text_color;
                    this.menu1_table_calender_label_day42.Font = sub_font;
                    break;
            }

            // カレンダーの日にちの背景色を変更
            this.menu1_table_calender_panel_day1.BackColor = submain_color;
            this.menu1_table_calender_panel_day2.BackColor = submain_color;
            this.menu1_table_calender_panel_day3.BackColor = submain_color;
            this.menu1_table_calender_panel_day4.BackColor = submain_color;
            this.menu1_table_calender_panel_day5.BackColor = submain_color;
            this.menu1_table_calender_panel_day6.BackColor = submain_color;
            this.menu1_table_calender_panel_day7.BackColor = submain_color;
            this.menu1_table_calender_panel_day8.BackColor = submain_color;
            this.menu1_table_calender_panel_day9.BackColor = submain_color;
            this.menu1_table_calender_panel_day10.BackColor = submain_color;
            this.menu1_table_calender_panel_day11.BackColor = submain_color;
            this.menu1_table_calender_panel_day12.BackColor = submain_color;
            this.menu1_table_calender_panel_day13.BackColor = submain_color;
            this.menu1_table_calender_panel_day14.BackColor = submain_color;
            this.menu1_table_calender_panel_day15.BackColor = submain_color;
            this.menu1_table_calender_panel_day16.BackColor = submain_color;
            this.menu1_table_calender_panel_day17.BackColor = submain_color;
            this.menu1_table_calender_panel_day18.BackColor = submain_color;
            this.menu1_table_calender_panel_day19.BackColor = submain_color;
            this.menu1_table_calender_panel_day20.BackColor = submain_color;
            this.menu1_table_calender_panel_day21.BackColor = submain_color;
            this.menu1_table_calender_panel_day22.BackColor = submain_color;
            this.menu1_table_calender_panel_day23.BackColor = submain_color;
            this.menu1_table_calender_panel_day24.BackColor = submain_color;
            this.menu1_table_calender_panel_day25.BackColor = submain_color;
            this.menu1_table_calender_panel_day26.BackColor = submain_color;
            this.menu1_table_calender_panel_day27.BackColor = submain_color;
            this.menu1_table_calender_panel_day28.BackColor = submain_color;
            this.menu1_table_calender_panel_day29.BackColor = submain_color;
            this.menu1_table_calender_panel_day30.BackColor = submain_color;
            this.menu1_table_calender_panel_day31.BackColor = submain_color;
            this.menu1_table_calender_panel_day32.BackColor = submain_color;
            this.menu1_table_calender_panel_day33.BackColor = submain_color;
            this.menu1_table_calender_panel_day34.BackColor = submain_color;
            this.menu1_table_calender_panel_day35.BackColor = submain_color;
            this.menu1_table_calender_panel_day36.BackColor = submain_color;
            this.menu1_table_calender_panel_day37.BackColor = submain_color;
            this.menu1_table_calender_panel_day38.BackColor = submain_color;
            this.menu1_table_calender_panel_day39.BackColor = submain_color;
            this.menu1_table_calender_panel_day40.BackColor = submain_color;
            this.menu1_table_calender_panel_day41.BackColor = submain_color;
            this.menu1_table_calender_panel_day42.BackColor = submain_color;

            // 現在日がカレンダーに存在する場合はパネルの色を変更する
            switch (today_int)
            {
                case 0:
                    this.menu1_table_calender_panel_day1.BackColor = today_color;
                    break;
                case 1:
                    this.menu1_table_calender_panel_day2.BackColor = today_color;
                    break;
                case 2:
                    this.menu1_table_calender_panel_day3.BackColor = today_color;
                    break;
                case 3:
                    this.menu1_table_calender_panel_day4.BackColor = today_color;
                    break;
                case 4:
                    this.menu1_table_calender_panel_day5.BackColor = today_color;
                    break;
                case 5:
                    this.menu1_table_calender_panel_day6.BackColor = today_color;
                    break;
                case 6:
                    this.menu1_table_calender_panel_day7.BackColor = today_color;
                    break;
                case 7:
                    this.menu1_table_calender_panel_day8.BackColor = today_color;
                    break;
                case 8:
                    this.menu1_table_calender_panel_day9.BackColor = today_color;
                    break;
                case 9:
                    this.menu1_table_calender_panel_day10.BackColor = today_color;
                    break;
                case 10:
                    this.menu1_table_calender_panel_day11.BackColor = today_color;
                    break;
                case 11:
                    this.menu1_table_calender_panel_day12.BackColor = today_color;
                    break;
                case 12:
                    this.menu1_table_calender_panel_day13.BackColor = today_color;
                    break;
                case 13:
                    this.menu1_table_calender_panel_day14.BackColor = today_color;
                    break;
                case 14:
                    this.menu1_table_calender_panel_day15.BackColor = today_color;
                    break;
                case 15:
                    this.menu1_table_calender_panel_day16.BackColor = today_color;
                    break;
                case 16:
                    this.menu1_table_calender_panel_day17.BackColor = today_color;
                    break;
                case 17:
                    this.menu1_table_calender_panel_day18.BackColor = today_color;
                    break;
                case 18:
                    this.menu1_table_calender_panel_day19.BackColor = today_color;
                    break;
                case 19:
                    this.menu1_table_calender_panel_day20.BackColor = today_color;
                    break;
                case 20:
                    this.menu1_table_calender_panel_day21.BackColor = today_color;
                    break;
                case 21:
                    this.menu1_table_calender_panel_day22.BackColor = today_color;
                    break;
                case 22:
                    this.menu1_table_calender_panel_day23.BackColor = today_color;
                    break;
                case 23:
                    this.menu1_table_calender_panel_day24.BackColor = today_color;
                    break;
                case 24:
                    this.menu1_table_calender_panel_day25.BackColor = today_color;
                    break;
                case 25:
                    this.menu1_table_calender_panel_day26.BackColor = today_color;
                    break;
                case 26:
                    this.menu1_table_calender_panel_day27.BackColor = today_color;
                    break;
                case 27:
                    this.menu1_table_calender_panel_day28.BackColor = today_color;
                    break;
                case 28:
                    this.menu1_table_calender_panel_day29.BackColor = today_color;
                    break;
                case 29:
                    this.menu1_table_calender_panel_day30.BackColor = today_color;
                    break;
                case 30:
                    this.menu1_table_calender_panel_day31.BackColor = today_color;
                    break;
                case 31:
                    this.menu1_table_calender_panel_day32.BackColor = today_color;
                    break;
                case 32:
                    this.menu1_table_calender_panel_day33.BackColor = today_color;
                    break;
                case 33:
                    this.menu1_table_calender_panel_day34.BackColor = today_color;
                    break;
                case 34:
                    this.menu1_table_calender_panel_day35.BackColor = today_color;
                    break;
                case 35:
                    this.menu1_table_calender_panel_day36.BackColor = today_color;
                    break;
                case 36:
                    this.menu1_table_calender_panel_day37.BackColor = today_color;
                    break;
            }
        }

        // 年月変更時イベント
        private void Change_YearMonth()
        {
            int year = 0;
            int month = 0;
            if (this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem == null)
            {
                year = DateTime.Now.Year;
            }
            else
            {
                year = Int32.Parse(this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem.ToString());
                if (!(Int32.Parse(this.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[0].ToString()) <= year && year <= Int32.Parse(this.menu1_panel_calendertop_panel_yearmonth_combo_year.Items[4].ToString())))
                {
                    year = DateTime.Now.Year;
                }
            }

            if (this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem == null)
            {
                month = DateTime.Now.Month;
            }
            else
            {
                month = Int32.Parse(this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem.ToString());
                if (!(1 <= month && month <= 12))
                {
                    month = DateTime.Now.Month;
                }
            }

            Set_Day(year, month);
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedItem = year.ToString();
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedItem = month.ToString();
        }

        // 日付クリック時の動作
        private void ClickPanel(Panel panel, int panel_num)
        {
            this.menu1_table_calender_panel_day1.Refresh();
            this.menu1_table_calender_panel_day2.Refresh();
            this.menu1_table_calender_panel_day3.Refresh();
            this.menu1_table_calender_panel_day4.Refresh();
            this.menu1_table_calender_panel_day5.Refresh();
            this.menu1_table_calender_panel_day6.Refresh();
            this.menu1_table_calender_panel_day7.Refresh();
            this.menu1_table_calender_panel_day8.Refresh();
            this.menu1_table_calender_panel_day9.Refresh();
            this.menu1_table_calender_panel_day10.Refresh();
            this.menu1_table_calender_panel_day11.Refresh();
            this.menu1_table_calender_panel_day12.Refresh();
            this.menu1_table_calender_panel_day13.Refresh();
            this.menu1_table_calender_panel_day14.Refresh();
            this.menu1_table_calender_panel_day15.Refresh();
            this.menu1_table_calender_panel_day16.Refresh();
            this.menu1_table_calender_panel_day17.Refresh();
            this.menu1_table_calender_panel_day18.Refresh();
            this.menu1_table_calender_panel_day19.Refresh();
            this.menu1_table_calender_panel_day20.Refresh();
            this.menu1_table_calender_panel_day21.Refresh();
            this.menu1_table_calender_panel_day22.Refresh();
            this.menu1_table_calender_panel_day23.Refresh();
            this.menu1_table_calender_panel_day24.Refresh();
            this.menu1_table_calender_panel_day25.Refresh();
            this.menu1_table_calender_panel_day26.Refresh();
            this.menu1_table_calender_panel_day27.Refresh();
            this.menu1_table_calender_panel_day28.Refresh();
            this.menu1_table_calender_panel_day29.Refresh();
            this.menu1_table_calender_panel_day30.Refresh();
            this.menu1_table_calender_panel_day31.Refresh();
            this.menu1_table_calender_panel_day32.Refresh();
            this.menu1_table_calender_panel_day33.Refresh();
            this.menu1_table_calender_panel_day34.Refresh();
            this.menu1_table_calender_panel_day35.Refresh();
            this.menu1_table_calender_panel_day36.Refresh();
            this.menu1_table_calender_panel_day37.Refresh();
            this.menu1_table_calender_panel_day38.Refresh();
            this.menu1_table_calender_panel_day39.Refresh();
            this.menu1_table_calender_panel_day40.Refresh();
            this.menu1_table_calender_panel_day41.Refresh();
            this.menu1_table_calender_panel_day42.Refresh();

            clickpanel = panel_num;

            Graphics g = panel.CreateGraphics();
            Pen pen;

            int r = panel.ClientRectangle.Right - 1;
            int b = panel.ClientRectangle.Bottom - 1;
            pen = new Pen(sub_color);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // 日付ホバー時の動作
        private void OverMouse(Panel panel)
        {
            panel.Refresh();
            Graphics g = panel.CreateGraphics();
            Pen pen;

            int r = panel.ClientRectangle.Right - 1;
            int b = panel.ClientRectangle.Bottom - 1;
            pen = new Pen(subsub_color);
            g.DrawLine(pen, 0, 0, r, 0);
            g.DrawLine(pen, 0, 0, 0, b);
            g.DrawLine(pen, r, 0, r, b);
            g.DrawLine(pen, 0, b, r, b);
        }

        // 日付ホバーが外れた時の動作
        private void NoOverMouse(Panel panel)
        {
            if (clickpanel != 0)
            {
                this.menu1_table_calender_panel_day1.Refresh();
            }
            if (clickpanel != 1)
            {
                this.menu1_table_calender_panel_day2.Refresh();
            }
            if (clickpanel != 2)
            {
                this.menu1_table_calender_panel_day3.Refresh();
            }
            if (clickpanel != 3)
            {
                this.menu1_table_calender_panel_day4.Refresh();
            }
            if (clickpanel != 4)
            {
                this.menu1_table_calender_panel_day5.Refresh();
            }
            if (clickpanel != 5)
            {
                this.menu1_table_calender_panel_day6.Refresh();
            }
            if (clickpanel != 6)
            {
                this.menu1_table_calender_panel_day7.Refresh();
            }
            if (clickpanel != 7)
            {
                this.menu1_table_calender_panel_day8.Refresh();
            }
            if (clickpanel != 8)
            {
                this.menu1_table_calender_panel_day9.Refresh();
            }
            if (clickpanel != 9)
            {
                this.menu1_table_calender_panel_day10.Refresh();
            }
            if (clickpanel != 10)
            {
                this.menu1_table_calender_panel_day11.Refresh();
            }
            if (clickpanel != 11)
            {
                this.menu1_table_calender_panel_day12.Refresh();
            }
            if (clickpanel != 12)
            {
                this.menu1_table_calender_panel_day13.Refresh();
            }
            if (clickpanel != 13)
            {
                this.menu1_table_calender_panel_day14.Refresh();
            }
            if (clickpanel != 14)
            {
                this.menu1_table_calender_panel_day15.Refresh();
            }
            if (clickpanel != 15)
            {
                this.menu1_table_calender_panel_day16.Refresh();
            }
            if (clickpanel != 16)
            {
                this.menu1_table_calender_panel_day17.Refresh();
            }
            if (clickpanel != 17)
            {
                this.menu1_table_calender_panel_day18.Refresh();
            }
            if (clickpanel != 18)
            {
                this.menu1_table_calender_panel_day19.Refresh();
            }
            if (clickpanel != 19)
            {
                this.menu1_table_calender_panel_day20.Refresh();
            }
            if (clickpanel != 20)
            {
                this.menu1_table_calender_panel_day21.Refresh();
            }
            if (clickpanel != 21)
            {
                this.menu1_table_calender_panel_day22.Refresh();
            }
            if (clickpanel != 22)
            {
                this.menu1_table_calender_panel_day23.Refresh();
            }
            if (clickpanel != 23)
            {
                this.menu1_table_calender_panel_day24.Refresh();
            }
            if (clickpanel != 24)
            {
                this.menu1_table_calender_panel_day25.Refresh();
            }
            if (clickpanel != 25)
            {
                this.menu1_table_calender_panel_day26.Refresh();
            }
            if (clickpanel != 26)
            {
                this.menu1_table_calender_panel_day27.Refresh();
            }
            if (clickpanel != 27)
            {
                this.menu1_table_calender_panel_day28.Refresh();
            }
            if (clickpanel != 28)
            {
                this.menu1_table_calender_panel_day29.Refresh();
            }
            if (clickpanel != 29)
            {
                this.menu1_table_calender_panel_day30.Refresh();
            }
            if (clickpanel != 30)
            {
                this.menu1_table_calender_panel_day31.Refresh();
            }
            if (clickpanel != 31)
            {
                this.menu1_table_calender_panel_day32.Refresh();
            }
            if (clickpanel != 32)
            {
                this.menu1_table_calender_panel_day33.Refresh();
            }
            if (clickpanel != 33)
            {
                this.menu1_table_calender_panel_day34.Refresh();
            }
            if (clickpanel != 34)
            {
                this.menu1_table_calender_panel_day35.Refresh();
            }
            if (clickpanel != 35)
            {
                this.menu1_table_calender_panel_day36.Refresh();
            }
            if (clickpanel != 36)
            {
                this.menu1_table_calender_panel_day37.Refresh();
            }
            if (clickpanel != 37)
            {
                this.menu1_table_calender_panel_day38.Refresh();
            }
            if (clickpanel != 38)
            {
                this.menu1_table_calender_panel_day39.Refresh();
            }
            if (clickpanel != 39)
            {
                this.menu1_table_calender_panel_day40.Refresh();
            }
            if (clickpanel != 40)
            {
                this.menu1_table_calender_panel_day41.Refresh();
            }
            if (clickpanel != 41)
            {
                this.menu1_table_calender_panel_day42.Refresh();
            }

            switch (clickpanel)
            {
                case 0:
                    panel = this.menu1_table_calender_panel_day1;
                    break;
                case 1:
                    panel = this.menu1_table_calender_panel_day2;
                    break;
                case 2:
                    panel = this.menu1_table_calender_panel_day3;
                    break;
                case 3:
                    panel = this.menu1_table_calender_panel_day4;
                    break;
                case 4:
                    panel = this.menu1_table_calender_panel_day5;
                    break;
                case 5:
                    panel = this.menu1_table_calender_panel_day6;
                    break;
                case 6:
                    panel = this.menu1_table_calender_panel_day7;
                    break;
                case 7:
                    panel = this.menu1_table_calender_panel_day8;
                    break;
                case 8:
                    panel = this.menu1_table_calender_panel_day9;
                    break;
                case 9:
                    panel = this.menu1_table_calender_panel_day10;
                    break;
                case 10:
                    panel = this.menu1_table_calender_panel_day11;
                    break;
                case 11:
                    panel = this.menu1_table_calender_panel_day12;
                    break;
                case 12:
                    panel = this.menu1_table_calender_panel_day13;
                    break;
                case 13:
                    panel = this.menu1_table_calender_panel_day14;
                    break;
                case 14:
                    panel = this.menu1_table_calender_panel_day15;
                    break;
                case 15:
                    panel = this.menu1_table_calender_panel_day16;
                    break;
                case 16:
                    panel = this.menu1_table_calender_panel_day17;
                    break;
                case 17:
                    panel = this.menu1_table_calender_panel_day18;
                    break;
                case 18:
                    panel = this.menu1_table_calender_panel_day19;
                    break;
                case 19:
                    panel = this.menu1_table_calender_panel_day20;
                    break;
                case 20:
                    panel = this.menu1_table_calender_panel_day21;
                    break;
                case 21:
                    panel = this.menu1_table_calender_panel_day22;
                    break;
                case 22:
                    panel = this.menu1_table_calender_panel_day23;
                    break;
                case 23:
                    panel = this.menu1_table_calender_panel_day24;
                    break;
                case 24:
                    panel = this.menu1_table_calender_panel_day25;
                    break;
                case 25:
                    panel = this.menu1_table_calender_panel_day26;
                    break;
                case 26:
                    panel = this.menu1_table_calender_panel_day27;
                    break;
                case 27:
                    panel = this.menu1_table_calender_panel_day28;
                    break;
                case 28:
                    panel = this.menu1_table_calender_panel_day29;
                    break;
                case 29:
                    panel = this.menu1_table_calender_panel_day30;
                    break;
                case 30:
                    panel = this.menu1_table_calender_panel_day31;
                    break;
                case 31:
                    panel = this.menu1_table_calender_panel_day32;
                    break;
                case 32:
                    panel = this.menu1_table_calender_panel_day33;
                    break;
                case 33:
                    panel = this.menu1_table_calender_panel_day34;
                    break;
                case 34:
                    panel = this.menu1_table_calender_panel_day35;
                    break;
                case 35:
                    panel = this.menu1_table_calender_panel_day36;
                    break;
                case 36:
                    panel = this.menu1_table_calender_panel_day37;
                    break;
                case 37:
                    panel = this.menu1_table_calender_panel_day38;
                    break;
                case 38:
                    panel = this.menu1_table_calender_panel_day39;
                    break;
                case 39:
                    panel = this.menu1_table_calender_panel_day40;
                    break;
                case 40:
                    panel = this.menu1_table_calender_panel_day41;
                    break;
                case 41:
                    panel = this.menu1_table_calender_panel_day42;
                    break;
                default:
                    return;
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

        //日付ダブルクリック
        private void OpenTaskFromPanel(int panel_num, string label_day)
        {

        }
        #endregion menu1
        /* 
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
         * menu1 end
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□ 
         */

        /* 
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
         * menu2 start
         * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□ 
         */
        #region menu2
        // タスクの構造体
        private struct Task
        {
            public string name;
            public Boolean term;
            public DateTime term_from;
            public DateTime term_to;
            public string memo;
            public int color;

            public Task(string name, Boolean term, DateTime term_from, DateTime term_to, string memo, int color)
            {
                this.name = name;
                this.term = term;
                this.term_from = term_from;
                this.term_to = term_to;
                this.memo = memo;
                this.color = color;
            }
        }
        // 実績の構造体
        private struct Achieve
        {
            public string name;
            public int progress;
            public double hour;
            public string memo;

            public Achieve(string name, int progress, double hour, string memo)
            {
                this.name = name;
                this.progress = progress;
                this.hour = hour;
                this.memo = memo;
            }
        }

        // タスクの初期化
        private Task[] task = new Task[50];
        
        private void Inittask()
        {
            for (int i = 0; i < 50; i++)
            {
                task[i] = new Task("", false, DateTime.Now, DateTime.Now, "", 0);
            }
        }

        // 実績の初期化
        private Achieve[] achieve = new Achieve[50];
        
        private void InitAchieve()
        {
            for (int i = 0; i < 50; i++)
            {
                achieve[i] = new Achieve("", 0, 0, "");
            }
        }

        /// <summary>
        /// タスクを開く
        /// </summary>
        /// <param name="task_num"></param>
        private void OpenTask(int task_num)
        {
            if (task_num == -1)
            {
                this.menutask_table1_text.Text = "";
                this.menutask_table2_check.Checked = false;
                //this.menutask_table2_text1 = 
                //this.menutask_table2_text2 =
                this.menutask_table3_text.Text = "";
            }
            else
            {
                this.menutask_table1_text.Text = task[task_num].name;
                this.menutask_table2_check.Checked = task[task_num].term;
                //this.menutask_table2_text1 = task[task_num].term_from;
                //this.menutask_table2_text2 = task[task_num].term_to;
                this.menutask_table3_text.Text = task[task_num].memo;
                //this.menutask_table4_
            }
            this.menuachieve.Visible = false;
            this.menutask.Visible = true;
        }

        /// <summary>
        /// タスク登録
        /// </summary>
        /// <param name="name"></param>
        /// <param name="term"></param>
        /// <param name="term_from"></param>
        /// <param name="term_to"></param>
        /// <param name="memo"></param>
        /// <param name="priority"></param>
        /// <param name="color"></param>
        private void AddTask(string name, Boolean term, DateTime term_from, DateTime term_to, string memo, int priority, int color)
        {
            for (int i=0; i<50; i++)
            {
                if (task[i].name=="")
                {
                    task[i].name = name;
                    task[i].term = term;
                    task[i].term_from = term_from;
                    task[i].term_to = term_to;
                    task[i].memo = memo;
                    task[i].color = color;
                    break;
                }
            }
        }

        /// <summary>
        /// タスク削除
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private Boolean RemoveTask(int num)
        {
            for (int i=num; i<49; i++)
            {
                task[num].name = task[num + 1].name;
                task[num].term = task[num + 1].term;
                task[num].term_from = task[num + 1].term_from;
                task[num].term_to = task[num + 1].term_to;
                task[num].memo = task[num + 1].memo;
                task[num].color = task[num + 1].color;
            }
            return false;
        }

        /// <summary>
        /// 実績を開く
        /// </summary>
        /// <param name="achieve_num"></param>
        private void OpenAchieve(int achieve_num)
        {
            if (achieve_num == -1)
            {
                this.menuachieve_table1_text.Text = "";
                this.menuachieve_table2_text.Text = "";
                this.menuachieve_table3_text.Text = "";
                this.menuachieve_table4_text.Text = "";
            }
            else
            {
                this.menuachieve_table1_text.Text = achieve[achieve_num].name;
                this.menuachieve_table2_text.Text = achieve[achieve_num].progress.ToString();
                this.menuachieve_table3_text.Text = achieve[achieve_num].hour.ToString();
                this.menuachieve_table4_text.Text = achieve[achieve_num].memo;
            }
            this.menutask.Visible = false;
            this.menuachieve.Visible = true;
        }

        private void AddAchieve(int num)
        {

        }

        private Boolean RemoveAchieve(int num)
        {
            for (int i=num; i<49; i++)
            {
                achieve[num].name = achieve[num+1].name;
                achieve[num].progress = achieve[num + 1].progress;
                achieve[num].hour = achieve[num + 1].hour;
                achieve[num].memo = achieve[num + 1].memo;
            }
            return false;
        }

        // menu2 panel2 のメモのサイズ変更イベント定義
        private void SetSizeChanger()
        {
            menu2_2_panel_main_table_memo1_sizeChanger = new DAndDSizeChanger(this.menu2_2_panel_main_panel1_table_memo_text, this.menu2_2_panel_main_panel1, DAndDArea.Bottom, 12, this.menu2_2);
            menu2_2_panel_main_table_memo2_sizeChanger = new DAndDSizeChanger(this.menu2_2_panel_main_panel2_table_memo_text, this.menu2_2_panel_main_panel2, DAndDArea.Bottom, 12, this.menu2_2);
            menu2_2_panel_main_table_memo3_sizeChanger = new DAndDSizeChanger(this.menu2_2_panel_main_panel3_table_memo_text, this.menu2_2_panel_main_panel3, DAndDArea.Bottom, 12, this.menu2_2);
            menu2_2_panel_main_table_memo4_sizeChanger = new DAndDSizeChanger(this.menu2_2_panel_main_panel4_table_memo_text, this.menu2_2_panel_main_panel4, DAndDArea.Bottom, 12, this.menu2_2);
            menu2_2_panel_main_table_memo5_sizeChanger = new DAndDSizeChanger(this.menu2_2_panel_main_panel5_table_memo_text, this.menu2_2_panel_main_panel5, DAndDArea.Bottom, 12, this.menu2_2);
            this_sizeChanger = new DAndDSizeChanger(this, this, DAndDArea.All, 24);
        }

        // menu2の要素順を反映する
        private void RefrectMoveControl()
        {
            this.menu2.Controls.Remove(this.menu2_1);
            this.menu2.Controls.Remove(this.menu2_2);
            this.menu2.Controls.Remove(this.menu2_3);

            switch (setting.order)
            {
                case 123:
                    this.menu2.Controls.Add(this.menu2_3);
                    this.menu2.Controls.Add(this.menu2_2);
                    this.menu2.Controls.Add(this.menu2_1);
                    break;
                case 132:
                    this.menu2.Controls.Add(this.menu2_2);
                    this.menu2.Controls.Add(this.menu2_3);
                    this.menu2.Controls.Add(this.menu2_1);
                    break;
                case 213:
                    this.menu2.Controls.Add(this.menu2_3);
                    this.menu2.Controls.Add(this.menu2_1);
                    this.menu2.Controls.Add(this.menu2_2);
                    break;
                case 231:
                    this.menu2.Controls.Add(this.menu2_1);
                    this.menu2.Controls.Add(this.menu2_3);
                    this.menu2.Controls.Add(this.menu2_2);
                    break;
                case 312:
                    this.menu2.Controls.Add(this.menu2_2);
                    this.menu2.Controls.Add(this.menu2_1);
                    this.menu2.Controls.Add(this.menu2_3);
                    break;
                case 321:
                    this.menu2.Controls.Add(this.menu2_1);
                    this.menu2.Controls.Add(this.menu2_2);
                    this.menu2.Controls.Add(this.menu2_3);
                    break;
            }
        }


        // メモを保存する時の関数
        private Boolean SaveMemo(string path, string text)
        {
            FileUtil fu = new FileUtil();
            if (path == "")
            {
                
            }
            else
            {
                fu.WriteFileLine(path, text, false, true);
            }

            return true;
        }










        #endregion menu2
        /* 
        * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        * menu2 end
        * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□ 
        */

        /*
         * ☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆
         * price
         * ☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆
         */
    }
}
