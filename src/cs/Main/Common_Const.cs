using System.Drawing;

namespace TaskManage.Main
{
    internal class Common_Const
    {
        private static int form_x_ = 600; // フォームのデフォルトサイズ x
        private static int form_y_ = 600; // フォームのデフォルトサイズ y

        private static Color color1_ = Color.FromArgb(241, 159, 77);
        private static Color color2_ = Color.FromArgb(205, 205, 205);
        private static Color color3_ = Color.FromArgb(239, 239, 239);
        private static Color color4_ = Color.FromArgb(249, 207, 0);
        private static Color color5_ = Color.FromArgb(171, 171, 171);

        private static int menu2_num_ = 2; // menu2の項目数
        private static int memo_num_ = 99; // メモの保存数
        private static int memo_height_ = 100;

        public static int form_x
        {
            get { return form_x_; }
        }

        public static int form_y
        {
            get { return form_y_; }
        }

        public static Color color1
        {
            get { return color1_; }
        }

        public static Color color2
        {
            get { return color2_; }
        }

        public static Color color3
        {
            get { return color3_; }
        }

        public static Color color4
        {
            get { return color4_; }
        }

        public static Color color5
        {
            get { return color5_; }
        }

        public static int menu2_num
        {
            get { return menu2_num_; }
        }
        public static int memo_num
        {
            get { return memo_num_; }
        }
        public static int memo_height
        {
            get { return memo_height_; }
        }
    }
}
