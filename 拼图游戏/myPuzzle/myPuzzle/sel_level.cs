using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myPuzzle
{
    public partial class sel_level : Form
    {
        public sel_level()
        {
            InitializeComponent();
        }

        private void btn_DO_Click(object sender, EventArgs e)
        {
            int num = (int)this.numericUpDown_sel.Value;
            if ( num < 0)
            {
                DialogResult ans = MessageBox.Show("无效的难度等级哦","提示",MessageBoxButtons.RetryCancel);
                if (ans != DialogResult.Retry)
                {
                    this.Close();
                }
            }
            else {
                Select_level.sLevel = num;
                this.Close();
            }
            
        }

        private void numericUpDown_sel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sel_level_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void sel_level_Load(object sender, EventArgs e)
        {
           
        }

        private void sel_level_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
