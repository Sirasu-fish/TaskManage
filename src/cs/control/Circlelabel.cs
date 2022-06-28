using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManage
{
    public partial class Circlelabel : UserControl
    {
        public Circlelabel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 枠線。
        /// </summary>
        private string _text = "";

        /// <summary>
        /// 枠線
        /// </summary>
        public string CustomText
        {
            get { return this._text; }
            set
            {
                this._text = value;
            }
        }

        /// <summary>
        /// OnPaintイベント
        /// </summary>
        /// <param name="e">イベントデータ</param>
        protected override void OnPaint(PaintEventArgs e)
        {

            int right = this.ClientRectangle.Right - 1;
            int bottom = this.ClientRectangle.Bottom - 1;

            StringFormat stringformat = new StringFormat();
            stringformat.Alignment = StringAlignment.Center;
            stringformat.LineAlignment = StringAlignment.Center;
            Rectangle rect = new Rectangle(0, 0, right, bottom);

            // 四角を描画
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Red, 0, 0, right, bottom);
            g.DrawString(_text, Font, Brushes.White, rect, stringformat);
        }

        /// <summary>
        /// OnSizeChangedイベント
        /// </summary>
        /// <param name="e">イベントデータ</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            // 描画をクリア
            this.Refresh();

            base.OnSizeChanged(e);
        }
    }
}
