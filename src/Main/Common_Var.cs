using System.Drawing;

namespace TaskManage.Main
{
    internal class Common_Var
    {
        private static int menu_; //閲覧中のメニュー
        private static int clickpanel_ = -1; //カレンダーでクリックされたパネル

        private static Color main_color_ = Color.FromArgb(40, 40, 40); //ダークモード 基本色;
        private static Color sub_color_;
        private static Color submain_color_;
        private static Color subsub_color_;



        public Common_Var()
        {

            sub_color_ = Color.FromArgb(240, 240, 240); //ライトモード 基本色
            submain_color_ = Color.FromArgb(80, 80, 80); //ダークモード サブ色
            subsub_color_ = Color.FromArgb(220, 220, 220); //ライトモード サブ色
        }

        // 現在のmenuの取得、設定
        public static int menu
        {
            set
            {
                menu_ = value;
            }
            get
            {
                return menu_;
            }
        }

        // カレンダーのクリックされたパネル
        public static int clickpanel
        {
            set
            {
                clickpanel_ = value;
            }
            get
            {
                return clickpanel_;
            }
        }

        // メインカラー
        public static Color main_color
        {
            set
            {
                main_color_ = value;
            }
            get
            {
                return main_color_;
            }
        }

        public static Color sub_color
        {
            set
            {
                sub_color_ = value;
            }
            get
            {
                return sub_color_;
            }
        }

        public static Color submain_color
        {
            set
            {
                submain_color_ = value;
            }
            get
            {
                return submain_color_;
            }
        }

        public static Color subsub_color
        {
            set
            {
                subsub_color_ = value;
            }
            get
            {
                return subsub_color_;
            }
        }
    }
}
