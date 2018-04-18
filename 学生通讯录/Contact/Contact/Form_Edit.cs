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
    public partial class Form_Edit : Form
    {
        public int studentid_edit = 0;
        public int studentkey_edit = 0;
        public Form_Edit()
        {
            InitializeComponent();
        }

        private void Form_Edit_Load(object sender, EventArgs e)
        {
            initControl();
        }
        public void initControl()
        {
            //查询要编辑的学生信息并把编辑前的信息显示出来
            // StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo2(studentkey_edit);
            if (studentinfo != null)
            {
                txt_studentid.Text = studentinfo.StudentId.ToString();
                txt_name.Text = studentinfo.Name;
                if (studentinfo.Sex == "男")
                {
                    rb_man.Checked = true;
                    rb_woman.Checked = false;
                }
                else {
                    rb_man.Checked = false;
                    rb_woman.Checked = true;
                }
                txt_age.Text = studentinfo.Age.ToString();
                dt_birthday.Text = studentinfo.BirthDate.ToString();
                txt_phone.Text = studentinfo.Phone;
                txt_email.Text = studentinfo.Email;
                txt_homeaddress.Text = studentinfo.HomeAddress;
                txt_profession.Text = studentinfo.Profession;
            }
        }
        //编辑后更新
        private void btn_update_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo2 = StudentInfoBLL.GetStudentInfo2(studentkey_edit);
          //StudentInfo studentInfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            studentInfo2.StudentId = Int32.Parse(txt_studentid.Text);
            studentInfo2.Name = txt_name.Text;
            if (rb_man.Checked)
                studentInfo2.Sex = "男";
            else if (rb_woman.Checked)
            studentInfo2.Sex = "女";
            studentInfo2.Age = Int32.Parse(txt_age.Text);
            studentInfo2.BirthDate = DateTime.Parse(dt_birthday.Text);
            studentInfo2.Phone = txt_phone.Text;
            studentInfo2.Profession = txt_profession.Text;
            studentInfo2.HomeAddress = txt_homeaddress.Text;
            studentInfo2.Email = txt_email.Text;
            if (StudentInfoBLL.UpdateStudentInfo(studentInfo2))
                MessageBox.Show("数据修改成功！");
        }
        //关闭
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_birthday_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dt_birthday.Value.Year).ToString();
        }

       private void txt_email_TextChanged(object sender, EventArgs e)
        {
     /*       string a = txt_email.Text;
            if (!StudentInfoBLL.CheckBadStr(a))
                MessageBox.Show("email格式错误，请重新输入！", "错误", MessageBoxButtons.OK);*/
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
