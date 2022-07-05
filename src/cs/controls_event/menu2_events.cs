namespace TaskManage.controls_event
{
    class menu2_events
    {
        //要素順反映
        public static void RefrectMoveControl(MainForm form)
        {
            form.menu2.SuspendLayout();
            form.menu2_1.SuspendLayout();
            form.menu2_2.SuspendLayout();

            form.menu2.Controls.Remove(form.menu2_1);
            form.menu2.Controls.Remove(form.menu2_2);

            string[] order = new string[Main.Common_Const.menu2_num];
            Properties.Settings.Default.order.CopyTo(order, 0);

            for (int i = Main.Common_Const.menu2_num - 1; i >= 0; i--)
            {
                switch (order[i])
                {
                    case "1":
                        form.menu2.Controls.Add(form.menu2_1);
                        break;
                    case "2":
                        form.menu2.Controls.Add(form.menu2_2);
                        break;
                }
            }

            form.menu2.ResumeLayout();
            form.menu2_1.ResumeLayout();
            form.menu2_2.ResumeLayout();
        }
    }
}
