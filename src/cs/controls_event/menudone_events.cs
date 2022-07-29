using System;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menudone_events
    {
        public static void menudone_table1_text_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.KeyCode == Keys.Return) // Enter
            {
                int year = 0;
                int month = 0;
                // 入力内容チェック処理
                if (!CheckDoneInput(form, ref year, ref month))
                {
                    return;
                }
                // 登録処理
                menu1_events.AddDone(form, year, month);

                form.SuspendLayout();
                form.menudone.SuspendLayout();
                form.menudone_table1.SuspendLayout();
                form.menudone_table2.SuspendLayout();

                form.menudone_table1_text.Text = "";
                form.menudone_table2_text_h.Text = "";
                form.menudone_table2_text_m.Text = "";

                form.ResumeLayout();
                form.menudone.ResumeLayout();
                form.menudone_table1.ResumeLayout();
                form.menudone_table2.ResumeLayout();
            }
        }

        public static void menudone_button_close_Click(object sender, EventArgs e, MainForm form)
        {
            form.menudone.Visible = false;
        }

        public static void menudone_button_save_Click(object sender, EventArgs e, MainForm form)
        {
            int year = 0;
            int month = 0;
            // 入力内容チェック処理
            if (!CheckDoneInput(form, ref year, ref month))
            {
                return;
            }

            // 登録処理
            menu1_events.AddDone(form, year, month);

            // 実績画面非表示処理
            form.menudone_table1_text.Text = "";
            form.menudone_table2_text_h.Text = "";
            form.menudone_table2_text_m.Text = "";
            form.menudone_table3_text.Text = "";
        }


        // ********** private **********
        #region private

        // チェック処理
        private static bool CheckDoneInput(MainForm form, ref int year, ref int month)
        {
            // 実績名
            if (string.IsNullOrEmpty(form.menudone_table1_text.Text))
            {
                return false;
            }
            if (!int.TryParse(form.menudone_table2_text_h.Text, out int h))
            {
                return false;
            }
            if (!int.TryParse(form.menudone_table2_text_m.Text, out int m))
            {
                return false;
            }
            if (int.Parse(form.menudone_table2_text_h.Text) < 0)
            {
                return false;
            }
            if (24 < int.Parse(form.menudone_table2_text_h.Text))
            {
                return false;
            }
            if (int.Parse(form.menudone_table2_text_m.Text) >= 60)
            {
                return false;
            }
            if (int.Parse(form.menudone_table2_text_m.Text) < 0)
            {
                return false;
            }
            if (int.Parse(form.menudone_table2_text_h.Text) == 0 && int.Parse(form.menudone_table2_text_m.Text) == 0)
            {
                return false;
            }
            year = int.Parse(form.menudone_table2_text_h.Text);
            month = int.Parse(form.menudone_table2_text_m.Text);
            return true;
        }

        #endregion private
        // ********** private **********
    }
}
