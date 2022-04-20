namespace Shoes
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbTitle = new System.Windows.Forms.Label();
            this.Lblogin = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtEnter = new System.Windows.Forms.Button();
            this.BrExit = new System.Windows.Forms.Button();
            this.CbCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTitle.Location = new System.Drawing.Point(117, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(129, 24);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Авторизация";
            // 
            // Lblogin
            // 
            this.Lblogin.AutoSize = true;
            this.Lblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lblogin.Location = new System.Drawing.Point(12, 48);
            this.Lblogin.Name = "Lblogin";
            this.Lblogin.Size = new System.Drawing.Size(64, 24);
            this.Lblogin.TabIndex = 1;
            this.Lblogin.Text = "Логин";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbPassword.Location = new System.Drawing.Point(12, 89);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(76, 24);
            this.LbPassword.TabIndex = 2;
            this.LbPassword.Text = "Пароль";
            // 
            // TbLogin
            // 
            this.TbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbLogin.Location = new System.Drawing.Point(90, 48);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(252, 29);
            this.TbLogin.TabIndex = 3;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbPassword.Location = new System.Drawing.Point(90, 89);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(252, 29);
            this.TbPassword.TabIndex = 4;
            // 
            // BtEnter
            // 
            this.BtEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtEnter.Location = new System.Drawing.Point(12, 158);
            this.BtEnter.Name = "BtEnter";
            this.BtEnter.Size = new System.Drawing.Size(162, 43);
            this.BtEnter.TabIndex = 5;
            this.BtEnter.Text = "Войти";
            this.BtEnter.UseVisualStyleBackColor = true;
            this.BtEnter.Click += new System.EventHandler(this.BtEnter_Click);
            // 
            // BrExit
            // 
            this.BrExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrExit.Location = new System.Drawing.Point(180, 158);
            this.BrExit.Name = "BrExit";
            this.BrExit.Size = new System.Drawing.Size(162, 43);
            this.BrExit.TabIndex = 6;
            this.BrExit.Text = "Выйти";
            this.BrExit.UseVisualStyleBackColor = true;
            this.BrExit.Click += new System.EventHandler(this.BrExit_Click);
            // 
            // CbCheck
            // 
            this.CbCheck.AutoSize = true;
            this.CbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbCheck.Location = new System.Drawing.Point(16, 128);
            this.CbCheck.Name = "CbCheck";
            this.CbCheck.Size = new System.Drawing.Size(160, 24);
            this.CbCheck.TabIndex = 7;
            this.CbCheck.Text = "Показать пароль";
            this.CbCheck.UseVisualStyleBackColor = true;
            this.CbCheck.CheckedChanged += new System.EventHandler(this.CbCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Войти как гость";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbCheck);
            this.Controls.Add(this.BrExit);
            this.Controls.Add(this.BtEnter);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.Lblogin);
            this.Controls.Add(this.LbTitle);
            this.Name = "Authorization";
            this.Text = "ООО \"Обувь\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label Lblogin;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtEnter;
        private System.Windows.Forms.Button BrExit;
        private System.Windows.Forms.CheckBox CbCheck;
        private System.Windows.Forms.Label label1;
    }
}

