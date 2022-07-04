namespace TaskManage.controls_event
{
    class menu2_events
    {
        //要素順反映
        public static void RefrectMoveControl(MainForm form)
        {
            form.menu2.Controls.Remove(form.menu2_1);
            form.menu2.Controls.Remove(form.menu2_2);
            form.menu2.Controls.Remove(form.menu2_3);

            switch (Properties.Settings.Default.order)
            {
                case 123:
                    form.menu2.Controls.Add(form.menu2_3);
                    form.menu2.Controls.Add(form.menu2_2);
                    form.menu2.Controls.Add(form.menu2_1);
                    break;
                case 132:
                    form.menu2.Controls.Add(form.menu2_2);
                    form.menu2.Controls.Add(form.menu2_3);
                    form.menu2.Controls.Add(form.menu2_1);
                    break;
                case 213:
                    form.menu2.Controls.Add(form.menu2_3);
                    form.menu2.Controls.Add(form.menu2_1);
                    form.menu2.Controls.Add(form.menu2_2);
                    break;
                case 231:
                    form.menu2.Controls.Add(form.menu2_1);
                    form.menu2.Controls.Add(form.menu2_3);
                    form.menu2.Controls.Add(form.menu2_2);
                    break;
                case 312:
                    form.menu2.Controls.Add(form.menu2_2);
                    form.menu2.Controls.Add(form.menu2_1);
                    form.menu2.Controls.Add(form.menu2_3);
                    break;
                case 321:
                    form.menu2.Controls.Add(form.menu2_1);
                    form.menu2.Controls.Add(form.menu2_2);
                    form.menu2.Controls.Add(form.menu2_3);
                    break;
            }
            Properties.Settings.Default.Save();
        }

    }
}
