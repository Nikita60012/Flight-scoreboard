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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void accChange_Click(object sender, EventArgs e)
        {
            Close();
            Accaunt_choice acc = new Accaunt_choice();
            acc.Show();
        }

        private void listViewing_Click(object sender, EventArgs e)
        {
            Close();
            Lists_viewing view = new Lists_viewing(true);
            view.Show();
        }

        private void listEditing_Click(object sender, EventArgs e)
        {
            Close();
            Lists_editing edit = new Lists_editing(false);
            edit.Show();
        }
    }
}
