using System.Windows.Forms;
using System;

namespace TaskManege
{
    partial class TaskForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_table1_check_title = new System.Windows.Forms.CheckBox();
            this.p_TaskForm = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.main_button_save = new System.Windows.Forms.Button();
            this.main_table5 = new System.Windows.Forms.TableLayoutPanel();
            this.main_table5_label_title = new System.Windows.Forms.Label();
            this.main_table5_panel1 = new System.Windows.Forms.Panel();
            this.main_table5_panel1_panel11 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel10 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel9 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel8 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel7 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel6 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel5 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel4 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel3 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel2 = new TaskManege.PanelEx();
            this.main_table5_panel1_panel1 = new TaskManege.PanelEx();
            this.main_table5_panel1_picture_check = new System.Windows.Forms.PictureBox();
            this.main_table4 = new System.Windows.Forms.TableLayoutPanel();
            this.main_table4_panel1 = new System.Windows.Forms.Panel();
            this.main_table4_panel1_panel3 = new TaskManege.PanelEx();
            this.main_table4_panel1_panel3_label = new System.Windows.Forms.Label();
            this.main_table4_panel1_panel2 = new TaskManege.PanelEx();
            this.main_table4_panel1_panel2_label = new System.Windows.Forms.Label();
            this.main_table4_panel1_picture_check = new System.Windows.Forms.PictureBox();
            this.main_table4_panel1_panel1 = new TaskManege.PanelEx();
            this.main_table4_panel1_panel1_label = new System.Windows.Forms.Label();
            this.main_table4_label_title = new System.Windows.Forms.Label();
            this.main_table3 = new System.Windows.Forms.TableLayoutPanel();
            this.main_table3_label_title = new System.Windows.Forms.Label();
            this.main_table3_text1 = new System.Windows.Forms.TextBox();
            this.main_table1 = new System.Windows.Forms.TableLayoutPanel();
            this.main_table1_label_title = new System.Windows.Forms.Label();
            this.main_table1_text_name = new System.Windows.Forms.TextBox();
            this.main_table2 = new System.Windows.Forms.TableLayoutPanel();
            this.main_table2_panel_from = new System.Windows.Forms.Panel();
            this.main_table2_panel_from_combo_date = new System.Windows.Forms.ComboBox();
            this.main_table2_panel_from_combo_month = new System.Windows.Forms.ComboBox();
            this.main_table2_panel_from_combo_year = new System.Windows.Forms.ComboBox();
            this.main_table2_panel_to = new System.Windows.Forms.Panel();
            this.main_table2_panel_to_combo_date = new System.Windows.Forms.ComboBox();
            this.main_table2_panel_to_combo_month = new System.Windows.Forms.ComboBox();
            this.main_table2_panel_to_combo_year = new System.Windows.Forms.ComboBox();
            this.p_TaskForm.SuspendLayout();
            this.main.SuspendLayout();
            this.main_table5.SuspendLayout();
            this.main_table5_panel1.SuspendLayout();
            this.main_table5_panel1_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_table5_panel1_picture_check)).BeginInit();
            this.main_table4.SuspendLayout();
            this.main_table4_panel1.SuspendLayout();
            this.main_table4_panel1_panel3.SuspendLayout();
            this.main_table4_panel1_panel2.SuspendLayout();
            this.main_table4_panel1_panel2_label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_table4_panel1_picture_check)).BeginInit();
            this.main_table4_panel1_panel1.SuspendLayout();
            this.main_table3.SuspendLayout();
            this.main_table1.SuspendLayout();
            this.main_table2.SuspendLayout();
            this.main_table2_panel_from.SuspendLayout();
            this.main_table2_panel_to.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_table1_check_title
            // 
            this.main_table1_check_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_table1_check_title.AutoSize = true;
            this.main_table1_check_title.Location = new System.Drawing.Point(4, 11);
            this.main_table1_check_title.Name = "main_table1_check_title";
            this.main_table1_check_title.Size = new System.Drawing.Size(50, 19);
            this.main_table1_check_title.TabIndex = 2;
            this.main_table1_check_title.Text = "期間";
            this.main_table1_check_title.UseVisualStyleBackColor = true;
            // 
            // p_TaskForm
            // 
            this.p_TaskForm.Controls.Add(this.main);
            this.p_TaskForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_TaskForm.Location = new System.Drawing.Point(0, 0);
            this.p_TaskForm.Name = "p_TaskForm";
            this.p_TaskForm.Size = new System.Drawing.Size(540, 480);
            this.p_TaskForm.TabIndex = 1;
            // 
            // main
            // 
            this.main.Controls.Add(this.main_button_save);
            this.main.Controls.Add(this.main_table5);
            this.main.Controls.Add(this.main_table4);
            this.main.Controls.Add(this.main_table3);
            this.main.Controls.Add(this.main_table1);
            this.main.Controls.Add(this.main_table2);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(540, 480);
            this.main.TabIndex = 1;
            // 
            // main_button_save
            // 
            this.main_button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main_button_save.Location = new System.Drawing.Point(0, 443);
            this.main_button_save.Name = "main_button_save";
            this.main_button_save.Size = new System.Drawing.Size(540, 37);
            this.main_button_save.TabIndex = 5;
            this.main_button_save.Text = "保存/Save";
            this.main_button_save.UseVisualStyleBackColor = true;
            this.main_button_save.Click += new System.EventHandler(this.main_button_save_Click);
            // 
            // main_table5
            // 
            this.main_table5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_table5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.main_table5.ColumnCount = 2;
            this.main_table5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.main_table5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 478F));
            this.main_table5.Controls.Add(this.main_table5_label_title, 0, 0);
            this.main_table5.Controls.Add(this.main_table5_panel1, 1, 0);
            this.main_table5.Location = new System.Drawing.Point(3, 401);
            this.main_table5.Name = "main_table5";
            this.main_table5.RowCount = 1;
            this.main_table5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.main_table5.Size = new System.Drawing.Size(534, 38);
            this.main_table5.TabIndex = 1;
            // 
            // main_table5_label_title
            // 
            this.main_table5_label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_table5_label_title.AutoSize = true;
            this.main_table5_label_title.Location = new System.Drawing.Point(19, 11);
            this.main_table5_label_title.Name = "main_table5_label_title";
            this.main_table5_label_title.Size = new System.Drawing.Size(19, 15);
            this.main_table5_label_title.TabIndex = 0;
            this.main_table5_label_title.Text = "色";
            // 
            // main_table5_panel1
            // 
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel11);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel10);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel9);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel8);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel7);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel6);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel5);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel4);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel3);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel2);
            this.main_table5_panel1.Controls.Add(this.main_table5_panel1_panel1);
            this.main_table5_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table5_panel1.Location = new System.Drawing.Point(58, 1);
            this.main_table5_panel1.Margin = new System.Windows.Forms.Padding(0);
            this.main_table5_panel1.Name = "main_table5_panel1";
            this.main_table5_panel1.Size = new System.Drawing.Size(475, 36);
            this.main_table5_panel1.TabIndex = 1;
            // 
            // main_table5_panel1_panel11
            // 
            this.main_table5_panel1_panel11.BackColor = System.Drawing.Color.Purple;
            this.main_table5_panel1_panel11.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel11.Location = new System.Drawing.Point(342, 2);
            this.main_table5_panel1_panel11.Name = "main_table5_panel1_panel11";
            this.main_table5_panel1_panel11.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel11.TabIndex = 10;
            this.main_table5_panel1_panel11.Click += new System.EventHandler(this.main_panel5_panel1_panel11_Click);
            // 
            // main_table5_panel1_panel10
            // 
            this.main_table5_panel1_panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.main_table5_panel1_panel10.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel10.Location = new System.Drawing.Point(308, 2);
            this.main_table5_panel1_panel10.Name = "main_table5_panel1_panel10";
            this.main_table5_panel1_panel10.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel10.TabIndex = 9;
            this.main_table5_panel1_panel10.Click += new System.EventHandler(this.main_panel5_panel1_panel10_Click);
            // 
            // main_table5_panel1_panel9
            // 
            this.main_table5_panel1_panel9.BackColor = System.Drawing.Color.Blue;
            this.main_table5_panel1_panel9.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel9.Location = new System.Drawing.Point(274, 2);
            this.main_table5_panel1_panel9.Name = "main_table5_panel1_panel9";
            this.main_table5_panel1_panel9.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel9.TabIndex = 8;
            this.main_table5_panel1_panel9.Click += new System.EventHandler(this.main_panel5_panel1_panel9_Click);
            // 
            // main_table5_panel1_panel8
            // 
            this.main_table5_panel1_panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.main_table5_panel1_panel8.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel8.Location = new System.Drawing.Point(240, 2);
            this.main_table5_panel1_panel8.Name = "main_table5_panel1_panel8";
            this.main_table5_panel1_panel8.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel8.TabIndex = 7;
            this.main_table5_panel1_panel8.Click += new System.EventHandler(this.main_panel5_panel1_panel8_Click);
            // 
            // main_table5_panel1_panel7
            // 
            this.main_table5_panel1_panel7.BackColor = System.Drawing.Color.Aqua;
            this.main_table5_panel1_panel7.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel7.Location = new System.Drawing.Point(206, 2);
            this.main_table5_panel1_panel7.Name = "main_table5_panel1_panel7";
            this.main_table5_panel1_panel7.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel7.TabIndex = 6;
            this.main_table5_panel1_panel7.Click += new System.EventHandler(this.main_panel5_panel1_panel7_Click);
            // 
            // main_table5_panel1_panel6
            // 
            this.main_table5_panel1_panel6.BackColor = System.Drawing.Color.Lime;
            this.main_table5_panel1_panel6.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel6.Location = new System.Drawing.Point(172, 2);
            this.main_table5_panel1_panel6.Name = "main_table5_panel1_panel6";
            this.main_table5_panel1_panel6.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel6.TabIndex = 5;
            this.main_table5_panel1_panel6.Click += new System.EventHandler(this.main_panel5_panel1_panel6_Click);
            // 
            // main_table5_panel1_panel5
            // 
            this.main_table5_panel1_panel5.BackColor = System.Drawing.Color.Yellow;
            this.main_table5_panel1_panel5.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel5.Location = new System.Drawing.Point(138, 2);
            this.main_table5_panel1_panel5.Name = "main_table5_panel1_panel5";
            this.main_table5_panel1_panel5.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel5.TabIndex = 4;
            this.main_table5_panel1_panel5.Click += new System.EventHandler(this.main_panel5_panel1_panel5_Click);
            // 
            // main_table5_panel1_panel4
            // 
            this.main_table5_panel1_panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.main_table5_panel1_panel4.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel4.Location = new System.Drawing.Point(104, 2);
            this.main_table5_panel1_panel4.Name = "main_table5_panel1_panel4";
            this.main_table5_panel1_panel4.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel4.TabIndex = 3;
            this.main_table5_panel1_panel4.Click += new System.EventHandler(this.main_panel5_panel1_panel4_Click);
            // 
            // main_table5_panel1_panel3
            // 
            this.main_table5_panel1_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.main_table5_panel1_panel3.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel3.Location = new System.Drawing.Point(70, 2);
            this.main_table5_panel1_panel3.Name = "main_table5_panel1_panel3";
            this.main_table5_panel1_panel3.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel3.TabIndex = 2;
            this.main_table5_panel1_panel3.Click += new System.EventHandler(this.main_panel5_panel1_panel3_Click);
            // 
            // main_table5_panel1_panel2
            // 
            this.main_table5_panel1_panel2.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel2.Location = new System.Drawing.Point(36, 2);
            this.main_table5_panel1_panel2.Name = "main_table5_panel1_panel2";
            this.main_table5_panel1_panel2.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel2.TabIndex = 1;
            this.main_table5_panel1_panel2.Click += new System.EventHandler(this.main_panel5_panel1_panel2_Click);
            // 
            // main_table5_panel1_panel1
            // 
            this.main_table5_panel1_panel1.BorderColor = System.Drawing.Color.Black;
            this.main_table5_panel1_panel1.Controls.Add(this.main_table5_panel1_picture_check);
            this.main_table5_panel1_panel1.Location = new System.Drawing.Point(2, 2);
            this.main_table5_panel1_panel1.Name = "main_table5_panel1_panel1";
            this.main_table5_panel1_panel1.Size = new System.Drawing.Size(32, 32);
            this.main_table5_panel1_panel1.TabIndex = 0;
            this.main_table5_panel1_panel1.Click += new System.EventHandler(this.main_panel5_panel1_panel1_Click);
            // 
            // main_table5_panel1_picture_check
            // 
            this.main_table5_panel1_picture_check.BackColor = System.Drawing.Color.Transparent;
            this.main_table5_panel1_picture_check.Location = new System.Drawing.Point(1, 1);
            this.main_table5_panel1_picture_check.Name = "main_table5_panel1_picture_check";
            this.main_table5_panel1_picture_check.Size = new System.Drawing.Size(30, 30);
            this.main_table5_panel1_picture_check.TabIndex = 11;
            this.main_table5_panel1_picture_check.TabStop = false;
            // 
            // main_table4
            // 
            this.main_table4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_table4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.main_table4.ColumnCount = 2;
            this.main_table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.main_table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 478F));
            this.main_table4.Controls.Add(this.main_table4_panel1, 0, 0);
            this.main_table4.Controls.Add(this.main_table4_label_title, 0, 0);
            this.main_table4.Location = new System.Drawing.Point(3, 357);
            this.main_table4.Name = "main_table4";
            this.main_table4.RowCount = 1;
            this.main_table4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table4.Size = new System.Drawing.Size(534, 38);
            this.main_table4.TabIndex = 1;
            // 
            // main_table4_panel1
            // 
            this.main_table4_panel1.Controls.Add(this.main_table4_panel1_panel3);
            this.main_table4_panel1.Controls.Add(this.main_table4_panel1_panel2);
            this.main_table4_panel1.Controls.Add(this.main_table4_panel1_panel1);
            this.main_table4_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table4_panel1.Location = new System.Drawing.Point(58, 1);
            this.main_table4_panel1.Margin = new System.Windows.Forms.Padding(0);
            this.main_table4_panel1.Name = "main_table4_panel1";
            this.main_table4_panel1.Size = new System.Drawing.Size(475, 36);
            this.main_table4_panel1.TabIndex = 2;
            // 
            // main_table4_panel1_panel3
            // 
            this.main_table4_panel1_panel3.BorderColor = System.Drawing.Color.Black;
            this.main_table4_panel1_panel3.Controls.Add(this.main_table4_panel1_panel3_label);
            this.main_table4_panel1_panel3.Location = new System.Drawing.Point(70, 2);
            this.main_table4_panel1_panel3.Name = "main_table4_panel1_panel3";
            this.main_table4_panel1_panel3.Size = new System.Drawing.Size(32, 32);
            this.main_table4_panel1_panel3.TabIndex = 2;
            // 
            // main_table4_panel1_panel3_label
            // 
            this.main_table4_panel1_panel3_label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.main_table4_panel1_panel3_label.Location = new System.Drawing.Point(1, 1);
            this.main_table4_panel1_panel3_label.Name = "main_table4_panel1_panel3_label";
            this.main_table4_panel1_panel3_label.Size = new System.Drawing.Size(30, 30);
            this.main_table4_panel1_panel3_label.TabIndex = 5;
            this.main_table4_panel1_panel3_label.Text = "3";
            this.main_table4_panel1_panel3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_table4_panel1_panel3_label.Click += new System.EventHandler(this.main_table4_panel1_panel3_label_Click);
            // 
            // main_table4_panel1_panel2
            // 
            this.main_table4_panel1_panel2.BorderColor = System.Drawing.Color.Black;
            this.main_table4_panel1_panel2.Controls.Add(this.main_table4_panel1_panel2_label);
            this.main_table4_panel1_panel2.Location = new System.Drawing.Point(36, 2);
            this.main_table4_panel1_panel2.Name = "main_table4_panel1_panel2";
            this.main_table4_panel1_panel2.Size = new System.Drawing.Size(32, 32);
            this.main_table4_panel1_panel2.TabIndex = 1;
            // 
            // main_table4_panel1_panel2_label
            // 
            this.main_table4_panel1_panel2_label.Controls.Add(this.main_table4_panel1_picture_check);
            this.main_table4_panel1_panel2_label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.main_table4_panel1_panel2_label.Location = new System.Drawing.Point(1, 1);
            this.main_table4_panel1_panel2_label.Name = "main_table4_panel1_panel2_label";
            this.main_table4_panel1_panel2_label.Size = new System.Drawing.Size(30, 30);
            this.main_table4_panel1_panel2_label.TabIndex = 4;
            this.main_table4_panel1_panel2_label.Text = "2";
            this.main_table4_panel1_panel2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_table4_panel1_panel2_label.Click += new System.EventHandler(this.main_table4_panel1_panel2_label_Click);
            // 
            // main_table4_panel1_picture_check
            // 
            this.main_table4_panel1_picture_check.BackColor = System.Drawing.Color.Transparent;
            this.main_table4_panel1_picture_check.Location = new System.Drawing.Point(0, 0);
            this.main_table4_panel1_picture_check.Name = "main_table4_panel1_picture_check";
            this.main_table4_panel1_picture_check.Size = new System.Drawing.Size(30, 30);
            this.main_table4_panel1_picture_check.TabIndex = 12;
            this.main_table4_panel1_picture_check.TabStop = false;
            // 
            // main_table4_panel1_panel1
            // 
            this.main_table4_panel1_panel1.BorderColor = System.Drawing.Color.Black;
            this.main_table4_panel1_panel1.Controls.Add(this.main_table4_panel1_panel1_label);
            this.main_table4_panel1_panel1.Location = new System.Drawing.Point(2, 2);
            this.main_table4_panel1_panel1.Name = "main_table4_panel1_panel1";
            this.main_table4_panel1_panel1.Size = new System.Drawing.Size(32, 32);
            this.main_table4_panel1_panel1.TabIndex = 0;
            // 
            // main_table4_panel1_panel1_label
            // 
            this.main_table4_panel1_panel1_label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.main_table4_panel1_panel1_label.Location = new System.Drawing.Point(1, 1);
            this.main_table4_panel1_panel1_label.Name = "main_table4_panel1_panel1_label";
            this.main_table4_panel1_panel1_label.Size = new System.Drawing.Size(30, 30);
            this.main_table4_panel1_panel1_label.TabIndex = 3;
            this.main_table4_panel1_panel1_label.Text = "1";
            this.main_table4_panel1_panel1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_table4_panel1_panel1_label.Click += new System.EventHandler(this.main_table4_panel1_panel1_label_Click);
            // 
            // main_table4_label_title
            // 
            this.main_table4_label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_table4_label_title.AutoSize = true;
            this.main_table4_label_title.Location = new System.Drawing.Point(7, 11);
            this.main_table4_label_title.Name = "main_table4_label_title";
            this.main_table4_label_title.Size = new System.Drawing.Size(43, 15);
            this.main_table4_label_title.TabIndex = 0;
            this.main_table4_label_title.Text = "優先度";
            // 
            // main_table3
            // 
            this.main_table3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_table3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.main_table3.ColumnCount = 1;
            this.main_table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table3.Controls.Add(this.main_table3_label_title, 0, 0);
            this.main_table3.Controls.Add(this.main_table3_text1, 0, 1);
            this.main_table3.Location = new System.Drawing.Point(3, 95);
            this.main_table3.MinimumSize = new System.Drawing.Size(534, 200);
            this.main_table3.Name = "main_table3";
            this.main_table3.RowCount = 2;
            this.main_table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.main_table3.Size = new System.Drawing.Size(534, 256);
            this.main_table3.TabIndex = 1;
            // 
            // main_table3_label_title
            // 
            this.main_table3_label_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.main_table3_label_title.AutoSize = true;
            this.main_table3_label_title.Location = new System.Drawing.Point(4, 5);
            this.main_table3_label_title.Name = "main_table3_label_title";
            this.main_table3_label_title.Size = new System.Drawing.Size(31, 15);
            this.main_table3_label_title.TabIndex = 0;
            this.main_table3_label_title.Text = "備考";
            // 
            // main_table3_text1
            // 
            this.main_table3_text1.AcceptsReturn = true;
            this.main_table3_text1.AcceptsTab = true;
            this.main_table3_text1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table3_text1.Location = new System.Drawing.Point(1, 25);
            this.main_table3_text1.Margin = new System.Windows.Forms.Padding(0);
            this.main_table3_text1.Multiline = true;
            this.main_table3_text1.Name = "main_table3_text1";
            this.main_table3_text1.Size = new System.Drawing.Size(532, 230);
            this.main_table3_text1.TabIndex = 1;
            // 
            // main_table1
            // 
            this.main_table1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.main_table1.ColumnCount = 2;
            this.main_table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.main_table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 478F));
            this.main_table1.Controls.Add(this.main_table1_label_title, 0, 0);
            this.main_table1.Controls.Add(this.main_table1_text_name, 1, 0);
            this.main_table1.Location = new System.Drawing.Point(3, 3);
            this.main_table1.Name = "main_table1";
            this.main_table1.RowCount = 1;
            this.main_table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table1.Size = new System.Drawing.Size(534, 38);
            this.main_table1.TabIndex = 1;
            // 
            // main_table1_label_title
            // 
            this.main_table1_label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_table1_label_title.AutoSize = true;
            this.main_table1_label_title.Location = new System.Drawing.Point(6, 11);
            this.main_table1_label_title.Name = "main_table1_label_title";
            this.main_table1_label_title.Size = new System.Drawing.Size(46, 15);
            this.main_table1_label_title.TabIndex = 0;
            this.main_table1_label_title.Text = "タスク名";
            // 
            // main_table1_text_name
            // 
            this.main_table1_text_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_table1_text_name.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.main_table1_text_name.Location = new System.Drawing.Point(58, 1);
            this.main_table1_text_name.Margin = new System.Windows.Forms.Padding(0);
            this.main_table1_text_name.Name = "main_table1_text_name";
            this.main_table1_text_name.Size = new System.Drawing.Size(475, 35);
            this.main_table1_text_name.TabIndex = 1;
            // 
            // main_table2
            // 
            this.main_table2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_table2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.main_table2.ColumnCount = 4;
            this.main_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.main_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 180F));
            this.main_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.main_table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 180F));
            this.main_table2.Controls.Add(this.main_table1_check_title, 0, 0);
            this.main_table2.Controls.Add(this.main_table2_panel_from, 1, 0);
            this.main_table2.Controls.Add(this.main_table2_panel_to, 3, 0);
            this.main_table2.Location = new System.Drawing.Point(3, 47);
            this.main_table2.Name = "main_table2";
            this.main_table2.RowCount = 1;
            this.main_table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_table2.Size = new System.Drawing.Size(534, 42);
            this.main_table2.TabIndex = 1;
            // 
            // main_table2_panel_from
            // 
            this.main_table2_panel_from.Controls.Add(this.main_table2_panel_from_combo_date);
            this.main_table2_panel_from.Controls.Add(this.main_table2_panel_from_combo_month);
            this.main_table2_panel_from.Controls.Add(this.main_table2_panel_from_combo_year);
            this.main_table2_panel_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table2_panel_from.Location = new System.Drawing.Point(58, 1);
            this.main_table2_panel_from.Margin = new System.Windows.Forms.Padding(0);
            this.main_table2_panel_from.Name = "main_table2_panel_from";
            this.main_table2_panel_from.Size = new System.Drawing.Size(226, 40);
            this.main_table2_panel_from.TabIndex = 4;
            // 
            // main_table2_panel_from_combo_date
            // 
            this.main_table2_panel_from_combo_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_table2_panel_from_combo_date.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_table2_panel_from_combo_date.FormattingEnabled = true;
            this.main_table2_panel_from_combo_date.ItemHeight = 30;
            this.main_table2_panel_from_combo_date.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.main_table2_panel_from_combo_date.Location = new System.Drawing.Point(132, 0);
            this.main_table2_panel_from_combo_date.Name = "main_table2_panel_from_combo_date";
            this.main_table2_panel_from_combo_date.Size = new System.Drawing.Size(47, 38);
            this.main_table2_panel_from_combo_date.TabIndex = 5;
            // 
            // main_table2_panel_from_combo_month
            // 
            this.main_table2_panel_from_combo_month.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_table2_panel_from_combo_month.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_table2_panel_from_combo_month.FormattingEnabled = true;
            this.main_table2_panel_from_combo_month.ItemHeight = 30;
            this.main_table2_panel_from_combo_month.Items.AddRange(new object[] {
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
            this.main_table2_panel_from_combo_month.Location = new System.Drawing.Point(85, 0);
            this.main_table2_panel_from_combo_month.Name = "main_table2_panel_from_combo_month";
            this.main_table2_panel_from_combo_month.Size = new System.Drawing.Size(47, 38);
            this.main_table2_panel_from_combo_month.TabIndex = 4;
            // 
            // main_table2_panel_from_combo_year
            // 
            this.main_table2_panel_from_combo_year.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_table2_panel_from_combo_year.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_table2_panel_from_combo_year.FormattingEnabled = true;
            this.main_table2_panel_from_combo_year.ItemHeight = 30;
            this.main_table2_panel_from_combo_year.Location = new System.Drawing.Point(0, 0);
            this.main_table2_panel_from_combo_year.Name = "main_table2_panel_from_combo_year";
            this.main_table2_panel_from_combo_year.Size = new System.Drawing.Size(85, 38);
            this.main_table2_panel_from_combo_year.TabIndex = 3;
            // 
            // main_table2_panel_to
            // 
            this.main_table2_panel_to.Controls.Add(this.main_table2_panel_to_combo_date);
            this.main_table2_panel_to.Controls.Add(this.main_table2_panel_to_combo_month);
            this.main_table2_panel_to.Controls.Add(this.main_table2_panel_to_combo_year);
            this.main_table2_panel_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table2_panel_to.Location = new System.Drawing.Point(306, 1);
            this.main_table2_panel_to.Margin = new System.Windows.Forms.Padding(0);
            this.main_table2_panel_to.Name = "main_table2_panel_to";
            this.main_table2_panel_to.Size = new System.Drawing.Size(227, 40);
            this.main_table2_panel_to.TabIndex = 5;
            // 
            // main_table2_panel_to_combo_date
            // 
            this.main_table2_panel_to_combo_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_table2_panel_to_combo_date.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_table2_panel_to_combo_date.FormattingEnabled = true;
            this.main_table2_panel_to_combo_date.ItemHeight = 30;
            this.main_table2_panel_to_combo_date.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.main_table2_panel_to_combo_date.Location = new System.Drawing.Point(132, 0);
            this.main_table2_panel_to_combo_date.Name = "main_table2_panel_to_combo_date";
            this.main_table2_panel_to_combo_date.Size = new System.Drawing.Size(47, 38);
            this.main_table2_panel_to_combo_date.TabIndex = 8;
            // 
            // main_table2_panel_to_combo_month
            // 
            this.main_table2_panel_to_combo_month.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_table2_panel_to_combo_month.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_table2_panel_to_combo_month.FormattingEnabled = true;
            this.main_table2_panel_to_combo_month.ItemHeight = 30;
            this.main_table2_panel_to_combo_month.Items.AddRange(new object[] {
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
            this.main_table2_panel_to_combo_month.Location = new System.Drawing.Point(85, 0);
            this.main_table2_panel_to_combo_month.Name = "main_table2_panel_to_combo_month";
            this.main_table2_panel_to_combo_month.Size = new System.Drawing.Size(47, 38);
            this.main_table2_panel_to_combo_month.TabIndex = 7;
            // 
            // main_table2_panel_to_combo_year
            // 
            this.main_table2_panel_to_combo_year.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_table2_panel_to_combo_year.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_table2_panel_to_combo_year.FormattingEnabled = true;
            this.main_table2_panel_to_combo_year.ItemHeight = 30;
            this.main_table2_panel_to_combo_year.Location = new System.Drawing.Point(0, 0);
            this.main_table2_panel_to_combo_year.Name = "main_table2_panel_to_combo_year";
            this.main_table2_panel_to_combo_year.Size = new System.Drawing.Size(85, 38);
            this.main_table2_panel_to_combo_year.TabIndex = 6;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 480);
            this.Controls.Add(this.p_TaskForm);
            this.Name = "TaskForm";
            this.Text = "タスク";
            this.p_TaskForm.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main_table5.ResumeLayout(false);
            this.main_table5.PerformLayout();
            this.main_table5_panel1.ResumeLayout(false);
            this.main_table5_panel1_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_table5_panel1_picture_check)).EndInit();
            this.main_table4.ResumeLayout(false);
            this.main_table4.PerformLayout();
            this.main_table4_panel1.ResumeLayout(false);
            this.main_table4_panel1_panel3.ResumeLayout(false);
            this.main_table4_panel1_panel2.ResumeLayout(false);
            this.main_table4_panel1_panel2_label.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_table4_panel1_picture_check)).EndInit();
            this.main_table4_panel1_panel1.ResumeLayout(false);
            this.main_table3.ResumeLayout(false);
            this.main_table3.PerformLayout();
            this.main_table1.ResumeLayout(false);
            this.main_table1.PerformLayout();
            this.main_table2.ResumeLayout(false);
            this.main_table2.PerformLayout();
            this.main_table2_panel_from.ResumeLayout(false);
            this.main_table2_panel_to.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void TaskForm_Load()
        {
            Set_YearMonthDay();
        }

        // カレンダーの年、月をセット
        private void Set_YearMonthDay()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            string[] years = new string[5];

            years[0] = DateTime.Now.AddYears(-2).Year.ToString();
            years[1] = DateTime.Now.AddYears(-1).Year.ToString();
            years[2] = DateTime.Now.Year.ToString();
            years[3] = DateTime.Now.AddYears(1).Year.ToString();
            years[4] = DateTime.Now.AddYears(2).Year.ToString();

            this.main_table2_panel_from_combo_year.Items.AddRange(years);
            this.main_table2_panel_from_combo_year.SelectedItem = year.ToString();
            this.main_table2_panel_from_combo_month.SelectedItem = month.ToString();
            this.main_table2_panel_from_combo_date.SelectedItem = day.ToString();
            this.main_table2_panel_to_combo_year.Items.AddRange(years);
            this.main_table2_panel_to_combo_year.SelectedItem = year.ToString();
            this.main_table2_panel_to_combo_month.SelectedItem = month.ToString();
            this.main_table2_panel_to_combo_date.SelectedItem = day.ToString();
        }

        private void Set_YearMonthDayTo(int year, int month, int day)
        {
            this.main_table2_panel_to_combo_year.SelectedItem = year.ToString();
            this.main_table2_panel_to_combo_month.SelectedItem = month.ToString();
            this.main_table2_panel_to_combo_date.SelectedItem = day.ToString();
        }

        private void Set_ColorCheck(int panel)
        {
            this.main_table5_panel1_panel1.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel2.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel3.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel4.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel5.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel6.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel7.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel8.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel9.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel10.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_panel11.Controls.Remove(main_table5_panel1_picture_check);
            this.main_table5_panel1_picture_check.Location = new System.Drawing.Point(1, 1);
            switch (panel)
            {
                case 1:
                    this.main_table5_panel1_panel1.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 2:
                    this.main_table5_panel1_panel2.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 3:
                    this.main_table5_panel1_panel3.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 4:
                    this.main_table5_panel1_panel4.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 5:
                    this.main_table5_panel1_panel5.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 6:
                    this.main_table5_panel1_panel6.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 7:
                    this.main_table5_panel1_panel7.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 8:
                    this.main_table5_panel1_panel8.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 9:
                    this.main_table5_panel1_panel9.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 10:
                    this.main_table5_panel1_panel10.Controls.Add(main_table5_panel1_picture_check);
                    break;
                case 11:
                    this.main_table5_panel1_panel11.Controls.Add(main_table5_panel1_picture_check);
                    break;
            }
            this.main_table5_panel1_picture_check.Refresh();
        }

        private void Set_PrioCheck(int prio)
        {
            this.main_table4_panel1_panel1.Controls.Remove(main_table4_panel1_picture_check);
            this.main_table4_panel1_panel2.Controls.Remove(main_table4_panel1_picture_check);
            this.main_table4_panel1_panel3.Controls.Remove(main_table4_panel1_picture_check);
            this.main_table4_panel1_picture_check.Location = new System.Drawing.Point(0, 0);
            switch (prio)
            {
                case 1:
                    this.main_table4_panel1_panel1_label.Controls.Add(main_table4_panel1_picture_check);
                    break;
                case 2:
                    this.main_table4_panel1_panel2_label.Controls.Add(main_table4_panel1_picture_check);
                    break;
                case 3:
                    this.main_table4_panel1_panel3_label.Controls.Add(main_table4_panel1_picture_check);
                    break;
            }
        }

        private CheckBox main_table1_check_title;
        private Panel p_TaskForm;
        private Panel main;
        private TableLayoutPanel main_table1;
        private Label main_table1_label_title;
        private TableLayoutPanel main_table2;
        private TableLayoutPanel main_table3;
        private Label main_table3_label_title;
        private TextBox main_table3_text1;
        private TableLayoutPanel main_table4;
        private Label main_table4_label_title;
        private TableLayoutPanel main_table5;
        private Label main_table5_label_title;
        private Button main_button_save;
        private TextBox main_table1_text_name;
        private Panel main_table2_panel_from;
        private Panel main_table2_panel_to;
        private ComboBox main_table2_panel_to_combo_date;
        private ComboBox main_table2_panel_from_combo_date;
        private ComboBox main_table2_panel_from_combo_month;
        private ComboBox main_table2_panel_from_combo_year;
        private ComboBox main_table2_panel_to_combo_month;
        private ComboBox main_table2_panel_to_combo_year;
        private Panel main_table5_panel1;
        private PanelEx main_table5_panel1_panel1;
        private PanelEx main_table5_panel1_panel11;
        private PanelEx main_table5_panel1_panel10;
        private PanelEx main_table5_panel1_panel9;
        private PanelEx main_table5_panel1_panel8;
        private PanelEx main_table5_panel1_panel7;
        private PanelEx main_table5_panel1_panel6;
        private PanelEx main_table5_panel1_panel5;
        private PanelEx main_table5_panel1_panel4;
        private PanelEx main_table5_panel1_panel3;
        private PanelEx main_table5_panel1_panel2;
        private Panel main_table4_panel1;
        private Label main_table4_panel1_panel1_label;
        private PanelEx main_table4_panel1_panel3;
        private PanelEx main_table4_panel1_panel2;
        private PanelEx main_table4_panel1_panel1;
        private Label main_table4_panel1_panel2_label;
        private Label main_table4_panel1_panel3_label;
        private PictureBox main_table5_panel1_picture_check;
        private PictureBox main_table4_panel1_picture_check;
    }
}