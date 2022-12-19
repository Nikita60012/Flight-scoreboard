
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListsEditing));
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
            this.listOfArrive.AllowUserToAddRows = false;
            this.listOfArrive.AllowUserToDeleteRows = false;
            this.listOfArrive.AllowUserToResizeColumns = false;
            this.listOfArrive.AllowUserToResizeRows = false;
            this.listOfArrive.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.listOfArrive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfArrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfArrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.aircraftNumber,
            this.time,
            this.exit});
            this.listOfArrive.Location = new System.Drawing.Point(0, 0);
            this.listOfArrive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listOfArrive.Name = "listOfArrive";
            this.listOfArrive.ReadOnly = true;
            this.listOfArrive.RowHeadersWidth = 51;
            this.listOfArrive.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listOfArrive.Size = new System.Drawing.Size(629, 554);
            this.listOfArrive.TabIndex = 0;
            this.listOfArrive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfArrive_CellContentClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // aircraftNumber
            // 
            this.aircraftNumber.Frozen = true;
            this.aircraftNumber.HeaderText = "Номер рейса";
            this.aircraftNumber.MinimumWidth = 6;
            this.aircraftNumber.Name = "aircraftNumber";
            this.aircraftNumber.ReadOnly = true;
            this.aircraftNumber.Width = 175;
            // 
            // time
            // 
            this.time.Frozen = true;
            this.time.HeaderText = "Время";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 125;
            // 
            // exit
            // 
            this.exit.Frozen = true;
            this.exit.HeaderText = "Выход";
            this.exit.MinimumWidth = 6;
            this.exit.Name = "exit";
            this.exit.ReadOnly = true;
            this.exit.Width = 90;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Location = new System.Drawing.Point(692, 292);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 55);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить новую запись";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.Location = new System.Drawing.Point(1080, 512);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 28);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_button.Location = new System.Drawing.Point(853, 292);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(141, 55);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Сохранить изменения";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.del_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_button.Location = new System.Drawing.Point(1016, 292);
            this.del_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(141, 55);
            this.del_button.TabIndex = 4;
            this.del_button.Text = "Удалить запись";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // numberL
            // 
            this.numberL.AutoSize = true;
            this.numberL.BackColor = System.Drawing.Color.Transparent;
            this.numberL.Location = new System.Drawing.Point(727, 65);
            this.numberL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberL.Name = "numberL";
            this.numberL.Size = new System.Drawing.Size(94, 17);
            this.numberL.TabIndex = 5;
            this.numberL.Text = "Номер рейса";
            // 
            // destinationL
            // 
            this.destinationL.AutoSize = true;
            this.destinationL.BackColor = System.Drawing.Color.Transparent;
            this.destinationL.Location = new System.Drawing.Point(701, 118);
            this.destinationL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationL.Name = "destinationL";
            this.destinationL.Size = new System.Drawing.Size(130, 17);
            this.destinationL.TabIndex = 6;
            this.destinationL.Text = "Пункт назначения";
            this.destinationL.Visible = false;
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.BackColor = System.Drawing.Color.Transparent;
            this.timeL.Location = new System.Drawing.Point(772, 165);
            this.timeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(50, 17);
            this.timeL.TabIndex = 7;
            this.timeL.Text = "Время";
            // 
            // exitL
            // 
            this.exitL.AutoSize = true;
            this.exitL.BackColor = System.Drawing.Color.Transparent;
            this.exitL.Location = new System.Drawing.Point(773, 207);
            this.exitL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitL.Name = "exitL";
            this.exitL.Size = new System.Drawing.Size(49, 17);
            this.exitL.TabIndex = 8;
            this.exitL.Text = "Выход";
            // 
            // timeBox
            // 
            this.timeBox.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.timeBox.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeBox.Location = new System.Drawing.Point(841, 158);
            this.timeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(265, 22);
            this.timeBox.TabIndex = 2;
            this.timeBox.Value = new System.DateTime(2022, 12, 17, 12, 0, 0, 0);
            // 
            // numberBox
            // 
            this.numberBox.BackColor = System.Drawing.SystemColors.Menu;
            this.numberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberBox.FormattingEnabled = true;
            this.numberBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numberBox.Location = new System.Drawing.Point(841, 62);
            this.numberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(265, 24);
            this.numberBox.TabIndex = 13;
            // 
            // destinationBox
            // 
            this.destinationBox.BackColor = System.Drawing.SystemColors.Menu;
            this.destinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(841, 114);
            this.destinationBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(265, 24);
            this.destinationBox.TabIndex = 14;
            this.destinationBox.Visible = false;
            // 
            // exitBox
            // 
            this.exitBox.BackColor = System.Drawing.SystemColors.Menu;
            this.exitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitBox.FormattingEnabled = true;
            this.exitBox.Location = new System.Drawing.Point(841, 203);
            this.exitBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(265, 24);
            this.exitBox.TabIndex = 15;
            // 
            // listOfDeparture
            // 
            this.listOfDeparture.AllowUserToAddRows = false;
            this.listOfDeparture.AllowUserToDeleteRows = false;
            this.listOfDeparture.AllowUserToResizeColumns = false;
            this.listOfDeparture.AllowUserToResizeRows = false;
            this.listOfDeparture.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.listOfDeparture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfDeparture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfDeparture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.numberAircraft,
            this.destination,
            this.timeD,
            this.exitD});
            this.listOfDeparture.Location = new System.Drawing.Point(0, 0);
            this.listOfDeparture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listOfDeparture.Name = "listOfDeparture";
            this.listOfDeparture.ReadOnly = true;
            this.listOfDeparture.RowHeadersWidth = 51;
            this.listOfDeparture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listOfDeparture.Size = new System.Drawing.Size(629, 554);
            this.listOfDeparture.TabIndex = 16;
            this.listOfDeparture.Visible = false;
            this.listOfDeparture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfDeparture_CellContentClick);
            // 
            // idd
            // 
            this.idd.Frozen = true;
            this.idd.HeaderText = "ID";
            this.idd.MinimumWidth = 6;
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Width = 30;
            // 
            // numberAircraft
            // 
            this.numberAircraft.Frozen = true;
            this.numberAircraft.HeaderText = "Номер рейса";
            this.numberAircraft.MinimumWidth = 6;
            this.numberAircraft.Name = "numberAircraft";
            this.numberAircraft.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.Frozen = true;
            this.destination.HeaderText = "Пункт назначения";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 125;
            // 
            // timeD
            // 
            this.timeD.Frozen = true;
            this.timeD.HeaderText = "Время";
            this.timeD.MinimumWidth = 6;
            this.timeD.Name = "timeD";
            this.timeD.ReadOnly = true;
            this.timeD.Width = 110;
            // 
            // exitD
            // 
            this.exitD.Frozen = true;
            this.exitD.HeaderText = "Выход";
            this.exitD.MinimumWidth = 6;
            this.exitD.Name = "exitD";
            this.exitD.ReadOnly = true;
            this.exitD.Width = 57;
            // 
            // ListsEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1196, 555);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListsEditing";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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