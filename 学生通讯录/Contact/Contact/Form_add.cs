using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class Form_add : Form
    {
        public Form_add()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = new StudentInfo();
            studentinfo.StudentId = Int32.Parse(txt_studentid.Text);
            studentinfo.Name = txt_name.Text;
            if (rb_man.Checked)
                studentinfo.Sex = "男";
            else if (rb_woman.Checked)
                studentinfo.Sex = "女";
            studentinfo.Age = Int32.Parse(txt_age.Text);
            studentinfo.BirthDate = DateTime.Parse(dt_birthday.Text);
            studentinfo.Phone = txt_phone.Text;
            studentinfo.Email = txt_email.Text;
            studentinfo.HomeAddress = txt_homeaddress.Text;
            studentinfo.Profession = txt_profession.Text;
            if (StudentInfoBLL.AddStudentInfo(studentinfo))
            {
                MessageBox.Show("添加学生信息成功！");
            }
            else
            {
                MessageBox.Show("添加学生信息失败！");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void Form_add_Load(object sender, EventArgs e)
        {

        }

        private void dt_birthday_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dt_birthday.Value.Year).ToString();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            /*string a = txt_email.Text;
            if (!StudentInfoBLL.CheckBadStr(a))
                MessageBox.Show("email格式错误，请重新输入！", "错误", MessageBoxButtons.OK);*/
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
