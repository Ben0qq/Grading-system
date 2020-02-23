using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamianBednarzlab3zadanie
{
    public partial class FormUser : Form
    {
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["GradeDatabase"].ConnectionString);
        /// <summary>
        /// zmienna w której przechowywane jest id użytkownika
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// konstruktor wyświetlający dane z bazy i czytający id użytkownika
        /// </summary>
        /// <param name="id"></param>
        public FormUser(int id)
        {
            InitializeComponent();
            userId = id;
            GetDataFromTable();
        }
        /// <summary>
        /// funkcja wyświetlająca oceny z bazy tylko dla zalogowanego użytkownika
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                string command = "select * from Grade where UserId = " + userId.ToString();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewUser.DataSource = table;
                }
            }
        }
    }
}
