
namespace Flight_scoreboard
{
    partial class Main_window
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
            this.listsViewing = new System.Windows.Forms.Button();
            this.listsEditing = new System.Windows.Forms.Button();
            this.accChange = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listsViewing
            // 
            this.listsViewing.Location = new System.Drawing.Point(76, 38);
            this.listsViewing.Name = "listsViewing";
            this.listsViewing.Size = new System.Drawing.Size(133, 56);
            this.listsViewing.TabIndex = 0;
            this.listsViewing.Text = "Просмотр рапсисания прибывающих рейсов";
            this.listsViewing.UseVisualStyleBackColor = true;
            this.listsViewing.Click += new System.EventHandler(this.listsViewing_Click);
            // 
            // listsEditing
            // 
            this.listsEditing.Location = new System.Drawing.Point(76, 127);
            this.listsEditing.Name = "listsEditing";
            this.listsEditing.Size = new System.Drawing.Size(133, 56);
            this.listsEditing.TabIndex = 1;
            this.listsEditing.Text = "Редактирование расписания прибывающих рейсов";
            this.listsEditing.UseVisualStyleBackColor = true;
            this.listsEditing.Click += new System.EventHandler(this.listsEditing_Click);
            // 
            // accChange
            // 
            this.accChange.Location = new System.Drawing.Point(148, 229);
            this.accChange.Name = "accChange";
            this.accChange.Size = new System.Drawing.Size(114, 25);
            this.accChange.TabIndex = 2;
            this.accChange.Text = "Сменить аккаунт";
            this.accChange.UseVisualStyleBackColor = true;
            this.accChange.Click += new System.EventHandler(this.AccChange_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(12, 231);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 266);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.accChange);
            this.Controls.Add(this.listsEditing);
            this.Controls.Add(this.listsViewing);
            this.Name = "Main_window";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listsViewing;
        private System.Windows.Forms.Button listsEditing;
        private System.Windows.Forms.Button accChange;
        private System.Windows.Forms.Button exit_button;
    }
}