using System;
using System.Windows.Forms;
using TaskManagementApp;

namespace TaskManagement
{
    public partial class Form1 : Form
    {
        private const string validUsername = "Админ";
        private const string validPassword = "12345";

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load); // Подключаем обработчик события загрузки
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код инициализации при загрузке формы, если это необходимо
            // Например, можно очистить поля ввода
            txtLogin.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPassword.Text;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Проверка учетных данных
            if (username == validUsername && password == validPassword)
            {
                MessageBox.Show("Авторизация прошла успешно!");

                // Создайте новую форму для основного интерфейса
                MainForm mainForm = new MainForm(); // Предполагается, что у вас есть класс MainForm
                mainForm.Show(); // Показываем новую форму
                this.Hide(); // Скрываем текущую форму (форму авторизации)
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
        }
    }
}

