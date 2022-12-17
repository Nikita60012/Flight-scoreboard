using MySql.Data.MySqlClient;
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
    public partial class ListsEditing : Form
    {
        public bool arrAdmin;
        Database db = new Database();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private MySqlCommand command = new MySqlCommand();
        private DataTable dt = new DataTable();
        private int rowIndex;
        private int idNumber;

        public ListsEditing(bool arrAdmin)
        {
            
            InitializeComponent();
            loadData();
            this.arrAdmin = arrAdmin;
            if (!arrAdmin)
            {
                Text = "Редактирование расписания отбывающих рейсов";
                listOfArrive.Hide();
                listOfDeparture.Show();
                destinationL.Show();
                destinationBox.Show();
            }
        }

        private void loadData()
        {
            db.openConnection();

            if (arrAdmin)
            {
                string query = "SELECT * FROM `arrivals` ORDER BY `ID`";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                adapter.SelectCommand = command;

                MySqlDataReader reader = command.ExecuteReader();

                BindingList<string[]> data = new BindingList<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }

                db.closeConnection();
                reader.Close();

                foreach (string[] s in data)
                    listOfArrive.Rows.Add(s);

                for (int i = 0; i < listOfArrive.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 0 || i % 2 == 0)
                        {
                            listOfArrive.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                        }
                        else if (i % 2 == 1)
                        {
                            listOfArrive.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }
                }
            }
            else
            {
                string query = "SELECT * FROM `flights` ORDER BY `ID`";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                adapter.SelectCommand = command;

                MySqlDataReader reader = command.ExecuteReader();

                BindingList<string[]> data = new BindingList<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }

                reader.Close();
                db.closeConnection();
            
                foreach (string[] s in data)
                    listOfDeparture.Rows.Add(s);

                for (int i = 0; i < listOfDeparture.Rows.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 0 || i % 2 == 0)
                        {
                            listOfDeparture.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                        }
                        else if (i % 2 == 1)
                        {
                            listOfDeparture.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (arrAdmin)
            {
                MySqlCommand sqlCopyCommand = new MySqlCommand("SELECT * FROM `arrivals` WHERE `Numbers` = '" + numberBox.Text + "'", db.getConnection());

                adapter.SelectCommand = sqlCopyCommand;
                adapter.Fill(dt);

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `arrivals` (`Numbers`, `Time`,`Exits`) VALUES ('" + numberBox.Text + "', '" + timeBox.Text + "', '" + exitBox.Text + "')", db.getConnection());

                db.openConnection();

                sqlCommand.ExecuteNonQuery();

                db.closeConnection();

                listOfArrive.DataSource = null;
                listOfArrive.Rows.Clear();
            }
            else
            {
                MySqlCommand sqlCopyCommand = new MySqlCommand("SELECT * FROM `flights` WHERE `Numbers` = '" + numberBox.Text + "'", db.getConnection());

                adapter.SelectCommand = sqlCopyCommand;
                adapter.Fill(dt);

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `flights` (`Numbers`, `Dest`, `Time`,`Exits`) VALUES ('" + numberBox.Text + "', '" + destinationBox.Text + "', '" + timeBox.Text + "', '" + exitBox.Text + "')", db.getConnection());

                db.openConnection();

                sqlCommand.ExecuteNonQuery();

                db.closeConnection();

                listOfDeparture.DataSource = null;
                listOfDeparture.Rows.Clear();
            }
            loadData();
        }
        private void listOfArrive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idNumber = Convert.ToInt32(listOfArrive.Rows[e.RowIndex].Cells[0].Value);
                numberBox.Text = listOfArrive.Rows[e.RowIndex].Cells[1].Value.ToString();
                timeBox.Text = listOfArrive.Rows[e.RowIndex].Cells[2].Value.ToString();
                exitBox.Text = listOfArrive.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void listOfDeparture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                idNumber = Convert.ToInt32(listOfDeparture.Rows[e.RowIndex].Cells[0].Value);
                numberBox.Text = listOfDeparture.Rows[e.RowIndex].Cells[1].Value.ToString();
                destinationBox.Text = listOfDeparture.Rows[e.RowIndex].Cells[2].Value.ToString();
                timeBox.Text = listOfDeparture.Rows[e.RowIndex].Cells[3].Value.ToString();
                exitBox.Text = listOfDeparture.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            db.openConnection();
            if (arrAdmin)
            {
                command = new MySqlCommand("UPDATE `arrivals` SET `Numbers`= '" + numberBox.Text + "', `Time`= '" + timeBox.Text + "', `Exits`= '" + exitBox.Text + "' WHERE `ID` = '" + idNumber + "'", db.getConnection());

                command.ExecuteNonQuery();
                db.closeConnection();

                listOfArrive.DataSource = null;
                listOfArrive.Rows.Clear();
            }
            else
            {
                command = new MySqlCommand("UPDATE `flights` SET `Numbers`= '" + numberBox.Text + "', `Dest`= '" + destinationBox.Text + "', `Time`= '" + timeBox.Text + "', `Exits`= '" + exitBox.Text + "' WHERE `ID` = '" + idNumber + "'", db.getConnection());

                command.ExecuteNonQuery();
                db.closeConnection();

                listOfDeparture.DataSource = null;
                listOfDeparture.Rows.Clear();
            }
            loadData();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (arrAdmin)
            {
                rowIndex = Convert.ToInt32(listOfArrive.CurrentRow.Cells["id"].Value);

                MySqlCommand deletecommand = new MySqlCommand("DELETE FROM `arrivals` WHERE `arrivals`.`ID` = " + rowIndex, db.getConnection());

                db.openConnection();
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deletecommand.ExecuteNonQuery();
                }

                db.closeConnection();

                listOfArrive.DataSource = null;
                listOfArrive.Rows.Clear();
            }
            else{
                rowIndex = Convert.ToInt32(listOfDeparture.CurrentRow.Cells["idd"].Value);

                MySqlCommand deletecommand = new MySqlCommand("DELETE FROM `flights` WHERE `flights`.`ID` = " + rowIndex, db.getConnection());

                db.openConnection();
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deletecommand.ExecuteNonQuery();
                }

                db.closeConnection();

                listOfDeparture.DataSource = null;
                listOfDeparture.Rows.Clear();
            }
            loadData();

        }
        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
            Main_window main = new Main_window(arrAdmin);
            main.Show();
        }

    }
}
