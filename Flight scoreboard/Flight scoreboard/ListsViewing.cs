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
    public partial class ListsViewing : Form
    {
        public bool arrAdmin;
        public ListsViewing(bool arrAdmin)
        {
            InitializeComponent();
            this.arrAdmin = arrAdmin;
            if (!arrAdmin)
            {
                Text = "Расписание отбывающих рейсов";
                listOfArrive.Hide();
                listOfDeparture.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Main_window main = new Main_window(arrAdmin);
            main.Show();
        }
    }
}
