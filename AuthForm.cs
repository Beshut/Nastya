using System;
using System.Windows.Forms;

namespace Organizer1
{
    public partial class AuthForm : Form
    {
        const String login = "admin";
        const String password = "admin";
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tmpLogin = textBox1.Text.Trim();
            String tmpPassword = textBox2.Text.Trim();
            if (!tmpLogin.Equals(login) || !tmpPassword.Equals(password))
            {
                MessageBox.Show("Данные аккаунта не верны");
                return;
            }
            else
            {
                MessageBox.Show("Авторизация прошла успешно");
                OrganizerForm organizerForm = new OrganizerForm();
                organizerForm.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Boolean isShowPassword = checkBox1.Checked;
            textBox2.PasswordChar = !isShowPassword ? '*' : '\0';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("До встречи", "Прощальный", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
