using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Recreate;
using System.Drawing.Drawing2D;

namespace RecreateForm
{
    public partial class Form1 : Form

    {

        vm m = new vm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
            try
            {
                int num = Convert.ToInt32(this.textBox8.Text);
                m.delcpu1(num);
                this.label3.Text = Convert.ToString(m.amount1());
            }
            catch (Recreate.OverflowException)
            {
                this.textBox7.Text = "Произошло переполнение cpu";
            }

            catch
            {
                this.textBox7.Text = "Ошибка при удалении CPU. Вероятно, неправильно введен номер СPU или его не существует. Попробуйте еще раз";
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.label3.Text = "0";
            this.label4.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
            try
            {
                Cpu1 c1 = new Cpu1();
                int min = Convert.ToInt32(this.textBox3.Text);
                int max = Convert.ToInt32(this.textBox4.Text);
                c1.setscop(min, max);
                m.addcpu1(c1);
                this.label3.Text = Convert.ToString(m.amount1());
            } 
            catch
            {
                this.textBox7.Text = "Ошибка при создании CPU1. Попробуйте еще раз";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
            try
            {
                Cpu2 c2 = new Cpu2();
                int min = Convert.ToInt32(this.textBox5.Text);
                int max = Convert.ToInt32(this.textBox6.Text);
                c2.setscop(min, max);
                m.addcpu2(c2);
                this.label4.Text = Convert.ToString(m.amount2());
            }
            catch
            {
                this.textBox7.Text = "Ошибка при создании CPU2. Попробуйте еще раз";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.textBox7.Text = "";
            try
            {
                int num = Convert.ToInt32(this.textBox9.Text);
                m.delcpu2(num);
                this.label3.Text = Convert.ToString(m.amount2());
            }
            catch
            {
                this.textBox7.Text = "Ошибка при удалении CPU. Вероятно, неправильно введен номер СPU или его не существует. Попробуйте еще раз";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
            try
            {
                int x, y, r;
                char s, c;
                x = Convert.ToInt32(this.textBox2.Text);
                y = Convert.ToInt32(this.textBox1.Text);
                s = Convert.ToChar(this.comboBox1.SelectedItem);

                r = m.realization(x, y, s);

                this.label6.Text = Convert.ToString(r);

            } catch (DivideByZeroException)
            {
                this.textBox7.Text = "Нельзя делить на 0";
            }
            catch (Recreate.OverflowException)
            {
                this.textBox7.Text = "Произошло переполнение";
            }
            catch
            {
                this.textBox7.Text = "Ошибка при расчете. Попробуйте еще раз";
            }
            
        }
        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        PrivateFontCollection font;
        private void fontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("font/Alice.ttf");
            this.font.AddFontFile("font/Modestina.ttf");
            this.font.AddFontFile("font/serp_and_molot.ttf");
        }

        private void fonts()
        {
            //Задаем шрифт текста, отображаемого элементом управления.
            label1.Font = new Font(font.Families[0], 31);//Alice.ttf
            label2.Font = new Font(font.Families[1], 31);//Modestina.ttf
            label3.Font = new Font(font.Families[2], 31);//serp_and_molot.ttf
        }

        
    }
}
