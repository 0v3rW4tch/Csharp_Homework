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
using System.Web;
using System.Web.UI;

namespace SimpleMDIExample
{
    public partial class Form1 : Form
    {
        //记录新建文档数目及显示窗口标题
        private int _Num = 1;
        public Form1()
        {
            InitializeComponent();
        }
        public float[] FontSize = { 8, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72, 42, 36, 26, 24, 22, 18, 16, 15, 14, 12, 10.5F, 9, 7.5F, 6.5F, 5.5F, 5 };
        //定义字号数组
        //定义字体大小名字
        public string[] FontSizeName = { "8", "9", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72", "初号", "小初", "一号", "小一", "二号", "小二", "三号", "小三", "四号", "小四", "五号", "小五", "六号", "小六", "七号", "八号" };
        private void Form1_Load(object sender, EventArgs e)
        {

            //获取系统所有字体，将字体名称显示在下拉框中
            tSCbBoxFontName.Items.Clear();//改为ComboBox控件
            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)
                tSCbBoxFontName.Items.Add(ff.GetName(1));
            tSCbBoxFontSizeName.Items.Clear();
            InstalledFontCollection ifd = new InstalledFontCollection();
            //Font [] ffs2 = ifd.Dispose();
            // for(int i =8;i<=11;i++)
            foreach (string name in FontSizeName)
                tSCbBoxFontSizeName.Items.Add(name);           
            LayoutMdi(MdiLayout.Cascade);
            Text = "多文档文本编辑器";
            //WindowState = FormWindowState.Maximized;    最大化不好看
        }


