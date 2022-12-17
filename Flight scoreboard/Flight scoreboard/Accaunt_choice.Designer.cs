
namespace Flight_scoreboard
{
    partial class Accaunt_choice
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter_button = new System.Windows.Forms.Button();
            this.passwordMessage = new System.Windows.Forms.Label();
            this.passwordEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(139, 89);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(75, 23);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // passwordMessage
            // 
            this.passwordMessage.AutoSize = true;
            this.passwordMessage.Location = new System.Drawing.Point(22, 31);
            this.passwordMessage.Name = "passwordMessage";
            this.passwordMessage.Size = new System.Drawing.Size(88, 13);
            this.passwordMessage.TabIndex = 1;
            this.passwordMessage.Text = "Введите пароль";
            // 
            // passwordEnter
            // 
            this.passwordEnter.Location = new System.Drawing.Point(116, 28);
            this.passwordEnter.Name = "passwordEnter";
            this.passwordEnter.Size = new System.Drawing.Size(174, 20);
            this.passwordEnter.TabIndex = 2;
            // 
            // Accaunt_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 135);
            this.Controls.Add(this.passwordEnter);
            this.Controls.Add(this.passwordMessage);
            this.Controls.Add(this.enter_button);
            this.Name = "Accaunt_choice";
            this.Text = "Выберите аккаунт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label passwordMessage;
        private System.Windows.Forms.TextBox passwordEnter;
    }
}

