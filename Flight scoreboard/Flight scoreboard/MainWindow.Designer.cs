
namespace Flight_scoreboard
{
    partial class MainWindow
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
            this.listViewing = new System.Windows.Forms.Button();
            this.listEditing = new System.Windows.Forms.Button();
            this.accChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewing
            // 
            this.listViewing.Location = new System.Drawing.Point(111, 54);
            this.listViewing.Name = "listViewing";
            this.listViewing.Size = new System.Drawing.Size(176, 70);
            this.listViewing.TabIndex = 0;
            this.listViewing.Text = "Просмотр расписания прибывающих рейсов";
            this.listViewing.UseVisualStyleBackColor = true;
            this.listViewing.Click += new System.EventHandler(this.listViewing_Click);
            // 
            // listEditing
            // 
            this.listEditing.Location = new System.Drawing.Point(111, 180);
            this.listEditing.Name = "listEditing";
            this.listEditing.Size = new System.Drawing.Size(176, 70);
            this.listEditing.TabIndex = 1;
            this.listEditing.Text = "Редактирование расписания прибывающих рейсов";
            this.listEditing.UseVisualStyleBackColor = true;
            this.listEditing.Click += new System.EventHandler(this.listEditing_Click);
            // 
            // accChange
            // 
            this.accChange.Location = new System.Drawing.Point(265, 325);
            this.accChange.Name = "accChange";
            this.accChange.Size = new System.Drawing.Size(133, 45);
            this.accChange.TabIndex = 2;
            this.accChange.Text = "Сменить аккаунт";
            this.accChange.UseVisualStyleBackColor = true;
            this.accChange.Click += new System.EventHandler(this.accChange_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 384);
            this.Controls.Add(this.accChange);
            this.Controls.Add(this.listEditing);
            this.Controls.Add(this.listViewing);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listViewing;
        private System.Windows.Forms.Button listEditing;
        private System.Windows.Forms.Button accChange;
    }
}