using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManage.controls_event
{
    class menu2_3_events
    {
        // menu2 panel3を開いたり閉じたりする時の動作
        public static void menu2_3_panel_top_button_openclose_Click(MainForm form)
        {
            if (form.menu2_3_panel_main.Visible == false)
            {
                form.menu2_3_panel_main.Visible = true;
                form.menu2_3_panel.Height = 934;
                form.menu2_3.Height = 942;
                Properties.Settings.Default.menu2_open3 = true;
            }
            else
            {
                form.menu2_3_panel_main.Visible = false;
                form.menu2_3_panel.Height = 34;
                form.menu2_3.Height = 42;
                Properties.Settings.Default.menu2_open3 = false;
            }
            Properties.Settings.Default.Save();
        }

        // 要素順を入れ替える
        public static void menu2_3_panel_top_button_moveup_Click(MainForm form)
        {
            switch (Properties.Settings.Default.order)
            {
                case 123:
                    Properties.Settings.Default.order = 132;
                    break;
                case 132:
                    Properties.Settings.Default.order = 312;
                    break;
                case 213:
                    Properties.Settings.Default.order = 231;
                    break;
                case 231:
                    Properties.Settings.Default.order = 321;
                    break;
            }

            menu2_events.RefrectMoveControl(form);
        }
        public static void menu2_3_panel_top_button_movedown_Click(MainForm form)
        {
            switch (Properties.Settings.Default.order)
            {
                case 132:
                    Properties.Settings.Default.order = 123;
                    break;
                case 231:
                    Properties.Settings.Default.order = 213;
                    break;
                case 312:
                    Properties.Settings.Default.order = 132;
                    break;
                case 321:
                    Properties.Settings.Default.order = 231;
                    break;
            }

            menu2_events.RefrectMoveControl(form);
        }

        public static void menu2_3_panel_top_button_add_Click(MainForm form)
        {
            OpenAchieve(form, -1);
        }

        public static void menu2_3_panel_main_panel1_button_delete_Click(MainForm form)
        {
            RemoveAchieve(1);
        }

        public static void menu2_3_panel_main_panel2_button_delete_Click(MainForm form)
        {
            RemoveAchieve(2);
        }

        public static void menu2_3_panel_main_panel3_button_delete_Click(MainForm form)
        {
            RemoveAchieve(3);
        }

        public static void menu2_3_panel_main_panel4_button_delete_Click(MainForm form)
        {
            RemoveAchieve(4);
        }

        public static void menu2_3_panel_main_panel5_button_delete_Click(MainForm form)
        {
            RemoveAchieve(5);
        }

        public static void menu2_3_panel_main_panel6_button_delete_Click(MainForm form)
        {
            RemoveAchieve(6);
        }

        public static void menu2_3_panel_main_panel7_button_delete_Click(MainForm form)
        {
            RemoveAchieve(7);
        }

        public static void menu2_3_panel_main_panel8_button_delete_Click(MainForm form)
        {
            RemoveAchieve(8);
        }

        public static void menu2_3_panel_main_panel9_button_delete_Click(MainForm form)
        {
            RemoveAchieve(9);
        }

        public static void menu2_3_panel_main_panel10_button_delete_Click(MainForm form)
        {
            RemoveAchieve(10);
        }

        public static void menu2_3_panel_main_panel11_button_delete_Click(MainForm form)
        {
            RemoveAchieve(11);
        }

        public static void menu2_3_panel_main_panel12_button_delete_Click(MainForm form)
        {
            RemoveAchieve(12);
        }

        public static void menu2_3_panel_main_panel13_button_delete_Click(MainForm form)
        {
            RemoveAchieve(13);
        }

        public static void menu2_3_panel_main_panel14_button_delete_Click(MainForm form)
        {
            RemoveAchieve(14);
        }

        public static void menu2_3_panel_main_panel15_button_delete_Click(MainForm form)
        {
            RemoveAchieve(15);
        }

        public static void menu2_3_panel_main_panel16_button_delete_Click(MainForm form)
        {
            RemoveAchieve(16);
        }

        public static void menu2_3_panel_main_panel17_button_delete_Click(MainForm form)
        {
            RemoveAchieve(17);
        }

        public static void menu2_3_panel_main_panel18_button_delete_Click(MainForm form)
        {
            RemoveAchieve(18);
        }

        public static void menu2_3_panel_main_panel19_button_delete_Click(MainForm form)
        {
            RemoveAchieve(19);
        }

        public static void menu2_3_panel_main_panel20_button_delete_Click(MainForm form)
        {
            RemoveAchieve(20);
        }

        public static void menu2_3_panel_main_panel21_button_delete_Click(MainForm form)
        {
            RemoveAchieve(21);
        }

        public static void menu2_3_panel_main_panel22_button_delete_Click(MainForm form)
        {
            RemoveAchieve(22);
        }

        public static void menu2_3_panel_main_panel23_button_delete_Click(MainForm form)
        {
            RemoveAchieve(23);
        }

        public static void menu2_3_panel_main_panel24_button_delete_Click(MainForm form)
        {
            RemoveAchieve(24);
        }

        public static void menu2_3_panel_main_panel25_button_delete_Click(MainForm form)
        {
            RemoveAchieve(25);
        }

        public static void menu2_3_panel_main_panel1_Click(MainForm form)
        {
            OpenAchieve(form, 1);
        }

        public static void menu2_3_panel_main_panel1_label1_Click(MainForm form)
        {
            OpenAchieve(form, 1);
        }

        public static void menu2_3_panel_main_panel2_Click(MainForm form)
        {
            OpenAchieve(form, 2);
        }

        public static void menu2_3_panel_main_panel2_label1_Click(MainForm form)
        {
            OpenAchieve(form, 2);
        }

        public static void menu2_3_panel_main_panel3_Click(MainForm form)
        {
            OpenAchieve(form, 3);
        }

        public static void menu2_3_panel_main_panel3_label1_Click(MainForm form)
        {
            OpenAchieve(form, 3);
        }

        public static void menu2_3_panel_main_panel4_Click(MainForm form)
        {
            OpenAchieve(form, 4);
        }

        public static void menu2_3_panel_main_panel4_label1_Click(MainForm form)
        {
            OpenAchieve(form, 4);
        }

        public static void menu2_3_panel_main_panel5_Click(MainForm form)
        {
            OpenAchieve(form, 5);
        }

        public static void menu2_3_panel_main_panel5_label1_Click(MainForm form)
        {
            OpenAchieve(form, 5);
        }

        public static void menu2_3_panel_main_panel6_Click(MainForm form)
        {
            OpenAchieve(form, 6);
        }

        public static void menu2_3_panel_main_panel6_label1_Click(MainForm form)
        {
            OpenAchieve(form, 6);
        }

        public static void menu2_3_panel_main_panel7_Click(MainForm form)
        {
            OpenAchieve(form, 7);
        }

        public static void menu2_3_panel_main_panel7_label1_Click(MainForm form)
        {
            OpenAchieve(form, 7);
        }

        public static void menu2_3_panel_main_panel8_Click(MainForm form)
        {
            OpenAchieve(form, 8);
        }

        public static void menu2_3_panel_main_panel8_label1_Click(MainForm form)
        {
            OpenAchieve(form, 8);
        }

        public static void menu2_3_panel_main_panel9_Click(MainForm form)
        {
            OpenAchieve(form, 9);
        }

        public static void menu2_3_panel_main_panel9_label1_Click(MainForm form)
        {
            OpenAchieve(form, 9);
        }

        public static void menu2_3_panel_main_panel10_Click(MainForm form)
        {
            OpenAchieve(form, 10);
        }

        public static void menu2_3_panel_main_panel10_label1_Click(MainForm form)
        {
            OpenAchieve(form, 10);
        }

        public static void menu2_3_panel_main_panel11_Click(MainForm form)
        {
            OpenAchieve(form, 11);
        }

        public static void menu2_3_panel_main_panel11_label1_Click(MainForm form)
        {
            OpenAchieve(form, 11);
        }

        public static void menu2_3_panel_main_panel12_Click(MainForm form)
        {
            OpenAchieve(form, 12);
        }

        public static void menu2_3_panel_main_panel12_label1_Click(MainForm form)
        {
            OpenAchieve(form, 12);
        }

        public static void menu2_3_panel_main_panel13_Click(MainForm form)
        {
            OpenAchieve(form, 13);
        }

        public static void menu2_3_panel_main_panel13_label1_Click(MainForm form)
        {
            OpenAchieve(form, 13);
        }

        public static void menu2_3_panel_main_panel14_Click(MainForm form)
        {
            OpenAchieve(form, 14);
        }

        public static void menu2_3_panel_main_panel14_label1_Click(MainForm form)
        {
            OpenAchieve(form, 14);
        }

        public static void menu2_3_panel_main_panel15_Click(MainForm form)
        {
            OpenAchieve(form, 15);
        }

        public static void menu2_3_panel_main_panel15_label1_Click(MainForm form)
        {
            OpenAchieve(form, 15);
        }

        public static void menu2_3_panel_main_panel16_Click(MainForm form)
        {
            OpenAchieve(form, 16);
        }

        public static void menu2_3_panel_main_panel16_label1_Click(MainForm form)
        {
            OpenAchieve(form, 16);
        }

        public static void menu2_3_panel_main_panel17_Click(MainForm form)
        {
            OpenAchieve(form, 17);
        }

        public static void menu2_3_panel_main_panel17_label1_Click(MainForm form)
        {
            OpenAchieve(form, 17);
        }

        public static void menu2_3_panel_main_panel18_Click(MainForm form)
        {
            OpenAchieve(form, 18);
        }

        public static void menu2_3_panel_main_panel18_label1_Click(MainForm form)
        {
            OpenAchieve(form, 18);
        }

        public static void menu2_3_panel_main_panel19_Click(MainForm form)
        {
            OpenAchieve(form, 19);
        }

        public static void menu2_3_panel_main_panel19_label1_Click(MainForm form)
        {
            OpenAchieve(form, 19);
        }

        public static void menu2_3_panel_main_panel20_Click(MainForm form)
        {
            OpenAchieve(form, 20);
        }

        public static void menu2_3_panel_main_panel20_label1_Click(MainForm form)
        {
            OpenAchieve(form, 20);
        }

        public static void menu2_3_panel_main_panel21_Click(MainForm form)
        {
            OpenAchieve(form, 21);
        }

        public static void menu2_3_panel_main_panel21_label1_Click(MainForm form)
        {
            OpenAchieve(form, 21);
        }

        public static void menu2_3_panel_main_panel22_Click(MainForm form)
        {
            OpenAchieve(form, 22);
        }

        public static void menu2_3_panel_main_panel22_label1_Click(MainForm form)
        {
            OpenAchieve(form, 22);
        }

        public static void menu2_3_panel_main_panel23_Click(MainForm form)
        {
            OpenAchieve(form, 23);
        }

        public static void menu2_3_panel_main_panel23_label1_Click(MainForm form)
        {
            OpenAchieve(form, 23);
        }

        public static void menu2_3_panel_main_panel24_Click(MainForm form)
        {
            OpenAchieve(form, 24);
        }

        public static void menu2_3_panel_main_panel24_label1_Click(MainForm form)
        {
            OpenAchieve(form, 24);
        }

        public static void menu2_3_panel_main_panel25_Click(MainForm form)
        {
            OpenAchieve(form, 25);
        }

        public static void menu2_3_panel_main_panel25_label1_Click(MainForm form)
        {
            OpenAchieve(form, 25);
        }

        // private 

        #region private

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

        // 実績の初期化
        private static Achieve[] achieve = new Achieve[50];

        private void InitAchieve()
        {
            for (int i = 0; i < 50; i++)
            {
                achieve[i] = new Achieve("", 0, 0, "");
            }
        }

        /// <summary>
        /// 実績を開く
        /// </summary>
        /// <param name="achieve_num"></param>
        private static void OpenAchieve(MainForm form, int achieve_num)
        {
            if (achieve_num == -1)
            {
                form.menuachieve_table1_text.Text = "";
                form.menuachieve_table2_text.Text = "";
                form.menuachieve_table3_text.Text = "";
                form.menuachieve_table4_text.Text = "";
            }
            else
            {
                form.menuachieve_table1_text.Text = achieve[achieve_num].name;
                form.menuachieve_table2_text.Text = achieve[achieve_num].progress.ToString();
                form.menuachieve_table3_text.Text = achieve[achieve_num].hour.ToString();
                form.menuachieve_table4_text.Text = achieve[achieve_num].memo;
            }
            form.menutask.Visible = false;
            form.menuachieve.Visible = true;
        }

        private static void AddAchieve(int num)
        {

        }

        private static Boolean RemoveAchieve(int num)
        {
            for (int i = num; i < 49; i++)
            {
                achieve[num].name = achieve[num + 1].name;
                achieve[num].progress = achieve[num + 1].progress;
                achieve[num].hour = achieve[num + 1].hour;
                achieve[num].memo = achieve[num + 1].memo;
            }
            return false;
        }

        #endregion private
    }
}
