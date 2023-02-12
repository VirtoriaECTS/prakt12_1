using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_work
{


    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            stud.ves = (double)numericUpDown2.Value;
            stud.eda = (int)numericUpDown3.Value;
            stud.SetEat();
            MessageBox.Show($"Студент: {stud.name} \nрост: {stud.rost} \nвес: {stud.GetEat()} ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }

    public class Student
    {
        public string name;
        public int rost;
        public double ves;
        public int eda;
        public void SetEat()
        {
            // 2500 калорий нужно человеку
            if (eda < 5)
            {
                ves += (eda * 1000 - 2500);
            }
            else if (eda >= 5 && eda < 10)
            {
                rost = rost - 1;
                ves += (eda * 1000 - 1600) * 0.7;
            }
            else if (eda >= 10)
            {
                rost = rost - 2;
                ves += (eda * 1000 - 1800) * 0.5;
            }
        }
        public double GetEat()
        {
            return ves;
        }
    }
}
