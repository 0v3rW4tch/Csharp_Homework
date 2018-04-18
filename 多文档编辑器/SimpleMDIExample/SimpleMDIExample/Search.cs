using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleMDIExample
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
       
        Form1 fn1;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            
                Form1 fn1 = (Form1)this.Owner;
                if (textBox1.Text.Length != 0)//如果查找字符串不为空,调用主窗体查找方法
                {
                    fn1.FindRichTextBoxString(textBox1.Text, true);
                   // setbutton();
                }
                else
                {
                    MessageBox.Show("查找字符串不能为空", "提示", MessageBoxButtons.OK);
                  //  setbutton();
                }
           
        }




        //替换作用
        private void button1_Click(object sender, EventArgs e)
        {
            fn1 = (Form1)this.Owner;
            if (textBox2.Text.Length != 0)//如果查找字符串不为空,调用主窗体替换方法
            {
              //  fn1.ReverseFindRichTextBoxString(textBox1.Text, true);
                fn1.replacertbs(textBox1.Text, textBox2.Text, true);
            }
            else      //方法MainForm1.ReplaceRichTextBoxString
                MessageBox.Show("替换字符串不能为空", "提示", MessageBoxButtons.OK);
        }

        
    }
}
