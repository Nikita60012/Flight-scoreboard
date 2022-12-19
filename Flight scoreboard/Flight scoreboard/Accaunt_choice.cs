using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_scoreboard
{
    public partial class Accaunt_choice : Form
    {
        public bool arrAdmin;
        public Accaunt_choice()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string password = passwordEnter.Text;
            string[] pass = new string[2];
            string input;
            /*
             * Пароли:
             * Администратор расписания прибывающих рейсов 12336
             * Администратор расписания прибывающих рейсов 63321
            */
            using (System.IO.StreamReader reader = new System.IO.StreamReader("Passwords.txt"))
            {
                for (int i = 0; i < 2; i++)
                {
                    pass[i] = reader.ReadLine();
                }
            }
            
            if (password.Equals(pass[0]))
            {
                arrAdmin = true;
                Hide();
                Main_window main = new Main_window(arrAdmin);
                main.Show();
            }
            else if (password.Equals(pass[1]))
            {
                arrAdmin = false;
                Hide();
                Main_window main = new Main_window(arrAdmin);
                main.Show();
            }
            else
            {
                MessageBox.Show("Введён неверный пароль, введите ещё раз");
            }
            
        }
    }
}
