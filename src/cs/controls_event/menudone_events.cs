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
                // 入力内容チェック処理
                if (string.IsNullOrEmpty(form.menudone_table1_text.Text))
                {
                    return;
                }

                // 登録処理
                menu1_events.AddDone(form);

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
            // 入力内容チェック処理
            if (string.IsNullOrEmpty(form.menudone_table1_text.Text))
            {
                return;
            }

            // 登録処理
            menu1_events.AddDone(form);

            // 実績画面非表示処理
            form.menudone_table1_text.Text = "";
            form.menudone_table2_text_h.Text = "";
            form.menudone_table2_text_m.Text = "";
            form.menudone_table3_text.Text = "";
        }

    }
}
