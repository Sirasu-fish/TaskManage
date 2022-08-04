using System.Drawing;
using System.Windows.Forms;

namespace TaskManage
{
    class DAndDMoveDone
    {
        Control mouseListner;
        MainForm form;
        Point lastMouseDownPoint;

        public DAndDMoveDone(Control mouseListner, MainForm form)
        {
            this.mouseListner = mouseListner;
            this.form = form;

            mouseListner.MouseDown += new MouseEventHandler(mouseListner_MouseDown);
            mouseListner.MouseMove += new MouseEventHandler(mouseListner_MouseMove);
            mouseListner.MouseUp += new MouseEventHandler(mouseListner_MouseUp);
        }

        void mouseListner_MouseDown(object sender, MouseEventArgs e)
        {
            lastMouseDownPoint = e.Location;
            mouseListner.Capture = true;
        }

        void mouseListner_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int diffY = e.Y - lastMouseDownPoint.Y;
                int num = int.Parse(((Control)sender).Name);

                // 上 → 下
                if (num + 1 < Main.Common_Var.menu1_day_done
                    && form.menu1_done_main_panel[num + 1].Location.Y < form.menu1_done_main_panel[num].Location.Y + e.Y + form.menu1_done_main_panel[num + 1].Height / 2)
                {
                    int num_pos = 0;
                    int sub_pos = 0;
                    int cnt = -1;
                    for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                        && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                        {
                            cnt++;
                            if (cnt == num)
                            {
                                num_pos = i;
                            }
                            if (cnt == num + 1)
                            {
                                sub_pos = i;
                            }
                        }
                    }

                    string tmp;
                    tmp = Properties.Settings.Default.done_name[num_pos];
                    Properties.Settings.Default.done_name[num_pos] = Properties.Settings.Default.done_name[sub_pos];
                    Properties.Settings.Default.done_name[sub_pos] = tmp;

                    tmp = Properties.Settings.Default.done_memo[num_pos];
                    Properties.Settings.Default.done_memo[num_pos] = Properties.Settings.Default.done_memo[sub_pos];
                    Properties.Settings.Default.done_memo[sub_pos] = tmp;

                    tmp = Properties.Settings.Default.done_time[num_pos];
                    Properties.Settings.Default.done_time[num_pos] = Properties.Settings.Default.done_time[sub_pos];
                    Properties.Settings.Default.done_time[sub_pos] = tmp;

                    Properties.Settings.Default.Save();

                    form.menu1.SuspendLayout();
                    form.menu1_done_main.SuspendLayout();

                    tmp = form.menu1_done_main_panel_button_delete[num].Name;
                    form.menu1_done_main_panel_button_delete[num].Name = form.menu1_done_main_panel_button_delete[num + 1].Name;
                    form.menu1_done_main_panel_button_delete[num + 1].Name = tmp;

                    Button tmpbutton = form.menu1_done_main_panel_button_delete[num];
                    form.menu1_done_main_panel_button_delete[num] = form.menu1_done_main_panel_button_delete[num + 1];
                    form.menu1_done_main_panel_button_delete[num + 1] = tmpbutton;

                    tmp = form.menu1_done_main_panel_label_name[num].Name;
                    form.menu1_done_main_panel_label_name[num].Name = form.menu1_done_main_panel_label_name[num + 1].Name;
                    form.menu1_done_main_panel_label_name[num + 1].Name = tmp;

                    Label tmplabel = form.menu1_done_main_panel_label_name[num];
                    form.menu1_done_main_panel_label_name[num] = form.menu1_done_main_panel_label_name[num + 1];
                    form.menu1_done_main_panel_label_name[num + 1] = tmplabel;

                    tmp = form.menu1_done_main_panel_label_time[num].Name;
                    form.menu1_done_main_panel_label_time[num].Name = form.menu1_done_main_panel_label_time[num + 1].Name;
                    form.menu1_done_main_panel_label_time[num + 1].Name = tmp;

                    tmplabel = form.menu1_done_main_panel_label_time[num];
                    form.menu1_done_main_panel_label_time[num] = form.menu1_done_main_panel_label_time[num + 1];
                    form.menu1_done_main_panel_label_time[num + 1] = tmplabel;

                    tmp = form.menu1_done_main_panel[num].Name;
                    form.menu1_done_main_panel[num].Name = form.menu1_done_main_panel[num + 1].Name;
                    form.menu1_done_main_panel[num + 1].Name = tmp;

                    PanelEx tmppanel = form.menu1_done_main_panel[num];
                    form.menu1_done_main_panel[num] = form.menu1_done_main_panel[num + 1];
                    form.menu1_done_main_panel[num + 1] = tmppanel;

                    int tmpy;
                    tmpy = form.menu1_done_main_panel[num].Location.Y;
                    form.menu1_done_main_panel[num].Location = new Point(form.menu1_done_main_panel[num].Location.X, form.menu1_done_main_panel[num + 1].Location.Y);
                    form.menu1_done_main_panel[num + 1].Location = new Point(form.menu1_done_main_panel[num + 1].Location.X, tmpy);

