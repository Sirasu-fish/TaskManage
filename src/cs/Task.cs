using System;

namespace TaskManage
{
    internal class Task
    {
        private string name; //タスク名
        private DateTime term_from;
        private DateTime term_to;
        private string memo;

        public Task(string name, DateTime term_from, DateTime term_to, string memo)
        {
            this.name = name;
            this.term_from = term_from;
            this.term_to = term_to;
            this.memo = memo;
        }
    }
}
