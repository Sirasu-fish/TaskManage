﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage
{
    class DAndDSizeChanger
    {
        Control mouseListner;
        Control sizeChangeCtrl;
        DAndDArea sizeChangeArea;
        Size lastMouseDownSize;
        Point lastMouseDownPoint;
        DAndDArea status;
        int sizeChangeAreaWidth;
        Cursor defaultCursor;
        MainForm form;
        Size lastMouseDownSize2_2;
        Size lastMouseDownSize2_2_panel;

        /// <param name="mouseListner">マウス入力を受け取るコントロール</param>
        /// <param name="sizeChangeCtrl">マウス入力によってサイズが変更されるコントロール</param>
        /// <param name="sizeChangeArea">上下左右のサイズ変更が有効になる範囲を指定</param>
        /// <param name="sizeChangeAreaWidth">サイズ変更が有効になる範囲の幅を指定</param>
        public DAndDSizeChanger(Control mouseListner, Control sizeChangeCtrl, MainForm form, DAndDArea sizeChangeArea, int sizeChangeAreaWidth)
        {
            this.mouseListner = mouseListner;
            this.sizeChangeCtrl = sizeChangeCtrl;
            this.sizeChangeAreaWidth = sizeChangeAreaWidth;
            this.sizeChangeArea = sizeChangeArea;
            this.form = form;
            defaultCursor = mouseListner.Cursor;

            mouseListner.MouseDown += new MouseEventHandler(mouseListner_MouseDown);
            mouseListner.MouseMove += new MouseEventHandler(mouseListner_MouseMove);
            mouseListner.MouseUp += new MouseEventHandler(mouseListner_MouseUp);
        }

        void mouseListner_MouseDown(object sender, MouseEventArgs e)
        {
            lastMouseDownPoint = e.Location;
            lastMouseDownSize = sizeChangeCtrl.Size;
            lastMouseDownSize2_2 = form.menu2_2.Size;
            lastMouseDownSize2_2_panel = form.menu2_2_panel.Size;

            //動作を決定
            status = DAndDArea.None;
            if (getTop().Contains(e.Location))
            {
                status |= DAndDArea.Top;
            }
            if (getLeft().Contains(e.Location))
            {
                status |= DAndDArea.Left;
            }
            if (getBottom().Contains(e.Location))
            {
                status |= DAndDArea.Bottom;
            }
            if (getRight().Contains(e.Location))
            {
                status |= DAndDArea.Right;
            }
            if (status != DAndDArea.None)
            {
                mouseListner.Capture = true;
            }
        }

        void mouseListner_MouseMove(object sender, MouseEventArgs e)
        {
            //カーソルを変更
            if ((getTop().Contains(e.Location) &&
                getLeft().Contains(e.Location)) ||
                (getBottom().Contains(e.Location) &&
                getRight().Contains(e.Location)))
            {

                mouseListner.Cursor = Cursors.SizeNWSE;
            }
            else if ((getTop().Contains(e.Location) &&
              getRight().Contains(e.Location)) ||
              (getBottom().Contains(e.Location) &&
              getLeft().Contains(e.Location)))
            {

                mouseListner.Cursor = Cursors.SizeNESW;
            }
            else if (getTop().Contains(e.Location) ||
              getBottom().Contains(e.Location))
            {

                mouseListner.Cursor = Cursors.SizeNS;
            }
            else if (getLeft().Contains(e.Location) ||
              getRight().Contains(e.Location))
            {

                mouseListner.Cursor = Cursors.SizeWE;
            }
            else
            {
                mouseListner.Cursor = defaultCursor;
            }

            if (e.Button == MouseButtons.Left)
            {
                int diffX = e.X - lastMouseDownPoint.X;
                int diffY = e.Y - lastMouseDownPoint.Y;

                if ((status & DAndDArea.Top) == DAndDArea.Top)
                {
                    int h = sizeChangeCtrl.Height;
                    if (sizeChangeCtrl.Height - diffY < 207 && sizeChangeCtrl.Name == "done")
                    {
                        sizeChangeCtrl.Height = 207;
                    }
                    else if (sizeChangeCtrl.Height - diffY < 178 && sizeChangeCtrl.Name == "task")
                    {
                        sizeChangeCtrl.Height = 178;
                    }
                    else if (sizeChangeCtrl.Height - diffY > 300)
                    {
                        sizeChangeCtrl.Height = 300;
                    }
                    else
                    {
                        sizeChangeCtrl.Height -= diffY;
                    }
                }
                if ((status & DAndDArea.Bottom) == DAndDArea.Bottom)
                {
                    if (lastMouseDownSize.Height + diffY <= 54)
                    {
                        sizeChangeCtrl.Height = 54;
                    }
                    else
                    {
                        sizeChangeCtrl.Height = lastMouseDownSize.Height + diffY;
                        form.menu2_2.Height = lastMouseDownSize2_2.Height + diffY;
                        form.menu2_2_panel.Height = lastMouseDownSize2_2_panel.Height + diffY;
                    }
                }
                if ((status & DAndDArea.Left) == DAndDArea.Left)
                {
                    int w = sizeChangeCtrl.Width;
                    sizeChangeCtrl.Width -= diffX;
                    sizeChangeCtrl.Left += w - sizeChangeCtrl.Width;
                }
                if ((status & DAndDArea.Right) == DAndDArea.Right)
                {
                    sizeChangeCtrl.Width = lastMouseDownSize.Width + diffX;
                }
            }
        }

        void mouseListner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseListner.Capture = false;
        }

        /// <summary>
        /// ポイントがD＆Dするとサイズが変更されるエリア内にあるかどうかを判定します。
        /// </summary>
        public bool ContainsSizeChangeArea(Point p)
        {
            return getTop().Contains(p) ||
                getBottom().Contains(p) ||
                getLeft().Contains(p) ||
                getRight().Contains(p);
        }

        private Rectangle getTop()
        {
            if ((sizeChangeArea & DAndDArea.Top) == DAndDArea.Top)
            {
                return new Rectangle(0, 0, mouseListner.Width, sizeChangeAreaWidth);
            }
            else
            {
                return new Rectangle();
            }
        }

        private Rectangle getBottom()
        {
            if ((sizeChangeArea & DAndDArea.Bottom) == DAndDArea.Bottom)
            {
                return new Rectangle(0, mouseListner.Height - sizeChangeAreaWidth,
                    mouseListner.Width, sizeChangeAreaWidth);
            }
            else
            {
                return new Rectangle();
            }
        }

        private Rectangle getLeft()
        {
            if ((sizeChangeArea & DAndDArea.Left) == DAndDArea.Left)
            {
                return new Rectangle(0, 0,
                    sizeChangeAreaWidth, mouseListner.Height);
            }
            else
            {
                return new Rectangle();
            }
        }

        private Rectangle getRight()
        {
            if ((sizeChangeArea & DAndDArea.Right) == DAndDArea.Right)
            {
                return new Rectangle(mouseListner.Width - sizeChangeAreaWidth, 0,
                    sizeChangeAreaWidth, mouseListner.Height);
            }
            else
            {
                return new Rectangle();
            }
        }
    }

    public enum DAndDArea
    {
        None = 0,
        Top = 1,
        Bottom = 2,
        Left = 4,
        Right = 8,
        All = 15
    }
}
