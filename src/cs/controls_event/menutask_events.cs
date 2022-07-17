﻿using System;
using System.Windows.Forms;

namespace TaskManage.controls_event
{
    class menutask_events
    {
        public static void menutask_table1_text_KeyDown(object sender, KeyEventArgs e, MainForm form)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
            {
                // 入力内容チェック処理
                if (string.IsNullOrEmpty(form.menutask_table1_text.Text))
                {
                    return;
                }

                // 登録処理
                menu2_1_events.AddTask(form, form.menutask_table1_text.Text);

                // タスク画面非表示処理
                form.SuspendLayout();
                form.menutask.SuspendLayout();
                form.menutask_table1.SuspendLayout();
                form.menutask_table2.SuspendLayout();

                form.menutask_table1_text.Text = "";
                form.menutask_table2_text.Text = "";

                form.ResumeLayout();
                form.menutask.ResumeLayout();
                form.menutask_table1.ResumeLayout();
                form.menutask_table2.ResumeLayout();
            }
        }

        // 閉じるボタン
        public static void menutask_button_close_Click(object sender, EventArgs e, MainForm form)
        {
            form.menutask.Visible = false;
        }

        // 保存するボタン
        public static void menutask_button_save_Click(object sender, EventArgs e, MainForm form)
        {
            // 入力内容チェック処理
            if (string.IsNullOrEmpty(form.menutask_table1_text.Text))
            {
                return;
            }

            // 登録処理
            menu2_1_events.AddTask(form, form.menutask_table1_text.Text);

            // タスク画面非表示処理
            form.SuspendLayout();
            form.menutask.SuspendLayout();
            form.menutask_table1.SuspendLayout();
            form.menutask_table2.SuspendLayout();

            form.menutask_table1_text.Text = "";
            form.menutask_table2_text.Text = "";

            form.ResumeLayout();
            form.menutask.ResumeLayout();
            form.menutask_table1.ResumeLayout();
            form.menutask_table2.ResumeLayout();
        }
    }
}
