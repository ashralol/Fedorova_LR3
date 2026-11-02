namespace Fedorova
{
    partial class FormAutorization
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows Forms

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // labelTitle
            //
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTitle.Location = new System.Drawing.Point(200, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(124, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Авторизация";
            //
            // labelLogin
            //
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelLogin.Location = new System.Drawing.Point(50, 115);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 24);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            //
            // labelPassword
            //
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(50, 180);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 24);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            //
            // textBoxLogin
            //
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLogin.Location = new System.Drawing.Point(150, 112);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(245, 26);
            this.textBoxLogin.TabIndex = 2;
            //
            // textBoxPassword
            //
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(150, 177);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(245, 26);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            //
            // buttonEnter
            //
            this.buttonEnter.Location = new System.Drawing.Point(200, 240);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(130, 45);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            //
            // FormAutorization
            //
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 320);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация - Fedorova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEnter;
    }
}
