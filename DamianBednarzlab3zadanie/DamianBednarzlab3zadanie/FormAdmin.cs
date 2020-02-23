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
    public partial class FormAdmin : Form
    {
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["GradeDatabase"].ConnectionString);
        /// <summary>
        /// konstruktor, na start wypełnia tabelę danymi z bazy
        /// </summary>
        public FormAdmin()
        {
            InitializeComponent();
            GetDataFromTable();
        }
        /// <summary>
        /// funkcja umożliwiająca wczytanie danych z bazy i umieszczenie ich w DataGridView 
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Grade", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewAdmin.DataSource = table;
                }
            }
        }
        /// <summary>
        /// funkcja dodająca ocenę do bazy przy wciśnięciu guzika i odświeżająca widok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                string query = "Insert into Grade(UserId, GradeNumber, GradeName)values("+textBoxInsertId.Text+", "+textBoxInsertGrade.Text+", '"+textBoxInsertText.Text+"')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                GetDataFromTable();
            }
            textBoxInsertText.Text = "";
            textBoxInsertId.Text = "";
            textBoxInsertGrade.Text = "";
        }
        /// <summary>
        /// funkcja usuwająca ocenę z bazy i odświeżająca widok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                string query = "DELETE Grade WHERE GradeId = "+textBoxDelete.Text;
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                GetDataFromTable();
            }
            textBoxDelete.Text = "";
        }
    }
}
