﻿using System.Windows.Forms;
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
        public CheckBox common_panel_setting_table_check2;
        public Label common_panel_setting_table_label1;
        public Label common_panel_setting_table_label2;
        public TableLayoutPanel common_panel_setting_table_setting;

        // ■■■■■■■■■■■■■■■■■■■■■　menu1　■■■■■■■■■■■■■■■■■■■■■
        public Panel menu1;
        public PanelEx menu1_panel_calender;
        public Panel menu1_panel_calender_panel_top;
        public Panel menu1_panel_calender_panel_top_panel_yearmonth;
        public Button menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth;
        public Button menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth;
        public ComboBox menu1_panel_calender_panel_top_panel_yearmonth_combo_month;
        public ComboBox menu1_panel_calender_panel_top_panel_yearmonth_combo_year;
        public Panel menu1_panel_calender_panel_main;
        public TableLayoutPanel menu1_panel_calender_panel_main_table_calender;
        public Panel[] menu1_panel_calender_panel_main_table_calender_panel_day;
        public Label[] menu1_panel_calender_panel_main_table_calender_label_dow;
        public Label[] menu1_panel_calender_panel_main_table_calender_panel_day_label_day;

        public PanelEx menu1_panel_done;
        public Panel menu1_panel_done_panel_top;
        public Label menu1_panel_done_panel_top_label_day;
        public Label menu1_panel_done_panel_top_label_hour;
        public Button menu1_panel_done_panel_top_button_add;
        public Panel menu1_panel_done_panel_main;
        public System.Collections.Generic.List<PanelEx> menu1_panel_done_panel_main_panel;
        public System.Collections.Generic.List<Label> menu1_panel_done_panel_main_panel_label_name;
        public System.Collections.Generic.List<Label> menu1_panel_done_panel_main_panel_label_time;
        public System.Collections.Generic.List<Button> menu1_panel_done_panel_main_panel_button_delete;

        // ■■■■■■■■■■■■■■■■■■■■■　menu2　■■■■■■■■■■■■■■■■■■■■■
        public Panel menu2;
        public Panel menu2_1;
        public PanelEx menu2_1_panel;
        public Panel menu2_1_panel_main;
        public System.Collections.Generic.List<PanelEx> menu2_1_panel_main_panel;
        public System.Collections.Generic.List<Button> menu2_1_panel_main_panel_button_delete;
        public System.Collections.Generic.List<Button> menu2_1_panel_main_panel_button_finish;
        public System.Collections.Generic.List<Label> menu2_1_panel_main_panel_label1;
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
        public Panel menu2_2_panel_top;
        public Button menu2_2_panel_top_button_add;
        public Button menu2_2_panel_top_button_movedown;
        public Button menu2_2_panel_top_button_moveup;
        public Button menu2_2_panel_top_button_open;
        public Button menu2_2_panel_top_button_openclose;
        public Circlelabel menu2_2_panel_top_label_num;
        public Label menu2_2_panel_top_label_title;
        public System.Collections.Generic.List<Panel> menu2_2_panel_main_panel;
        public System.Collections.Generic.List<TableLayoutPanel> menu2_2_panel_main_panel_table_memo;
        public System.Collections.Generic.List<TextBox> menu2_2_panel_main_panel_table_memo_text;
        public System.Collections.Generic.List<Panel> menu2_2_panel_main_panel_table_memo_panel_top;
        public System.Collections.Generic.List<Button> menu2_2_panel_main_panel_table_memo_panel_top_button_close;
        public System.Collections.Generic.List<Button> menu2_2_panel_main_panel_table_memo_panel_top_button_minmax;
        public System.Collections.Generic.List<Button> menu2_2_panel_main_panel_table_memo_panel_top_button_save;
        public System.Collections.Generic.List<TextBox> menu2_2_panel_main_panel_table_memo_panel_top_text;

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
        public Label menutask_table2_label;
        public TextBox menutask_table2_text;

        // ■■■■■■■■■■■■■■■■■■■■■　other　■■■■■■■■■■■■■■■■■■■■■ 
        public ToolTip tooltip;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 変数
            int common_button_width = 42;
            int common_button_height = 32;
            string[] menu1_panel_calender_panel_main_dow = { "日", "月", "火", "水", "木", "金", "土" };
            int menu1_panel_calender_panel_main_num = 42;
            int menu1_panel_calender_panel_main_table_calender_height = 485;

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.common = new TaskManage.PanelEx();
            this.common_button_close = new System.Windows.Forms.Button();
            this.common_button_max = new System.Windows.Forms.Button();
            this.common_button_min = new System.Windows.Forms.Button();
            this.common_button_prevmenu = new System.Windows.Forms.Button();
            this.common_button_setting = new System.Windows.Forms.Button();
            this.common_button_nextmenu = new System.Windows.Forms.Button();
            this.common_panel_setting = new System.Windows.Forms.Panel();
            this.common_panel_setting_table_setting = new System.Windows.Forms.TableLayoutPanel();
            this.common_panel_setting_table_check1 = new System.Windows.Forms.CheckBox();
            this.common_panel_setting_table_check2 = new System.Windows.Forms.CheckBox();
            this.common_panel_setting_table_label2 = new System.Windows.Forms.Label();
            this.common_panel_setting_table_label1 = new System.Windows.Forms.Label();

            this.menu1 = new System.Windows.Forms.Panel();
            this.menu1_panel_calender = new TaskManage.PanelEx();
            this.menu1_panel_calender_panel_top = new System.Windows.Forms.Panel();
            this.menu1_panel_calender_panel_top_panel_yearmonth = new System.Windows.Forms.Panel();
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth = new System.Windows.Forms.Button();
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth = new System.Windows.Forms.Button();
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month = new System.Windows.Forms.ComboBox();
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year = new System.Windows.Forms.ComboBox();
            this.menu1_panel_calender_panel_main = new System.Windows.Forms.Panel();
            this.menu1_panel_calender_panel_main_table_calender = new System.Windows.Forms.TableLayoutPanel();
            this.menu1_panel_calender_panel_main_table_calender_label_dow = new System.Windows.Forms.Label[7];
            for (int i = 0; i < 7; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender_label_dow[i] = new System.Windows.Forms.Label();
            }
            this.menu1_panel_calender_panel_main_table_calender_panel_day = new System.Windows.Forms.Panel[menu1_panel_calender_panel_main_num];
            this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day = new System.Windows.Forms.Label[menu1_panel_calender_panel_main_num];
            for (int i = 0; i < menu1_panel_calender_panel_main_num; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i] = new System.Windows.Forms.Panel();
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i] = new System.Windows.Forms.Label();
            }

            this.menu1_panel_done = new TaskManage.PanelEx();
            this.menu1_panel_done_panel_top = new System.Windows.Forms.Panel();
            this.menu1_panel_done_panel_top_label_day = new System.Windows.Forms.Label();
            this.menu1_panel_done_panel_top_label_hour = new System.Windows.Forms.Label();
            this.menu1_panel_done_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu1_panel_done_panel_main = new System.Windows.Forms.Panel();
            this.menu1_panel_done_panel_main_panel = new System.Collections.Generic.List<PanelEx>();
            this.menu1_panel_done_panel_main_panel_label_name = new System.Collections.Generic.List<Label>();
            this.menu1_panel_done_panel_main_panel_label_time = new System.Collections.Generic.List<Label>();
            this.menu1_panel_done_panel_main_panel_button_delete = new System.Collections.Generic.List<Button>();

            this.menu2 = new System.Windows.Forms.Panel();
            this.menu2_1 = new System.Windows.Forms.Panel();
            this.menu2_1_panel = new TaskManage.PanelEx();
            this.menu2_1_panel_top = new System.Windows.Forms.Panel();
            this.menu2_1_panel_top_label_num = new TaskManage.Circlelabel();
            this.menu2_1_panel_top_button_movedown = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_button_moveup = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_label_title = new System.Windows.Forms.Label();
            this.menu2_1_panel_top_button_openclose = new System.Windows.Forms.Button();
            this.menu2_1_panel_top_button_add = new System.Windows.Forms.Button();
            this.menu2_1_panel_main = new System.Windows.Forms.Panel();
            this.menu2_1_panel_main_panel = new System.Collections.Generic.List<PanelEx>();
            this.menu2_1_panel_main_panel_button_delete = new System.Collections.Generic.List<Button>();
            this.menu2_1_panel_main_panel_button_finish = new System.Collections.Generic.List<Button>();
            this.menu2_1_panel_main_panel_label1 = new System.Collections.Generic.List<Label>();

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
            this.menu2_2_panel_main_panel = new System.Collections.Generic.List<Panel>();
            this.menu2_2_panel_main_panel_table_memo = new System.Collections.Generic.List<TableLayoutPanel>();
            this.menu2_2_panel_main_panel_table_memo_text = new System.Collections.Generic.List<TextBox>();
            this.menu2_2_panel_main_panel_table_memo_panel_top = new System.Collections.Generic.List<Panel>();
            this.menu2_2_panel_main_panel_table_memo_panel_top_button_close = new System.Collections.Generic.List<Button>();
            this.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax =new System.Collections.Generic.List<Button>();
            this.menu2_2_panel_main_panel_table_memo_panel_top_button_save = new System.Collections.Generic.List<Button>();
            this.menu2_2_panel_main_panel_table_memo_panel_top_text = new System.Collections.Generic.List<TextBox>();

            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            
            this.menutask = new TaskManage.PanelEx();
            this.menutask_button_close = new System.Windows.Forms.Button();
            this.menutask_table2 = new System.Windows.Forms.TableLayoutPanel();
            this.menutask_table2_label = new System.Windows.Forms.Label();
            this.menutask_table2_text = new System.Windows.Forms.TextBox();
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

            // レイアウトロジック停止 子コントロールを持つコントロール全て
            this.SuspendLayout();

            this.common.SuspendLayout();
            this.common_panel_setting.SuspendLayout();
            this.common_panel_setting_table_setting.SuspendLayout();
            
            this.menu1.SuspendLayout();
            this.menu1_panel_calender.SuspendLayout();
            this.menu1_panel_calender_panel_top.SuspendLayout();
            this.menu1_panel_calender_panel_top_panel_yearmonth.SuspendLayout();
            this.menu1_panel_calender_panel_main.SuspendLayout();
            this.menu1_panel_calender_panel_main_table_calender.SuspendLayout();
            for (int i = 0; i < menu1_panel_calender_panel_main_num; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].SuspendLayout();
            }

            this.menu1_panel_done.SuspendLayout();
            this.menu1_panel_done_panel_top.SuspendLayout();
            this.menu1_panel_done_panel_main.SuspendLayout();

            this.menu2.SuspendLayout();
            this.menu2_1.SuspendLayout();
            this.menu2_1_panel.SuspendLayout();
            this.menu2_1_panel_top.SuspendLayout();
            this.menu2_1_panel_main.SuspendLayout();
            this.menu2_2.SuspendLayout();
            this.menu2_2_panel.SuspendLayout();
            this.menu2_2_panel_top.SuspendLayout();
            this.menu2_2_panel_main.SuspendLayout();

            this.menutask.SuspendLayout();
            this.menutask_table2.SuspendLayout();
            this.menutask_table1.SuspendLayout();

            this.menuachieve.SuspendLayout();
            this.menuachieve_table4.SuspendLayout();
            this.menuachieve_table3.SuspendLayout();
            this.menuachieve_table2.SuspendLayout();
            this.menuachieve_table1.SuspendLayout();

            

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(Main.Common_Const.form_x, Main.Common_Const.form_y);
            this.Controls.Add(this.common_panel_setting);
            this.Controls.Add(this.menutask);
            this.Controls.Add(this.menuachieve);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.common);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "タスク管理";

            // 
            // common
            // 
            this.common.BorderColor = System.Drawing.Color.Black;
            this.common.Controls.Add(this.common_button_prevmenu);
            this.common.Controls.Add(this.common_button_setting);
            this.common.Controls.Add(this.common_button_nextmenu);
            this.common.Controls.Add(this.common_button_min);
            this.common.Controls.Add(this.common_button_max);
            this.common.Controls.Add(this.common_button_close);
            this.common.Dock = System.Windows.Forms.DockStyle.Top;
            this.common.Size = new System.Drawing.Size(Main.Common_Const.form_x, common_button_height + 2);
            this.common.Margin = new System.Windows.Forms.Padding(0);
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
            this.common_button_prevmenu.Location = new System.Drawing.Point(Main.Common_Const.form_x - common_button_width * 5, 1);
            this.common_button_prevmenu.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_prevmenu.Size = new System.Drawing.Size(common_button_width, common_button_height);
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
            this.common_button_setting.Size = new System.Drawing.Size(32, common_button_height);
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
            this.common_button_nextmenu.Location = new System.Drawing.Point(Main.Common_Const.form_x - common_button_width * 4, 1);
            this.common_button_nextmenu.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_nextmenu.Size = new System.Drawing.Size(common_button_width, common_button_height);
            this.tooltip.SetToolTip(this.common_button_nextmenu, "次のメニューに移動");
            this.common_button_nextmenu.UseVisualStyleBackColor = false;
            this.common_button_nextmenu.Click += new System.EventHandler(this.common_button_nextmenu_Click);
            // 
            // common_button_close
            // 
            this.common_button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.common_button_close.BackColor = System.Drawing.Color.Transparent;
            this.common_button_close.FlatAppearance.BorderSize = 0;
            this.common_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.common_button_close.ForeColor = System.Drawing.Color.Red;
            this.common_button_close.Image = ((System.Drawing.Image)(resources.GetObject("common_button_close.Image")));
            this.common_button_close.Location = new System.Drawing.Point(Main.Common_Const.form_x - common_button_width * 1, 1);
            this.common_button_close.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_close.Size = new System.Drawing.Size(common_button_width, common_button_height);
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
            this.common_button_max.Image = ((System.Drawing.Image)(resources.GetObject("common_button_max.Image")));
            this.common_button_max.Location = new System.Drawing.Point(Main.Common_Const.form_x - common_button_width * 2, 1);
            this.common_button_max.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_max.Size = new System.Drawing.Size(common_button_width, common_button_height);
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
            this.common_button_min.Image = ((System.Drawing.Image)(resources.GetObject("common_button_min.Image")));
            this.common_button_min.Location = new System.Drawing.Point(Main.Common_Const.form_x - common_button_width * 3, 1);
            this.common_button_min.Margin = new System.Windows.Forms.Padding(0);
            this.common_button_min.Size = new System.Drawing.Size(common_button_width, common_button_height);
            this.tooltip.SetToolTip(this.common_button_min, "最小化");
            this.common_button_min.UseVisualStyleBackColor = false;
            this.common_button_min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.common_button_min_MouseClick);
            // 
            // common_panel_setting
            // 
            this.common_panel_setting.BackColor = System.Drawing.Color.Transparent;
            this.common_panel_setting.Controls.Add(this.common_panel_setting_table_setting);
            this.common_panel_setting.Location = new System.Drawing.Point(3, 38);
            this.common_panel_setting.Size = new System.Drawing.Size(150, 96);
            this.common_panel_setting.Visible = false;
            // 
            // common_panel_setting_table_setting
            // 
            this.common_panel_setting_table_setting.BackColor = System.Drawing.Color.Transparent;
            this.common_panel_setting_table_setting.ColumnCount = 2;
            this.common_panel_setting_table_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.common_panel_setting_table_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_label1, 0, 0);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_label2, 0, 1);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_check1, 1, 0);
            this.common_panel_setting_table_setting.Controls.Add(this.common_panel_setting_table_check2, 1, 1);
            this.common_panel_setting_table_setting.Location = new System.Drawing.Point(4, 3);
            this.common_panel_setting_table_setting.RowCount = 2;
            this.common_panel_setting_table_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.common_panel_setting_table_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.common_panel_setting_table_setting.Size = new System.Drawing.Size(142, 90);
            // 
            // common_panel_setting_table_label1
            // 
            this.common_panel_setting_table_label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.common_panel_setting_table_label1.Text = "ダークモード";
            this.common_panel_setting_table_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // common_panel_setting_table_label2
            // 
            this.common_panel_setting_table_label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.common_panel_setting_table_label2.Text = "右端折り返し";
            this.common_panel_setting_table_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // common_panel_setting_table_check1
            // 
            this.common_panel_setting_table_check1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.common_panel_setting_table_check1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.common_panel_setting_table_check1.UseVisualStyleBackColor = true;
            this.common_panel_setting_table_check1.CheckedChanged += new System.EventHandler(this.common_panel_setting_table_check1_CheckedChanged);
            // 
            // common_panel_setting_table_check2
            // 
            this.common_panel_setting_table_check2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.common_panel_setting_table_check2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.common_panel_setting_table_check2.UseVisualStyleBackColor = true;


            // 
            // menu1
            // 
            this.menu1.AutoScroll = true;
            this.menu1.BackColor = System.Drawing.Color.Transparent;
            this.menu1.Controls.Add(this.menu1_panel_done);
            this.menu1.Controls.Add(this.menu1_panel_calender);
            this.menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1.Size = new System.Drawing.Size(Main.Common_Const.form_x, 1000);
            //
            // menu1_panel_calender
            //
            this.menu1_panel_calender.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_panel_calender.Controls.Add(this.menu1_panel_calender_panel_top);
            this.menu1_panel_calender.Controls.Add(this.menu1_panel_calender_panel_main);
            this.menu1_panel_calender.Size = new System.Drawing.Size(Main.Common_Const.form_x, common_button_height + menu1_panel_calender_panel_main_table_calender_height + 2);
            // 
            // menu1_panel_calender_panel_top
            // 
            this.menu1_panel_calender_panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_calender_panel_top.Controls.Add(this.menu1_panel_calender_panel_top_panel_yearmonth);
            this.menu1_panel_calender_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu1_panel_calender_panel_top.Size = new System.Drawing.Size(Main.Common_Const.form_x - 2, common_button_height);
            // 
            // menu1_panel_calender_panel_top_panel_yearmonth
            // 
            this.menu1_panel_calender_panel_top_panel_yearmonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
            this.menu1_panel_calender_panel_top_panel_yearmonth.Controls.Add(this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth);
            this.menu1_panel_calender_panel_top_panel_yearmonth.Controls.Add(this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year);
            this.menu1_panel_calender_panel_top_panel_yearmonth.Controls.Add(this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month);
            this.menu1_panel_calender_panel_top_panel_yearmonth.Controls.Add(this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year);
            this.menu1_panel_calender_panel_top_panel_yearmonth.Controls.Add(this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth);
            this.menu1_panel_calender_panel_top_panel_yearmonth.Size = new System.Drawing.Size(this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.Width 
                + this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.Width + this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.Width
                + this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.Width, common_button_height);
            this.menu1_panel_calender_panel_top_panel_yearmonth.Location = new System.Drawing.Point(Main.Common_Const.form_x / 2
                - this.menu1_panel_calender_panel_top_panel_yearmonth.Width / 2, 0);
            // 
            // menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth
            // 
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.FlatAppearance.BorderSize = 0;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.Image = ((System.Drawing.Image)(resources.GetObject("common_button_prevmenu.Image")));
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.Size = new System.Drawing.Size(common_button_width, 0);
            this.tooltip.SetToolTip(this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth, "前の月を表示");
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.UseVisualStyleBackColor = true;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth.Click += new System.EventHandler(this.menu1_panel_calender_panel_top_panel_yearmonth_button_prevmonth_Click);
            // 
            // menu1_panel_calender_panel_top_panel_yearmonth_combo_year
            // 
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.FormattingEnabled = true;
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.Size = new System.Drawing.Size(60, 0);
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year.SelectedIndexChanged += new System.EventHandler(this.menu1_panel_calender_panel_top_panel_yearmonth_combo_year_SelectedIndexChanged);
            // 
            // menu1_panel_calender_panel_top_panel_yearmonth_combo_month
            // 
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.FormattingEnabled = true;
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"});
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.Size = new System.Drawing.Size(43, 0);
            this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month.SelectedIndexChanged += new System.EventHandler(this.menu1_panel_calender_panel_top_panel_yearmonth_combo_month_SelectedIndexChanged);
            // 
            // menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth
            // 
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.FlatAppearance.BorderSize = 0;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.Image = ((System.Drawing.Image)(resources.GetObject("common_button_nextmenu.Image")));
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.Size = new System.Drawing.Size(common_button_width, 0);
            this.tooltip.SetToolTip(this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth, "次の月を表示");
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.UseVisualStyleBackColor = true;
            this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth.Click += new System.EventHandler(this.menu1_panel_calender_panel_top_panel_yearmonth_button_nextmonth_Click);
            // 
            // menu1_panel_calender_panel_main
            // 
            this.menu1_panel_calender_panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_calender_panel_main.Controls.Add(this.menu1_panel_calender_panel_main_table_calender);
            this.menu1_panel_calender_panel_main.Location = new System.Drawing.Point(1, common_button_height + 1);
            this.menu1_panel_calender_panel_main.Size = new System.Drawing.Size(Main.Common_Const.form_x - 2, menu1_panel_calender_panel_main_table_calender_height);
            // 
            // menu1_table_calender
            // 
            this.menu1_panel_calender_panel_main_table_calender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_calender_panel_main_table_calender.ColumnCount = 7;
            for (int i = 0; i < 7; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            }

            for (int i = 0; i < 7; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender.Controls.Add(this.menu1_panel_calender_panel_main_table_calender_label_dow[i], i, 0);
            }
            for (int i = menu1_panel_calender_panel_main_num - 1; i >= 0; i--)
            {
                this.menu1_panel_calender_panel_main_table_calender.Controls.Add(this.menu1_panel_calender_panel_main_table_calender_panel_day[i], i % 7, i / 7 + 1);
            }
            this.menu1_panel_calender_panel_main_table_calender.ForeColor = System.Drawing.Color.Black;
            this.menu1_panel_calender_panel_main_table_calender.Location = new System.Drawing.Point(10, 39);
            this.menu1_panel_calender_panel_main_table_calender.RowCount = 7;
            this.menu1_panel_calender_panel_main_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            for (int i = 1; i <= 6; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            }
            this.menu1_panel_calender_panel_main_table_calender.Size = new System.Drawing.Size(Main.Common_Const.form_x - 20, menu1_panel_calender_panel_main_table_calender_height);

            for (int i = menu1_panel_calender_panel_main_num - 1; i >= 0; i--)
            {
                //
                // menu1_panel_calender_panel_main_table_calender_panel_day
                //
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].BackColor = System.Drawing.Color.Transparent;
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].Controls.Add(this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i]);
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].Location = new System.Drawing.Point(1 + 94 * (i % 7), 21 + (73 * (i / 7)));
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].Margin = new System.Windows.Forms.Padding(1);
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].Name = i.ToString();
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].Size = new System.Drawing.Size(92, 61);
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_MouseClick);
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].MouseEnter += new System.EventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_MouseEnter);
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].MouseLeave += new System.EventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_MouseLeave);
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_MouseDoubleClick);
                //
                // menu1_panel_calender_panel_main_table_calender_panel_day_label_day
                //
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].BackColor = System.Drawing.Color.Transparent;
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].Location = new System.Drawing.Point(1, 1);
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].Margin = new System.Windows.Forms.Padding(0);
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].Name = i.ToString();
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].Size = new System.Drawing.Size(90, 15);
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].TextAlign = System.Drawing.ContentAlignment.TopCenter;
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day_MouseClick);
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].MouseEnter += new System.EventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day_MouseEnter);
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].MouseLeave += new System.EventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day_MouseLeave);
                this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day[i].MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menu1_panel_calender_panel_main_table_calender_panel_day_label_day_MouseDoubleClick);
            }
            for (int i = 0; i < 7; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender_label_dow[i].Dock = System.Windows.Forms.DockStyle.Top;
                this.menu1_panel_calender_panel_main_table_calender_label_dow[i].Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.menu1_panel_calender_panel_main_table_calender_label_dow[i].Size = new System.Drawing.Size(88, 13);
                this.menu1_panel_calender_panel_main_table_calender_label_dow[i].Text = menu1_panel_calender_panel_main_dow[i];
                this.menu1_panel_calender_panel_main_table_calender_label_dow[i].TextAlign = System.Drawing.ContentAlignment.TopCenter;
            }
            //
            // menu1_panel_done
            //
            this.menu1_panel_done.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1_panel_done.Controls.Add(this.menu1_panel_done_panel_top);
            this.menu1_panel_done.Controls.Add(this.menu1_panel_done_panel_main);
            this.menu1_panel_done.Size = new System.Drawing.Size(Main.Common_Const.form_x, 200);
            //
            // menu1_panel_done_panel_top
            //
            this.menu1_panel_done_panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_done_panel_top.Controls.Add(this.menu1_panel_done_panel_top_label_day);
            this.menu1_panel_done_panel_top.Controls.Add(this.menu1_panel_done_panel_top_label_hour);
            this.menu1_panel_done_panel_top.Controls.Add(this.menu1_panel_done_panel_top_button_add);
            this.menu1_panel_done_panel_top.Location = new System.Drawing.Point(1, 1);
            this.menu1_panel_done_panel_top.Size = new System.Drawing.Size(Main.Common_Const.form_x - 2, 32);
            //
            // menu1_panel_done_panel_top_label_day
            //
            this.menu1_panel_done_panel_top_label_day.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1_panel_done_panel_top_label_day.BackColor = System.Drawing.Color.Transparent;
            this.menu1_panel_done_panel_top_label_day.Location = new System.Drawing.Point(1, 1);
            this.menu1_panel_done_panel_top_label_day.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_panel_done_panel_top_label_day.Size = new System.Drawing.Size(78, 15);
            this.menu1_panel_done_panel_top_label_day.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // menu1_panel_done_panel_top_label_hour
            //
            this.menu1_panel_done_panel_top_label_hour.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu1_panel_done_panel_top_label_hour.BackColor = System.Drawing.Color.Transparent;
            this.menu1_panel_done_panel_top_label_hour.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_panel_done_panel_top_label_hour.Size = new System.Drawing.Size(78, 0);
            this.menu1_panel_done_panel_top_label_hour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // menu1_panel_done_panel_top_button_add
            //
            this.menu1_panel_done_panel_top_button_add.BackColor = System.Drawing.Color.Transparent;
            this.menu1_panel_done_panel_top_button_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu1_panel_done_panel_top_button_add.FlatAppearance.BorderSize = 0;
            this.menu1_panel_done_panel_top_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu1_panel_done_panel_top_button_add.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu1_panel_done_panel_top_button_add.Image = ((System.Drawing.Image)(resources.GetObject("menu2_1_panel_top_button_add.Image")));
            this.menu1_panel_done_panel_top_button_add.Size = new System.Drawing.Size(32, 0);
            this.menu1_panel_done_panel_top_button_add.Margin = new System.Windows.Forms.Padding(0);
            this.tooltip.SetToolTip(this.menu1_panel_done_panel_top_button_add, "追加");
            this.menu1_panel_done_panel_top_button_add.UseVisualStyleBackColor = false;
            this.menu1_panel_done_panel_top_button_add.Click += new System.EventHandler(this.menu1_panel_done_panel_top_button_add_Click);
            //
            // menu1_panel_done_panel_main
            //
            this.menu1_panel_done_panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1_panel_done_panel_main.BackColor = System.Drawing.Color.Transparent;
            this.menu1_panel_done_panel_main.Location = new System.Drawing.Point(1, 33);
            this.menu1_panel_done_panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.menu1_panel_done_panel_main.Size = new System.Drawing.Size(150, 32);

            // 
            // menu2
            // 
            this.menu2.AutoScroll = true;
            this.menu2.Controls.Add(this.menu2_2);
            this.menu2.Controls.Add(this.menu2_1);
            this.menu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);

            // 
            // menu2_1
            // 
            this.menu2_1.Controls.Add(this.menu2_1_panel);
            this.menu2_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_1.Size = new System.Drawing.Size(Main.Common_Const.form_x, 950);
            // 
            // menu2_1_panel
            // 
            this.menu2_1_panel.BorderColor = System.Drawing.Color.Black;
            this.menu2_1_panel.Controls.Add(this.menu2_1_panel_top);
            this.menu2_1_panel.Controls.Add(this.menu2_1_panel_main);
            this.menu2_1_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_1_panel.Margin = new System.Windows.Forms.Padding(0);
            this.menu2_1_panel.Size = new System.Drawing.Size(Main.Common_Const.form_x, 936);
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
            this.menu2_1_panel_top.Size = new System.Drawing.Size(Main.Common_Const.form_x - this.menu2_1_panel_top.Location.X * 2, 32);
            // 
            // menu2_1_panel_top_button_moveup
            // 
            this.menu2_1_panel_top_button_moveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_moveup.Location = new System.Drawing.Point(0, 0);
            this.menu2_1_panel_top_button_moveup.Size = new System.Drawing.Size(16, 16);
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_moveup, "上に移動");
            this.menu2_1_panel_top_button_moveup.UseVisualStyleBackColor = true;
            this.menu2_1_panel_top_button_moveup.Click += new System.EventHandler(this.menu2_1_panel_top_button_moveup_Click);
            // 
            // menu2_1_panel_top_button_movedown
            // 
            this.menu2_1_panel_top_button_movedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_movedown.Location = new System.Drawing.Point(0, 16);
            this.menu2_1_panel_top_button_movedown.Size = new System.Drawing.Size(16, 16);
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_movedown, "下に移動");
            this.menu2_1_panel_top_button_movedown.UseVisualStyleBackColor = true;
            this.menu2_1_panel_top_button_movedown.Click += new System.EventHandler(this.menu2_1_panel_top_button_movedown_Click);
            // 
            // menu2_1_panel_top_label_title
            // 
            this.menu2_1_panel_top_label_title.Location = new System.Drawing.Point(this.menu2_1_panel_top_button_movedown.Size.Width, 0);
            this.menu2_1_panel_top_label_title.Size = new System.Drawing.Size(100, 32);
            this.menu2_1_panel_top_label_title.Text = "期間設定ありタスク";
            this.menu2_1_panel_top_label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu2_1_panel_top_label_num
            // 
            this.menu2_1_panel_top_label_num.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_top_label_num.CustomText = "25";
            this.menu2_1_panel_top_label_num.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_1_panel_top_label_num.Location = new System.Drawing.Point(this.menu2_1_panel_top_label_title.Location.X + this.menu2_1_panel_top_label_title.Width, 0);
            this.menu2_1_panel_top_label_num.Size = new System.Drawing.Size(20, 20);
            // 
            // menu2_1_panel_top_button_openclose
            // 
            this.menu2_1_panel_top_button_openclose.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_top_button_openclose.FlatAppearance.BorderSize = 0;
            this.menu2_1_panel_top_button_openclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_openclose.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_1_panel_top_button_openclose.Location = new System.Drawing.Point(this.menu2_1_panel_top_button_movedown.Size.Width + this.menu2_1_panel_top_label_title.Width
                + this.menu2_1_panel_top_label_num.Width, 0);
            this.menu2_1_panel_top_button_openclose.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_top_button_openclose.Text = "+";
            this.menu2_1_panel_top_button_openclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_openclose, "開く/閉じる");
            this.menu2_1_panel_top_button_openclose.UseVisualStyleBackColor = false;
            this.menu2_1_panel_top_button_openclose.Click += new System.EventHandler(this.menu2_1_panel_top_button_openclose_Click);
            // 
            // menu2_1_panel_top_button_add
            // 
            this.menu2_1_panel_top_button_add.BackColor = System.Drawing.Color.Transparent;
            this.menu2_1_panel_top_button_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_1_panel_top_button_add.FlatAppearance.BorderSize = 0;
            this.menu2_1_panel_top_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_1_panel_top_button_add.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu2_1_panel_top_button_add.Image = ((System.Drawing.Image)(resources.GetObject("menu2_1_panel_top_button_add.Image")));
            this.menu2_1_panel_top_button_add.Size = new System.Drawing.Size(32, 32);
            this.menu2_1_panel_top_button_add.Margin = new System.Windows.Forms.Padding(0);
            this.tooltip.SetToolTip(this.menu2_1_panel_top_button_add, "追加");
            this.menu2_1_panel_top_button_add.UseVisualStyleBackColor = false;
            this.menu2_1_panel_top_button_add.Click += new System.EventHandler(this.menu2_1_panel_top_button_add_Click);
            // 
            // menu2_1_panel_main
            // 
            this.menu2_1_panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_1_panel_main.Location = new System.Drawing.Point(1, 34);
            this.menu2_1_panel_main.Size = new System.Drawing.Size(Main.Common_Const.form_x - this.menu2_1_panel_main.Location.X * 2, 899);

            // 
            // menu2_2
            // 
            this.menu2_2.Controls.Add(this.menu2_2_panel);
            this.menu2_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2_2.Size = new System.Drawing.Size(Main.Common_Const.form_x, 570);
            // 
            // menu2_2_panel
            // 
            this.menu2_2_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel.BorderColor = System.Drawing.Color.Black;
            this.menu2_2_panel.Controls.Add(this.menu2_2_panel_top);
            this.menu2_2_panel.Controls.Add(this.menu2_2_panel_main);
            this.menu2_2_panel.Size = new System.Drawing.Size(Main.Common_Const.form_x, 580);
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
            this.menu2_2_panel_top.Size = new System.Drawing.Size(Main.Common_Const.form_x - this.menu2_2_panel_top.Location.X * 2, 32);
            // 
            // menu2_2_panel_top_button_movedown
            // 
            this.menu2_2_panel_top_button_movedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_movedown.Location = new System.Drawing.Point(0, 16);
            this.menu2_2_panel_top_button_movedown.Size = new System.Drawing.Size(16, 16);
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_movedown, "下に移動");
            this.menu2_2_panel_top_button_movedown.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_movedown.Click += new System.EventHandler(this.menu2_2_panel_top_button_movedown_Click);
            // 
            // menu2_2_panel_top_button_moveup
            // 
            this.menu2_2_panel_top_button_moveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_moveup.Location = new System.Drawing.Point(0, 0);
            this.menu2_2_panel_top_button_moveup.Size = new System.Drawing.Size(16, 16);
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_moveup, "上に移動");
            this.menu2_2_panel_top_button_moveup.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_moveup.Click += new System.EventHandler(this.menu2_2_panel_top_button_moveup_Click);
            // 
            // menu2_2_panel_top_label_title
            // 
            this.menu2_2_panel_top_label_title.Location = new System.Drawing.Point(this.menu2_2_panel_top_button_movedown.Width, 0);
            this.menu2_2_panel_top_label_title.Size = new System.Drawing.Size(30, 32);
            this.menu2_2_panel_top_label_title.Text = "メモ";
            this.menu2_2_panel_top_label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu2_2_panel_top_label_num
            // 
            this.menu2_2_panel_top_label_num.BackColor = System.Drawing.Color.Transparent;
            this.menu2_2_panel_top_label_num.CustomText = "0";
            this.menu2_2_panel_top_label_num.Location = new System.Drawing.Point(this.menu2_2_panel_top_label_title.Location.X + this.menu2_2_panel_top_label_title.Width, 0);
            this.menu2_2_panel_top_label_num.Size = new System.Drawing.Size(20, 20);
            // 
            // menu2_2_panel_top_button_openclose
            // 
            this.menu2_2_panel_top_button_openclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu2_2_panel_top_button_openclose.BackColor = System.Drawing.Color.Transparent;
            this.menu2_2_panel_top_button_openclose.FlatAppearance.BorderSize = 0;
            this.menu2_2_panel_top_button_openclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_openclose.Location = new System.Drawing.Point(this.menu2_2_panel_top_label_num.Location.X + this.menu2_2_panel_top_label_num.Width, 0);
            this.menu2_2_panel_top_button_openclose.Size = new System.Drawing.Size(32, 32);
            this.menu2_2_panel_top_button_openclose.Text = "+";
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_openclose, "開く/閉じる");
            this.menu2_2_panel_top_button_openclose.UseVisualStyleBackColor = false;
            this.menu2_2_panel_top_button_openclose.Click += new System.EventHandler(this.menu2_2_panel_top_button_openclose_Click);
            // 
            // menu2_2_panel_top_button_open
            // 
            this.menu2_2_panel_top_button_open.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_top_button_open.FlatAppearance.BorderSize = 0;
            this.menu2_2_panel_top_button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_open.Size = new System.Drawing.Size(32, 32);
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_open, "追加");
            this.menu2_2_panel_top_button_open.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_open.Click += new System.EventHandler(this.menu2_2_panel_top_button_open_Click);
            // 
            // menu2_2_panel_top_button_add
            // 
            this.menu2_2_panel_top_button_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu2_2_panel_top_button_add.FlatAppearance.BorderSize = 0;
            this.menu2_2_panel_top_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2_2_panel_top_button_add.Image = ((System.Drawing.Image)(resources.GetObject("menu2_2_panel_top_button_add.Image")));
            this.menu2_2_panel_top_button_add.Size = new System.Drawing.Size(32, 32);
            this.tooltip.SetToolTip(this.menu2_2_panel_top_button_add, "追加");
            this.menu2_2_panel_top_button_add.UseVisualStyleBackColor = true;
            this.menu2_2_panel_top_button_add.Click += new System.EventHandler(this.menu2_2_panel_top_button_add_Click);
            
            // 
            // menu2_2_panel_main
            // 
            this.menu2_2_panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu2_2_panel_main.Location = new System.Drawing.Point(1, 33);
            this.menu2_2_panel_main.Size = new System.Drawing.Size(Main.Common_Const.form_x - this.menu2_2_panel_main.Location.X * 2, 540);

            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 5000;
            this.tooltip.InitialDelay = 1000;
            this.tooltip.ReshowDelay = 100;
            // 
            // menutask
            // 
            this.menutask.BorderColor = System.Drawing.Color.Black;
            this.menutask.Controls.Add(this.menutask_button_close);
            this.menutask.Controls.Add(this.menutask_table2);
            this.menutask.Controls.Add(this.menutask_button_save);
            this.menutask.Controls.Add(this.menutask_table1);
            this.menutask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menutask.Size = new System.Drawing.Size(682, 250);
            // 
            // menutask_button_close
            // 
            this.menutask_button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menutask_button_close.FlatAppearance.BorderSize = 0;
            this.menutask_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menutask_button_close.Image = ((System.Drawing.Image)(resources.GetObject("menutask_button_close.Image")));
            this.menutask_button_close.Location = new System.Drawing.Point(649, 1);
            this.menutask_button_close.Size = new System.Drawing.Size(32, 32);
            this.menutask_button_close.UseVisualStyleBackColor = true;
            this.menutask_button_close.Click += new System.EventHandler(this.menutask_button_close_Click);
            // 
            // menutask_table2
            // 
            this.menutask_table2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menutask_table2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menutask_table2.ColumnCount = 1;
            this.menutask_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menutask_table2.Controls.Add(this.menutask_table2_label, 0, 0);
            this.menutask_table2.Controls.Add(this.menutask_table2_text, 0, 1);
            this.menutask_table2.Location = new System.Drawing.Point(14, 52);
            this.menutask_table2.RowCount = 2;
            this.menutask_table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.menutask_table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.95652F));
            this.menutask_table2.Size = new System.Drawing.Size(629, 161);
            // 
            // menutask_table2_label
            // 
            this.menutask_table2_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table2_label.Text = "備考";
            this.menutask_table2_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menutask_table2_text
            // 
            this.menutask_table2_text.AcceptsReturn = true;
            this.menutask_table2_text.AcceptsTab = true;
            this.menutask_table2_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table2_text.Margin = new System.Windows.Forms.Padding(0);
            this.menutask_table2_text.Multiline = true;
            // 
            // menutask_button_save
            // 
            this.menutask_button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menutask_button_save.Size = new System.Drawing.Size(682, 28);
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
            this.menutask_table1.Location = new System.Drawing.Point(14, 4);
            this.menutask_table1.RowCount = 1;
            this.menutask_table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menutask_table1.Size = new System.Drawing.Size(629, 38);
            // 
            // menutask_table1_label
            // 
            this.menutask_table1_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table1_label.Text = "タスク名";
            this.menutask_table1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menutask_table1_text
            // 
            this.menutask_table1_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutask_table1_text.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menutask_table1_text.Margin = new System.Windows.Forms.Padding(0);
            this.menutask_table1_text.KeyDown += new KeyEventHandler(this.menutask_table1_text_KeyDown);
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
            this.menuachieve.Size = new System.Drawing.Size(682, 0);
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
            this.menuachieve_table4.RowCount = 2;
            this.menuachieve_table4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.menuachieve_table4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.95652F));
            this.menuachieve_table4.Size = new System.Drawing.Size(629, 87);
            // 
            // menuachieve_table4_label
            // 
            this.menuachieve_table4_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table4_label.Text = "備考";
            this.menuachieve_table4_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuachieve_table4_text
            // 
            this.menuachieve_table4_text.AcceptsReturn = true;
            this.menuachieve_table4_text.AcceptsTab = true;
            this.menuachieve_table4_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table4_text.Margin = new System.Windows.Forms.Padding(0);
            this.menuachieve_table4_text.Multiline = true;
            this.menuachieve_table4_text.Size = new System.Drawing.Size(627, 69);
            // 
            // menuachieve_button_close
            // 
            this.menuachieve_button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuachieve_button_close.FlatAppearance.BorderSize = 0;
            this.menuachieve_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuachieve_button_close.Image = ((System.Drawing.Image)(resources.GetObject("menuachieve_button_close.Image")));
            this.menuachieve_button_close.Location = new System.Drawing.Point(649, 1);
            this.menuachieve_button_close.Size = new System.Drawing.Size(32, 32);
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
            this.menuachieve_table3.RowCount = 1;
            this.menuachieve_table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuachieve_table3.Size = new System.Drawing.Size(629, 26);
            // 
            // menuachieve_table3_label
            // 
            this.menuachieve_table3_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table3_label.Text = "時間";
            this.menuachieve_table3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuachieve_table3_text
            // 
            this.menuachieve_table3_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table3_text.Margin = new System.Windows.Forms.Padding(0);
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
            this.menuachieve_table2.RowCount = 1;
            this.menuachieve_table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuachieve_table2.Size = new System.Drawing.Size(629, 26);
            // 
            // menuachieve_table2_label
            // 
            this.menuachieve_table2_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table2_label.Text = "進捗";
            this.menuachieve_table2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuachieve_table2_text
            // 
            this.menuachieve_table2_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table2_text.Margin = new System.Windows.Forms.Padding(0);
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
            this.menuachieve_table1.RowCount = 1;
            this.menuachieve_table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuachieve_table1.Size = new System.Drawing.Size(629, 26);
            // 
            // menuachieve_table1_label
            // 
            this.menuachieve_table1_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table1_label.Text = "実績名";
            this.menuachieve_table1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuachieve_table1_text
            // 
            this.menuachieve_table1_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuachieve_table1_text.Margin = new System.Windows.Forms.Padding(0);
            // 
            // menuachieve_button_save
            // 
            this.menuachieve_button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuachieve_button_save.Size = new System.Drawing.Size(682, 32);
            this.menuachieve_button_save.Text = "保存";
            this.menuachieve_button_save.UseVisualStyleBackColor = true;
            this.menuachieve_button_save.Click += new System.EventHandler(this.menuachieve_button_save_Click);

            // レイアウトロジック再開 子コントロールを持つコントロール全て
            this.ResumeLayout(false);

            this.common.ResumeLayout(false);
            this.common_panel_setting.ResumeLayout(false);
            this.common_panel_setting_table_setting.ResumeLayout(false);
            this.common_panel_setting_table_setting.PerformLayout();

            this.menu1.ResumeLayout(false);
            this.menu1_panel_calender.ResumeLayout(false);
            this.menu1_panel_calender_panel_top.ResumeLayout(false);
            this.menu1_panel_calender_panel_top_panel_yearmonth.ResumeLayout(false);
            this.menu1_panel_calender_panel_main.ResumeLayout(false);
            this.menu1_panel_calender_panel_main_table_calender.ResumeLayout(false);
            for (int i = 0; i < 42; i++)
            {
                this.menu1_panel_calender_panel_main_table_calender_panel_day[i].ResumeLayout(false);
            }
            this.menu1_panel_done.ResumeLayout(false);
            this.menu1_panel_done_panel_top.ResumeLayout(false);
            this.menu1_panel_done_panel_main.ResumeLayout(false);

            this.menu2.ResumeLayout(false);

            this.menu2_1.ResumeLayout(false);
            this.menu2_1_panel.ResumeLayout(false);
            this.menu2_1_panel_top.ResumeLayout(false);
            this.menu2_1_panel_main.ResumeLayout(false);

            this.menu2_2.ResumeLayout(false);
            this.menu2_2_panel.ResumeLayout(false);
            this.menu2_2_panel_top.ResumeLayout(false);
            this.menu2_2_panel_main.ResumeLayout(false);

            this.menutask.ResumeLayout(false);
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
        }

        #endregion

        
    }
}