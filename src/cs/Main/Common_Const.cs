using System.Drawing;

namespace TaskManage.Main
{
    internal class Common_Const
    {
        private static int form_x_ = 600; // フォームのデフォルトサイズ x
        private static int form_y_ = 600; // フォームのデフォルトサイズ y

        private static Color color_main_ = Color.FromArgb(241, 159, 77); // オレンジ
        private static Color color_calender_today_ = Color.FromArgb(249, 207, 0); // 黄色
        private static Color color_calender_out_ = Color.FromArgb(171, 171, 171); // カレンダーで使う濃いグレー(カレンダー)
        private static Color color_gray1_ = Color.FromArgb(205, 205, 205); // 薄いグレー
        private static Color color_gray2_ = Color.FromArgb(239, 239, 239); // 濃いグレー(タスク実績、カレンダー)

        private static Color color_done1_ = Color.FromArgb(144, 238, 144); // 緑
        private static Color color_done2_ = Color.FromArgb(247, 100, 100); // 赤

        private static int menu2_num_ = 2; // menu2の項目数
        private static int memo_num_ = 99; // メモの保存数
        private static int memo_height_ = 100; // メモの高さ

        public static int form_x
        {
            get { return form_x_; }
        }

        public static int form_y
        {
            get { return form_y_; }
        }

        public static Color color_main
        {
            get { return color_main_; }
        }

        public static Color color_calender_today
        {
            get { return color_calender_today_; }
        }

        public static Color color_calender_out
        {
            get { return color_calender_out_; }
        }

        public static Color color_gray1
        {
            get { return color_gray1_; }
        }

        public static Color color_gray2
        {
            get { return color_gray2_; }
        }

        public static Color color_done1
        {
            get { return color_done1_; }
        }

        public static Color color_done2
        {
            get { return color_done2_; }
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
