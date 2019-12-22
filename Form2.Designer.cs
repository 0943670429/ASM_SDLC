namespace WindowsFormsApp1
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "WELCOME TO TUNE SOUCRE";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Forgot Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "create a new account";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(86, 54);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(205, 20);
            this.username.TabIndex = 5;
            this.username.Text = "User Name";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(86, 97);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(205, 20);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 313);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}