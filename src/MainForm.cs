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

        private int menu = 1; //閲覧中のメニュー

        DAndDSizeChanger menu2_2_panel_main_table_memo1_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo2_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo3_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo4_sizeChanger;
        DAndDSizeChanger menu2_2_panel_main_table_memo5_sizeChanger;
        DAndDSizeChanger this_sizeChanger;
        control_lib.DAndDMoveForm common_MoveForm;

        static readonly Color dark = Color.FromArgb(40, 40, 40); //ダークモード 基本色
        static readonly Color white = Color.FromArgb(240, 240, 240); //ライトモード 基本色
        static readonly Color subdark = Color.FromArgb(80, 80, 80); //ダークモード サブ色
        static readonly Color subwhite = Color.FromArgb(220, 220, 220); //ライトモード サブ色
        Color main_color = dark;
        Color sub_color = white;
        Color submain_color = subdark;
        Color subsub_color = subwhite;

        public int clickpanel = -1; //カレンダーでクリックされたパネル

        // コンストラクタ
        public MainForm()
        {
            // コントロールの初期設定
            InitializeComponent();
            // フォームロード時の設定
            MainForm_Load();
        }

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
            //InitAchieve();
            // commonをタイトルバー化する
            SetMoveForm();
            // 設定を反映
            RefrectSetting();
            // メニュー切り替え
            ChangeMenu(menu);
            // 表示モード切り替え
            ChangeDarkMode(Properties.Settings.Default.common_mode);
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
            if (Properties.Settings.Default.common_mode)
            {
                this.common_panel_setting_table_check1.Checked = true;
            }
            else
            {
                this.common_panel_setting_table_check1.Checked = false;
            }

            // メモ文字サイズ
            if (Properties.Settings.Default.menu2_fontsize != 0)
            {

            }
            else
            {

            }

            // メモ折り返し
            if (Properties.Settings.Default.menu2_memowrap)
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
            if (Properties.Settings.Default.menu2_open1)
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
            if (Properties.Settings.Default.menu2_open2)
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
            if (Properties.Settings.Default.menu2_open3)
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
            if (Properties.Settings.Default.form_x != 0)
            {
                this.Width = Properties.Settings.Default.form_x;
            }
            else
            {
            }

            // フォームサイズ y
            if (Properties.Settings.Default.form_y != 0)
            {
                this.Height = Properties.Settings.Default.form_y;
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
            common_MoveForm = new control_lib.DAndDMoveForm(this.common, this);
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


        // タスクの初期化
        private Task[] task = new Task[50];

        private void Inittask()
        {
            for (int i = 0; i < 50; i++)
            {
                task[i] = new Task("", false, DateTime.Now, DateTime.Now, "", 0);
            }
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

        #endregion menu2
        /*
        * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        * menu2 end
        * □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        */

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
        private void menu2_2_panel_main_panel1_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel1_table_memo_text_KeyDown(this, e);
        }
        private void menu2_2_panel_main_panel2_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel2_table_memo_text_KeyDown(this, e);
        }
        private void menu2_2_panel_main_panel3_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel3_table_memo_text_KeyDown(this, e);
        }
        private void menu2_2_panel_main_panel4_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel4_table_memo_text_KeyDown(this, e);
        }
        private void menu2_2_panel_main_panel5_table_memo_text_KeyDown(object sender, KeyEventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel5_table_memo_text_KeyDown(this, e);
        }
        private void menu2_2_panel_main_panel1_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel1_table_memo_panel_top_button_save_Click(this);
        }
        private void menu2_2_panel_main_panel2_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel2_table_memo_panel_top_button_save_Click(this);
        }
        private void menu2_2_panel_main_panel3_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel3_table_memo_panel_top_button_save_Click(this);
        }
        private void menu2_2_panel_main_panel4_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel4_table_memo_panel_top_button_save_Click(this);
        }
        private void menu2_2_panel_main_panel5_table_memo_panel_top_button_save_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel5_table_memo_panel_top_button_save_Click(this);
        }
        private void menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax_Click(this);
        }
        private void menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax_Click(this);
        }
        private void menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax_Click(this);
        }
        private void menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel4_table_memo_panel_top_button_save_Click(this);
        }
        private void menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax_Click(this);
        }
        private void menu2_2_panel_main_panel1_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel1_table_memo_panel_top_button_close_Click(this);
        }
        private void menu2_2_panel_main_panel2_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel2_table_memo_panel_top_button_close_Click(this);
        }
        private void menu2_2_panel_main_panel3_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel3_table_memo_panel_top_button_close_Click(this);
        }
        private void menu2_2_panel_main_panel4_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel4_table_memo_panel_top_button_close_Click(this);
        }
        private void menu2_2_panel_main_panel5_table_memo_panel_top_button_close_Click(object sender, EventArgs e)
        {
            controls_event.menu2_2_events.menu2_2_panel_main_panel5_table_memo_panel_top_button_close_Click(this);
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
    }
}
