using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMDIExample
{
    public partial class FrmDoc : Form
    {
        public FrmDoc()
        {
            InitializeComponent();
        }
       

        Form1 f1;
        private void setf1()
        {
            f1 = (Form1)this.ParentForm;
        }
        private void FrmDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;

            if (rTBDoc.Modified)//观察期是否有修改
            {
                if (rTBDoc.CanUndo == false)
                {
                    setf1();
                }
                else//都是保存文件的操作
                {
                    dr = MessageBox.Show("文件以更改，是否保存？", "保存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            {
                                e.Cancel = true;
                                break;
                            }
                        case DialogResult.Yes:
                            {
                                if (this.Name != "")
                                {
                                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                                    saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|rtf格式(*.rtf)|*.rtf|所有文件(*.*)|*.*";
                                    //FrmDoc fn = (FrmDoc)this.ActiveMdiChild;
                                    saveFileDialog1.FileName = this.Text;
                                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                    {

                                        string s = saveFileDialog1.FileName;
                                        if (s.EndsWith("txt"))
                                        {
                                           this.rTBDoc.SaveFile(s, RichTextBoxStreamType.PlainText);
                                        }
                                        else
                                        {
                                           this.rTBDoc.SaveFile(s, RichTextBoxStreamType.RichText);
                                        }
                                    }
                                }
                                else
                                {
                                    SaveFileDialog saveFileDialog2 = new SaveFileDialog();
                                    saveFileDialog2.Filter = "文本文件(*.txt)|*.txt|rtf格式(*.rtf)|*.rtf|所有文件(*.*)|*.*";
                                    saveFileDialog2.FileName = this.Text;
                                    if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                                    {

                                        string s = saveFileDialog2.FileName;
                                        if (s.EndsWith(".txt"))
                                        {
                                            this.rTBDoc.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.PlainText);
                                        }
                                        else
                                        {
                                            this.rTBDoc .SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.RichText);
                                        }
                                    }
                                    else
                                        e.Cancel = true;
                                    break;
                                }
                                setf1();
                                break;
                            }
                        case DialogResult.No:
                            {
                               setf1();
                                break;
                            }
                    }
                }
            }
        }
    }
}
