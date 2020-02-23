using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamianBednarzlab3zadanie
{
    class GradeSystem
    {
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["GradeDatabase"].ConnectionString);
        /// <summary>
        /// zmienna w której przechowywane jest polecenie sql
        /// </summary>
        public SqlCommand QuerySql { get; set; }
        /// <summary>
        /// login użytkownika
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// hasło użytkownika
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// id uzytkownika
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// konstruktor, jako parametry przyjmuje login i hasło z aplikacji
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public GradeSystem(string username, string password)
        {
            Username = username;
            Password = password;
        }
        /// <summary>
        /// funkcja umożliwiająca logowanie, sprawdza czy istnieje użytkownik o takich parametrach, jeżeli tak to udziela dostępu
        /// dodatkowo funkcja pobiera jego id
        /// </summary>
        /// <returns></returns>
        public bool SignIn()
        {
            int valueResult;
            bool isTrue = false;
            string query = "SELECT COUNT(Users.Username) From Users WHERE Username = @Username AND Password = @Password ";
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResult = (int)QuerySql.ExecuteScalar();
                if (valueResult > 0)
                    isTrue = true;
            }
            query = "SELECT Users.UserId From Users WHERE Username = @Username AND Password = @Password ";
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                userId = (int)QuerySql.ExecuteScalar();
                if (valueResult > 0)
                    isTrue = true;
            }
            return isTrue;
        }
        /// <summary>
        /// funckja która sprawdza jaka jest ranga użytkownika
        /// </summary>
        /// <returns></returns>
        public int GetRank()
        {
            int rankId=0;
            string query = "SELECT Users.RankId From Users WHERE Username = @Username AND Password = @Password ";
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                rankId = (int)QuerySql.ExecuteScalar();
            }
            return rankId;
        }

    }
}
