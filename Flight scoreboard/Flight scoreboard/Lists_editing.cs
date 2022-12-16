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
    public partial class Lists_editing : Form
    {
        public Lists_editing(bool arrAdmin)
        {
            InitializeComponent();
            if (!arrAdmin)
            {
                editArriving.Hide();
                editDeparture.Show();
                depDestination.Show();
                destLabel.Show();
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
