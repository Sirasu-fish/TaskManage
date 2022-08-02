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
    class DAndDMoveMemo
    {
        Control mouseListner;
        MainForm form;
        Point lastMouseDownPoint;

        public DAndDMoveMemo(Control mouseListner, MainForm form)
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
                if (num + 1 < Main.Common_Var.menu2_2_memo
                    && form.menu2_2_panel_main_panel[num + 1].Location.Y < form.menu2_2_panel_main_panel[num].Location.Y + e.Y)
                {
                    string tmp;
                    tmp = Properties.Settings.Default.memo_path[num];
                    Properties.Settings.Default.memo_path[num] = Properties.Settings.Default.memo_path[num + 1];
                    Properties.Settings.Default.memo_path[num + 1] = tmp;

                    tmp = Properties.Settings.Default.memo_height[num];
                    Properties.Settings.Default.memo_height[num] = Properties.Settings.Default.memo_height[num + 1];
                    Properties.Settings.Default.memo_height[num + 1] = tmp;

                    tmp = Properties.Settings.Default.memo_wrap[num];
                    Properties.Settings.Default.memo_wrap[num] = Properties.Settings.Default.memo_wrap[num + 1];
                    Properties.Settings.Default.memo_wrap[num + 1] = tmp;

                    Properties.Settings.Default.Save();

                    form.menu2.SuspendLayout();
                    form.menu2_2.SuspendLayout();
                    form.menu2_2_panel.SuspendLayout();
                    form.menu2_2_panel_main.SuspendLayout();

                    tmp = form.menu2_2_panel_main_panel_table_memo_text[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_text[num].Name = form.menu2_2_panel_main_panel_table_memo_text[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_text[num + 1].Name = tmp;

                    TextBox tmptextbox = form.menu2_2_panel_main_panel_table_memo_text[num];
                    form.menu2_2_panel_main_panel_table_memo_text[num] = form.menu2_2_panel_main_panel_table_memo_text[num + 1];
                    form.menu2_2_panel_main_panel_table_memo_text[num + 1] = tmptextbox;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num + 1].Name = tmp;

                    Button tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num + 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num + 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num + 1].Name = tmp;

                    tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num + 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num + 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num + 1].Name = tmp;

                    tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num + 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num + 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num + 1].Name = tmp;

                    tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num + 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num + 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num + 1].Name = tmp;

                    tmptextbox = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num + 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num + 1] = tmptextbox;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num + 1].Name = tmp;

                    Panel tmppanel = form.menu2_2_panel_main_panel_table_memo_panel_top[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num] = form.menu2_2_panel_main_panel_table_memo_panel_top[num + 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num + 1] = tmppanel;

                    tmp = form.menu2_2_panel_main_panel_table_memo[num].Name;
                    form.menu2_2_panel_main_panel_table_memo[num].Name = form.menu2_2_panel_main_panel_table_memo[num + 1].Name;
                    form.menu2_2_panel_main_panel_table_memo[num + 1].Name = tmp;

                    TableLayoutPanel tmptable = form.menu2_2_panel_main_panel_table_memo[num];
                    form.menu2_2_panel_main_panel_table_memo[num] = form.menu2_2_panel_main_panel_table_memo[num + 1];
                    form.menu2_2_panel_main_panel_table_memo[num + 1] = tmptable;

                    tmp = form.menu2_2_panel_main_panel[num].Name;
                    form.menu2_2_panel_main_panel[num].Name = form.menu2_2_panel_main_panel[num + 1].Name;
                    form.menu2_2_panel_main_panel[num + 1].Name = tmp;

                    tmppanel = form.menu2_2_panel_main_panel[num];
                    form.menu2_2_panel_main_panel[num] = form.menu2_2_panel_main_panel[num + 1];
                    form.menu2_2_panel_main_panel[num + 1] = tmppanel;

                    bool tmpbool;
                    tmpbool = Main.Common_Var.memo_save[num];
                    Main.Common_Var.memo_save[num] = Main.Common_Var.memo_save[num + 1];
                    Main.Common_Var.memo_save[num + 1] = tmpbool;

                    for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
                    {
                        form.menu2_2_panel_main_panel[i].BringToFront();
                    }

                    form.menu2.ResumeLayout();
                    form.menu2_2.ResumeLayout();
                    form.menu2_2_panel.ResumeLayout();
                    form.menu2_2_panel_main.ResumeLayout();

                }
                // 下 → 上(下から上の時は猶予を持たせる
                if (0 < num
                    && form.menu2_2_panel_main_panel[num - 1].Location.Y + form.menu2_2_panel_top.Height > form.menu2_2_panel_main_panel[num].Location.Y + e.Y)
                {
                    string tmp;
                    tmp = Properties.Settings.Default.memo_path[num];
                    Properties.Settings.Default.memo_path[num] = Properties.Settings.Default.memo_path[num - 1];
                    Properties.Settings.Default.memo_path[num - 1] = tmp;

                    tmp = Properties.Settings.Default.memo_height[num];
                    Properties.Settings.Default.memo_height[num] = Properties.Settings.Default.memo_height[num - 1];
                    Properties.Settings.Default.memo_height[num - 1] = tmp;

                    tmp = Properties.Settings.Default.memo_wrap[num];
                    Properties.Settings.Default.memo_wrap[num] = Properties.Settings.Default.memo_wrap[num - 1];
                    Properties.Settings.Default.memo_wrap[num - 1] = tmp;

                    Properties.Settings.Default.Save();

                    form.menu2.SuspendLayout();
                    form.menu2_2.SuspendLayout();
                    form.menu2_2_panel.SuspendLayout();
                    form.menu2_2_panel_main.SuspendLayout();

                    tmp = form.menu2_2_panel_main_panel_table_memo_text[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_text[num].Name = form.menu2_2_panel_main_panel_table_memo_text[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_text[num - 1].Name = tmp;

                    TextBox tmptextbox = form.menu2_2_panel_main_panel_table_memo_text[num];
                    form.menu2_2_panel_main_panel_table_memo_text[num] = form.menu2_2_panel_main_panel_table_memo_text[num - 1];
                    form.menu2_2_panel_main_panel_table_memo_text[num - 1] = tmptextbox;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num - 1].Name = tmp;

                    Button tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num - 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_wrap[num - 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num - 1].Name = tmp;

                    tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num - 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_save[num - 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num - 1].Name = tmp;

                    tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num - 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_minmax[num - 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num - 1].Name = tmp;

                    tmpbutton = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num - 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_button_close[num - 1] = tmpbutton;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num - 1].Name = tmp;

                    tmptextbox = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num] = form.menu2_2_panel_main_panel_table_memo_panel_top_text[num - 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top_text[num - 1] = tmptextbox;

                    tmp = form.menu2_2_panel_main_panel_table_memo_panel_top[num].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num].Name = form.menu2_2_panel_main_panel_table_memo_panel_top[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num - 1].Name = tmp;

                    Panel tmppanel = form.menu2_2_panel_main_panel_table_memo_panel_top[num];
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num] = form.menu2_2_panel_main_panel_table_memo_panel_top[num - 1];
                    form.menu2_2_panel_main_panel_table_memo_panel_top[num - 1] = tmppanel;

                    tmp = form.menu2_2_panel_main_panel_table_memo[num].Name;
                    form.menu2_2_panel_main_panel_table_memo[num].Name = form.menu2_2_panel_main_panel_table_memo[num - 1].Name;
                    form.menu2_2_panel_main_panel_table_memo[num - 1].Name = tmp;

                    TableLayoutPanel tmptable = form.menu2_2_panel_main_panel_table_memo[num];
                    form.menu2_2_panel_main_panel_table_memo[num] = form.menu2_2_panel_main_panel_table_memo[num - 1];
                    form.menu2_2_panel_main_panel_table_memo[num - 1] = tmptable;

                    tmp = form.menu2_2_panel_main_panel[num].Name;
                    form.menu2_2_panel_main_panel[num].Name = form.menu2_2_panel_main_panel[num - 1].Name;
                    form.menu2_2_panel_main_panel[num - 1].Name = tmp;

                    tmppanel = form.menu2_2_panel_main_panel[num];
                    form.menu2_2_panel_main_panel[num] = form.menu2_2_panel_main_panel[num - 1];
                    form.menu2_2_panel_main_panel[num - 1] = tmppanel;

                    for (int i = 0; i < Main.Common_Var.menu2_2_memo; i++)
                    {
                        form.menu2_2_panel_main_panel[i].BringToFront();
                    }

                    bool tmpbool;
                    tmpbool = Main.Common_Var.memo_save[num];
                    Main.Common_Var.memo_save[num] = Main.Common_Var.memo_save[num - 1];
                    Main.Common_Var.memo_save[num - 1] = tmpbool;

                    form.menu2.ResumeLayout();
                    form.menu2_2.ResumeLayout();
                    form.menu2_2_panel.ResumeLayout();
                    form.menu2_2_panel_main.ResumeLayout();
                }
            }
        }

        void mouseListner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseListner.Capture = false;


        }
    }
}
