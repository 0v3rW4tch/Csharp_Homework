namespace myPuzzle
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_Picture = new System.Windows.Forms.Panel();
            this.btn_select = new System.Windows.Forms.Button();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.btn_challenge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_result = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Changepic = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_Originalpic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl_Picture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_select);
            this.splitContainer1.Panel2.Controls.Add(this.lab2);
            this.splitContainer1.Panel2.Controls.Add(this.lab1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_challenge);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lab_time);
            this.splitContainer1.Panel2.Controls.Add(this.lab_result);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Reset);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Changepic);
            this.splitContainer1.Panel2.Controls.Add(this.btn_import);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Originalpic);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 738);
            this.splitContainer1.SplitterDistance = 805;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnl_Picture
            // 
            this.pnl_Picture.AutoSize = true;
            this.pnl_Picture.Location = new System.Drawing.Point(12, 12);
            this.pnl_Picture.Name = "pnl_Picture";
            this.pnl_Picture.Size = new System.Drawing.Size(774, 714);
            this.pnl_Picture.TabIndex = 0;
            // 
            // btn_select
            // 
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_select.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_select.Location = new System.Drawing.Point(62, 540);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(144, 37);
            this.btn_select.TabIndex = 11;
            this.btn_select.Text = "结束挑战";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Visible = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab2.Location = new System.Drawing.Point(168, 476);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(0, 20);
            this.lab2.TabIndex = 10;
            // 
            // lab1
            // 
            this.lab1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab1.Location = new System.Drawing.Point(19, 418);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(241, 27);
            this.lab1.TabIndex = 9;
            this.lab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_challenge
            // 
            this.btn_challenge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_challenge.Location = new System.Drawing.Point(62, 347);
            this.btn_challenge.Name = "btn_challenge";
            this.btn_challenge.Size = new System.Drawing.Size(144, 31);
            this.btn_challenge.TabIndex = 8;
            this.btn_challenge.Text = "挑战模式";
            this.btn_challenge.UseVisualStyleBackColor = true;
            this.btn_challenge.Click += new System.EventHandler(this.btn_challenge_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "难度等级：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_time
            // 
            this.lab_time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lab_time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_time.Location = new System.Drawing.Point(94, 475);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(68, 33);
            this.lab_time.TabIndex = 6;
            this.lab_time.Click += new System.EventHandler(this.lab_time_Click);
            // 
            // lab_result
            // 
            this.lab_result.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lab_result.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_result.Location = new System.Drawing.Point(38, 276);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(201, 29);
            this.lab_result.TabIndex = 5;
            this.lab_result.Text = "Enjoy it now!";
            this.lab_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_result.Click += new System.EventHandler(this.lab_result_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.Location = new System.Drawing.Point(132, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 28);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Location = new System.Drawing.Point(132, 199);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(113, 45);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "图片重排";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Changepic
            // 
            this.btn_Changepic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Changepic.Location = new System.Drawing.Point(16, 199);
            this.btn_Changepic.Name = "btn_Changepic";
            this.btn_Changepic.Size = new System.Drawing.Size(109, 45);
            this.btn_Changepic.TabIndex = 2;
            this.btn_Changepic.Text = "切换图片";
            this.btn_Changepic.UseVisualStyleBackColor = true;
            this.btn_Changepic.Click += new System.EventHandler(this.btn_Changepic_Click);
            // 
            // btn_import
            // 
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_import.Location = new System.Drawing.Point(132, 127);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(113, 46);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "试玩新图";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_Originalpic
            // 
            this.btn_Originalpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Originalpic.Location = new System.Drawing.Point(17, 127);
            this.btn_Originalpic.Name = "btn_Originalpic";
            this.btn_Originalpic.Size = new System.Drawing.Size(109, 46);
            this.btn_Originalpic.TabIndex = 0;
            this.btn_Originalpic.Text = "查看原图";
            this.btn_Originalpic.UseVisualStyleBackColor = true;
            this.btn_Originalpic.Click += new System.EventHandler(this.btn_Originalpic_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 650;
            this.timer1.Tick += new System.EventHandler(this.t_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 738);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myPuzzle";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl_Picture;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Changepic;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_Originalpic;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lab_result;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_challenge;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btn_select;
    }
}

