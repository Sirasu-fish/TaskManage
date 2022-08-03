using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage
{
    class DAndDMoveForm
    {
        Control mouseListner;
        Control moveForm;
        Point lastMouseDownPoint;

        public DAndDMoveForm(Control mouseListner, Control moveForm)
        {
            this.mouseListner = mouseListner;
            this.moveForm = moveForm;

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
                int diffX = Cursor.Position.X - lastMouseDownPoint.X - mouseListner.Location.X - 1;
                int diffY = Cursor.Position.Y - lastMouseDownPoint.Y - mouseListner.Location.Y - 1;
                moveForm.Location = new Point(diffX, diffY);
            }
        }

        void mouseListner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseListner.Capture = false;
        }
    }
}
