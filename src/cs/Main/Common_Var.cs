using System.Drawing;

namespace TaskManage.Main
{
    internal class Common_Var
    {
        private static int menu_; //閲覧中のメニュー
        private static int clickpanel_ = -1; //カレンダーでクリックされたパネル

        private static Color main_color_ = Color.FromArgb(40, 40, 40); //ダークモード 基本色;
        private static Color sub_color_ = Color.FromArgb(240, 240, 240); //ライトモード 基本色
        private static Color submain_color_ = Color.FromArgb(80, 80, 80); //ダークモード サブ色
        private static Color subsub_color_ = Color.FromArgb(220, 220, 220); //ライトモード サブ色

        private static int menu1_done_year_ = 0; //開いている実績の年
        private static int menu1_done_month_ = 0; //開いている実績の月
        private static int menu1_done_day_ = 0; //開いている実績の日
        private static int menu1_done_ = 0; //実績数(全合計)
        private static int menu1_day_done_ = 0; //実績数(日)
        private static int menu1_open_done_ = -1; //開いている実績の番号
        private static int menu1_delete_done_ = 0; //削除された実績の数
        private static int menu2_1_task_ = 0; //タスク数
        private static int menu2_1_open_task_ = -1; // 開いているタスクの番号
        private static int menu2_1_delete_task_ = 0; // 削除されたタスクの数
        private static int menu2_2_memo_ = 0; //メモ数
        private static System.Collections.Generic.List<DAndDSizeChanger> menu2_2_panel_main_table_memo_sizeChanger_ = new System.Collections.Generic.List<DAndDSizeChanger>();
        private static System.Collections.Generic.List<bool> memo_save_ = new System.Collections.Generic.List<bool>(); //ファイルの保存状況 true:保存済み false:未保存

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

        public static int menu1_done_year
        {
            set
            {
                menu1_done_year_ = value;
            }
            get
            {
                return menu1_done_year_;
            }
        }

        public static int menu1_done_month
        {
            set
            {
                menu1_done_month_ = value;
            }
            get
            {
                return menu1_done_month_;
            }
        }

        public static int menu1_done_day
        {
            set
            {
                menu1_done_day_ = value;
            }
            get
            {
                return menu1_done_day_;
            }
        }

        public static int menu1_done
        {
            set
            {
                menu1_done_ = value;
            }
            get
            {
                return menu1_done_;
            }
        }

        public static int menu1_day_done
        {
            set
            {
                menu1_day_done_ = value;
            }
            get
            {
                return menu1_day_done_;
            }
        }

        public static int menu1_open_done
        {
            set
            {
                menu1_open_done_ = value;
            }
            get
            {
                return menu1_open_done_;
            }
        }

        public static int menu1_delete_done
        {
            set
            {
                menu1_delete_done_ = value;
            }
            get
            {
                return menu1_delete_done_;
            }
        }

        public static int menu2_1_task
        {
            set
            {
                menu2_1_task_ = value;
            }
            get
            {
                return menu2_1_task_;
            }
        }

        public static int menu2_1_open_task
        {
            set
            {
                menu2_1_open_task_ = value;
            }
            get
            {
                return menu2_1_open_task_;
            }
        }

        public static int menu2_1_delete_task
        {
            set
            {
                menu2_1_delete_task_ = value;
            }
            get
            {
                return menu2_1_delete_task_;
            }
        }

        public static int menu2_2_memo
        {
            set
            {
                menu2_2_memo_ = value;
            }
            get
            {
                return menu2_2_memo_;
            }
        }

        public static System.Collections.Generic.List<DAndDSizeChanger> menu2_2_panel_main_table_memo_sizeChanger
        {
            set
            {
                menu2_2_panel_main_table_memo_sizeChanger_ = value;
            }
            get
            {
                return menu2_2_panel_main_table_memo_sizeChanger_;
            }
        }

        public static System.Collections.Generic.List<bool> memo_save
        {
            set
            {
                memo_save_ = value;
            }
            get
            {
                return memo_save_;
            }
        }
    }
}
