
namespace Flight_scoreboard
{
    partial class Lists_editing
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
            this.editArriving = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.ComboBox();
            this.exitBox = new System.Windows.Forms.ComboBox();
            this.timeBox = new System.Windows.Forms.DateTimePicker();
            this.add_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depDestination = new System.Windows.Forms.ComboBox();
            this.destLabel = new System.Windows.Forms.Label();
            this.editDeparture = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.editArriving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDeparture)).BeginInit();
            this.SuspendLayout();
            // 
            // editArriving
            // 
            this.editArriving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editArriving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.aircraftNumber,
            this.time,
            this.exit});
            this.editArriving.Location = new System.Drawing.Point(0, -1);
            this.editArriving.Name = "editArriving";
            this.editArriving.RowHeadersWidth = 51;
            this.editArriving.RowTemplate.Height = 29;
            this.editArriving.Size = new System.Drawing.Size(551, 497);
            this.editArriving.TabIndex = 0;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // aircraftNumber
            // 
            this.aircraftNumber.Frozen = true;
            this.aircraftNumber.HeaderText = "Номер рейса";
            this.aircraftNumber.MinimumWidth = 6;
            this.aircraftNumber.Name = "aircraftNumber";
            this.aircraftNumber.ReadOnly = true;
            this.aircraftNumber.Width = 125;
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
            this.exit.Width = 125;
            // 
            // number
            // 
            this.number.FormattingEnabled = true;
            this.number.Location = new System.Drawing.Point(767, 40);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(250, 28);
            this.number.TabIndex = 2;
            // 
            // exitBox
            // 
            this.exitBox.FormattingEnabled = true;
            this.exitBox.Location = new System.Drawing.Point(767, 225);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(250, 28);
            this.exitBox.TabIndex = 3;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(767, 151);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(250, 27);
            this.timeBox.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(672, 275);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(126, 67);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Добавить новую запись";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(817, 275);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(126, 67);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Сохранить изменения";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(960, 275);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(126, 67);
            this.del_button.TabIndex = 7;
            this.del_button.Text = "Удалить запись";
            this.del_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(991, 454);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(94, 29);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(659, 43);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(102, 20);
            this.numberLabel.TabIndex = 9;
            this.numberLabel.Text = "Номер рейса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Выход";
            // 
            // depDestination
            // 
            this.depDestination.FormattingEnabled = true;
            this.depDestination.Location = new System.Drawing.Point(767, 95);
            this.depDestination.Name = "depDestination";
            this.depDestination.Size = new System.Drawing.Size(250, 28);
            this.depDestination.TabIndex = 12;
            this.depDestination.Visible = false;
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(625, 98);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(136, 20);
            this.destLabel.TabIndex = 13;
            this.destLabel.Text = "Пункт назначения";
            this.destLabel.Visible = false;
            // 
            // editDeparture
            // 
            this.editDeparture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editDeparture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.destination,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.editDeparture.Location = new System.Drawing.Point(0, -1);
            this.editDeparture.Name = "editDeparture";
            this.editDeparture.RowHeadersWidth = 51;
            this.editDeparture.RowTemplate.Height = 29;
            this.editDeparture.Size = new System.Drawing.Size(551, 497);
            this.editDeparture.TabIndex = 14;
            this.editDeparture.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер рейса";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // destination
            // 
            this.destination.Frozen = true;
            this.destination.HeaderText = "Пункт назначения";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Время";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Выход";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // Lists_editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 495);
            this.Controls.Add(this.editDeparture);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.depDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.number);
            this.Controls.Add(this.editArriving);
            this.Name = "Lists_editing";
            this.Text = "Lists_editing";
            ((System.ComponentModel.ISupportInitialize)(this.editArriving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDeparture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView editArriving;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn exit;
        private System.Windows.Forms.ComboBox number;
        private System.Windows.Forms.ComboBox exitBox;
        private System.Windows.Forms.DateTimePicker timeBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox depDestination;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.DataGridView editDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}