using System;

namespace TaskManage.controls_event
{
    class menudone_events
    {
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
            menu1_events.AddDone(form, form.menudone_table1_text.Text, form.menudone_table3_text.Text);

            // 実績画面非表示処理
            form.menudone_table1_text.Text = "";
            form.menudone_table2_text.Text = "";
            form.menudone_table3_text.Text = "";
            form.menudone_table4_text.Text = "";
        }

    }
}
