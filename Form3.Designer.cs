namespace WindowsFormsApp1
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.reapeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "WELCOME TO TUNE SOUCRE";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(52, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 35);
            this.button7.TabIndex = 7;
            this.button7.Text = "LOGIN";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login with Facebook";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "Login with Email";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "REGISTRATION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(226, 52);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(199, 20);
            this.username.TabIndex = 20;
            this.username.Text = "User Name";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(226, 90);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(199, 20);
            this.mail.TabIndex = 15;
            this.mail.Text = "Email";
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(226, 127);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(199, 20);
            this.password.TabIndex = 16;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // reapeat
            // 
            this.reapeat.Location = new System.Drawing.Point(226, 167);
            this.reapeat.Name = "reapeat";
            this.reapeat.Size = new System.Drawing.Size(199, 20);
            this.reapeat.TabIndex = 17;
            this.reapeat.Text = "Reapeat Password";
            this.reapeat.TextChanged += new System.EventHandler(this.reapeat_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 276);
            this.Controls.Add(this.reapeat);
            this.Controls.Add(this.password);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox reapeat;
    }
}