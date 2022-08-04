using System.Drawing;

namespace TaskManage.Main
{
    internal class Common_Var
    {
        private static int menu_; //閲覧中のメニュー
        private static int clickpanel_ = -1; //カレンダーでクリックされたパネル
        private static int today_year_ = 0; // 今日の日付(年)
        private static int today_month_ = 0; // 今日の日付(月)
        private static int today_day_ = 0; // 今日の日付(日)

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

        // 今日の日付(年)
        public static int today_year
        {
            set
            {
                today_year_ = value;
            }
            get
            {
                return today_year_;
            }
        }

        // 今日の日付(月)
        public static int today_month
        {
            set
            {
                today_month_ = value;
            }
            get
            {
                return today_month_;
            }
        }

        // 今日の日付(日)
        public static int today_day
        {
            set
            {
                today_day_ = value;
            }
            get
            {
                return today_day_;
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
