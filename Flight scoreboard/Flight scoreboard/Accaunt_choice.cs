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
            String password = passwordEnter.Text;
            
            if (password.Equals("123"))
            {
                arrAdmin = true;
                Hide();
                Main_window main = new Main_window(arrAdmin);
                main.Show();
            }
            else if (password.Equals("321"))
            {
                arrAdmin = false;
                Hide();
                Main_window main = new Main_window(arrAdmin);
                main.Show();
            }
            else
            {
                MessageBox.Show("Введён неверный пароль");
            }
            
        }
    }
}
