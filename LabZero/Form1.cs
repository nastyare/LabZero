using System;
using System.Windows.Forms;

namespace LabZero
{
    public partial class Form1 : Form
    {            
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private bool isError = false;
        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double d = 0;
            double p = 0;

            try
            {
                a = Convert.ToDouble(textBox1.Text);
                d = Convert.ToDouble(textBox2.Text);
                p = Convert.ToDouble(textBox3.Text);
                if (a <= 0 || d <= 0 || p <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели отрицательное число или ноль.", "Error", MessageBoxButtons.OK);
                isError = true;
            }
                
           

            try
            {
                if (d > a)
                {
                    throw new Exception();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Диаметр шара не может быть больше ребра куба.");
                isError= true;
            }

            if (!isError)
            { 
                double r = d / 2;
                double pow_r = Math.Pow(r, 3);

                double Vsh = ((double)4 / 3) * Math.PI * pow_r;

                double Vk = Math.Pow(a, 3);
                double Vd = Vk - Vsh;

                //p = p / 1000; 
                double res = Math.Round(p * Vd, 3);
                //res = res * 1000;

                textBox4.Text = res.ToString();
            } else
            {
                isError = false;
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
