using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace calculate
{
    public partial class Form_Main : Form
    {
        Stack st = new Stack();
        double num1, num2, tempresult, a;
        string Operator;




        //1-9的显示
        private void btn_0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }



        //      小数点的显示
        private void btn_point_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
                txtDisplay.Text = "0.0";
            else if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }


        //+的运算
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                  st.Push(txtDisplay.Text);
                if (st.Count>=3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                  //  tempresult = num1 + num2;
                //    st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);

                    }
                    else if(Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if(Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if(Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "%")
                    {
                        tempresult = num2 % num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();
                    
                }
                st.Push("+");
                txtDisplay.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }


        //-的运算
        private void btn_sub_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    //tempresult = num2 - num1;
                    //st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);

                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "%")
                    {
                        tempresult = num2 % num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();

                }
                st.Push("-");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }


        //除法的运算
        private void btn_div_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    
                   // tempresult = num1/num2;
                   // st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);

                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "%")
                    {
                        tempresult = num2 % num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();

                }
                st.Push("÷");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }


        //运算符=的操作
        private void btn_eqaul_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                  //  tempresult = num1 / num2;
                    //st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);

                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                       
                    }
                    else if (Operator == "%")
                    {
                        tempresult = num2 % num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();

                }
                txtDisplay.Text = tempresult.ToString();
                st.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }


        //退格操作
        private void btn_backbackspace_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            st.Clear();
        }


        //sqrt操作
        private void bun_sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double dd = 0;
                st.Push(txtDisplay.Text);
                dd = Math.Sqrt(Convert.ToDouble(st.Pop()));
                //num1= bun_sqrt()
                txtDisplay.Text = dd.ToString();
               

            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }


        //取余操作
        private void btn_quyu_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    // tempresult = num1/num2;
                    // st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);

                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if(Operator == "%")
                    {
                        tempresult = num2 % num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();

                }
                st.Push("%");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }


        //取倒数操作
        private void btn_turnover_Click(object sender, EventArgs e)
        {
            try {
                st.Push(txtDisplay.Text);
                double dd = 0;
                dd = 1 / Convert.ToDouble(st.Pop());
                txtDisplay.Text = dd.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
           

        }


        //求平方
        private void btn_dob_Click(object sender, EventArgs e)
        {
            try
            {
                double dd;
                st.Push(txtDisplay.Text);
                dd = Convert.ToDouble(st.Pop()) * Convert.ToDouble(st.Pop());
                txtDisplay.Text = dd.ToString();
            }
             catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
        }


        //求ln
        private void ln_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double dd;
                st.Push(txtDisplay.Text);
                dd = Math.Log(Convert.ToDouble(st.Pop()));
                txtDisplay.Text = dd.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
        }


        //求log10
        private void log_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double dd;
                st.Push(txtDisplay.Text);
                dd = Math.Log10(Convert.ToDouble(st.Pop()));
                txtDisplay.Text = dd.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
        }

        private void Exp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double dd;
                st.Push(txtDisplay.Text);
                dd = Math.Exp(Convert.ToDouble(st.Pop()));
                txtDisplay.Text = dd.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
        }

        private void sin_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double dd;
                st.Push(txtDisplay.Text);
                dd = Math.Sin(Convert.ToDouble(st.Pop()));
                txtDisplay.Text = dd.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
        }

        private void cos_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double dd;
                st.Push(txtDisplay.Text);
                dd = Math.Cos(Convert.ToDouble(st.Pop()));
                txtDisplay.Text = dd.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
        }

        private void Tan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double dd;
                st.Push(txtDisplay.Text);
                dd = Math.Tan(Convert.ToDouble(st.Pop()));
                txtDisplay.Text = dd.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);

            }
        }



        //     *的运算
        private void btn_multi_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    //tempresult = num1 * num2;
                    //st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);

                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "%")
                    {
                        tempresult = num2 % num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();

                }
                st.Push("×");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }
        

        



       

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
