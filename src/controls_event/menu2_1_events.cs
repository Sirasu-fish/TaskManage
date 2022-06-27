using System;
using System.Drawing;

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
        public static void menu2_1_panel_main_panel1_button_delete_MouseEnter(MainForm form)
        {
            form.menu2_1_panel_main_panel1_button_delete.BackColor = Color.FromArgb(50, 255, 128, 128);
        }
        // タスク削除ボタンホバーが離れた時
        public static void menu2_1_panel_main_panel1_button_delete_MouseLeave(MainForm form)
        {
            form.menu2_1_panel_main_panel1_button_delete.BackColor = Color.Transparent;
        }
        // タスク完了ボタンホバー時
        public static void menu2_1_panel_main_panel1_button_finish_MouseEnter(MainForm form)
        {
            form.menu2_1_panel_main_panel1_button_finish.BackColor = Color.FromArgb(50, 128, 255, 128);
        }
        // タスク完了ボタンホバーが離れた時
        public static void menu2_1_panel_main_panel1_button_finish_MouseLeave(MainForm form)
        {
            form.menu2_1_panel_main_panel1_button_finish.BackColor = Color.Transparent;
        }

        // menu2 panel1のタスクを追加するボタン
        public static void menu2_1_panel_top_button_add_Click(MainForm form)
        {
            OpenTask(form, -1);
        }

        //タスク完了ボタン
        public static void menu2_1_panel_main_panel1_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel2_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel3_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel4_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel5_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel6_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel7_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel8_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel9_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel10_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel11_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel12_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel13_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel14_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel15_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel16_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel17_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel18_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel19_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel20_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel21_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel22_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel23_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel24_button_finish_Click(MainForm form)
        {

        }
        public static void menu2_1_panel_main_panel25_button_finish_Click(MainForm form)
        {

        }
        //タスク削除ボタン
        public static void menu2_1_panel_main_panel1_button_delete_Click(MainForm form)
        {
            RemoveTask(1);
        }
        public static void menu2_1_panel_main_panel2_button_delete_Click(MainForm form)
        {
            RemoveTask(2);
        }
        public static void menu2_1_panel_main_panel3_button_delete_Click(MainForm form)
        {
            RemoveTask(3);
        }
        public static void menu2_1_panel_main_panel4_button_delete_Click(MainForm form)
        {
            RemoveTask(4);
        }
        public static void menu2_1_panel_main_panel5_button_delete_Click(MainForm form)
        {
            RemoveTask(5);
        }
        public static void menu2_1_panel_main_panel6_button_delete_Click(MainForm form)
        {
            RemoveTask(6);
        }
        public static void menu2_1_panel_main_panel7_button_delete_Click(MainForm form)
        {
            RemoveTask(7);
        }
        public static void menu2_1_panel_main_panel8_button_delete_Click(MainForm form)
        {
            RemoveTask(8);
        }
        public static void menu2_1_panel_main_panel9_button_delete_Click(MainForm form)
        {
            RemoveTask(9);
        }
        public static void menu2_1_panel_main_panel10_button_delete_Click(MainForm form)
        {
            RemoveTask(10);
        }
        public static void menu2_1_panel_main_panel11_button_delete_Click(MainForm form)
        {
            RemoveTask(11);
        }
        public static void menu2_1_panel_main_panel12_button_delete_Click(MainForm form)
        {
            RemoveTask(12);
        }
        public static void menu2_1_panel_main_panel13_button_delete_Click(MainForm form)
        {
            RemoveTask(13);
        }
        public static void menu2_1_panel_main_panel14_button_delete_Click(MainForm form)
        {
            RemoveTask(14);
        }
        public static void menu2_1_panel_main_panel15_button_delete_Click(MainForm form)
        {
            RemoveTask(15);
        }
        public static void menu2_1_panel_main_panel16_button_delete_Click(MainForm form)
        {
            RemoveTask(16);
        }
        public static void menu2_1_panel_main_panel17_button_delete_Click(MainForm form)
        {
            RemoveTask(17);
        }
        public static void menu2_1_panel_main_panel18_button_delete_Click(MainForm form)
        {
            RemoveTask(18);
        }
        public static void menu2_1_panel_main_panel19_button_delete_Click(MainForm form)
        {
            RemoveTask(19);
        }
        public static void menu2_1_panel_main_panel20_button_delete_Click(MainForm form)
        {
            RemoveTask(20);
        }
        public static void menu2_1_panel_main_panel21_button_delete_Click(MainForm form)
        {
            RemoveTask(21);
        }
        public static void menu2_1_panel_main_panel22_button_delete_Click(MainForm form)
        {
            RemoveTask(22);
        }
        public static void menu2_1_panel_main_panel23_button_delete_Click(MainForm form)
        {
            RemoveTask(23);
        }
        public static void menu2_1_panel_main_panel24_button_delete_Click(MainForm form)
        {
            RemoveTask(24);
        }
        public static void menu2_1_panel_main_panel25_button_delete_Click(MainForm form)
        {
            RemoveTask(25);
        }

        //タスククリック時
        public static void menu2_1_panel_main_panel1_Click(MainForm form)
        {
            OpenTask(form, 1);
        }
        public static void menu2_1_panel_main_panel1_label1_Click(MainForm form)
        {
            OpenTask(form, 1);
        }
        public static void menu2_1_panel_main_panel1_label2_Click(MainForm form)
        {
            OpenTask(form, 1);
        }

        public static void menu2_1_panel_main_panel2_Click(MainForm form)
        {
            OpenTask(form, 2);
        }

        public static void menu2_1_panel_main_panel2_label1_Click(MainForm form)
        {
            OpenTask(form, 2);
        }

        public static void menu2_1_panel_main_panel2_label2_Click(MainForm form)
        {
            OpenTask(form, 2);
        }

        public static void menu2_1_panel_main_panel3_Click(MainForm form)
        {
            OpenTask(form, 3);
        }

        public static void menu2_1_panel_main_panel3_label1_Click(MainForm form)
        {
            OpenTask(form, 3);
        }

        public static void menu2_1_panel_main_panel3_label2_Click(MainForm form)
        {
            OpenTask(form, 3);
        }

        public static void menu2_1_panel_main_panel4_Click(MainForm form)
        {
            OpenTask(form, 4);
        }

        public static void menu2_1_panel_main_panel4_label1_Click(MainForm form)
        {
            OpenTask(form, 4);
        }

        public static void menu2_1_panel_main_panel4_label2_Click(MainForm form)
        {
            OpenTask(form, 4);
        }

        public static void menu2_1_panel_main_panel5_Click(MainForm form)
        {
            OpenTask(form, 5);
        }

        public static void menu2_1_panel_main_panel5_label1_Click(MainForm form)
        {
            OpenTask(form, 5);
        }

        public static void menu2_1_panel_main_panel5_label2_Click(MainForm form)
        {
            OpenTask(form, 5);
        }

        public static void menu2_1_panel_main_panel6_Click(MainForm form)
        {
            OpenTask(form, 6);
        }

        public static void menu2_1_panel_main_panel6_label1_Click(MainForm form)
        {
            OpenTask(form, 6);
        }

        public static void menu2_1_panel_main_panel6_label2_Click(MainForm form)
        {
            OpenTask(form, 6);
        }

        public static void menu2_1_panel_main_panel7_Click(MainForm form)
        {
            OpenTask(form, 7);
        }

        public static void menu2_1_panel_main_panel7_label1_Click(MainForm form)
        {
            OpenTask(form, 7);
        }

        public static void menu2_1_panel_main_panel7_label2_Click(MainForm form)
        {
            OpenTask(form, 7);
        }

        public static void menu2_1_panel_main_panel8_Click(MainForm form)
        {
            OpenTask(form, 8);
        }

        public static void menu2_1_panel_main_panel8_label1_Click(MainForm form)
        {
            OpenTask(form, 8);
        }

        public static void menu2_1_panel_main_panel8_label2_Click(MainForm form)
        {
            OpenTask(form, 8);
        }

        public static void menu2_1_panel_main_panel9_Click(MainForm form)
        {
            OpenTask(form, 9);
        }

        public static void menu2_1_panel_main_panel9_label1_Click(MainForm form)
        {
            OpenTask(form, 9);
        }

        public static void menu2_1_panel_main_panel9_label2_Click(MainForm form)
        {
            OpenTask(form, 9);
        }

        public static void menu2_1_panel_main_panel10_Click(MainForm form)
        {
            OpenTask(form, 10);
        }

        public static void menu2_1_panel_main_panel10_label1_Click(MainForm form)
        {
            OpenTask(form, 10);
        }

        public static void menu2_1_panel_main_panel10_label2_Click(MainForm form)
        {
            OpenTask(form, 10);
        }

        public static void menu2_1_panel_main_panel11_Click(MainForm form)
        {
            OpenTask(form, 11);
        }

        public static void menu2_1_panel_main_panel11_label1_Click(MainForm form)
        {
            OpenTask(form, 11);
        }

        public static void menu2_1_panel_main_panel11_label2_Click(MainForm form)
        {
            OpenTask(form, 11);
        }

        public static void menu2_1_panel_main_panel12_Click(MainForm form)
        {
            OpenTask(form, 12);
        }

        public static void menu2_1_panel_main_panel12_label1_Click(MainForm form)
        {
            OpenTask(form, 12);
        }

        public static void menu2_1_panel_main_panel12_label2_Click(MainForm form)
        {
            OpenTask(form, 12);
        }

        public static void menu2_1_panel_main_panel13_Click(MainForm form)
        {
            OpenTask(form, 13);
        }

        public static void menu2_1_panel_main_panel13_label1_Click(MainForm form)
        {
            OpenTask(form, 13);
        }

        public static void menu2_1_panel_main_panel13_label2_Click(MainForm form)
        {
            OpenTask(form, 13);
        }

        public static void menu2_1_panel_main_panel14_Click(MainForm form)
        {
            OpenTask(form, 14);
        }

        public static void menu2_1_panel_main_panel14_label1_Click(MainForm form)
        {
            OpenTask(form, 14);
        }

        public static void menu2_1_panel_main_panel14_label2_Click(MainForm form)
        {
            OpenTask(form, 14);
        }

        public static void menu2_1_panel_main_panel15_Click(MainForm form)
        {
            OpenTask(form, 15);
        }

        public static void menu2_1_panel_main_panel15_label1_Click(MainForm form)
        {
            OpenTask(form, 15);
        }

        public static void menu2_1_panel_main_panel15_label2_Click(MainForm form)
        {
            OpenTask(form, 15);
        }

        public static void menu2_1_panel_main_panel16_Click(MainForm form)
        {
            OpenTask(form, 16);
        }

        public static void menu2_1_panel_main_panel16_label1_Click(MainForm form)
        {
            OpenTask(form, 16);
        }

        public static void menu2_1_panel_main_panel16_label2_Click(MainForm form)
        {
            OpenTask(form, 16);
        }

        public static void menu2_1_panel_main_panel17_Click(MainForm form)
        {
            OpenTask(form, 17);
        }

        public static void menu2_1_panel_main_panel17_label1_Click(MainForm form)
        {
            OpenTask(form, 17);
        }

        public static void menu2_1_panel_main_panel17_label2_Click(MainForm form)
        {
            OpenTask(form, 17);
        }

        public static void menu2_1_panel_main_panel18_Click(MainForm form)
        {
            OpenTask(form, 18);
        }

        public static void menu2_1_panel_main_panel18_label1_Click(MainForm form)
        {
            OpenTask(form, 18);
        }

        public static void menu2_1_panel_main_panel18_label2_Click(MainForm form)
        {
            OpenTask(form, 18);
        }

        public static void menu2_1_panel_main_panel19_Click(MainForm form)
        {
            OpenTask(form, 18);
        }

        public static void menu2_1_panel_main_panel19_label1_Click(MainForm form)
        {
            OpenTask(form, 19);
        }

        public static void menu2_1_panel_main_panel19_label2_Click(MainForm form)
        {
            OpenTask(form, 19);
        }

        public static void menu2_1_panel_main_panel20_Click(MainForm form)
        {
            OpenTask(form, 20);
        }

        public static void menu2_1_panel_main_panel20_label1_Click(MainForm form)
        {
            OpenTask(form, 20);
        }

        public static void menu2_1_panel_main_panel20_label2_Click(MainForm form)
        {
            OpenTask(form, 20);
        }

        public static void menu2_1_panel_main_panel21_Click(MainForm form)
        {
            OpenTask(form, 21);
        }

        public static void menu2_1_panel_main_panel21_label1_Click(MainForm form)
        {
            OpenTask(form, 21);
        }

        public static void menu2_1_panel_main_panel21_label2_Click(MainForm form)
        {
            OpenTask(form, 21);
        }

        public static void menu2_1_panel_main_panel22_Click(MainForm form)
        {
            OpenTask(form, 22);
        }

        public static void menu2_1_panel_main_panel22_label1_Click(MainForm form)
        {
            OpenTask(form, 22);
        }

        public static void menu2_1_panel_main_panel22_label2_Click(MainForm form)
        {
            OpenTask(form, 22);
        }

        public static void menu2_1_panel_main_panel23_Click(MainForm form)
        {
            OpenTask(form, 23);
        }

        public static void menu2_1_panel_main_panel23_label1_Click(MainForm form)
        {
            OpenTask(form, 23);
        }

        public static void menu2_1_panel_main_panel23_label2_Click(MainForm form)
        {
            OpenTask(form, 23);
        }

        public static void menu2_1_panel_main_panel24_Click(MainForm form)
        {
            OpenTask(form, 24);
        }

        public static void menu2_1_panel_main_panel24_label1_Click(MainForm form)
        {
            OpenTask(form, 24);
        }

        public static void menu2_1_panel_main_panel24_label2_Click(MainForm form)
        {
            OpenTask(form, 24);
        }

        public static void menu2_1_panel_main_panel25_Click(MainForm form)
        {
            OpenTask(form, 25);
        }

        public static void menu2_1_panel_main_panel25_label1_Click(MainForm form)
        {
            OpenTask(form, 25);
        }
        public static void menu2_1_panel_main_panel25_label2_Click(MainForm form)
        {
            OpenTask(form, 25);
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
