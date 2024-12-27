using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private string connectionString = "Server=LAPTOP-B8RCT3A1\\SQLEXPRESS;Database=TaskManagementDB;Integrated Security=True;";

        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.MainForm_Load); // Подключение обработчика события загрузки
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasks(); // Загрузка задач при загрузке формы
        }

        private void txtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            // Логика обработки изменения текста
            string searchTerm = txtSearchTerm.Text;
            // Например, фильтрация списка на основе searchTerm
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Получение данных пользователя из текстовых полей
            string userName = txtUserName.Text; // Поле для ввода имени пользователя
            string Role = txtUserRole.Text; // Поле для ввода роли пользователя

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(Role))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // SQL запрос для добавления нового пользователя
                    string query = "INSERT INTO Users ([User Name], [Role]) VALUES (@UserName, @Role)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Role", Role);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно добавлен.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}");
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            // Получение данных проекта из текстовых полей
            string projectName = txtProjectName.Text; // Поле для ввода названия проекта
            string projectDescription = txtProjectDescription.Text; // Поле для ввода описания проекта

            // Проверка на заполненность полей
            if (string.IsNullOrWhiteSpace(projectName) || string.IsNullOrWhiteSpace(projectDescription))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // SQL запрос для добавления нового проекта
                    string query = "INSERT INTO Projects (ProjectName, ProjectDescription) VALUES (@ProjectName, @ProjectDescription)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Проект успешно добавлен.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении проекта: {ex.Message}");
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Получение данных задачи из текстовых полей
            string taskName = txtTaskName.Text; // Поле для ввода названия задачи
            string taskDescription = txtTaskDescription.Text; // Поле для ввода описания задачи

            // Проверка на заполненность полей
            if (string.IsNullOrWhiteSpace(taskName) || string.IsNullOrWhiteSpace(taskDescription))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // SQL запрос для добавления новой задачи
                    string query = "INSERT INTO Tasks (TaskNumber, TaskDescription) VALUES (@TaskNumber, @TaskDescription)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskNumber", taskName); // Здесь TaskNumber может быть не совсем корректным, если это не номер задачи
                    cmd.Parameters.AddWithValue("@TaskDescription", taskDescription);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Задача успешно добавлена.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении задачи: {ex.Message}");
            }
        }

        private void LoadTasks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TaskID, TaskNumber, Description, Priority, AssigneeID, Status FROM Tasks";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    adapter.Fill(dt);
                    dataGridViewTasks.DataSource = dt; // Предполагается, что у вас есть DataGridView для задач
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке задач: {ex.Message}");
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            int taskId = GetSelectedTaskId();
            if (taskId == -1) return; // Если ничего не выбрано

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Задача удалена.");
                    LoadTasks(); // Обновление списка задач
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении задачи: {ex.Message}");
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            int taskId = GetSelectedTaskId();
            if (taskId == -1) return; // Если ничего не выбрано

            // Получение новых данных из текстовых полей
            string description = txtTaskDescription.Text;
            string priority = cmbPriority.SelectedItem?.ToString(); // Проверка на null
            int assigneeId;
            if (!int.TryParse(txtAssigneeId.Text, out assigneeId))
            {
                MessageBox.Show("Пожалуйста, введите корректный ID исполнителя.");
                return;
            }
            string status = cmbStatus.SelectedItem?.ToString(); // Проверка на null

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Tasks SET Description = @Description, Priority = @Priority, AssigneeID = @AssigneeID, Status = @Status WHERE TaskID = @TaskID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Priority", priority);
                    cmd.Parameters.AddWithValue("@AssigneeID", assigneeId);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Задача обновлена.");
                    LoadTasks(); // Обновление списка задач
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении задачи: {ex.Message}");
            }
        }

        private void btnSearchTask_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchTerm.Text; // Поле для поиска

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TaskID, TaskNumber, Description, Priority, AssigneeID, Status FROM Tasks WHERE Description LIKE @SearchTerm";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    adapter.Fill(dt);
                    dataGridViewTasks.DataSource = dt; // Обновление списка задач
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске задач: {ex.Message}");
            }
        }


        private int GetSelectedTaskId()
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                return (int)dataGridViewTasks.SelectedRows[0].Cells["TaskID"].Value; // Предполагается, что есть колонка TaskID
            }
            MessageBox.Show("Пожалуйста, выберите задачу.");
            return -1;
        }
    }
}





