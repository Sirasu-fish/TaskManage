using System;

namespace TaskManage.controls_event
{
    class menutask_events
    {
        // 閉じるボタン
        public static void menutask_button_close_Click(object sender, EventArgs e, MainForm form)
        {
            form.menutask.Visible = false;
        }

        // 保存するボタン
        public static void menutask_button_save_Click(object sender, EventArgs e, MainForm form)
        {

        }
    }
}
