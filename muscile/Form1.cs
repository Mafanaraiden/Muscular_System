using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muscile
{
    public partial class Form1 : Form
    {
       string str_1;double G = 4, MF = 1, I = 2, MX = 1; // составляющие
        double  n, step; // коэффициенты
        double f1 = 1, f2= 0.51,  f3= 0.49, f4 = 0.69,  f5 = 0.47, f6 = 1.25, f7 = 0.89, f8 = 0.13, f9 = 0.63, f10 = 1.86, f11 = 1.34;

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f5 > 0.5 || f5 < 0)
                {
                    throw new Exception();
                }

                f5 = (double)numericUpDown5.Value;
                trackBar5.Value = (int)(f5 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f5 >= 0.5)
                {
                    f5 = trackBar5.Maximum / 100.0;
                    numericUpDown5.Value = (decimal)f5;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f5 <= 0)
                {
                    f5 = trackBar5.Minimum / 100.0;
                    numericUpDown5.Value = (decimal)f5;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f7 > 2 || f7 < 0)
                {
                    throw new Exception();
                }

                f7 = (double)numericUpDown7.Value;
                trackBar7.Value = (int)(f7 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f7 >= 2)
                {
                    f7 = trackBar7.Maximum / 100.0;
                    numericUpDown7.Value = (decimal)f7;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f7 <= 0)
                {
                    f7 = trackBar7.Minimum / 100.0;
                    numericUpDown7.Value = (decimal)f7;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f8 > 2 || f8 < 0)
                {
                    throw new Exception();
                }

                f8 = (double)numericUpDown8.Value;
                trackBar8.Value = (int)(f8 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f8 >= 2)
                {
                    f8 = trackBar8.Maximum / 100.0;
                    numericUpDown8.Value = (decimal)f8;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f8 <= 0)
                {
                    f8 = trackBar8.Minimum / 100.0;
                    numericUpDown8.Value = (decimal)f8;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f9 > 2 || f9 < 0)
                {
                    throw new Exception();
                }

                f9 = (double)numericUpDown9.Value;
                trackBar9.Value = (int)(f9 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f9 >= 2)
                {
                    f9 = trackBar9.Maximum / 100.0;
                    numericUpDown9.Value = (decimal)f9;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f9 <= 0)
                {
                    f9 = trackBar9.Minimum / 100.0;
                    numericUpDown9.Value = (decimal)f9;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f10 > 2 || f10 < 0)
                {
                    throw new Exception();
                }

                f10 = (double)numericUpDown10.Value;
                trackBar10.Value = (int)(f10 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f10 >= 2)
                {
                    f10 = trackBar10.Maximum / 100.0;
                    numericUpDown10.Value = (decimal)f10;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f10 <= 0)
                {
                    f10 = trackBar10.Minimum / 100.0;
                    numericUpDown10.Value = (decimal)f10;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f11 > 2 || f11 < 0)
                {
                    throw new Exception();
                }

                f11 = (double)numericUpDown11.Value;
                trackBar11.Value = (int)(f11 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f11 >= 2)
                {
                    f11 = trackBar11.Maximum / 100.0;
                    numericUpDown11.Value = (decimal)f11;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f11 <= 0)
                {
                    f11 = trackBar11.Minimum / 100.0;
                    numericUpDown11.Value = (decimal)f11;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            f11 = trackBar11.Value / 100.0;
            numericUpDown11.Value = (decimal)f11;
            func();
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            f10 = trackBar10.Value / 100.0;
            numericUpDown10.Value = (decimal)f10;
            func();
            start();
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            f9 = trackBar9.Value / 100.0;
            numericUpDown9.Value = (decimal)f9;
            func();
            start();
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            f8 = trackBar8.Value / 100.0;
            numericUpDown8.Value = (decimal)f8;
            func();
            start();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            f7 = trackBar7.Value / 100.0;
            numericUpDown7.Value = (decimal)f7;
            func();
            start();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            f6 = trackBar6.Value / 100.0;
            numericUpDown6.Value = (decimal)f6;
            func();
            start();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            f5 = trackBar5.Value / 100.0;
            numericUpDown5.Value = (decimal)f5;
            func();
            start();
        }

        private void trackBar11_Scroll_1(object sender, EventArgs e)
        {
            f11 = trackBar11.Value / 100.0;
            numericUpDown11.Value = (decimal)f11;
            func();
            start();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f6 > 2 || f6 < 0)
                {
                    throw new Exception();
                }

                f6 = (double)numericUpDown6.Value;
                trackBar6.Value = (int)(f6 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f6 >= 2)
                {
                    f6 = trackBar6.Maximum / 100.0;
                    numericUpDown6.Value = (decimal)f6;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f6 <= 0)
                {
                    f6 = trackBar6.Minimum / 100.0;
                    numericUpDown6.Value = (decimal)f6;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f4 > 1 || f4 < 0)
                {
                    throw new Exception();
                }

                f4 = (double)numericUpDown4.Value;
                trackBar4.Value = (int)(f4 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f4 >= 1)
                {
                    f4 = trackBar4.Maximum / 100.0;
                    numericUpDown4.Value = (decimal)f4;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f4 <= 0)
                {
                    f4 = trackBar4.Minimum / 100.0;
                    numericUpDown4.Value = (decimal)f4;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            f4 = trackBar4.Value / 100.0;
            numericUpDown4.Value = (decimal)f4;
            func();
            start();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f3 > 2 || f3 < 0)
                {
                    throw new Exception();
                }

                f3 = (double)numericUpDown3.Value;
                trackBar3.Value = (int)(f3 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f3 >= 2)
                {
                    f3 = trackBar3.Maximum / 100.0;
                    numericUpDown3.Value = (decimal)f3;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f3 <= 0)
                {
                    f3 = trackBar3.Minimum / 100.0;
                    numericUpDown3.Value = (decimal)f3;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            f3 = trackBar3.Value / 100.0;
            numericUpDown3.Value = (decimal)f3;
            func();
            start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start();
            label1.Text = "Коэффциент взаимодействия гормонов и миофибрилл";
            chart1.Series.Clear();
            chart2.Series.Clear();

            chart1.Series.Add("Изменение массы миофбрилл");
            chart2.Series.Add("Изменение массы митохондрий");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            trackBar1.Minimum = 100;
            trackBar1.Maximum = 200;
            trackBar1.TickFrequency = 2;
            numericUpDown1.Value = (decimal)f1;
            numericUpDown1.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown1.Increment = (decimal)((trackBar1.Maximum - trackBar1.Minimum) / 10000.0);
            //
            trackBar2.Minimum = 50;
            trackBar2.Maximum = 200;
            trackBar2.TickFrequency = 2;
            numericUpDown2.Value = (decimal)f2;
            numericUpDown2.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown2.Increment = (decimal)((trackBar2.Maximum - trackBar2.Minimum) / 15000.0);
            //
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 200;
            trackBar3.TickFrequency = 2;
            numericUpDown3.Value = (decimal)f3;
            numericUpDown3.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown3.Increment = (decimal)((trackBar3.Maximum - trackBar3.Minimum) / 20000.0);
            //
            trackBar4.Minimum = 0;
            trackBar4.Maximum = 100;
            trackBar4.TickFrequency = 2;
            numericUpDown4.Value = (decimal)f4;
            numericUpDown4.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown4.Increment = (decimal)((trackBar4.Maximum - trackBar4.Minimum) / 10000.0);
            //
            trackBar5.Minimum = 0;
            trackBar5.Maximum = 50;
            trackBar5.TickFrequency = 2;
            numericUpDown5.Value = (decimal)f5;
            numericUpDown5.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown5.Increment = (decimal)((trackBar5.Maximum - trackBar5.Minimum) / 5000.0);
            //
            trackBar6.Minimum = 0;
            trackBar6.Maximum = 200;
            trackBar6.TickFrequency = 2;
            numericUpDown6.Value = (decimal)f6;
            numericUpDown6.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown6.Increment = (decimal)((trackBar6.Maximum - trackBar6.Minimum) / 20000.0);
            //
            trackBar7.Minimum = 0;
            trackBar7.Maximum = 200;
            trackBar7.TickFrequency = 2;
            numericUpDown7.Value = (decimal)f7;
            numericUpDown7.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown7.Increment = (decimal)((trackBar7.Maximum - trackBar7.Minimum) / 20000.0);
            //
            trackBar8.Minimum = 0;
            trackBar8.Maximum = 200;
            trackBar8.TickFrequency = 2;
            numericUpDown8.Value = (decimal)f8;
            numericUpDown8.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown8.Increment = (decimal)((trackBar8.Maximum - trackBar8.Minimum) / 20000.0);
            //
            trackBar9.Minimum = 0;
            trackBar9.Maximum = 200;
            trackBar9.TickFrequency = 2;
            numericUpDown9.Value = (decimal)f9;
            numericUpDown9.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown9.Increment = (decimal)((trackBar9.Maximum - trackBar9.Minimum) / 20000.0);
            //
            trackBar10.Minimum = 0;
            trackBar10.Maximum = 200;
            trackBar10.TickFrequency = 2;
            numericUpDown10.Value = (decimal)f10;
            numericUpDown10.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown10.Increment = (decimal)((trackBar10.Maximum - trackBar10.Minimum) / 20000.0);
            //
            trackBar11.Minimum = 0;
            trackBar11.Maximum = 200;
            trackBar11.TickFrequency = 2;
            numericUpDown11.Value = (decimal)f11;
            numericUpDown11.DecimalPlaces = 2; //количество знаков после запятой
            numericUpDown11.Increment = (decimal)((trackBar11.Maximum - trackBar11.Minimum) / 20000.0);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f2 > 2 || f2 < 0.5)
                {
                    throw new Exception();
                }

                f2 = (double)numericUpDown2.Value;
                trackBar2.Value = (int)(f2 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f2 >= 2)
                {
                    f2 = trackBar2.Maximum / 100.0;
                    numericUpDown2.Value = (decimal)f2;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f2 <= 0.5)
                {
                    f2 = trackBar2.Minimum / 100.0;
                    numericUpDown2.Value = (decimal)f2;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            f2 = trackBar2.Value / 100.0;
            numericUpDown2.Value = (decimal)f2;
            func();
            start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (f1 > 2 || f1 < 1)
                {
                    throw new Exception();
                }

                f1 = (double)numericUpDown1.Value;
                trackBar1.Value = (int)(f1 * 100);
                func();
                start();
            }
            catch (Exception exp)
            {
                if (f1 >= 2)
                {
                    f1 = trackBar1.Maximum / 100.0;
                    numericUpDown1.Value = (decimal)f1;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
                else if (f1 <= 1)
                {
                    f1 = trackBar1.Minimum / 100.0;
                    numericUpDown1.Value = (decimal)f1;
                    MessageBox.Show("Ошибка", "Значение выходит за доступные пределы");
                }
            }
        }
               
        double dMF_func()
        {
            return f1 * G * MF * (f2 + Math.Pow(I, n)) - MF*(f3+f4*I);
        }

        double dMX_func()
        {
            return f5 * MX * (1 - Math.Exp((-1) * G * f6))* (1 - Math.Exp((-1) * I * f7))*(f8 - MX/MF)+f9*MX - MX*(f10+f11*Math.Pow(I,n));
        }

        void func() // Решение уравнений методом Эйлера
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();

            List<double> a1 = new List<double>();
            List<double> a2 = new List<double>();

            double x = 0, y1 = MF, y2 = MX;
            chart1.Series[0].Points.AddXY(x, MF);
            chart2.Series[0].Points.AddXY(x, MX);
            x += step;
            for (int i = 0; i < 14; i++)
            {
                MF += step * dMF_func();
                MX += step * dMX_func();
                chart1.Series[0].Points.AddXY(x, MF);
                chart2.Series[0].Points.AddXY(x, MX);
                a2.Add(MX);
                x += step;
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            f1 = trackBar1.Value / 100.0;
            numericUpDown1.Value = (decimal)f1;
            func();
            start();
        }

        void start() //начальные условия
        {
            n = 1;
            MF = 1; MX =70; I = 2; G = 4;
            step = 0.1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
