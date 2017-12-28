namespace System
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
            this.UserName = new System.Windows.Forms.Label();
            this.UserPWD = new System.Windows.Forms.Label();
            this.tBUserName = new System.Windows.Forms.TextBox();
            this.tBUserPWD = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(54, 108);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(67, 15);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "用户名称";
            // 
            // UserPWD
            // 
            this.UserPWD.AutoSize = true;
            this.UserPWD.Location = new System.Drawing.Point(54, 184);
            this.UserPWD.Name = "UserPWD";
            this.UserPWD.Size = new System.Drawing.Size(67, 15);
            this.UserPWD.TabIndex = 1;
            this.UserPWD.Text = "登录密码";
            // 
            // tBUserName
            // 
            this.tBUserName.Location = new System.Drawing.Point(149, 98);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(114, 25);
            this.tBUserName.TabIndex = 2;
            // 
            // tBUserPWD
            // 
            this.tBUserPWD.Location = new System.Drawing.Point(149, 174);
            this.tBUserPWD.Name = "tBUserPWD";
            this.tBUserPWD.Size = new System.Drawing.Size(114, 25);
            this.tBUserPWD.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(57, 266);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(81, 33);
            this.Login.TabIndex = 4;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(188, 266);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(75, 33);
            this.Clean.TabIndex = 5;
            this.Clean.Text = "重置";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 415);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.tBUserPWD);
            this.Controls.Add(this.tBUserName);
            this.Controls.Add(this.UserPWD);
            this.Controls.Add(this.UserName);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "欢迎使用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label UserName;
        private Windows.Forms.Label UserPWD;
        private Windows.Forms.TextBox tBUserName;
        private Windows.Forms.TextBox tBUserPWD;
        private Windows.Forms.Button Login;
        private Windows.Forms.Button Clean;
    }
}

