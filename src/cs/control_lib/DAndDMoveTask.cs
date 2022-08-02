using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManage
{
    class DAndDMoveTask
    {
        Control mouseListner;
        MainForm form;
        Point lastMouseDownPoint;

        public DAndDMoveTask(Control mouseListner, MainForm form)
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
                if (num + 1 < Main.Common_Var.menu2_1_task
                    && form.menu2_1_panel_main_panel[num + 1].Location.Y < form.menu2_1_panel_main_panel[num].Location.Y + e.Y + form.menu2_1_panel_main_panel[num + 1].Height / 2)
                {
                    string tmp;
                    tmp = Properties.Settings.Default.task_name[num];
                    Properties.Settings.Default.task_name[num] = Properties.Settings.Default.task_name[num + 1];
                    Properties.Settings.Default.task_name[num + 1] = tmp;

                    tmp = Properties.Settings.Default.task_memo[num];
                    Properties.Settings.Default.task_memo[num] = Properties.Settings.Default.task_memo[num + 1];
                    Properties.Settings.Default.task_memo[num + 1] = tmp;

                    Properties.Settings.Default.Save();

                    form.menu2.SuspendLayout();
                    form.menu2_1.SuspendLayout();
                    form.menu2_1_panel.SuspendLayout();
                    form.menu2_1_panel_main.SuspendLayout();

                    tmp = form.menu2_1_panel_main_panel_button_delete[num].Name;
                    form.menu2_1_panel_main_panel_button_delete[num].Name = form.menu2_1_panel_main_panel_button_delete[num + 1].Name;
                    form.menu2_1_panel_main_panel_button_delete[num + 1].Name = tmp;

                    Button tmpbutton = form.menu2_1_panel_main_panel_button_delete[num];
                    form.menu2_1_panel_main_panel_button_delete[num] = form.menu2_1_panel_main_panel_button_delete[num + 1];
                    form.menu2_1_panel_main_panel_button_delete[num + 1] = tmpbutton;

                    tmp = form.menu2_1_panel_main_panel_button_finish[num].Name;
                    form.menu2_1_panel_main_panel_button_finish[num].Name = form.menu2_1_panel_main_panel_button_finish[num + 1].Name;
                    form.menu2_1_panel_main_panel_button_finish[num + 1].Name = tmp;

                    tmpbutton = form.menu2_1_panel_main_panel_button_finish[num];
                    form.menu2_1_panel_main_panel_button_finish[num] = form.menu2_1_panel_main_panel_button_finish[num + 1];
                    form.menu2_1_panel_main_panel_button_finish[num + 1] = tmpbutton;

                    tmp = form.menu2_1_panel_main_panel[num].Name;
                    form.menu2_1_panel_main_panel[num].Name = form.menu2_1_panel_main_panel[num + 1].Name;
                    form.menu2_1_panel_main_panel[num + 1].Name = tmp;

                    PanelEx tmppanel = form.menu2_1_panel_main_panel[num];
                    form.menu2_1_panel_main_panel[num] = form.menu2_1_panel_main_panel[num + 1];
                    form.menu2_1_panel_main_panel[num + 1] = tmppanel;

                    tmp = form.menu2_1_panel_main_panel_label1[num].Name;
                    form.menu2_1_panel_main_panel_label1[num].Name = form.menu2_1_panel_main_panel_label1[num + 1].Name;
                    form.menu2_1_panel_main_panel_label1[num + 1].Name = tmp;

                    Label tmplabel = form.menu2_1_panel_main_panel_label1[num];
                    form.menu2_1_panel_main_panel_label1[num] = form.menu2_1_panel_main_panel_label1[num + 1];
                    form.menu2_1_panel_main_panel_label1[num + 1] = tmplabel;

                    int tmpy;
                    tmpy = form.menu2_1_panel_main_panel[num].Location.Y;
                    form.menu2_1_panel_main_panel[num].Location = new Point(form.menu2_1_panel_main_panel[num].Location.X, form.menu2_1_panel_main_panel[num + 1].Location.Y);
                    form.menu2_1_panel_main_panel[num + 1].Location = new Point(form.menu2_1_panel_main_panel[num + 1].Location.X, tmpy);

                    form.menutask.Visible = false;

                    form.menu2.ResumeLayout();
                    form.menu2_1.ResumeLayout();
                    form.menu2_1_panel.ResumeLayout();
                    form.menu2_1_panel_main.ResumeLayout();
                }
                // 下 → 上
                if (0 < num
                    && form.menu2_1_panel_main_panel[num - 1].Location.Y + form.menu2_1_panel_main_panel[num - 1].Height / 2 > form.menu2_1_panel_main_panel[num].Location.Y + e.Y)
                {
                    string tmp;
                    tmp = Properties.Settings.Default.task_name[num];
                    Properties.Settings.Default.task_name[num] = Properties.Settings.Default.task_name[num - 1];
                    Properties.Settings.Default.task_name[num - 1] = tmp;

                    tmp = Properties.Settings.Default.task_memo[num];
                    Properties.Settings.Default.task_memo[num] = Properties.Settings.Default.task_memo[num - 1];
                    Properties.Settings.Default.task_memo[num - 1] = tmp;

                    Properties.Settings.Default.Save();

                    form.menu2.SuspendLayout();
                    form.menu2_1.SuspendLayout();
                    form.menu2_1_panel.SuspendLayout();
                    form.menu2_1_panel_main.SuspendLayout();

                    tmp = form.menu2_1_panel_main_panel_button_delete[num].Name;
                    form.menu2_1_panel_main_panel_button_delete[num].Name = form.menu2_1_panel_main_panel_button_delete[num - 1].Name;
                    form.menu2_1_panel_main_panel_button_delete[num - 1].Name = tmp;

                    Button tmpbutton = form.menu2_1_panel_main_panel_button_delete[num];
                    form.menu2_1_panel_main_panel_button_delete[num] = form.menu2_1_panel_main_panel_button_delete[num - 1];
                    form.menu2_1_panel_main_panel_button_delete[num - 1] = tmpbutton;

                    tmp = form.menu2_1_panel_main_panel_button_finish[num].Name;
                    form.menu2_1_panel_main_panel_button_finish[num].Name = form.menu2_1_panel_main_panel_button_finish[num - 1].Name;
                    form.menu2_1_panel_main_panel_button_finish[num - 1].Name = tmp;

                    tmpbutton = form.menu2_1_panel_main_panel_button_finish[num];
                    form.menu2_1_panel_main_panel_button_finish[num] = form.menu2_1_panel_main_panel_button_finish[num - 1];
                    form.menu2_1_panel_main_panel_button_finish[num - 1] = tmpbutton;

                    tmp = form.menu2_1_panel_main_panel[num].Name;
                    form.menu2_1_panel_main_panel[num].Name = form.menu2_1_panel_main_panel[num - 1].Name;
                    form.menu2_1_panel_main_panel[num - 1].Name = tmp;

                    PanelEx tmppanel = form.menu2_1_panel_main_panel[num];
                    form.menu2_1_panel_main_panel[num] = form.menu2_1_panel_main_panel[num - 1];
                    form.menu2_1_panel_main_panel[num - 1] = tmppanel;

                    tmp = form.menu2_1_panel_main_panel_label1[num].Name;
                    form.menu2_1_panel_main_panel_label1[num].Name = form.menu2_1_panel_main_panel_label1[num - 1].Name;
                    form.menu2_1_panel_main_panel_label1[num - 1].Name = tmp;

                    Label tmplabel = form.menu2_1_panel_main_panel_label1[num];
                    form.menu2_1_panel_main_panel_label1[num] = form.menu2_1_panel_main_panel_label1[num - 1];
                    form.menu2_1_panel_main_panel_label1[num - 1] = tmplabel;

                    int tmpy;
                    tmpy = form.menu2_1_panel_main_panel[num].Location.Y;
                    form.menu2_1_panel_main_panel[num].Location = new Point(form.menu2_1_panel_main_panel[num].Location.X, form.menu2_1_panel_main_panel[num - 1].Location.Y);
                    form.menu2_1_panel_main_panel[num - 1].Location = new Point(form.menu2_1_panel_main_panel[num - 1].Location.X, tmpy);

                    form.menutask.Visible = false;

                    form.menu2.ResumeLayout();
                    form.menu2_1.ResumeLayout();
                    form.menu2_1_panel.ResumeLayout();
                    form.menu2_1_panel_main.ResumeLayout();
                }
            }
        }

        void mouseListner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseListner.Capture = false;


        }
    }
}
