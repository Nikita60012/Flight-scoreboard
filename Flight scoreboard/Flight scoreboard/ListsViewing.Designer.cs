
namespace Flight_scoreboard
{
    partial class ListsViewing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListsViewing));
            this.back_button = new System.Windows.Forms.Button();
            this.listOfArrive = new System.Windows.Forms.DataGridView();
            this.listOfDeparture = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberAircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listOfArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDeparture)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.Location = new System.Drawing.Point(515, 511);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 28);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // listOfArrive
            // 
            this.listOfArrive.AllowUserToResizeRows = false;
            this.listOfArrive.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.listOfArrive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfArrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfArrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.aircraftNumber,
            this.time,
            this.exit});
            this.listOfArrive.Location = new System.Drawing.Point(-1, 0);
            this.listOfArrive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listOfArrive.Name = "listOfArrive";
            this.listOfArrive.ReadOnly = true;
            this.listOfArrive.RowHeadersWidth = 51;
            this.listOfArrive.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listOfArrive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfArrive.Size = new System.Drawing.Size(632, 503);
            this.listOfArrive.TabIndex = 1;
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
            this.listOfDeparture.Location = new System.Drawing.Point(-1, 0);
            this.listOfDeparture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listOfDeparture.Name = "listOfDeparture";
            this.listOfDeparture.ReadOnly = true;
            this.listOfDeparture.RowHeadersWidth = 51;
            this.listOfDeparture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listOfDeparture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfDeparture.Size = new System.Drawing.Size(629, 503);
            this.listOfDeparture.TabIndex = 17;
            this.listOfDeparture.Visible = false;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 40;
            // 
            // aircraftNumber
            // 
            this.aircraftNumber.Frozen = true;
            this.aircraftNumber.HeaderText = "Номер рейса";
            this.aircraftNumber.MinimumWidth = 6;
            this.aircraftNumber.Name = "aircraftNumber";
            this.aircraftNumber.ReadOnly = true;
            this.aircraftNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aircraftNumber.Width = 175;
            // 
            // time
            // 
            this.time.Frozen = true;
            this.time.HeaderText = "Время";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.time.Width = 125;
            // 
            // exit
            // 
            this.exit.Frozen = true;
            this.exit.HeaderText = "Выход";
            this.exit.MinimumWidth = 6;
            this.exit.Name = "exit";
            this.exit.ReadOnly = true;
            this.exit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exit.Width = 93;
            // 
            // idd
            // 
            this.idd.Frozen = true;
            this.idd.HeaderText = "ID";
            this.idd.MinimumWidth = 6;
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idd.Width = 50;
            // 
            // numberAircraft
            // 
            this.numberAircraft.Frozen = true;
            this.numberAircraft.HeaderText = "Номер рейса";
            this.numberAircraft.MinimumWidth = 6;
            this.numberAircraft.Name = "numberAircraft";
            this.numberAircraft.ReadOnly = true;
            this.numberAircraft.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numberAircraft.Width = 113;
            // 
            // destination
            // 
            this.destination.Frozen = true;
            this.destination.HeaderText = "Пункт назначения";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.destination.Width = 138;
            // 
            // timeD
            // 
            this.timeD.Frozen = true;
            this.timeD.HeaderText = "Время";
            this.timeD.MinimumWidth = 6;
            this.timeD.Name = "timeD";
            this.timeD.ReadOnly = true;
            this.timeD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.timeD.Width = 79;
            // 
            // exitD
            // 
            this.exitD.Frozen = true;
            this.exitD.HeaderText = "Выход";
            this.exitD.MinimumWidth = 40;
            this.exitD.Name = "exitD";
            this.exitD.ReadOnly = true;
            this.exitD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exitD.Width = 78;
            // 
            // ListsViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 554);
            this.Controls.Add(this.listOfDeparture);
            this.Controls.Add(this.listOfArrive);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListsViewing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание прибывающих рейсов";
            ((System.ComponentModel.ISupportInitialize)(this.listOfArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDeparture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView listOfArrive;
        private System.Windows.Forms.DataGridView listOfDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitD;
    }
}