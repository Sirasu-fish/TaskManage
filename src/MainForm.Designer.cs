﻿using System.Windows.Forms;
using System.Drawing;
using System;

namespace TaskManege
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
        private PanelEx common;
        private Button common_button_close;
        private Button common_button_max;
        private Button common_button_min;
        private Button common_button_nextmenu;
        private Button common_button_prevmenu;
        private Button common_button_setting;
        private Panel common_panel_setting;
        private CheckBox common_panel_setting_table_check1;
        private CheckBox common_panel_setting_table_check3;
        private ComboBox common_panel_setting_table_combo2;
        private Label common_panel_setting_table_label1;
        private Label common_panel_setting_table_label2;
        private Label common_panel_setting_table_label3;
        private TableLayoutPanel common_panel_setting_table_setting;

        // ■■■■■■■■■■■■■■■■■■■■■　menu1　■■■■■■■■■■■■■■■■■■■■■
        private PanelEx menu1;
        private Panel menu1_panel_calendertop;
        private Button menu1_panel_calendertop_button_nextmonth;
        private Button menu1_panel_calendertop_button_onoff;
        private Button menu1_panel_calendertop_button_prevmonth;
        private Panel menu1_panel_calendertop_panel_yearmonth;
        private ComboBox menu1_panel_calendertop_panel_yearmonth_combo_month;
        private ComboBox menu1_panel_calendertop_panel_yearmonth_combo_year;
        private Label menu1_panel_calendertop_panel_yearmonth_label_month;
        private Label menu1_panel_calendertop_panel_yearmonth_label_year;
        private TableLayoutPanel menu1_table_calender;
        private Label menu1_table_calender_label_day1;
        private Label menu1_table_calender_label_day10;
        private Label menu1_table_calender_label_day11;
        private Label menu1_table_calender_label_day12;
        private Label menu1_table_calender_label_day13;
        private Label menu1_table_calender_label_day14;
        private Label menu1_table_calender_label_day15;
        private Label menu1_table_calender_label_day16;
        private Label menu1_table_calender_label_day17;
        private Label menu1_table_calender_label_day18;
        private Label menu1_table_calender_label_day19;
        private Label menu1_table_calender_label_day2;
        private Label menu1_table_calender_label_day20;
        private Label menu1_table_calender_label_day21;
        private Label menu1_table_calender_label_day22;
        private Label menu1_table_calender_label_day23;
        private Label menu1_table_calender_label_day24;
        private Label menu1_table_calender_label_day25;
        private Label menu1_table_calender_label_day26;
        private Label menu1_table_calender_label_day27;
        private Label menu1_table_calender_label_day28;
        private Label menu1_table_calender_label_day29;
        private Label menu1_table_calender_label_day3;
        private Label menu1_table_calender_label_day30;
        private Label menu1_table_calender_label_day31;
        private Label menu1_table_calender_label_day32;
        private Label menu1_table_calender_label_day33;
        private Label menu1_table_calender_label_day34;
        private Label menu1_table_calender_label_day35;
        private Label menu1_table_calender_label_day36;
        private Label menu1_table_calender_label_day37;
        private Label menu1_table_calender_label_day38;
        private Label menu1_table_calender_label_day39;
        private Label menu1_table_calender_label_day4;
        private Label menu1_table_calender_label_day40;
        private Label menu1_table_calender_label_day41;
        private Label menu1_table_calender_label_day42;
        private Label menu1_table_calender_label_day5;
        private Label menu1_table_calender_label_day6;
        private Label menu1_table_calender_label_day7;
        private Label menu1_table_calender_label_day8;
        private Label menu1_table_calender_label_day9;
        private Label menu1_table_calender_label_friday;
        private Label menu1_table_calender_label_monday;
        private Label menu1_table_calender_label_saturday;
        private Label menu1_table_calender_label_sunday;
        private Label menu1_table_calender_label_thursday;
        private Label menu1_table_calender_label_tuesday;
        private Label menu1_table_calender_label_wednesday;
        private Panel menu1_table_calender_panel_day1;
        private Panel menu1_table_calender_panel_day10;
        private Panel menu1_table_calender_panel_day11;
        private Panel menu1_table_calender_panel_day12;
        private Panel menu1_table_calender_panel_day13;
        private Panel menu1_table_calender_panel_day14;
        private Panel menu1_table_calender_panel_day15;
        private Panel menu1_table_calender_panel_day16;
        private Panel menu1_table_calender_panel_day17;
        private Panel menu1_table_calender_panel_day18;
        private Panel menu1_table_calender_panel_day19;
        private Panel menu1_table_calender_panel_day2;
        private Panel menu1_table_calender_panel_day20;
        private Panel menu1_table_calender_panel_day21;
        private Panel menu1_table_calender_panel_day22;
        private Panel menu1_table_calender_panel_day23;
        private Panel menu1_table_calender_panel_day24;
        private Panel menu1_table_calender_panel_day25;
        private Panel menu1_table_calender_panel_day26;
        private Panel menu1_table_calender_panel_day27;
        private Panel menu1_table_calender_panel_day28;
        private Panel menu1_table_calender_panel_day29;
        private Panel menu1_table_calender_panel_day3;
        private Panel menu1_table_calender_panel_day30;
        private Panel menu1_table_calender_panel_day31;
        private Panel menu1_table_calender_panel_day32;
        private Panel menu1_table_calender_panel_day33;
        private Panel menu1_table_calender_panel_day34;
        private Panel menu1_table_calender_panel_day35;
        private Panel menu1_table_calender_panel_day36;
        private Panel menu1_table_calender_panel_day37;
        private Panel menu1_table_calender_panel_day38;
        private Panel menu1_table_calender_panel_day39;
        private Panel menu1_table_calender_panel_day4;
        private Panel menu1_table_calender_panel_day40;
        private Panel menu1_table_calender_panel_day41;
        private Panel menu1_table_calender_panel_day42;
        private Panel menu1_table_calender_panel_day5;
        private Panel menu1_table_calender_panel_day6;
        private Panel menu1_table_calender_panel_day7;
        private Panel menu1_table_calender_panel_day8;
        private Panel menu1_table_calender_panel_day9;

        // ■■■■■■■■■■■■■■■■■■■■■　menu2　■■■■■■■■■■■■■■■■■■■■■
        private Panel menu2;
        private Panel menu2_1;
        private PanelEx menu2_1_panel;
        private Panel menu2_1_panel_main;
        private PanelEx menu2_1_panel_main_panel1;
        private Button menu2_1_panel_main_panel1_button_delete;
        private Button menu2_1_panel_main_panel1_button_finish;
        private Label menu2_1_panel_main_panel1_label1;
        private Label menu2_1_panel_main_panel1_label2;
        private PanelEx menu2_1_panel_main_panel10;
        private Button menu2_1_panel_main_panel10_button_delete;
        private Button menu2_1_panel_main_panel10_button_finish;
        private Label menu2_1_panel_main_panel10_label1;
        private Label menu2_1_panel_main_panel10_label2;
        private PanelEx menu2_1_panel_main_panel11;
        private Button menu2_1_panel_main_panel11_button_delete;
        private Button menu2_1_panel_main_panel11_button_finish;
        private Label menu2_1_panel_main_panel11_label1;
        private Label menu2_1_panel_main_panel11_label2;
        private PanelEx menu2_1_panel_main_panel12;
        private Button menu2_1_panel_main_panel12_button_delete;
        private Button menu2_1_panel_main_panel12_button_finish;
        private Label menu2_1_panel_main_panel12_label1;
        private Label menu2_1_panel_main_panel12_label2;
        private PanelEx menu2_1_panel_main_panel13;
        private Button menu2_1_panel_main_panel13_button_delete;
        private Button menu2_1_panel_main_panel13_button_finish;
        private Label menu2_1_panel_main_panel13_label1;
        private Label menu2_1_panel_main_panel13_label2;
        private PanelEx menu2_1_panel_main_panel14;
        private Button menu2_1_panel_main_panel14_button_delete;
        private Button menu2_1_panel_main_panel14_button_finish;
        private Label menu2_1_panel_main_panel14_label1;
        private Label menu2_1_panel_main_panel14_label2;
        private PanelEx menu2_1_panel_main_panel15;
        private Button menu2_1_panel_main_panel15_button_delete;
        private Button menu2_1_panel_main_panel15_button_finish;
        private Label menu2_1_panel_main_panel15_label1;
        private Label menu2_1_panel_main_panel15_label2;
        private PanelEx menu2_1_panel_main_panel16;
        private Button menu2_1_panel_main_panel16_button_delete;
        private Button menu2_1_panel_main_panel16_button_finish;
        private Label menu2_1_panel_main_panel16_label1;
        private Label menu2_1_panel_main_panel16_label2;
        private PanelEx menu2_1_panel_main_panel17;
        private Button menu2_1_panel_main_panel17_button_delete;
        private Button menu2_1_panel_main_panel17_button_finish;
        private Label menu2_1_panel_main_panel17_label1;
        private Label menu2_1_panel_main_panel17_label2;
        private PanelEx menu2_1_panel_main_panel18;
        private Button menu2_1_panel_main_panel18_button_delete;
        private Button menu2_1_panel_main_panel18_button_finish;
        private Label menu2_1_panel_main_panel18_label1;
        private Label menu2_1_panel_main_panel18_label2;
        private PanelEx menu2_1_panel_main_panel19;
        private Button menu2_1_panel_main_panel19_button_delete;
        private Button menu2_1_panel_main_panel19_button_finish;
        private Label menu2_1_panel_main_panel19_label1;
        private Label menu2_1_panel_main_panel19_label2;
        private PanelEx menu2_1_panel_main_panel2;
        private Button menu2_1_panel_main_panel2_button_delete;
        private Button menu2_1_panel_main_panel2_button_finish;
        private Label menu2_1_panel_main_panel2_label1;
        private Label menu2_1_panel_main_panel2_label2;
        private PanelEx menu2_1_panel_main_panel20;
        private Button menu2_1_panel_main_panel20_button_delete;
        private Button menu2_1_panel_main_panel20_button_finish;
        private Label menu2_1_panel_main_panel20_label1;
        private Label menu2_1_panel_main_panel20_label2;
        private PanelEx menu2_1_panel_main_panel21;
        private Button menu2_1_panel_main_panel21_button_delete;
        private Button menu2_1_panel_main_panel21_button_finish;
        private Label menu2_1_panel_main_panel21_label1;
        private Label menu2_1_panel_main_panel21_label2;
        private PanelEx menu2_1_panel_main_panel22;
        private Button menu2_1_panel_main_panel22_button_delete;
        private Button menu2_1_panel_main_panel22_button_finish;
        private Label menu2_1_panel_main_panel22_label1;
        private Label menu2_1_panel_main_panel22_label2;
        private PanelEx menu2_1_panel_main_panel23;
        private Button menu2_1_panel_main_panel23_button_delete;
        private Button menu2_1_panel_main_panel23_button_finish;
        private Label menu2_1_panel_main_panel23_label1;
        private Label menu2_1_panel_main_panel23_label2;
        private PanelEx menu2_1_panel_main_panel24;
        private Button menu2_1_panel_main_panel24_button_delete;
        private Button menu2_1_panel_main_panel24_button_finish;
        private Label menu2_1_panel_main_panel24_label1;
        private Label menu2_1_panel_main_panel24_label2;
        private PanelEx menu2_1_panel_main_panel25;
        private Button menu2_1_panel_main_panel25_button_delete;
        private Button menu2_1_panel_main_panel25_button_finish;
        private Label menu2_1_panel_main_panel25_label1;
        private Label menu2_1_panel_main_panel25_label2;
        private PanelEx menu2_1_panel_main_panel3;
        private Button menu2_1_panel_main_panel3_button_delete;
        private Button menu2_1_panel_main_panel3_button_finish;
        private Label menu2_1_panel_main_panel3_label1;
        private Label menu2_1_panel_main_panel3_label2;
        private PanelEx menu2_1_panel_main_panel4;
        private Button menu2_1_panel_main_panel4_button_delete;
        private Button menu2_1_panel_main_panel4_button_finish;
        private Label menu2_1_panel_main_panel4_label1;
        private Label menu2_1_panel_main_panel4_label2;
        private PanelEx menu2_1_panel_main_panel5;
        private Button menu2_1_panel_main_panel5_button_delete;
        private Button menu2_1_panel_main_panel5_button_finish;
        private Label menu2_1_panel_main_panel5_label1;
        private Label menu2_1_panel_main_panel5_label2;
        private PanelEx menu2_1_panel_main_panel6;
        private Button menu2_1_panel_main_panel6_button_delete;
        private Button menu2_1_panel_main_panel6_button_finish;
        private Label menu2_1_panel_main_panel6_label1;
        private Label menu2_1_panel_main_panel6_label2;
        private PanelEx menu2_1_panel_main_panel7;
        private Button menu2_1_panel_main_panel7_button_delete;
        private Button menu2_1_panel_main_panel7_button_finish;
        private Label menu2_1_panel_main_panel7_label1;
        private Label menu2_1_panel_main_panel7_label2;
        private PanelEx menu2_1_panel_main_panel8;
        private Button menu2_1_panel_main_panel8_button_delete;
        private Button menu2_1_panel_main_panel8_button_finish;
        private Label menu2_1_panel_main_panel8_label1;
        private Label menu2_1_panel_main_panel8_label2;
        private PanelEx menu2_1_panel_main_panel9;
        private Button menu2_1_panel_main_panel9_button_delete;
        private Button menu2_1_panel_main_panel9_button_finish;
        private Label menu2_1_panel_main_panel9_label1;
        private Label menu2_1_panel_main_panel9_label2;
        private Panel menu2_1_panel_margin;
        private Panel menu2_1_panel_top;
        private Button menu2_1_panel_top_button_add;
        private Button menu2_1_panel_top_button_movedown;
        private Button menu2_1_panel_top_button_moveup;
        private Button menu2_1_panel_top_button_openclose;
        private Circlelabel menu2_1_panel_top_label_num;
        private Label menu2_1_panel_top_label_title;

        private Panel menu2_2;
        private PanelEx menu2_2_panel;
        private Panel menu2_2_panel_main;
        private Panel menu2_2_panel_main_panel1;
        private TableLayoutPanel menu2_2_panel_main_panel1_table_memo;
        private Panel menu2_2_panel_main_panel1_table_memo_panel_top;
        private Button menu2_2_panel_main_panel1_table_memo_panel_top_button_close;
        private Button menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax;
        private Button menu2_2_panel_main_panel1_table_memo_panel_top_button_save;
        private TextBox menu2_2_panel_main_panel1_table_memo_panel_top_text;
        private TextBox menu2_2_panel_main_panel1_table_memo_text;
        private Panel menu2_2_panel_main_panel2;
        private TableLayoutPanel menu2_2_panel_main_panel2_table_memo;
        private Panel menu2_2_panel_main_panel2_table_memo_panel_top;
        private Button menu2_2_panel_main_panel2_table_memo_panel_top_button_close;
        private Button menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax;
        private Button menu2_2_panel_main_panel2_table_memo_panel_top_button_save;
        private TextBox menu2_2_panel_main_panel2_table_memo_panel_top_text;
        private TextBox menu2_2_panel_main_panel2_table_memo_text;
        private Panel menu2_2_panel_main_panel3;
        private TableLayoutPanel menu2_2_panel_main_panel3_table_memo;
        private Panel menu2_2_panel_main_panel3_table_memo_panel_top;
        private Button menu2_2_panel_main_panel3_table_memo_panel_top_button_close;
        private Button menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax;
        private Button menu2_2_panel_main_panel3_table_memo_panel_top_button_save;
        private TextBox menu2_2_panel_main_panel3_table_memo_panel_top_text;
        private TextBox menu2_2_panel_main_panel3_table_memo_text;
        private Panel menu2_2_panel_main_panel4;
        private TableLayoutPanel menu2_2_panel_main_panel4_table_memo;
        private Panel menu2_2_panel_main_panel4_table_memo_panel_top;
        private Button menu2_2_panel_main_panel4_table_memo_panel_top_button_close;
        private Button menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax;
        private Button menu2_2_panel_main_panel4_table_memo_panel_top_button_save;
        private TextBox menu2_2_panel_main_panel4_table_memo_panel_top_text;
        private TextBox menu2_2_panel_main_panel4_table_memo_text;
        private Panel menu2_2_panel_main_panel5;
        private TableLayoutPanel menu2_2_panel_main_panel5_table_memo;
        private Panel menu2_2_panel_main_panel5_table_memo_panel_top;
        private Button menu2_2_panel_main_panel5_table_memo_panel_top_button_close;
        private Button menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax;
        private Button menu2_2_panel_main_panel5_table_memo_panel_top_button_save;
        private TextBox menu2_2_panel_main_panel5_table_memo_panel_top_text;
        private TextBox menu2_2_panel_main_panel5_table_memo_text;
        private Panel menu2_2_panel_margin;
        private Panel menu2_2_panel_top;
        private Button menu2_2_panel_top_button_add;
        private Button menu2_2_panel_top_button_movedown;
        private Button menu2_2_panel_top_button_moveup;
        private Button menu2_2_panel_top_button_open;
        private Button menu2_2_panel_top_button_openclose;
        private Circlelabel menu2_2_panel_top_label_num;
        private Label menu2_2_panel_top_label_title;

        private Panel menu2_3;
        private PanelEx menu2_3_panel;
        private Panel menu2_3_panel_main;
        private PanelEx menu2_3_panel_main_panel1;
        private Button menu2_3_panel_main_panel1_button_delete;
        private Label menu2_3_panel_main_panel1_label1;
        private PanelEx menu2_3_panel_main_panel10;
        private Button menu2_3_panel_main_panel10_button_delete;
        private Label menu2_3_panel_main_panel10_label1;
        private PanelEx menu2_3_panel_main_panel11;
        private Button menu2_3_panel_main_panel11_button_delete;
        private Label menu2_3_panel_main_panel11_label1;
        private PanelEx menu2_3_panel_main_panel12;
        private Button menu2_3_panel_main_panel12_button_delete;
        private Label menu2_3_panel_main_panel12_label1;
        private PanelEx menu2_3_panel_main_panel13;
        private Button menu2_3_panel_main_panel13_button_delete;
        private Label menu2_3_panel_main_panel13_label1;
        private PanelEx menu2_3_panel_main_panel14;
        private Button menu2_3_panel_main_panel14_button_delete;
        private Label menu2_3_panel_main_panel14_label1;
        private PanelEx menu2_3_panel_main_panel15;
        private Button menu2_3_panel_main_panel15_button_delete;
        private Label menu2_3_panel_main_panel15_label1;
        private PanelEx menu2_3_panel_main_panel16;
        private Button menu2_3_panel_main_panel16_button_delete;
        private Label menu2_3_panel_main_panel16_label1;
        private PanelEx menu2_3_panel_main_panel17;
        private Button menu2_3_panel_main_panel17_button_delete;
        private Label menu2_3_panel_main_panel17_label1;
        private PanelEx menu2_3_panel_main_panel18;
        private Button menu2_3_panel_main_panel18_button_delete;
        private Label menu2_3_panel_main_panel18_label1;
        private PanelEx menu2_3_panel_main_panel19;
        private Button menu2_3_panel_main_panel19_button_delete;
        private Label menu2_3_panel_main_panel19_label1;
        private PanelEx menu2_3_panel_main_panel2;
        private Button menu2_3_panel_main_panel2_button_delete;
        private Label menu2_3_panel_main_panel2_label1;
        private PanelEx menu2_3_panel_main_panel20;
        private Button menu2_3_panel_main_panel20_button_delete;
        private Label menu2_3_panel_main_panel20_label1;
        private PanelEx menu2_3_panel_main_panel21;
        private Button menu2_3_panel_main_panel21_button_delete;
        private Label menu2_3_panel_main_panel21_label1;
        private PanelEx menu2_3_panel_main_panel22;
        private Button menu2_3_panel_main_panel22_button_delete;
        private Label menu2_3_panel_main_panel22_label1;
        private PanelEx menu2_3_panel_main_panel23;
        private Button menu2_3_panel_main_panel23_button_delete;
        private Label menu2_3_panel_main_panel23_label1;
        private PanelEx menu2_3_panel_main_panel24;
        private Button menu2_3_panel_main_panel24_button_delete;
        private Label menu2_3_panel_main_panel24_label1;
        private PanelEx menu2_3_panel_main_panel25;
        private Button menu2_3_panel_main_panel25_button_delete;
        private Label menu2_3_panel_main_panel25_label1;
        private PanelEx menu2_3_panel_main_panel3;
        private Button menu2_3_panel_main_panel3_button_delete;
        private Label menu2_3_panel_main_panel3_label1;
        private PanelEx menu2_3_panel_main_panel4;
        private Button menu2_3_panel_main_panel4_button_delete;
        private Label menu2_3_panel_main_panel4_label1;
        private PanelEx menu2_3_panel_main_panel5;
        private Button menu2_3_panel_main_panel5_button_delete;
        private Label menu2_3_panel_main_panel5_label1;
        private PanelEx menu2_3_panel_main_panel6;
        private Button menu2_3_panel_main_panel6_button_delete;
        private Label menu2_3_panel_main_panel6_label1;
        private PanelEx menu2_3_panel_main_panel7;
        private Button menu2_3_panel_main_panel7_button_delete;
        private Label menu2_3_panel_main_panel7_label1;
        private PanelEx menu2_3_panel_main_panel8;
        private Button menu2_3_panel_main_panel8_button_delete;
        private Label menu2_3_panel_main_panel8_label1;
        private PanelEx menu2_3_panel_main_panel9;
        private Button menu2_3_panel_main_panel9_button_delete;
        private Label menu2_3_panel_main_panel9_label1;
        private Panel menu2_3_panel_top;
        private Button menu2_3_panel_top_button_add;
        private Button menu2_3_panel_top_button_movedown;
        private Button menu2_3_panel_top_button_moveup;
        private Button menu2_3_panel_top_button_openclose;
        private Circlelabel menu2_3_panel_top_label_num;
        private Label menu2_3_panel_top_label_title;
        // 2_3のmarginない？

        // ■■■■■■■■■■■■■■■■■■■■■　menuachieve　■■■■■■■■■■■■■■■■■■■■■
        private PanelEx menuachieve;
        private Button menuachieve_button_close;
        private Button menuachieve_button_save;
        private TableLayoutPanel menuachieve_table1;
        private Label menuachieve_table1_label;
        private TextBox menuachieve_table1_text;
        private TableLayoutPanel menuachieve_table2;
        private Label menuachieve_table2_label;
        private TextBox menuachieve_table2_text;
        private TableLayoutPanel menuachieve_table3;
        private TextBox menuachieve_table3_text;
        private Label menuachieve_table3_label;
        private TableLayoutPanel menuachieve_table4;
        private Label menuachieve_table4_label;
        private TextBox menuachieve_table4_text;

        // ■■■■■■■■■■■■■■■■■■■■■　menutask　■■■■■■■■■■■■■■■■■■■■■
        private PanelEx menutask;
        private Button menutask_button_close;
        private Button menutask_button_save;
        private TableLayoutPanel menutask_table1;
        private Label menutask_table1_label;
        private TextBox menutask_table1_text;
        private TableLayoutPanel menutask_table2;
        private CheckBox menutask_table2_check;
        private TableLayoutPanel menutask_table3;
        private Label menutask_table3_label;
        private TextBox menutask_table3_text;
        private TableLayoutPanel menutask_table4;
        private Label menutask_table4_label;

        // ■■■■■■■■■■■■■■■■■■■■■　menu3　■■■■■■■■■■■■■■■■■■■■■
        private Panel menu3;
        private Panel menu3_panel_main;
        private Panel menu3_panel_top;
        private Button menu3_panel_top_button_100;
        private Button menu3_panel_top_button_nextweek;
        private Button menu3_panel_top_button_prevweek;
        private Label menu3_panel_top_label_title;

        // ■■■■■■■■■■■■■■■■■■■■■　other　■■■■■■■■■■■■■■■■■■■■■ 
        private ToolTip tooltip;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.common = new TaskManege.PanelEx();
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
            this.menu1 = new TaskManege.PanelEx();
            this.menu1_table_calender = new System.Windows.Forms.TableLayoutPanel();
            this.menu1_table_calender_panel_day1 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day1 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day42 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day42 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day41 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day41 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day40 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day40 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day39 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day39 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day38 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day38 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day37 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day37 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day36 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day36 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day35 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day35 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day34 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day34 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day33 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day33 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day32 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day32 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day31 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day31 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day30 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day30 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day29 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day29 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day28 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day28 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day27 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day27 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day26 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day26 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day25 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day25 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day24 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day24 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day23 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day23 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day22 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day22 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day21 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day21 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day20 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day20 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day19 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day19 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day18 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day18 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day17 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day17 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day16 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day16 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day15 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day15 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day14 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day14 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day13 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day13 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day12 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day12 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day11 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day11 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day8 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day8 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day7 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day7 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day6 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day6 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day5 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day5 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day4 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day4 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day3 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day3 = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_sunday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_monday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_tuesday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_wednesday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_thursday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_friday = new System.Windows.Forms.Label();
            this.menu1_table_calender_label_saturday = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day2 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day2 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day9 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day9 = new System.Windows.Forms.Label();
            this.menu1_table_calender_panel_day10 = new System.Windows.Forms.Panel();
            this.menu1_table_calender_label_day10 = new System.Windows.Forms.Label();
            this.menu2 = new System.Windows.Forms.Panel();
            this.menu2_3 = new System.Windows.Forms.Panel();
            this.menu2_3_panel = new TaskManege.PanelEx();
            this.menu2_3_panel_top = new System.Windows.Forms.Panel();
            this.menu2_3_panel_top_label_num = new TaskManege.Circlelabel();
            this.menu2_3_panel_top_button_movedown = new System.Windows.Forms.Button();
            this.menu2_3_panel_top_button_moveup = new System.Windows.Forms.Button();
            this.menu2_3_panel_top_label_title = new System.Windows.Forms.Label();
            this.menu2_3_panel_top_button_openclose = new System.Windows.Forms.Button();
            this.menu2_3_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu2_3_panel_main = new System.Windows.Forms.Panel();
            this.menu2_3_panel_main_panel25 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel25_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel25_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel24 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel24_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel24_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel23 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel23_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel23_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel22 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel22_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel22_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel21 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel21_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel21_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel20 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel20_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel20_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel19 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel19_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel19_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel18 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel18_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel18_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel17 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel17_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel17_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel16 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel16_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel16_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel15 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel15_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel15_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel14 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel14_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel14_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel13 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel13_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel13_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel12 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel12_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel12_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel11 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel11_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel11_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel10 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel10_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel10_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel9 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel9_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel9_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel8 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel8_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel8_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel7 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel7_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel7_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel6 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel6_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel6_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel5 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel5_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel5_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel4 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel4_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel4_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel3 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel3_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel3_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel2 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel2_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel2_label1 = new System.Windows.Forms.Label();
            this.menu2_3_panel_main_panel1 = new TaskManege.PanelEx();
            this.menu2_3_panel_main_panel1_button_delete = new System.Windows.Forms.Button();
            this.menu2_3_panel_main_panel1_label1 = new System.Windows.Forms.Label();
            this.menu2_2 = new System.Windows.Forms.Panel();
            this.menu2_2_panel_margin = new System.Windows.Forms.Panel();
            this.menu2_2_panel = new TaskManege.PanelEx();
            this.menu2_2_panel_top = new System.Windows.Forms.Panel();
            this.menu2_2_panel_top_button_open = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_label_num = new TaskManege.Circlelabel();
            this.menu2_2_panel_top_button_movedown = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_button_moveup = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_button_openclose = new System.Windows.Forms.Button();
            this.menu2_2_panel_top_label_title = new System.Windows.Forms.Label();
            this.menu2_2_panel_main = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel5 = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel5_table_memo = new System.Windows.Forms.TableLayoutPanel();
            this.menu2_2_panel_main_panel5_table_memo_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel5_table_memo_panel_top = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel5_table_memo_panel_top_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel4 = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel4_table_memo = new System.Windows.Forms.TableLayoutPanel();
            this.menu2_2_panel_main_panel4_table_memo_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel4_table_memo_panel_top = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel4_table_memo_panel_top_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel3 = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel3_table_memo = new System.Windows.Forms.TableLayoutPanel();
            this.menu2_2_panel_main_panel3_table_memo_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel3_table_memo_panel_top = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel3_table_memo_panel_top_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel2 = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel2_table_memo = new System.Windows.Forms.TableLayoutPanel();
            this.menu2_2_panel_main_panel2_table_memo_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel2_table_memo_panel_top = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel2_table_memo_panel_top_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel1 = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel1_table_memo = new System.Windows.Forms.TableLayoutPanel();
            this.menu2_2_panel_main_panel1_table_memo_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel1_table_memo_panel_top = new System.Windows.Forms.Panel();
            this.menu2_2_panel_main_panel1_table_memo_panel_top_text = new System.Windows.Forms.TextBox();
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax = new System.Windows.Forms.Button();
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close = new System.Windows.Forms.Button();
            this.menu2_1 = new System.Windows.Forms.Panel();
            this.menu2_1_panel_margin = new System.Windows.Forms.Panel();
            this.menu2_1_panel = new TaskManege.PanelEx();
            this.menu2_1_panel_top = new System.Windows.Forms.Panel();
            this.menu2_1_panel_top_label_num = new TaskManege.Circlelabel();
            this.menu2_1_panel_top_button_movedown = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_button_moveup = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_label_title = new System.Windows.Forms.Label();
            this.menu2_1_panel_top_button_openclose = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu2_1_panel_main = new System.Windows.Forms.Panel();
            this.menu2_1_panel_main_panel25 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel25_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel25_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel25_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel25_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel24 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel24_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel24_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel24_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel24_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel23 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel23_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel23_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel23_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel23_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel22 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel22_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel22_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel22_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel22_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel21 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel21_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel21_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel21_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel21_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel20 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel20_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel20_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel20_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel20_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel19 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel19_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel19_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel19_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel19_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel18 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel18_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel18_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel18_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel18_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel17 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel17_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel17_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel17_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel17_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel16 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel16_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel16_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel16_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel16_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel15 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel15_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel15_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel15_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel15_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel14 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel14_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel14_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel14_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel14_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel13 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel13_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel13_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel13_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel13_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel12 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel12_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel12_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel12_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel12_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel11 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel11_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel11_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel11_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel11_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel10 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel10_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel10_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel10_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel10_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel9 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel9_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel9_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel9_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel9_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel8 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel8_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel8_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel8_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel8_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel7 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel7_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel7_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel7_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel7_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel6 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel6_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel6_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel6_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel6_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel5 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel5_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel5_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel5_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel5_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel4 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel4_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel4_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel4_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel4_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel3 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel3_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel3_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel3_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel3_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel2 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel2_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel2_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel2_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel2_label2 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel1 = new TaskManege.PanelEx();
            this.menu2_1_panel_main_panel1_label1 = new System.Windows.Forms.Label();
            this.menu2_1_panel_main_panel1_button_finish = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel1_button_delete = new System.Windows.Forms.Button();
            this.menu2_1_panel_main_panel1_label2 = new System.Windows.Forms.Label();
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
            this.menutask = new TaskManege.PanelEx();
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
            this.menuachieve = new TaskManege.PanelEx();
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
            this.menu1_table_calender_panel_day1.SuspendLayout();
            this.menu1_table_calender_panel_day42.SuspendLayout();
            this.menu1_table_calender_panel_day41.SuspendLayout();
            this.menu1_table_calender_panel_day40.SuspendLayout();
            this.menu1_table_calender_panel_day39.SuspendLayout();
            this.menu1_table_calender_panel_day38.SuspendLayout();
            this.menu1_table_calender_panel_day37.SuspendLayout();
            this.menu1_table_calender_panel_day36.SuspendLayout();
            this.menu1_table_calender_panel_day35.SuspendLayout();
            this.menu1_table_calender_panel_day34.SuspendLayout();
            this.menu1_table_calender_panel_day33.SuspendLayout();
            this.menu1_table_calender_panel_day32.SuspendLayout();
            this.menu1_table_calender_panel_day31.SuspendLayout();
            this.menu1_table_calender_panel_day30.SuspendLayout();
            this.menu1_table_calender_panel_day29.SuspendLayout();
            this.menu1_table_calender_panel_day28.SuspendLayout();
            this.menu1_table_calender_panel_day27.SuspendLayout();
            this.menu1_table_calender_panel_day26.SuspendLayout();
            this.menu1_table_calender_panel_day25.SuspendLayout();
            this.menu1_table_calender_panel_day24.SuspendLayout();
            this.menu1_table_calender_panel_day23.SuspendLayout();
            this.menu1_table_calender_panel_day22.SuspendLayout();
            this.menu1_table_calender_panel_day21.SuspendLayout();
            this.menu1_table_calender_panel_day20.SuspendLayout();
            this.menu1_table_calender_panel_day19.SuspendLayout();
            this.menu1_table_calender_panel_day18.SuspendLayout();
            this.menu1_table_calender_panel_day17.SuspendLayout();
            this.menu1_table_calender_panel_day16.SuspendLayout();
            this.menu1_table_calender_panel_day15.SuspendLayout();
            this.menu1_table_calender_panel_day14.SuspendLayout();
            this.menu1_table_calender_panel_day13.SuspendLayout();
            this.menu1_table_calender_panel_day12.SuspendLayout();
            this.menu1_table_calender_panel_day11.SuspendLayout();
            this.menu1_table_calender_panel_day8.SuspendLayout();
            this.menu1_table_calender_panel_day7.SuspendLayout();
            this.menu1_table_calender_panel_day6.SuspendLayout();
            this.menu1_table_calender_panel_day5.SuspendLayout();
            this.menu1_table_calender_panel_day4.SuspendLayout();
            this.menu1_table_calender_panel_day3.SuspendLayout();
            this.menu1_table_calender_panel_day2.SuspendLayout();
            this.menu1_table_calender_panel_day9.SuspendLayout();
            this.menu1_table_calender_panel_day10.SuspendLayout();
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
            this.menu2_2_panel_main_panel5.SuspendLayout();
            this.menu2_2_panel_main_panel5_table_memo.SuspendLayout();
            this.menu2_2_panel_main_panel5_table_memo_panel_top.SuspendLayout();
            this.menu2_2_panel_main_panel4.SuspendLayout();
            this.menu2_2_panel_main_panel4_table_memo.SuspendLayout();
            this.menu2_2_panel_main_panel4_table_memo_panel_top.SuspendLayout();
            this.menu2_2_panel_main_panel3.SuspendLayout();
            this.menu2_2_panel_main_panel3_table_memo.SuspendLayout();
            this.menu2_2_panel_main_panel3_table_memo_panel_top.SuspendLayout();
            this.menu2_2_panel_main_panel2.SuspendLayout();
            this.menu2_2_panel_main_panel2_table_memo.SuspendLayout();
            this.menu2_2_panel_main_panel2_table_memo_panel_top.SuspendLayout();
            this.menu2_2_panel_main_panel1.SuspendLayout();
            this.menu2_2_panel_main_panel1_table_memo.SuspendLayout();
            this.menu2_2_panel_main_panel1_table_memo_panel_top.SuspendLayout();
            this.menu2_1.SuspendLayout();
            this.menu2_1_panel.SuspendLayout();
            this.menu2_1_panel_top.SuspendLayout();
            this.menu2_1_panel_main.SuspendLayout();
            this.menu2_1_panel_main_panel25.SuspendLayout();
            this.menu2_1_panel_main_panel24.SuspendLayout();
            this.menu2_1_panel_main_panel23.SuspendLayout();
            this.menu2_1_panel_main_panel22.SuspendLayout();
            this.menu2_1_panel_main_panel21.SuspendLayout();
            this.menu2_1_panel_main_panel20.SuspendLayout();
            this.menu2_1_panel_main_panel19.SuspendLayout();
            this.menu2_1_panel_main_panel18.SuspendLayout();
            this.menu2_1_panel_main_panel17.SuspendLayout();
            this.menu2_1_panel_main_panel16.SuspendLayout();
            this.menu2_1_panel_main_panel15.SuspendLayout();
            this.menu2_1_panel_main_panel14.SuspendLayout();
            this.menu2_1_panel_main_panel13.SuspendLayout();
            this.menu2_1_panel_main_panel12.SuspendLayout();
            this.menu2_1_panel_main_panel11.SuspendLayout();
            this.menu2_1_panel_main_panel10.SuspendLayout();
            this.menu2_1_panel_main_panel9.SuspendLayout();
            this.menu2_1_panel_main_panel8.SuspendLayout();
            this.menu2_1_panel_main_panel7.SuspendLayout();
            this.menu2_1_panel_main_panel6.SuspendLayout();
            this.menu2_1_panel_main_panel5.SuspendLayout();
            this.menu2_1_panel_main_panel4.SuspendLayout();
            this.menu2_1_panel_main_panel3.SuspendLayout();
            this.menu2_1_panel_main_panel2.SuspendLayout();
            this.menu2_1_panel_main_panel1.SuspendLayout();
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
            this.menu1.Size = new System.Drawing.Size(682, 445);
            this.menu1.TabIndex = 1;
            // 
            // menu1_table_calender
            // 
            this.menu1_table_calender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender.ColumnCount = 7;
            this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.menu1_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day1, 0, 1);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day42, 6, 6);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day41, 5, 6);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day40, 4, 6);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day39, 3, 6);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day38, 2, 6);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day37, 1, 6);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day36, 0, 6);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day35, 6, 5);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day34, 5, 5);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day33, 4, 5);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day32, 3, 5);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day31, 2, 5);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day30, 1, 5);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day29, 0, 5);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day28, 6, 4);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day27, 5, 4);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day26, 4, 4);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day25, 3, 4);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day24, 2, 4);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day23, 1, 4);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day22, 0, 4);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day21, 6, 3);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day20, 5, 3);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day19, 4, 3);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day18, 3, 3);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day17, 2, 3);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day16, 1, 3);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day15, 0, 3);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day14, 6, 2);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day13, 5, 2);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day12, 4, 2);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day11, 3, 2);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day8, 0, 2);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day7, 6, 1);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day6, 5, 1);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day5, 4, 1);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day4, 3, 1);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day3, 2, 1);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_sunday, 0, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_monday, 1, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_tuesday, 2, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_wednesday, 3, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_thursday, 4, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_friday, 5, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_label_saturday, 6, 0);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day2, 1, 1);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day9, 1, 2);
            this.menu1_table_calender.Controls.Add(this.menu1_table_calender_panel_day10, 2, 2);
            this.menu1_table_calender.ForeColor = System.Drawing.Color.Black;
            this.menu1_table_calender.Location = new System.Drawing.Point(11, 39);
            this.menu1_table_calender.Name = "menu1_table_calender";
            this.menu1_table_calender.RowCount = 7;
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.menu1_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.menu1_table_calender.Size = new System.Drawing.Size(658, 402);
            this.menu1_table_calender.TabIndex = 1;
            // 
            // menu1_table_calender_panel_day1
            // 
            this.menu1_table_calender_panel_day1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day1.BackColor = System.Drawing.Color.Transparent;
            this.menu1_table_calender_panel_day1.Controls.Add(this.menu1_table_calender_label_day1);
            this.menu1_table_calender_panel_day1.Location = new System.Drawing.Point(1, 21);
            this.menu1_table_calender_panel_day1.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day1.Name = "menu1_table_calender_panel_day1";
            this.menu1_table_calender_panel_day1.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day1.TabIndex = 49;
            this.menu1_table_calender_panel_day1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day1_MouseClick);
            this.menu1_table_calender_panel_day1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day1_DoubleClick);
            this.menu1_table_calender_panel_day1.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day1_MouseEnter);
            this.menu1_table_calender_panel_day1.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day1_MouseLeave);
            // 
            // menu1_table_calender_label_day1
            // 
            this.menu1_table_calender_label_day1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day1.BackColor = System.Drawing.Color.Transparent;
            this.menu1_table_calender_label_day1.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day1.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_table_calender_label_day1.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day1.Name = "menu1_table_calender_label_day1";
            this.menu1_table_calender_label_day1.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day1.TabIndex = 50;
            this.menu1_table_calender_label_day1.Text = "1";
            this.menu1_table_calender_label_day1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day1_MouseClick);
            this.menu1_table_calender_label_day1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day1_DoubleClick);
            this.menu1_table_calender_label_day1.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day1_MouseEnter);
            this.menu1_table_calender_label_day1.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day1_MouseLeave);
            // 
            // menu1_table_calender_panel_day42
            // 
            this.menu1_table_calender_panel_day42.Controls.Add(this.menu1_table_calender_label_day42);
            this.menu1_table_calender_panel_day42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day42.Location = new System.Drawing.Point(565, 336);
            this.menu1_table_calender_panel_day42.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day42.Name = "menu1_table_calender_panel_day42";
            this.menu1_table_calender_panel_day42.Size = new System.Drawing.Size(92, 65);
            this.menu1_table_calender_panel_day42.TabIndex = 90;
            this.menu1_table_calender_panel_day42.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day42_MouseClick);
            this.menu1_table_calender_panel_day42.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day42_DoubleClick);
            this.menu1_table_calender_panel_day42.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day42_MouseEnter);
            this.menu1_table_calender_panel_day42.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day42_MouseLeave);
            // 
            // menu1_table_calender_label_day42
            // 
            this.menu1_table_calender_label_day42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day42.Location = new System.Drawing.Point(2, 1);
            this.menu1_table_calender_label_day42.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day42.Name = "menu1_table_calender_label_day42";
            this.menu1_table_calender_label_day42.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day42.TabIndex = 48;
            this.menu1_table_calender_label_day42.Text = "label42";
            this.menu1_table_calender_label_day42.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day42.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day42_MouseClick);
            this.menu1_table_calender_label_day42.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day42_DoubleClick);
            this.menu1_table_calender_label_day42.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day42_MouseEnter);
            this.menu1_table_calender_label_day42.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day42_MouseLeave);
            // 
            // menu1_table_calender_panel_day41
            // 
            this.menu1_table_calender_panel_day41.Controls.Add(this.menu1_table_calender_label_day41);
            this.menu1_table_calender_panel_day41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day41.Location = new System.Drawing.Point(471, 336);
            this.menu1_table_calender_panel_day41.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day41.Name = "menu1_table_calender_panel_day41";
            this.menu1_table_calender_panel_day41.Size = new System.Drawing.Size(92, 65);
            this.menu1_table_calender_panel_day41.TabIndex = 89;
            this.menu1_table_calender_panel_day41.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day41_MouseClick);
            this.menu1_table_calender_panel_day41.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day41_DoubleClick);
            this.menu1_table_calender_panel_day41.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day41_MouseEnter);
            this.menu1_table_calender_panel_day41.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day41_MouseLeave);
            // 
            // menu1_table_calender_label_day41
            // 
            this.menu1_table_calender_label_day41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day41.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day41.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day41.Name = "menu1_table_calender_label_day41";
            this.menu1_table_calender_label_day41.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day41.TabIndex = 47;
            this.menu1_table_calender_label_day41.Text = "label41";
            this.menu1_table_calender_label_day41.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day41.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day41_MouseClick);
            this.menu1_table_calender_label_day41.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day41_DoubleClick);
            this.menu1_table_calender_label_day41.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day41_MouseEnter);
            this.menu1_table_calender_label_day41.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day41_MouseLeave);
            // 
            // menu1_table_calender_panel_day40
            // 
            this.menu1_table_calender_panel_day40.Controls.Add(this.menu1_table_calender_label_day40);
            this.menu1_table_calender_panel_day40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day40.Location = new System.Drawing.Point(377, 336);
            this.menu1_table_calender_panel_day40.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day40.Name = "menu1_table_calender_panel_day40";
            this.menu1_table_calender_panel_day40.Size = new System.Drawing.Size(92, 65);
            this.menu1_table_calender_panel_day40.TabIndex = 88;
            this.menu1_table_calender_panel_day40.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day40_MouseClick);
            this.menu1_table_calender_panel_day40.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day40_DoubleClick);
            this.menu1_table_calender_panel_day40.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day40_MouseEnter);
            this.menu1_table_calender_panel_day40.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day40_MouseLeave);
            // 
            // menu1_table_calender_label_day40
            // 
            this.menu1_table_calender_label_day40.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day40.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day40.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day40.Name = "menu1_table_calender_label_day40";
            this.menu1_table_calender_label_day40.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day40.TabIndex = 46;
            this.menu1_table_calender_label_day40.Text = "label40";
            this.menu1_table_calender_label_day40.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day40.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day40_MouseClick);
            this.menu1_table_calender_label_day40.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day40_DoubleClick);
            this.menu1_table_calender_label_day40.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day40_MouseEnter);
            this.menu1_table_calender_label_day40.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day40_MouseLeave);
            // 
            // menu1_table_calender_panel_day39
            // 
            this.menu1_table_calender_panel_day39.Controls.Add(this.menu1_table_calender_label_day39);
            this.menu1_table_calender_panel_day39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day39.Location = new System.Drawing.Point(283, 336);
            this.menu1_table_calender_panel_day39.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day39.Name = "menu1_table_calender_panel_day39";
            this.menu1_table_calender_panel_day39.Size = new System.Drawing.Size(92, 65);
            this.menu1_table_calender_panel_day39.TabIndex = 87;
            this.menu1_table_calender_panel_day39.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day39_MouseClick);
            this.menu1_table_calender_panel_day39.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day39_DoubleClick);
            this.menu1_table_calender_panel_day39.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day39_MouseEnter);
            this.menu1_table_calender_panel_day39.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day39_MouseLeave);
            // 
            // menu1_table_calender_label_day39
            // 
            this.menu1_table_calender_label_day39.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day39.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day39.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day39.Name = "menu1_table_calender_label_day39";
            this.menu1_table_calender_label_day39.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day39.TabIndex = 45;
            this.menu1_table_calender_label_day39.Text = "label39";
            this.menu1_table_calender_label_day39.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day39.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day39_MouseClick);
            this.menu1_table_calender_label_day39.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day39_DoubleClick);
            this.menu1_table_calender_label_day39.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day39_MouseEnter);
            this.menu1_table_calender_label_day39.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day39_MouseLeave);
            // 
            // menu1_table_calender_panel_day38
            // 
            this.menu1_table_calender_panel_day38.Controls.Add(this.menu1_table_calender_label_day38);
            this.menu1_table_calender_panel_day38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day38.Location = new System.Drawing.Point(189, 336);
            this.menu1_table_calender_panel_day38.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day38.Name = "menu1_table_calender_panel_day38";
            this.menu1_table_calender_panel_day38.Size = new System.Drawing.Size(92, 65);
            this.menu1_table_calender_panel_day38.TabIndex = 86;
            this.menu1_table_calender_panel_day38.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day38_MouseClick);
            this.menu1_table_calender_panel_day38.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day38_DoubleClick);
            this.menu1_table_calender_panel_day38.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day38_MouseEnter);
            this.menu1_table_calender_panel_day38.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day38_MouseLeave);
            // 
            // menu1_table_calender_label_day38
            // 
            this.menu1_table_calender_label_day38.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day38.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day38.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day38.Name = "menu1_table_calender_label_day38";
            this.menu1_table_calender_label_day38.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day38.TabIndex = 44;
            this.menu1_table_calender_label_day38.Text = "label38";
            this.menu1_table_calender_label_day38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day38.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day38_MouseClick);
            this.menu1_table_calender_label_day38.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day38_DoubleClick);
            this.menu1_table_calender_label_day38.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day38_MouseEnter);
            this.menu1_table_calender_label_day38.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day38_MouseLeave);
            // 
            // menu1_table_calender_panel_day37
            // 
            this.menu1_table_calender_panel_day37.Controls.Add(this.menu1_table_calender_label_day37);
            this.menu1_table_calender_panel_day37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day37.Location = new System.Drawing.Point(95, 336);
            this.menu1_table_calender_panel_day37.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day37.Name = "menu1_table_calender_panel_day37";
            this.menu1_table_calender_panel_day37.Size = new System.Drawing.Size(92, 65);
            this.menu1_table_calender_panel_day37.TabIndex = 85;
            this.menu1_table_calender_panel_day37.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day37_MouseClick);
            this.menu1_table_calender_panel_day37.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day37_DoubleClick);
            this.menu1_table_calender_panel_day37.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day37_MouseEnter);
            this.menu1_table_calender_panel_day37.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day37_MouseLeave);
            // 
            // menu1_table_calender_label_day37
            // 
            this.menu1_table_calender_label_day37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day37.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day37.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day37.Name = "menu1_table_calender_label_day37";
            this.menu1_table_calender_label_day37.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day37.TabIndex = 43;
            this.menu1_table_calender_label_day37.Text = "label37";
            this.menu1_table_calender_label_day37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day37.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day37_MouseClick);
            this.menu1_table_calender_label_day37.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day37_DoubleClick);
            this.menu1_table_calender_label_day37.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day37_MouseEnter);
            this.menu1_table_calender_label_day37.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day37_MouseLeave);
            // 
            // menu1_table_calender_panel_day36
            // 
            this.menu1_table_calender_panel_day36.Controls.Add(this.menu1_table_calender_label_day36);
            this.menu1_table_calender_panel_day36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day36.Location = new System.Drawing.Point(1, 336);
            this.menu1_table_calender_panel_day36.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day36.Name = "menu1_table_calender_panel_day36";
            this.menu1_table_calender_panel_day36.Size = new System.Drawing.Size(92, 65);
            this.menu1_table_calender_panel_day36.TabIndex = 84;
            this.menu1_table_calender_panel_day36.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day36_MouseClick);
            this.menu1_table_calender_panel_day36.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day36_DoubleClick);
            this.menu1_table_calender_panel_day36.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day36_MouseEnter);
            this.menu1_table_calender_panel_day36.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day36_MouseLeave);
            // 
            // menu1_table_calender_label_day36
            // 
            this.menu1_table_calender_label_day36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day36.BackColor = System.Drawing.Color.Transparent;
            this.menu1_table_calender_label_day36.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day36.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day36.Name = "menu1_table_calender_label_day36";
            this.menu1_table_calender_label_day36.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day36.TabIndex = 42;
            this.menu1_table_calender_label_day36.Text = "label36";
            this.menu1_table_calender_label_day36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day36.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day36_MouseClick);
            this.menu1_table_calender_label_day36.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day36_DoubleClick);
            this.menu1_table_calender_label_day36.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day36_MouseEnter);
            this.menu1_table_calender_label_day36.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day36_MouseLeave);
            // 
            // menu1_table_calender_panel_day35
            // 
            this.menu1_table_calender_panel_day35.Controls.Add(this.menu1_table_calender_label_day35);
            this.menu1_table_calender_panel_day35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day35.Location = new System.Drawing.Point(565, 273);
            this.menu1_table_calender_panel_day35.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day35.Name = "menu1_table_calender_panel_day35";
            this.menu1_table_calender_panel_day35.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day35.TabIndex = 83;
            this.menu1_table_calender_panel_day35.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day35_MouseClick);
            this.menu1_table_calender_panel_day35.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day35_DoubleClick);
            this.menu1_table_calender_panel_day35.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day35_MouseEnter);
            this.menu1_table_calender_panel_day35.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day35_MouseLeave);
            // 
            // menu1_table_calender_label_day35
            // 
            this.menu1_table_calender_label_day35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day35.Location = new System.Drawing.Point(2, 1);
            this.menu1_table_calender_label_day35.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day35.Name = "menu1_table_calender_label_day35";
            this.menu1_table_calender_label_day35.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day35.TabIndex = 41;
            this.menu1_table_calender_label_day35.Text = "label35";
            this.menu1_table_calender_label_day35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day35.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day35_MouseClick);
            this.menu1_table_calender_label_day35.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day35_DoubleClick);
            this.menu1_table_calender_label_day35.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day35_MouseEnter);
            this.menu1_table_calender_label_day35.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day35_MouseLeave);
            // 
            // menu1_table_calender_panel_day34
            // 
            this.menu1_table_calender_panel_day34.Controls.Add(this.menu1_table_calender_label_day34);
            this.menu1_table_calender_panel_day34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day34.Location = new System.Drawing.Point(471, 273);
            this.menu1_table_calender_panel_day34.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day34.Name = "menu1_table_calender_panel_day34";
            this.menu1_table_calender_panel_day34.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day34.TabIndex = 82;
            this.menu1_table_calender_panel_day34.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day34_MouseClick);
            this.menu1_table_calender_panel_day34.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day34_DoubleClick);
            this.menu1_table_calender_panel_day34.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day34_MouseEnter);
            this.menu1_table_calender_panel_day34.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day34_MouseLeave);
            // 
            // menu1_table_calender_label_day34
            // 
            this.menu1_table_calender_label_day34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day34.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day34.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day34.Name = "menu1_table_calender_label_day34";
            this.menu1_table_calender_label_day34.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day34.TabIndex = 40;
            this.menu1_table_calender_label_day34.Text = "label34";
            this.menu1_table_calender_label_day34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day34.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day34_MouseClick);
            this.menu1_table_calender_label_day34.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day34_DoubleClick);
            this.menu1_table_calender_label_day34.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day34_MouseEnter);
            this.menu1_table_calender_label_day34.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day34_MouseLeave);
            // 
            // menu1_table_calender_panel_day33
            // 
            this.menu1_table_calender_panel_day33.Controls.Add(this.menu1_table_calender_label_day33);
            this.menu1_table_calender_panel_day33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day33.Location = new System.Drawing.Point(377, 273);
            this.menu1_table_calender_panel_day33.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day33.Name = "menu1_table_calender_panel_day33";
            this.menu1_table_calender_panel_day33.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day33.TabIndex = 81;
            this.menu1_table_calender_panel_day33.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day33_MouseClick);
            this.menu1_table_calender_panel_day33.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day33_DoubleClick);
            this.menu1_table_calender_panel_day33.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day33_MouseEnter);
            this.menu1_table_calender_panel_day33.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day33_MouseLeave);
            // 
            // menu1_table_calender_label_day33
            // 
            this.menu1_table_calender_label_day33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day33.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day33.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day33.Name = "menu1_table_calender_label_day33";
            this.menu1_table_calender_label_day33.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day33.TabIndex = 39;
            this.menu1_table_calender_label_day33.Text = "label33";
            this.menu1_table_calender_label_day33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day33.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day33_MouseClick);
            this.menu1_table_calender_label_day33.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day33_DoubleClick);
            this.menu1_table_calender_label_day33.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day33_MouseEnter);
            this.menu1_table_calender_label_day33.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day33_MouseLeave);
            // 
            // menu1_table_calender_panel_day32
            // 
            this.menu1_table_calender_panel_day32.Controls.Add(this.menu1_table_calender_label_day32);
            this.menu1_table_calender_panel_day32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day32.Location = new System.Drawing.Point(283, 273);
            this.menu1_table_calender_panel_day32.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day32.Name = "menu1_table_calender_panel_day32";
            this.menu1_table_calender_panel_day32.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day32.TabIndex = 80;
            this.menu1_table_calender_panel_day32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day32_MouseClick);
            this.menu1_table_calender_panel_day32.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day32_DoubleClick);
            this.menu1_table_calender_panel_day32.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day32_MouseEnter);
            this.menu1_table_calender_panel_day32.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day32_MouseLeave);
            // 
            // menu1_table_calender_label_day32
            // 
            this.menu1_table_calender_label_day32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day32.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day32.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day32.Name = "menu1_table_calender_label_day32";
            this.menu1_table_calender_label_day32.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day32.TabIndex = 38;
            this.menu1_table_calender_label_day32.Text = "label32";
            this.menu1_table_calender_label_day32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day32_MouseClick);
            this.menu1_table_calender_label_day32.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day32_DoubleClick);
            this.menu1_table_calender_label_day32.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day32_MouseEnter);
            this.menu1_table_calender_label_day32.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day32_MouseLeave);
            // 
            // menu1_table_calender_panel_day31
            // 
            this.menu1_table_calender_panel_day31.Controls.Add(this.menu1_table_calender_label_day31);
            this.menu1_table_calender_panel_day31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day31.Location = new System.Drawing.Point(189, 273);
            this.menu1_table_calender_panel_day31.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day31.Name = "menu1_table_calender_panel_day31";
            this.menu1_table_calender_panel_day31.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day31.TabIndex = 78;
            this.menu1_table_calender_panel_day31.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day31_MouseClick);
            this.menu1_table_calender_panel_day31.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day31_DoubleClick);
            this.menu1_table_calender_panel_day31.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day31_MouseEnter);
            this.menu1_table_calender_panel_day31.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day31_MouseLeave);
            // 
            // menu1_table_calender_label_day31
            // 
            this.menu1_table_calender_label_day31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day31.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day31.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day31.Name = "menu1_table_calender_label_day31";
            this.menu1_table_calender_label_day31.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day31.TabIndex = 37;
            this.menu1_table_calender_label_day31.Text = "label31";
            this.menu1_table_calender_label_day31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day31.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day31_MouseClick);
            this.menu1_table_calender_label_day31.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day31_DoubleClick);
            this.menu1_table_calender_label_day31.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day31_MouseEnter);
            this.menu1_table_calender_label_day31.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day31_MouseLeave);
            // 
            // menu1_table_calender_panel_day30
            // 
            this.menu1_table_calender_panel_day30.Controls.Add(this.menu1_table_calender_label_day30);
            this.menu1_table_calender_panel_day30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day30.Location = new System.Drawing.Point(95, 273);
            this.menu1_table_calender_panel_day30.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day30.Name = "menu1_table_calender_panel_day30";
            this.menu1_table_calender_panel_day30.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day30.TabIndex = 78;
            this.menu1_table_calender_panel_day30.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day30_MouseClick);
            this.menu1_table_calender_panel_day30.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day30_DoubleClick);
            this.menu1_table_calender_panel_day30.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day30_MouseEnter);
            this.menu1_table_calender_panel_day30.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day30_MouseLeave);
            // 
            // menu1_table_calender_label_day30
            // 
            this.menu1_table_calender_label_day30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day30.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day30.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day30.Name = "menu1_table_calender_label_day30";
            this.menu1_table_calender_label_day30.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day30.TabIndex = 36;
            this.menu1_table_calender_label_day30.Text = "label30";
            this.menu1_table_calender_label_day30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day30.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day30_MouseClick);
            this.menu1_table_calender_label_day30.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day30_DoubleClick);
            this.menu1_table_calender_label_day30.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day30_MouseEnter);
            this.menu1_table_calender_label_day30.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day30_MouseLeave);
            // 
            // menu1_table_calender_panel_day29
            // 
            this.menu1_table_calender_panel_day29.Controls.Add(this.menu1_table_calender_label_day29);
            this.menu1_table_calender_panel_day29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day29.Location = new System.Drawing.Point(1, 273);
            this.menu1_table_calender_panel_day29.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day29.Name = "menu1_table_calender_panel_day29";
            this.menu1_table_calender_panel_day29.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day29.TabIndex = 77;
            this.menu1_table_calender_panel_day29.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day29_MouseClick);
            this.menu1_table_calender_panel_day29.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day29_DoubleClick);
            this.menu1_table_calender_panel_day29.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day29_MouseEnter);
            this.menu1_table_calender_panel_day29.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day29_MouseLeave);
            // 
            // menu1_table_calender_label_day29
            // 
            this.menu1_table_calender_label_day29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day29.Location = new System.Drawing.Point(5, 1);
            this.menu1_table_calender_label_day29.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day29.Name = "menu1_table_calender_label_day29";
            this.menu1_table_calender_label_day29.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day29.TabIndex = 35;
            this.menu1_table_calender_label_day29.Text = "label29";
            this.menu1_table_calender_label_day29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day29.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day29_MouseClick);
            this.menu1_table_calender_label_day29.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day29_DoubleClick);
            this.menu1_table_calender_label_day29.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day29_MouseEnter);
            this.menu1_table_calender_label_day29.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day29_MouseLeave);
            // 
            // menu1_table_calender_panel_day28
            // 
            this.menu1_table_calender_panel_day28.Controls.Add(this.menu1_table_calender_label_day28);
            this.menu1_table_calender_panel_day28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day28.Location = new System.Drawing.Point(565, 210);
            this.menu1_table_calender_panel_day28.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day28.Name = "menu1_table_calender_panel_day28";
            this.menu1_table_calender_panel_day28.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day28.TabIndex = 76;
            this.menu1_table_calender_panel_day28.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day28_MouseClick);
            this.menu1_table_calender_panel_day28.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day28_DoubleClick);
            this.menu1_table_calender_panel_day28.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day28_MouseEnter);
            this.menu1_table_calender_panel_day28.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day28_MouseLeave);
            // 
            // menu1_table_calender_label_day28
            // 
            this.menu1_table_calender_label_day28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day28.Location = new System.Drawing.Point(4, 1);
            this.menu1_table_calender_label_day28.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day28.Name = "menu1_table_calender_label_day28";
            this.menu1_table_calender_label_day28.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day28.TabIndex = 34;
            this.menu1_table_calender_label_day28.Text = "label28";
            this.menu1_table_calender_label_day28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day28.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day28_MouseClick);
            this.menu1_table_calender_label_day28.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day28_DoubleClick);
            this.menu1_table_calender_label_day28.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day28_MouseEnter);
            this.menu1_table_calender_label_day28.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day28_MouseLeave);
            // 
            // menu1_table_calender_panel_day27
            // 
            this.menu1_table_calender_panel_day27.Controls.Add(this.menu1_table_calender_label_day27);
            this.menu1_table_calender_panel_day27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day27.Location = new System.Drawing.Point(471, 210);
            this.menu1_table_calender_panel_day27.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day27.Name = "menu1_table_calender_panel_day27";
            this.menu1_table_calender_panel_day27.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day27.TabIndex = 75;
            this.menu1_table_calender_panel_day27.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day27_MouseClick);
            this.menu1_table_calender_panel_day27.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day27_DoubleClick);
            this.menu1_table_calender_panel_day27.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day27_MouseEnter);
            this.menu1_table_calender_panel_day27.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day27_MouseLeave);
            // 
            // menu1_table_calender_label_day27
            // 
            this.menu1_table_calender_label_day27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day27.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day27.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day27.Name = "menu1_table_calender_label_day27";
            this.menu1_table_calender_label_day27.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day27.TabIndex = 33;
            this.menu1_table_calender_label_day27.Text = "label27";
            this.menu1_table_calender_label_day27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day27.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day27_MouseClick);
            this.menu1_table_calender_label_day27.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day27_DoubleClick);
            this.menu1_table_calender_label_day27.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day27_MouseEnter);
            this.menu1_table_calender_label_day27.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day27_MouseLeave);
            // 
            // menu1_table_calender_panel_day26
            // 
            this.menu1_table_calender_panel_day26.Controls.Add(this.menu1_table_calender_label_day26);
            this.menu1_table_calender_panel_day26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day26.Location = new System.Drawing.Point(377, 210);
            this.menu1_table_calender_panel_day26.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day26.Name = "menu1_table_calender_panel_day26";
            this.menu1_table_calender_panel_day26.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day26.TabIndex = 74;
            this.menu1_table_calender_panel_day26.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day26_MouseClick);
            this.menu1_table_calender_panel_day26.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day26_DoubleClick);
            this.menu1_table_calender_panel_day26.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day26_MouseEnter);
            this.menu1_table_calender_panel_day26.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day26_MouseLeave);
            // 
            // menu1_table_calender_label_day26
            // 
            this.menu1_table_calender_label_day26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day26.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day26.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day26.Name = "menu1_table_calender_label_day26";
            this.menu1_table_calender_label_day26.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day26.TabIndex = 32;
            this.menu1_table_calender_label_day26.Text = "label26";
            this.menu1_table_calender_label_day26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day26.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day26_MouseClick);
            this.menu1_table_calender_label_day26.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day26_DoubleClick);
            this.menu1_table_calender_label_day26.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day26_MouseEnter);
            this.menu1_table_calender_label_day26.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day26_MouseLeave);
            // 
            // menu1_table_calender_panel_day25
            // 
            this.menu1_table_calender_panel_day25.Controls.Add(this.menu1_table_calender_label_day25);
            this.menu1_table_calender_panel_day25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day25.Location = new System.Drawing.Point(283, 210);
            this.menu1_table_calender_panel_day25.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day25.Name = "menu1_table_calender_panel_day25";
            this.menu1_table_calender_panel_day25.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day25.TabIndex = 73;
            this.menu1_table_calender_panel_day25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day25_MouseClick);
            this.menu1_table_calender_panel_day25.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day25_DoubleClick);
            this.menu1_table_calender_panel_day25.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day25_MouseEnter);
            this.menu1_table_calender_panel_day25.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day25_MouseLeave);
            // 
            // menu1_table_calender_label_day25
            // 
            this.menu1_table_calender_label_day25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day25.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day25.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day25.Name = "menu1_table_calender_label_day25";
            this.menu1_table_calender_label_day25.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day25.TabIndex = 31;
            this.menu1_table_calender_label_day25.Text = "label25";
            this.menu1_table_calender_label_day25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day25_MouseClick);
            this.menu1_table_calender_label_day25.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day25_DoubleClick);
            this.menu1_table_calender_label_day25.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day25_MouseEnter);
            this.menu1_table_calender_label_day25.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day25_MouseLeave);
            // 
            // menu1_table_calender_panel_day24
            // 
            this.menu1_table_calender_panel_day24.Controls.Add(this.menu1_table_calender_label_day24);
            this.menu1_table_calender_panel_day24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day24.Location = new System.Drawing.Point(189, 210);
            this.menu1_table_calender_panel_day24.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day24.Name = "menu1_table_calender_panel_day24";
            this.menu1_table_calender_panel_day24.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day24.TabIndex = 72;
            this.menu1_table_calender_panel_day24.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day24_MouseClick);
            this.menu1_table_calender_panel_day24.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day24_DoubleClick);
            this.menu1_table_calender_panel_day24.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day24_MouseEnter);
            this.menu1_table_calender_panel_day24.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day24_MouseLeave);
            // 
            // menu1_table_calender_label_day24
            // 
            this.menu1_table_calender_label_day24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day24.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day24.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day24.Name = "menu1_table_calender_label_day24";
            this.menu1_table_calender_label_day24.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day24.TabIndex = 30;
            this.menu1_table_calender_label_day24.Text = "label24";
            this.menu1_table_calender_label_day24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day24.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day24_MouseClick);
            this.menu1_table_calender_label_day24.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day24_DoubleClick);
            this.menu1_table_calender_label_day24.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day24_MouseEnter);
            this.menu1_table_calender_label_day24.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day24_MouseLeave);
            // 
            // menu1_table_calender_panel_day23
            // 
            this.menu1_table_calender_panel_day23.Controls.Add(this.menu1_table_calender_label_day23);
            this.menu1_table_calender_panel_day23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day23.Location = new System.Drawing.Point(95, 210);
            this.menu1_table_calender_panel_day23.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day23.Name = "menu1_table_calender_panel_day23";
            this.menu1_table_calender_panel_day23.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day23.TabIndex = 71;
            this.menu1_table_calender_panel_day23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day23_MouseClick);
            this.menu1_table_calender_panel_day23.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day23_DoubleClick);
            this.menu1_table_calender_panel_day23.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day23_MouseEnter);
            this.menu1_table_calender_panel_day23.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day23_MouseLeave);
            // 
            // menu1_table_calender_label_day23
            // 
            this.menu1_table_calender_label_day23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day23.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day23.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day23.Name = "menu1_table_calender_label_day23";
            this.menu1_table_calender_label_day23.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day23.TabIndex = 29;
            this.menu1_table_calender_label_day23.Text = "label23";
            this.menu1_table_calender_label_day23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day23_MouseClick);
            this.menu1_table_calender_label_day23.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day23_DoubleClick);
            this.menu1_table_calender_label_day23.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day23_MouseEnter);
            this.menu1_table_calender_label_day23.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day23_MouseLeave);
            // 
            // menu1_table_calender_panel_day22
            // 
            this.menu1_table_calender_panel_day22.Controls.Add(this.menu1_table_calender_label_day22);
            this.menu1_table_calender_panel_day22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day22.Location = new System.Drawing.Point(1, 210);
            this.menu1_table_calender_panel_day22.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day22.Name = "menu1_table_calender_panel_day22";
            this.menu1_table_calender_panel_day22.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day22.TabIndex = 70;
            this.menu1_table_calender_panel_day22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day22_MouseClick);
            this.menu1_table_calender_panel_day22.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day22_DoubleClick);
            this.menu1_table_calender_panel_day22.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day22_MouseEnter);
            this.menu1_table_calender_panel_day22.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day22_MouseLeave);
            // 
            // menu1_table_calender_label_day22
            // 
            this.menu1_table_calender_label_day22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day22.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day22.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day22.Name = "menu1_table_calender_label_day22";
            this.menu1_table_calender_label_day22.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day22.TabIndex = 28;
            this.menu1_table_calender_label_day22.Text = "label22";
            this.menu1_table_calender_label_day22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day22_MouseClick);
            this.menu1_table_calender_label_day22.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day22_DoubleClick);
            this.menu1_table_calender_label_day22.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day22_MouseEnter);
            this.menu1_table_calender_label_day22.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day22_MouseLeave);
            // 
            // menu1_table_calender_panel_day21
            // 
            this.menu1_table_calender_panel_day21.Controls.Add(this.menu1_table_calender_label_day21);
            this.menu1_table_calender_panel_day21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day21.Location = new System.Drawing.Point(565, 147);
            this.menu1_table_calender_panel_day21.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day21.Name = "menu1_table_calender_panel_day21";
            this.menu1_table_calender_panel_day21.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day21.TabIndex = 69;
            this.menu1_table_calender_panel_day21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day21_MouseClick);
            this.menu1_table_calender_panel_day21.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day21_DoubleClick);
            this.menu1_table_calender_panel_day21.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day21_MouseEnter);
            this.menu1_table_calender_panel_day21.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day21_MouseLeave);
            // 
            // menu1_table_calender_label_day21
            // 
            this.menu1_table_calender_label_day21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day21.Location = new System.Drawing.Point(4, 1);
            this.menu1_table_calender_label_day21.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day21.Name = "menu1_table_calender_label_day21";
            this.menu1_table_calender_label_day21.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day21.TabIndex = 27;
            this.menu1_table_calender_label_day21.Text = "label21";
            this.menu1_table_calender_label_day21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day21_MouseClick);
            this.menu1_table_calender_label_day21.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day21_DoubleClick);
            this.menu1_table_calender_label_day21.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day21_MouseEnter);
            this.menu1_table_calender_label_day21.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day21_MouseLeave);
            // 
            // menu1_table_calender_panel_day20
            // 
            this.menu1_table_calender_panel_day20.Controls.Add(this.menu1_table_calender_label_day20);
            this.menu1_table_calender_panel_day20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day20.Location = new System.Drawing.Point(471, 147);
            this.menu1_table_calender_panel_day20.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day20.Name = "menu1_table_calender_panel_day20";
            this.menu1_table_calender_panel_day20.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day20.TabIndex = 68;
            this.menu1_table_calender_panel_day20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day20_MouseClick);
            this.menu1_table_calender_panel_day20.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day20_DoubleClick);
            this.menu1_table_calender_panel_day20.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day20_MouseEnter);
            this.menu1_table_calender_panel_day20.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day20_MouseLeave);
            // 
            // menu1_table_calender_label_day20
            // 
            this.menu1_table_calender_label_day20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day20.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day20.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day20.Name = "menu1_table_calender_label_day20";
            this.menu1_table_calender_label_day20.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day20.TabIndex = 26;
            this.menu1_table_calender_label_day20.Text = "label20";
            this.menu1_table_calender_label_day20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day20_MouseClick);
            this.menu1_table_calender_label_day20.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day20_DoubleClick);
            this.menu1_table_calender_label_day20.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day20_MouseEnter);
            this.menu1_table_calender_label_day20.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day20_MouseLeave);
            // 
            // menu1_table_calender_panel_day19
            // 
            this.menu1_table_calender_panel_day19.Controls.Add(this.menu1_table_calender_label_day19);
            this.menu1_table_calender_panel_day19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day19.Location = new System.Drawing.Point(377, 147);
            this.menu1_table_calender_panel_day19.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day19.Name = "menu1_table_calender_panel_day19";
            this.menu1_table_calender_panel_day19.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day19.TabIndex = 67;
            this.menu1_table_calender_panel_day19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day19_MouseClick);
            this.menu1_table_calender_panel_day19.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day19_DoubleClick);
            this.menu1_table_calender_panel_day19.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day19_MouseEnter);
            this.menu1_table_calender_panel_day19.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day19_MouseLeave);
            // 
            // menu1_table_calender_label_day19
            // 
            this.menu1_table_calender_label_day19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day19.BackColor = System.Drawing.Color.Transparent;
            this.menu1_table_calender_label_day19.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day19.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day19.Name = "menu1_table_calender_label_day19";
            this.menu1_table_calender_label_day19.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day19.TabIndex = 25;
            this.menu1_table_calender_label_day19.Text = "label19";
            this.menu1_table_calender_label_day19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day19_MouseClick);
            this.menu1_table_calender_label_day19.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day19_DoubleClick);
            this.menu1_table_calender_label_day19.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day19_MouseEnter);
            this.menu1_table_calender_label_day19.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day19_MouseLeave);
            // 
            // menu1_table_calender_panel_day18
            // 
            this.menu1_table_calender_panel_day18.BackColor = System.Drawing.Color.Transparent;
            this.menu1_table_calender_panel_day18.Controls.Add(this.menu1_table_calender_label_day18);
            this.menu1_table_calender_panel_day18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day18.Location = new System.Drawing.Point(283, 147);
            this.menu1_table_calender_panel_day18.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day18.Name = "menu1_table_calender_panel_day18";
            this.menu1_table_calender_panel_day18.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day18.TabIndex = 66;
            this.menu1_table_calender_panel_day18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day18_MouseClick);
            this.menu1_table_calender_panel_day18.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day18_DoubleClick);
            this.menu1_table_calender_panel_day18.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day18_MouseEnter);
            this.menu1_table_calender_panel_day18.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day18_MouseLeave);
            // 
            // menu1_table_calender_label_day18
            // 
            this.menu1_table_calender_label_day18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day18.BackColor = System.Drawing.Color.Transparent;
            this.menu1_table_calender_label_day18.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day18.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day18.Name = "menu1_table_calender_label_day18";
            this.menu1_table_calender_label_day18.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day18.TabIndex = 24;
            this.menu1_table_calender_label_day18.Text = "label18";
            this.menu1_table_calender_label_day18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day18_MouseClick);
            this.menu1_table_calender_label_day18.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day18_DoubleClick);
            this.menu1_table_calender_label_day18.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day18_MouseEnter);
            this.menu1_table_calender_label_day18.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day18_MouseLeave);
            // 
            // menu1_table_calender_panel_day17
            // 
            this.menu1_table_calender_panel_day17.Controls.Add(this.menu1_table_calender_label_day17);
            this.menu1_table_calender_panel_day17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day17.Location = new System.Drawing.Point(189, 147);
            this.menu1_table_calender_panel_day17.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day17.Name = "menu1_table_calender_panel_day17";
            this.menu1_table_calender_panel_day17.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day17.TabIndex = 65;
            this.menu1_table_calender_panel_day17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day17_MouseClick);
            this.menu1_table_calender_panel_day17.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day17_DoubleClick);
            this.menu1_table_calender_panel_day17.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day17_MouseEnter);
            this.menu1_table_calender_panel_day17.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day17_MouseLeave);
            // 
            // menu1_table_calender_label_day17
            // 
            this.menu1_table_calender_label_day17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day17.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day17.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day17.Name = "menu1_table_calender_label_day17";
            this.menu1_table_calender_label_day17.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day17.TabIndex = 23;
            this.menu1_table_calender_label_day17.Text = "label17";
            this.menu1_table_calender_label_day17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day17_MouseClick);
            this.menu1_table_calender_label_day17.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day17_DoubleClick);
            this.menu1_table_calender_label_day17.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day17_MouseEnter);
            this.menu1_table_calender_label_day17.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day17_MouseLeave);
            // 
            // menu1_table_calender_panel_day16
            // 
            this.menu1_table_calender_panel_day16.Controls.Add(this.menu1_table_calender_label_day16);
            this.menu1_table_calender_panel_day16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day16.Location = new System.Drawing.Point(95, 147);
            this.menu1_table_calender_panel_day16.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day16.Name = "menu1_table_calender_panel_day16";
            this.menu1_table_calender_panel_day16.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day16.TabIndex = 64;
            this.menu1_table_calender_panel_day16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day16_MouseClick);
            this.menu1_table_calender_panel_day16.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day16_DoubleClick);
            this.menu1_table_calender_panel_day16.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day16_MouseEnter);
            this.menu1_table_calender_panel_day16.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day16_MouseLeave);
            // 
            // menu1_table_calender_label_day16
            // 
            this.menu1_table_calender_label_day16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day16.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day16.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day16.Name = "menu1_table_calender_label_day16";
            this.menu1_table_calender_label_day16.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day16.TabIndex = 22;
            this.menu1_table_calender_label_day16.Text = "label16";
            this.menu1_table_calender_label_day16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day16_MouseClick);
            this.menu1_table_calender_label_day16.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day16_DoubleClick);
            this.menu1_table_calender_label_day16.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day16_MouseEnter);
            this.menu1_table_calender_label_day16.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day16_MouseLeave);
            // 
            // menu1_table_calender_panel_day15
            // 
            this.menu1_table_calender_panel_day15.Controls.Add(this.menu1_table_calender_label_day15);
            this.menu1_table_calender_panel_day15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day15.Location = new System.Drawing.Point(1, 147);
            this.menu1_table_calender_panel_day15.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day15.Name = "menu1_table_calender_panel_day15";
            this.menu1_table_calender_panel_day15.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day15.TabIndex = 63;
            this.menu1_table_calender_panel_day15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day15_MouseClick);
            this.menu1_table_calender_panel_day15.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day15_DoubleClick);
            this.menu1_table_calender_panel_day15.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day15_MouseEnter);
            this.menu1_table_calender_panel_day15.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day15_MouseLeave);
            // 
            // menu1_table_calender_label_day15
            // 
            this.menu1_table_calender_label_day15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day15.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day15.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day15.Name = "menu1_table_calender_label_day15";
            this.menu1_table_calender_label_day15.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day15.TabIndex = 21;
            this.menu1_table_calender_label_day15.Text = "label15";
            this.menu1_table_calender_label_day15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day15_MouseClick);
            this.menu1_table_calender_label_day15.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day15_DoubleClick);
            this.menu1_table_calender_label_day15.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day15_MouseEnter);
            this.menu1_table_calender_label_day15.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day15_MouseLeave);
            // 
            // menu1_table_calender_panel_day14
            // 
            this.menu1_table_calender_panel_day14.Controls.Add(this.menu1_table_calender_label_day14);
            this.menu1_table_calender_panel_day14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day14.Location = new System.Drawing.Point(565, 84);
            this.menu1_table_calender_panel_day14.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day14.Name = "menu1_table_calender_panel_day14";
            this.menu1_table_calender_panel_day14.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day14.TabIndex = 62;
            this.menu1_table_calender_panel_day14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day14_MouseClick);
            this.menu1_table_calender_panel_day14.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day14_DoubleClick);
            this.menu1_table_calender_panel_day14.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day14_MouseEnter);
            this.menu1_table_calender_panel_day14.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day14_MouseLeave);
            // 
            // menu1_table_calender_label_day14
            // 
            this.menu1_table_calender_label_day14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day14.Location = new System.Drawing.Point(4, 1);
            this.menu1_table_calender_label_day14.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day14.Name = "menu1_table_calender_label_day14";
            this.menu1_table_calender_label_day14.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day14.TabIndex = 20;
            this.menu1_table_calender_label_day14.Text = "14";
            this.menu1_table_calender_label_day14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day14_MouseClick);
            this.menu1_table_calender_label_day14.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day14_DoubleClick);
            this.menu1_table_calender_label_day14.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day14_MouseEnter);
            this.menu1_table_calender_label_day14.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day14_MouseLeave);
            // 
            // menu1_table_calender_panel_day13
            // 
            this.menu1_table_calender_panel_day13.BackColor = System.Drawing.Color.Transparent;
            this.menu1_table_calender_panel_day13.Controls.Add(this.menu1_table_calender_label_day13);
            this.menu1_table_calender_panel_day13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day13.Location = new System.Drawing.Point(471, 84);
            this.menu1_table_calender_panel_day13.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day13.Name = "menu1_table_calender_panel_day13";
            this.menu1_table_calender_panel_day13.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day13.TabIndex = 61;
            this.menu1_table_calender_panel_day13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day13_MouseClick);
            this.menu1_table_calender_panel_day13.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day13_DoubleClick);
            this.menu1_table_calender_panel_day13.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day13_MouseEnter);
            this.menu1_table_calender_panel_day13.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day13_MouseLeave);
            // 
            // menu1_table_calender_label_day13
            // 
            this.menu1_table_calender_label_day13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day13.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day13.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day13.Name = "menu1_table_calender_label_day13";
            this.menu1_table_calender_label_day13.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day13.TabIndex = 19;
            this.menu1_table_calender_label_day13.Text = "13";
            this.menu1_table_calender_label_day13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day13_MouseClick);
            this.menu1_table_calender_label_day13.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day13_DoubleClick);
            this.menu1_table_calender_label_day13.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day13_MouseEnter);
            this.menu1_table_calender_label_day13.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day3_MouseLeave);
            // 
            // menu1_table_calender_panel_day12
            // 
            this.menu1_table_calender_panel_day12.Controls.Add(this.menu1_table_calender_label_day12);
            this.menu1_table_calender_panel_day12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day12.Location = new System.Drawing.Point(377, 84);
            this.menu1_table_calender_panel_day12.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day12.Name = "menu1_table_calender_panel_day12";
            this.menu1_table_calender_panel_day12.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day12.TabIndex = 60;
            this.menu1_table_calender_panel_day12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day12_MouseClick);
            this.menu1_table_calender_panel_day12.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day12_DoubleClick);
            this.menu1_table_calender_panel_day12.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day12_MouseEnter);
            this.menu1_table_calender_panel_day12.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day12_MouseLeave);
            // 
            // menu1_table_calender_label_day12
            // 
            this.menu1_table_calender_label_day12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day12.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day12.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day12.Name = "menu1_table_calender_label_day12";
            this.menu1_table_calender_label_day12.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day12.TabIndex = 18;
            this.menu1_table_calender_label_day12.Text = "12";
            this.menu1_table_calender_label_day12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day12_MouseClick);
            this.menu1_table_calender_label_day12.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day12_DoubleClick);
            this.menu1_table_calender_label_day12.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day12_MouseEnter);
            this.menu1_table_calender_label_day12.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day12_MouseLeave);
            // 
            // menu1_table_calender_panel_day11
            // 
            this.menu1_table_calender_panel_day11.Controls.Add(this.menu1_table_calender_label_day11);
            this.menu1_table_calender_panel_day11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day11.Location = new System.Drawing.Point(283, 84);
            this.menu1_table_calender_panel_day11.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day11.Name = "menu1_table_calender_panel_day11";
            this.menu1_table_calender_panel_day11.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day11.TabIndex = 59;
            this.menu1_table_calender_panel_day11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day12_MouseClick);
            this.menu1_table_calender_panel_day11.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day11_DoubleClick);
            this.menu1_table_calender_panel_day11.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day11_MouseEnter);
            this.menu1_table_calender_panel_day11.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day11_MouseLeave);
            // 
            // menu1_table_calender_label_day11
            // 
            this.menu1_table_calender_label_day11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day11.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day11.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day11.Name = "menu1_table_calender_label_day11";
            this.menu1_table_calender_label_day11.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day11.TabIndex = 17;
            this.menu1_table_calender_label_day11.Text = "11";
            this.menu1_table_calender_label_day11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day12_MouseClick);
            this.menu1_table_calender_label_day11.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day11_DoubleClick);
            this.menu1_table_calender_label_day11.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day11_MouseEnter);
            this.menu1_table_calender_label_day11.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day11_MouseLeave);
            // 
            // menu1_table_calender_panel_day8
            // 
            this.menu1_table_calender_panel_day8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day8.Controls.Add(this.menu1_table_calender_label_day8);
            this.menu1_table_calender_panel_day8.Location = new System.Drawing.Point(1, 84);
            this.menu1_table_calender_panel_day8.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day8.Name = "menu1_table_calender_panel_day8";
            this.menu1_table_calender_panel_day8.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day8.TabIndex = 56;
            this.menu1_table_calender_panel_day8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day8_MouseClick);
            this.menu1_table_calender_panel_day8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day8_DoubleClick);
            this.menu1_table_calender_panel_day8.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day8_MouseEnter);
            this.menu1_table_calender_panel_day8.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day8_MouseLeave);
            // 
            // menu1_table_calender_label_day8
            // 
            this.menu1_table_calender_label_day8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day8.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day8.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day8.Name = "menu1_table_calender_label_day8";
            this.menu1_table_calender_label_day8.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day8.TabIndex = 14;
            this.menu1_table_calender_label_day8.Text = "8";
            this.menu1_table_calender_label_day8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day8_MouseClick);
            this.menu1_table_calender_label_day8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day8_DoubleClick);
            this.menu1_table_calender_label_day8.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day8_MouseEnter);
            this.menu1_table_calender_label_day8.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day8_MouseLeave);
            // 
            // menu1_table_calender_panel_day7
            // 
            this.menu1_table_calender_panel_day7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day7.Controls.Add(this.menu1_table_calender_label_day7);
            this.menu1_table_calender_panel_day7.Location = new System.Drawing.Point(565, 21);
            this.menu1_table_calender_panel_day7.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day7.Name = "menu1_table_calender_panel_day7";
            this.menu1_table_calender_panel_day7.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day7.TabIndex = 55;
            this.menu1_table_calender_panel_day7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day7_MouseClick);
            this.menu1_table_calender_panel_day7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day7_DoubleClick);
            this.menu1_table_calender_panel_day7.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day7_MouseEnter);
            this.menu1_table_calender_panel_day7.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day7_MouseLeave);
            // 
            // menu1_table_calender_label_day7
            // 
            this.menu1_table_calender_label_day7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day7.Location = new System.Drawing.Point(4, 1);
            this.menu1_table_calender_label_day7.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day7.Name = "menu1_table_calender_label_day7";
            this.menu1_table_calender_label_day7.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day7.TabIndex = 13;
            this.menu1_table_calender_label_day7.Text = "7";
            this.menu1_table_calender_label_day7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day7_MouseClick);
            this.menu1_table_calender_label_day7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day7_DoubleClick);
            this.menu1_table_calender_label_day7.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day7_MouseEnter);
            this.menu1_table_calender_label_day7.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day7_MouseLeave);
            // 
            // menu1_table_calender_panel_day6
            // 
            this.menu1_table_calender_panel_day6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day6.Controls.Add(this.menu1_table_calender_label_day6);
            this.menu1_table_calender_panel_day6.Location = new System.Drawing.Point(471, 21);
            this.menu1_table_calender_panel_day6.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day6.Name = "menu1_table_calender_panel_day6";
            this.menu1_table_calender_panel_day6.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day6.TabIndex = 54;
            this.menu1_table_calender_panel_day6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day6_MouseClick);
            this.menu1_table_calender_panel_day6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day6_DoubleClick);
            this.menu1_table_calender_panel_day6.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day6_MouseEnter);
            this.menu1_table_calender_panel_day6.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day6_MouseLeave);
            // 
            // menu1_table_calender_label_day6
            // 
            this.menu1_table_calender_label_day6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day6.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day6.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day6.Name = "menu1_table_calender_label_day6";
            this.menu1_table_calender_label_day6.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day6.TabIndex = 12;
            this.menu1_table_calender_label_day6.Text = "6";
            this.menu1_table_calender_label_day6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day6_MouseClick);
            this.menu1_table_calender_label_day6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day6_DoubleClick);
            this.menu1_table_calender_label_day6.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day6_MouseEnter);
            this.menu1_table_calender_label_day6.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day6_MouseLeave);
            // 
            // menu1_table_calender_panel_day5
            // 
            this.menu1_table_calender_panel_day5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day5.Controls.Add(this.menu1_table_calender_label_day5);
            this.menu1_table_calender_panel_day5.Location = new System.Drawing.Point(377, 21);
            this.menu1_table_calender_panel_day5.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day5.Name = "menu1_table_calender_panel_day5";
            this.menu1_table_calender_panel_day5.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day5.TabIndex = 53;
            this.menu1_table_calender_panel_day5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day5_MouseClick);
            this.menu1_table_calender_panel_day5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day5_DoubleClick);
            this.menu1_table_calender_panel_day5.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day5_MouseEnter);
            this.menu1_table_calender_panel_day5.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day5_MouseLeave);
            // 
            // menu1_table_calender_label_day5
            // 
            this.menu1_table_calender_label_day5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day5.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day5.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_table_calender_label_day5.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day5.Name = "menu1_table_calender_label_day5";
            this.menu1_table_calender_label_day5.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day5.TabIndex = 11;
            this.menu1_table_calender_label_day5.Text = "5";
            this.menu1_table_calender_label_day5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day5_MouseClick);
            this.menu1_table_calender_label_day5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day5_DoubleClick);
            this.menu1_table_calender_label_day5.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day5_MouseEnter);
            this.menu1_table_calender_label_day5.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day5_MouseLeave);
            // 
            // menu1_table_calender_panel_day4
            // 
            this.menu1_table_calender_panel_day4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day4.Controls.Add(this.menu1_table_calender_label_day4);
            this.menu1_table_calender_panel_day4.ForeColor = System.Drawing.Color.Black;
            this.menu1_table_calender_panel_day4.Location = new System.Drawing.Point(283, 21);
            this.menu1_table_calender_panel_day4.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day4.Name = "menu1_table_calender_panel_day4";
            this.menu1_table_calender_panel_day4.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day4.TabIndex = 52;
            this.menu1_table_calender_panel_day4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day4_MouseClick);
            this.menu1_table_calender_panel_day4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day4_DoubleClick);
            this.menu1_table_calender_panel_day4.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day4_MouseEnter);
            this.menu1_table_calender_panel_day4.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day4_MouseLeave);
            // 
            // menu1_table_calender_label_day4
            // 
            this.menu1_table_calender_label_day4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day4.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day4.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_table_calender_label_day4.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day4.Name = "menu1_table_calender_label_day4";
            this.menu1_table_calender_label_day4.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day4.TabIndex = 10;
            this.menu1_table_calender_label_day4.Text = "4";
            this.menu1_table_calender_label_day4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day4_MouseClick);
            this.menu1_table_calender_label_day4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day4_DoubleClick);
            this.menu1_table_calender_label_day4.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day4_MouseEnter);
            this.menu1_table_calender_label_day4.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day4_MouseLeave);
            // 
            // menu1_table_calender_panel_day3
            // 
            this.menu1_table_calender_panel_day3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day3.Controls.Add(this.menu1_table_calender_label_day3);
            this.menu1_table_calender_panel_day3.Location = new System.Drawing.Point(189, 21);
            this.menu1_table_calender_panel_day3.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day3.Name = "menu1_table_calender_panel_day3";
            this.menu1_table_calender_panel_day3.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day3.TabIndex = 51;
            this.menu1_table_calender_panel_day3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day3_MouseClick);
            this.menu1_table_calender_panel_day3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day3_DoubleClick);
            this.menu1_table_calender_panel_day3.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day3_MouseEnter);
            this.menu1_table_calender_panel_day3.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day3_MouseLeave);
            // 
            // menu1_table_calender_label_day3
            // 
            this.menu1_table_calender_label_day3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day3.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day3.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_table_calender_label_day3.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day3.Name = "menu1_table_calender_label_day3";
            this.menu1_table_calender_label_day3.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day3.TabIndex = 9;
            this.menu1_table_calender_label_day3.Text = "3";
            this.menu1_table_calender_label_day3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day3_MouseClick);
            this.menu1_table_calender_label_day3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day3_DoubleClick);
            this.menu1_table_calender_label_day3.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day3_MouseEnter);
            this.menu1_table_calender_label_day3.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day3_MouseLeave);
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
            // menu1_table_calender_panel_day2
            // 
            this.menu1_table_calender_panel_day2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_table_calender_panel_day2.Controls.Add(this.menu1_table_calender_label_day2);
            this.menu1_table_calender_panel_day2.Location = new System.Drawing.Point(95, 21);
            this.menu1_table_calender_panel_day2.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day2.Name = "menu1_table_calender_panel_day2";
            this.menu1_table_calender_panel_day2.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day2.TabIndex = 50;
            this.menu1_table_calender_panel_day2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day2_MouseClick);
            this.menu1_table_calender_panel_day2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day2_DoubleClick);
            this.menu1_table_calender_panel_day2.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day2_MouseEnter);
            this.menu1_table_calender_panel_day2.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day2_MouseLeave);
            // 
            // menu1_table_calender_label_day2
            // 
            this.menu1_table_calender_label_day2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day2.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day2.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_table_calender_label_day2.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day2.Name = "menu1_table_calender_label_day2";
            this.menu1_table_calender_label_day2.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day2.TabIndex = 8;
            this.menu1_table_calender_label_day2.Text = "2";
            this.menu1_table_calender_label_day2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day2_MouseClick);
            this.menu1_table_calender_label_day2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day2_DoubleClick);
            this.menu1_table_calender_label_day2.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day2_MouseEnter);
            this.menu1_table_calender_label_day2.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day2_MouseLeave);
            // 
            // menu1_table_calender_panel_day9
            // 
            this.menu1_table_calender_panel_day9.Controls.Add(this.menu1_table_calender_label_day9);
            this.menu1_table_calender_panel_day9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day9.Location = new System.Drawing.Point(95, 84);
            this.menu1_table_calender_panel_day9.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day9.Name = "menu1_table_calender_panel_day9";
            this.menu1_table_calender_panel_day9.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day9.TabIndex = 57;
            this.menu1_table_calender_panel_day9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day9_MouseClick);
            this.menu1_table_calender_panel_day9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day9_DoubleClick);
            this.menu1_table_calender_panel_day9.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day9_MouseEnter);
            this.menu1_table_calender_panel_day9.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day9_MouseLeave);
            // 
            // menu1_table_calender_label_day9
            // 
            this.menu1_table_calender_label_day9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day9.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day9.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day9.Name = "menu1_table_calender_label_day9";
            this.menu1_table_calender_label_day9.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day9.TabIndex = 15;
            this.menu1_table_calender_label_day9.Text = "9";
            this.menu1_table_calender_label_day9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day9_MouseClick);
            this.menu1_table_calender_label_day9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day9_DoubleClick);
            this.menu1_table_calender_label_day9.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day9_MouseEnter);
            this.menu1_table_calender_label_day9.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day9_MouseLeave);
            // 
            // menu1_table_calender_panel_day10
            // 
            this.menu1_table_calender_panel_day10.Controls.Add(this.menu1_table_calender_label_day10);
            this.menu1_table_calender_panel_day10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_table_calender_panel_day10.Location = new System.Drawing.Point(189, 84);
            this.menu1_table_calender_panel_day10.Margin = new System.Windows.Forms.Padding(1);
            this.menu1_table_calender_panel_day10.Name = "menu1_table_calender_panel_day10";
            this.menu1_table_calender_panel_day10.Size = new System.Drawing.Size(92, 61);
            this.menu1_table_calender_panel_day10.TabIndex = 58;
            this.menu1_table_calender_panel_day10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day10_MouseClick);
            this.menu1_table_calender_panel_day10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day10_DoubleClick);
            this.menu1_table_calender_panel_day10.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day10_MouseEnter);
            this.menu1_table_calender_panel_day10.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day10_MouseLeave);
            // 
            // menu1_table_calender_label_day10
            // 
            this.menu1_table_calender_label_day10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1_table_calender_label_day10.Location = new System.Drawing.Point(6, 1);
            this.menu1_table_calender_label_day10.MaximumSize = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day10.Name = "menu1_table_calender_label_day10";
            this.menu1_table_calender_label_day10.Size = new System.Drawing.Size(78, 15);
            this.menu1_table_calender_label_day10.TabIndex = 16;
            this.menu1_table_calender_label_day10.Text = "10";
            this.menu1_table_calender_label_day10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu1_table_calender_label_day10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day10_MouseClick);
            this.menu1_table_calender_label_day10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_table_calender_panel_day10_DoubleClick);
            this.menu1_table_calender_label_day10.MouseEnter += new System.EventHandler(this.menu1_table_calender_panel_day10_MouseEnter);
            this.menu1_table_calender_label_day10.MouseLeave += new System.EventHandler(this.menu1_table_calender_panel_day10_MouseLeave);
            // 
            // menu2
            // 
            this.menu2.AutoScroll = true;
            this.menu2.Controls.Add(this.menu2_3);
            this.menu2.Controls.Add(this.menu2_2);
            this.menu2.Controls.Add(this.menu2_1);
            this.menu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2.Location = new System.Drawing.Point(0, 479);
            this.menu2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(682, 811);
            this.menu2.TabIndex = 3;
            // 
            // menu2_3
            // 
            this.menu2_3.Controls.Add(this.menu2_3_panel);
            this.menu2_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_3.Location = new System.Drawing.Point(0, 1620);
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
            this.menu2_3_panel_main_panel22_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel20_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel19_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel18_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel17_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel16_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel15_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel14_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel13_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel12_label1.Text = "label76";
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
            this.menu2_3_panel_main_panel11_label1.Text = "label19";
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
            this.menu2_3_panel_main_panel10_label1.Text = "label80";
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
            this.menu2_3_panel_main_panel9_label1.Text = "label82";
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
            this.menu2_3_panel_main_panel8_label1.Text = "label84";
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
            this.menu2_3_panel_main_panel7_label1.Text = "label86";
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
            this.menu2_3_panel_main_panel6_label1.Text = "label88";
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
            this.menu2_3_panel_main_panel5_label1.Text = "label90";
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
            this.menu2_3_panel_main_panel4_label1.Text = "label92";
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
            this.menu2_3_panel_main_panel3_label1.Text = "label94";
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
            this.menu2_3_panel_main_panel2_label1.Text = "label96";
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
            this.menu2_3_panel_main_panel1_label1.Text = "label1";
            this.menu2_3_panel_main_panel1_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_3_panel_main_panel1_label1.Click += new System.EventHandler(this.menu2_3_panel_main_panel1_label1_Click);
            // 
            // menu2_2
            // 
            this.menu2_2.Controls.Add(this.menu2_2_panel_margin);
            this.menu2_2.Controls.Add(this.menu2_2_panel);
            this.menu2_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2.Location = new System.Drawing.Point(0, 950);
            this.menu2_2.Name = "menu2_2";
            this.menu2_2.Size = new System.Drawing.Size(665, 670);
            this.menu2_2.TabIndex = 9;
            // 
            // menu2_2_panel_margin
            // 
            this.menu2_2_panel_margin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_margin.Location = new System.Drawing.Point(1, 650);
            this.menu2_2_panel_margin.Name = "menu2_2_panel_margin";
            this.menu2_2_panel_margin.Size = new System.Drawing.Size(663, 8);
            this.menu2_2_panel_margin.TabIndex = 6;
            // 
            // menu2_2_panel
            // 
            this.menu2_2_panel.BorderColor = System.Drawing.Color.Black;
            this.menu2_2_panel.Controls.Add(this.menu2_2_panel_top);
            this.menu2_2_panel.Controls.Add(this.menu2_2_panel_main);
            this.menu2_2_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2_panel.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel.Name = "menu2_2_panel";
            this.menu2_2_panel.Size = new System.Drawing.Size(665, 564);
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
            this.menu2_2_panel_main.Controls.Add(this.menu2_2_panel_main_panel5);
            this.menu2_2_panel_main.Controls.Add(this.menu2_2_panel_main_panel4);
            this.menu2_2_panel_main.Controls.Add(this.menu2_2_panel_main_panel3);
            this.menu2_2_panel_main.Controls.Add(this.menu2_2_panel_main_panel2);
            this.menu2_2_panel_main.Controls.Add(this.menu2_2_panel_main_panel1);
            this.menu2_2_panel_main.Location = new System.Drawing.Point(1, 33);
            this.menu2_2_panel_main.Name = "menu2_2_panel_main";
            this.menu2_2_panel_main.Size = new System.Drawing.Size(663, 531);
            this.menu2_2_panel_main.TabIndex = 5;
            // 
            // menu2_2_panel_main_panel5
            // 
            this.menu2_2_panel_main_panel5.Controls.Add(this.menu2_2_panel_main_panel5_table_memo);
            this.menu2_2_panel_main_panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2_panel_main_panel5.Location = new System.Drawing.Point(0, 424);
            this.menu2_2_panel_main_panel5.Name = "menu2_2_panel_main_panel5";
            this.menu2_2_panel_main_panel5.Size = new System.Drawing.Size(663, 106);
            this.menu2_2_panel_main_panel5.TabIndex = 13;
            // 
            // menu2_2_panel_main_panel5_table_memo
            // 
            this.menu2_2_panel_main_panel5_table_memo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_main_panel5_table_memo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menu2_2_panel_main_panel5_table_memo.ColumnCount = 1;
            this.menu2_2_panel_main_panel5_table_memo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu2_2_panel_main_panel5_table_memo.Controls.Add(this.menu2_2_panel_main_panel5_table_memo_text, 0, 1);
            this.menu2_2_panel_main_panel5_table_memo.Controls.Add(this.menu2_2_panel_main_panel5_table_memo_panel_top, 0, 0);
            this.menu2_2_panel_main_panel5_table_memo.Location = new System.Drawing.Point(4, 0);
            this.menu2_2_panel_main_panel5_table_memo.Name = "menu2_2_panel_main_panel5_table_memo";
            this.menu2_2_panel_main_panel5_table_memo.RowCount = 2;
            this.menu2_2_panel_main_panel5_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.menu2_2_panel_main_panel5_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.menu2_2_panel_main_panel5_table_memo.Size = new System.Drawing.Size(655, 102);
            this.menu2_2_panel_main_panel5_table_memo.TabIndex = 8;
            // 
            // menu2_2_panel_main_panel5_table_memo_text
            // 
            this.menu2_2_panel_main_panel5_table_memo_text.AcceptsReturn = true;
            this.menu2_2_panel_main_panel5_table_memo_text.AcceptsTab = true;
            this.menu2_2_panel_main_panel5_table_memo_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel5_table_memo_text.Location = new System.Drawing.Point(1, 24);
            this.menu2_2_panel_main_panel5_table_memo_text.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel5_table_memo_text.Multiline = true;
            this.menu2_2_panel_main_panel5_table_memo_text.Name = "menu2_2_panel_main_panel5_table_memo_text";
            this.menu2_2_panel_main_panel5_table_memo_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.menu2_2_panel_main_panel5_table_memo_text.Size = new System.Drawing.Size(653, 77);
            this.menu2_2_panel_main_panel5_table_memo_text.TabIndex = 0;
            // 
            // menu2_2_panel_main_panel5_table_memo_panel_top
            // 
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel5_table_memo_panel_top_text);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Name = "menu2_2_panel_main_panel5_table_memo_panel_top";
            this.menu2_2_panel_main_panel5_table_memo_panel_top.Size = new System.Drawing.Size(653, 22);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.TabIndex = 1;
            // 
            // menu2_2_panel_main_panel5_table_memo_panel_top_text
            // 
            this.menu2_2_panel_main_panel5_table_memo_panel_top_text.BackColor = System.Drawing.SystemColors.Control;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_text.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_text.Name = "menu2_2_panel_main_panel5_table_memo_panel_top_text";
            this.menu2_2_panel_main_panel5_table_memo_panel_top_text.Size = new System.Drawing.Size(557, 23);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_text.TabIndex = 4;
            // 
            // menu2_2_panel_main_panel5_table_memo_panel_top_button_save
            // 
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.Location = new System.Drawing.Point(557, 0);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.Name = "menu2_2_panel_main_panel5_table_memo_panel_top_button_save";
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.TabIndex = 3;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save.Click += new System.EventHandler(this.menu2_2_panel_main_panel5_table_memo_panel_top_button_save_Click);
            // 
            // menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax
            // 
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.Location = new System.Drawing.Point(589, 0);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.Name = "menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax";
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.TabIndex = 2;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax.Click += new System.EventHandler(this.menu2_2_panel_main_panel5_table_memo_panel_top_button_minmax_Click);
            // 
            // menu2_2_panel_main_panel5_table_memo_panel_top_button_close
            // 
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.Location = new System.Drawing.Point(621, 0);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.Name = "menu2_2_panel_main_panel5_table_memo_panel_top_button_close";
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.TabIndex = 1;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close.Click += new System.EventHandler(this.menu2_2_panel_main_panel5_table_memo_panel_top_button_close_Click);
            // 
            // menu2_2_panel_main_panel4
            // 
            this.menu2_2_panel_main_panel4.Controls.Add(this.menu2_2_panel_main_panel4_table_memo);
            this.menu2_2_panel_main_panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2_panel_main_panel4.Location = new System.Drawing.Point(0, 318);
            this.menu2_2_panel_main_panel4.Name = "menu2_2_panel_main_panel4";
            this.menu2_2_panel_main_panel4.Size = new System.Drawing.Size(663, 106);
            this.menu2_2_panel_main_panel4.TabIndex = 12;
            // 
            // menu2_2_panel_main_panel4_table_memo
            // 
            this.menu2_2_panel_main_panel4_table_memo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_main_panel4_table_memo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menu2_2_panel_main_panel4_table_memo.ColumnCount = 1;
            this.menu2_2_panel_main_panel4_table_memo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu2_2_panel_main_panel4_table_memo.Controls.Add(this.menu2_2_panel_main_panel4_table_memo_text, 0, 1);
            this.menu2_2_panel_main_panel4_table_memo.Controls.Add(this.menu2_2_panel_main_panel4_table_memo_panel_top, 0, 0);
            this.menu2_2_panel_main_panel4_table_memo.Location = new System.Drawing.Point(4, 0);
            this.menu2_2_panel_main_panel4_table_memo.Name = "menu2_2_panel_main_panel4_table_memo";
            this.menu2_2_panel_main_panel4_table_memo.RowCount = 2;
            this.menu2_2_panel_main_panel4_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.menu2_2_panel_main_panel4_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.menu2_2_panel_main_panel4_table_memo.Size = new System.Drawing.Size(655, 102);
            this.menu2_2_panel_main_panel4_table_memo.TabIndex = 7;
            // 
            // menu2_2_panel_main_panel4_table_memo_text
            // 
            this.menu2_2_panel_main_panel4_table_memo_text.AcceptsReturn = true;
            this.menu2_2_panel_main_panel4_table_memo_text.AcceptsTab = true;
            this.menu2_2_panel_main_panel4_table_memo_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel4_table_memo_text.Location = new System.Drawing.Point(1, 24);
            this.menu2_2_panel_main_panel4_table_memo_text.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel4_table_memo_text.Multiline = true;
            this.menu2_2_panel_main_panel4_table_memo_text.Name = "menu2_2_panel_main_panel4_table_memo_text";
            this.menu2_2_panel_main_panel4_table_memo_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.menu2_2_panel_main_panel4_table_memo_text.Size = new System.Drawing.Size(653, 77);
            this.menu2_2_panel_main_panel4_table_memo_text.TabIndex = 0;
            // 
            // menu2_2_panel_main_panel4_table_memo_panel_top
            // 
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel4_table_memo_panel_top_text);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Name = "menu2_2_panel_main_panel4_table_memo_panel_top";
            this.menu2_2_panel_main_panel4_table_memo_panel_top.Size = new System.Drawing.Size(653, 22);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.TabIndex = 1;
            // 
            // menu2_2_panel_main_panel4_table_memo_panel_top_text
            // 
            this.menu2_2_panel_main_panel4_table_memo_panel_top_text.BackColor = System.Drawing.SystemColors.Control;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_text.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_text.Name = "menu2_2_panel_main_panel4_table_memo_panel_top_text";
            this.menu2_2_panel_main_panel4_table_memo_panel_top_text.Size = new System.Drawing.Size(557, 23);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_text.TabIndex = 4;
            // 
            // menu2_2_panel_main_panel4_table_memo_panel_top_button_save
            // 
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.Location = new System.Drawing.Point(557, 0);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.Name = "menu2_2_panel_main_panel4_table_memo_panel_top_button_save";
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.TabIndex = 3;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save.Click += new System.EventHandler(this.menu2_2_panel_main_panel4_table_memo_panel_top_button_save_Click);
            // 
            // menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax
            // 
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.Location = new System.Drawing.Point(589, 0);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.Name = "menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax";
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.TabIndex = 2;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax.Click += new System.EventHandler(this.menu2_2_panel_main_panel4_table_memo_panel_top_button_minmax_Click);
            // 
            // menu2_2_panel_main_panel4_table_memo_panel_top_button_close
            // 
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.Location = new System.Drawing.Point(621, 0);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.Name = "menu2_2_panel_main_panel4_table_memo_panel_top_button_close";
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.TabIndex = 1;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close.Click += new System.EventHandler(this.menu2_2_panel_main_panel4_table_memo_panel_top_button_close_Click);
            // 
            // menu2_2_panel_main_panel3
            // 
            this.menu2_2_panel_main_panel3.Controls.Add(this.menu2_2_panel_main_panel3_table_memo);
            this.menu2_2_panel_main_panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2_panel_main_panel3.Location = new System.Drawing.Point(0, 212);
            this.menu2_2_panel_main_panel3.Name = "menu2_2_panel_main_panel3";
            this.menu2_2_panel_main_panel3.Size = new System.Drawing.Size(663, 106);
            this.menu2_2_panel_main_panel3.TabIndex = 11;
            // 
            // menu2_2_panel_main_panel3_table_memo
            // 
            this.menu2_2_panel_main_panel3_table_memo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_main_panel3_table_memo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menu2_2_panel_main_panel3_table_memo.ColumnCount = 1;
            this.menu2_2_panel_main_panel3_table_memo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu2_2_panel_main_panel3_table_memo.Controls.Add(this.menu2_2_panel_main_panel3_table_memo_text, 0, 1);
            this.menu2_2_panel_main_panel3_table_memo.Controls.Add(this.menu2_2_panel_main_panel3_table_memo_panel_top, 0, 0);
            this.menu2_2_panel_main_panel3_table_memo.Location = new System.Drawing.Point(4, 0);
            this.menu2_2_panel_main_panel3_table_memo.Name = "menu2_2_panel_main_panel3_table_memo";
            this.menu2_2_panel_main_panel3_table_memo.RowCount = 2;
            this.menu2_2_panel_main_panel3_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.menu2_2_panel_main_panel3_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.menu2_2_panel_main_panel3_table_memo.Size = new System.Drawing.Size(655, 102);
            this.menu2_2_panel_main_panel3_table_memo.TabIndex = 6;
            // 
            // menu2_2_panel_main_panel3_table_memo_text
            // 
            this.menu2_2_panel_main_panel3_table_memo_text.AcceptsReturn = true;
            this.menu2_2_panel_main_panel3_table_memo_text.AcceptsTab = true;
            this.menu2_2_panel_main_panel3_table_memo_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel3_table_memo_text.Location = new System.Drawing.Point(1, 24);
            this.menu2_2_panel_main_panel3_table_memo_text.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel3_table_memo_text.Multiline = true;
            this.menu2_2_panel_main_panel3_table_memo_text.Name = "menu2_2_panel_main_panel3_table_memo_text";
            this.menu2_2_panel_main_panel3_table_memo_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.menu2_2_panel_main_panel3_table_memo_text.Size = new System.Drawing.Size(653, 77);
            this.menu2_2_panel_main_panel3_table_memo_text.TabIndex = 0;
            // 
            // menu2_2_panel_main_panel3_table_memo_panel_top
            // 
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel3_table_memo_panel_top_text);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Name = "menu2_2_panel_main_panel3_table_memo_panel_top";
            this.menu2_2_panel_main_panel3_table_memo_panel_top.Size = new System.Drawing.Size(653, 22);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.TabIndex = 1;
            // 
            // menu2_2_panel_main_panel3_table_memo_panel_top_text
            // 
            this.menu2_2_panel_main_panel3_table_memo_panel_top_text.BackColor = System.Drawing.SystemColors.Control;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_text.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_text.Name = "menu2_2_panel_main_panel3_table_memo_panel_top_text";
            this.menu2_2_panel_main_panel3_table_memo_panel_top_text.Size = new System.Drawing.Size(557, 23);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_text.TabIndex = 4;
            // 
            // menu2_2_panel_main_panel3_table_memo_panel_top_button_save
            // 
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.Location = new System.Drawing.Point(557, 0);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.Name = "menu2_2_panel_main_panel3_table_memo_panel_top_button_save";
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.TabIndex = 3;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save.Click += new System.EventHandler(this.menu2_2_panel_main_panel3_table_memo_panel_top_button_save_Click);
            // 
            // menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax
            // 
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.Location = new System.Drawing.Point(589, 0);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.Name = "menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax";
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.TabIndex = 2;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax.Click += new System.EventHandler(this.menu2_2_panel_main_panel3_table_memo_panel_top_button_minmax_Click);
            // 
            // menu2_2_panel_main_panel3_table_memo_panel_top_button_close
            // 
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.Location = new System.Drawing.Point(621, 0);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.Name = "menu2_2_panel_main_panel3_table_memo_panel_top_button_close";
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.TabIndex = 1;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close.Click += new System.EventHandler(this.menu2_2_panel_main_panel3_table_memo_panel_top_button_close_Click);
            // 
            // menu2_2_panel_main_panel2
            // 
            this.menu2_2_panel_main_panel2.Controls.Add(this.menu2_2_panel_main_panel2_table_memo);
            this.menu2_2_panel_main_panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2_panel_main_panel2.Location = new System.Drawing.Point(0, 106);
            this.menu2_2_panel_main_panel2.Name = "menu2_2_panel_main_panel2";
            this.menu2_2_panel_main_panel2.Size = new System.Drawing.Size(663, 106);
            this.menu2_2_panel_main_panel2.TabIndex = 10;
            // 
            // menu2_2_panel_main_panel2_table_memo
            // 
            this.menu2_2_panel_main_panel2_table_memo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_main_panel2_table_memo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menu2_2_panel_main_panel2_table_memo.ColumnCount = 1;
            this.menu2_2_panel_main_panel2_table_memo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu2_2_panel_main_panel2_table_memo.Controls.Add(this.menu2_2_panel_main_panel2_table_memo_text, 0, 1);
            this.menu2_2_panel_main_panel2_table_memo.Controls.Add(this.menu2_2_panel_main_panel2_table_memo_panel_top, 0, 0);
            this.menu2_2_panel_main_panel2_table_memo.Location = new System.Drawing.Point(4, 0);
            this.menu2_2_panel_main_panel2_table_memo.Name = "menu2_2_panel_main_panel2_table_memo";
            this.menu2_2_panel_main_panel2_table_memo.RowCount = 2;
            this.menu2_2_panel_main_panel2_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.menu2_2_panel_main_panel2_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.menu2_2_panel_main_panel2_table_memo.Size = new System.Drawing.Size(655, 102);
            this.menu2_2_panel_main_panel2_table_memo.TabIndex = 5;
            // 
            // menu2_2_panel_main_panel2_table_memo_text
            // 
            this.menu2_2_panel_main_panel2_table_memo_text.AcceptsReturn = true;
            this.menu2_2_panel_main_panel2_table_memo_text.AcceptsTab = true;
            this.menu2_2_panel_main_panel2_table_memo_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel2_table_memo_text.Location = new System.Drawing.Point(1, 24);
            this.menu2_2_panel_main_panel2_table_memo_text.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel2_table_memo_text.Multiline = true;
            this.menu2_2_panel_main_panel2_table_memo_text.Name = "menu2_2_panel_main_panel2_table_memo_text";
            this.menu2_2_panel_main_panel2_table_memo_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.menu2_2_panel_main_panel2_table_memo_text.Size = new System.Drawing.Size(653, 77);
            this.menu2_2_panel_main_panel2_table_memo_text.TabIndex = 0;
            // 
            // menu2_2_panel_main_panel2_table_memo_panel_top
            // 
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel2_table_memo_panel_top_text);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Name = "menu2_2_panel_main_panel2_table_memo_panel_top";
            this.menu2_2_panel_main_panel2_table_memo_panel_top.Size = new System.Drawing.Size(653, 22);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.TabIndex = 1;
            // 
            // menu2_2_panel_main_panel2_table_memo_panel_top_text
            // 
            this.menu2_2_panel_main_panel2_table_memo_panel_top_text.BackColor = System.Drawing.SystemColors.Control;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_text.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_text.Name = "menu2_2_panel_main_panel2_table_memo_panel_top_text";
            this.menu2_2_panel_main_panel2_table_memo_panel_top_text.Size = new System.Drawing.Size(557, 23);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_text.TabIndex = 4;
            // 
            // menu2_2_panel_main_panel2_table_memo_panel_top_button_save
            // 
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.Location = new System.Drawing.Point(557, 0);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.Name = "menu2_2_panel_main_panel2_table_memo_panel_top_button_save";
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.TabIndex = 3;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save.Click += new System.EventHandler(this.menu2_2_panel_main_panel2_table_memo_panel_top_button_save_Click);
            // 
            // menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax
            // 
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.Location = new System.Drawing.Point(589, 0);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.Name = "menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax";
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.TabIndex = 2;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax.Click += new System.EventHandler(this.menu2_2_panel_main_panel2_table_memo_panel_top_button_minmax_Click);
            // 
            // menu2_2_panel_main_panel2_table_memo_panel_top_button_close
            // 
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.Location = new System.Drawing.Point(621, 0);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.Name = "menu2_2_panel_main_panel2_table_memo_panel_top_button_close";
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.TabIndex = 1;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close.Click += new System.EventHandler(this.menu2_2_panel_main_panel2_table_memo_panel_top_button_close_Click);
            // 
            // menu2_2_panel_main_panel1
            // 
            this.menu2_2_panel_main_panel1.Controls.Add(this.menu2_2_panel_main_panel1_table_memo);
            this.menu2_2_panel_main_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2_panel_main_panel1.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_main_panel1.Name = "menu2_2_panel_main_panel1";
            this.menu2_2_panel_main_panel1.Size = new System.Drawing.Size(663, 106);
            this.menu2_2_panel_main_panel1.TabIndex = 9;
            // 
            // menu2_2_panel_main_panel1_table_memo
            // 
            this.menu2_2_panel_main_panel1_table_memo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_main_panel1_table_memo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menu2_2_panel_main_panel1_table_memo.ColumnCount = 1;
            this.menu2_2_panel_main_panel1_table_memo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu2_2_panel_main_panel1_table_memo.Controls.Add(this.menu2_2_panel_main_panel1_table_memo_text, 0, 1);
            this.menu2_2_panel_main_panel1_table_memo.Controls.Add(this.menu2_2_panel_main_panel1_table_memo_panel_top, 0, 0);
            this.menu2_2_panel_main_panel1_table_memo.Location = new System.Drawing.Point(4, 0);
            this.menu2_2_panel_main_panel1_table_memo.Name = "menu2_2_panel_main_panel1_table_memo";
            this.menu2_2_panel_main_panel1_table_memo.RowCount = 2;
            this.menu2_2_panel_main_panel1_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.menu2_2_panel_main_panel1_table_memo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.menu2_2_panel_main_panel1_table_memo.Size = new System.Drawing.Size(655, 102);
            this.menu2_2_panel_main_panel1_table_memo.TabIndex = 4;
            // 
            // menu2_2_panel_main_panel1_table_memo_text
            // 
            this.menu2_2_panel_main_panel1_table_memo_text.AcceptsReturn = true;
            this.menu2_2_panel_main_panel1_table_memo_text.AcceptsTab = true;
            this.menu2_2_panel_main_panel1_table_memo_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel1_table_memo_text.Location = new System.Drawing.Point(1, 24);
            this.menu2_2_panel_main_panel1_table_memo_text.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel1_table_memo_text.Multiline = true;
            this.menu2_2_panel_main_panel1_table_memo_text.Name = "menu2_2_panel_main_panel1_table_memo_text";
            this.menu2_2_panel_main_panel1_table_memo_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.menu2_2_panel_main_panel1_table_memo_text.Size = new System.Drawing.Size(653, 77);
            this.menu2_2_panel_main_panel1_table_memo_text.TabIndex = 0;
            // 
            // menu2_2_panel_main_panel1_table_memo_panel_top
            // 
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel1_table_memo_panel_top_text);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Controls.Add(this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Name = "menu2_2_panel_main_panel1_table_memo_panel_top";
            this.menu2_2_panel_main_panel1_table_memo_panel_top.Size = new System.Drawing.Size(653, 22);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.TabIndex = 1;
            // 
            // menu2_2_panel_main_panel1_table_memo_panel_top_text
            // 
            this.menu2_2_panel_main_panel1_table_memo_panel_top_text.BackColor = System.Drawing.SystemColors.Control;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_text.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_text.Name = "menu2_2_panel_main_panel1_table_memo_panel_top_text";
            this.menu2_2_panel_main_panel1_table_memo_panel_top_text.Size = new System.Drawing.Size(557, 23);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_text.TabIndex = 4;
            // 
            // menu2_2_panel_main_panel1_table_memo_panel_top_button_save
            // 
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.Location = new System.Drawing.Point(557, 0);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.Name = "menu2_2_panel_main_panel1_table_memo_panel_top_button_save";
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.TabIndex = 3;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save.Click += new System.EventHandler(this.menu2_2_panel_main_panel1_table_memo_panel_top_button_save_Click);
            // 
            // menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax
            // 
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.Location = new System.Drawing.Point(589, 0);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.Name = "menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax";
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.TabIndex = 2;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax.Click += new System.EventHandler(this.menu2_2_panel_main_panel1_table_memo_panel_top_button_minmax_Click);
            // 
            // menu2_2_panel_main_panel1_table_memo_panel_top_button_close
            // 
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.Location = new System.Drawing.Point(621, 0);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.Name = "menu2_2_panel_main_panel1_table_memo_panel_top_button_close";
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.Size = new System.Drawing.Size(32, 22);
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.TabIndex = 1;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.UseVisualStyleBackColor = true;
            this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close.Click += new System.EventHandler(this.menu2_2_panel_main_panel1_table_memo_panel_top_button_close_Click);
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
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel25);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel24);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel23);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel22);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel21);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel20);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel19);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel18);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel17);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel16);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel15);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel14);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel13);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel12);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel11);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel10);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel9);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel8);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel7);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel6);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel5);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel4);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel3);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel2);
            this.menu2_1_panel_main.Controls.Add(this.menu2_1_panel_main_panel1);
            this.menu2_1_panel_main.Location = new System.Drawing.Point(1, 34);
            this.menu2_1_panel_main.Name = "menu2_1_panel_main";
            this.menu2_1_panel_main.Size = new System.Drawing.Size(663, 899);
            this.menu2_1_panel_main.TabIndex = 3;
            // 
            // menu2_1_panel_main_panel25
            // 
            this.menu2_1_panel_main_panel25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel25.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel25.Controls.Add(this.menu2_1_panel_main_panel25_button_finish);
            this.menu2_1_panel_main_panel25.Controls.Add(this.menu2_1_panel_main_panel25_button_delete);
            this.menu2_1_panel_main_panel25.Controls.Add(this.menu2_1_panel_main_panel25_label1);
            this.menu2_1_panel_main_panel25.Controls.Add(this.menu2_1_panel_main_panel25_label2);
            this.menu2_1_panel_main_panel25.Location = new System.Drawing.Point(4, 864);
            this.menu2_1_panel_main_panel25.Name = "menu2_1_panel_main_panel25";
            this.menu2_1_panel_main_panel25.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel25.TabIndex = 27;
            this.menu2_1_panel_main_panel25.Click += new System.EventHandler(this.menu2_1_panel_main_panel25_Click);
            // 
            // menu2_1_panel_main_panel25_button_finish
            // 
            this.menu2_1_panel_main_panel25_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel25_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel25_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel25_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel25_button_finish.Name = "menu2_1_panel_main_panel25_button_finish";
            this.menu2_1_panel_main_panel25_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel25_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel25_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel25_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel25_button_finish_Click);
            // 
            // menu2_1_panel_main_panel25_button_delete
            // 
            this.menu2_1_panel_main_panel25_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel25_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel25_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel25_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel25_button_delete.Name = "menu2_1_panel_main_panel25_button_delete";
            this.menu2_1_panel_main_panel25_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel25_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel25_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel25_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel25_button_delete_Click);
            // 
            // menu2_1_panel_main_panel25_label1
            // 
            this.menu2_1_panel_main_panel25_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel25_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel25_label1.Name = "menu2_1_panel_main_panel25_label1";
            this.menu2_1_panel_main_panel25_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel25_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel25_label1.Text = "label19";
            this.menu2_1_panel_main_panel25_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel25_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel25_label1_Click);
            // 
            // menu2_1_panel_main_panel25_label2
            // 
            this.menu2_1_panel_main_panel25_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel25_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel25_label2.Name = "menu2_1_panel_main_panel25_label2";
            this.menu2_1_panel_main_panel25_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel25_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel25_label2.Text = "label20";
            this.menu2_1_panel_main_panel25_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel25_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel25_label2_Click);
            // 
            // menu2_1_panel_main_panel24
            // 
            this.menu2_1_panel_main_panel24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel24.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel24.Controls.Add(this.menu2_1_panel_main_panel24_button_finish);
            this.menu2_1_panel_main_panel24.Controls.Add(this.menu2_1_panel_main_panel24_button_delete);
            this.menu2_1_panel_main_panel24.Controls.Add(this.menu2_1_panel_main_panel24_label1);
            this.menu2_1_panel_main_panel24.Controls.Add(this.menu2_1_panel_main_panel24_label2);
            this.menu2_1_panel_main_panel24.Location = new System.Drawing.Point(4, 828);
            this.menu2_1_panel_main_panel24.Name = "menu2_1_panel_main_panel24";
            this.menu2_1_panel_main_panel24.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel24.TabIndex = 26;
            this.menu2_1_panel_main_panel24.Click += new System.EventHandler(this.menu2_1_panel_main_panel24_Click);
            // 
            // menu2_1_panel_main_panel24_button_finish
            // 
            this.menu2_1_panel_main_panel24_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel24_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel24_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel24_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel24_button_finish.Name = "menu2_1_panel_main_panel24_button_finish";
            this.menu2_1_panel_main_panel24_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel24_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel24_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel24_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel24_button_finish_Click);
            // 
            // menu2_1_panel_main_panel24_button_delete
            // 
            this.menu2_1_panel_main_panel24_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel24_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel24_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel24_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel24_button_delete.Name = "menu2_1_panel_main_panel24_button_delete";
            this.menu2_1_panel_main_panel24_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel24_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel24_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel24_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel24_button_delete_Click);
            // 
            // menu2_1_panel_main_panel24_label1
            // 
            this.menu2_1_panel_main_panel24_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel24_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel24_label1.Name = "menu2_1_panel_main_panel24_label1";
            this.menu2_1_panel_main_panel24_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel24_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel24_label1.Text = "label19";
            this.menu2_1_panel_main_panel24_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel24_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel24_label1_Click);
            // 
            // menu2_1_panel_main_panel24_label2
            // 
            this.menu2_1_panel_main_panel24_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel24_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel24_label2.Name = "menu2_1_panel_main_panel24_label2";
            this.menu2_1_panel_main_panel24_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel24_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel24_label2.Text = "label20";
            this.menu2_1_panel_main_panel24_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel24_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel24_label2_Click);
            // 
            // menu2_1_panel_main_panel23
            // 
            this.menu2_1_panel_main_panel23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel23.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel23.Controls.Add(this.menu2_1_panel_main_panel23_button_finish);
            this.menu2_1_panel_main_panel23.Controls.Add(this.menu2_1_panel_main_panel23_button_delete);
            this.menu2_1_panel_main_panel23.Controls.Add(this.menu2_1_panel_main_panel23_label1);
            this.menu2_1_panel_main_panel23.Controls.Add(this.menu2_1_panel_main_panel23_label2);
            this.menu2_1_panel_main_panel23.Location = new System.Drawing.Point(4, 792);
            this.menu2_1_panel_main_panel23.Name = "menu2_1_panel_main_panel23";
            this.menu2_1_panel_main_panel23.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel23.TabIndex = 25;
            this.menu2_1_panel_main_panel23.Click += new System.EventHandler(this.menu2_1_panel_main_panel23_Click);
            // 
            // menu2_1_panel_main_panel23_button_finish
            // 
            this.menu2_1_panel_main_panel23_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel23_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel23_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel23_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel23_button_finish.Name = "menu2_1_panel_main_panel23_button_finish";
            this.menu2_1_panel_main_panel23_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel23_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel23_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel23_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel23_button_finish_Click);
            // 
            // menu2_1_panel_main_panel23_button_delete
            // 
            this.menu2_1_panel_main_panel23_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel23_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel23_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel23_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel23_button_delete.Name = "menu2_1_panel_main_panel23_button_delete";
            this.menu2_1_panel_main_panel23_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel23_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel23_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel23_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel23_button_delete_Click);
            // 
            // menu2_1_panel_main_panel23_label1
            // 
            this.menu2_1_panel_main_panel23_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel23_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel23_label1.Name = "menu2_1_panel_main_panel23_label1";
            this.menu2_1_panel_main_panel23_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel23_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel23_label1.Text = "label19";
            this.menu2_1_panel_main_panel23_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel23_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel23_label1_Click);
            // 
            // menu2_1_panel_main_panel23_label2
            // 
            this.menu2_1_panel_main_panel23_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel23_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel23_label2.Name = "menu2_1_panel_main_panel23_label2";
            this.menu2_1_panel_main_panel23_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel23_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel23_label2.Text = "label20";
            this.menu2_1_panel_main_panel23_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel23_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel23_label2_Click);
            // 
            // menu2_1_panel_main_panel22
            // 
            this.menu2_1_panel_main_panel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel22.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel22.Controls.Add(this.menu2_1_panel_main_panel22_button_finish);
            this.menu2_1_panel_main_panel22.Controls.Add(this.menu2_1_panel_main_panel22_button_delete);
            this.menu2_1_panel_main_panel22.Controls.Add(this.menu2_1_panel_main_panel22_label1);
            this.menu2_1_panel_main_panel22.Controls.Add(this.menu2_1_panel_main_panel22_label2);
            this.menu2_1_panel_main_panel22.Location = new System.Drawing.Point(4, 756);
            this.menu2_1_panel_main_panel22.Name = "menu2_1_panel_main_panel22";
            this.menu2_1_panel_main_panel22.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel22.TabIndex = 24;
            this.menu2_1_panel_main_panel22.Click += new System.EventHandler(this.menu2_1_panel_main_panel22_Click);
            // 
            // menu2_1_panel_main_panel22_button_finish
            // 
            this.menu2_1_panel_main_panel22_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel22_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel22_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel22_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel22_button_finish.Name = "menu2_1_panel_main_panel22_button_finish";
            this.menu2_1_panel_main_panel22_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel22_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel22_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel22_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel22_button_finish_Click);
            // 
            // menu2_1_panel_main_panel22_button_delete
            // 
            this.menu2_1_panel_main_panel22_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel22_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel22_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel22_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel22_button_delete.Name = "menu2_1_panel_main_panel22_button_delete";
            this.menu2_1_panel_main_panel22_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel22_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel22_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel22_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel22_button_delete_Click);
            // 
            // menu2_1_panel_main_panel22_label1
            // 
            this.menu2_1_panel_main_panel22_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel22_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel22_label1.Name = "menu2_1_panel_main_panel22_label1";
            this.menu2_1_panel_main_panel22_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel22_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel22_label1.Text = "label19";
            this.menu2_1_panel_main_panel22_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel22_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel22_label1_Click);
            // 
            // menu2_1_panel_main_panel22_label2
            // 
            this.menu2_1_panel_main_panel22_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel22_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel22_label2.Name = "menu2_1_panel_main_panel22_label2";
            this.menu2_1_panel_main_panel22_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel22_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel22_label2.Text = "label20";
            this.menu2_1_panel_main_panel22_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel22_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel22_label2_Click);
            // 
            // menu2_1_panel_main_panel21
            // 
            this.menu2_1_panel_main_panel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel21.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel21.Controls.Add(this.menu2_1_panel_main_panel21_button_finish);
            this.menu2_1_panel_main_panel21.Controls.Add(this.menu2_1_panel_main_panel21_button_delete);
            this.menu2_1_panel_main_panel21.Controls.Add(this.menu2_1_panel_main_panel21_label1);
            this.menu2_1_panel_main_panel21.Controls.Add(this.menu2_1_panel_main_panel21_label2);
            this.menu2_1_panel_main_panel21.Location = new System.Drawing.Point(4, 720);
            this.menu2_1_panel_main_panel21.Name = "menu2_1_panel_main_panel21";
            this.menu2_1_panel_main_panel21.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel21.TabIndex = 23;
            this.menu2_1_panel_main_panel21.Click += new System.EventHandler(this.menu2_1_panel_main_panel21_Click);
            // 
            // menu2_1_panel_main_panel21_button_finish
            // 
            this.menu2_1_panel_main_panel21_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel21_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel21_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel21_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel21_button_finish.Name = "menu2_1_panel_main_panel21_button_finish";
            this.menu2_1_panel_main_panel21_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel21_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel21_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel21_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel21_button_finish_Click);
            // 
            // menu2_1_panel_main_panel21_button_delete
            // 
            this.menu2_1_panel_main_panel21_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel21_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel21_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel21_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel21_button_delete.Name = "menu2_1_panel_main_panel21_button_delete";
            this.menu2_1_panel_main_panel21_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel21_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel21_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel21_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel21_button_delete_Click);
            // 
            // menu2_1_panel_main_panel21_label1
            // 
            this.menu2_1_panel_main_panel21_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel21_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel21_label1.Name = "menu2_1_panel_main_panel21_label1";
            this.menu2_1_panel_main_panel21_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel21_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel21_label1.Text = "label19";
            this.menu2_1_panel_main_panel21_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel21_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel21_label1_Click);
            // 
            // menu2_1_panel_main_panel21_label2
            // 
            this.menu2_1_panel_main_panel21_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel21_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel21_label2.Name = "menu2_1_panel_main_panel21_label2";
            this.menu2_1_panel_main_panel21_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel21_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel21_label2.Text = "label20";
            this.menu2_1_panel_main_panel21_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel21_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel21_label2_Click);
            // 
            // menu2_1_panel_main_panel20
            // 
            this.menu2_1_panel_main_panel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel20.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel20.Controls.Add(this.menu2_1_panel_main_panel20_button_finish);
            this.menu2_1_panel_main_panel20.Controls.Add(this.menu2_1_panel_main_panel20_button_delete);
            this.menu2_1_panel_main_panel20.Controls.Add(this.menu2_1_panel_main_panel20_label1);
            this.menu2_1_panel_main_panel20.Controls.Add(this.menu2_1_panel_main_panel20_label2);
            this.menu2_1_panel_main_panel20.Location = new System.Drawing.Point(4, 684);
            this.menu2_1_panel_main_panel20.Name = "menu2_1_panel_main_panel20";
            this.menu2_1_panel_main_panel20.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel20.TabIndex = 22;
            this.menu2_1_panel_main_panel20.Click += new System.EventHandler(this.menu2_1_panel_main_panel20_Click);
            // 
            // menu2_1_panel_main_panel20_button_finish
            // 
            this.menu2_1_panel_main_panel20_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel20_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel20_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel20_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel20_button_finish.Name = "menu2_1_panel_main_panel20_button_finish";
            this.menu2_1_panel_main_panel20_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel20_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel20_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel20_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel20_button_finish_Click);
            // 
            // menu2_1_panel_main_panel20_button_delete
            // 
            this.menu2_1_panel_main_panel20_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel20_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel20_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel20_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel20_button_delete.Name = "menu2_1_panel_main_panel20_button_delete";
            this.menu2_1_panel_main_panel20_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel20_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel20_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel20_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel20_button_delete_Click);
            // 
            // menu2_1_panel_main_panel20_label1
            // 
            this.menu2_1_panel_main_panel20_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel20_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel20_label1.Name = "menu2_1_panel_main_panel20_label1";
            this.menu2_1_panel_main_panel20_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel20_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel20_label1.Text = "label19";
            this.menu2_1_panel_main_panel20_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel20_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel20_label1_Click);
            // 
            // menu2_1_panel_main_panel20_label2
            // 
            this.menu2_1_panel_main_panel20_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel20_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel20_label2.Name = "menu2_1_panel_main_panel20_label2";
            this.menu2_1_panel_main_panel20_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel20_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel20_label2.Text = "label20";
            this.menu2_1_panel_main_panel20_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel20_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel20_label2_Click);
            // 
            // menu2_1_panel_main_panel19
            // 
            this.menu2_1_panel_main_panel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel19.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel19.Controls.Add(this.menu2_1_panel_main_panel19_button_finish);
            this.menu2_1_panel_main_panel19.Controls.Add(this.menu2_1_panel_main_panel19_button_delete);
            this.menu2_1_panel_main_panel19.Controls.Add(this.menu2_1_panel_main_panel19_label1);
            this.menu2_1_panel_main_panel19.Controls.Add(this.menu2_1_panel_main_panel19_label2);
            this.menu2_1_panel_main_panel19.Location = new System.Drawing.Point(4, 648);
            this.menu2_1_panel_main_panel19.Name = "menu2_1_panel_main_panel19";
            this.menu2_1_panel_main_panel19.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel19.TabIndex = 21;
            this.menu2_1_panel_main_panel19.Click += new System.EventHandler(this.menu2_1_panel_main_panel19_Click);
            // 
            // menu2_1_panel_main_panel19_button_finish
            // 
            this.menu2_1_panel_main_panel19_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel19_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel19_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel19_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel19_button_finish.Name = "menu2_1_panel_main_panel19_button_finish";
            this.menu2_1_panel_main_panel19_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel19_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel19_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel19_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel19_button_finish_Click);
            // 
            // menu2_1_panel_main_panel19_button_delete
            // 
            this.menu2_1_panel_main_panel19_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel19_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel19_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel19_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel19_button_delete.Name = "menu2_1_panel_main_panel19_button_delete";
            this.menu2_1_panel_main_panel19_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel19_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel19_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel19_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel19_button_delete_Click);
            // 
            // menu2_1_panel_main_panel19_label1
            // 
            this.menu2_1_panel_main_panel19_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel19_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel19_label1.Name = "menu2_1_panel_main_panel19_label1";
            this.menu2_1_panel_main_panel19_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel19_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel19_label1.Text = "label19";
            this.menu2_1_panel_main_panel19_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel19_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel19_label1_Click);
            // 
            // menu2_1_panel_main_panel19_label2
            // 
            this.menu2_1_panel_main_panel19_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel19_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel19_label2.Name = "menu2_1_panel_main_panel19_label2";
            this.menu2_1_panel_main_panel19_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel19_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel19_label2.Text = "label20";
            this.menu2_1_panel_main_panel19_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel19_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel19_label2_Click);
            // 
            // menu2_1_panel_main_panel18
            // 
            this.menu2_1_panel_main_panel18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel18.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel18.Controls.Add(this.menu2_1_panel_main_panel18_button_finish);
            this.menu2_1_panel_main_panel18.Controls.Add(this.menu2_1_panel_main_panel18_button_delete);
            this.menu2_1_panel_main_panel18.Controls.Add(this.menu2_1_panel_main_panel18_label1);
            this.menu2_1_panel_main_panel18.Controls.Add(this.menu2_1_panel_main_panel18_label2);
            this.menu2_1_panel_main_panel18.Location = new System.Drawing.Point(4, 612);
            this.menu2_1_panel_main_panel18.Name = "menu2_1_panel_main_panel18";
            this.menu2_1_panel_main_panel18.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel18.TabIndex = 20;
            this.menu2_1_panel_main_panel18.Click += new System.EventHandler(this.menu2_1_panel_main_panel18_Click);
            // 
            // menu2_1_panel_main_panel18_button_finish
            // 
            this.menu2_1_panel_main_panel18_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel18_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel18_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel18_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel18_button_finish.Name = "menu2_1_panel_main_panel18_button_finish";
            this.menu2_1_panel_main_panel18_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel18_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel18_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel18_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel18_button_finish_Click);
            // 
            // menu2_1_panel_main_panel18_button_delete
            // 
            this.menu2_1_panel_main_panel18_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel18_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel18_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel18_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel18_button_delete.Name = "menu2_1_panel_main_panel18_button_delete";
            this.menu2_1_panel_main_panel18_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel18_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel18_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel18_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel18_button_delete_Click);
            // 
            // menu2_1_panel_main_panel18_label1
            // 
            this.menu2_1_panel_main_panel18_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel18_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel18_label1.Name = "menu2_1_panel_main_panel18_label1";
            this.menu2_1_panel_main_panel18_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel18_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel18_label1.Text = "label19";
            this.menu2_1_panel_main_panel18_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel18_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel18_label1_Click);
            // 
            // menu2_1_panel_main_panel18_label2
            // 
            this.menu2_1_panel_main_panel18_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel18_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel18_label2.Name = "menu2_1_panel_main_panel18_label2";
            this.menu2_1_panel_main_panel18_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel18_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel18_label2.Text = "label20";
            this.menu2_1_panel_main_panel18_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel18_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel18_label2_Click);
            // 
            // menu2_1_panel_main_panel17
            // 
            this.menu2_1_panel_main_panel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel17.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel17.Controls.Add(this.menu2_1_panel_main_panel17_button_finish);
            this.menu2_1_panel_main_panel17.Controls.Add(this.menu2_1_panel_main_panel17_button_delete);
            this.menu2_1_panel_main_panel17.Controls.Add(this.menu2_1_panel_main_panel17_label1);
            this.menu2_1_panel_main_panel17.Controls.Add(this.menu2_1_panel_main_panel17_label2);
            this.menu2_1_panel_main_panel17.Location = new System.Drawing.Point(4, 576);
            this.menu2_1_panel_main_panel17.Name = "menu2_1_panel_main_panel17";
            this.menu2_1_panel_main_panel17.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel17.TabIndex = 19;
            this.menu2_1_panel_main_panel17.Click += new System.EventHandler(this.menu2_1_panel_main_panel17_Click);
            // 
            // menu2_1_panel_main_panel17_button_finish
            // 
            this.menu2_1_panel_main_panel17_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel17_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel17_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel17_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel17_button_finish.Name = "menu2_1_panel_main_panel17_button_finish";
            this.menu2_1_panel_main_panel17_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel17_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel17_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel17_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel17_button_finish_Click);
            // 
            // menu2_1_panel_main_panel17_button_delete
            // 
            this.menu2_1_panel_main_panel17_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel17_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel17_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel17_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel17_button_delete.Name = "menu2_1_panel_main_panel17_button_delete";
            this.menu2_1_panel_main_panel17_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel17_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel17_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel17_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel17_button_delete_Click);
            // 
            // menu2_1_panel_main_panel17_label1
            // 
            this.menu2_1_panel_main_panel17_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel17_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel17_label1.Name = "menu2_1_panel_main_panel17_label1";
            this.menu2_1_panel_main_panel17_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel17_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel17_label1.Text = "label19";
            this.menu2_1_panel_main_panel17_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel17_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel17_label1_Click);
            // 
            // menu2_1_panel_main_panel17_label2
            // 
            this.menu2_1_panel_main_panel17_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel17_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel17_label2.Name = "menu2_1_panel_main_panel17_label2";
            this.menu2_1_panel_main_panel17_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel17_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel17_label2.Text = "label20";
            this.menu2_1_panel_main_panel17_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel17_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel17_label2_Click);
            // 
            // menu2_1_panel_main_panel16
            // 
            this.menu2_1_panel_main_panel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel16.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel16.Controls.Add(this.menu2_1_panel_main_panel16_button_finish);
            this.menu2_1_panel_main_panel16.Controls.Add(this.menu2_1_panel_main_panel16_button_delete);
            this.menu2_1_panel_main_panel16.Controls.Add(this.menu2_1_panel_main_panel16_label1);
            this.menu2_1_panel_main_panel16.Controls.Add(this.menu2_1_panel_main_panel16_label2);
            this.menu2_1_panel_main_panel16.Location = new System.Drawing.Point(4, 540);
            this.menu2_1_panel_main_panel16.Name = "menu2_1_panel_main_panel16";
            this.menu2_1_panel_main_panel16.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel16.TabIndex = 18;
            this.menu2_1_panel_main_panel16.Click += new System.EventHandler(this.menu2_1_panel_main_panel16_Click);
            // 
            // menu2_1_panel_main_panel16_button_finish
            // 
            this.menu2_1_panel_main_panel16_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel16_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel16_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel16_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel16_button_finish.Name = "menu2_1_panel_main_panel16_button_finish";
            this.menu2_1_panel_main_panel16_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel16_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel16_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel16_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel16_button_finish_Click);
            // 
            // menu2_1_panel_main_panel16_button_delete
            // 
            this.menu2_1_panel_main_panel16_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel16_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel16_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel16_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel16_button_delete.Name = "menu2_1_panel_main_panel16_button_delete";
            this.menu2_1_panel_main_panel16_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel16_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel16_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel16_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel16_button_delete_Click);
            // 
            // menu2_1_panel_main_panel16_label1
            // 
            this.menu2_1_panel_main_panel16_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel16_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel16_label1.Name = "menu2_1_panel_main_panel16_label1";
            this.menu2_1_panel_main_panel16_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel16_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel16_label1.Text = "label19";
            this.menu2_1_panel_main_panel16_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel16_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel16_label1_Click);
            // 
            // menu2_1_panel_main_panel16_label2
            // 
            this.menu2_1_panel_main_panel16_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel16_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel16_label2.Name = "menu2_1_panel_main_panel16_label2";
            this.menu2_1_panel_main_panel16_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel16_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel16_label2.Text = "label20";
            this.menu2_1_panel_main_panel16_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel16_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel16_label2_Click);
            // 
            // menu2_1_panel_main_panel15
            // 
            this.menu2_1_panel_main_panel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel15.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel15.Controls.Add(this.menu2_1_panel_main_panel15_button_finish);
            this.menu2_1_panel_main_panel15.Controls.Add(this.menu2_1_panel_main_panel15_button_delete);
            this.menu2_1_panel_main_panel15.Controls.Add(this.menu2_1_panel_main_panel15_label1);
            this.menu2_1_panel_main_panel15.Controls.Add(this.menu2_1_panel_main_panel15_label2);
            this.menu2_1_panel_main_panel15.Location = new System.Drawing.Point(4, 504);
            this.menu2_1_panel_main_panel15.Name = "menu2_1_panel_main_panel15";
            this.menu2_1_panel_main_panel15.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel15.TabIndex = 17;
            this.menu2_1_panel_main_panel15.Click += new System.EventHandler(this.menu2_1_panel_main_panel15_Click);
            // 
            // menu2_1_panel_main_panel15_button_finish
            // 
            this.menu2_1_panel_main_panel15_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel15_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel15_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel15_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel15_button_finish.Name = "menu2_1_panel_main_panel15_button_finish";
            this.menu2_1_panel_main_panel15_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel15_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel15_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel15_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel15_button_finish_Click);
            // 
            // menu2_1_panel_main_panel15_button_delete
            // 
            this.menu2_1_panel_main_panel15_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel15_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel15_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel15_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel15_button_delete.Name = "menu2_1_panel_main_panel15_button_delete";
            this.menu2_1_panel_main_panel15_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel15_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel15_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel15_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel15_button_delete_Click);
            // 
            // menu2_1_panel_main_panel15_label1
            // 
            this.menu2_1_panel_main_panel15_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel15_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel15_label1.Name = "menu2_1_panel_main_panel15_label1";
            this.menu2_1_panel_main_panel15_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel15_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel15_label1.Text = "label19";
            this.menu2_1_panel_main_panel15_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel15_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel15_label1_Click);
            // 
            // menu2_1_panel_main_panel15_label2
            // 
            this.menu2_1_panel_main_panel15_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel15_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel15_label2.Name = "menu2_1_panel_main_panel15_label2";
            this.menu2_1_panel_main_panel15_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel15_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel15_label2.Text = "label20";
            this.menu2_1_panel_main_panel15_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel15_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel15_label2_Click);
            // 
            // menu2_1_panel_main_panel14
            // 
            this.menu2_1_panel_main_panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel14.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel14.Controls.Add(this.menu2_1_panel_main_panel14_button_finish);
            this.menu2_1_panel_main_panel14.Controls.Add(this.menu2_1_panel_main_panel14_button_delete);
            this.menu2_1_panel_main_panel14.Controls.Add(this.menu2_1_panel_main_panel14_label1);
            this.menu2_1_panel_main_panel14.Controls.Add(this.menu2_1_panel_main_panel14_label2);
            this.menu2_1_panel_main_panel14.Location = new System.Drawing.Point(4, 468);
            this.menu2_1_panel_main_panel14.Name = "menu2_1_panel_main_panel14";
            this.menu2_1_panel_main_panel14.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel14.TabIndex = 16;
            this.menu2_1_panel_main_panel14.Click += new System.EventHandler(this.menu2_1_panel_main_panel14_Click);
            // 
            // menu2_1_panel_main_panel14_button_finish
            // 
            this.menu2_1_panel_main_panel14_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel14_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel14_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel14_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel14_button_finish.Name = "menu2_1_panel_main_panel14_button_finish";
            this.menu2_1_panel_main_panel14_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel14_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel14_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel14_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel14_button_finish_Click);
            // 
            // menu2_1_panel_main_panel14_button_delete
            // 
            this.menu2_1_panel_main_panel14_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel14_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel14_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel14_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel14_button_delete.Name = "menu2_1_panel_main_panel14_button_delete";
            this.menu2_1_panel_main_panel14_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel14_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel14_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel14_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel14_button_delete_Click);
            // 
            // menu2_1_panel_main_panel14_label1
            // 
            this.menu2_1_panel_main_panel14_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel14_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel14_label1.Name = "menu2_1_panel_main_panel14_label1";
            this.menu2_1_panel_main_panel14_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel14_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel14_label1.Text = "label19";
            this.menu2_1_panel_main_panel14_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel14_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel14_label1_Click);
            // 
            // menu2_1_panel_main_panel14_label2
            // 
            this.menu2_1_panel_main_panel14_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel14_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel14_label2.Name = "menu2_1_panel_main_panel14_label2";
            this.menu2_1_panel_main_panel14_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel14_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel14_label2.Text = "label20";
            this.menu2_1_panel_main_panel14_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel14_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel14_label2_Click);
            // 
            // menu2_1_panel_main_panel13
            // 
            this.menu2_1_panel_main_panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel13.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel13.Controls.Add(this.menu2_1_panel_main_panel13_button_finish);
            this.menu2_1_panel_main_panel13.Controls.Add(this.menu2_1_panel_main_panel13_button_delete);
            this.menu2_1_panel_main_panel13.Controls.Add(this.menu2_1_panel_main_panel13_label1);
            this.menu2_1_panel_main_panel13.Controls.Add(this.menu2_1_panel_main_panel13_label2);
            this.menu2_1_panel_main_panel13.Location = new System.Drawing.Point(4, 432);
            this.menu2_1_panel_main_panel13.Name = "menu2_1_panel_main_panel13";
            this.menu2_1_panel_main_panel13.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel13.TabIndex = 15;
            this.menu2_1_panel_main_panel13.Click += new System.EventHandler(this.menu2_1_panel_main_panel13_Click);
            // 
            // menu2_1_panel_main_panel13_button_finish
            // 
            this.menu2_1_panel_main_panel13_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel13_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel13_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel13_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel13_button_finish.Name = "menu2_1_panel_main_panel13_button_finish";
            this.menu2_1_panel_main_panel13_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel13_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel13_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel13_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel13_button_finish_Click);
            // 
            // menu2_1_panel_main_panel13_button_delete
            // 
            this.menu2_1_panel_main_panel13_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel13_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel13_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel13_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel13_button_delete.Name = "menu2_1_panel_main_panel13_button_delete";
            this.menu2_1_panel_main_panel13_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel13_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel13_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel13_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel13_button_delete_Click);
            // 
            // menu2_1_panel_main_panel13_label1
            // 
            this.menu2_1_panel_main_panel13_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel13_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel13_label1.Name = "menu2_1_panel_main_panel13_label1";
            this.menu2_1_panel_main_panel13_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel13_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel13_label1.Text = "label19";
            this.menu2_1_panel_main_panel13_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel13_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel13_label1_Click);
            // 
            // menu2_1_panel_main_panel13_label2
            // 
            this.menu2_1_panel_main_panel13_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel13_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel13_label2.Name = "menu2_1_panel_main_panel13_label2";
            this.menu2_1_panel_main_panel13_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel13_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel13_label2.Text = "label20";
            this.menu2_1_panel_main_panel13_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel13_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel13_label2_Click);
            // 
            // menu2_1_panel_main_panel12
            // 
            this.menu2_1_panel_main_panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel12.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel12.Controls.Add(this.menu2_1_panel_main_panel12_button_finish);
            this.menu2_1_panel_main_panel12.Controls.Add(this.menu2_1_panel_main_panel12_button_delete);
            this.menu2_1_panel_main_panel12.Controls.Add(this.menu2_1_panel_main_panel12_label1);
            this.menu2_1_panel_main_panel12.Controls.Add(this.menu2_1_panel_main_panel12_label2);
            this.menu2_1_panel_main_panel12.Location = new System.Drawing.Point(4, 396);
            this.menu2_1_panel_main_panel12.Name = "menu2_1_panel_main_panel12";
            this.menu2_1_panel_main_panel12.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel12.TabIndex = 14;
            this.menu2_1_panel_main_panel12.Click += new System.EventHandler(this.menu2_1_panel_main_panel12_Click);
            // 
            // menu2_1_panel_main_panel12_button_finish
            // 
            this.menu2_1_panel_main_panel12_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel12_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel12_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel12_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel12_button_finish.Name = "menu2_1_panel_main_panel12_button_finish";
            this.menu2_1_panel_main_panel12_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel12_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel12_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel12_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel12_button_finish_Click);
            // 
            // menu2_1_panel_main_panel12_button_delete
            // 
            this.menu2_1_panel_main_panel12_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel12_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel12_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel12_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel12_button_delete.Name = "menu2_1_panel_main_panel12_button_delete";
            this.menu2_1_panel_main_panel12_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel12_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel12_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel12_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel12_button_delete_Click);
            // 
            // menu2_1_panel_main_panel12_label1
            // 
            this.menu2_1_panel_main_panel12_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel12_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel12_label1.Name = "menu2_1_panel_main_panel12_label1";
            this.menu2_1_panel_main_panel12_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel12_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel12_label1.Text = "label19";
            this.menu2_1_panel_main_panel12_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel12_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel12_label1_Click);
            // 
            // menu2_1_panel_main_panel12_label2
            // 
            this.menu2_1_panel_main_panel12_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel12_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel12_label2.Name = "menu2_1_panel_main_panel12_label2";
            this.menu2_1_panel_main_panel12_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel12_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel12_label2.Text = "label20";
            this.menu2_1_panel_main_panel12_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel12_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel12_label2_Click);
            // 
            // menu2_1_panel_main_panel11
            // 
            this.menu2_1_panel_main_panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel11.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel11.Controls.Add(this.menu2_1_panel_main_panel11_button_finish);
            this.menu2_1_panel_main_panel11.Controls.Add(this.menu2_1_panel_main_panel11_button_delete);
            this.menu2_1_panel_main_panel11.Controls.Add(this.menu2_1_panel_main_panel11_label1);
            this.menu2_1_panel_main_panel11.Controls.Add(this.menu2_1_panel_main_panel11_label2);
            this.menu2_1_panel_main_panel11.Location = new System.Drawing.Point(4, 360);
            this.menu2_1_panel_main_panel11.Name = "menu2_1_panel_main_panel11";
            this.menu2_1_panel_main_panel11.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel11.TabIndex = 13;
            this.menu2_1_panel_main_panel11.Click += new System.EventHandler(this.menu2_1_panel_main_panel11_Click);
            // 
            // menu2_1_panel_main_panel11_button_finish
            // 
            this.menu2_1_panel_main_panel11_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel11_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel11_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel11_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel11_button_finish.Name = "menu2_1_panel_main_panel11_button_finish";
            this.menu2_1_panel_main_panel11_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel11_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel11_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel11_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel11_button_finish_Click);
            // 
            // menu2_1_panel_main_panel11_button_delete
            // 
            this.menu2_1_panel_main_panel11_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel11_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel11_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel11_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel11_button_delete.Name = "menu2_1_panel_main_panel11_button_delete";
            this.menu2_1_panel_main_panel11_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel11_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel11_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel11_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel11_button_delete_Click);
            // 
            // menu2_1_panel_main_panel11_label1
            // 
            this.menu2_1_panel_main_panel11_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel11_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel11_label1.Name = "menu2_1_panel_main_panel11_label1";
            this.menu2_1_panel_main_panel11_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel11_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel11_label1.Text = "label19";
            this.menu2_1_panel_main_panel11_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel11_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel11_label1_Click);
            // 
            // menu2_1_panel_main_panel11_label2
            // 
            this.menu2_1_panel_main_panel11_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel11_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel11_label2.Name = "menu2_1_panel_main_panel11_label2";
            this.menu2_1_panel_main_panel11_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel11_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel11_label2.Text = "label20";
            this.menu2_1_panel_main_panel11_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel11_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel11_label2_Click);
            // 
            // menu2_1_panel_main_panel10
            // 
            this.menu2_1_panel_main_panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel10.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel10.Controls.Add(this.menu2_1_panel_main_panel10_button_finish);
            this.menu2_1_panel_main_panel10.Controls.Add(this.menu2_1_panel_main_panel10_button_delete);
            this.menu2_1_panel_main_panel10.Controls.Add(this.menu2_1_panel_main_panel10_label1);
            this.menu2_1_panel_main_panel10.Controls.Add(this.menu2_1_panel_main_panel10_label2);
            this.menu2_1_panel_main_panel10.Location = new System.Drawing.Point(4, 324);
            this.menu2_1_panel_main_panel10.Name = "menu2_1_panel_main_panel10";
            this.menu2_1_panel_main_panel10.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel10.TabIndex = 12;
            this.menu2_1_panel_main_panel10.Click += new System.EventHandler(this.menu2_1_panel_main_panel10_Click);
            // 
            // menu2_1_panel_main_panel10_button_finish
            // 
            this.menu2_1_panel_main_panel10_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel10_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel10_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel10_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel10_button_finish.Name = "menu2_1_panel_main_panel10_button_finish";
            this.menu2_1_panel_main_panel10_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel10_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel10_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel10_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel10_button_finish_Click);
            // 
            // menu2_1_panel_main_panel10_button_delete
            // 
            this.menu2_1_panel_main_panel10_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel10_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel10_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel10_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel10_button_delete.Name = "menu2_1_panel_main_panel10_button_delete";
            this.menu2_1_panel_main_panel10_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel10_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel10_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel10_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel10_button_delete_Click);
            // 
            // menu2_1_panel_main_panel10_label1
            // 
            this.menu2_1_panel_main_panel10_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel10_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel10_label1.Name = "menu2_1_panel_main_panel10_label1";
            this.menu2_1_panel_main_panel10_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel10_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel10_label1.Text = "label17";
            this.menu2_1_panel_main_panel10_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel10_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel10_label1_Click);
            // 
            // menu2_1_panel_main_panel10_label2
            // 
            this.menu2_1_panel_main_panel10_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel10_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel10_label2.Name = "menu2_1_panel_main_panel10_label2";
            this.menu2_1_panel_main_panel10_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel10_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel10_label2.Text = "label18";
            this.menu2_1_panel_main_panel10_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel10_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel10_label2_Click);
            // 
            // menu2_1_panel_main_panel9
            // 
            this.menu2_1_panel_main_panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel9.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel9.Controls.Add(this.menu2_1_panel_main_panel9_button_finish);
            this.menu2_1_panel_main_panel9.Controls.Add(this.menu2_1_panel_main_panel9_button_delete);
            this.menu2_1_panel_main_panel9.Controls.Add(this.menu2_1_panel_main_panel9_label1);
            this.menu2_1_panel_main_panel9.Controls.Add(this.menu2_1_panel_main_panel9_label2);
            this.menu2_1_panel_main_panel9.Location = new System.Drawing.Point(4, 288);
            this.menu2_1_panel_main_panel9.Name = "menu2_1_panel_main_panel9";
            this.menu2_1_panel_main_panel9.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel9.TabIndex = 11;
            this.menu2_1_panel_main_panel9.Click += new System.EventHandler(this.menu2_1_panel_main_panel9_Click);
            // 
            // menu2_1_panel_main_panel9_button_finish
            // 
            this.menu2_1_panel_main_panel9_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel9_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel9_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel9_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel9_button_finish.Name = "menu2_1_panel_main_panel9_button_finish";
            this.menu2_1_panel_main_panel9_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel9_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel9_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel9_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel9_button_finish_Click);
            // 
            // menu2_1_panel_main_panel9_button_delete
            // 
            this.menu2_1_panel_main_panel9_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel9_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel9_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel9_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel9_button_delete.Name = "menu2_1_panel_main_panel9_button_delete";
            this.menu2_1_panel_main_panel9_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel9_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel9_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel9_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel9_button_delete_Click);
            // 
            // menu2_1_panel_main_panel9_label1
            // 
            this.menu2_1_panel_main_panel9_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel9_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel9_label1.Name = "menu2_1_panel_main_panel9_label1";
            this.menu2_1_panel_main_panel9_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel9_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel9_label1.Text = "label15";
            this.menu2_1_panel_main_panel9_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel9_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel9_label1_Click);
            // 
            // menu2_1_panel_main_panel9_label2
            // 
            this.menu2_1_panel_main_panel9_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel9_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel9_label2.Name = "menu2_1_panel_main_panel9_label2";
            this.menu2_1_panel_main_panel9_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel9_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel9_label2.Text = "label16";
            this.menu2_1_panel_main_panel9_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel9_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel9_label2_Click);
            // 
            // menu2_1_panel_main_panel8
            // 
            this.menu2_1_panel_main_panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel8.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel8.Controls.Add(this.menu2_1_panel_main_panel8_button_finish);
            this.menu2_1_panel_main_panel8.Controls.Add(this.menu2_1_panel_main_panel8_button_delete);
            this.menu2_1_panel_main_panel8.Controls.Add(this.menu2_1_panel_main_panel8_label1);
            this.menu2_1_panel_main_panel8.Controls.Add(this.menu2_1_panel_main_panel8_label2);
            this.menu2_1_panel_main_panel8.Location = new System.Drawing.Point(4, 252);
            this.menu2_1_panel_main_panel8.Name = "menu2_1_panel_main_panel8";
            this.menu2_1_panel_main_panel8.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel8.TabIndex = 10;
            this.menu2_1_panel_main_panel8.Click += new System.EventHandler(this.menu2_1_panel_main_panel8_Click);
            // 
            // menu2_1_panel_main_panel8_button_finish
            // 
            this.menu2_1_panel_main_panel8_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel8_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel8_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel8_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel8_button_finish.Name = "menu2_1_panel_main_panel8_button_finish";
            this.menu2_1_panel_main_panel8_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel8_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel8_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel8_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel8_button_finish_Click);
            // 
            // menu2_1_panel_main_panel8_button_delete
            // 
            this.menu2_1_panel_main_panel8_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel8_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel8_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel8_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel8_button_delete.Name = "menu2_1_panel_main_panel8_button_delete";
            this.menu2_1_panel_main_panel8_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel8_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel8_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel8_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel8_button_delete_Click);
            // 
            // menu2_1_panel_main_panel8_label1
            // 
            this.menu2_1_panel_main_panel8_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel8_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel8_label1.Name = "menu2_1_panel_main_panel8_label1";
            this.menu2_1_panel_main_panel8_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel8_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel8_label1.Text = "label13";
            this.menu2_1_panel_main_panel8_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel8_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel8_label1_Click);
            // 
            // menu2_1_panel_main_panel8_label2
            // 
            this.menu2_1_panel_main_panel8_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel8_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel8_label2.Name = "menu2_1_panel_main_panel8_label2";
            this.menu2_1_panel_main_panel8_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel8_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel8_label2.Text = "label14";
            this.menu2_1_panel_main_panel8_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel8_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel8_label2_Click);
            // 
            // menu2_1_panel_main_panel7
            // 
            this.menu2_1_panel_main_panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel7.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel7.Controls.Add(this.menu2_1_panel_main_panel7_button_finish);
            this.menu2_1_panel_main_panel7.Controls.Add(this.menu2_1_panel_main_panel7_button_delete);
            this.menu2_1_panel_main_panel7.Controls.Add(this.menu2_1_panel_main_panel7_label1);
            this.menu2_1_panel_main_panel7.Controls.Add(this.menu2_1_panel_main_panel7_label2);
            this.menu2_1_panel_main_panel7.Location = new System.Drawing.Point(4, 216);
            this.menu2_1_panel_main_panel7.Name = "menu2_1_panel_main_panel7";
            this.menu2_1_panel_main_panel7.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel7.TabIndex = 9;
            this.menu2_1_panel_main_panel7.Click += new System.EventHandler(this.menu2_1_panel_main_panel7_Click);
            // 
            // menu2_1_panel_main_panel7_button_finish
            // 
            this.menu2_1_panel_main_panel7_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel7_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel7_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel7_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel7_button_finish.Name = "menu2_1_panel_main_panel7_button_finish";
            this.menu2_1_panel_main_panel7_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel7_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel7_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel7_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel7_button_finish_Click);
            // 
            // menu2_1_panel_main_panel7_button_delete
            // 
            this.menu2_1_panel_main_panel7_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel7_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel7_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel7_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel7_button_delete.Name = "menu2_1_panel_main_panel7_button_delete";
            this.menu2_1_panel_main_panel7_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel7_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel7_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel7_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel7_button_delete_Click);
            // 
            // menu2_1_panel_main_panel7_label1
            // 
            this.menu2_1_panel_main_panel7_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel7_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel7_label1.Name = "menu2_1_panel_main_panel7_label1";
            this.menu2_1_panel_main_panel7_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel7_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel7_label1.Text = "label11";
            this.menu2_1_panel_main_panel7_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel7_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel7_label1_Click);
            // 
            // menu2_1_panel_main_panel7_label2
            // 
            this.menu2_1_panel_main_panel7_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel7_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel7_label2.Name = "menu2_1_panel_main_panel7_label2";
            this.menu2_1_panel_main_panel7_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel7_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel7_label2.Text = "label12";
            this.menu2_1_panel_main_panel7_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel7_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel7_label2_Click);
            // 
            // menu2_1_panel_main_panel6
            // 
            this.menu2_1_panel_main_panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel6.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel6.Controls.Add(this.menu2_1_panel_main_panel6_button_finish);
            this.menu2_1_panel_main_panel6.Controls.Add(this.menu2_1_panel_main_panel6_button_delete);
            this.menu2_1_panel_main_panel6.Controls.Add(this.menu2_1_panel_main_panel6_label1);
            this.menu2_1_panel_main_panel6.Controls.Add(this.menu2_1_panel_main_panel6_label2);
            this.menu2_1_panel_main_panel6.Location = new System.Drawing.Point(4, 180);
            this.menu2_1_panel_main_panel6.Name = "menu2_1_panel_main_panel6";
            this.menu2_1_panel_main_panel6.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel6.TabIndex = 8;
            this.menu2_1_panel_main_panel6.Click += new System.EventHandler(this.menu2_1_panel_main_panel6_Click);
            // 
            // menu2_1_panel_main_panel6_button_finish
            // 
            this.menu2_1_panel_main_panel6_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel6_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel6_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel6_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel6_button_finish.Name = "menu2_1_panel_main_panel6_button_finish";
            this.menu2_1_panel_main_panel6_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel6_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel6_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel6_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel6_button_finish_Click);
            // 
            // menu2_1_panel_main_panel6_button_delete
            // 
            this.menu2_1_panel_main_panel6_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel6_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel6_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel6_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel6_button_delete.Name = "menu2_1_panel_main_panel6_button_delete";
            this.menu2_1_panel_main_panel6_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel6_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel6_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel6_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel6_button_delete_Click);
            // 
            // menu2_1_panel_main_panel6_label1
            // 
            this.menu2_1_panel_main_panel6_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel6_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel6_label1.Name = "menu2_1_panel_main_panel6_label1";
            this.menu2_1_panel_main_panel6_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel6_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel6_label1.Text = "label9";
            this.menu2_1_panel_main_panel6_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel6_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel6_label1_Click);
            // 
            // menu2_1_panel_main_panel6_label2
            // 
            this.menu2_1_panel_main_panel6_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel6_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel6_label2.Name = "menu2_1_panel_main_panel6_label2";
            this.menu2_1_panel_main_panel6_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel6_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel6_label2.Text = "label10";
            this.menu2_1_panel_main_panel6_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel6_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel6_label2_Click);
            // 
            // menu2_1_panel_main_panel5
            // 
            this.menu2_1_panel_main_panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel5.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel5.Controls.Add(this.menu2_1_panel_main_panel5_button_finish);
            this.menu2_1_panel_main_panel5.Controls.Add(this.menu2_1_panel_main_panel5_button_delete);
            this.menu2_1_panel_main_panel5.Controls.Add(this.menu2_1_panel_main_panel5_label1);
            this.menu2_1_panel_main_panel5.Controls.Add(this.menu2_1_panel_main_panel5_label2);
            this.menu2_1_panel_main_panel5.Location = new System.Drawing.Point(4, 144);
            this.menu2_1_panel_main_panel5.Name = "menu2_1_panel_main_panel5";
            this.menu2_1_panel_main_panel5.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel5.TabIndex = 7;
            this.menu2_1_panel_main_panel5.Click += new System.EventHandler(this.menu2_1_panel_main_panel5_Click);
            // 
            // menu2_1_panel_main_panel5_button_finish
            // 
            this.menu2_1_panel_main_panel5_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel5_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel5_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel5_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel5_button_finish.Name = "menu2_1_panel_main_panel5_button_finish";
            this.menu2_1_panel_main_panel5_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel5_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel5_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel5_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel5_button_finish_Click);
            // 
            // menu2_1_panel_main_panel5_button_delete
            // 
            this.menu2_1_panel_main_panel5_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel5_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel5_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel5_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel5_button_delete.Name = "menu2_1_panel_main_panel5_button_delete";
            this.menu2_1_panel_main_panel5_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel5_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel5_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel5_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel5_button_delete_Click);
            // 
            // menu2_1_panel_main_panel5_label1
            // 
            this.menu2_1_panel_main_panel5_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel5_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel5_label1.Name = "menu2_1_panel_main_panel5_label1";
            this.menu2_1_panel_main_panel5_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel5_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel5_label1.Text = "label7";
            this.menu2_1_panel_main_panel5_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel5_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel5_label1_Click);
            // 
            // menu2_1_panel_main_panel5_label2
            // 
            this.menu2_1_panel_main_panel5_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel5_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel5_label2.Name = "menu2_1_panel_main_panel5_label2";
            this.menu2_1_panel_main_panel5_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel5_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel5_label2.Text = "label8";
            this.menu2_1_panel_main_panel5_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel5_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel5_label2_Click);
            // 
            // menu2_1_panel_main_panel4
            // 
            this.menu2_1_panel_main_panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel4.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel4.Controls.Add(this.menu2_1_panel_main_panel4_button_finish);
            this.menu2_1_panel_main_panel4.Controls.Add(this.menu2_1_panel_main_panel4_button_delete);
            this.menu2_1_panel_main_panel4.Controls.Add(this.menu2_1_panel_main_panel4_label1);
            this.menu2_1_panel_main_panel4.Controls.Add(this.menu2_1_panel_main_panel4_label2);
            this.menu2_1_panel_main_panel4.Location = new System.Drawing.Point(4, 108);
            this.menu2_1_panel_main_panel4.Name = "menu2_1_panel_main_panel4";
            this.menu2_1_panel_main_panel4.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel4.TabIndex = 6;
            this.menu2_1_panel_main_panel4.Click += new System.EventHandler(this.menu2_1_panel_main_panel4_Click);
            // 
            // menu2_1_panel_main_panel4_button_finish
            // 
            this.menu2_1_panel_main_panel4_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel4_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel4_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel4_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel4_button_finish.Name = "menu2_1_panel_main_panel4_button_finish";
            this.menu2_1_panel_main_panel4_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel4_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel4_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel4_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel4_button_finish_Click);
            // 
            // menu2_1_panel_main_panel4_button_delete
            // 
            this.menu2_1_panel_main_panel4_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel4_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel4_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel4_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel4_button_delete.Name = "menu2_1_panel_main_panel4_button_delete";
            this.menu2_1_panel_main_panel4_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel4_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel4_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel4_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel4_button_delete_Click);
            // 
            // menu2_1_panel_main_panel4_label1
            // 
            this.menu2_1_panel_main_panel4_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel4_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel4_label1.Name = "menu2_1_panel_main_panel4_label1";
            this.menu2_1_panel_main_panel4_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel4_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel4_label1.Text = "label5";
            this.menu2_1_panel_main_panel4_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel4_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel4_label1_Click);
            // 
            // menu2_1_panel_main_panel4_label2
            // 
            this.menu2_1_panel_main_panel4_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel4_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel4_label2.Name = "menu2_1_panel_main_panel4_label2";
            this.menu2_1_panel_main_panel4_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel4_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel4_label2.Text = "label6";
            this.menu2_1_panel_main_panel4_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel4_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel4_label2_Click);
            // 
            // menu2_1_panel_main_panel3
            // 
            this.menu2_1_panel_main_panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel3.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel3.Controls.Add(this.menu2_1_panel_main_panel3_button_finish);
            this.menu2_1_panel_main_panel3.Controls.Add(this.menu2_1_panel_main_panel3_button_delete);
            this.menu2_1_panel_main_panel3.Controls.Add(this.menu2_1_panel_main_panel3_label1);
            this.menu2_1_panel_main_panel3.Controls.Add(this.menu2_1_panel_main_panel3_label2);
            this.menu2_1_panel_main_panel3.Location = new System.Drawing.Point(4, 72);
            this.menu2_1_panel_main_panel3.Name = "menu2_1_panel_main_panel3";
            this.menu2_1_panel_main_panel3.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel3.TabIndex = 5;
            this.menu2_1_panel_main_panel3.Click += new System.EventHandler(this.menu2_1_panel_main_panel3_Click);
            // 
            // menu2_1_panel_main_panel3_button_finish
            // 
            this.menu2_1_panel_main_panel3_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel3_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel3_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel3_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel3_button_finish.Name = "menu2_1_panel_main_panel3_button_finish";
            this.menu2_1_panel_main_panel3_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel3_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel3_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel3_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel3_button_finish_Click);
            // 
            // menu2_1_panel_main_panel3_button_delete
            // 
            this.menu2_1_panel_main_panel3_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel3_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel3_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel3_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel3_button_delete.Name = "menu2_1_panel_main_panel3_button_delete";
            this.menu2_1_panel_main_panel3_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel3_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel3_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel3_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel3_button_delete_Click);
            // 
            // menu2_1_panel_main_panel3_label1
            // 
            this.menu2_1_panel_main_panel3_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel3_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel3_label1.Name = "menu2_1_panel_main_panel3_label1";
            this.menu2_1_panel_main_panel3_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel3_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel3_label1.Text = "label3";
            this.menu2_1_panel_main_panel3_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel3_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel3_label1_Click);
            // 
            // menu2_1_panel_main_panel3_label2
            // 
            this.menu2_1_panel_main_panel3_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel3_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel3_label2.Name = "menu2_1_panel_main_panel3_label2";
            this.menu2_1_panel_main_panel3_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel3_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel3_label2.Text = "label4";
            this.menu2_1_panel_main_panel3_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel3_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel3_label2_Click);
            // 
            // menu2_1_panel_main_panel2
            // 
            this.menu2_1_panel_main_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel2.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel2.Controls.Add(this.menu2_1_panel_main_panel2_button_finish);
            this.menu2_1_panel_main_panel2.Controls.Add(this.menu2_1_panel_main_panel2_button_delete);
            this.menu2_1_panel_main_panel2.Controls.Add(this.menu2_1_panel_main_panel2_label1);
            this.menu2_1_panel_main_panel2.Controls.Add(this.menu2_1_panel_main_panel2_label2);
            this.menu2_1_panel_main_panel2.Location = new System.Drawing.Point(4, 36);
            this.menu2_1_panel_main_panel2.Name = "menu2_1_panel_main_panel2";
            this.menu2_1_panel_main_panel2.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel2.TabIndex = 4;
            this.menu2_1_panel_main_panel2.Click += new System.EventHandler(this.menu2_1_panel_main_panel2_Click);
            // 
            // menu2_1_panel_main_panel2_button_finish
            // 
            this.menu2_1_panel_main_panel2_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel2_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel2_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel2_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel2_button_finish.Name = "menu2_1_panel_main_panel2_button_finish";
            this.menu2_1_panel_main_panel2_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel2_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel2_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel2_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel2_button_finish_Click);
            // 
            // menu2_1_panel_main_panel2_button_delete
            // 
            this.menu2_1_panel_main_panel2_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel2_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel2_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel2_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel2_button_delete.Name = "menu2_1_panel_main_panel2_button_delete";
            this.menu2_1_panel_main_panel2_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel2_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel2_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel2_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel2_button_delete_Click);
            // 
            // menu2_1_panel_main_panel2_label1
            // 
            this.menu2_1_panel_main_panel2_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel2_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel2_label1.MinimumSize = new System.Drawing.Size(30, 0);
            this.menu2_1_panel_main_panel2_label1.Name = "menu2_1_panel_main_panel2_label1";
            this.menu2_1_panel_main_panel2_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel2_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel2_label1.Text = "label1";
            this.menu2_1_panel_main_panel2_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel2_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel2_label1_Click);
            // 
            // menu2_1_panel_main_panel2_label2
            // 
            this.menu2_1_panel_main_panel2_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel2_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel2_label2.Name = "menu2_1_panel_main_panel2_label2";
            this.menu2_1_panel_main_panel2_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel2_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel2_label2.Text = "label2";
            this.menu2_1_panel_main_panel2_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel2_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel2_label2_Click);
            // 
            // menu2_1_panel_main_panel1
            // 
            this.menu2_1_panel_main_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel1.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel_main_panel1.Controls.Add(this.menu2_1_panel_main_panel1_label1);
            this.menu2_1_panel_main_panel1.Controls.Add(this.menu2_1_panel_main_panel1_button_finish);
            this.menu2_1_panel_main_panel1.Controls.Add(this.menu2_1_panel_main_panel1_button_delete);
            this.menu2_1_panel_main_panel1.Controls.Add(this.menu2_1_panel_main_panel1_label2);
            this.menu2_1_panel_main_panel1.Location = new System.Drawing.Point(4, 0);
            this.menu2_1_panel_main_panel1.Name = "menu2_1_panel_main_panel1";
            this.menu2_1_panel_main_panel1.Size = new System.Drawing.Size(655, 32);
            this.menu2_1_panel_main_panel1.TabIndex = 3;
            this.menu2_1_panel_main_panel1.Click += new System.EventHandler(this.menu2_1_panel_main_panel1_Click);
            // 
            // menu2_1_panel_main_panel1_label1
            // 
            this.menu2_1_panel_main_panel1_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel1_label1.Location = new System.Drawing.Point(1, 1);
            this.menu2_1_panel_main_panel1_label1.Name = "menu2_1_panel_main_panel1_label1";
            this.menu2_1_panel_main_panel1_label1.Size = new System.Drawing.Size(512, 30);
            this.menu2_1_panel_main_panel1_label1.TabIndex = 0;
            this.menu2_1_panel_main_panel1_label1.Text = "label1";
            this.menu2_1_panel_main_panel1_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2_1_panel_main_panel1_label1.Click += new System.EventHandler(this.menu2_1_panel_main_panel1_label1_Click);
            // 
            // menu2_1_panel_main_panel1_button_finish
            // 
            this.menu2_1_panel_main_panel1_button_finish.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel1_button_finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel1_button_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel1_button_finish.Image = ((System.Drawing.Image)(resources.GetObject("menu2_1_panel_main_panel1_button_finish.Image")));
            this.menu2_1_panel_main_panel1_button_finish.Location = new System.Drawing.Point(591, 0);
            this.menu2_1_panel_main_panel1_button_finish.Name = "menu2_1_panel_main_panel1_button_finish";
            this.menu2_1_panel_main_panel1_button_finish.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel1_button_finish.TabIndex = 2;
            this.menu2_1_panel_main_panel1_button_finish.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel1_button_finish.Click += new System.EventHandler(this.menu2_1_panel_main_panel1_button_finish_Click);
            this.menu2_1_panel_main_panel1_button_finish.MouseEnter += new System.EventHandler(this.menu2_1_panel_main_panel1_button_finish_MouseEnter);
            this.menu2_1_panel_main_panel1_button_finish.MouseLeave += new System.EventHandler(this.menu2_1_panel_main_panel1_button_finish_MouseLeave);
            // 
            // menu2_1_panel_main_panel1_button_delete
            // 
            this.menu2_1_panel_main_panel1_button_delete.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_main_panel1_button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_main_panel1_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_main_panel1_button_delete.Image = ((System.Drawing.Image)(resources.GetObject("menu2_1_panel_main_panel1_button_delete.Image")));
            this.menu2_1_panel_main_panel1_button_delete.Location = new System.Drawing.Point(623, 0);
            this.menu2_1_panel_main_panel1_button_delete.Name = "menu2_1_panel_main_panel1_button_delete";
            this.menu2_1_panel_main_panel1_button_delete.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_main_panel1_button_delete.TabIndex = 1;
            this.menu2_1_panel_main_panel1_button_delete.UseVisualStyleBackColor = false;
            this.menu2_1_panel_main_panel1_button_delete.Click += new System.EventHandler(this.menu2_1_panel_main_panel1_button_delete_Click);
            this.menu2_1_panel_main_panel1_button_delete.MouseEnter += new System.EventHandler(this.menu2_1_panel_main_panel1_button_delete_MouseEnter);
            this.menu2_1_panel_main_panel1_button_delete.MouseLeave += new System.EventHandler(this.menu2_1_panel_main_panel1_button_delete_MouseLeave);
            // 
            // menu2_1_panel_main_panel1_label2
            // 
            this.menu2_1_panel_main_panel1_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main_panel1_label2.Location = new System.Drawing.Point(513, 1);
            this.menu2_1_panel_main_panel1_label2.Name = "menu2_1_panel_main_panel1_label2";
            this.menu2_1_panel_main_panel1_label2.Size = new System.Drawing.Size(76, 30);
            this.menu2_1_panel_main_panel1_label2.TabIndex = 3;
            this.menu2_1_panel_main_panel1_label2.Text = "99/99 - 99/99";
            this.menu2_1_panel_main_panel1_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2_1_panel_main_panel1_label2.Click += new System.EventHandler(this.menu2_1_panel_main_panel1_label2_Click);
            // 
            // menu3
            // 
            this.menu3.Controls.Add(this.menu3_panel_main);
            this.menu3.Controls.Add(this.menu3_panel_top);
            this.menu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu3.Location = new System.Drawing.Point(0, 479);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(682, 200);
            this.menu3.TabIndex = 4;
            // 
            // menu3_panel_main
            // 
            this.menu3_panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu3_panel_main.Location = new System.Drawing.Point(0, 64);
            this.menu3_panel_main.Name = "menu3_panel_main";
            this.menu3_panel_main.Size = new System.Drawing.Size(682, 136);
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
            this.menu3_panel_top_label_title.Size = new System.Drawing.Size(38, 15);
            this.menu3_panel_top_label_title.TabIndex = 0;
            this.menu3_panel_top_label_title.Text = "label1";
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
            this.menutask.Location = new System.Drawing.Point(0, 748);
            this.menutask.Name = "menutask";
            this.menutask.Size = new System.Drawing.Size(682, 307);
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
            this.menutask_button_save.Location = new System.Drawing.Point(0, 279);
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
            this.menuachieve.Location = new System.Drawing.Point(0, 1055);
            this.menuachieve.Name = "menuachieve";
            this.menuachieve.Size = new System.Drawing.Size(682, 235);
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
            this.menuachieve_button_save.Location = new System.Drawing.Point(0, 203);
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
            this.menu1_table_calender_panel_day1.ResumeLayout(false);
            this.menu1_table_calender_panel_day42.ResumeLayout(false);
            this.menu1_table_calender_panel_day41.ResumeLayout(false);
            this.menu1_table_calender_panel_day40.ResumeLayout(false);
            this.menu1_table_calender_panel_day39.ResumeLayout(false);
            this.menu1_table_calender_panel_day38.ResumeLayout(false);
            this.menu1_table_calender_panel_day37.ResumeLayout(false);
            this.menu1_table_calender_panel_day36.ResumeLayout(false);
            this.menu1_table_calender_panel_day35.ResumeLayout(false);
            this.menu1_table_calender_panel_day34.ResumeLayout(false);
            this.menu1_table_calender_panel_day33.ResumeLayout(false);
            this.menu1_table_calender_panel_day32.ResumeLayout(false);
            this.menu1_table_calender_panel_day31.ResumeLayout(false);
            this.menu1_table_calender_panel_day30.ResumeLayout(false);
            this.menu1_table_calender_panel_day29.ResumeLayout(false);
            this.menu1_table_calender_panel_day28.ResumeLayout(false);
            this.menu1_table_calender_panel_day27.ResumeLayout(false);
            this.menu1_table_calender_panel_day26.ResumeLayout(false);
            this.menu1_table_calender_panel_day25.ResumeLayout(false);
            this.menu1_table_calender_panel_day24.ResumeLayout(false);
            this.menu1_table_calender_panel_day23.ResumeLayout(false);
            this.menu1_table_calender_panel_day22.ResumeLayout(false);
            this.menu1_table_calender_panel_day21.ResumeLayout(false);
            this.menu1_table_calender_panel_day20.ResumeLayout(false);
            this.menu1_table_calender_panel_day19.ResumeLayout(false);
            this.menu1_table_calender_panel_day18.ResumeLayout(false);
            this.menu1_table_calender_panel_day17.ResumeLayout(false);
            this.menu1_table_calender_panel_day16.ResumeLayout(false);
            this.menu1_table_calender_panel_day15.ResumeLayout(false);
            this.menu1_table_calender_panel_day14.ResumeLayout(false);
            this.menu1_table_calender_panel_day13.ResumeLayout(false);
            this.menu1_table_calender_panel_day12.ResumeLayout(false);
            this.menu1_table_calender_panel_day11.ResumeLayout(false);
            this.menu1_table_calender_panel_day8.ResumeLayout(false);
            this.menu1_table_calender_panel_day7.ResumeLayout(false);
            this.menu1_table_calender_panel_day6.ResumeLayout(false);
            this.menu1_table_calender_panel_day5.ResumeLayout(false);
            this.menu1_table_calender_panel_day4.ResumeLayout(false);
            this.menu1_table_calender_panel_day3.ResumeLayout(false);
            this.menu1_table_calender_panel_day2.ResumeLayout(false);
            this.menu1_table_calender_panel_day9.ResumeLayout(false);
            this.menu1_table_calender_panel_day10.ResumeLayout(false);
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
            this.menu2_2_panel_main_panel5.ResumeLayout(false);
            this.menu2_2_panel_main_panel5_table_memo.ResumeLayout(false);
            this.menu2_2_panel_main_panel5_table_memo.PerformLayout();
            this.menu2_2_panel_main_panel5_table_memo_panel_top.ResumeLayout(false);
            this.menu2_2_panel_main_panel5_table_memo_panel_top.PerformLayout();
            this.menu2_2_panel_main_panel4.ResumeLayout(false);
            this.menu2_2_panel_main_panel4_table_memo.ResumeLayout(false);
            this.menu2_2_panel_main_panel4_table_memo.PerformLayout();
            this.menu2_2_panel_main_panel4_table_memo_panel_top.ResumeLayout(false);
            this.menu2_2_panel_main_panel4_table_memo_panel_top.PerformLayout();
            this.menu2_2_panel_main_panel3.ResumeLayout(false);
            this.menu2_2_panel_main_panel3_table_memo.ResumeLayout(false);
            this.menu2_2_panel_main_panel3_table_memo.PerformLayout();
            this.menu2_2_panel_main_panel3_table_memo_panel_top.ResumeLayout(false);
            this.menu2_2_panel_main_panel3_table_memo_panel_top.PerformLayout();
            this.menu2_2_panel_main_panel2.ResumeLayout(false);
            this.menu2_2_panel_main_panel2_table_memo.ResumeLayout(false);
            this.menu2_2_panel_main_panel2_table_memo.PerformLayout();
            this.menu2_2_panel_main_panel2_table_memo_panel_top.ResumeLayout(false);
            this.menu2_2_panel_main_panel2_table_memo_panel_top.PerformLayout();
            this.menu2_2_panel_main_panel1.ResumeLayout(false);
            this.menu2_2_panel_main_panel1_table_memo.ResumeLayout(false);
            this.menu2_2_panel_main_panel1_table_memo.PerformLayout();
            this.menu2_2_panel_main_panel1_table_memo_panel_top.ResumeLayout(false);
            this.menu2_2_panel_main_panel1_table_memo_panel_top.PerformLayout();
            this.menu2_1.ResumeLayout(false);
            this.menu2_1_panel.ResumeLayout(false);
            this.menu2_1_panel_top.ResumeLayout(false);
            this.menu2_1_panel_main.ResumeLayout(false);
            this.menu2_1_panel_main_panel25.ResumeLayout(false);
            this.menu2_1_panel_main_panel24.ResumeLayout(false);
            this.menu2_1_panel_main_panel23.ResumeLayout(false);
            this.menu2_1_panel_main_panel22.ResumeLayout(false);
            this.menu2_1_panel_main_panel21.ResumeLayout(false);
            this.menu2_1_panel_main_panel20.ResumeLayout(false);
            this.menu2_1_panel_main_panel19.ResumeLayout(false);
            this.menu2_1_panel_main_panel18.ResumeLayout(false);
            this.menu2_1_panel_main_panel17.ResumeLayout(false);
            this.menu2_1_panel_main_panel16.ResumeLayout(false);
            this.menu2_1_panel_main_panel15.ResumeLayout(false);
            this.menu2_1_panel_main_panel14.ResumeLayout(false);
            this.menu2_1_panel_main_panel13.ResumeLayout(false);
            this.menu2_1_panel_main_panel12.ResumeLayout(false);
            this.menu2_1_panel_main_panel11.ResumeLayout(false);
            this.menu2_1_panel_main_panel10.ResumeLayout(false);
            this.menu2_1_panel_main_panel9.ResumeLayout(false);
            this.menu2_1_panel_main_panel8.ResumeLayout(false);
            this.menu2_1_panel_main_panel7.ResumeLayout(false);
            this.menu2_1_panel_main_panel6.ResumeLayout(false);
            this.menu2_1_panel_main_panel5.ResumeLayout(false);
            this.menu2_1_panel_main_panel4.ResumeLayout(false);
            this.menu2_1_panel_main_panel3.ResumeLayout(false);
            this.menu2_1_panel_main_panel2.ResumeLayout(false);
            this.menu2_1_panel_main_panel1.ResumeLayout(false);
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