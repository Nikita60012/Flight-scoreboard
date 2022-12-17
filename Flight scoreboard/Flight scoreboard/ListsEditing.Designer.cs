
namespace Flight_scoreboard
{
    partial class ListsEditing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfArrive = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.numberL = new System.Windows.Forms.Label();
            this.destinationL = new System.Windows.Forms.Label();
            this.timeL = new System.Windows.Forms.Label();
            this.exitL = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.DateTimePicker();
            this.numberBox = new System.Windows.Forms.ComboBox();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.exitBox = new System.Windows.Forms.ComboBox();
            this.listOfDeparture = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberAircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listOfArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDeparture)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfArrive
            // 
            this.listOfArrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfArrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.aircraftNumber,
            this.time,
            this.exit});
            this.listOfArrive.Location = new System.Drawing.Point(0, 0);
            this.listOfArrive.Name = "listOfArrive";
            this.listOfArrive.Size = new System.Drawing.Size(472, 450);
            this.listOfArrive.TabIndex = 0;
            this.listOfArrive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfArrive_CellContentClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // aircraftNumber
            // 
            this.aircraftNumber.Frozen = true;
            this.aircraftNumber.HeaderText = "Номер рейса";
            this.aircraftNumber.Name = "aircraftNumber";
            this.aircraftNumber.ReadOnly = true;
            this.aircraftNumber.Width = 175;
            // 
            // time
            // 
            this.time.Frozen = true;
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 125;
            // 
            // exit
            // 
            this.exit.Frozen = true;
            this.exit.HeaderText = "Выход";
            this.exit.Name = "exit";
            this.exit.ReadOnly = true;
            this.exit.Width = 90;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(519, 237);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(106, 45);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить новую запись";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(810, 416);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(640, 237);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(106, 45);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Сохранить изменения";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(762, 237);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(106, 45);
            this.del_button.TabIndex = 4;
            this.del_button.Text = "Удалить запись";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // numberL
            // 
            this.numberL.AutoSize = true;
            this.numberL.Location = new System.Drawing.Point(545, 53);
            this.numberL.Name = "numberL";
            this.numberL.Size = new System.Drawing.Size(74, 13);
            this.numberL.TabIndex = 5;
            this.numberL.Text = "Номер рейса";
            // 
            // destinationL
            // 
            this.destinationL.AutoSize = true;
            this.destinationL.Location = new System.Drawing.Point(526, 96);
            this.destinationL.Name = "destinationL";
            this.destinationL.Size = new System.Drawing.Size(99, 13);
            this.destinationL.TabIndex = 6;
            this.destinationL.Text = "Пункт назначения";
            this.destinationL.Visible = false;
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.Location = new System.Drawing.Point(579, 134);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(40, 13);
            this.timeL.TabIndex = 7;
            this.timeL.Text = "Время";
            // 
            // exitL
            // 
            this.exitL.AutoSize = true;
            this.exitL.Location = new System.Drawing.Point(580, 168);
            this.exitL.Name = "exitL";
            this.exitL.Size = new System.Drawing.Size(39, 13);
            this.exitL.TabIndex = 8;
            this.exitL.Text = "Выход";
            // 
            // timeBox
            // 
            this.timeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeBox.Location = new System.Drawing.Point(631, 128);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(200, 20);
            this.timeBox.TabIndex = 2;
            this.timeBox.Value = new System.DateTime(2022, 12, 17, 12, 0, 0, 0);
            // 
            // numberBox
            // 
            this.numberBox.FormattingEnabled = true;
            this.numberBox.Location = new System.Drawing.Point(631, 50);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(200, 21);
            this.numberBox.TabIndex = 13;
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(631, 93);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(200, 21);
            this.destinationBox.TabIndex = 14;
            this.destinationBox.Visible = false;
            // 
            // exitBox
            // 
            this.exitBox.FormattingEnabled = true;
            this.exitBox.Location = new System.Drawing.Point(631, 165);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(200, 21);
            this.exitBox.TabIndex = 15;
            // 
            // listOfDeparture
            // 
            this.listOfDeparture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfDeparture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.numberAircraft,
            this.destination,
            this.timeD,
            this.exitD});
            this.listOfDeparture.Location = new System.Drawing.Point(0, 0);
            this.listOfDeparture.Name = "listOfDeparture";
            this.listOfDeparture.Size = new System.Drawing.Size(472, 450);
            this.listOfDeparture.TabIndex = 16;
            this.listOfDeparture.Visible = false;
            this.listOfDeparture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfDeparture_CellContentClick);
            // 
            // idd
            // 
            this.idd.Frozen = true;
            this.idd.HeaderText = "ID";
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Width = 30;
            // 
            // numberAircraft
            // 
            this.numberAircraft.Frozen = true;
            this.numberAircraft.HeaderText = "Номер рейса";
            this.numberAircraft.Name = "numberAircraft";
            this.numberAircraft.ReadOnly = true;
            this.numberAircraft.Width = 125;
            // 
            // destination
            // 
            this.destination.Frozen = true;
            this.destination.HeaderText = "Пункт назначения";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 125;
            // 
            // timeD
            // 
            this.timeD.Frozen = true;
            this.timeD.HeaderText = "Время";
            this.timeD.Name = "timeD";
            this.timeD.ReadOnly = true;
            // 
            // exitD
            // 
            this.exitD.Frozen = true;
            this.exitD.HeaderText = "Выход";
            this.exitD.Name = "exitD";
            this.exitD.ReadOnly = true;
            this.exitD.Width = 50;
            // 
            // ListsEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 451);
            this.Controls.Add(this.listOfDeparture);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.exitL);
            this.Controls.Add(this.timeL);
            this.Controls.Add(this.destinationL);
            this.Controls.Add(this.numberL);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.listOfArrive);
            this.Name = "ListsEditing";
            this.RightToLeftLayout = true;
            this.Text = "Редактирование расписания прибывающих рейсов";
            ((System.ComponentModel.ISupportInitialize)(this.listOfArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDeparture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfArrive;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Label numberL;
        private System.Windows.Forms.Label destinationL;
        private System.Windows.Forms.Label timeL;
        private System.Windows.Forms.Label exitL;
        private System.Windows.Forms.DateTimePicker timeBox;
        private System.Windows.Forms.ComboBox numberBox;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.ComboBox exitBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn exit;
        private System.Windows.Forms.DataGridView listOfDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitD;
    }
}