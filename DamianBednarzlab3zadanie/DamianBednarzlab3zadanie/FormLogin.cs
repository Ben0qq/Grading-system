using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamianBednarzlab3zadanie
{
    public partial class FormLogin : Form
    {
        /// <summary>
        /// konstruktor
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// przy wciśnięciu przycisku funkcja podejmuje próbę zalogowania użytkownika w zależności od podanych danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            GradeSystem system = new GradeSystem(textBoxLogin.Text, textBoxPassword.Text);

            if (system.SignIn() == true)
            {
                MessageBox.Show("Zalogowano");
                int rank = system.GetRank();
                if (rank == 2)
                {
                    FormAdmin fq = new FormAdmin();
                    fq.Show();
                }
                else if(rank == 1)
                {
                    FormUser fq = new FormUser(system.userId);
                    fq.Show();
                }
                else
                {
                    MessageBox.Show("Błąd!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nie udało się");
            }
            this.Visible = false;
        }
    }
}
