
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accaunt_choice));
            this.enter_button = new System.Windows.Forms.Button();
            this.passwordMessage = new System.Windows.Forms.Label();
            this.passwordEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter_button.Location = new System.Drawing.Point(185, 110);
            this.enter_button.Margin = new System.Windows.Forms.Padding(4);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(100, 28);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // passwordMessage
            // 
            this.passwordMessage.AutoSize = true;
            this.passwordMessage.Location = new System.Drawing.Point(33, 37);
            this.passwordMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordMessage.Name = "passwordMessage";
            this.passwordMessage.Size = new System.Drawing.Size(114, 17);
            this.passwordMessage.TabIndex = 1;
            this.passwordMessage.Text = "Введите пароль";
            // 
            // passwordEnter
            // 
            this.passwordEnter.BackColor = System.Drawing.SystemColors.Menu;
            this.passwordEnter.Location = new System.Drawing.Point(155, 34);
            this.passwordEnter.Margin = new System.Windows.Forms.Padding(4);
            this.passwordEnter.Name = "passwordEnter";
            this.passwordEnter.Size = new System.Drawing.Size(231, 22);
            this.passwordEnter.TabIndex = 2;
            // 
            // Accaunt_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 166);
            this.Controls.Add(this.passwordEnter);
            this.Controls.Add(this.passwordMessage);
            this.Controls.Add(this.enter_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Accaunt_choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в аккаунт администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label passwordMessage;
        private System.Windows.Forms.TextBox passwordEnter;
    }
}

