namespace myPuzzle
{
    partial class sel_level
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_sel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DO
            // 
            this.btn_DO.Location = new System.Drawing.Point(212, 25);
            this.btn_DO.Name = "btn_DO";
            this.btn_DO.Size = new System.Drawing.Size(89, 25);
            this.btn_DO.TabIndex = 0;
            this.btn_DO.Text = "确定";
            this.btn_DO.UseVisualStyleBackColor = true;
            this.btn_DO.Click += new System.EventHandler(this.btn_DO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "难度系数";
            // 
            // numericUpDown_sel
            // 
            this.numericUpDown_sel.Location = new System.Drawing.Point(86, 25);
            this.numericUpDown_sel.Name = "numericUpDown_sel";
            this.numericUpDown_sel.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_sel.TabIndex = 2;
            this.numericUpDown_sel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_sel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sel.ValueChanged += new System.EventHandler(this.numericUpDown_sel_ValueChanged);
            // 
            // sel_level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 60);
            this.ControlBox = false;
            this.Controls.Add(this.numericUpDown_sel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DO);
            this.Name = "sel_level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "难度选择";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sel_level_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sel_level_FormClosed);
            this.Load += new System.EventHandler(this.sel_level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_sel;
    }
}