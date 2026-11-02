using System;
using System.Linq;
using System.Windows.Forms;

using Fedorova.Model;

namespace Fedorova
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        //создание статической переменной для хранения данных пользователя
        public static Users Enter_User;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            //поиск пользователя по логину и паролю
            Enter_User = model1.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_User != null)
            {
                Form form;
                switch (Enter_User.RoleID)//переход по формам в зависимости от роли
                {
                    case 1:
                        form = new FormManager();
                        break;
                    case 2:
                        form = new FormSeller();
                        break;
                    case 3:
                        form = new FormDirector();
                        break;
                    default:
                        MessageBox.Show("Роль не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                Hide();
                form.ShowDialog();
                textBoxPassword.Clear();
                Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
