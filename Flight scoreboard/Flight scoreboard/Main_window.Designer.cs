
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            this.listsViewing = new System.Windows.Forms.Button();
            this.listsEditing = new System.Windows.Forms.Button();
            this.accChange = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listsViewing
            // 
            this.listsViewing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listsViewing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listsViewing.Location = new System.Drawing.Point(101, 47);
            this.listsViewing.Margin = new System.Windows.Forms.Padding(4);
            this.listsViewing.Name = "listsViewing";
            this.listsViewing.Size = new System.Drawing.Size(177, 69);
            this.listsViewing.TabIndex = 0;
            this.listsViewing.Text = "Просмотр рапсисания прибывающих рейсов";
            this.listsViewing.UseVisualStyleBackColor = false;
            this.listsViewing.Click += new System.EventHandler(this.listsViewing_Click);
            // 
            // listsEditing
            // 
            this.listsEditing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listsEditing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listsEditing.Location = new System.Drawing.Point(101, 156);
            this.listsEditing.Margin = new System.Windows.Forms.Padding(4);
            this.listsEditing.Name = "listsEditing";
            this.listsEditing.Size = new System.Drawing.Size(177, 69);
            this.listsEditing.TabIndex = 1;
            this.listsEditing.Text = "Редактирование расписания прибывающих рейсов";
            this.listsEditing.UseVisualStyleBackColor = false;
            this.listsEditing.Click += new System.EventHandler(this.listsEditing_Click);
            // 
            // accChange
            // 
            this.accChange.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.accChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accChange.Location = new System.Drawing.Point(197, 282);
            this.accChange.Margin = new System.Windows.Forms.Padding(4);
            this.accChange.Name = "accChange";
            this.accChange.Size = new System.Drawing.Size(152, 31);
            this.accChange.TabIndex = 2;
            this.accChange.Text = "Сменить аккаунт";
            this.accChange.UseVisualStyleBackColor = false;
            this.accChange.Click += new System.EventHandler(this.AccChange_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_button.Location = new System.Drawing.Point(16, 284);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(100, 28);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(365, 327);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.accChange);
            this.Controls.Add(this.listsEditing);
            this.Controls.Add(this.listsViewing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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