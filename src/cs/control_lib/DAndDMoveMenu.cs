using System.Drawing;
using System.Windows.Forms;

namespace TaskManage
{
    class DAndDMoveMenu
    {
        Control mouseListner;
        MainForm form;
        Point lastMouseDownPoint;

        public DAndDMoveMenu(Control mouseListner, MainForm form)
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

                // 上 → 下
                if (Properties.Settings.Default.order[0] == "1" && ((Panel)sender).Name == "1")
                {
                    if (form.menu2_2.Location.Y < form.menu2_1.Location.Y + e.Y)
                    {
                        string tmp;
                        tmp = Properties.Settings.Default.order[0];
                        Properties.Settings.Default.order[0] = Properties.Settings.Default.order[1];
                        Properties.Settings.Default.order[1] = tmp;

                        Properties.Settings.Default.Save();

                        form.menu2.SuspendLayout();
                        form.menu2_1.SuspendLayout();
                        form.menu2_2.SuspendLayout();

                        form.menu2_2.BringToFront();
                        form.menu2_1.BringToFront();

                        form.menu2.ResumeLayout();
                        form.menu2_1.ResumeLayout();
                        form.menu2_2.ResumeLayout();
                    }
                }
                if (Properties.Settings.Default.order[0] == "2" && ((Panel)sender).Name == "2")
                {
                    if (form.menu2_1.Location.Y < form.menu2_2.Location.Y + e.Y)
                    {
                        string tmp;
                        tmp = Properties.Settings.Default.order[0];
                        Properties.Settings.Default.order[0] = Properties.Settings.Default.order[1];
                        Properties.Settings.Default.order[1] = tmp;

                        Properties.Settings.Default.Save();

                        form.menu2.SuspendLayout();
                        form.menu2_1.SuspendLayout();
                        form.menu2_2.SuspendLayout();

                        form.menu2_1.BringToFront();
                        form.menu2_2.BringToFront();

                        form.menu2.ResumeLayout();
                        form.menu2_1.ResumeLayout();
                        form.menu2_2.ResumeLayout();
                    }
                }
                // 下 → 上(下から上の時は猶予を持たせる(topと同じ32)
                if (Properties.Settings.Default.order[1] == "1" && ((Panel)sender).Name == "1")
                {
                    if (form.menu2_2.Location.Y + form.menu2_2_panel_top.Height > form.menu2_1.Location.Y + e.Y)
                    {
                        string tmp;
                        tmp = Properties.Settings.Default.order[0];
                        Properties.Settings.Default.order[0] = Properties.Settings.Default.order[1];
                        Properties.Settings.Default.order[1] = tmp;

                        Properties.Settings.Default.Save();

                        form.menu2.SuspendLayout();
                        form.menu2_1.SuspendLayout();
                        form.menu2_2.SuspendLayout();

                        form.menu2_1.BringToFront();
                        form.menu2_2.BringToFront();

                        form.menu2.ResumeLayout();
                        form.menu2_1.ResumeLayout();
                        form.menu2_2.ResumeLayout();
                    }
                }

                if (Properties.Settings.Default.order[1] == "2" && ((Panel)sender).Name == "2")
                {
                    if (form.menu2_1.Location.Y + form.menu2_1_panel_top.Height > form.menu2_2.Location.Y + e.Y)
                    {
                        string tmp;
                        tmp = Properties.Settings.Default.order[0];
                        Properties.Settings.Default.order[0] = Properties.Settings.Default.order[1];
                        Properties.Settings.Default.order[1] = tmp;

                        Properties.Settings.Default.Save();

                        form.menu2.SuspendLayout();
                        form.menu2_1.SuspendLayout();
                        form.menu2_2.SuspendLayout();

                        form.menu2_2.BringToFront();
                        form.menu2_1.BringToFront();

                        form.menu2.ResumeLayout();
                        form.menu2_1.ResumeLayout();
                        form.menu2_2.ResumeLayout();
                    }
                }
            }
        }

        void mouseListner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseListner.Capture = false;


        }
    }
}
