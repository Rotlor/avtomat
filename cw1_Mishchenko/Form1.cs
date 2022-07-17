using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw1_Mishchenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int last_result, result, dve, tri;
        Boolean pressed = false;
        Random rnd = new Random();
        Image[] img = new Image[6];
        string numbers = "234";
        

        private void pic_ruchka_MouseDown(object sender, MouseEventArgs e)
        {
            pic_ruchka.Image = Properties.Resources.handleDown;
            pressed = true;
            timer.Interval = 200;
            timer.Start();
            img[0] = Properties.Resources.suit1;
            img[1] = Properties.Resources.suit2;
            img[2] = Properties.Resources.suit3;
            img[3] = Properties.Resources.suit4;
            img[4] = Properties.Resources.suit5;
            img[5] = Properties.Resources.suit6;
        }

        private void pic_ruchka_MouseUp(object sender, MouseEventArgs e)
        {
            pic_ruchka.Image = Properties.Resources.handleUp;
            pressed = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic1.Image = img[rnd.Next(0, 6)];
            pic2.Image = img[rnd.Next(0, 6)];
            pic3.Image = img[rnd.Next(0, 6)];
            if (pressed == false)
            {
                timer.Interval += timer.Interval/5;
                if (timer.Interval > 800)
                {
                    timer.Stop();
                    if (pic1.Image == pic2.Image && pic2.Image == pic3.Image)
                    {
                        last_result = 50;
                        result += last_result;
                        label_txt_result.Text = "Набрано очков: " + Convert.ToString(result);
                        label_txt_last_result.Text = "Последний результат: " + Convert.ToString(last_result);
                        tri++;
                        label_txt_tri.Text = "3 одинаковых картинки выпало " + Convert.ToString(tri) + " раз";
                        if (numbers.Contains(Convert.ToString(tri % 10))) //(numbers.Contains(Convert.ToString(tri).Substring(Convert.ToString(tri).Length - 1)))
                        {
                            label_txt_tri.Text += "а";
                        }
                    }
                    else if (pic1.Image == pic2.Image || pic1.Image == pic3.Image || pic2.Image == pic3.Image)
                    {
                        last_result = 10;
                        result += last_result;
                        label_txt_result.Text = "Набрано очков: " + Convert.ToString(result);
                        label_txt_last_result.Text = "Последний результат: " + Convert.ToString(last_result);
                        dve++;
                        label_txt_dve.Text = "2 одинаковых картинки выпало " + Convert.ToString(dve) + " раз";
                        if (numbers.Contains(Convert.ToString(dve % 10))) //(numbers.Contains(Convert.ToString(tri).Substring(Convert.ToString(tri).Length - 1)))
                        {
                            label_txt_dve.Text += "а";
                        }
                    }
                }
            }
        }
    }
}
