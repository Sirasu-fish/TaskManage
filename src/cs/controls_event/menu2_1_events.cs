using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menu2_1_events
    {
        // menu2 panel1を開いたり閉じたりする時の動作
        public static void menu2_1_panel_top_button_openclose_Click(MainForm form)
        {
            if (form.menu2_1_panel_main.Visible == false)
            {
                form.menu2_1_panel_main.Visible = true;
                form.menu2_1_panel.Height = 936;
                form.menu2_1.Height = 944;
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
        public static void menu2_1_panel_top_button_moveup_Click(MainForm form)
        {
            switch (Properties.Settings.Default.order)
            {
                case 213:
                    Properties.Settings.Default.order = 123;
                    break;
                case 231:
                    Properties.Settings.Default.order = 213;
                    break;
                case 312:
                    Properties.Settings.Default.order = 132;
                    break;
                case 321:
                    Properties.Settings.Default.order = 312;
                    break;
            }

            menu2_events.RefrectMoveControl(form);
        }

        public static void menu2_1_panel_top_button_movedown_Click(MainForm form)
        {
            switch (Properties.Settings.Default.order)
            {
                case 123:
                    Properties.Settings.Default.order = 213;
                    break;
                case 132:
                    Properties.Settings.Default.order = 312;
                    break;
                case 213:
                    Properties.Settings.Default.order = 231;
                    break;
                case 312:
                    Properties.Settings.Default.order = 321;
                    break;
            }

            menu2_events.RefrectMoveControl(form);
        }

        // タスク削除ボタンホバー時
        public static void menu2_1_panel_main_panel_button_delete_MouseEnter(object sender, MainForm form)
        {
            form.menu2_1_panel_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 255, 128, 128);
        }
        // タスク削除ボタンホバーが離れた時
        public static void menu2_1_panel_main_panel_button_delete_MouseLeave(object sender, MainForm form)
        {
            form.menu2_1_panel_main_panel_button_delete[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
        }
        // タスク完了ボタンホバー時
        public static void menu2_1_panel_main_panel_button_finish_MouseEnter(object sender, MainForm form)
        {
            form.menu2_1_panel_main_panel_button_finish[int.Parse(((Button)sender).Name)].BackColor = Color.FromArgb(50, 128, 255, 128);
        }
        // タスク完了ボタンホバーが離れた時
        public static void menu2_1_panel_main_panel_button_finish_MouseLeave(object sender, MainForm form)
        {
            form.menu2_1_panel_main_panel_button_finish[int.Parse(((Button)sender).Name)].BackColor = Color.Transparent;
        }

        // menu2 panel1のタスクを追加するボタン
        public static void menu2_1_panel_top_button_add_Click(object sender, MainForm form)
        {
            OpenTask(form, -1);
        }
        //タスク完了ボタン
        public static void menu2_1_panel_main_panel_button_finish_Click(object sender, MainForm form)
        {

        }
        //タスク削除ボタン
        public static void menu2_1_panel_main_panel_button_delete_Click(object sender, MainForm form)
        {
            RemoveTask(int.Parse(((Button)sender).Name));
        }
        //タスククリック時
        public static void menu2_1_panel_main_panel_Click(object sender, MainForm form)
        {
            OpenTask(form, int.Parse(((Panel)sender).Name));
        }
        public static void menu2_1_panel_main_panel_label1_Click(object sender, MainForm form)
        {
            OpenTask(form, int.Parse(((Label)sender).Name));
        }
        public static void menu2_1_panel_main_panel_label2_Click(object sender, MainForm form)
        {
            OpenTask(form, int.Parse(((Label)sender).Name));
        }

        //private
        #region private

        /// <summary>
        /// タスク削除
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static Boolean RemoveTask(int num)
        {
            for (int i = num; i < 49; i++)
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

        // <summary>
        /// タスクを開く
        /// </summary>
        /// <param name="task_num"></param>
        private static void OpenTask(MainForm form, int task_num)
        {
            if (task_num == -1)
            {
                form.menutask_table1_text.Text = "";
                form.menutask_table2_check.Checked = false;
                //form.menutask_table2_text1 =
                //form.menutask_table2_text2 =
                form.menutask_table3_text.Text = "";
            }
            else
            {
                form.menutask_table1_text.Text = task[task_num].name;
                form.menutask_table2_check.Checked = task[task_num].term;
                //form.menutask_table2_text1 = task[task_num].term_from;
                //form.menutask_table2_text2 = task[task_num].term_to;
                form.menutask_table3_text.Text = task[task_num].memo;
                //form.menutask_table4_
            }
            form.menuachieve.Visible = false;
            form.menutask.Visible = true;
        }

        // タスクの初期化
        private static Task[] task = new Task[50];

        private void Inittask()
        {
            for (int i = 0; i < 50; i++)
            {
                task[i] = new Task("", false, DateTime.Now, DateTime.Now, "", 0);
            }
        }

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

        #endregion private

    }
}
