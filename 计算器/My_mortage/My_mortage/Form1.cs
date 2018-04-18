using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_mortage
{
    public partial class Form1 : Form
    {
        RadioButton mortage;
        public Form1()
        {
            InitializeComponent();
        }
        double m_pay, m_mortage, t_mortage;//月均还款 月均利息  总利息
        double  money,rate;//月数，年份，总额，利率
        int month,year;


        //按钮选择
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

       
        private void rad_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_1.Checked)
            {
                mortage = rad_1;
               
            }
        }

        private void rad_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_2.Checked)
            {
                mortage = rad_2;
            }
        }


        //按键执行
        private void button1_Click(object sender, EventArgs e)
        {
          
                try
                {
                    year = Convert.ToInt16(textBox1.Text);
                    month = year * 12;
                }
                catch (Exception)
                {
                    MessageBox.Show("先输入贷款年限才能进行此运算！", "错误", MessageBoxButtons.OK);
                }
                try
                {
                    money = Convert.ToDouble(textBox2.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("先输入贷款金额才能进行此运算！", "错误", MessageBoxButtons.OK);
                }
                try
                {
                    rate = Convert.ToDouble(textBox3.Text) / 100;

                }
                catch (Exception)
                {
                    MessageBox.Show("先输入贷款利率才能进行此运算！", "错误", MessageBoxButtons.OK);
                }
                //判断哪种方式
                if (mortage == rad_1)
                {
                    m_pay = (money*10000 * rate * Math.Pow((1 + rate), month)) / (Math.Pow((1 + rate), month) - 1);
                    m_mortage = money *10000* rate * (Math.Pow((1 + rate), month) - Math.Pow((1 + rate), (month % 12 + (month / 12) * 12) - 1)) / (Math.Pow((1 + rate), month) - 1);
                    t_mortage = month *10000* m_pay - money;
                    textBox4.Text = m_pay.ToString();
                    textBox5.Text = t_mortage.ToString();
                    textBox6.Text = (t_mortage + money).ToString();
                    
                }
                else if(mortage == rad_2)
                {

                m_pay = (money / month) + (money*10000-(money*10000/month)) * rate;
                m_mortage = (money*10000 - (money*10000 / month)) * rate;
                t_mortage = ((money / month + money * rate) + money / month * (1 + rate)) / 2 * month - money;
                    textBox4.Text = m_pay.ToString();
                    textBox5.Text = t_mortage.ToString();
                    textBox6.Text = (t_mortage + money).ToString();
                   
                }
           }
                   
        }
    }

