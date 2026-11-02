namespace Fedorova
{
    partial class FormParent
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // buttonBack
            //
            this.buttonBack.Location = new System.Drawing.Point(25, 25);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 50);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            //
            // labelTitle
            //
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTitle.Location = new System.Drawing.Point(85, 110);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 24);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Форма";
            //
            // labelNames
            //
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNames.Location = new System.Drawing.Point(40, 175);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(110, 24);
            this.labelNames.TabIndex = 2;
            this.labelNames.Text = "labelNames";
            //
            // labelRole
            //
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRole.Location = new System.Drawing.Point(40, 230);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(90, 24);
            this.labelRole.TabIndex = 3;
            this.labelRole.Text = "labelRole";
            //
            // pictureBox1
            //
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(330, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            //
            // FormParent
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParent";
            this.Load += new System.EventHandler(this.FormParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonBack;
        protected System.Windows.Forms.Label labelTitle;
        protected System.Windows.Forms.Label labelNames;
        protected System.Windows.Forms.Label labelRole;
        protected System.Windows.Forms.PictureBox pictureBox1;
    }
}
