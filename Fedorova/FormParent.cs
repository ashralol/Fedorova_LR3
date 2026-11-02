using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Fedorova.Model;

namespace Fedorova
{
    // Родительская форма: от неё наследуются FormDirector, FormManager и FormSeller
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            // в конструкторе форм (дизайнере) пользователя нет - ничего не загружаем
            if (FormAutorization.Enter_User == null) return;

            Model1 model = new Model1();
            //Используя ранее заполненное статическое поле формы авторизации заполняем эту форму данными
            labelNames.Text = FormAutorization.Enter_User.First_Name + " " + FormAutorization.Enter_User.Second_Name;
            labelRole.Text = model.Roles.First(x => x.ID == FormAutorization.Enter_User.RoleID).Name;
            string path = @"Photo\" + FormAutorization.Enter_User.Pictures;
            if (File.Exists(path))
                pictureBox1.Image = Image.FromFile(path);
        }
    }
}
