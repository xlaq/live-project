namespace Appointment
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.预约ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.number = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.query_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预约ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 预约ToolStripMenuItem
            // 
            this.预约ToolStripMenuItem.Name = "预约ToolStripMenuItem";
            this.预约ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.预约ToolStripMenuItem.Text = "口罩预约";
            this.预约ToolStripMenuItem.Click += new System.EventHandler(this.预约ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.查询ToolStripMenuItem.Text = "结果查询";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(40, 54);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(127, 15);
            this.number.TabIndex = 10;
            this.number.Text = "请输入预约编号：";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(40, 102);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(82, 15);
            this.result_label.TabIndex = 11;
            this.result_label.Text = "查询结果：";
            // 
            // numbertextBox
            // 
            this.numbertextBox.Location = new System.Drawing.Point(173, 51);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(320, 25);
            this.numbertextBox.TabIndex = 12;
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(71, 135);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(551, 181);
            this.result_textBox.TabIndex = 13;
            // 
            // query_button
            // 
            this.query_button.Location = new System.Drawing.Point(525, 45);
            this.query_button.Name = "query_button";
            this.query_button.Size = new System.Drawing.Size(97, 33);
            this.query_button.TabIndex = 14;
            this.query_button.Text = "查询";
            this.query_button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.query_button);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.numbertextBox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.number);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "中签查询界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 预约ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button query_button;
    }
}