                    form.menudone.Visible = false;

                    form.menu1.ResumeLayout();
                    form.menu1_done_main.ResumeLayout();
                }
                // 下 → 上
                if (0 < num
                    && form.menu1_done_main_panel[num - 1].Location.Y + form.menu1_done_main_panel[num - 1].Height / 2 > form.menu1_done_main_panel[num].Location.Y + e.Y)
                {
                    int num_pos = 0;
                    int sub_pos = 0;
                    int cnt = -1;
                    for (int i = 0; i < Properties.Settings.Default.done_name.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(Properties.Settings.Default.done_name[i])
                        && Properties.Settings.Default.done_day[i] == Main.Common_Var.menu1_done_year.ToString() + "/" + Main.Common_Var.menu1_done_month.ToString() + "/" + Main.Common_Var.menu1_done_day.ToString())
                        {
                            cnt++;
                            if (cnt == num - 1)
                            {
                                sub_pos = i;
                            }
                            if (cnt == num)
                            {
                                num_pos = i;
                            }
                        }
                    }

                    string tmp;
                    tmp = Properties.Settings.Default.done_name[num_pos];
                    Properties.Settings.Default.done_name[num_pos] = Properties.Settings.Default.done_name[sub_pos];
                    Properties.Settings.Default.done_name[sub_pos] = tmp;

                    tmp = Properties.Settings.Default.done_memo[num_pos];
                    Properties.Settings.Default.done_memo[num_pos] = Properties.Settings.Default.done_memo[sub_pos];
                    Properties.Settings.Default.done_memo[sub_pos] = tmp;

                    tmp = Properties.Settings.Default.done_time[num_pos];
                    Properties.Settings.Default.done_time[num_pos] = Properties.Settings.Default.done_time[sub_pos];
                    Properties.Settings.Default.done_time[sub_pos] = tmp;

                    Properties.Settings.Default.Save();

                    form.menu1.SuspendLayout();
                    form.menu1_done_main.SuspendLayout();

                    tmp = form.menu1_done_main_panel_button_delete[num].Name;
                    form.menu1_done_main_panel_button_delete[num].Name = form.menu1_done_main_panel_button_delete[num - 1].Name;
                    form.menu1_done_main_panel_button_delete[num - 1].Name = tmp;

                    Button tmpbutton = form.menu1_done_main_panel_button_delete[num];
                    form.menu1_done_main_panel_button_delete[num] = form.menu1_done_main_panel_button_delete[num - 1];
                    form.menu1_done_main_panel_button_delete[num - 1] = tmpbutton;

                    tmp = form.menu1_done_main_panel_label_name[num].Name;
                    form.menu1_done_main_panel_label_name[num].Name = form.menu1_done_main_panel_label_name[num - 1].Name;
                    form.menu1_done_main_panel_label_name[num - 1].Name = tmp;

                    Label tmplabel = form.menu1_done_main_panel_label_name[num];
                    form.menu1_done_main_panel_label_name[num] = form.menu1_done_main_panel_label_name[num - 1];
                    form.menu1_done_main_panel_label_name[num - 1] = tmplabel;

                    tmp = form.menu1_done_main_panel_label_time[num].Name;
                    form.menu1_done_main_panel_label_time[num].Name = form.menu1_done_main_panel_label_time[num - 1].Name;
                    form.menu1_done_main_panel_label_time[num - 1].Name = tmp;

                    tmplabel = form.menu1_done_main_panel_label_time[num];
                    form.menu1_done_main_panel_label_time[num] = form.menu1_done_main_panel_label_time[num - 1];
                    form.menu1_done_main_panel_label_time[num - 1] = tmplabel;

                    tmp = form.menu1_done_main_panel[num].Name;
                    form.menu1_done_main_panel[num].Name = form.menu1_done_main_panel[num - 1].Name;
                    form.menu1_done_main_panel[num - 1].Name = tmp;

                    PanelEx tmppanel = form.menu1_done_main_panel[num];
                    form.menu1_done_main_panel[num] = form.menu1_done_main_panel[num - 1];
                    form.menu1_done_main_panel[num - 1] = tmppanel;

                    int tmpy;
                    tmpy = form.menu1_done_main_panel[num].Location.Y;
                    form.menu1_done_main_panel[num].Location = new Point(form.menu1_done_main_panel[num].Location.X, form.menu1_done_main_panel[num - 1].Location.Y);
                    form.menu1_done_main_panel[num - 1].Location = new Point(form.menu1_done_main_panel[num - 1].Location.X, tmpy);

                    form.menudone.Visible = false;

                    form.menu1.ResumeLayout();
                    form.menu1_done_main.ResumeLayout();
                }
            }
        }

        void mouseListner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseListner.Capture = false;


        }
    }
}
