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
    public partial class Lists_viewing : Form
    {
        public Lists_viewing(bool arrAdmin)
        {
            InitializeComponent();
            if (!arrAdmin)
            {
                arrList.Hide();
                depList.Show();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
