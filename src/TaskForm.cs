using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManege
{
    
    public partial class TaskForm : Form
    {
        int color = -1;
        int prio = -1;

        public TaskForm()
        {
            InitializeComponent();
            TaskForm_Load();
        }
        private void main_button_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetDayTo(int year, int month, int day)
        {
            Set_YearMonthDayTo(year, month, day);
        }

        private void main_panel5_panel1_panel1_Click(object sender, EventArgs e)
        {
            color = 1;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel2_Click(object sender, EventArgs e)
        {
            color = 2;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel3_Click(object sender, EventArgs e)
        {
            color = 3;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel4_Click(object sender, EventArgs e)
        {
            color = 4;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel5_Click(object sender, EventArgs e)
        {
            color = 5;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel6_Click(object sender, EventArgs e)
        {
            color = 6;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel7_Click(object sender, EventArgs e)
        {
            color = 7;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel8_Click(object sender, EventArgs e)
        {
            color = 8;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel9_Click(object sender, EventArgs e)
        {
            color = 9;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel10_Click(object sender, EventArgs e)
        {
            color = 10;
            Set_ColorCheck(color);
        }

        private void main_panel5_panel1_panel11_Click(object sender, EventArgs e)
        {
            color = 11;
            Set_ColorCheck(color);
        }

        private void main_table4_panel1_panel1_label_Click(object sender, EventArgs e)
        {
            prio = 1;
            Set_PrioCheck(prio);
        }

        private void main_table4_panel1_panel2_label_Click(object sender, EventArgs e)
        {
            prio = 2;
            Set_PrioCheck(prio);
        }

        private void main_table4_panel1_panel3_label_Click(object sender, EventArgs e)
        {
            prio = 3;
            Set_PrioCheck(prio);
        }
    }
}
