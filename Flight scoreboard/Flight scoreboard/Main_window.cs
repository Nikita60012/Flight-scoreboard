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
    public partial class Main_window : Form
    {
        public bool arrAdmin;
        public Main_window(bool arrAdmin)
        {
            InitializeComponent();
            this.arrAdmin = arrAdmin;
            if (!arrAdmin)
            {
                listsViewing.Text = "Просмотр рапсисания отбывающих рейсов";
                listsEditing.Text = "Редактирование расписания отбывающих рейсов";
            }
        }

        private void AccChange_Click(object sender, EventArgs e)
        {
            Close();
            Accaunt_choice acc = new Accaunt_choice();
            acc.Show();
        }

        private void listsEditing_Click(object sender, EventArgs e)
        {
            Close();
            ListsEditing edit = new ListsEditing(arrAdmin);
            edit.Show();
        }

        private void listsViewing_Click(object sender, EventArgs e)
        {
            Close();
            ListsViewing view = new ListsViewing(arrAdmin);
            view.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
