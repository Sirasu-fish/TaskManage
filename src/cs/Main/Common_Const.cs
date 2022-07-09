namespace TaskManage.Main
{
    internal class Common_Const
    {
        private static int calender_num_ = 42; // カレンダーの表示日数
        private static int menu2_num_ = 2; // menu2の項目数
        private static int task_num_ = 99; // タスクの数
        private static int memo_num_ = 99; // メモの保存数
        private static int done_num_ = 50; // 実績数

        public static int menu2_num
        {
            get { return menu2_num_; }
        }
        public static int calender_num
        {
            get { return calender_num_; }
        }
        public static int task_num
        {
            get { return task_num_; }
        }
        public static int memo_num
        {
            get { return memo_num_; }
        }

        public static int done_num
        {
            get { return done_num_; }
        }
    }
}
