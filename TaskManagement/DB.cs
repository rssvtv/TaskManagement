using System;
using System.Data.SqlClient;

namespace TaskManagement
{
    internal class DB
    {
        public void ConnectToDatabase()
        {
            // Строка подключения к базе данных
            string connectionString = "Server=localhost;Database=TaskManagementDB;Trusted_Connection=True;";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открытие подключения
                    connection.Open();
                    Console.WriteLine("Подключение к базе данных установлено.");

                    // SQL-запрос
                    string query = "SELECT * FROM Users"; // Замените 'Users' на вашу таблицу

                    // Создание команды
                    SqlCommand command = new SqlCommand(query, connection);

                    // Выполнение запроса и получение данных
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Предполагается, что в таблице есть столбцы "User  Name" и "Email"
                            Console.WriteLine($"User  Name: {reader["User  Name"]}, Email: {reader["Email"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                finally
                {
                    // Закрытие подключения
                    connection.Close();
                    Console.WriteLine("Подключение закрыто.");
                }
            }
        }
    }
}

