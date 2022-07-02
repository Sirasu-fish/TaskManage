using System.Windows.Forms;
using System.Drawing;
using System;

namespace TaskManage
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // ■■■■■■■■■■■■■■■■■■■■■　common　■■■■■■■■■■■■■■■■■■■■■
        public PanelEx common;
        public Button common_button_close;
        public Button common_button_max;
        public Button common_button_min;
        public Button common_button_nextmenu;
        public Button common_button_prevmenu;
        public Button common_button_setting;
        public Panel common_panel_setting;
        public CheckBox common_panel_setting_table_check1;
        public CheckBox common_panel_setting_table_check3;
        public ComboBox common_panel_setting_table_combo2;
        public Label common_panel_setting_table_label1;
        public Label common_panel_setting_table_label2;
        public Label common_panel_setting_table_label3;
        public TableLayoutPanel common_panel_setting_table_setting;

        // ■■■■■■■■■■■■■■■■■■■■■　menu1　■■■■■■■■■■■■■■■■■■■■■
        public PanelEx menu1;
        public Panel menu1_panel_calendertop;
        public Button menu1_panel_calendertop_button_nextmonth;
        public Button menu1_panel_calendertop_button_onoff;
        public Button menu1_panel_calendertop_button_prevmonth;
        public Panel menu1_panel_calendertop_panel_yearmonth;
        public ComboBox menu1_panel_calendertop_panel_yearmonth_combo_month;
        public ComboBox menu1_panel_calendertop_panel_yearmonth_combo_year;
        public Label menu1_panel_calendertop_panel_yearmonth_label_month;
        public Label menu1_panel_calendertop_panel_yearmonth_label_year;
        public TableLayoutPanel menu1_table_calender;

        public Panel[] menu1_table_calender_panel_day;
        public Label[] menu1_table_calender_label_day;

        public Label menu1_table_calender_label_friday;
        public Label menu1_table_calender_label_monday;
        public Label menu1_table_calender_label_saturday;
        public Label menu1_table_calender_label_sunday;
        public Label menu1_table_calender_label_thursday;
        public Label menu1_table_calender_label_tuesday;
        public Label menu1_table_calender_label_wednesday;

        // ■■■■■■■■■■■■■■■■■■■■■　menu2　■■■■■■■■■■■■■■■■■■■■■
        public Panel menu2;
        public Panel menu2_1;
        public PanelEx menu2_1_panel;
        public Panel menu2_1_panel_main;

        public PanelEx[] menu2_1_panel_main_panel;
        public Button[] menu2_1_panel_main_panel_button_delete;
        public Button[] menu2_1_panel_main_panel_button_finish;
        public Label[] menu2_1_panel_main_panel_label1;
        public Label[] menu2_1_panel_main_panel_label2;

        public Panel menu2_1_panel_margin;
        public Panel menu2_1_panel_top;
        public Button menu2_1_panel_top_button_add;
        public Button menu2_1_panel_top_button_movedown;
        public Button menu2_1_panel_top_button_moveup;
        public Button menu2_1_panel_top_button_openclose;
        public Circlelabel menu2_1_panel_top_label_num;
        public Label menu2_1_panel_top_label_title;

        public Panel menu2_2;
        public PanelEx menu2_2_panel;
        public Panel menu2_2_panel_main;

        public Panel[] menu2_2_panel_main_panel;
        public TableLayoutPanel[] menu2_2_panel_main_panel_table_memo;
        public TextBox[] menu2_2_panel_main_panel_table_memo_text;
        public Panel[] menu2_2_panel_main_panel_table_memo_panel_top;
        public Button[] menu2_2_panel_main_panel_table_memo_panel_top_button_close;
        public Button[] menu2_2_panel_main_panel_table_memo_panel_top_button_minmax;
        public Button[] menu2_2_panel_main_panel_table_memo_panel_top_button_save;
        public TextBox[] menu2_2_panel_main_panel_table_memo_panel_top_text;

        public Panel menu2_2_panel_top;
        public Button menu2_2_panel_top_button_add;
        public Button menu2_2_panel_top_button_movedown;
        public Button menu2_2_panel_top_button_moveup;
        public Button menu2_2_panel_top_button_open;
        public Button menu2_2_panel_top_button_openclose;
        public Circlelabel menu2_2_panel_top_label_num;
        public Label menu2_2_panel_top_label_title;

        public Panel menu2_3;
        public PanelEx menu2_3_panel;
        public Panel menu2_3_panel_main;
        public PanelEx menu2_3_panel_main_panel1;
        public Button menu2_3_panel_main_panel1_button_delete;
        public Label menu2_3_panel_main_panel1_label1;
        public PanelEx menu2_3_panel_main_panel10;
        public Button menu2_3_panel_main_panel10_button_delete;
        public Label menu2_3_panel_main_panel10_label1;
        public PanelEx menu2_3_panel_main_panel11;
        public Button menu2_3_panel_main_panel11_button_delete;
        public Label menu2_3_panel_main_panel11_label1;
        public PanelEx menu2_3_panel_main_panel12;
        public Button menu2_3_panel_main_panel12_button_delete;
        public Label menu2_3_panel_main_panel12_label1;
        public PanelEx menu2_3_panel_main_panel13;
        public Button menu2_3_panel_main_panel13_button_delete;
        public Label menu2_3_panel_main_panel13_label1;
        public PanelEx menu2_3_panel_main_panel14;
        public Button menu2_3_panel_main_panel14_button_delete;
        public Label menu2_3_panel_main_panel14_label1;
        public PanelEx menu2_3_panel_main_panel15;
        public Button menu2_3_panel_main_panel15_button_delete;
        public Label menu2_3_panel_main_panel15_label1;
        public PanelEx menu2_3_panel_main_panel16;
        public Button menu2_3_panel_main_panel16_button_delete;
        public Label menu2_3_panel_main_panel16_label1;
        public PanelEx menu2_3_panel_main_panel17;
        public Button menu2_3_panel_main_panel17_button_delete;
        public Label menu2_3_panel_main_panel17_label1;
        public PanelEx menu2_3_panel_main_panel18;
        public Button menu2_3_panel_main_panel18_button_delete;
        public Label menu2_3_panel_main_panel18_label1;
        public PanelEx menu2_3_panel_main_panel19;
        public Button menu2_3_panel_main_panel19_button_delete;
        public Label menu2_3_panel_main_panel19_label1;
        public PanelEx menu2_3_panel_main_panel2;
        public Button menu2_3_panel_main_panel2_button_delete;
        public Label menu2_3_panel_main_panel2_label1;
        public PanelEx menu2_3_panel_main_panel20;
        public Button menu2_3_panel_main_panel20_button_delete;
        public Label menu2_3_panel_main_panel20_label1;
        public PanelEx menu2_3_panel_main_panel21;
        public Button menu2_3_panel_main_panel21_button_delete;
        public Label menu2_3_panel_main_panel21_label1;
        public PanelEx menu2_3_panel_main_panel22;
        public Button menu2_3_panel_main_panel22_button_delete;
        public Label menu2_3_panel_main_panel22_label1;
        public PanelEx menu2_3_panel_main_panel23;
        public Button menu2_3_panel_main_panel23_button_delete;
        public Label menu2_3_panel_main_panel23_label1;
        public PanelEx menu2_3_panel_main_panel24;
        public Button menu2_3_panel_main_panel24_button_delete;
        public Label menu2_3_panel_main_panel24_label1;
        public PanelEx menu2_3_panel_main_panel25;
        public Button menu2_3_panel_main_panel25_button_delete;
        public Label menu2_3_panel_main_panel25_label1;
        public PanelEx menu2_3_panel_main_panel3;
        public Button menu2_3_panel_main_panel3_button_delete;
        public Label menu2_3_panel_main_panel3_label1;
        public PanelEx menu2_3_panel_main_panel4;
        public Button menu2_3_panel_main_panel4_button_delete;
        public Label menu2_3_panel_main_panel4_label1;
        public PanelEx menu2_3_panel_main_panel5;
        public Button menu2_3_panel_main_panel5_button_delete;
        public Label menu2_3_panel_main_panel5_label1;
        public PanelEx menu2_3_panel_main_panel6;
        public Button menu2_3_panel_main_panel6_button_delete;
        public Label menu2_3_panel_main_panel6_label1;
        public PanelEx menu2_3_panel_main_panel7;
        public Button menu2_3_panel_main_panel7_button_delete;
        public Label menu2_3_panel_main_panel7_label1;
        public PanelEx menu2_3_panel_main_panel8;
        public Button menu2_3_panel_main_panel8_button_delete;
        public Label menu2_3_panel_main_panel8_label1;
        public PanelEx menu2_3_panel_main_panel9;
        public Button menu2_3_panel_main_panel9_button_delete;
        public Label menu2_3_panel_main_panel9_label1;
        public Panel menu2_3_panel_top;
        public Button menu2_3_panel_top_button_add;
        public Button menu2_3_panel_top_button_movedown;
        public Button menu2_3_panel_top_button_moveup;
        public Button menu2_3_panel_top_button_openclose;
        public Circlelabel menu2_3_panel_top_label_num;
        public Label menu2_3_panel_top_label_title;

        // ■■■■■■■■■■■■■■■■■■■■■　menuachieve　■■■■■■■■■■■■■■■■■■■■■
        public PanelEx menuachieve;
        public Button menuachieve_button_close;
        public Button menuachieve_button_save;
        public TableLayoutPanel menuachieve_table1;
        public Label menuachieve_table1_label;
        public TextBox menuachieve_table1_text;
        public TableLayoutPanel menuachieve_table2;
        public Label menuachieve_table2_label;
        public TextBox menuachieve_table2_text;
        public TableLayoutPanel menuachieve_table3;
        public TextBox menuachieve_table3_text;
        public Label menuachieve_table3_label;
        public TableLayoutPanel menuachieve_table4;
        public Label menuachieve_table4_label;
        public TextBox menuachieve_table4_text;

        // ■■■■■■■■■■■■■■■■■■■■■　menutask　■■■■■■■■■■■■■■■■■■■■■
        public PanelEx menutask;
        public Button menutask_button_close;
        public Button menutask_button_save;
        public TableLayoutPanel menutask_table1;
        public Label menutask_table1_label;
        public TextBox menutask_table1_text;
        public TableLayoutPanel menutask_table2;
        public CheckBox menutask_table2_check;
        public TableLayoutPanel menutask_table3;
        public Label menutask_table3_label;
        public TextBox menutask_table3_text;
        public TableLayoutPanel menutask_table4;
        public Label menutask_table4_label;

        // ■■■■■■■■■■■■■■■■■■■■■　menu3　■■■■■■■■■■■■■■■■■■■■■
        public Panel menu3;
        public Panel menu3_panel_main;
        public Panel menu3_panel_top;
        public Button menu3_panel_top_button_100;
        public Button menu3_panel_top_button_nextweek;
        public Button menu3_panel_top_button_prevweek;
        public Label menu3_panel_top_label_title;

        // ■■■■■■■■■■■■■■■■■■■■■　other　■■■■■■■■■■■■■■■■■■■■■ 
        public ToolTip tooltip;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.common = new TaskManage.PanelEx();
            this.common_button_prevmenu = new System.Windows.Forms.Button();
            this.common_button_setting = new System.Windows.Forms.Button();
            this.common_button_nextmenu = new System.Windows.Forms.Button();
            this.menu1_panel_calendertop = new System.Windows.Forms.Panel();
            this.menu1_panel_calendertop_button_onoff = new System.Windows.Forms.Button();
            this.menu1_panel_calendertop_panel_yearmonth = new System.Windows.Forms.Panel();
            this.menu1_panel_calendertop_panel_yearmonth_combo_year = new System.Windows.Forms.ComboBox();
            this.menu1_panel_calendertop_panel_yearmonth_label_month = new System.Windows.Forms.Label();
            this.menu1_panel_calendertop_panel_yearmonth_combo_month = new System.Windows.Forms.ComboBox();
            this.menu1_panel_calendertop_panel_yearmonth_label_year = new System.Windows.Forms.Label();
            this.menu1_panel_calendertop_button_nextmonth = new System.Windows.Forms.Button();
            this.menu1_panel_calendertop_button_prevmonth = new System.Windows.Forms.Button();
            this.common_panel_setting = new System.Windows.Forms.Panel();
            this.common_panel_setting_table_setting = new System.Windows.Forms.TableLayoutPanel();
            this.common_panel_setting_table_check1 = new System.Windows.Forms.CheckBox();
            this.common_panel_setting_table_combo2 = new System.Windows.Forms.ComboBox();
            this.common_panel_setting_table_check3 = new System.Windows.Forms.CheckBox();
            this.common_panel_setting_table_label3 = new System.Windows.Forms.Label();
            this.common_panel_setting_table_label1 = new System.Windows.Forms.Label();
            this.common_panel_setting_table_label2 = new System.Windows.Forms.Label();
            this.menu1 = new TaskManage.PanelEx();
            this.menu1_table_calender = new System.Windows.Forms.TableLayoutPanel();

            this.menu1_table_calender_panel_day = new System.Windows.Forms.Panel[42];
            this.menu1_table_calender_label_day = new System.Windows.Forms.Label[42];

            for (int i = menu1_table_calender_panel_day.Length - 1; i >= 0; i--)
            {
                this.menu1_table_calender_panel_day[i] = new System.Windows.Forms.Panel();
                this.menu1_table_calender_label_day[i] = new System.Windows.Forms.Label();
            }

            this.menu1_table_calender_label_sunday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_monday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_tuesday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_wednesday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_thursday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_friday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_saturday = new System.Windows.Forms.Label();

            this.menu2 = new System.Windows.Forms.Panel();
            this.menu2_3 = new System.Windows.Forms.Panel();
            this.menu2_3_panel = new TaskManage.PanelEx();
            this.menu2_3_panel_top = new System.Windows.Forms.Panel();
            this.menu2_3_panel_top_label_num = new TaskManage.Circlelabel();
            this.menu2_3_panel_top_button_movedown = new System.Windows.Forms.Button();
            this.menu2_3_panel_top_button_moveup = new System.Windows.Forms.Button();
            this.menu2_3_panel_top_label_title = new System.Windows.Forms.Label();
            this.menu2_3_panel_top_button_openclose = new System.Windows.Forms.Button();
            this.menu2_3_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu2_3_panel_main = new System.Windows.Forms.Panel();
            this.menu2_3_panel_main_panel25 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel25_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel25_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel24 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel24_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel24_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel23 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel23_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel23_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel22 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel22_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel22_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel21 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel21_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel21_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel20 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel20_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel20_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel19 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel19_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel19_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel18 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel18_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel18_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel17 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel17_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel17_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel16 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel16_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel16_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel15 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel15_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel15_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel14 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel14_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel14_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel13 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel13_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel13_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel12 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel12_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel12_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel11 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel11_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel11_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel10 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel10_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel10_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel9 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel9_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel9_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel8 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel8_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel8_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel7 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel7_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel7_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel6 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel6_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel6_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel5 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel5_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel5_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel4 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel4_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel4_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel3 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel3_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel3_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel2 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel2_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel2_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel1 = new TaskManage.PanelEx();
            this.menu2_3_panel_main_panel1_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel1_label1 = new System.Windows.Forms.Label();
            this.menu2_2 = new System.Windows.Forms.Panel();
            this.menu2_2_panel = new TaskManage.PanelEx();
            this.menu2_2_panel_top = new System.Windows.Forms.Panel();
            this.menu2_2_panel_top_button_open = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_label_num = new TaskManage.Circlelabel();
            this.menu2_2_panel_top_button_movedown = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_button_moveup = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_button_openclose = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_label_title = new System.Windows.Forms.Label();
            this.menu2_2_panel_main = new System.Windows.Forms.Panel();

            this.menu2_2_panel_main_panel = new System.Windows.Forms.Panel[99];
            this.menu2_2_panel_main_panel_table_memo = new System.Windows.Forms.TableLayoutPanel[99];
            this.menu2_2_panel_main_panel_table_memo_text = new System.Windows.Forms.TextBox[99];
            this.menu2_2_panel_main_panel_table_memo_panel_top = new System.Windows.Forms.Panel[99];
            this.menu2_2_panel_main_panel_table_memo_panel_top_text = new System.Windows.Forms.TextBox[99];
            this.menu2_2_panel_main_panel_table_memo_panel_top_button_save = new System.Windows.Forms.Button[99];
            this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax = new System.Windows.Forms.Button[99];
            this.menu2_2_panel_main_panel_table_memo_panel_top_button_close = new System.Windows.Forms.Button[99];

            for (int i = menu2_2_panel_main_panel.Length - 1; i >= 0 ; i--)
            {
                this.menu2_2_panel_main_panel[i] = new System.Windows.Forms.Panel();
                this.menu2_2_panel_main_panel_table_memo[i] = new System.Windows.Forms.TableLayoutPanel();
                this.menu2_2_panel_main_panel_table_memo_text[i] = new System.Windows.Forms.TextBox();
                this.menu2_2_panel_main_panel_table_memo_panel_top[i] = new System.Windows.Forms.Panel();
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i] = new System.Windows.Forms.TextBox();
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i] = new System.Windows.Forms.Button();
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i] = new System.Windows.Forms.Button();
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i] = new System.Windows.Forms.Button();
            }

            this.menu2_1 = new System.Windows.Forms.Panel();
            this.menu2_1_panel_margin = new System.Windows.Forms.Panel();
            this.menu2_1_panel = new TaskManage.PanelEx();
            this.menu2_1_panel_top = new System.Windows.Forms.Panel();
            this.menu2_1_panel_top_label_num = new TaskManage.Circlelabel();
            this.menu2_1_panel_top_button_movedown = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_button_moveup = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_label_title = new System.Windows.Forms.Label();
            this.menu2_1_panel_top_button_openclose = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu2_1_panel_main = new System.Windows.Forms.Panel();

            this.menu2_1_panel_main_panel = new TaskManage.PanelEx[99];
            this.menu2_1_panel_main_panel_label1 = new System.Windows.Forms.Label[99];
            this.menu2_1_panel_main_panel_button_finish = new System.Windows.Forms.Button[99];
            this.menu2_1_panel_main_panel_button_delete = new System.Windows.Forms.Button[99];
            this.menu2_1_panel_main_panel_label2 = new System.Windows.Forms.Label[99];

            for (int i = 0; i < menu2_1_panel_main_panel.Length; i++)
            {
                this.menu2_1_panel_main_panel[i] = new TaskManage.PanelEx();
                this.menu2_1_panel_main_panel_label1[i] = new System.Windows.Forms.Label();
                this.menu2_1_panel_main_panel_button_finish[i] = new System.Windows.Forms.Button();
                this.menu2_1_panel_main_panel_button_delete[i] = new System.Windows.Forms.Button();
                this.menu2_1_panel_main_panel_label2[i] = new System.Windows.Forms.Label();
            }

            this.menu3 = new System.Windows.Forms.Panel();
            this.menu3_panel_main = new System.Windows.Forms.Panel();
            this.menu3_panel_top = new System.Windows.Forms.Panel();
            this.menu3_panel_top_button_100 = new System.Windows.Forms.Button();
            this.menu3_panel_top_button_nextweek = new System.Windows.Forms.Button();
            this.menu3_panel_top_button_prevweek = new System.Windows.Forms.Button();
            this.menu3_panel_top_label_title = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.common_button_close = new System.Windows.Forms.Button();
            this.common_button_max = new System.Windows.Forms.Button();
            this.common_button_min = new System.Windows.Forms.Button();
            this.menutask = new TaskManage.PanelEx();
            this.menutask_button_close = new System.Windows.Forms.Button();
            this.menutask_table4 = new System.Windows.Forms.TableLayoutPanel();
            this.menutask_table4_label = new System.Windows.Forms.Label();
            this.menutask_table3 = new System.Windows.Forms.TableLayoutPanel();
            this.menutask_table3_label = new System.Windows.Forms.Label();
            this.menutask_table3_text = new System.Windows.Forms.TextBox();
            this.menutask_table2 = new System.Windows.Forms.TableLayoutPanel();
            this.menutask_table2_check = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.menutask_button_save = new System.Windows.Forms.Button();
            this.menutask_table1 = new System.Windows.Forms.TableLayoutPanel();
            this.menutask_table1_label = new System.Windows.Forms.Label();
            this.menutask_table1_text = new System.Windows.Forms.TextBox();
            this.menuachieve = new TaskManage.PanelEx();
            this.menuachieve_table4 = new System.Windows.Forms.TableLayoutPanel();
            this.menuachieve_table4_label = new System.Windows.Forms.Label();
            this.menuachieve_table4_text = new System.Windows.Forms.TextBox();
            this.menuachieve_button_close = new System.Windows.Forms.Button();
            this.menuachieve_table3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuachieve_table3_label = new System.Windows.Forms.Label();
            this.menuachieve_table3_text = new System.Windows.Forms.TextBox();
            this.menuachieve_table2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuachieve_table2_label = new System.Windows.Forms.Label();
            this.menuachieve_table2_text = new System.Windows.Forms.TextBox();
            this.menuachieve_table1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuachieve_table1_label = new System.Windows.Forms.Label();
            this.menuachieve_table1_text = new System.Windows.Forms.TextBox();
            this.menuachieve_button_save = new System.Windows.Forms.Button();
            this.common.SuspendLayout();
            this.menu1_panel_calendertop.SuspendLayout();
            this.menu1_panel_calendertop_panel_yearmonth.SuspendLayout();
            this.common_panel_setting.SuspendLayout();
            this.common_panel_setting_table_setting.SuspendLayout();
            this.menu1.SuspendLayout();
            this.menu1_table_calender.SuspendLayout();

            for (int i = 0; i < menu1_table_calender_panel_day.Length; i++)
            {
                this.menu1_table_calender_panel_day[i].SuspendLayout();
            }

            
            this.menu2.SuspendLayout();
            this.menu2_3.SuspendLayout();
            this.menu2_3_panel.SuspendLayout();
            this.menu2_3_panel_top.SuspendLayout();
            this.menu2_3_panel_main.SuspendLayout();
            this.menu2_3_panel_main_panel25.SuspendLayout();
            this.menu2_3_panel_main_panel24.SuspendLayout();
            this.menu2_3_panel_main_panel23.SuspendLayout();
            this.menu2_3_panel_main_panel22.SuspendLayout();
            this.menu2_3_panel_main_panel21.SuspendLayout();
            this.menu2_3_panel_main_panel20.SuspendLayout();
            this.menu2_3_panel_main_panel19.SuspendLayout();
            this.menu2_3_panel_main_panel18.SuspendLayout();
            this.menu2_3_panel_main_panel17.SuspendLayout();
            this.menu2_3_panel_main_panel16.SuspendLayout();
            this.menu2_3_panel_main_panel15.SuspendLayout();
            this.menu2_3_panel_main_panel14.SuspendLayout();
            this.menu2_3_panel_main_panel13.SuspendLayout();
            this.menu2_3_panel_main_panel12.SuspendLayout();
            this.menu2_3_panel_main_panel11.SuspendLayout();
            this.menu2_3_panel_main_panel10.SuspendLayout();
            this.menu2_3_panel_main_panel9.SuspendLayout();
            this.menu2_3_panel_main_panel8.SuspendLayout();
            this.menu2_3_panel_main_panel7.SuspendLayout();
            this.menu2_3_panel_main_panel6.SuspendLayout();
            this.menu2_3_panel_main_panel5.SuspendLayout();
            this.menu2_3_panel_main_panel4.SuspendLayout();
            this.menu2_3_panel_main_panel3.SuspendLayout();
            this.menu2_3_panel_main_panel2.SuspendLayout();
            this.menu2_3_panel_main_panel1.SuspendLayout();
            this.menu2_2.SuspendLayout();
            this.menu2_2_panel.SuspendLayout();
            this.menu2_2_panel_top.SuspendLayout();
            this.menu2_2_panel_main.SuspendLayout();
            this.menu2_1.SuspendLayout();
            this.menu2_1_panel.SuspendLayout();
            this.menu2_1_panel_top.SuspendLayout();
            this.menu2_1_panel_main.SuspendLayout();

            for (int i = 0; i < menu2_1_panel_main_panel.Length; i++)
            {
                this.menu2_1_panel_main_panel[i].SuspendLayout();
            }
            
            for (int i = 0; i < menu2_2_panel_main_panel.Length; i++)
            {
                this.menu2_2_panel_main_panel[i].SuspendLayout();
            }
            for (int i = 0; i < menu2_2_panel_main_panel_table_memo.Length; i++)
            {
                this.menu2_2_panel_main_panel_table_memo[i].SuspendLayout();
            }
            for (int i = 0; i < menu2_2_panel_main_panel_table_memo_panel_top.Length; i++)
            {
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].SuspendLayout();
            }

            this.menu3.SuspendLayout();
            this.menu3_panel_top.SuspendLayout();
            this.menutask.SuspendLayout();
            this.menutask_table4.SuspendLayout();
            this.menutask_table3.SuspendLayout();
            this.menutask_table2.SuspendLayout();
            this.menutask_table1.SuspendLayout();
            this.menuachieve.SuspendLayout();
            this.menuachieve_table4.SuspendLayout();
            this.menuachieve_table3.SuspendLayout();
            this.menuachieve_table2.SuspendLayout();
            this.menuachieve_table1.SuspendLayout();
            this.SuspendLayout();
            // 
            // common
            // 
            this.common.BorderColor = System.Drawing.Color.Black;
            this.common.Controls.Add(this.common_button_prevmenu);
            this.common.Controls.Add(this.common_button_setting);
            this.common.Controls.Add(this.common_button_nextmenu);
            this.common.Dock = System.Windows.Forms.DockStyle.Top;
            this.common.Location = new System.Drawing.Point(0, 0);
            this.common.Margin = new System.Windows.Forms.Padding(0);
            this.common.Name = "common";
            this.common.Size = new System.Drawing.Size(682, 34);
            this.common.TabIndex = 0;
            this.common.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.common_MouseDoubleClick);
            // 
            // common_button_prevmenu
            // 
            this.common_button_prevmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.common_button_prevmenu.BackColor = System.Drawing.Color.Transparent;
            this.common_button_prevmenu.FlatAppearance.BorderSize = 0;
            this.common_button_prevmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.common_button_prevmenu.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.common_button_prevmenu.Image = ((System.Drawing.Image)(resources.GetObject("common_button_prevmenu.Image")));
            this.common_button_prevmenu.Location = new System.Drawing.Point(471, 1);
            this.common_button_prevmenu.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_prevmenu.Name = "common_button_prevmenu";
            this.common_button_prevmenu.Size = new System.Drawing.Size(42, 32);
            this.common_button_prevmenu.TabIndex = 2;
            this.tooltip.SetToolTip(this.common_button_prevmenu, "前のメニューに移動");
            this.common_button_prevmenu.UseVisualStyleBackColor = false;
            this.common_button_prevmenu.Click += new System.EventHandler(this.common_button_prevmenu_Click);
            // 
            // common_button_setting
            // 
            this.common_button_setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("common_button_setting.BackgroundImage")));
            this.common_button_setting.FlatAppearance.BorderSize = 0;
            this.common_button_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.common_button_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.common_button_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.common_button_setting.Location = new System.Drawing.Point(1, 1);
            this.common_button_setting.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_setting.Name = "common_button_setting";
            this.common_button_setting.Size = new System.Drawing.Size(32, 32);
            this.common_button_setting.TabIndex = 1;
            this.tooltip.SetToolTip(this.common_button_setting, "設定");
            this.common_button_setting.UseVisualStyleBackColor = true;
            this.common_button_setting.Click += new System.EventHandler(this.common_button_setting_Click);
            // 
            // common_button_nextmenu
            // 
            this.common_button_nextmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.common_button_nextmenu.BackColor = System.Drawing.Color.Transparent;
            this.common_button_nextmenu.FlatAppearance.BorderSize = 0;
            this.common_button_nextmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.common_button_nextmenu.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.common_button_nextmenu.Image = ((System.Drawing.Image)(resources.GetObject("common_button_nextmenu.Image")));
            this.common_button_nextmenu.Location = new System.Drawing.Point(513, 1);
            this.common_button_nextmenu.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_nextmenu.Name = "common_button_nextmenu";
            this.common_button_nextmenu.Size = new System.Drawing.Size(42, 32);
            this.common_button_nextmenu.TabIndex = 0;
            this.tooltip.SetToolTip(this.common_button_nextmenu, "次のメニューに移動");
            this.common_button_nextmenu.UseVisualStyleBackColor = false;
            this.common_button_nextmenu.Click += new System.EventHandler(this.common_button_nextmenu_Click);
            // 
            // menu1_panel_calendertop
            // 
            this.menu1_panel_calendertop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_calendertop.Controls.Add(this.menu1_panel_calendertop_button_onoff);
            this.menu1_panel_calendertop.Controls.Add(this.menu1_panel_calendertop_panel_yearmonth);
            this.menu1_panel_calendertop.Controls.Add(this.menu1_panel_calendertop_button_nextmonth);
            this.menu1_panel_calendertop.Controls.Add(this.menu1_panel_calendertop_button_prevmonth);
            this.menu1_panel_calendertop.Location = new System.Drawing.Point(1, 1);
            this.menu1_panel_calendertop.Name = "menu1_panel_calendertop";
            this.menu1_panel_calendertop.Size = new System.Drawing.Size(680, 37);
            this.menu1_panel_calendertop.TabIndex = 0;
            // 
            // menu1_panel_calendertop_button_onoff
            // 
            this.menu1_panel_calendertop_button_onoff.Location = new System.Drawing.Point(3, 3);
            this.menu1_panel_calendertop_button_onoff.Name = "menu1_panel_calendertop_button_onoff";
            this.menu1_panel_calendertop_button_onoff.Size = new System.Drawing.Size(52, 31);
            this.menu1_panel_calendertop_button_onoff.TabIndex = 2;
            this.menu1_panel_calendertop_button_onoff.Text = "on/off";
            this.menu1_panel_calendertop_button_onoff.UseVisualStyleBackColor = true;
            // 
            // menu1_panel_calendertop_panel_yearmonth
            // 
            this.menu1_panel_calendertop_panel_yearmonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_panel_calendertop_panel_yearmonth.Controls.Add(this.menu1_panel_calendertop_panel_yearmonth_combo_year);
            this.menu1_panel_calendertop_panel_yearmonth.Controls.Add(this.menu1_panel_calendertop_panel_yearmonth_label_month);
            this.menu1_panel_calendertop_panel_yearmonth.Controls.Add(this.menu1_panel_calendertop_panel_yearmonth_combo_month);
            this.menu1_panel_calendertop_panel_yearmonth.Controls.Add(this.menu1_panel_calendertop_panel_yearmonth_label_year);
            this.menu1_panel_calendertop_panel_yearmonth.Location = new System.Drawing.Point(248, 0);
            this.menu1_panel_calendertop_panel_yearmonth.Name = "menu1_panel_calendertop_panel_yearmonth";
            this.menu1_panel_calendertop_panel_yearmonth.Size = new System.Drawing.Size(162, 36);
            this.menu1_panel_calendertop_panel_yearmonth.TabIndex = 6;
            // 
            // menu1_panel_calendertop_panel_yearmonth_combo_year
            // 
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.FormattingEnabled = true;
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.Location = new System.Drawing.Point(0, 1);
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.Name = "menu1_panel_calendertop_panel_yearmonth_combo_year";
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.Size = new System.Drawing.Size(55, 23);
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.TabIndex = 5;
            this.menu1_panel_calendertop_panel_yearmonth_combo_year.SelectedIndexChanged += new System.EventHandler(this.menu1_panel_calendertop_panel_yearmonth_combo_year_SelectedIndexChanged);
            // 
            // menu1_panel_calendertop_panel_yearmonth_label_month
            // 
            this.menu1_panel_calendertop_panel_yearmonth_label_month.AutoSize = true;
            this.menu1_panel_calendertop_panel_yearmonth_label_month.Location = new System.Drawing.Point(125, 9);
            this.menu1_panel_calendertop_panel_yearmonth_label_month.Name = "menu1_panel_calendertop_panel_yearmonth_label_month";
            this.menu1_panel_calendertop_panel_yearmonth_label_month.Size = new System.Drawing.Size(19, 15);
            this.menu1_panel_calendertop_panel_yearmonth_label_month.TabIndex = 5;
            this.menu1_panel_calendertop_panel_yearmonth_label_month.Text = "月";
            // 
            // menu1_panel_calendertop_panel_yearmonth_combo_month
            // 
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.FormattingEnabled = true;
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.Location = new System.Drawing.Point(76, 3);
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.Name = "menu1_panel_calendertop_panel_yearmonth_combo_month";
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.Size = new System.Drawing.Size(43, 29);
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.TabIndex = 4;
            this.menu1_panel_calendertop_panel_yearmonth_combo_month.SelectedIndexChanged += new System.EventHandler(this.menu1_panel_calendertop_panel_yearmonth_combo_month_SelectedIndexChanged);
            // 
            // menu1_panel_calendertop_panel_yearmonth_label_year
            // 
            this.menu1_panel_calendertop_panel_yearmonth_label_year.AutoSize = true;
            this.menu1_panel_calendertop_panel_yearmonth_label_year.Location = new System.Drawing.Point(60, 1);
            this.menu1_panel_calendertop_panel_yearmonth_label_year.Name = "menu1_panel_calendertop_panel_yearmonth_label_year";
            this.menu1_panel_calendertop_panel_yearmonth_label_year.Size = new System.Drawing.Size(19, 15);
            this.menu1_panel_calendertop_panel_yearmonth_label_year.TabIndex = 0;
            this.menu1_panel_calendertop_panel_yearmonth_label_year.Text = "年";
            // 
            // menu1_panel_calendertop_button_nextmonth
            // 
            this.menu1_panel_calendertop_button_nextmonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_calendertop_button_nextmonth.FlatAppearance.BorderSize = 0;
            this.menu1_panel_calendertop_button_nextmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu1_panel_calendertop_button_nextmonth.Image = ((System.Drawing.Image)(resources.GetObject("menu1_panel_calendertop_button_nextmonth.Image")));
            this.menu1_panel_calendertop_button_nextmonth.Location = new System.Drawing.Point(644, 1);
            this.menu1_panel_calendertop_button_nextmonth.Name = "menu1_panel_calendertop_button_nextmonth";
            this.menu1_panel_calendertop_button_nextmonth.Size = new System.Drawing.Size(36, 36);
            this.menu1_panel_calendertop_button_nextmonth.TabIndex = 3;
            this.tooltip.SetToolTip(this.menu1_panel_calendertop_button_nextmonth, "次の月を表示");
            this.menu1_panel_calendertop_button_nextmonth.UseVisualStyleBackColor = true;
            this.menu1_panel_calendertop_button_nextmonth.Click += new System.EventHandler(this.menu1_panel_calendertop_button_nextmonth_Click);
            // 
            // menu1_panel_calendertop_button_prevmonth
            // 
            this.menu1_panel_calendertop_button_prevmonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_calendertop_button_prevmonth.FlatAppearance.BorderSize = 0;
            this.menu1_panel_calendertop_button_prevmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu1_panel_calendertop_button_prevmonth.Image = ((System.Drawing.Image)(resources.GetObject("menu1_panel_calendertop_button_prevmonth.Image")));
            this.menu1_panel_calendertop_button_prevmonth.Location = new System.Drawing.Point(608, 1);
            this.menu1_panel_calendertop_button_prevmonth.Name = "menu1_panel_calendertop_button_prevmonth";
            this.menu1_panel_calendertop_button_prevmonth.Size = new System.Drawing.Size(36, 36);
            this.menu1_panel_calendertop_button_prevmonth.TabIndex = 2;
            this.tooltip.SetToolTip(this.menu1_panel_calendertop_button_prevmonth, "前の月を表示");
            this.menu1_panel_calendertop_button_prevmonth.UseVisualStyleBackColor = true;
            this.menu1_panel_calendertop_button_prevmonth.Click += new System.EventHandler(this.menu1_panel_calendertop_button_prevmonth_Click);
            // 
            // common_panel_setting
            // 
            this.common_panel_setting.BackColor = System.Drawing.Color.Transparent;
            this.common_panel_setting.Controls.Add(this.common_panel_setting_table_setting);
            this.common_panel_setting.Location = new System.Drawing.Point(3, 38);
            this.common_panel_setting.Name = "common_panel_setting";
            this.common_panel_setting.Size = new System.Drawing.Size(214, 96);
            this.common_panel_setting.TabIndex = 2;
            this.common_panel_setting.Visible = false;
            // 
            // common_panel_setting_table_setting
            // 
            this.common_panel_setting_table_setting.BackColor = System.Drawing.Color.Transparent;
            this.common_panel_setting_table_setting.ColumnCount = 2;
            this.common_panel_setting_table_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.common_panel_setting_table_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_check1, 1, 0);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_combo2, 1, 1);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_check3, 1, 2);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_label3, 0, 2);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_label1, 0, 0);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_label2, 0, 1);
            this.common_panel_setting_table_setting.Location = new System.Drawing.Point(4, 3);
            this.common_panel_setting_table_setting.Name = "common_panel_setting_table_setting";
            this.common_panel_setting_table_setting.RowCount = 3;
            this.common_panel_setting_table_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.common_panel_setting_table_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.common_panel_setting_table_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.common_panel_setting_table_setting.Size = new System.Drawing.Size(206, 90);
            this.common_panel_setting_table_setting.TabIndex = 2;
            // 
            // common_panel_setting_table_check1
            // 
            this.common_panel_setting_table_check1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.common_panel_setting_table_check1.AutoSize = true;
            this.common_panel_setting_table_check1.Location = new System.Drawing.Point(188, 8);
            this.common_panel_setting_table_check1.Name = "common_panel_setting_table_check1";
            this.common_panel_setting_table_check1.Size = new System.Drawing.Size(15, 14);
            this.common_panel_setting_table_check1.TabIndex = 3;
            this.common_panel_setting_table_check1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.common_panel_setting_table_check1.UseVisualStyleBackColor = true;
            this.common_panel_setting_table_check1.CheckedChanged += new System.EventHandler(this.common_panel_setting_table_check1_CheckedChanged);
            // 
            // common_panel_setting_table_combo2
            // 
            this.common_panel_setting_table_combo2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.common_panel_setting_table_combo2.FormattingEnabled = true;
            this.common_panel_setting_table_combo2.Location = new System.Drawing.Point(106, 33);
            this.common_panel_setting_table_combo2.Name = "common_panel_setting_table_combo2";
            this.common_panel_setting_table_combo2.Size = new System.Drawing.Size(97, 23);
            this.common_panel_setting_table_combo2.TabIndex = 4;
            // 
            // common_panel_setting_table_check3
            // 
            this.common_panel_setting_table_check3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.common_panel_setting_table_check3.AutoSize = true;
            this.common_panel_setting_table_check3.Location = new System.Drawing.Point(188, 68);
            this.common_panel_setting_table_check3.Name = "common_panel_setting_table_check3";
            this.common_panel_setting_table_check3.Size = new System.Drawing.Size(15, 14);
            this.common_panel_setting_table_check3.TabIndex = 6;
            this.common_panel_setting_table_check3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.common_panel_setting_table_check3.UseVisualStyleBackColor = true;
            // 
            // common_panel_setting_table_label3
            // 
            this.common_panel_setting_table_label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.common_panel_setting_table_label3.AutoSize = true;
            this.common_panel_setting_table_label3.Location = new System.Drawing.Point(3, 67);
            this.common_panel_setting_table_label3.Name = "common_panel_setting_table_label3";
            this.common_panel_setting_table_label3.Size = new System.Drawing.Size(71, 15);
            this.common_panel_setting_table_label3.TabIndex = 5;
            this.common_panel_setting_table_label3.Text = "右端折り返し";
            this.common_panel_setting_table_label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // common_panel_setting_table_label1
            // 
            this.common_panel_setting_table_label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.common_panel_setting_table_label1.AutoSize = true;
            this.common_panel_setting_table_label1.Location = new System.Drawing.Point(3, 7);
            this.common_panel_setting_table_label1.Name = "common_panel_setting_table_label1";
            this.common_panel_setting_table_label1.Size = new System.Drawing.Size(58, 15);
            this.common_panel_setting_table_label1.TabIndex = 0;
            this.common_panel_setting_table_label1.Text = "ダークモード";
            this.common_panel_setting_table_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // common_panel_setting_table_label2
            // 
            this.common_panel_setting_table_label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.common_panel_setting_table_label2.AutoSize = true;
            this.common_panel_setting_table_label2.Location = new System.Drawing.Point(3, 37);
            this.common_panel_setting_table_label2.Name = "common_panel_setting_table_label2";
            this.common_panel_setting_table_label2.Size = new System.Drawing.Size(86, 15);
            this.common_panel_setting_table_label2.TabIndex = 1;
            this.common_panel_setting_table_label2.Text = "メモの文字サイズ";
            this.common_panel_setting_table_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.Transparent;
            this.menu1.BorderColor = System.Drawing.Color.Black;
            this.menu1.Controls.Add(this.menu1_table_calender);
            this.menu1.Controls.Add(this.menu1_panel_calendertop);
            this.menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1.Location = new System.Drawing.Point(0, 34);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(682, 485);
            this.menu1.TabIndex = 1;
            // 
            // menu1_table_calender
            // 
            this.menu1_table_calender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender.ColumnCount = 7;
            for (int i = 1; i <= 7; i++)
            {
                this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            }

            for (int i = 0; i < menu1_table_calender_panel_day.Length; i++)
            {
                this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day[i], i % 7, i / 7 + 1);
            }
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_sunday, 0, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_monday, 1, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_tuesday, 2, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_wednesday, 3, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_thursday, 4, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_friday, 5, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_saturday, 6, 0);
            this.menu1_table_calender.ForeColor = System.Drawing.Color.Black;
            this.menu1_table_calender.Location = new System.Drawing.Point(11, 39);
            this.menu1_table_calender.Name = "menu1_table_calender";
            this.menu1_table_calender.RowCount = 7;
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            for (int i = 1; i <= 6; i++)
            {
                this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            }
            this.menu1_table_calender.Size = new System.Drawing.Size(658, 485);
            this.menu1_table_calender.TabIndex = 1;

            //
            // menu1_table_calender_panel_day
            //
            for (int i = 0; i < menu1_table_calender_panel_day.Length; i++)
            {
                this.menu1_table_calender_panel_day[i].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.menu1_table_calender_panel_day[i].BackColor = System.Drawing.Color.Transparent;
                this.menu1_table_calender_panel_day[i].Controls.Add(this.menu1_table_calender_label_day[i]);
                this.menu1_table_calender_panel_day[i].Location = new System.Drawing.Point(1 + 94 * (i % 7), 21 + (73 * (i / 7)));
                this.menu1_table_calender_panel_day[i].Margin = new System.Windows.Forms.Padding(1);
                this.menu1_table_calender_panel_day[i].Name = i.ToString();
                this.menu1_table_calender_panel_day[i].Size = new System.Drawing.Size(92, 61);
                this.menu1_table_calender_panel_day[i].TabIndex = 49;
                this.menu1_table_calender_panel_day[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day_MouseClick);
                this.menu1_table_calender_panel_day[i].MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day_DoubleClick);
                this.menu1_table_calender_panel_day[i].MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day_MouseEnter);
                this.menu1_table_calender_panel_day[i].MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day_MouseLeave);
            }
            //
            // menu1_table_calender_label_day
            //
            for (int i = 0; i < menu1_table_calender_label_day.Length; i++)
            {
                this.menu1_table_calender_label_day[i].Anchor = System.Windows.Forms.AnchorStyles.Top;
                this.menu1_table_calender_label_day[i].BackColor = System.Drawing.Color.Transparent;
                this.menu1_table_calender_label_day[i].Location = new System.Drawing.Point(6, 1);
                this.menu1_table_calender_label_day[i].Margin = new System.Windows.Forms.Padding(0);
                this.menu1_table_calender_label_day[i].MaximumSize = new System.Drawing.Size(78, 15);
                this.menu1_table_calender_label_day[i].Name = i.ToString();
                this.menu1_table_calender_label_day[i].Size = new System.Drawing.Size(78, 15);
                this.menu1_table_calender_label_day[i].TabIndex = 50;
                this.menu1_table_calender_label_day[i].TextAlign = System.Drawing.ContentAlignment.TopCenter;
                this.menu1_table_calender_label_day[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_label_day_MouseClick);
                this.menu1_table_calender_label_day[i].MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_label_day_DoubleClick);
                this.menu1_table_calender_label_day[i].MouseEnter += new System.EventHandler(this.menu1_table_calender_label_day_MouseEnter);
                this.menu1_table_calender_label_day[i].MouseLeave += new System.EventHandler(this.menu1_table_calender_label_day_MouseLeave);
            }
            // 
            // menu1_table_calender_label_sunday
            // 
            this.menu1_table_calender_label_sunday.AutoSize = true;
            this.menu1_table_calender_label_sunday.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_table_calender_label_sunday.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_table_calender_label_sunday.Location = new System.Drawing.Point(3, 0);
            this.menu1_table_calender_label_sunday.Name = "menu1_table_calender_label_sunday";
            this.menu1_table_calender_label_sunday.Size = new System.Drawing.Size(88, 13);
            this.menu1_table_calender_label_sunday.TabIndex = 3;
            this.menu1_table_calender_label_sunday.Text = "日";
            this.menu1_table_calender_label_sunday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu1_table_calender_label_monday
            // 
            this.menu1_table_calender_label_monday.AutoSize = true;
            this.menu1_table_calender_label_monday.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_table_calender_label_monday.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_table_calender_label_monday.Location = new System.Drawing.Point(97, 0);
            this.menu1_table_calender_label_monday.Name = "menu1_table_calender_label_monday";
            this.menu1_table_calender_label_monday.Size = new System.Drawing.Size(88, 13);
            this.menu1_table_calender_label_monday.TabIndex = 0;
            this.menu1_table_calender_label_monday.Text = "月";
            this.menu1_table_calender_label_monday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu1_table_calender_label_tuesday
            // 
            this.menu1_table_calender_label_tuesday.AutoSize = true;
            this.menu1_table_calender_label_tuesday.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_table_calender_label_tuesday.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_table_calender_label_tuesday.Location = new System.Drawing.Point(191, 0);
            this.menu1_table_calender_label_tuesday.Name = "menu1_table_calender_label_tuesday";
            this.menu1_table_calender_label_tuesday.Size = new System.Drawing.Size(88, 13);
            this.menu1_table_calender_label_tuesday.TabIndex = 1;
            this.menu1_table_calender_label_tuesday.Text = "火";
            this.menu1_table_calender_label_tuesday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu1_table_calender_label_wednesday
            // 
            this.menu1_table_calender_label_wednesday.AutoSize = true;
            this.menu1_table_calender_label_wednesday.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_table_calender_label_wednesday.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_table_calender_label_wednesday.Location = new System.Drawing.Point(285, 0);
            this.menu1_table_calender_label_wednesday.Name = "menu1_table_calender_label_wednesday";
            this.menu1_table_calender_label_wednesday.Size = new System.Drawing.Size(88, 13);
            this.menu1_table_calender_label_wednesday.TabIndex = 2;
            this.menu1_table_calender_label_wednesday.Text = "水";
            this.menu1_table_calender_label_wednesday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu1_table_calender_label_thursday
            // 
            this.menu1_table_calender_label_thursday.AutoSize = true;
            this.menu1_table_calender_label_thursday.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_table_calender_label_thursday.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_table_calender_label_thursday.Location = new System.Drawing.Point(379, 0);
            this.menu1_table_calender_label_thursday.Name = "menu1_table_calender_label_thursday";
            this.menu1_table_calender_label_thursday.Size = new System.Drawing.Size(88, 13);
            this.menu1_table_calender_label_thursday.TabIndex = 5;
            this.menu1_table_calender_label_thursday.Text = "木";
            this.menu1_table_calender_label_thursday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu1_table_calender_label_friday
            // 
            this.menu1_table_calender_label_friday.AutoSize = true;
            this.menu1_table_calender_label_friday.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_table_calender_label_friday.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_table_calender_label_friday.Location = new System.Drawing.Point(473, 0);
            this.menu1_table_calender_label_friday.Name = "menu1_table_calender_label_friday";
            this.menu1_table_calender_label_friday.Size = new System.Drawing.Size(88, 13);
            this.menu1_table_calender_label_friday.TabIndex = 4;
            this.menu1_table_calender_label_friday.Text = "金";
            this.menu1_table_calender_label_friday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu1_table_calender_label_saturday
            // 
            this.menu1_table_calender_label_saturday.AutoSize = true;
            this.menu1_table_calender_label_saturday.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_table_calender_label_saturday.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_table_calender_label_saturday.Location = new System.Drawing.Point(567, 0);
            this.menu1_table_calender_label_saturday.Name = "menu1_table_calender_label_saturday";
            this.menu1_table_calender_label_saturday.Size = new System.Drawing.Size(88, 13);
            this.menu1_table_calender_label_saturday.TabIndex = 6;
            this.menu1_table_calender_label_saturday.Text = "土";
            this.menu1_table_calender_label_saturday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // menu2
            // 
            this.menu2.AutoScroll = true;
            this.menu2.Controls.Add(this.menu2_3);
            this.menu2.Controls.Add(this.menu2_2);
            this.menu2.Controls.Add(this.menu2_1);
            this.menu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2.Location = new System.Drawing.Point(0, 519);
            this.menu2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(682, 771);
            this.menu2.TabIndex = 3;
            // 
            // menu2_3
            // 
            this.menu2_3.Controls.Add(this.menu2_3_panel);
            this.menu2_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_3.Location = new System.Drawing.Point(0, 1520);
            this.menu2_3.Name = "menu2_3";
            this.menu2_3.Size = new System.Drawing.Size(665, 942);
            this.menu2_3.TabIndex = 10;
            // 
            // menu2_3_panel
            // 
            this.menu2_3_panel.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel.Controls.Add(this.menu2_3_panel_top);
            this.menu2_3_panel.Controls.Add(this.menu2_3_panel_main);
            this.menu2_3_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_3_panel.Location = new System.Drawing.Point(0, 0);
            this.menu2_3_panel.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_3_panel.Name = "menu2_3_panel";
            this.menu2_3_panel.Size = new System.Drawing.Size(665, 1002);
            this.menu2_3_panel.TabIndex = 2;
            // 
            // menu2_3_panel_top
            // 
            this.menu2_3_panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_top.Controls.Add(this.menu2_3_panel_top_label_num);
            this.menu2_3_panel_top.Controls.Add(this.menu2_3_panel_top_button_movedown);
            this.menu2_3_panel_top.Controls.Add(this.menu2_3_panel_top_button_moveup);
            this.menu2_3_panel_top.Controls.Add(this.menu2_3_panel_top_label_title);
            this.menu2_3_panel_top.Controls.Add(this.menu2_3_panel_top_button_openclose);
            this.menu2_3_panel_top.Controls.Add(this.menu2_3_panel_top_button_add);
            this.menu2_3_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_top.Name = "menu2_3_panel_top";
            this.menu2_3_panel_top.Size = new System.Drawing.Size(663, 32);
            this.menu2_3_panel_top.TabIndex = 4;
            // 
            // menu2_3_panel_top_label_num
            // 
            this.menu2_3_panel_top_label_num.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_top_label_num.CustomText = "0";
            this.menu2_3_panel_top_label_num.Location = new System.Drawing.Point(46, 0);
            this.menu2_3_panel_top_label_num.Name = "menu2_3_panel_top_label_num";
            this.menu2_3_panel_top_label_num.Size = new System.Drawing.Size(20, 20);
            this.menu2_3_panel_top_label_num.TabIndex = 31;
            // 
            // menu2_3_panel_top_button_movedown
            // 
            this.menu2_3_panel_top_button_movedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_top_button_movedown.Location = new System.Drawing.Point(0, 16);
            this.menu2_3_panel_top_button_movedown.Name = "menu2_3_panel_top_button_movedown";
            this.menu2_3_panel_top_button_movedown.Size = new System.Drawing.Size(16, 16);
            this.menu2_3_panel_top_button_movedown.TabIndex = 30;
            this.tooltip.SetToolTip(this.menu2_3_panel_top_button_movedown, "下に移動");
            this.menu2_3_panel_top_button_movedown.UseVisualStyleBackColor = true;
            this.menu2_3_panel_top_button_movedown.Click += new System.EventHandler(this.menu2_3_panel_top_button_movedown_Click);
            // 
            // menu2_3_panel_top_button_moveup
            // 
            this.menu2_3_panel_top_button_moveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_top_button_moveup.Location = new System.Drawing.Point(0, 0);
            this.menu2_3_panel_top_button_moveup.Name = "menu2_3_panel_top_button_moveup";
            this.menu2_3_panel_top_button_moveup.Size = new System.Drawing.Size(16, 16);
            this.menu2_3_panel_top_button_moveup.TabIndex = 29;
            this.tooltip.SetToolTip(this.menu2_3_panel_top_button_moveup, "上に移動");
            this.menu2_3_panel_top_button_moveup.UseVisualStyleBackColor = true;
            this.menu2_3_panel_top_button_moveup.Click += new System.EventHandler(this.menu2_3_panel_top_button_moveup_Click);
            // 
            // menu2_3_panel_top_label_title
            // 
            this.menu2_3_panel_top_label_title.Location = new System.Drawing.Point(16, 0);
            this.menu2_3_panel_top_label_title.Name = "menu2_3_panel_top_label_title";
            this.menu2_3_panel_top_label_title.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_top_label_title.TabIndex = 0;
            this.menu2_3_panel_top_label_title.Text = "実績";
            this.menu2_3_panel_top_label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu2_3_panel_top_button_openclose
            // 
            this.menu2_3_panel_top_button_openclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu2_3_panel_top_button_openclose.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_top_button_openclose.FlatAppearance.BorderSize = 0;
            this.menu2_3_panel_top_button_openclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_top_button_openclose.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_3_panel_top_button_openclose.Location = new System.Drawing.Point(66, 0);
            this.menu2_3_panel_top_button_openclose.Name = "menu2_3_panel_top_button_openclose";
            this.menu2_3_panel_top_button_openclose.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_top_button_openclose.TabIndex = 3;
            this.menu2_3_panel_top_button_openclose.Text = "+";
            this.menu2_3_panel_top_button_openclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooltip.SetToolTip(this.menu2_3_panel_top_button_openclose, "開く/閉じる");
            this.menu2_3_panel_top_button_openclose.UseVisualStyleBackColor = false;
            this.menu2_3_panel_top_button_openclose.Click += new System.EventHandler(this.menu2_3_panel_top_button_openclose_Click);
            // 
            // menu2_3_panel_top_button_add
            // 
            this.menu2_3_panel_top_button_add.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_top_button_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_top_button_add.FlatAppearance.BorderSize = 0;
            this.menu2_3_panel_top_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_top_button_add.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_3_panel_top_button_add.Image = ((System.Drawing.Image)(resources.GetObject("menu2_3_panel_top_button_add.Image")));
            this.menu2_3_panel_top_button_add.Location = new System.Drawing.Point(631, 0);
            this.menu2_3_panel_top_button_add.Name = "menu2_3_panel_top_button_add";
            this.menu2_3_panel_top_button_add.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_top_button_add.TabIndex = 28;
            this.menu2_3_panel_top_button_add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooltip.SetToolTip(this.menu2_3_panel_top_button_add, "追加");
            this.menu2_3_panel_top_button_add.UseVisualStyleBackColor = false;
            this.menu2_3_panel_top_button_add.Click += new System.EventHandler(this.menu2_3_panel_top_button_add_Click);
            // 
            // menu2_3_panel_main
            // 
            this.menu2_3_panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel25);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel24);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel23);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel22);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel21);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel20);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel19);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel18);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel17);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel16);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel15);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel14);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel13);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel12);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel11);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel10);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel9);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel8);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel7);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel6);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel5);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel4);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel3);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel2);
            this.menu2_3_panel_main.Controls.Add(this.menu2_3_panel_main_panel1);
            this.menu2_3_panel_main.Location = new System.Drawing.Point(1, 33);
            this.menu2_3_panel_main.Name = "menu2_3_panel_main";
            this.menu2_3_panel_main.Size = new System.Drawing.Size(663, 968);
            this.menu2_3_panel_main.TabIndex = 29;
            // 
            // menu2_3_panel_main_panel25
            // 
            this.menu2_3_panel_main_panel25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel25.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel25.Controls.Add(this.menu2_3_panel_main_panel25_button_delete);
            this.menu2_3_panel_main_panel25.Controls.Add(this.menu2_3_panel_main_panel25_label1);
            this.menu2_3_panel_main_panel25.Location = new System.Drawing.Point(4, 864);
            this.menu2_3_panel_main_panel25.Name = "menu2_3_panel_main_panel25";
            this.menu2_3_panel_main_panel25.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel25.TabIndex = 27;
            this.menu2_3_panel_main_panel25.Click += new System.EventHandler(this.menu2_3_panel_main_panel25_Click);
            // 
            // menu2_3_panel_main_panel25_button_delete
            // 
            this.menu2_3_panel_main_panel25_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel25_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel25_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel25_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel25_button_delete.Name = "menu2_3_panel_main_panel25_button_delete";
            this.menu2_3_panel_main_panel25_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel25_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel25_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel25_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel25_button_delete_Click);
            // 
            // menu2_3_panel_main_panel25_label1
            // 
            this.menu2_3_panel_main_panel25_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel25_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel25_label1.Name = "menu2_3_panel_main_panel25_label1";
            this.menu2_3_panel_main_panel25_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel25_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel25_label1.Text = "label19";
            this.menu2_3_panel_main_panel25_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel25_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel25_label1_Click);
            // 
            // menu2_3_panel_main_panel24
            // 
            this.menu2_3_panel_main_panel24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel24.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel24.Controls.Add(this.menu2_3_panel_main_panel24_button_delete);
            this.menu2_3_panel_main_panel24.Controls.Add(this.menu2_3_panel_main_panel24_label1);
            this.menu2_3_panel_main_panel24.Location = new System.Drawing.Point(4, 828);
            this.menu2_3_panel_main_panel24.Name = "menu2_3_panel_main_panel24";
            this.menu2_3_panel_main_panel24.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel24.TabIndex = 26;
            this.menu2_3_panel_main_panel24.Click += new System.EventHandler(this.menu2_3_panel_main_panel24_Click);
            // 
            // menu2_3_panel_main_panel24_button_delete
            // 
            this.menu2_3_panel_main_panel24_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel24_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel24_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel24_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel24_button_delete.Name = "menu2_3_panel_main_panel24_button_delete";
            this.menu2_3_panel_main_panel24_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel24_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel24_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel24_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel24_button_delete_Click);
            // 
            // menu2_3_panel_main_panel24_label1
            // 
            this.menu2_3_panel_main_panel24_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel24_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel24_label1.Name = "menu2_3_panel_main_panel24_label1";
            this.menu2_3_panel_main_panel24_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel24_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel24_label1.Text = "label19";
            this.menu2_3_panel_main_panel24_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel24_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel24_label1_Click);
            // 
            // menu2_3_panel_main_panel23
            // 
            this.menu2_3_panel_main_panel23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel23.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel23.Controls.Add(this.menu2_3_panel_main_panel23_button_delete);
            this.menu2_3_panel_main_panel23.Controls.Add(this.menu2_3_panel_main_panel23_label1);
            this.menu2_3_panel_main_panel23.Location = new System.Drawing.Point(4, 792);
            this.menu2_3_panel_main_panel23.Name = "menu2_3_panel_main_panel23";
            this.menu2_3_panel_main_panel23.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel23.TabIndex = 25;
            this.menu2_3_panel_main_panel23.Click += new System.EventHandler(this.menu2_3_panel_main_panel23_Click);
            // 
            // menu2_3_panel_main_panel23_button_delete
            // 
            this.menu2_3_panel_main_panel23_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel23_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel23_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel23_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel23_button_delete.Name = "menu2_3_panel_main_panel23_button_delete";
            this.menu2_3_panel_main_panel23_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel23_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel23_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel23_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel23_button_delete_Click);
            // 
            // menu2_3_panel_main_panel23_label1
            // 
            this.menu2_3_panel_main_panel23_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel23_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel23_label1.Name = "menu2_3_panel_main_panel23_label1";
            this.menu2_3_panel_main_panel23_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel23_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel23_label1.Text = "label19";
            this.menu2_3_panel_main_panel23_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel23_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel23_label1_Click);
            // 
            // menu2_3_panel_main_panel22
            // 
            this.menu2_3_panel_main_panel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel22.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel22.Controls.Add(this.menu2_3_panel_main_panel22_button_delete);
            this.menu2_3_panel_main_panel22.Controls.Add(this.menu2_3_panel_main_panel22_label1);
            this.menu2_3_panel_main_panel22.Location = new System.Drawing.Point(4, 756);
            this.menu2_3_panel_main_panel22.Name = "menu2_3_panel_main_panel22";
            this.menu2_3_panel_main_panel22.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel22.TabIndex = 24;
            this.menu2_3_panel_main_panel22.Click += new System.EventHandler(this.menu2_3_panel_main_panel22_Click);
            // 
            // menu2_3_panel_main_panel22_button_delete
            // 
            this.menu2_3_panel_main_panel22_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel22_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel22_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel22_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel22_button_delete.Name = "menu2_3_panel_main_panel22_button_delete";
            this.menu2_3_panel_main_panel22_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel22_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel22_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel22_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel22_button_delete_Click);
            // 
            // menu2_3_panel_main_panel22_label1
            // 
            this.menu2_3_panel_main_panel22_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel22_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel22_label1.Name = "menu2_3_panel_main_panel22_label1";
            this.menu2_3_panel_main_panel22_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel22_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel22_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel22_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel22_label1_Click);
            // 
            // menu2_3_panel_main_panel21
            // 
            this.menu2_3_panel_main_panel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel21.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel21.Controls.Add(this.menu2_3_panel_main_panel21_button_delete);
            this.menu2_3_panel_main_panel21.Controls.Add(this.menu2_3_panel_main_panel21_label1);
            this.menu2_3_panel_main_panel21.Location = new System.Drawing.Point(4, 720);
            this.menu2_3_panel_main_panel21.Name = "menu2_3_panel_main_panel21";
            this.menu2_3_panel_main_panel21.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel21.TabIndex = 23;
            this.menu2_3_panel_main_panel21.Click += new System.EventHandler(this.menu2_3_panel_main_panel21_Click);
            // 
            // menu2_3_panel_main_panel21_button_delete
            // 
            this.menu2_3_panel_main_panel21_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel21_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel21_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel21_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel21_button_delete.Name = "menu2_3_panel_main_panel21_button_delete";
            this.menu2_3_panel_main_panel21_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel21_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel21_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel21_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel21_button_delete_Click);
            // 
            // menu2_3_panel_main_panel21_label1
            // 
            this.menu2_3_panel_main_panel21_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel21_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel21_label1.Name = "menu2_3_panel_main_panel21_label1";
            this.menu2_3_panel_main_panel21_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel21_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel21_label1.Text = "label19";
            this.menu2_3_panel_main_panel21_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel21_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel21_label1_Click);
            // 
            // menu2_3_panel_main_panel20
            // 
            this.menu2_3_panel_main_panel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel20.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel20.Controls.Add(this.menu2_3_panel_main_panel20_button_delete);
            this.menu2_3_panel_main_panel20.Controls.Add(this.menu2_3_panel_main_panel20_label1);
            this.menu2_3_panel_main_panel20.Location = new System.Drawing.Point(4, 684);
            this.menu2_3_panel_main_panel20.Name = "menu2_3_panel_main_panel20";
            this.menu2_3_panel_main_panel20.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel20.TabIndex = 22;
            this.menu2_3_panel_main_panel20.Click += new System.EventHandler(this.menu2_3_panel_main_panel20_Click);
            // 
            // menu2_3_panel_main_panel20_button_delete
            // 
            this.menu2_3_panel_main_panel20_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel20_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel20_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel20_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel20_button_delete.Name = "menu2_3_panel_main_panel20_button_delete";
            this.menu2_3_panel_main_panel20_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel20_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel20_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel20_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel20_button_delete_Click);
            // 
            // menu2_3_panel_main_panel20_label1
            // 
            this.menu2_3_panel_main_panel20_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel20_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel20_label1.Name = "menu2_3_panel_main_panel20_label1";
            this.menu2_3_panel_main_panel20_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel20_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel20_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel20_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel20_label1_Click);
            // 
            // menu2_3_panel_main_panel19
            // 
            this.menu2_3_panel_main_panel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel19.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel19.Controls.Add(this.menu2_3_panel_main_panel19_button_delete);
            this.menu2_3_panel_main_panel19.Controls.Add(this.menu2_3_panel_main_panel19_label1);
            this.menu2_3_panel_main_panel19.Location = new System.Drawing.Point(4, 648);
            this.menu2_3_panel_main_panel19.Name = "menu2_3_panel_main_panel19";
            this.menu2_3_panel_main_panel19.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel19.TabIndex = 21;
            this.menu2_3_panel_main_panel19.Click += new System.EventHandler(this.menu2_3_panel_main_panel19_Click);
            // 
            // menu2_3_panel_main_panel19_button_delete
            // 
            this.menu2_3_panel_main_panel19_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel19_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel19_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel19_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel19_button_delete.Name = "menu2_3_panel_main_panel19_button_delete";
            this.menu2_3_panel_main_panel19_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel19_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel19_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel19_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel19_button_delete_Click);
            // 
            // menu2_3_panel_main_panel19_label1
            // 
            this.menu2_3_panel_main_panel19_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel19_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel19_label1.Name = "menu2_3_panel_main_panel19_label1";
            this.menu2_3_panel_main_panel19_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel19_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel19_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel19_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel19_label1_Click);
            // 
            // menu2_3_panel_main_panel18
            // 
            this.menu2_3_panel_main_panel18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel18.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel18.Controls.Add(this.menu2_3_panel_main_panel18_button_delete);
            this.menu2_3_panel_main_panel18.Controls.Add(this.menu2_3_panel_main_panel18_label1);
            this.menu2_3_panel_main_panel18.Location = new System.Drawing.Point(4, 612);
            this.menu2_3_panel_main_panel18.Name = "menu2_3_panel_main_panel18";
            this.menu2_3_panel_main_panel18.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel18.TabIndex = 20;
            this.menu2_3_panel_main_panel18.Click += new System.EventHandler(this.menu2_3_panel_main_panel18_Click);
            // 
            // menu2_3_panel_main_panel18_button_delete
            // 
            this.menu2_3_panel_main_panel18_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel18_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel18_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel18_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel18_button_delete.Name = "menu2_3_panel_main_panel18_button_delete";
            this.menu2_3_panel_main_panel18_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel18_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel18_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel18_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel18_button_delete_Click);
            // 
            // menu2_3_panel_main_panel18_label1
            // 
            this.menu2_3_panel_main_panel18_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel18_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel18_label1.Name = "menu2_3_panel_main_panel18_label1";
            this.menu2_3_panel_main_panel18_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel18_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel18_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel18_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel18_label1_Click);
            // 
            // menu2_3_panel_main_panel17
            // 
            this.menu2_3_panel_main_panel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel17.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel17.Controls.Add(this.menu2_3_panel_main_panel17_button_delete);
            this.menu2_3_panel_main_panel17.Controls.Add(this.menu2_3_panel_main_panel17_label1);
            this.menu2_3_panel_main_panel17.Location = new System.Drawing.Point(4, 576);
            this.menu2_3_panel_main_panel17.Name = "menu2_3_panel_main_panel17";
            this.menu2_3_panel_main_panel17.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel17.TabIndex = 19;
            this.menu2_3_panel_main_panel17.Click += new System.EventHandler(this.menu2_3_panel_main_panel17_Click);
            // 
            // menu2_3_panel_main_panel17_button_delete
            // 
            this.menu2_3_panel_main_panel17_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel17_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel17_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel17_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel17_button_delete.Name = "menu2_3_panel_main_panel17_button_delete";
            this.menu2_3_panel_main_panel17_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel17_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel17_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel17_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel17_button_delete_Click);
            // 
            // menu2_3_panel_main_panel17_label1
            // 
            this.menu2_3_panel_main_panel17_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel17_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel17_label1.Name = "menu2_3_panel_main_panel17_label1";
            this.menu2_3_panel_main_panel17_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel17_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel17_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel17_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel17_label1_Click);
            // 
            // menu2_3_panel_main_panel16
            // 
            this.menu2_3_panel_main_panel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel16.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel16.Controls.Add(this.menu2_3_panel_main_panel16_button_delete);
            this.menu2_3_panel_main_panel16.Controls.Add(this.menu2_3_panel_main_panel16_label1);
            this.menu2_3_panel_main_panel16.Location = new System.Drawing.Point(4, 540);
            this.menu2_3_panel_main_panel16.Name = "menu2_3_panel_main_panel16";
            this.menu2_3_panel_main_panel16.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel16.TabIndex = 18;
            this.menu2_3_panel_main_panel16.Click += new System.EventHandler(this.menu2_3_panel_main_panel16_Click);
            // 
            // menu2_3_panel_main_panel16_button_delete
            // 
            this.menu2_3_panel_main_panel16_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel16_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel16_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel16_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel16_button_delete.Name = "menu2_3_panel_main_panel16_button_delete";
            this.menu2_3_panel_main_panel16_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel16_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel16_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel16_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel16_button_delete_Click);
            // 
            // menu2_3_panel_main_panel16_label1
            // 
            this.menu2_3_panel_main_panel16_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel16_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel16_label1.Name = "menu2_3_panel_main_panel16_label1";
            this.menu2_3_panel_main_panel16_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel16_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel16_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel16_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel16_label1_Click);
            // 
            // menu2_3_panel_main_panel15
            // 
            this.menu2_3_panel_main_panel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel15.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel15.Controls.Add(this.menu2_3_panel_main_panel15_button_delete);
            this.menu2_3_panel_main_panel15.Controls.Add(this.menu2_3_panel_main_panel15_label1);
            this.menu2_3_panel_main_panel15.Location = new System.Drawing.Point(4, 504);
            this.menu2_3_panel_main_panel15.Name = "menu2_3_panel_main_panel15";
            this.menu2_3_panel_main_panel15.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel15.TabIndex = 17;
            this.menu2_3_panel_main_panel15.Click += new System.EventHandler(this.menu2_3_panel_main_panel15_Click);
            // 
            // menu2_3_panel_main_panel15_button_delete
            // 
            this.menu2_3_panel_main_panel15_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel15_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel15_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel15_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel15_button_delete.Name = "menu2_3_panel_main_panel15_button_delete";
            this.menu2_3_panel_main_panel15_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel15_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel15_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel15_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel15_button_delete_Click);
            // 
            // menu2_3_panel_main_panel15_label1
            // 
            this.menu2_3_panel_main_panel15_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel15_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel15_label1.Name = "menu2_3_panel_main_panel15_label1";
            this.menu2_3_panel_main_panel15_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel15_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel15_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel15_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel15_label1_Click);
            // 
            // menu2_3_panel_main_panel14
            // 
            this.menu2_3_panel_main_panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel14.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel14.Controls.Add(this.menu2_3_panel_main_panel14_button_delete);
            this.menu2_3_panel_main_panel14.Controls.Add(this.menu2_3_panel_main_panel14_label1);
            this.menu2_3_panel_main_panel14.Location = new System.Drawing.Point(4, 468);
            this.menu2_3_panel_main_panel14.Name = "menu2_3_panel_main_panel14";
            this.menu2_3_panel_main_panel14.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel14.TabIndex = 16;
            this.menu2_3_panel_main_panel14.Click += new System.EventHandler(this.menu2_3_panel_main_panel14_Click);
            // 
            // menu2_3_panel_main_panel14_button_delete
            // 
            this.menu2_3_panel_main_panel14_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel14_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel14_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel14_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel14_button_delete.Name = "menu2_3_panel_main_panel14_button_delete";
            this.menu2_3_panel_main_panel14_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel14_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel14_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel14_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel14_button_delete_Click);
            // 
            // menu2_3_panel_main_panel14_label1
            // 
            this.menu2_3_panel_main_panel14_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel14_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel14_label1.Name = "menu2_3_panel_main_panel14_label1";
            this.menu2_3_panel_main_panel14_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel14_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel14_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel14_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel14_label1_Click);
            // 
            // menu2_3_panel_main_panel13
            // 
            this.menu2_3_panel_main_panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel13.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel13.Controls.Add(this.menu2_3_panel_main_panel13_button_delete);
            this.menu2_3_panel_main_panel13.Controls.Add(this.menu2_3_panel_main_panel13_label1);
            this.menu2_3_panel_main_panel13.Location = new System.Drawing.Point(4, 432);
            this.menu2_3_panel_main_panel13.Name = "menu2_3_panel_main_panel13";
            this.menu2_3_panel_main_panel13.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel13.TabIndex = 15;
            this.menu2_3_panel_main_panel13.Click += new System.EventHandler(this.menu2_3_panel_main_panel13_Click);
            // 
            // menu2_3_panel_main_panel13_button_delete
            // 
            this.menu2_3_panel_main_panel13_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel13_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel13_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel13_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel13_button_delete.Name = "menu2_3_panel_main_panel13_button_delete";
            this.menu2_3_panel_main_panel13_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel13_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel13_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel13_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel13_button_delete_Click);
            // 
            // menu2_3_panel_main_panel13_label1
            // 
            this.menu2_3_panel_main_panel13_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel13_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel13_label1.Name = "menu2_3_panel_main_panel13_label1";
            this.menu2_3_panel_main_panel13_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel13_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel13_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel13_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel13_label1_Click);
            // 
            // menu2_3_panel_main_panel12
            // 
            this.menu2_3_panel_main_panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel12.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel12.Controls.Add(this.menu2_3_panel_main_panel12_button_delete);
            this.menu2_3_panel_main_panel12.Controls.Add(this.menu2_3_panel_main_panel12_label1);
            this.menu2_3_panel_main_panel12.Location = new System.Drawing.Point(4, 396);
            this.menu2_3_panel_main_panel12.Name = "menu2_3_panel_main_panel12";
            this.menu2_3_panel_main_panel12.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel12.TabIndex = 14;
            this.menu2_3_panel_main_panel12.Click += new System.EventHandler(this.menu2_3_panel_main_panel12_Click);
            // 
            // menu2_3_panel_main_panel12_button_delete
            // 
            this.menu2_3_panel_main_panel12_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel12_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel12_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel12_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel12_button_delete.Name = "menu2_3_panel_main_panel12_button_delete";
            this.menu2_3_panel_main_panel12_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel12_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel12_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel12_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel12_button_delete_Click);
            // 
            // menu2_3_panel_main_panel12_label1
            // 
            this.menu2_3_panel_main_panel12_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel12_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel12_label1.Name = "menu2_3_panel_main_panel12_label1";
            this.menu2_3_panel_main_panel12_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel12_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel12_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel12_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel12_label1_Click);
            // 
            // menu2_3_panel_main_panel11
            // 
            this.menu2_3_panel_main_panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel11.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel11.Controls.Add(this.menu2_3_panel_main_panel11_button_delete);
            this.menu2_3_panel_main_panel11.Controls.Add(this.menu2_3_panel_main_panel11_label1);
            this.menu2_3_panel_main_panel11.Location = new System.Drawing.Point(4, 360);
            this.menu2_3_panel_main_panel11.Name = "menu2_3_panel_main_panel11";
            this.menu2_3_panel_main_panel11.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel11.TabIndex = 13;
            this.menu2_3_panel_main_panel11.Click += new System.EventHandler(this.menu2_3_panel_main_panel11_Click);
            // 
            // menu2_3_panel_main_panel11_button_delete
            // 
            this.menu2_3_panel_main_panel11_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel11_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel11_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel11_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel11_button_delete.Name = "menu2_3_panel_main_panel11_button_delete";
            this.menu2_3_panel_main_panel11_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel11_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel11_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel11_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel11_button_delete_Click);
            // 
            // menu2_3_panel_main_panel11_label1
            // 
            this.menu2_3_panel_main_panel11_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel11_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel11_label1.Name = "menu2_3_panel_main_panel11_label1";
            this.menu2_3_panel_main_panel11_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel11_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel11_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel11_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel11_label1_Click);
            // 
            // menu2_3_panel_main_panel10
            // 
            this.menu2_3_panel_main_panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel10.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel10.Controls.Add(this.menu2_3_panel_main_panel10_button_delete);
            this.menu2_3_panel_main_panel10.Controls.Add(this.menu2_3_panel_main_panel10_label1);
            this.menu2_3_panel_main_panel10.Location = new System.Drawing.Point(4, 324);
            this.menu2_3_panel_main_panel10.Name = "menu2_3_panel_main_panel10";
            this.menu2_3_panel_main_panel10.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel10.TabIndex = 12;
            this.menu2_3_panel_main_panel10.Click += new System.EventHandler(this.menu2_3_panel_main_panel10_Click);
            // 
            // menu2_3_panel_main_panel10_button_delete
            // 
            this.menu2_3_panel_main_panel10_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel10_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel10_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel10_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel10_button_delete.Name = "menu2_3_panel_main_panel10_button_delete";
            this.menu2_3_panel_main_panel10_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel10_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel10_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel10_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel10_button_delete_Click);
            // 
            // menu2_3_panel_main_panel10_label1
            // 
            this.menu2_3_panel_main_panel10_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel10_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel10_label1.Name = "menu2_3_panel_main_panel10_label1";
            this.menu2_3_panel_main_panel10_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel10_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel10_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel10_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel10_label1_Click);
            // 
            // menu2_3_panel_main_panel9
            // 
            this.menu2_3_panel_main_panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel9.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel9.Controls.Add(this.menu2_3_panel_main_panel9_button_delete);
            this.menu2_3_panel_main_panel9.Controls.Add(this.menu2_3_panel_main_panel9_label1);
            this.menu2_3_panel_main_panel9.Location = new System.Drawing.Point(4, 288);
            this.menu2_3_panel_main_panel9.Name = "menu2_3_panel_main_panel9";
            this.menu2_3_panel_main_panel9.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel9.TabIndex = 11;
            this.menu2_3_panel_main_panel9.Click += new System.EventHandler(this.menu2_3_panel_main_panel9_Click);
            // 
            // menu2_3_panel_main_panel9_button_delete
            // 
            this.menu2_3_panel_main_panel9_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel9_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel9_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel9_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel9_button_delete.Name = "menu2_3_panel_main_panel9_button_delete";
            this.menu2_3_panel_main_panel9_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel9_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel9_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel9_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel9_button_delete_Click);
            // 
            // menu2_3_panel_main_panel9_label1
            // 
            this.menu2_3_panel_main_panel9_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel9_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel9_label1.Name = "menu2_3_panel_main_panel9_label1";
            this.menu2_3_panel_main_panel9_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel9_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel9_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel9_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel9_label1_Click);
            // 
            // menu2_3_panel_main_panel8
            // 
            this.menu2_3_panel_main_panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel8.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel8.Controls.Add(this.menu2_3_panel_main_panel8_button_delete);
            this.menu2_3_panel_main_panel8.Controls.Add(this.menu2_3_panel_main_panel8_label1);
            this.menu2_3_panel_main_panel8.Location = new System.Drawing.Point(4, 252);
            this.menu2_3_panel_main_panel8.Name = "menu2_3_panel_main_panel8";
            this.menu2_3_panel_main_panel8.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel8.TabIndex = 10;
            this.menu2_3_panel_main_panel8.Click += new System.EventHandler(this.menu2_3_panel_main_panel8_Click);
            // 
            // menu2_3_panel_main_panel8_button_delete
            // 
            this.menu2_3_panel_main_panel8_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel8_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel8_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel8_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel8_button_delete.Name = "menu2_3_panel_main_panel8_button_delete";
            this.menu2_3_panel_main_panel8_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel8_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel8_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel8_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel8_button_delete_Click);
            // 
            // menu2_3_panel_main_panel8_label1
            // 
            this.menu2_3_panel_main_panel8_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel8_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel8_label1.Name = "menu2_3_panel_main_panel8_label1";
            this.menu2_3_panel_main_panel8_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel8_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel8_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel8_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel8_label1_Click);
            // 
            // menu2_3_panel_main_panel7
            // 
            this.menu2_3_panel_main_panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel7.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel7.Controls.Add(this.menu2_3_panel_main_panel7_button_delete);
            this.menu2_3_panel_main_panel7.Controls.Add(this.menu2_3_panel_main_panel7_label1);
            this.menu2_3_panel_main_panel7.Location = new System.Drawing.Point(4, 216);
            this.menu2_3_panel_main_panel7.Name = "menu2_3_panel_main_panel7";
            this.menu2_3_panel_main_panel7.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel7.TabIndex = 9;
            this.menu2_3_panel_main_panel7.Click += new System.EventHandler(this.menu2_3_panel_main_panel7_Click);
            // 
            // menu2_3_panel_main_panel7_button_delete
            // 
            this.menu2_3_panel_main_panel7_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel7_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel7_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel7_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel7_button_delete.Name = "menu2_3_panel_main_panel7_button_delete";
            this.menu2_3_panel_main_panel7_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel7_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel7_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel7_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel7_button_delete_Click);
            // 
            // menu2_3_panel_main_panel7_label1
            // 
            this.menu2_3_panel_main_panel7_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel7_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel7_label1.Name = "menu2_3_panel_main_panel7_label1";
            this.menu2_3_panel_main_panel7_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel7_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel7_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel7_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel7_label1_Click);
            // 
            // menu2_3_panel_main_panel6
            // 
            this.menu2_3_panel_main_panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel6.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel6.Controls.Add(this.menu2_3_panel_main_panel6_button_delete);
            this.menu2_3_panel_main_panel6.Controls.Add(this.menu2_3_panel_main_panel6_label1);
            this.menu2_3_panel_main_panel6.Location = new System.Drawing.Point(4, 180);
            this.menu2_3_panel_main_panel6.Name = "menu2_3_panel_main_panel6";
            this.menu2_3_panel_main_panel6.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel6.TabIndex = 8;
            this.menu2_3_panel_main_panel6.Click += new System.EventHandler(this.menu2_3_panel_main_panel6_Click);
            // 
            // menu2_3_panel_main_panel6_button_delete
            // 
            this.menu2_3_panel_main_panel6_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel6_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel6_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel6_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel6_button_delete.Name = "menu2_3_panel_main_panel6_button_delete";
            this.menu2_3_panel_main_panel6_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel6_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel6_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel6_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel6_button_delete_Click);
            // 
            // menu2_3_panel_main_panel6_label1
            // 
            this.menu2_3_panel_main_panel6_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel6_label1.Name = "menu2_3_panel_main_panel6_label1";
            this.menu2_3_panel_main_panel6_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel6_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel6_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel6_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel6_label1_Click);
            // 
            // menu2_3_panel_main_panel5
            // 
            this.menu2_3_panel_main_panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel5.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel5.Controls.Add(this.menu2_3_panel_main_panel5_button_delete);
            this.menu2_3_panel_main_panel5.Controls.Add(this.menu2_3_panel_main_panel5_label1);
            this.menu2_3_panel_main_panel5.Location = new System.Drawing.Point(4, 144);
            this.menu2_3_panel_main_panel5.Name = "menu2_3_panel_main_panel5";
            this.menu2_3_panel_main_panel5.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel5.TabIndex = 7;
            this.menu2_3_panel_main_panel5.Click += new System.EventHandler(this.menu2_3_panel_main_panel5_Click);
            // 
            // menu2_3_panel_main_panel5_button_delete
            // 
            this.menu2_3_panel_main_panel5_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel5_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel5_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel5_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel5_button_delete.Name = "menu2_3_panel_main_panel5_button_delete";
            this.menu2_3_panel_main_panel5_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel5_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel5_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel5_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel5_button_delete_Click);
            // 
            // menu2_3_panel_main_panel5_label1
            // 
            this.menu2_3_panel_main_panel5_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel5_label1.Name = "menu2_3_panel_main_panel5_label1";
            this.menu2_3_panel_main_panel5_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel5_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel5_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel5_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel5_label1_Click);
            // 
            // menu2_3_panel_main_panel4
            // 
            this.menu2_3_panel_main_panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel4.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel4.Controls.Add(this.menu2_3_panel_main_panel4_button_delete);
            this.menu2_3_panel_main_panel4.Controls.Add(this.menu2_3_panel_main_panel4_label1);
            this.menu2_3_panel_main_panel4.Location = new System.Drawing.Point(4, 108);
            this.menu2_3_panel_main_panel4.Name = "menu2_3_panel_main_panel4";
            this.menu2_3_panel_main_panel4.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel4.TabIndex = 6;
            this.menu2_3_panel_main_panel4.Click += new System.EventHandler(this.menu2_3_panel_main_panel4_Click);
            // 
            // menu2_3_panel_main_panel4_button_delete
            // 
            this.menu2_3_panel_main_panel4_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel4_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel4_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel4_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel4_button_delete.Name = "menu2_3_panel_main_panel4_button_delete";
            this.menu2_3_panel_main_panel4_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel4_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel4_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel4_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel4_button_delete_Click);
            // 
            // menu2_3_panel_main_panel4_label1
            // 
            this.menu2_3_panel_main_panel4_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel4_label1.Name = "menu2_3_panel_main_panel4_label1";
            this.menu2_3_panel_main_panel4_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel4_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel4_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel4_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel4_label1_Click);
            // 
            // menu2_3_panel_main_panel3
            // 
            this.menu2_3_panel_main_panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel3.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel3.Controls.Add(this.menu2_3_panel_main_panel3_button_delete);
            this.menu2_3_panel_main_panel3.Controls.Add(this.menu2_3_panel_main_panel3_label1);
            this.menu2_3_panel_main_panel3.Location = new System.Drawing.Point(4, 72);
            this.menu2_3_panel_main_panel3.Name = "menu2_3_panel_main_panel3";
            this.menu2_3_panel_main_panel3.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel3.TabIndex = 5;
            this.menu2_3_panel_main_panel3.Click += new System.EventHandler(this.menu2_3_panel_main_panel3_Click);
            // 
            // menu2_3_panel_main_panel3_button_delete
            // 
            this.menu2_3_panel_main_panel3_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel3_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel3_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel3_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel3_button_delete.Name = "menu2_3_panel_main_panel3_button_delete";
            this.menu2_3_panel_main_panel3_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel3_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel3_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel3_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel3_button_delete_Click);
            // 
            // menu2_3_panel_main_panel3_label1
            // 
            this.menu2_3_panel_main_panel3_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel3_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel3_label1.Name = "menu2_3_panel_main_panel3_label1";
            this.menu2_3_panel_main_panel3_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel3_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel3_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel3_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel3_label1_Click);
            // 
            // menu2_3_panel_main_panel2
            // 
            this.menu2_3_panel_main_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel2.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel2.Controls.Add(this.menu2_3_panel_main_panel2_button_delete);
            this.menu2_3_panel_main_panel2.Controls.Add(this.menu2_3_panel_main_panel2_label1);
            this.menu2_3_panel_main_panel2.Location = new System.Drawing.Point(4, 36);
            this.menu2_3_panel_main_panel2.Name = "menu2_3_panel_main_panel2";
            this.menu2_3_panel_main_panel2.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel2.TabIndex = 4;
            this.menu2_3_panel_main_panel2.Click += new System.EventHandler(this.menu2_3_panel_main_panel2_Click);
            // 
            // menu2_3_panel_main_panel2_button_delete
            // 
            this.menu2_3_panel_main_panel2_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel2_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel2_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel2_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel2_button_delete.Name = "menu2_3_panel_main_panel2_button_delete";
            this.menu2_3_panel_main_panel2_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel2_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel2_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel2_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel2_button_delete_Click);
            // 
            // menu2_3_panel_main_panel2_label1
            // 
            this.menu2_3_panel_main_panel2_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel2_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel2_label1.Name = "menu2_3_panel_main_panel2_label1";
            this.menu2_3_panel_main_panel2_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel2_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel2_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel2_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel2_label1_Click);
            // 
            // menu2_3_panel_main_panel1
            // 
            this.menu2_3_panel_main_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_3_panel_main_panel1.BorderColor = System.Drawing.Color.Black;
            this.menu2_3_panel_main_panel1.Controls.Add(this.menu2_3_panel_main_panel1_button_delete);
            this.menu2_3_panel_main_panel1.Controls.Add(this.menu2_3_panel_main_panel1_label1);
            this.menu2_3_panel_main_panel1.Location = new System.Drawing.Point(4, 0);
            this.menu2_3_panel_main_panel1.Name = "menu2_3_panel_main_panel1";
            this.menu2_3_panel_main_panel1.Size = new System.Drawing.Size(655, 32);
            this.menu2_3_panel_main_panel1.TabIndex = 3;
            this.menu2_3_panel_main_panel1.Click += new System.EventHandler(this.menu2_3_panel_main_panel1_Click);
            // 
            // menu2_3_panel_main_panel1_button_delete
            // 
            this.menu2_3_panel_main_panel1_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_3_panel_main_panel1_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_3_panel_main_panel1_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_3_panel_main_panel1_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_3_panel_main_panel1_button_delete.Name = "menu2_3_panel_main_panel1_button_delete";
            this.menu2_3_panel_main_panel1_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_3_panel_main_panel1_button_delete.TabIndex = 1;
            this.menu2_3_panel_main_panel1_button_delete.UseVisualStyleBackColor = false;
            this.menu2_3_panel_main_panel1_button_delete.Click += new System.EventHandler(this.menu2_3_panel_main_panel1_button_delete_Click);
            // 
            // menu2_3_panel_main_panel1_label1
            // 
            this.menu2_3_panel_main_panel1_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_3_panel_main_panel1_label1.Name = "menu2_3_panel_main_panel1_label1";
            this.menu2_3_panel_main_panel1_label1.Size = new System.Drawing.Size(621, 30);
            this.menu2_3_panel_main_panel1_label1.TabIndex = 0;
            this.menu2_3_panel_main_panel1_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel1_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel1_label1_Click);
            // 
            // menu2_2
            // 
            this.menu2_2.Controls.Add(this.menu2_2_panel);
            this.menu2_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2.Location = new System.Drawing.Point(0, 950);
            this.menu2_2.Name = "menu2_2";
            this.menu2_2.Size = new System.Drawing.Size(665, 570);
            this.menu2_2.TabIndex = 9;
            // 
            // menu2_2_panel
            // 
            this.menu2_2_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel.BorderColor = System.Drawing.Color.Black;
            this.menu2_2_panel.Controls.Add(this.menu2_2_panel_top);
            this.menu2_2_panel.Controls.Add(this.menu2_2_panel_main);
            this.menu2_2_panel.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel.Name = "menu2_2_panel";
            this.menu2_2_panel.Size = new System.Drawing.Size(665, 540);
            this.menu2_2_panel.TabIndex = 3;
            // 
            // menu2_2_panel_top
            // 
            this.menu2_2_panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_top.Controls.Add(this.menu2_2_panel_top_button_open);
            this.menu2_2_panel_top.Controls.Add(this.menu2_2_panel_top_label_num);
            this.menu2_2_panel_top.Controls.Add(this.menu2_2_panel_top_button_movedown);
            this.menu2_2_panel_top.Controls.Add(this.menu2_2_panel_top_button_moveup);
            this.menu2_2_panel_top.Controls.Add(this.menu2_2_panel_top_button_add);
            this.menu2_2_panel_top.Controls.Add(this.menu2_2_panel_top_button_openclose);
            this.menu2_2_panel_top.Controls.Add(this.menu2_2_panel_top_label_title);
            this.menu2_2_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_2_panel_top.Name = "menu2_2_panel_top";
            this.menu2_2_panel_top.Size = new System.Drawing.Size(663, 32);
            this.menu2_2_panel_top.TabIndex = 4;
            // 
            // menu2_2_panel_top_button_open
            // 
            this.menu2_2_panel_top_button_open.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_top_button_open.FlatAppearance.BorderSize = 0;
            this.menu2_2_panel_top_button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_open.Location = new System.Drawing.Point(599, 0);
            this.menu2_2_panel_top_button_open.Name = "menu2_2_panel_top_button_open";
            this.menu2_2_panel_top_button_open.Size = new System.Drawing.Size(32, 32);
            this.menu2_2_panel_top_button_open.TabIndex = 6;
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_open, "追加");
            this.menu2_2_panel_top_button_open.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_open.Click += new System.EventHandler(this.menu2_2_panel_top_button_open_Click);
            // 
            // menu2_2_panel_top_label_num
            // 
            this.menu2_2_panel_top_label_num.BackColor = System.Drawing.Color.Transparent;
            this.menu2_2_panel_top_label_num.CustomText = "0";
            this.menu2_2_panel_top_label_num.Location = new System.Drawing.Point(46, 0);
            this.menu2_2_panel_top_label_num.Name = "menu2_2_panel_top_label_num";
            this.menu2_2_panel_top_label_num.Size = new System.Drawing.Size(20, 20);
            this.menu2_2_panel_top_label_num.TabIndex = 5;
            // 
            // menu2_2_panel_top_button_movedown
            // 
            this.menu2_2_panel_top_button_movedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_movedown.Location = new System.Drawing.Point(0, 16);
            this.menu2_2_panel_top_button_movedown.Name = "menu2_2_panel_top_button_movedown";
            this.menu2_2_panel_top_button_movedown.Size = new System.Drawing.Size(16, 16);
            this.menu2_2_panel_top_button_movedown.TabIndex = 4;
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_movedown, "下に移動");
            this.menu2_2_panel_top_button_movedown.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_movedown.Click += new System.EventHandler(this.menu2_2_panel_top_button_movedown_Click);
            // 
            // menu2_2_panel_top_button_moveup
            // 
            this.menu2_2_panel_top_button_moveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_moveup.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_top_button_moveup.Name = "menu2_2_panel_top_button_moveup";
            this.menu2_2_panel_top_button_moveup.Size = new System.Drawing.Size(16, 16);
            this.menu2_2_panel_top_button_moveup.TabIndex = 3;
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_moveup, "上に移動");
            this.menu2_2_panel_top_button_moveup.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_moveup.Click += new System.EventHandler(this.menu2_2_panel_top_button_moveup_Click);
            // 
            // menu2_2_panel_top_button_add
            // 
            this.menu2_2_panel_top_button_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_top_button_add.FlatAppearance.BorderSize = 0;
            this.menu2_2_panel_top_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_add.Image = ((System.Drawing.Image)(resources.GetObject("menu2_2_panel_top_button_add.Image")));
            this.menu2_2_panel_top_button_add.Location = new System.Drawing.Point(631, 0);
            this.menu2_2_panel_top_button_add.Name = "menu2_2_panel_top_button_add";
            this.menu2_2_panel_top_button_add.Size = new System.Drawing.Size(32, 32);
            this.menu2_2_panel_top_button_add.TabIndex = 2;
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_add, "追加");
            this.menu2_2_panel_top_button_add.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_add.Click += new System.EventHandler(this.menu2_2_panel_top_button_add_Click);
            // 
            // menu2_2_panel_top_button_openclose
            // 
            this.menu2_2_panel_top_button_openclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu2_2_panel_top_button_openclose.BackColor = System.Drawing.Color.Transparent;
            this.menu2_2_panel_top_button_openclose.FlatAppearance.BorderSize = 0;
            this.menu2_2_panel_top_button_openclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_openclose.Location = new System.Drawing.Point(66, 0);
            this.menu2_2_panel_top_button_openclose.Name = "menu2_2_panel_top_button_openclose";
            this.menu2_2_panel_top_button_openclose.Size = new System.Drawing.Size(32, 32);
            this.menu2_2_panel_top_button_openclose.TabIndex = 1;
            this.menu2_2_panel_top_button_openclose.Text = "+";
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_openclose, "開く/閉じる");
            this.menu2_2_panel_top_button_openclose.UseVisualStyleBackColor = false;
            this.menu2_2_panel_top_button_openclose.Click += new System.EventHandler(this.menu2_2_panel_top_button_openclose_Click);
            // 
            // menu2_2_panel_top_label_title
            // 
            this.menu2_2_panel_top_label_title.Location = new System.Drawing.Point(16, 0);
            this.menu2_2_panel_top_label_title.Name = "menu2_2_panel_top_label_title";
            this.menu2_2_panel_top_label_title.Size = new System.Drawing.Size(30, 32);
            this.menu2_2_panel_top_label_title.TabIndex = 0;
            this.menu2_2_panel_top_label_title.Text = "メモ";
            this.menu2_2_panel_top_label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu2_2_panel_main
            // 
            this.menu2_2_panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            for (int i = menu2_2_panel_main_panel.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main.Controls.Add(this.menu2_2_panel_main_panel[i]);
            }
            this.menu2_2_panel_main.Location = new System.Drawing.Point(1, 33);
            this.menu2_2_panel_main.Name = "menu2_2_panel_main";
            this.menu2_2_panel_main.Size = new System.Drawing.Size(663, 540);
            this.menu2_2_panel_main.TabIndex = 5;


            //
            // menu2_2_panel_main_panel
            //
            for (int i = menu2_2_panel_main_panel.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel[i].Controls.Add(this.menu2_2_panel_main_panel_table_memo[i]);
                this.menu2_2_panel_main_panel[i].Dock = System.Windows.Forms.DockStyle.Top;
                this.menu2_2_panel_main_panel[i].Location = new System.Drawing.Point(0, 0);
                this.menu2_2_panel_main_panel[i].Name = "menu2_2_panel_main_panel1";
                this.menu2_2_panel_main_panel[i].Size = new System.Drawing.Size(663, 106);
                this.menu2_2_panel_main_panel[i].TabIndex = 9;
            }
            //
            // menu2_2_panel_main_panel_table_memo
            //
            for (int i = menu2_2_panel_main_panel_table_memo.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel_table_memo[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.menu2_2_panel_main_panel_table_memo[i].CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
                this.menu2_2_panel_main_panel_table_memo[i].ColumnCount = 1;
                this.menu2_2_panel_main_panel_table_memo[i].ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.menu2_2_panel_main_panel_table_memo[i].Controls.Add(this.menu2_2_panel_main_panel_table_memo_text[i], 0, 1);
                this.menu2_2_panel_main_panel_table_memo[i].Controls.Add(this.menu2_2_panel_main_panel_table_memo_panel_top[i], 0, 0);
                this.menu2_2_panel_main_panel_table_memo[i].Location = new System.Drawing.Point(4, 0);
                this.menu2_2_panel_main_panel_table_memo[i].Name = "menu2_2_panel_main_panel1_table_memo";
                this.menu2_2_panel_main_panel_table_memo[i].RowCount = 2;
                this.menu2_2_panel_main_panel_table_memo[i].RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
                this.menu2_2_panel_main_panel_table_memo[i].RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
                this.menu2_2_panel_main_panel_table_memo[i].Size = new System.Drawing.Size(655, 102);
                this.menu2_2_panel_main_panel_table_memo[i].TabIndex = 4;
            }
            //
            // menu2_2_panel_main_panel_table_memo_text
            //
            for (int i = menu2_2_panel_main_panel_table_memo_text.Length - 1; i >= 0 ; i--)
            {
                this.menu2_2_panel_main_panel_table_memo_text[i].AcceptsReturn = true;
                this.menu2_2_panel_main_panel_table_memo_text[i].AcceptsTab = true;
                this.menu2_2_panel_main_panel_table_memo_text[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.menu2_2_panel_main_panel_table_memo_text[i].Location = new System.Drawing.Point(1, 24);
                this.menu2_2_panel_main_panel_table_memo_text[i].Margin = new System.Windows.Forms.Padding(0);
                this.menu2_2_panel_main_panel_table_memo_text[i].Multiline = true;
                this.menu2_2_panel_main_panel_table_memo_text[i].Name = i.ToString();
                this.menu2_2_panel_main_panel_table_memo_text[i].ScrollBars = System.Windows.Forms.ScrollBars.Both;
                this.menu2_2_panel_main_panel_table_memo_text[i].Size = new System.Drawing.Size(653, 77);
                this.menu2_2_panel_main_panel_table_memo_text[i].TabIndex = 0;
                this.menu2_2_panel_main_panel_table_memo_text[i].KeyDown += new System.Windows.Forms.KeyEventHandler(this.menu2_2_panel_main_panel_table_memo_text_KeyDown);
            }
            //
            // menu2_2_panel_main_panel_table_memo_panel_top
            //
            for (int i = menu2_2_panel_main_panel_table_memo_panel_top.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Controls.Add(this.menu2_2_panel_main_panel_table_memo_panel_top_text[i]);
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Controls.Add(this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i]);
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Controls.Add(this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i]);
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Controls.Add(this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i]);
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Location = new System.Drawing.Point(1, 1);
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Margin = new System.Windows.Forms.Padding(0);
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Name = "menu2_2_panel_main_panel1_table_memo_panel_top";
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].Size = new System.Drawing.Size(653, 22);
                this.menu2_2_panel_main_panel_table_memo_panel_top[i].TabIndex = 1;
            }
            //
            // menu2_2_panel_main_panel_table_memo_panel_top_text
            //
            for (int i = menu2_2_panel_main_panel_table_memo_panel_top_text.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i].BackColor = System.Drawing.SystemColors.Control;
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Location = new System.Drawing.Point(0, 0);
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Name = "menu2_2_panel_main_panel1_table_memo_panel_top_text";
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i].ReadOnly = true;
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i].Size = new System.Drawing.Size(557, 23);
                this.menu2_2_panel_main_panel_table_memo_panel_top_text[i].TabIndex = 4;
            }
            //
            // menu2_2_panel_main_panel_table_memo_panel_top_button_save
            //
            for (int i = menu2_2_panel_main_panel_table_memo_panel_top_button_save.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].Dock = System.Windows.Forms.DockStyle.Right;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].Location = new System.Drawing.Point(557, 0);
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].Name = i.ToString();
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].Size = new System.Drawing.Size(32, 22);
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].TabIndex = 3;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].UseVisualStyleBackColor = true;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_save[i].Click += new System.EventHandler(this.menu2_2_panel_main_panel_table_memo_panel_top_button_save_Click);
            }
            // 
            // menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax
            // 
            for (int i = menu2_2_panel_main_panel_table_memo_panel_top_button_minmax.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].Dock = System.Windows.Forms.DockStyle.Right;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].Location = new System.Drawing.Point(589, 0);
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].Name = i.ToString();
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].Size = new System.Drawing.Size(32, 22);
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].TabIndex = 2;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].UseVisualStyleBackColor = true;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[i].Click += new System.EventHandler(this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax_Click);
            }
            //
            // menu2_2_panel_main_panel_table_memo_panel_top_button_close
            //
            for (int i = menu2_2_panel_main_panel_table_memo_panel_top_button_close.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].Dock = System.Windows.Forms.DockStyle.Right;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].Location = new System.Drawing.Point(621, 0);
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].Name = "menu2_2_panel_main_panel1_table_memo_panel_top_button_close";
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].Size = new System.Drawing.Size(32, 22);
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].TabIndex = 1;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].UseVisualStyleBackColor = true;
                this.menu2_2_panel_main_panel_table_memo_panel_top_button_close[i].Click += new System.EventHandler(this.menu2_2_panel_main_panel_table_memo_panel_top_button_close_Click);
            }
             
            // 
            // menu2_1
            // 
            this.menu2_1.Controls.Add(this.menu2_1_panel_margin);
            this.menu2_1.Controls.Add(this.menu2_1_panel);
            this.menu2_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_1.Location = new System.Drawing.Point(0, 0);
            this.menu2_1.Name = "menu2_1";
            this.menu2_1.Size = new System.Drawing.Size(665, 950);
            this.menu2_1.TabIndex = 8;
            // 
            // menu2_1_panel_margin
            // 
            this.menu2_1_panel_margin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_margin.Location = new System.Drawing.Point(1, 936);
            this.menu2_1_panel_margin.Name = "menu2_1_panel_margin";
            this.menu2_1_panel_margin.Size = new System.Drawing.Size(663, 8);
            this.menu2_1_panel_margin.TabIndex = 4;
            // 
            // menu2_1_panel
            // 
            this.menu2_1_panel.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel.Controls.Add(this.menu2_1_panel_top);
            this.menu2_1_panel.Controls.Add(this.menu2_1_panel_main);
            this.menu2_1_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_1_panel.Location = new System.Drawing.Point(0, 0);
            this.menu2_1_panel.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_1_panel.Name = "menu2_1_panel";
            this.menu2_1_panel.Size = new System.Drawing.Size(665, 936);
            this.menu2_1_panel.TabIndex = 0;
            // 
            // menu2_1_panel_top
            // 
            this.menu2_1_panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_top.Controls.Add(this.menu2_1_panel_top_label_num);
            this.menu2_1_panel_top.Controls.Add(this.menu2_1_panel_top_button_movedown);
            this.menu2_1_panel_top.Controls.Add(this.menu2_1_panel_top_button_moveup);
            this.menu2_1_panel_top.Controls.Add(this.menu2_1_panel_top_label_title);
            this.menu2_1_panel_top.Controls.Add(this.menu2_1_panel_top_button_openclose);
            this.menu2_1_panel_top.Controls.Add(this.menu2_1_panel_top_button_add);
            this.menu2_1_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_top.Name = "menu2_1_panel_top";
            this.menu2_1_panel_top.Size = new System.Drawing.Size(663, 32);
            this.menu2_1_panel_top.TabIndex = 6;
            // 
            // menu2_1_panel_top_label_num
            // 
            this.menu2_1_panel_top_label_num.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_top_label_num.CustomText = "25";
            this.menu2_1_panel_top_label_num.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_1_panel_top_label_num.Location = new System.Drawing.Point(116, 0);
            this.menu2_1_panel_top_label_num.Name = "menu2_1_panel_top_label_num";
            this.menu2_1_panel_top_label_num.Size = new System.Drawing.Size(20, 20);
            this.menu2_1_panel_top_label_num.TabIndex = 31;
            // 
            // menu2_1_panel_top_button_movedown
            // 
            this.menu2_1_panel_top_button_movedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_movedown.Location = new System.Drawing.Point(0, 16);
            this.menu2_1_panel_top_button_movedown.Name = "menu2_1_panel_top_button_movedown";
            this.menu2_1_panel_top_button_movedown.Size = new System.Drawing.Size(16, 16);
            this.menu2_1_panel_top_button_movedown.TabIndex = 30;
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_movedown, "下に移動");
            this.menu2_1_panel_top_button_movedown.UseVisualStyleBackColor = true;
            this.menu2_1_panel_top_button_movedown.Click += new System.EventHandler(this.menu2_1_panel_top_button_movedown_Click);
            // 
            // menu2_1_panel_top_button_moveup
            // 
            this.menu2_1_panel_top_button_moveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_moveup.Location = new System.Drawing.Point(0, 0);
            this.menu2_1_panel_top_button_moveup.Name = "menu2_1_panel_top_button_moveup";
            this.menu2_1_panel_top_button_moveup.Size = new System.Drawing.Size(16, 16);
            this.menu2_1_panel_top_button_moveup.TabIndex = 29;
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_moveup, "上に移動");
            this.menu2_1_panel_top_button_moveup.UseVisualStyleBackColor = true;
            this.menu2_1_panel_top_button_moveup.Click += new System.EventHandler(this.menu2_1_panel_top_button_moveup_Click);
            // 
            // menu2_1_panel_top_label_title
            // 
            this.menu2_1_panel_top_label_title.Location = new System.Drawing.Point(16, 0);
            this.menu2_1_panel_top_label_title.Name = "menu2_1_panel_top_label_title";
            this.menu2_1_panel_top_label_title.Size = new System.Drawing.Size(100, 32);
            this.menu2_1_panel_top_label_title.TabIndex = 0;
            this.menu2_1_panel_top_label_title.Text = "期間設定ありタスク";
            this.menu2_1_panel_top_label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu2_1_panel_top_button_openclose
            // 
            this.menu2_1_panel_top_button_openclose.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_top_button_openclose.FlatAppearance.BorderSize = 0;
            this.menu2_1_panel_top_button_openclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_openclose.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_1_panel_top_button_openclose.Location = new System.Drawing.Point(146, 0);
            this.menu2_1_panel_top_button_openclose.Name = "menu2_1_panel_top_button_openclose";
            this.menu2_1_panel_top_button_openclose.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_top_button_openclose.TabIndex = 3;
            this.menu2_1_panel_top_button_openclose.Text = "+";
            this.menu2_1_panel_top_button_openclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_openclose, "開く/閉じる");
            this.menu2_1_panel_top_button_openclose.UseVisualStyleBackColor = false;
            this.menu2_1_panel_top_button_openclose.Click += new System.EventHandler(this.menu2_1_panel_top_button_openclose_Click);
            // 
            // menu2_1_panel_top_button_add
            // 
            this.menu2_1_panel_top_button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_top_button_add.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_top_button_add.FlatAppearance.BorderSize = 0;
            this.menu2_1_panel_top_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_add.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_1_panel_top_button_add.Image = ((System.Drawing.Image)(resources.GetObject("menu2_1_panel_top_button_add.Image")));
            this.menu2_1_panel_top_button_add.Location = new System.Drawing.Point(631, 0);
            this.menu2_1_panel_top_button_add.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_1_panel_top_button_add.Name = "menu2_1_panel_top_button_add";
            this.menu2_1_panel_top_button_add.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_top_button_add.TabIndex = 28;
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_add, "追加");
            this.menu2_1_panel_top_button_add.UseVisualStyleBackColor = false;
            this.menu2_1_panel_top_button_add.Click += new System.EventHandler(this.menu2_1_panel_top_button_add_Click);
            // 
            // menu2_1_panel_main
            // 
            this.menu2_1_panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));

            for (int i = 0; i < menu2_1_panel_main_panel.Length; i++)
            {
                this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel[i]);
            }
            this.menu2_1_panel_main.Location = new System.Drawing.Point(1, 34);
            this.menu2_1_panel_main.Name = "menu2_1_panel_main";
            this.menu2_1_panel_main.Size = new System.Drawing.Size(663, 899);
            this.menu2_1_panel_main.TabIndex = 3;
            //
            // menu2_1_panel_main_panel
            //
            for (int i=0; i < menu2_1_panel_main_panel.Length; i++)
            {
                this.menu2_1_panel_main_panel[i].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.menu2_1_panel_main_panel[i].BorderColor = System.Drawing.Color.Black;
                this.menu2_1_panel_main_panel[i].Controls.Add(this.menu2_1_panel_main_panel_label1[i]);
                this.menu2_1_panel_main_panel[i].Controls.Add(this.menu2_1_panel_main_panel_button_finish[i]);
                this.menu2_1_panel_main_panel[i].Controls.Add(this.menu2_1_panel_main_panel_button_delete[i]);
                this.menu2_1_panel_main_panel[i].Controls.Add(this.menu2_1_panel_main_panel_label2[i]);
                this.menu2_1_panel_main_panel[i].Location = new System.Drawing.Point(4, 36 * i);
                this.menu2_1_panel_main_panel[i].Name = i.ToString();
                this.menu2_1_panel_main_panel[i].Size = new System.Drawing.Size(655, 32);
                this.menu2_1_panel_main_panel[i].TabIndex = 3;
                this.menu2_1_panel_main_panel[i].Click += new System.EventHandler(this.menu2_1_panel_main_panel_Click);
            }
            //
            // menu2_1_panel_main_panel_button_delete
            //
            for (int i = 0; i < menu2_1_panel_main_panel_button_delete.Length; i++)
            {
                this.menu2_1_panel_main_panel_button_delete[i].BackColor = System.Drawing.Color.Transparent;
                this.menu2_1_panel_main_panel_button_delete[i].Dock = System.Windows.Forms.DockStyle.Right;
                this.menu2_1_panel_main_panel_button_delete[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.menu2_1_panel_main_panel_button_delete[i].Image = ((System.Drawing.Image)(resources.GetObject("menu2_1_panel_main_panel1_button_delete.Image")));
                this.menu2_1_panel_main_panel_button_delete[i].Location = new System.Drawing.Point(623, 0);
                this.menu2_1_panel_main_panel_button_delete[i].Name = i.ToString();
                this.menu2_1_panel_main_panel_button_delete[i].Size = new System.Drawing.Size(32, 32);
                this.menu2_1_panel_main_panel_button_delete[i].TabIndex = 1;
                this.menu2_1_panel_main_panel_button_delete[i].UseVisualStyleBackColor = false;
                this.menu2_1_panel_main_panel_button_delete[i].Click += new System.EventHandler(this.menu2_1_panel_main_panel_button_delete_Click);
                this.menu2_1_panel_main_panel_button_delete[i].MouseEnter += new System.EventHandler(this.menu2_1_panel_main_panel_button_delete_MouseEnter);
                this.menu2_1_panel_main_panel_button_delete[i].MouseLeave += new System.EventHandler(this.menu2_1_panel_main_panel_button_delete_MouseLeave);
            }
            //
            // menu2_1_panel_main_panel_button_finish
            //
            for (int i = 0; i < menu2_1_panel_main_panel_button_finish.Length; i++)
            {
                this.menu2_1_panel_main_panel_button_finish[i].BackColor = System.Drawing.Color.Transparent;
                this.menu2_1_panel_main_panel_button_finish[i].Dock = System.Windows.Forms.DockStyle.Right;
                this.menu2_1_panel_main_panel_button_finish[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.menu2_1_panel_main_panel_button_finish[i].Image = ((System.Drawing.Image)(resources.GetObject("menu2_1_panel_main_panel1_button_finish.Image")));
                this.menu2_1_panel_main_panel_button_finish[i].Location = new System.Drawing.Point(591, 0);
                this.menu2_1_panel_main_panel_button_finish[i].Name = i.ToString();
                this.menu2_1_panel_main_panel_button_finish[i].Size = new System.Drawing.Size(32, 32);
                this.menu2_1_panel_main_panel_button_finish[i].TabIndex = 2;
                this.menu2_1_panel_main_panel_button_finish[i].UseVisualStyleBackColor = false;
                this.menu2_1_panel_main_panel_button_finish[i].Click += new System.EventHandler(this.menu2_1_panel_main_panel_button_finish_Click);
                this.menu2_1_panel_main_panel_button_finish[i].MouseEnter += new System.EventHandler(this.menu2_1_panel_main_panel_button_finish_MouseEnter);
                this.menu2_1_panel_main_panel_button_finish[i].MouseLeave += new System.EventHandler(this.menu2_1_panel_main_panel_button_finish_MouseLeave);
            }
            //
            // menu2_1_panel_main_panel_label1
            //
            for (int i = 0; i < menu2_1_panel_main_panel_label1.Length; i++)
            {
                this.menu2_1_panel_main_panel_label1[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.menu2_1_panel_main_panel_label1[i].Location = new System.Drawing.Point(1, 1);
                this.menu2_1_panel_main_panel_label1[i].Name = i.ToString();
                this.menu2_1_panel_main_panel_label1[i].Size = new System.Drawing.Size(512, 30);
                this.menu2_1_panel_main_panel_label1[i].TabIndex = 0;
                this.menu2_1_panel_main_panel_label1[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.menu2_1_panel_main_panel_label1[i].Click += new System.EventHandler(this.menu2_1_panel_main_panel_label1_Click);
            }
            //
            // menu2_1_panel_main_panel_label2
            //
            for (int i = 0; i < menu2_1_panel_main_panel_label2.Length; i++)
            {
                this.menu2_1_panel_main_panel_label2[i].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.menu2_1_panel_main_panel_label2[i].Location = new System.Drawing.Point(513, 1);
                this.menu2_1_panel_main_panel_label2[i].Name = i.ToString();
                this.menu2_1_panel_main_panel_label2[i].Size = new System.Drawing.Size(76, 30);
                this.menu2_1_panel_main_panel_label2[i].TabIndex = 3;
                this.menu2_1_panel_main_panel_label2[i].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.menu2_1_panel_main_panel_label2[i].Click += new System.EventHandler(this.menu2_1_panel_main_panel_label2_Click);
            }
            // 
            // menu3
            // 
            this.menu3.Controls.Add(this.menu3_panel_main);
            this.menu3.Controls.Add(this.menu3_panel_top);
            this.menu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu3.Location = new System.Drawing.Point(0, 519);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(682, 0);
            this.menu3.TabIndex = 4;
            // 
            // menu3_panel_main
            // 
            this.menu3_panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu3_panel_main.Location = new System.Drawing.Point(0, 64);
            this.menu3_panel_main.Name = "menu3_panel_main";
            this.menu3_panel_main.Size = new System.Drawing.Size(682, 0);
            this.menu3_panel_main.TabIndex = 1;
            // 
            // menu3_panel_top
            // 
            this.menu3_panel_top.Controls.Add(this.menu3_panel_top_button_100);
            this.menu3_panel_top.Controls.Add(this.menu3_panel_top_button_nextweek);
            this.menu3_panel_top.Controls.Add(this.menu3_panel_top_button_prevweek);
            this.menu3_panel_top.Controls.Add(this.menu3_panel_top_label_title);
            this.menu3_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu3_panel_top.Location = new System.Drawing.Point(0, 0);
            this.menu3_panel_top.Name = "menu3_panel_top";
            this.menu3_panel_top.Size = new System.Drawing.Size(682, 64);
            this.menu3_panel_top.TabIndex = 0;
            // 
            // menu3_panel_top_button_100
            // 
            this.menu3_panel_top_button_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu3_panel_top_button_100.Location = new System.Drawing.Point(491, 17);
            this.menu3_panel_top_button_100.Name = "menu3_panel_top_button_100";
            this.menu3_panel_top_button_100.Size = new System.Drawing.Size(152, 34);
            this.menu3_panel_top_button_100.TabIndex = 3;
            this.menu3_panel_top_button_100.Text = "100%のみ表示";
            this.menu3_panel_top_button_100.UseVisualStyleBackColor = true;
            // 
            // menu3_panel_top_button_nextweek
            // 
            this.menu3_panel_top_button_nextweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu3_panel_top_button_nextweek.Location = new System.Drawing.Point(335, 20);
            this.menu3_panel_top_button_nextweek.Name = "menu3_panel_top_button_nextweek";
            this.menu3_panel_top_button_nextweek.Size = new System.Drawing.Size(32, 32);
            this.menu3_panel_top_button_nextweek.TabIndex = 2;
            this.menu3_panel_top_button_nextweek.Text = ">";
            this.menu3_panel_top_button_nextweek.UseVisualStyleBackColor = true;
            // 
            // menu3_panel_top_button_prevweek
            // 
            this.menu3_panel_top_button_prevweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu3_panel_top_button_prevweek.Location = new System.Drawing.Point(240, 20);
            this.menu3_panel_top_button_prevweek.Name = "menu3_panel_top_button_prevweek";
            this.menu3_panel_top_button_prevweek.Size = new System.Drawing.Size(32, 32);
            this.menu3_panel_top_button_prevweek.TabIndex = 1;
            this.menu3_panel_top_button_prevweek.Text = "<";
            this.menu3_panel_top_button_prevweek.UseVisualStyleBackColor = true;
            // 
            // menu3_panel_top_label_title
            // 
            this.menu3_panel_top_label_title.AutoSize = true;
            this.menu3_panel_top_label_title.Location = new System.Drawing.Point(282, 29);
            this.menu3_panel_top_label_title.Name = "menu3_panel_top_label_title";
            this.menu3_panel_top_label_title.Size = new System.Drawing.Size(0, 15);
            this.menu3_panel_top_label_title.TabIndex = 0;
            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 5000;
            this.tooltip.InitialDelay = 1000;
            this.tooltip.ReshowDelay = 100;
            // 
            // common_button_close
            // 
            this.common_button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.common_button_close.BackColor = System.Drawing.Color.Transparent;
            this.common_button_close.FlatAppearance.BorderSize = 0;
            this.common_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.common_button_close.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.common_button_close.ForeColor = System.Drawing.Color.Red;
            this.common_button_close.Image = ((System.Drawing.Image)(resources.GetObject("common_button_close.Image")));
            this.common_button_close.Location = new System.Drawing.Point(639, 1);
            this.common_button_close.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_close.Name = "common_button_close";
            this.common_button_close.Size = new System.Drawing.Size(42, 32);
            this.common_button_close.TabIndex = 5;
            this.tooltip.SetToolTip(this.common_button_close, "閉じる");
            this.common_button_close.UseVisualStyleBackColor = false;
            this.common_button_close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.common_button_close_MouseClick);
            this.common_button_close.MouseEnter += new System.EventHandler(this.common_button_close_MouseEnter);
            this.common_button_close.MouseLeave += new System.EventHandler(this.common_button_close_MouseLeave);
            // 
            // common_button_max
            // 
            this.common_button_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.common_button_max.BackColor = System.Drawing.Color.Transparent;
            this.common_button_max.FlatAppearance.BorderSize = 0;
            this.common_button_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.common_button_max.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.common_button_max.Image = ((System.Drawing.Image)(resources.GetObject("common_button_max.Image")));
            this.common_button_max.Location = new System.Drawing.Point(597, 1);
            this.common_button_max.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_max.Name = "common_button_max";
            this.common_button_max.Size = new System.Drawing.Size(42, 32);
            this.common_button_max.TabIndex = 6;
            this.tooltip.SetToolTip(this.common_button_max, "最大化");
            this.common_button_max.UseVisualStyleBackColor = false;
            this.common_button_max.MouseClick += new System.Windows.Forms.MouseEventHandler(this.common_button_max_MouseClick);
            // 
            // common_button_min
            // 
            this.common_button_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.common_button_min.BackColor = System.Drawing.Color.Transparent;
            this.common_button_min.FlatAppearance.BorderSize = 0;
            this.common_button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.common_button_min.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.common_button_min.Image = ((System.Drawing.Image)(resources.GetObject("common_button_min.Image")));
            this.common_button_min.Location = new System.Drawing.Point(555, 1);
            this.common_button_min.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_min.Name = "common_button_min";
            this.common_button_min.Size = new System.Drawing.Size(42, 32);
            this.common_button_min.TabIndex = 7;
            this.tooltip.SetToolTip(this.common_button_min, "最小化");
            this.common_button_min.UseVisualStyleBackColor = false;
            this.common_button_min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.common_button_min_MouseClick);
            // 
            // menutask
            // 
            this.menutask.BorderColor = System.Drawing.Color.Black;
            this.menutask.Controls.Add(this.menutask_button_close);
            this.menutask.Controls.Add(this.menutask_table4);
            this.menutask.Controls.Add(this.menutask_table3);
            this.menutask.Controls.Add(this.menutask_table2);
            this.menutask.Controls.Add(this.menutask_button_save);
            this.menutask.Controls.Add(this.menutask_table1);
            this.menutask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menutask.Location = new System.Drawing.Point(0, 1290);
            this.menutask.Name = "menutask";
            this.menutask.Size = new System.Drawing.Size(682, 0);
            this.menutask.TabIndex = 32;
            // 
            // menutask_button_close
            // 
            this.menutask_button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menutask_button_close.FlatAppearance.BorderSize = 0;
            this.menutask_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menutask_button_close.Image = ((System.Drawing.Image)(resources.GetObject("menutask_button_close.Image")));
            this.menutask_button_close.Location = new System.Drawing.Point(649, 1);
            this.menutask_button_close.Name = "menutask_button_close";
            this.menutask_button_close.Size = new System.Drawing.Size(32, 32);
            this.menutask_button_close.TabIndex = 5;
            this.menutask_button_close.UseVisualStyleBackColor = true;
            this.menutask_button_close.Click += new System.EventHandler(this.menutask_button_close_Click);
            // 
            // menutask_table4
            // 
            this.menutask_table4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menutask_table4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menutask_table4.ColumnCount = 2;
            this.menutask_table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menutask_table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.5814F));
            this.menutask_table4.Controls.Add(this.menutask_table4_label, 0, 0);
            this.menutask_table4.Location = new System.Drawing.Point(14, 245);
            this.menutask_table4.Name = "menutask_table4";
            this.menutask_table4.RowCount = 1;
            this.menutask_table4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menutask_table4.Size = new System.Drawing.Size(629, 26);
            this.menutask_table4.TabIndex = 4;
            // 
            // menutask_table4_label
            // 
            this.menutask_table4_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table4_label.Location = new System.Drawing.Point(4, 1);
            this.menutask_table4_label.Name = "menutask_table4_label";
            this.menutask_table4_label.Size = new System.Drawing.Size(44, 24);
            this.menutask_table4_label.TabIndex = 1;
            this.menutask_table4_label.Text = "色";
            this.menutask_table4_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menutask_table3
            // 
            this.menutask_table3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menutask_table3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menutask_table3.ColumnCount = 1;
            this.menutask_table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menutask_table3.Controls.Add(this.menutask_table3_label, 0, 0);
            this.menutask_table3.Controls.Add(this.menutask_table3_text, 0, 1);
            this.menutask_table3.Location = new System.Drawing.Point(14, 78);
            this.menutask_table3.Name = "menutask_table3";
            this.menutask_table3.RowCount = 2;
            this.menutask_table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.menutask_table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.95652F));
            this.menutask_table3.Size = new System.Drawing.Size(629, 161);
            this.menutask_table3.TabIndex = 3;
            // 
            // menutask_table3_label
            // 
            this.menutask_table3_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table3_label.Location = new System.Drawing.Point(4, 1);
            this.menutask_table3_label.Name = "menutask_table3_label";
            this.menutask_table3_label.Size = new System.Drawing.Size(621, 15);
            this.menutask_table3_label.TabIndex = 0;
            this.menutask_table3_label.Text = "備考";
            this.menutask_table3_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menutask_table3_text
            // 
            this.menutask_table3_text.AcceptsReturn = true;
            this.menutask_table3_text.AcceptsTab = true;
            this.menutask_table3_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table3_text.Location = new System.Drawing.Point(1, 17);
            this.menutask_table3_text.Margin = new System.Windows.Forms.Padding(0);
            this.menutask_table3_text.Multiline = true;
            this.menutask_table3_text.Name = "menutask_table3_text";
            this.menutask_table3_text.Size = new System.Drawing.Size(627, 143);
            this.menutask_table3_text.TabIndex = 1;
            // 
            // menutask_table2
            // 
            this.menutask_table2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menutask_table2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menutask_table2.ColumnCount = 4;
            this.menutask_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.menutask_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.73292F));
            this.menutask_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.menutask_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.menutask_table2.Controls.Add(this.menutask_table2_check, 0, 0);
            this.menutask_table2.Controls.Add(this.dateTimePicker1, 1, 0);
            this.menutask_table2.Controls.Add(this.dateTimePicker2, 3, 0);
            this.menutask_table2.Location = new System.Drawing.Point(14, 42);
            this.menutask_table2.Name = "menutask_table2";
            this.menutask_table2.RowCount = 1;
            this.menutask_table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menutask_table2.Size = new System.Drawing.Size(629, 26);
            this.menutask_table2.TabIndex = 2;
            // 
            // menutask_table2_check
            // 
            this.menutask_table2_check.AutoSize = true;
            this.menutask_table2_check.Location = new System.Drawing.Point(4, 4);
            this.menutask_table2_check.Name = "menutask_table2_check";
            this.menutask_table2_check.Size = new System.Drawing.Size(50, 18);
            this.menutask_table2_check.TabIndex = 0;
            this.menutask_table2_check.Text = "期間";
            this.menutask_table2_check.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 1);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Location = new System.Drawing.Point(326, 1);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(302, 23);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // menutask_button_save
            // 
            this.menutask_button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menutask_button_save.Location = new System.Drawing.Point(0, -28);
            this.menutask_button_save.Name = "menutask_button_save";
            this.menutask_button_save.Size = new System.Drawing.Size(682, 28);
            this.menutask_button_save.TabIndex = 1;
            this.menutask_button_save.Text = "保存";
            this.menutask_button_save.UseVisualStyleBackColor = true;
            this.menutask_button_save.Click += new System.EventHandler(this.menutask_button_save_Click);
            // 
            // menutask_table1
            // 
            this.menutask_table1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menutask_table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menutask_table1.ColumnCount = 2;
            this.menutask_table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.menutask_table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.8882F));
            this.menutask_table1.Controls.Add(this.menutask_table1_label, 0, 0);
            this.menutask_table1.Controls.Add(this.menutask_table1_text, 1, 0);
            this.menutask_table1.Location = new System.Drawing.Point(14, 9);
            this.menutask_table1.Name = "menutask_table1";
            this.menutask_table1.RowCount = 1;
            this.menutask_table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menutask_table1.Size = new System.Drawing.Size(629, 26);
            this.menutask_table1.TabIndex = 0;
            // 
            // menutask_table1_label
            // 
            this.menutask_table1_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table1_label.Location = new System.Drawing.Point(4, 1);
            this.menutask_table1_label.Name = "menutask_table1_label";
            this.menutask_table1_label.Size = new System.Drawing.Size(50, 24);
            this.menutask_table1_label.TabIndex = 0;
            this.menutask_table1_label.Text = "タスク名";
            this.menutask_table1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menutask_table1_text
            // 
            this.menutask_table1_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table1_text.Location = new System.Drawing.Point(58, 1);
            this.menutask_table1_text.Margin = new System.Windows.Forms.Padding(0);
            this.menutask_table1_text.Name = "menutask_table1_text";
            this.menutask_table1_text.Size = new System.Drawing.Size(570, 23);
            this.menutask_table1_text.TabIndex = 1;
            // 
            // menuachieve
            // 
            this.menuachieve.BorderColor = System.Drawing.Color.Black;
            this.menuachieve.Controls.Add(this.menuachieve_table4);
            this.menuachieve.Controls.Add(this.menuachieve_button_close);
            this.menuachieve.Controls.Add(this.menuachieve_table3);
            this.menuachieve.Controls.Add(this.menuachieve_table2);
            this.menuachieve.Controls.Add(this.menuachieve_table1);
            this.menuachieve.Controls.Add(this.menuachieve_button_save);
            this.menuachieve.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuachieve.Location = new System.Drawing.Point(0, 1290);
            this.menuachieve.Name = "menuachieve";
            this.menuachieve.Size = new System.Drawing.Size(682, 0);
            this.menuachieve.TabIndex = 1;
            // 
            // menuachieve_table4
            // 
            this.menuachieve_table4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuachieve_table4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menuachieve_table4.ColumnCount = 1;
            this.menuachieve_table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuachieve_table4.Controls.Add(this.menuachieve_table4_label, 0, 0);
            this.menuachieve_table4.Controls.Add(this.menuachieve_table4_text, 0, 1);
            this.menuachieve_table4.Location = new System.Drawing.Point(14, 111);
            this.menuachieve_table4.Name = "menuachieve_table4";
            this.menuachieve_table4.RowCount = 2;
            this.menuachieve_table4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.menuachieve_table4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.95652F));
            this.menuachieve_table4.Size = new System.Drawing.Size(629, 87);
            this.menuachieve_table4.TabIndex = 7;
            // 
            // menuachieve_table4_label
            // 
            this.menuachieve_table4_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table4_label.Location = new System.Drawing.Point(4, 1);
            this.menuachieve_table4_label.Name = "menuachieve_table4_label";
            this.menuachieve_table4_label.Size = new System.Drawing.Size(621, 15);
            this.menuachieve_table4_label.TabIndex = 0;
            this.menuachieve_table4_label.Text = "備考";
            this.menuachieve_table4_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuachieve_table4_text
            // 
            this.menuachieve_table4_text.AcceptsReturn = true;
            this.menuachieve_table4_text.AcceptsTab = true;
            this.menuachieve_table4_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table4_text.Location = new System.Drawing.Point(1, 17);
            this.menuachieve_table4_text.Margin = new System.Windows.Forms.Padding(0);
            this.menuachieve_table4_text.Multiline = true;
            this.menuachieve_table4_text.Name = "menuachieve_table4_text";
            this.menuachieve_table4_text.Size = new System.Drawing.Size(627, 69);
            this.menuachieve_table4_text.TabIndex = 1;
            // 
            // menuachieve_button_close
            // 
            this.menuachieve_button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuachieve_button_close.FlatAppearance.BorderSize = 0;
            this.menuachieve_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuachieve_button_close.Image = ((System.Drawing.Image)(resources.GetObject("menuachieve_button_close.Image")));
            this.menuachieve_button_close.Location = new System.Drawing.Point(649, 1);
            this.menuachieve_button_close.Name = "menuachieve_button_close";
            this.menuachieve_button_close.Size = new System.Drawing.Size(32, 32);
            this.menuachieve_button_close.TabIndex = 6;
            this.menuachieve_button_close.UseVisualStyleBackColor = true;
            this.menuachieve_button_close.Click += new System.EventHandler(this.menuachieve_button_close_Click);
            // 
            // menuachieve_table3
            // 
            this.menuachieve_table3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuachieve_table3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menuachieve_table3.ColumnCount = 2;
            this.menuachieve_table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.menuachieve_table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.8882F));
            this.menuachieve_table3.Controls.Add(this.menuachieve_table3_label, 0, 0);
            this.menuachieve_table3.Controls.Add(this.menuachieve_table3_text, 1, 0);
            this.menuachieve_table3.Location = new System.Drawing.Point(14, 79);
            this.menuachieve_table3.Name = "menuachieve_table3";
            this.menuachieve_table3.RowCount = 1;
            this.menuachieve_table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuachieve_table3.Size = new System.Drawing.Size(629, 26);
            this.menuachieve_table3.TabIndex = 3;
            // 
            // menuachieve_table3_label
            // 
            this.menuachieve_table3_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table3_label.Location = new System.Drawing.Point(4, 1);
            this.menuachieve_table3_label.Name = "menuachieve_table3_label";
            this.menuachieve_table3_label.Size = new System.Drawing.Size(50, 24);
            this.menuachieve_table3_label.TabIndex = 0;
            this.menuachieve_table3_label.Text = "時間";
            this.menuachieve_table3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuachieve_table3_text
            // 
            this.menuachieve_table3_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table3_text.Location = new System.Drawing.Point(58, 1);
            this.menuachieve_table3_text.Margin = new System.Windows.Forms.Padding(0);
            this.menuachieve_table3_text.Name = "menuachieve_table3_text";
            this.menuachieve_table3_text.Size = new System.Drawing.Size(570, 23);
            this.menuachieve_table3_text.TabIndex = 1;
            // 
            // menuachieve_table2
            // 
            this.menuachieve_table2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuachieve_table2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menuachieve_table2.ColumnCount = 2;
            this.menuachieve_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.menuachieve_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.8882F));
            this.menuachieve_table2.Controls.Add(this.menuachieve_table2_label, 0, 0);
            this.menuachieve_table2.Controls.Add(this.menuachieve_table2_text, 1, 0);
            this.menuachieve_table2.Location = new System.Drawing.Point(14, 47);
            this.menuachieve_table2.Name = "menuachieve_table2";
            this.menuachieve_table2.RowCount = 1;
            this.menuachieve_table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuachieve_table2.Size = new System.Drawing.Size(629, 26);
            this.menuachieve_table2.TabIndex = 2;
            // 
            // menuachieve_table2_label
            // 
            this.menuachieve_table2_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table2_label.Location = new System.Drawing.Point(4, 1);
            this.menuachieve_table2_label.Name = "menuachieve_table2_label";
            this.menuachieve_table2_label.Size = new System.Drawing.Size(50, 24);
            this.menuachieve_table2_label.TabIndex = 0;
            this.menuachieve_table2_label.Text = "進捗";
            this.menuachieve_table2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuachieve_table2_text
            // 
            this.menuachieve_table2_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table2_text.Location = new System.Drawing.Point(58, 1);
            this.menuachieve_table2_text.Margin = new System.Windows.Forms.Padding(0);
            this.menuachieve_table2_text.Name = "menuachieve_table2_text";
            this.menuachieve_table2_text.Size = new System.Drawing.Size(570, 23);
            this.menuachieve_table2_text.TabIndex = 1;
            // 
            // menuachieve_table1
            // 
            this.menuachieve_table1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuachieve_table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menuachieve_table1.ColumnCount = 2;
            this.menuachieve_table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.menuachieve_table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.8882F));
            this.menuachieve_table1.Controls.Add(this.menuachieve_table1_label, 0, 0);
            this.menuachieve_table1.Controls.Add(this.menuachieve_table1_text, 1, 0);
            this.menuachieve_table1.Location = new System.Drawing.Point(14, 15);
            this.menuachieve_table1.Name = "menuachieve_table1";
            this.menuachieve_table1.RowCount = 1;
            this.menuachieve_table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuachieve_table1.Size = new System.Drawing.Size(629, 26);
            this.menuachieve_table1.TabIndex = 1;
            // 
            // menuachieve_table1_label
            // 
            this.menuachieve_table1_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table1_label.Location = new System.Drawing.Point(4, 1);
            this.menuachieve_table1_label.Name = "menuachieve_table1_label";
            this.menuachieve_table1_label.Size = new System.Drawing.Size(50, 24);
            this.menuachieve_table1_label.TabIndex = 0;
            this.menuachieve_table1_label.Text = "実績名";
            this.menuachieve_table1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuachieve_table1_text
            // 
            this.menuachieve_table1_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table1_text.Location = new System.Drawing.Point(58, 1);
            this.menuachieve_table1_text.Margin = new System.Windows.Forms.Padding(0);
            this.menuachieve_table1_text.Name = "menuachieve_table1_text";
            this.menuachieve_table1_text.Size = new System.Drawing.Size(570, 23);
            this.menuachieve_table1_text.TabIndex = 1;
            // 
            // menuachieve_button_save
            // 
            this.menuachieve_button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuachieve_button_save.Location = new System.Drawing.Point(0, -32);
            this.menuachieve_button_save.Name = "menuachieve_button_save";
            this.menuachieve_button_save.Size = new System.Drawing.Size(682, 32);
            this.menuachieve_button_save.TabIndex = 0;
            this.menuachieve_button_save.Text = "保存";
            this.menuachieve_button_save.UseVisualStyleBackColor = true;
            this.menuachieve_button_save.Click += new System.EventHandler(this.menuachieve_button_save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(682, 1290);
            this.Controls.Add(this.common_panel_setting);
            this.Controls.Add(this.common_button_min);
            this.Controls.Add(this.common_button_max);
            this.Controls.Add(this.common_button_close);
            this.Controls.Add(this.menu3);
            this.Controls.Add(this.menutask);
            this.Controls.Add(this.menuachieve);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.common);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(681, 100);
            this.Name = "MainForm";
            this.Text = "タスク管理";
            this.common.ResumeLayout(false);
            this.menu1_panel_calendertop.ResumeLayout(false);
            this.menu1_panel_calendertop_panel_yearmonth.ResumeLayout(false);
            this.menu1_panel_calendertop_panel_yearmonth.PerformLayout();
            this.common_panel_setting.ResumeLayout(false);
            this.common_panel_setting_table_setting.ResumeLayout(false);
            this.common_panel_setting_table_setting.PerformLayout();
            this.menu1.ResumeLayout(false);
            this.menu1_table_calender.ResumeLayout(false);
            this.menu1_table_calender.PerformLayout();

            for (int i = 0; i < menu1_table_calender_panel_day.Length; i++)
            {
                this.menu1_table_calender_panel_day[i].ResumeLayout(false);
            }
            this.menu2.ResumeLayout(false);
            this.menu2_3.ResumeLayout(false);
            this.menu2_3_panel.ResumeLayout(false);
            this.menu2_3_panel_top.ResumeLayout(false);
            this.menu2_3_panel_main.ResumeLayout(false);
            this.menu2_3_panel_main_panel25.ResumeLayout(false);
            this.menu2_3_panel_main_panel24.ResumeLayout(false);
            this.menu2_3_panel_main_panel23.ResumeLayout(false);
            this.menu2_3_panel_main_panel22.ResumeLayout(false);
            this.menu2_3_panel_main_panel21.ResumeLayout(false);
            this.menu2_3_panel_main_panel20.ResumeLayout(false);
            this.menu2_3_panel_main_panel19.ResumeLayout(false);
            this.menu2_3_panel_main_panel18.ResumeLayout(false);
            this.menu2_3_panel_main_panel17.ResumeLayout(false);
            this.menu2_3_panel_main_panel16.ResumeLayout(false);
            this.menu2_3_panel_main_panel15.ResumeLayout(false);
            this.menu2_3_panel_main_panel14.ResumeLayout(false);
            this.menu2_3_panel_main_panel13.ResumeLayout(false);
            this.menu2_3_panel_main_panel12.ResumeLayout(false);
            this.menu2_3_panel_main_panel11.ResumeLayout(false);
            this.menu2_3_panel_main_panel10.ResumeLayout(false);
            this.menu2_3_panel_main_panel9.ResumeLayout(false);
            this.menu2_3_panel_main_panel8.ResumeLayout(false);
            this.menu2_3_panel_main_panel7.ResumeLayout(false);
            this.menu2_3_panel_main_panel6.ResumeLayout(false);
            this.menu2_3_panel_main_panel5.ResumeLayout(false);
            this.menu2_3_panel_main_panel4.ResumeLayout(false);
            this.menu2_3_panel_main_panel3.ResumeLayout(false);
            this.menu2_3_panel_main_panel2.ResumeLayout(false);
            this.menu2_3_panel_main_panel1.ResumeLayout(false);
            this.menu2_2.ResumeLayout(false);
            this.menu2_2_panel.ResumeLayout(false);
            this.menu2_2_panel_top.ResumeLayout(false);
            this.menu2_2_panel_main.ResumeLayout(false);

            for (int i = menu2_2_panel_main_panel.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel[i].ResumeLayout(false);
            }
            for (int i = menu2_2_panel_main_panel_table_memo.Length - 1; i >= 0; i--)
            {
                this.menu2_2_panel_main_panel_table_memo[i].ResumeLayout(false);
                this.menu2_2_panel_main_panel_table_memo[i].PerformLayout();
            }

            this.menu2_1.ResumeLayout(false);
            this.menu2_1_panel.ResumeLayout(false);
            this.menu2_1_panel_top.ResumeLayout(false);
            this.menu2_1_panel_main.ResumeLayout(false);

            for (int i = 0; i < menu2_1_panel_main_panel.Length; i++)
            {
                this.menu2_1_panel_main_panel[i].ResumeLayout(false);
            }

            this.menu3.ResumeLayout(false);
            this.menu3_panel_top.ResumeLayout(false);
            this.menu3_panel_top.PerformLayout();
            this.menutask.ResumeLayout(false);
            this.menutask_table4.ResumeLayout(false);
            this.menutask_table3.ResumeLayout(false);
            this.menutask_table3.PerformLayout();
            this.menutask_table2.ResumeLayout(false);
            this.menutask_table2.PerformLayout();
            this.menutask_table1.ResumeLayout(false);
            this.menutask_table1.PerformLayout();
            this.menuachieve.ResumeLayout(false);
            this.menuachieve_table4.ResumeLayout(false);
            this.menuachieve_table4.PerformLayout();
            this.menuachieve_table3.ResumeLayout(false);
            this.menuachieve_table3.PerformLayout();
            this.menuachieve_table2.ResumeLayout(false);
            this.menuachieve_table2.PerformLayout();
            this.menuachieve_table1.ResumeLayout(false);
            this.menuachieve_table1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}