        //给窗口事件添加代码
        private void 窗口层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);//在MDI父窗体内排列MDI子窗体
            this.窗口层叠ToolStripMenuItem.Checked = true;
            this.垂直平铺ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = false;
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = true;
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = true;
            this.水平平铺ToolStripMenuItem.Checked = false;
        }

        private void NewDoc()//新建文档，由于后面多处用到，便写一个方法方便调用
        {
            FrmDoc fd = new FrmDoc();
            fd.MdiParent = this;
            fd.Text = "文档" + _Num;
            fd.WindowState = FormWindowState.Maximized;
            fd.Show();
            fd.Activate();
            _Num++;
        }

        private void 新建NToolStripButton_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "RTF格式(*.rtf)|*.rtf|文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;
                    //将文本内容显示在富文本框中
                    if (openfiledialog1.FilterIndex == 1)//.rtf文件
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile(openfiledialog1.FileName, RichTextBoxStreamType.RichText);
                    else //.txt文件
                    {
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile(openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        ((FrmDoc)this.ActiveMdiChild).Text = openfiledialog1.FileName;

                    }
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            openfiledialog1.Dispose();
        }




        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc fn = (FrmDoc)this.ActiveMdiChild;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = fn.Text;
                fn.rTBDoc.Modified = false;
                if (fn.Name.Length != 0)
                {
                    string s = saveFileDialog1.FileName;
                    if (s.EndsWith("txt"))
                    {
                        fn.rTBDoc.SaveFile(s, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        fn.rTBDoc.SaveFile(s, RichTextBoxStreamType.RichText);
                    }
                }
                else
                    另存为AToolStripMenuItem_Click(sender, e);

            }
            catch { }

        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (MessageBox.Show("确定要关闭当前文档吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    ((FrmDoc)this.ActiveMdiChild).Close();
            }
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出应用程序吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach (FrmDoc fd in this.MdiChildren)
                    fd.Close();
                Application.Exit();
            }
        }

        

        //用于改变字体属性的方法
        private void ChangeRTBFontStyle(RichTextBox rtb, FontStyle style)
        {
            if (style != FontStyle.Bold && style != FontStyle.Italic && style != FontStyle.Underline)//针对粗体，斜体，下划线
                throw new System.InvalidProgramException("字体格式错误");
            RichTextBox tempRTB = new RichTextBox();
            int curRtbStart = rtb.SelectionStart;
            int len = rtb.SelectionLength;
            int tempRtbStart = 0;
            Font font = rtb.SelectionFont;
            if (len <= 0 && font != null)
            {
                if (style == FontStyle.Bold && font.Bold || style == FontStyle.Italic && font.Italic || style == FontStyle.Underline && font.Underline)
                    rtb.Font = new Font(font, font.Style ^ style);
                else
                    if (style == FontStyle.Bold && font.Bold || style == FontStyle.Italic && !font.Italic || style == FontStyle.Underline && !font.Underline)
                    rtb.Font = new Font(font, font.Style | style);
                return;

            }
            tempRTB.Rtf = rtb.SelectedRtf;
            tempRTB.Select(len - 1, 1);//选中副本中最后一个文字
            //克隆被选中的文字Font，用来判断选中的文字是否要加粗，去粗，斜体，去斜，加下划线，去下划线
            Font tempFont = (Font)tempRTB.SelectionFont.Clone();
            for(int i = 0;i<len;i++)
            {

                tempRTB.Select(tempRtbStart + i, 1);
                if (style == FontStyle.Bold && tempFont.Bold || style == FontStyle.Italic && tempFont.Italic || style == FontStyle.Underline && tempFont.Underline)
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style ^ style);
                else
                    if (style == FontStyle.Bold && !tempFont.Bold || style == FontStyle.Italic && !tempFont.Italic || style == FontStyle.Underline && !tempFont.Underline)
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style | style);
            }
            tempRTB.Select(tempRtbStart, len);
            rtb.SelectedRtf = tempRTB.SelectedRtf;
            //将设置格式后的副本拷贝给原型
            rtb.Select(curRtbStart, len);
            rtb.Focus();
            tempRTB.Dispose();

        }


        //都是直接调用内置函数
        private void 粗体toolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Bold);
        }

        private void 斜体toolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Italic);
        }

        private void 下划线toolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Underline);
        }

       


        //感觉RichTextbox属性真牛逼，直接调用函数就行
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 剪切UToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {
                FrmDoc ff = (FrmDoc)this.ActiveMdiChild;
                ff.rTBDoc.Cut();
            }
            catch { }
        }

        private void 复制CToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc ff = (FrmDoc)this.ActiveMdiChild;
                ff.rTBDoc.Copy();
            }
            catch { }
        }

        private void 粘贴PToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc ff = (FrmDoc)this.ActiveMdiChild;
                ff.rTBDoc.Paste();
            }
            catch { }
        }

        private void 撤销toolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc ff = (FrmDoc)this.ActiveMdiChild;
                ff.rTBDoc.Undo();
            }
            catch { }
        }

        private void 恢复toolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc ff = (FrmDoc)this.ActiveMdiChild;
                ff.rTBDoc.Redo();
            }
            catch { }
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.Undo();
            }
            catch { }
        }

        private void 恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.Redo();
            }
            catch { }
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.Cut();
            }
            catch { }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.Copy();
            }
            catch { }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.Paste();
            }
            catch { }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.SelectAll();
            }
            catch { }
        }

        private void 左对齐toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
               FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.SelectionAlignment = HorizontalAlignment.Left;
            }
            catch { }
        }

        private void 居中toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.SelectionAlignment = HorizontalAlignment.Center;
            }
            catch { }
        }

        private void 右对齐toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc gg = (FrmDoc)this.ActiveMdiChild;
                gg.rTBDoc.SelectionAlignment = HorizontalAlignment.Right;
            }
            catch { }
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|rtf格式(*.rtf)|*.rtf|所有文件(*.*)|*.*";
                FrmDoc fn = (FrmDoc)this.ActiveMdiChild;
                saveFileDialog1.FileName = fn.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string s = saveFileDialog1.FileName;
                    if (s.EndsWith("txt"))
                    {
                        fn.rTBDoc.SaveFile(s, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        fn.rTBDoc.SaveFile(s, RichTextBoxStreamType.RichText);
                    }
                }
            }
            catch { }
        }


        //字号的改变
        private void tSCbBoxFontName_TextChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                RichTextBox tempRTB = new RichTextBox();
                int RtbStart = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionStart;
                int len = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionLength;
                int tempRtbStart = 0;
                Font font = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont;
                if (len <= 0 && null != font)
                {
                    ((FrmDoc)this.ActiveMdiChild).rTBDoc.Font = new Font(tSCbBoxFontName.Text, font.Size, font.Style);
                    return;
                }
                tempRTB.Rtf = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf;
                for (int i = 0; i < len; i++)
                {
                    tempRTB.Select(tempRtbStart + i, 1);
                    tempRTB.SelectionFont = new Font(tSCbBoxFontName.Text, tempRTB.SelectionFont.Size, tempRTB.SelectionFont.Style);
                }
                tempRTB.Select(tempRtbStart, len);
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf = tempRTB.SelectedRtf;
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.Select(RtbStart, len);
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.Focus();
                tempRTB.Dispose();
            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc fn = (FrmDoc)this.ActiveMdiChild;
                if (自动换行ToolStripMenuItem.Checked)
                {
                    fn.rTBDoc.WordWrap = false;
                    自动换行ToolStripMenuItem.Checked = false;
                }
                else
                {
                    fn.rTBDoc.WordWrap = true;
                    自动换行ToolStripMenuItem.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("没有打开的文档");
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog fd = new FontDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    FrmDoc f = (FrmDoc)this.ActiveMdiChild;
                    f.rTBDoc.SelectionFont = fd.Font;
                }
            }
            catch { }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog fd = new ColorDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    FrmDoc f = (FrmDoc)this.ActiveMdiChild;
                    f.rTBDoc.SelectionColor = fd.Color;
                }
            }
            catch { }
        }



        int FindPostion;
        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Search cc = new Search();
            this.AddOwnedForm(cc);
            cc.Show();
        }

      
        FrmDoc doc;
        public void FindRichTextBoxString(string FindString, bool b)
        {
            FindPostion = 0;
            try
            {
                doc = (FrmDoc)this.ActiveMdiChild;
                if (FindPostion >= doc.rTBDoc.Text.Length)//已查到文本底部
                {
                    MessageBox.Show("已搜索完毕。", "提示", MessageBoxButtons.OK);
                    FindPostion = 0;
                    
                    return ;
                }//下边语句进行查找，返回找到的位置，返回-1，表示未找到，参数1是要找的字符串
                //参数2是查找的开始位置，参数3是查找的一些选项，如大小写是否匹配，查找方向等
                if (b)
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.None);

                }
                else
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.MatchCase);
                }
                if (FindPostion == -1)//如果未找到
                {
                    MessageBox.Show("已到文本底部,再次查找将从文本开始处查找",
                "提示", MessageBoxButtons.OK);
                    FindPostion = 0;//下次查找的开始位置
                   // return false;
                }
                else//已找到
                {
                    doc.rTBDoc.Focus();//主窗体成为注视窗口
                    FindPostion += FindString.Length;
                }//下次查找的开始位置在此次找到字符串之后
            }
            catch { }
        }


        public void ReverseFindRichTextBoxString(string FindString, bool b)
        {
            doc = (FrmDoc)this.ActiveMdiChild;
            FindPostion = doc.rTBDoc.Text.Length;
            try
            {
               
                if (FindPostion < 0)//已查到文本头部
                {
                    MessageBox.Show("已搜索完毕。", "提示", MessageBoxButtons.OK);
                    FindPostion = 0;
                    return;
                }//下边语句进行查找，返回找到的位置，返回-1，表示未找到，参数1是要找的字符串
                //参数2是查找的开始位置，参数3是查找的一些选项，如大小写是否匹配，查找方向等
                if (b)
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.None);

                }
                else
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.MatchCase);
                }
                if (FindPostion == -1)//如果未找到
                {
                    MessageBox.Show("已到文本底部,再次查找将从文本开始处查找",
                "提示", MessageBoxButtons.OK);
                    FindPostion = 0;//下次查找的开始位置
                }
                else//已找到
                {
                    doc.rTBDoc.Focus();//主窗体成为注视窗口
                    FindPostion -= FindString.Length;
                }//下次查找的开始位置在此次找到字符串之后
            }
            catch { }
        }



        //替换作用函数
        public void replacertbs(string FindString, string repstring, bool b)
        {
            doc = (FrmDoc)this.ActiveMdiChild;
            if ((FindString != "") == (doc.rTBDoc.SelectedText != ""))
            {
                doc.rTBDoc.SelectedText = repstring;
            }
            else
            {
                if (FindPostion >= doc.rTBDoc.Text.Length)//已查到文本底部
                {
                    MessageBox.Show("已搜索完毕。", "提示", MessageBoxButtons.OK);
                    FindPostion = 0;
                    return;
                }//下边语句进行查找，返回找到的位置，返回-1，表示未找到，参数1是要找的字符串
                //参数2是查找的开始位置，参数3是查找的一些选项，如大小写是否匹配，查找方向等
                if (b)
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.None);

                }
                else
                {
                    FindPostion = doc.rTBDoc.Find(FindString, FindPostion, RichTextBoxFinds.MatchCase);
                }
                if (FindPostion == -1)//如果未找到
                {
                    MessageBox.Show("搜索完毕。",
                "提示", MessageBoxButtons.OK);
                    FindPostion = 0;//下次查找的开始位置
                }
                else//已找到
                {
                    doc.rTBDoc.Focus();
                    doc.rTBDoc.SelectedText = repstring;//主窗体成为注视窗口
                    FindPostion += FindString.Length;
                }//下次查找的开始位置在此次找到字符串之后
            }
        }


        




        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoc fn = (FrmDoc)this.ActiveMdiChild;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = fn.Text;
                fn.rTBDoc.Modified = false;
                if (fn.Name.Length != 0)
                {
                    string s = saveFileDialog1.FileName;
                    if (s.EndsWith("txt"))
                    {
                        fn.rTBDoc.SaveFile(s, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        fn.rTBDoc.SaveFile(s, RichTextBoxStreamType.RichText);
                    }
                }
                else
                    另存为AToolStripMenuItem_Click(sender, e);

            }
            catch { }
        }

        private void tSCbBoxFontName_Click(object sender, EventArgs e)
        {

        }

        private void tSCbBoxFontSizeName_TextChanged(object sender, EventArgs e)
        {
          
        }


        //搜索窗口在主窗口打开
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Search aa = new Search();
            this.AddOwnedForm(aa);
            aa.Show();
        }

        private void tSCbBoxFontSizeName_Click(object sender, EventArgs e)
        {

        }



        //改变字号大小
        private void tSCbBoxFontSizeName_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (this.MdiChildren.Count() > 0)
             {
                 RichTextBox tempRTB = new RichTextBox();
                 int RtbStart = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionStart;
                 int len = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionLength;
                 int tempRtbStart = 0;
                 Font font = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont;
                 if (len <= 0 && null != font)
                 {
                     ((FrmDoc)this.ActiveMdiChild).rTBDoc.Font = new Font(tSCbBoxFontName.Text, font.Size, font.Style);
                     return;
                 }
                 tempRTB.Rtf = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf;
                 for (int i = 0; i < len; i++)
                 {
                     tempRTB.Select(tempRtbStart + i, 1);
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont.FontFamily, FontSize[this.tSCbBoxFontSizeName.SelectedIndex], tempRTB.SelectionFont.Style);
                 }
                 tempRTB.Select(tempRtbStart, len);
                 ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf = tempRTB.SelectedRtf;
                 ((FrmDoc)this.ActiveMdiChild).rTBDoc.Select(RtbStart, len);
                 ((FrmDoc)this.ActiveMdiChild).rTBDoc.Focus();
                 tempRTB.Dispose();
             }
          
        }



        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "RTF格式(*.rtf)|*.rtf|文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;
                    //将文本内容显示在富文本框中
                    if (openfiledialog1.FilterIndex == 1)//.rtf文件
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile(openfiledialog1.FileName, RichTextBoxStreamType.RichText);
                    else //.txt文件
                    {
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile(openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        ((FrmDoc)this.ActiveMdiChild).Text = openfiledialog1.FileName;

                    }
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            openfiledialog1.Dispose();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Help cc = new Help();
            this.AddOwnedForm(cc);
            cc.Show();
        }

        private void 隐藏菜单栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = false;
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void 时间日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDoc fn = (FrmDoc)this.ActiveMdiChild;
            DateTime dt = DateTime.Now;

            fn.rTBDoc.Text = fn.rTBDoc.Text.Insert(fn.rTBDoc.Text.Length, dt.ToString() + "\n");

        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void count_Click(object sender, EventArgs e)
        {
           // FrmDoc fn = new FrmDoc();
           // count.Text = fn.rTBDoc.Text.Length;
        }
    }
}
