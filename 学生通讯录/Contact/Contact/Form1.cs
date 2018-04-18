using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Contact
{
    public partial class Form_Main : Form
    {

        void initContracts()//从xml文件中查询并显示在dataGridView1控件中
        {
            /*
             如果存在xml,查询所有学生信息，如果不存在，则创建该文件后再查询
             */
            if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml"))
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            else
            {
                StudentInfoBLL.CreatStudentXml();
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            //初始化表格的列标题
            dataGridView1.Columns[0].HeaderText = "主键";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "学生编号";
            dataGridView1.Columns[2].HeaderText = "学生姓名";
            dataGridView1.Columns[3].HeaderText = "学生性别";
            dataGridView1.Columns[4].HeaderText = "学生年龄";
            dataGridView1.Columns[5].HeaderText = "出生日期";
            dataGridView1.Columns[6].HeaderText = "手机号码";
            dataGridView1.Columns[7].HeaderText = "家庭住址";
            dataGridView1.Columns[8].HeaderText = "电子邮箱";
            dataGridView1.Columns[9].HeaderText = "专    业";
        }
        public Form_Main()
        {
            InitializeComponent();
            initContracts();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
           
        }

        //add按钮添加，用于打开学生信息窗体
        private void toolStrip_add_Click(object sender, EventArgs e)
        {
            Form_add formadd = new Form_add();
            formadd.ShowDialog();
            initContracts();
            StudentInfoBLL.BackupStudentXml();
          
        }



        //edit按钮添加事件并能编辑
        private void toolStrip_Edit_Click(object sender, EventArgs e)
        {
            ///选中某一个学生信息后，打开编辑学生信息窗体
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
                int selectrow_key = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form_Edit formedit = new Form_Edit();
                //    formedit.studentid_edit = selectrow;
                formedit.studentid_edit = selectrow;
                formedit.studentkey_edit = selectrow_key;
                formedit.ShowDialog();
                StudentInfoBLL.BackupStudentXml();
                initContracts();
            }
            else
            {
                MessageBox.Show("请选中一行后再点击编辑按钮");
            }
        }


        //delete按钮事件
        private void toolStrip_delete_Click(object sender, EventArgs e)
        {
            //选中一个学生信息并删除
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("确定要删除此学生信息？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    if (StudentInfoBLL.DeleteStudentInfo(selectrow))
                        MessageBox.Show("删除学生信息成功！");
                    else
                    {
                        MessageBox.Show("删除学生信息失败，请检查是否选中学生信息！");

                    }
                    initContracts();
                 
                }

            }
            else
            {
                MessageBox.Show("请选中一行后再点击删除按钮！");
            }
        }


        //search查找事件  查询学生信息
        private void toolStrip_search_Click(object sender, EventArgs e)
        {
            //打开查询信息窗体
            Form_Search fromsearch = new Form_Search();
            fromsearch.ShowDialog();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip_backup_Click(object sender, EventArgs e)
        {
            StudentInfoBLL.BackupStudentXml();
            MessageBox.Show("备份成功！");

        }      

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            
        }

        private void toolStrip_recovery_Click(object sender, EventArgs e)
        {
            StudentInfoBLL.RecoveryStudentXml();
            initContracts();
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "计算机科学与技术")
            {
                StudentInfo s = new StudentInfo();
                s.Profession = "计算机科学与技术";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(s);
            }
            else if (treeView1.SelectedNode.Text == "信息安全")
            {
                StudentInfo s = new StudentInfo();
                s.Profession = "信息安全";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(s);
            }
            else if (treeView1.SelectedNode.Text == "电子信息科学与技术")
            {
                StudentInfo s = new StudentInfo();
                s.Profession = "电子信息科学与技术";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(s);
            }
            else if (treeView1.SelectedNode.Text == "男")
            {
                StudentInfo s = new StudentInfo();
                s.Sex = "男";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(s);
            }
            else if (treeView1.SelectedNode.Text == "女")
            {
                StudentInfo s = new StudentInfo();
                s.Sex = "女";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(s);
            }
            else
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
        }
    }
}
