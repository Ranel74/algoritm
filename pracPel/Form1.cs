using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracPel
{
    public partial class Form1 : Form
    {
        public double x = 0;
        public double y = 0;
        public double z = 0;
        public double res = 0;

        public int func = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
            label3.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        public void SolveProblem1()
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);

                double first;
                double res1;
                double second;
                double res2;
                double res3;

                first = Math.Pow(x, 1.0 / 3);
                first += Math.Pow(x, y + 2);
                first *= 10;
                res1 = Math.Sqrt(first);

                second = Math.Pow(Math.Asin(z), 2.0);
                res2 = Math.Abs(x - y);
                res3 = second - res2;

                res = res1 * res3;

                richTextBox1.Text = Convert.ToString(res);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text.Length >= 1 && textBox1.Text != "" && textBox2.Text != "")
            {
                SolveProblem1();
            }
            else
            {
                richTextBox1.Text = "В этом поле выводиться результат";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox3.Visible = true;
            groupBox3.Enabled = true;
            groupBox3.Location = new Point(65, 63);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            groupBox3.Visible = false;
            groupBox3.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                richTextBox2.ForeColor = Color.Red;
            }

            if (checkBox1.Checked == false)
            {
                richTextBox2.ForeColor = Color.Black;
            }
        }

        public int Function()
        {
            if (radioButton1.Checked)
            {
                func = 1;
            }
            if (radioButton2.Checked)
            {
                func = 2;
            }
            if (radioButton3.Checked)
            {
                func = 3;
            }
            return func;
        }

        public void SolveProblem2()
        {
            try
            {
                Function();

                double x1 = 0;
                double y1 = 0;

                double per = 0;
                double vtor = 0;
                double treri = 0;

                double rez1 = 0;

                x1 = Convert.ToDouble(textBox4.Text);
                y1 = Convert.ToDouble(textBox5.Text);

                if (x1 >= 1 && x1 < 5)
                {
                    if (func == 1)
                    {
                        per = Math.Pow(Math.Cos(x1), 2.0);
                        vtor = Math.Cos(x1);
                        treri = Math.Atan(vtor);
                        rez1 = per + treri;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                    if (func == 2)
                    {
                        per = Math.Pow(Math.Pow(x1, 2.0), 2.0);
                        vtor = Math.Pow(x1, 2.0);
                        treri = Math.Atan(vtor);
                        rez1 = per + treri;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                    if (func == 3)
                    {
                        per = Math.Pow(Math.Exp(x1), 2.0);
                        vtor = Math.Exp(x1);
                        treri = Math.Atan(vtor);
                        rez1 = per + treri;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                }
                else if (y1 > x1)
                {
                    if (func == 1)
                    {
                        per = Math.Pow((y1 - Math.Cos(x1)), 2);
                        vtor = Math.Cos(x1);
                        treri = Math.Atan(vtor);
                        rez1 = per + treri;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                    if (func == 2)
                    {
                        per = Math.Pow((y1 - Math.Pow(x1, 2.0)), 2);
                        vtor = Math.Pow(x1, 2.0);
                        treri = Math.Atan(vtor);
                        rez1 = per + treri;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                    if (func == 3)
                    {
                        per = Math.Pow((y1 - Math.Exp(x1)), 2);
                        double penis = Math.Exp(6);
                        vtor = Math.Exp(x1);
                        treri = Math.Atan(vtor);
                        rez1 = per + treri;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                }
                else
                {
                    if (func == 1)
                    {
                        per = Math.Pow((y1 + Math.Cos(x1)), 3);
                        vtor = per + 0.5;
                        rez1 = vtor;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                    if (func == 2)
                    {
                        per = Math.Pow((y1 + Math.Pow(x1, 2.0)), 3);
                        vtor = per + 0.5;
                        rez1 = vtor;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                    if (func == 3)
                    {
                        per = Math.Pow((y1 + Math.Exp(x1)), 3);
                        vtor = per + 0.5;
                        rez1 = vtor;
                        richTextBox2.Text = Convert.ToString(rez1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text != "" && textBox5.Text != "") && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                SolveProblem2();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text != "" && textBox5.Text != "") && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                SolveProblem2();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text != "" && textBox5.Text != "") && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                SolveProblem2();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if((textBox4.Text != "" && textBox5.Text != "") && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                SolveProblem2();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text != "" && textBox5.Text != "") && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                SolveProblem2();
            }
        }
    }
}
