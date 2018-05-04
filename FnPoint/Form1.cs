using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FnPoint
{
    public partial class Form1 : Form
    {
        public int ipt;
        public int otps;
        public int inqry;
        public int intfiles;
        public int extfiles;
        public int ufp = 0;
        public double fp;
        int sum_di;

        public void UFnPoint()
        {
            ipt = int.Parse(textBox1.Text);
            otps = int.Parse(textBox2.Text);
            inqry = int.Parse(textBox3.Text);
            intfiles = int.Parse(textBox4.Text);
            extfiles = int.Parse(textBox5.Text);
            


            if (comboBox1.SelectedItem == "simple")
            {
                ufp += ipt * 3;
            }
            else if (comboBox1.SelectedItem == "average")
            {
                ufp += ipt * 4;
            }
            else if (comboBox1.SelectedItem == "complex")
            {
                ufp += ipt * 6;
            }

            //=======================================================
            if (comboBox2.SelectedItem == "simple")
            {
                ufp += otps * 4;
            }
            else if (comboBox2.SelectedItem == "average")
            {
                ufp += otps * 5;
            }
            else if (comboBox2.SelectedItem == "complex")
            {
                ufp += otps * 7;
            }
            //==========================================================
            if (comboBox3.SelectedItem == "simple")
            {
                ufp += inqry * 3;
            }

            else if (comboBox3.SelectedItem == "average")
            {
                ufp += inqry * 4;
            }

            else if (comboBox3.SelectedItem == "complex")
            {
                ufp += inqry * 6;
            }
            //============================================================
            if (comboBox4.SelectedItem == "simple")
            {
                ufp += intfiles * 7;
            }

            else if (comboBox4.SelectedItem == "average")
            {
                ufp += intfiles * 10;
            }

            else if (comboBox4.SelectedItem == "complex")
            {
                ufp += intfiles * 15;
            }
            //==============================================================
            if (comboBox5.SelectedItem == "simple")
            {
                ufp += extfiles * 5;
            }

            else if (comboBox5.SelectedItem == "average")
            {
                ufp += extfiles * 7;
            }

            else if (comboBox5.SelectedItem == "complex")
            {
                ufp += extfiles * 10;
            }


        }
        public void Di()
        {
            int fact1 =comboBox6.SelectedIndex;
            int fact2 = comboBox7.SelectedIndex;
            int fact3 = comboBox8.SelectedIndex;
            int fact4 = comboBox9.SelectedIndex;
            int fact5 = comboBox10.SelectedIndex;
            int fact6 = comboBox11.SelectedIndex;
            int fact7 = comboBox12.SelectedIndex;
            int fact8 = comboBox13.SelectedIndex;
            int fact9 = comboBox14.SelectedIndex;
            int fact10 = comboBox15.SelectedIndex;
            int fact11 = comboBox16.SelectedIndex;
            int fact12 = comboBox17.SelectedIndex;
            int fact13 = comboBox18.SelectedIndex;
            int fact14 = comboBox19.SelectedIndex;
            sum_di = fact1 + fact2 + fact3 + fact4 + fact5 + fact6 + fact7 + fact8 + fact9 + fact10 + fact11 + fact12 + fact13 + fact14;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UFnPoint();
            textBox6.Text = ufp.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Di();
            fp = ufp * (0.65 + (0.01 * sum_di));

            textBox7.Text = fp.ToString();
        }

    }
}
