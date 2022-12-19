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
    public partial class ListsViewing : Form
    {
        public bool arrAdmin;

        Database db = new Database();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public ListsViewing(bool arrAdmin)
        {
            InitializeComponent();
            this.arrAdmin = arrAdmin;
            if (!arrAdmin)
            {
                //Подгрузка варианта окна для администратора расписания отбывающих рейсов
                loadDataDep();
                Text = "Расписание отбывающих рейсов";
                listOfArrive.Hide();
                listOfDeparture.Show();
            }
            else
            {
                //Подгрузка варианта окна для администратора расписания прибывающих рейсов
                loadDataArr();
                listOfArrive.Show();
            }
        }

        private void loadDataArr()
        {
            //Установление соединения с базой данных и подгрузка данных

            db.openConnection();

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

            //Передача данных в таблицу
            foreach (string[] s in data)
                listOfArrive.Rows.Add(s);
            //Установка разных цветов для чётных и нечётных рядов
            for (int i = 0; i < listOfArrive.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        listOfArrive.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    }
                    else if (i % 2 == 1)
                    {
                        listOfArrive.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }
        private void loadDataDep()
        {
            //Установление соединения с базой данных и подгрузка данных
            db.openConnection();
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

            //Передача данных в таблицу
            foreach (string[] s in data)
                listOfDeparture.Rows.Add(s);

            //Установка разных цветов для чётных и нечётных рядов
            for (int i = 0; i < listOfDeparture.Rows.Count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        listOfDeparture.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    }
                    else if (i % 2 == 1)
                    {
                        listOfDeparture.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
            Main_window main = new Main_window(arrAdmin);
            main.Show();
        }

       
    }
}
