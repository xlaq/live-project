namespace Appointment
{
    partial class Form1
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
            this.username = new System.Windows.Forms.Label();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.textBox2_id = new System.Windows.Forms.TextBox();
            this.textBox3_phone = new System.Windows.Forms.TextBox();
            this.textBox4_count = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.Label();
            this.userphone = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.预约ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.order_button = new System.Windows.Forms.Button();
            this.beginorder_button = new System.Windows.Forms.Button();
            this.endorder_button = new System.Windows.Forms.Button();
            this.order_label = new System.Windows.Forms.Label();
            this.order_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sum_textBox = new System.Windows.Forms.TextBox();
            this.set1_button = new System.Windows.Forms.Button();
            this.sum_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(70, 45);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 15);
            this.username.TabIndex = 0;
            this.username.Text = "真实姓名：";
            // 
            // textBox1_name
            // 
            this.textBox1_name.Location = new System.Drawing.Point(158, 42);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(201, 25);
            this.textBox1_name.TabIndex = 1;
            // 
            // textBox2_id
            // 
            this.textBox2_id.Location = new System.Drawing.Point(158, 90);
            this.textBox2_id.Name = "textBox2_id";
            this.textBox2_id.Size = new System.Drawing.Size(298, 25);
            this.textBox2_id.TabIndex = 2;
            this.textBox2_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_count_KeyPress);
            // 
            // textBox3_phone
            // 
            this.textBox3_phone.Location = new System.Drawing.Point(158, 144);
            this.textBox3_phone.Name = "textBox3_phone";
            this.textBox3_phone.Size = new System.Drawing.Size(201, 25);
            this.textBox3_phone.TabIndex = 3;
            // 
            // textBox4_count
            // 
            this.textBox4_count.Location = new System.Drawing.Point(158, 186);
            this.textBox4_count.Name = "textBox4_count";
            this.textBox4_count.Size = new System.Drawing.Size(201, 25);
            this.textBox4_count.TabIndex = 4;
            this.textBox4_count.Text = "3";
            this.textBox4_count.TextChanged += new System.EventHandler(this.textBox4_count_TextChanged);
            this.textBox4_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_count_KeyPress);
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(70, 100);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(82, 15);
            this.userid.TabIndex = 5;
            this.userid.Text = "身份证号：";
            // 
            // userphone
            // 
            this.userphone.AutoSize = true;
            this.userphone.Location = new System.Drawing.Point(85, 147);
            this.userphone.Name = "userphone";
            this.userphone.Size = new System.Drawing.Size(67, 15);
            this.userphone.TabIndex = 6;
            this.userphone.Text = "手机号：";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(40, 189);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(112, 15);
            this.count_label.TabIndex = 7;
            this.count_label.Text = "预约口罩数量：";
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
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 预约ToolStripMenuItem
            // 
            this.预约ToolStripMenuItem.Name = "预约ToolStripMenuItem";
            this.预约ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.预约ToolStripMenuItem.Text = "口罩预约";
            this.预约ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.查询ToolStripMenuItem.Text = "结果查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(35, 243);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(117, 40);
            this.order_button.TabIndex = 9;
            this.order_button.Text = "点击预约";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // beginorder_button
            // 
            this.beginorder_button.Location = new System.Drawing.Point(580, 45);
            this.beginorder_button.Name = "beginorder_button";
            this.beginorder_button.Size = new System.Drawing.Size(135, 42);
            this.beginorder_button.TabIndex = 10;
            this.beginorder_button.Text = "开始预约";
            this.beginorder_button.UseVisualStyleBackColor = true;
            this.beginorder_button.Click += new System.EventHandler(this.beginorder_button_Click);
            // 
            // endorder_button
            // 
            this.endorder_button.Location = new System.Drawing.Point(788, 45);
            this.endorder_button.Name = "endorder_button";
            this.endorder_button.Size = new System.Drawing.Size(137, 42);
            this.endorder_button.TabIndex = 11;
            this.endorder_button.Text = "结束预约";
            this.endorder_button.UseVisualStyleBackColor = true;
            this.endorder_button.Click += new System.EventHandler(this.endorder_button_Click);
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.Location = new System.Drawing.Point(40, 309);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(82, 15);
            this.order_label.TabIndex = 14;
            this.order_label.Text = "预约结果：";
            // 
            // order_textBox
            // 
            this.order_textBox.Location = new System.Drawing.Point(43, 338);
            this.order_textBox.Multiline = true;
            this.order_textBox.Name = "order_textBox";
            this.order_textBox.Size = new System.Drawing.Size(388, 123);
            this.order_textBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 16;
            // 
            // sum_textBox
            // 
            this.sum_textBox.Location = new System.Drawing.Point(710, 112);
            this.sum_textBox.Name = "sum_textBox";
            this.sum_textBox.Size = new System.Drawing.Size(131, 25);
            this.sum_textBox.TabIndex = 19;
            // 
            // set1_button
            // 
            this.set1_button.Location = new System.Drawing.Point(850, 103);
            this.set1_button.Name = "set1_button";
            this.set1_button.Size = new System.Drawing.Size(75, 38);
            this.set1_button.TabIndex = 21;
            this.set1_button.Text = "设置";
            this.set1_button.UseVisualStyleBackColor = true;
            // 
            // sum_label
            // 
            this.sum_label.AutoSize = true;
            this.sum_label.Location = new System.Drawing.Point(577, 115);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(127, 15);
            this.sum_label.TabIndex = 18;
            this.sum_label.Text = "请输入口罩总量：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 520);
            this.Controls.Add(this.set1_button);
            this.Controls.Add(this.sum_textBox);
            this.Controls.Add(this.sum_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.order_textBox);
            this.Controls.Add(this.order_label);
            this.Controls.Add(this.endorder_button);
            this.Controls.Add(this.beginorder_button);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.userphone);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.textBox4_count);
            this.Controls.Add(this.textBox3_phone);
            this.Controls.Add(this.textBox2_id);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.username);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "口罩预约界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox1_name;
        private System.Windows.Forms.TextBox textBox2_id;
        private System.Windows.Forms.TextBox textBox3_phone;
        private System.Windows.Forms.TextBox textBox4_count;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label userphone;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 预约ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button beginorder_button;
        private System.Windows.Forms.Button endorder_button;
        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.TextBox order_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sum_textBox;
        private System.Windows.Forms.Button set1_button;
        private System.Windows.Forms.Label sum_label;
    }
}

