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
    public partial class Form_Search : Form
    {

        //初始化显示要查找到学生信息的表头
        void InitHeadTitle()
        {
            //初始化dataGridView的列标题
            dataGridView1.Columns[0].HeaderText = "主键";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "学生编号";
            dataGridView1.Columns[2].HeaderText = "学生姓名";
            dataGridView1.Columns[3].HeaderText = "学生性别";
            dataGridView1.Columns[4].HeaderText = "学生年龄";
            dataGridView1.Columns[5].HeaderText = "出生日期";
            dataGridView1.Columns[6].HeaderText = "手机号码";
            dataGridView1.Columns[7].HeaderText = "家庭地址";
            dataGridView1.Columns[8].HeaderText = "电子邮箱";
            dataGridView1.Columns[9].HeaderText = "专    业";
            //dataGridView1.Columns[9].HeaderText = "";
        }



        public Form_Search()
        {
            InitializeComponent();
        }

        private void Form_Search_Load(object sender, EventArgs e)
        {

        }

       
       

        //关闭窗口
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //根据选择要查询的字段查找学生的信息并显示

        private void btn_search_Click(object sender, EventArgs e)
        {
            //依据选择的查询和输入查询值进行查询，如果两者都为空，则查询所有信息
            if (cb_searchitem.Text == string.Empty)
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
                InitHeadTitle();
            }
            else
            {
                if (cb_searchitem.Text != string.Empty)
                {
                    StudentInfo studentsearch = new StudentInfo();
                    switch (cb_searchitem.SelectedIndex)
                    {
                        case 0:
                            studentsearch.StudentId = Int32.Parse(txt_searchtxt.Text); break;
                        case 1:
                            studentsearch.Name = txt_searchtxt.Text; break;
                    }
                    dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(studentsearch);
                    InitHeadTitle();

                }
                else
                {
                    MessageBox.Show("请输入要查询的" + cb_searchitem.Text);
                }
            }
        }

        private void cb_searchitem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
