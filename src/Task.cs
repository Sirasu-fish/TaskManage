using System;

namespace TaskManage
{
    internal class Task
    {
        private string name;
        private Boolean term;
        private DateTime term_from;
        private DateTime term_to;
        private string memo;
        private int color;

        public Task(string name, Boolean term, DateTime term_from, DateTime term_to, string memo, int color)
        {
            this.name = name;
            this.term = term;
            this.term_from = term_from;
            this.term_to = term_to;
            this.memo = memo;
            this.color = color;
        }
    }
}
