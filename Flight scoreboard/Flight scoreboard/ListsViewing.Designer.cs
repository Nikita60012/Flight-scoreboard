
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
            this.back_button = new System.Windows.Forms.Button();
            this.listOfArrive = new System.Windows.Forms.DataGridView();
            this.listOfDeparture = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberAircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listOfArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDeparture)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(386, 415);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfArrive
            // 
            this.listOfArrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfArrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.aircraftNumber,
            this.time,
            this.exit});
            this.listOfArrive.Location = new System.Drawing.Point(-1, 0);
            this.listOfArrive.Name = "listOfArrive";
            this.listOfArrive.Size = new System.Drawing.Size(474, 409);
            this.listOfArrive.TabIndex = 1;
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
            this.listOfDeparture.Location = new System.Drawing.Point(1, 0);
            this.listOfDeparture.Name = "listOfDeparture";
            this.listOfDeparture.Size = new System.Drawing.Size(472, 409);
            this.listOfDeparture.TabIndex = 17;
            this.listOfDeparture.Visible = false;
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
            this.exit.Width = 93;
            // 
            // ListsViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.listOfDeparture);
            this.Controls.Add(this.listOfArrive);
            this.Controls.Add(this.back_button);
            this.Name = "ListsViewing";
            this.Text = "Расписание прибывающих рейсов";
            ((System.ComponentModel.ISupportInitialize)(this.listOfArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDeparture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView listOfArrive;
        private System.Windows.Forms.DataGridView listOfDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn exit;
    }
}