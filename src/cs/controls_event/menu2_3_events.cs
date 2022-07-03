using System;
using System.Windows.Forms;

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

        public static void menu2_3_panel_main_panel_button_delete_Click(object sender, MainForm form)
        {
            RemoveAchieve(int.Parse(((Button)sender).Name));
        }
        public static void menu2_3_panel_main_panel_Click(object sender, MainForm form)
        {
            OpenAchieve(form, int.Parse(((Panel)sender).Name));
        }

        public static void menu2_3_panel_main_panel_label1_Click(object sender, MainForm form)
        {
            OpenAchieve(form, int.Parse(((Label)sender).Name));
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
