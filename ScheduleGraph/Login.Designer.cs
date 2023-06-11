namespace ScheduleGraph
{
    partial class Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.LoginBottan = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UserPassText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(157, 123);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(385, 19);
            this.UserNameText.TabIndex = 0;
            this.UserNameText.TextChanged += new System.EventHandler(this.UserNameText_TextChanged);
            // 
            // LoginBottan
            // 
            this.LoginBottan.Location = new System.Drawing.Point(290, 293);
            this.LoginBottan.Name = "LoginBottan";
            this.LoginBottan.Size = new System.Drawing.Size(109, 21);
            this.LoginBottan.TabIndex = 2;
            this.LoginBottan.Text = "ログイン";
            this.LoginBottan.UseVisualStyleBackColor = true;
            this.LoginBottan.Click += new System.EventHandler(this.LoginBottan_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(155, 108);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(35, 12);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "ユーザ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(155, 194);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(52, 12);
            this.Password.TabIndex = 3;
            this.Password.Text = "パスワード";
            // 
            // UserPassText
            // 
            this.UserPassText.Location = new System.Drawing.Point(157, 209);
            this.UserPassText.Name = "UserPassText";
            this.UserPassText.Size = new System.Drawing.Size(385, 19);
            this.UserPassText.TabIndex = 1;
            this.UserPassText.TextChanged += new System.EventHandler(this.UserPassText_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserPassText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LoginBottan);
            this.Controls.Add(this.UserNameText);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Button LoginBottan;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UserPassText;
    }
}

