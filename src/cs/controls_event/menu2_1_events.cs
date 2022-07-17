using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu2_1_events
    {
        MainForm form;

        // コンストラクタ
        public menu2_1_events(MainForm form)
        {
            this.form = form;
        }

        // ********** form event **********
        #region form event
        // menu2 panel1を開いたり閉じたりする時の動作
        public static void menu2_1_panel_top_button_openclose_Click(object sender, EventArgs e, MainForm form)
        {
            if (form.menu2_1_panel_main.Visible == false)
            {
                form.menu2_1_panel_main.Visible = true;
                if (Main.Common_Var.menu2_1_task != 0)
                {
                    form.menu2_1_panel.Height = 34 + 36 * Main.Common_Var.menu2_1_task;
                    form.menu2_1.Height = 42 + 36 * Main.Common_Var.menu2_1_task;
                }
                else
                {
                    form.menu2_1_panel.Height = 34 + 36;
                    form.menu2_1.Height = 42 + 36;
                }
                Properties.Settings.Default.menu2_open1 = true;
            }
            else
            {
                form.menu2_1_panel_main.Visible = false;
                form.menu2_1_panel.Height = 34;
                form.menu2_1.Height = 42;
                Properties.Settings.Default.menu2_open1 = false;
            }
            Properties.Settings.Default.Save();
        }

        // 要素順を入れ替える
        public static void menu2_1_panel_top_button_moveup_Click(object sender, EventArgs e, MainForm form)
        {
            int order_num = -1;

            for (int i = 0; i < Main.Common_Const.menu2_num; i++)
            {
                if (Properties.Settings.Default.order[i] == "1")
                {
                    order_num = i;
                    break;
                }
            }
            if (!(order_num <= 0))
            {
                string tmp;
                // 入れ替え
                tmp = Properties.Settings.Default.order[order_num - 1];
                Properties.Settings.Default.order[order_num - 1] = Properties.Settings.Default.order[order_num];
                Properties.Settings.Default.order[order_num] = tmp;

                Properties.Settings.Default.Save();

                menu2_events.RefrectMoveControl(form);
            }
        }
        public static void menu2_1_panel_top_button_movedown_Click(object sender, EventArgs e, MainForm form)
        {
            int order_num = -1;

            for (int i = 0; i < Main.Common_Const.menu2_num; i++)
            {
                if (Properties.Settings.Default.order[i] == "1")
                {
                    order_num = i;
                    break;
                }
            }
            if (!(order_num >= Main.Common_Const.menu2_num - 1))
            {
                string tmp;
                // 入れ替え
                tmp = Properties.Settings.Default.order[order_num + 1];
                Properties.Settings.Default.order[order_num + 1] = Properties.Settings.Default.order[order_num];
                Properties.Settings.Default.order[order_num] = tmp;

                Properties.Settings.Default.Save();

                menu2_events.RefrectMoveControl(form);
            }
        }

        // menu2 panel1のタスクを追加するボタン
        public static void menu2_1_panel_top_button_add_Click(object sender, EventArgs e, MainForm form)
        {
            OpenTask(form, Main.Common_Var.menu2_1_task);
        }

        // タスクホバー時
        public void menu2_1_panel_main_panel_MouseEnter(object sender, EventArgs e)
        {
            form.menu2_1_panel_main_panel[int.Parse(((PanelEx)sender).Name)].BorderColor = Color.Green;
            form.menu2_1_panel_main_panel[int.Parse(((PanelEx)sender).Name)].Refresh();
        }
        public void menu2_1_panel_main_panel_label1_MouseEnter(object sender, EventArgs e)
        {
            form.menu2_1_panel_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Green;
            form.menu2_1_panel_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        // タスクホバーが離れた時
        public void menu2_1_panel_main_panel_MouseLeave(object sender, EventArgs e)
        {
            form.menu2_1_panel_main_panel[int.Parse(((PanelEx)sender).Name)].BorderColor = Color.Black;
            form.menu2_1_panel_main_panel[int.Parse(((PanelEx)sender).Name)].Refresh();
        }
        public void menu2_1_panel_main_panel_label1_MouseLeave(object sender, EventArgs e)
        {
            form.menu2_1_panel_main_panel[int.Parse(((Label)sender).Name)].BorderColor = Color.Black;
            form.menu2_1_panel_main_panel[int.Parse(((Label)sender).Name)].Refresh();
        }
        // タスク削除ボタンホバー時
        public void menu2_1_panel_main_panel_button_delete_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu2_1_panel_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 255, 128, 128);
                form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Green;
                form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
            }
        }
        // タスク削除ボタンホバーが離れた時
        public void menu2_1_panel_main_panel_button_delete_MouseLeave(object sender, EventArgs e)
        {
            if (int.Parse(((Button)sender).Name) >= 0)
            {
                form.menu2_1_panel_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
                form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
                form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
            }
        }
        // タスク完了ボタンホバー時
        public void menu2_1_panel_main_panel_button_finish_MouseEnter(object sender, EventArgs e)
        {
            Debug.WriteLine("enter:" + ((Button)sender).Name);
            form.menu2_1_panel_main_panel_button_finish[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 128, 255, 128);
            form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Green;
            form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
        }
        // タスク完了ボタンホバーが離れた時
        public void menu2_1_panel_main_panel_button_finish_MouseLeave(object sender, EventArgs e)
        {
            form.menu2_1_panel_main_panel_button_finish[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
            form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].BorderColor = Color.Black;
            form.menu2_1_panel_main_panel[int.Parse(((Button)sender).Name)].Refresh();
        }
        //タスク完了ボタン
        public void menu2_1_panel_main_panel_button_finish_Click(object sender, EventArgs e)
        {

        }
        //タスク削除ボタン
        public void menu2_1_panel_main_panel_button_delete_Click(object sender, EventArgs e)
        {
            RemoveTask(form, int.Parse(((Button)sender).Name));
        }
        //タスククリック時
        public void menu2_1_panel_main_panel_Click(object sender, EventArgs e)
        {
            OpenTask(form, int.Parse(((Panel)sender).Name));
        }
        public void menu2_1_panel_main_panel_label1_Click(object sender, EventArgs e)
        {
            OpenTask(form, int.Parse(((Label)sender).Name));
        }
        #endregion form event
        // ********** form event **********

        // ********** public **********
        #region public

        public static void InitAddTask(MainForm form, String text)
        {
            form.SuspendLayout();
            form.menu2.SuspendLayout();
            form.menu2_1.SuspendLayout();
            form.menu2_1_panel.SuspendLayout();
            form.menu2_1_panel_main.SuspendLayout();

            form.menu2_1_panel_main_panel_button_delete.Add(add_menu2_1_panel_main_panel_button_delete(form));
            form.menu2_1_panel_main_panel_button_finish.Add(add_menu2_1_panel_main_panel_button_finish(form));
            form.menu2_1_panel_main_panel_label1.Add(add_menu2_1_panel_main_panel_label1(form, text));
            form.menu2_1_panel_main_panel.Add(add_menu2_1_panel_main_panel(form));
            form.menu2_1_panel_main.Controls.Add(form.menu2_1_panel_main_panel[Main.Common_Var.menu2_1_task]);

            form.ResumeLayout();
            form.menu2.ResumeLayout();
            form.menu2_1.ResumeLayout();
            form.menu2_1_panel.ResumeLayout();
            form.menu2_1_panel_main.ResumeLayout();

            Main.Common_Var.menu2_1_task += 1;

            ChangeTaskNum(form);
        }
        // タスク追加
        public static void AddTask(MainForm form, String text)
        {
            if (Main.Common_Var.menu2_1_task <= Main.Common_Var.menu2_1_open_task) // 新規追加
            {
                form.SuspendLayout();
                form.menu2.SuspendLayout();
                form.menu2_1.SuspendLayout();
                form.menu2_1_panel.SuspendLayout();
                form.menu2_1_panel_main.SuspendLayout();

                form.menu2_1_panel_main_panel_button_delete.Add(add_menu2_1_panel_main_panel_button_delete(form));
                form.menu2_1_panel_main_panel_button_finish.Add(add_menu2_1_panel_main_panel_button_finish(form));
                form.menu2_1_panel_main_panel_label1.Add(add_menu2_1_panel_main_panel_label1(form, text));
                form.menu2_1_panel_main_panel.Add(add_menu2_1_panel_main_panel(form));
                form.menu2_1_panel_main.Controls.Add(form.menu2_1_panel_main_panel[Main.Common_Var.menu2_1_task]);

                form.ResumeLayout();
                form.menu2.ResumeLayout();
                form.menu2_1.ResumeLayout();
                form.menu2_1_panel.ResumeLayout();
                form.menu2_1_panel_main.ResumeLayout();

                Properties.Settings.Default.task_name.Add(form.menutask_table1_text.Text);
                Properties.Settings.Default.task_memo.Add(form.menutask_table2_text.Text);

                Properties.Settings.Default.Save();

                Main.Common_Var.menu2_1_task += 1;

                Main.Common_Var.menu2_1_open_task += 1;

                ChangeTaskNum(form);
            }
            else // 既存更新
            {
                form.menu2_1_panel_main_panel_label1[Main.Common_Var.menu2_1_open_task - Main.Common_Var.menu2_1_delete_task].Text = form.menutask_table1_text.Text;
                Properties.Settings.Default.task_name[Main.Common_Var.menu2_1_open_task - Main.Common_Var.menu2_1_delete_task] = form.menutask_table1_text.Text;
                Properties.Settings.Default.task_memo[Main.Common_Var.menu2_1_open_task - Main.Common_Var.menu2_1_delete_task] = form.menutask_table2_text.Text;

                Properties.Settings.Default.Save();
            }
        }

        // タスク数更新
        public static void ChangeTaskNum(MainForm form)
        {
            form.SuspendLayout();
            form.menu2.SuspendLayout();
            form.menu2_1.SuspendLayout();
            form.menu2_1_panel.SuspendLayout();
            form.menu2_1_panel_top.SuspendLayout();
            form.menu2_1_panel_main.SuspendLayout();

            form.menu2_1_panel_top_label_num.CustomText = Main.Common_Var.menu2_1_task.ToString();
            if (Properties.Settings.Default.menu2_open1)
            {
                if (Main.Common_Var.menu2_1_task != 0) // タスク数が0以外の時
                {
                    form.menu2_1_panel.Height = 34 + 36 * Main.Common_Var.menu2_1_task;
                    form.menu2_1.Height = 42 + 36 * Main.Common_Var.menu2_1_task;
                }
                else // タスク数が0の時
                {
                    form.menu2_1_panel.Height = 34 + 18;
                    form.menu2_1.Height = 42 + 18;
                }
            }
            else
            {
                form.menu2_1_panel.Height = 34;
                form.menu2_1.Height = 42;
            }

            for (int i = 0; i < Main.Common_Var.menu2_1_task; i++)
            {
                form.menu2_1_panel_main_panel_label1[i].Text = Properties.Settings.Default.task_name[i];
            }

            form.ResumeLayout();
            form.menu2.ResumeLayout();
            form.menu2_1.ResumeLayout();
            form.menu2_1_panel.ResumeLayout();
            form.menu2_1_panel_top.ResumeLayout();
            form.menu2_1_panel_main.ResumeLayout();
        }

        #endregion public
        // ********** public **********

        // ********** private **********
        #region private

        /// <summary>
        /// タスク削除
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private void RemoveTask(MainForm form, int num)
        {
            if (num <= Main.Common_Var.menu2_1_open_task) // 削除するタスクが保存した番号より前の時、回数をカウント
            {
                Main.Common_Var.menu2_1_delete_task += 1;
            }
            //開いていたタスクを削除する前に、タスク画面を非表示
            if (form.menutask.Visible == true && (Main.Common_Var.menu2_1_open_task - Main.Common_Var.menu2_1_delete_task + 1) == num)
            {
                form.menutask.Visible = false;
            }
            form.SuspendLayout();
            form.menu2.SuspendLayout();
            form.menu2_1.SuspendLayout();
            form.menu2_1_panel.SuspendLayout();
            form.menu2_1_panel_main.SuspendLayout();

            menu2_1_events events = new menu2_1_events(form);

            // コントロール削除時に削除ボタンのイベントを除去
            if (num < Main.Common_Var.menu2_1_task - 1)
            {
                form.menu2_1_panel_main_panel_button_delete[num].MouseLeave -= new EventHandler(events.menu2_1_panel_main_panel_button_delete_MouseLeave);
            }

            //
            for (int i = num; i < Main.Common_Var.menu2_1_task; i++)
            {
                // 位置更新
                form.menu2_1_panel_main_panel[i].Location = new Point(4, (form.menu2_1_panel_main_panel[i].Size.Height + 4) * (i - 1));
                // コントロール名更新
                form.menu2_1_panel_main_panel_label1[i].Name = (i - 1).ToString();
                form.menu2_1_panel_main_panel_button_finish[i].Name = (i - 1).ToString();
                form.menu2_1_panel_main_panel_button_delete[i].Name = (i - 1).ToString();
                form.menu2_1_panel_main_panel[i].Name = (i - 1).ToString();
            }

            // コントロール削除
            form.menu2_1_panel_main_panel_label1.RemoveAt(num);
            form.menu2_1_panel_main_panel_button_finish.RemoveAt(num);
            form.menu2_1_panel_main_panel_button_delete.RemoveAt(num);
            form.menu2_1_panel_main_panel.RemoveAt(num);

            // 削除ボタンのイベントを戻す
            if (num < Main.Common_Var.menu2_1_task - 1)
            {
                form.menu2_1_panel_main_panel_button_delete[num].BackColor = Color.Transparent;
                form.menu2_1_panel_main_panel_button_delete[num].MouseLeave += new EventHandler(events.menu2_1_panel_main_panel_button_delete_MouseLeave);
            }

            form.ResumeLayout();
            form.menu2.ResumeLayout();
            form.menu2_1.ResumeLayout();
            form.menu2_1_panel.ResumeLayout();
            form.menu2_1_panel_main.ResumeLayout();

            Main.Common_Var.menu2_1_task -= 1;

            Properties.Settings.Default.task_name.RemoveAt(num);

            Properties.Settings.Default.Save();

            ChangeTaskNum(form);
        }

        // タスクを開く
        private static void OpenTask(MainForm form, int task_num)
        {
            Main.Common_Var.menu2_1_open_task = task_num;
            Main.Common_Var.menu2_1_delete_task = 0;
            if (task_num >= Main.Common_Var.menu2_1_task) // 新規タスク
            {
                form.menutask_table1_text.Text = "";
                form.menutask_table2_text.Text = "";
                form.menutask.Visible = true;
            }
            else // 既存タスク
            {
                form.menutask_table1_text.Text = Properties.Settings.Default.task_name[task_num];
                form.menutask_table2_text.Text = Properties.Settings.Default.task_memo[task_num];
                form.menutask.Visible = true;
            }
        }
        // 削除ボタン追加
        private static Button add_menu2_1_panel_main_panel_button_delete(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu2_1_panel_main_panel_button_delete = new Button();
            menu2_1_events events = new menu2_1_events(form);

            menu2_1_panel_main_panel_button_delete.BackColor = Color.Transparent;
            menu2_1_panel_main_panel_button_delete.Dock = DockStyle.Right;
            menu2_1_panel_main_panel_button_delete.FlatStyle = FlatStyle.Flat;
            menu2_1_panel_main_panel_button_delete.Image = ((Image)(resources.GetObject("menu2_1_panel_main_panel1_button_delete.Image")));
            menu2_1_panel_main_panel_button_delete.Name = Main.Common_Var.menu2_1_task.ToString();
            menu2_1_panel_main_panel_button_delete.Size = new Size(32, 32);
            menu2_1_panel_main_panel_button_delete.UseVisualStyleBackColor = false;
            menu2_1_panel_main_panel_button_delete.Click += new EventHandler(events.menu2_1_panel_main_panel_button_delete_Click);
            menu2_1_panel_main_panel_button_delete.MouseEnter += new EventHandler(events.menu2_1_panel_main_panel_button_delete_MouseEnter);
            menu2_1_panel_main_panel_button_delete.MouseLeave += new EventHandler(events.menu2_1_panel_main_panel_button_delete_MouseLeave);
            menu2_1_panel_main_panel_button_delete.Cursor = Cursors.Hand;

            return menu2_1_panel_main_panel_button_delete;
        }
        // 完了ボタン追加
        private static Button add_menu2_1_panel_main_panel_button_finish(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Button menu2_1_panel_main_panel_button_finish = new Button();
            menu2_1_events events = new menu2_1_events(form);

            menu2_1_panel_main_panel_button_finish.BackColor = Color.Transparent;
            menu2_1_panel_main_panel_button_finish.Dock = DockStyle.Right;
            menu2_1_panel_main_panel_button_finish.FlatStyle = FlatStyle.Flat;
            menu2_1_panel_main_panel_button_finish.Name = Main.Common_Var.menu2_1_task.ToString();
            menu2_1_panel_main_panel_button_finish.Image = ((Image)(resources.GetObject("menu2_1_panel_main_panel1_button_finish.Image")));
            menu2_1_panel_main_panel_button_finish.Size = new Size(32, 32);
            menu2_1_panel_main_panel_button_finish.UseVisualStyleBackColor = false;
            menu2_1_panel_main_panel_button_finish.Click += new EventHandler(events.menu2_1_panel_main_panel_button_finish_Click);
            menu2_1_panel_main_panel_button_finish.MouseEnter += new EventHandler(events.menu2_1_panel_main_panel_button_finish_MouseEnter);
            menu2_1_panel_main_panel_button_finish.MouseLeave += new EventHandler(events.menu2_1_panel_main_panel_button_finish_MouseLeave);
            menu2_1_panel_main_panel_button_finish.Cursor = Cursors.Hand;

            return menu2_1_panel_main_panel_button_finish;
        }
        // タスク名追加
        private static Label add_menu2_1_panel_main_panel_label1(MainForm form, string text)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label menu2_1_panel_main_panel_label1 = new Label();
            menu2_1_events events = new menu2_1_events(form);

            menu2_1_panel_main_panel_label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu2_1_panel_main_panel_label1.Location = new Point(1, 1);
            menu2_1_panel_main_panel_label1.Name = Main.Common_Var.menu2_1_task.ToString();
            menu2_1_panel_main_panel_label1.Size = new Size(Main.Common_Const.form_x - 10
                - form.menu2_1_panel_main_panel_button_delete[Main.Common_Var.menu2_1_task].Width
                - form.menu2_1_panel_main_panel_button_finish[Main.Common_Var.menu2_1_task].Width
                - menu2_1_panel_main_panel_label1.Location.X * 2, 30);
            menu2_1_panel_main_panel_label1.Text = text;
            menu2_1_panel_main_panel_label1.TextAlign = ContentAlignment.MiddleLeft;
            menu2_1_panel_main_panel_label1.MouseEnter += new EventHandler(events.menu2_1_panel_main_panel_label1_MouseEnter);
            menu2_1_panel_main_panel_label1.MouseLeave += new EventHandler(events.menu2_1_panel_main_panel_label1_MouseLeave);
            menu2_1_panel_main_panel_label1.Click += new System.EventHandler(events.menu2_1_panel_main_panel_label1_Click);
            menu2_1_panel_main_panel_label1.Cursor = Cursors.Hand;

            return menu2_1_panel_main_panel_label1;
        }
        // タスクパネル追加
        private static PanelEx add_menu2_1_panel_main_panel(MainForm form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelEx menu2_1_panel_main_panel = new PanelEx();
            menu2_1_events events = new menu2_1_events(form);

            menu2_1_panel_main_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menu2_1_panel_main_panel.BorderColor = Color.Black;
            menu2_1_panel_main_panel.Controls.Add(form.menu2_1_panel_main_panel_label1[Main.Common_Var.menu2_1_task]);
            menu2_1_panel_main_panel.Controls.Add(form.menu2_1_panel_main_panel_button_finish[Main.Common_Var.menu2_1_task]);
            menu2_1_panel_main_panel.Controls.Add(form.menu2_1_panel_main_panel_button_delete[Main.Common_Var.menu2_1_task]);
            menu2_1_panel_main_panel.Location = new Point(4, (menu2_1_panel_main_panel.Size.Height + 4) * Main.Common_Var.menu2_1_task);
            menu2_1_panel_main_panel.Name = Main.Common_Var.menu2_1_task.ToString();
            menu2_1_panel_main_panel.Size = new Size(form.menu2_1_panel_main.Width - menu2_1_panel_main_panel.Location.X * 2, 32);
            menu2_1_panel_main_panel.MouseEnter += new EventHandler(events.menu2_1_panel_main_panel_MouseEnter);
            menu2_1_panel_main_panel.MouseLeave += new EventHandler(events.menu2_1_panel_main_panel_MouseLeave);
            menu2_1_panel_main_panel.Click += new EventHandler(events.menu2_1_panel_main_panel_Click);
            menu2_1_panel_main_panel.Cursor = Cursors.Hand;

            return menu2_1_panel_main_panel;
        }

        #endregion private
        // ********** private **********
    }
}
