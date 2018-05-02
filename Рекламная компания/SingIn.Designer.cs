namespace Рекламная_компания
{
    partial class SingIn
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
            this.signInBtn = new System.Windows.Forms.Button();
            this.signInTitle = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.loginL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(55, 198);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(169, 43);
            this.signInBtn.TabIndex = 0;
            this.signInBtn.Text = "Авторизироваться";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // signInTitle
            // 
            this.signInTitle.AutoSize = true;
            this.signInTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInTitle.Location = new System.Drawing.Point(50, 23);
            this.signInTitle.Name = "signInTitle";
            this.signInTitle.Size = new System.Drawing.Size(177, 29);
            this.signInTitle.TabIndex = 1;
            this.signInTitle.Text = "Авторизация";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(55, 84);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(169, 22);
            this.loginTB.TabIndex = 2;
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Location = new System.Drawing.Point(55, 61);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(47, 17);
            this.loginL.TabIndex = 3;
            this.loginL.Text = "Логин";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(58, 121);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(57, 17);
            this.passwordL.TabIndex = 5;
            this.passwordL.Text = "Пароль";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(58, 144);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(169, 22);
            this.passwordTB.TabIndex = 4;
            // 
            // SingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.signInTitle);
            this.Controls.Add(this.signInBtn);
            this.Name = "SingIn";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.SingIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label signInTitle;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox passwordTB;
    }
}

