
namespace Flight_scoreboard
{
    partial class Accaunt_choice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.enter_button.Location = new System.Drawing.Point(197, 168);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(94, 29);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // passwordMessage
            // 
            this.passwordMessage.AutoSize = true;
            this.passwordMessage.Location = new System.Drawing.Point(29, 70);
            this.passwordMessage.Name = "passwordMessage";
            this.passwordMessage.Size = new System.Drawing.Size(120, 20);
            this.passwordMessage.TabIndex = 1;
            this.passwordMessage.Text = "Введите пароль";
            // 
            // passwordEnter
            // 
            this.passwordEnter.Location = new System.Drawing.Point(156, 70);
            this.passwordEnter.Name = "passwordEnter";
            this.passwordEnter.Size = new System.Drawing.Size(215, 27);
            this.passwordEnter.TabIndex = 2;
            // 
            // Accaunt_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 226);
            this.Controls.Add(this.passwordEnter);
            this.Controls.Add(this.passwordMessage);
            this.Controls.Add(this.enter_button);
            this.Name = "Accaunt_choice";
            this.Text = "Ввод пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label passwordMessage;
        private System.Windows.Forms.TextBox passwordEnter;
    }
}

