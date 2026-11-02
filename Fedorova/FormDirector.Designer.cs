namespace Fedorova
{
    partial class FormDirector
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
            this.SuspendLayout();
            //
            // labelTitle
            //
            this.labelTitle.Text = "Форма Директора";
            //
            // FormDirector
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Name = "FormDirector";
            this.Text = "Форма Директора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
