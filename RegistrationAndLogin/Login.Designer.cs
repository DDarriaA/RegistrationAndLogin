namespace RegistrationAndLogin
{
    partial class Login
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            usernameField = new TextBox();
            passwordField = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(153, 212);
            button1.Name = "button1";
            button1.Size = new Size(146, 49);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(134, 298);
            button2.Name = "button2";
            button2.Size = new Size(182, 36);
            button2.TabIndex = 1;
            button2.Text = "Create an account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 2;
            label1.Text = "Enter username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 130);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter password";
            // 
            // usernameField
            // 
            usernameField.Location = new Point(164, 93);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(285, 27);
            usernameField.TabIndex = 4;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(164, 134);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(285, 27);
            passwordField.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(461, 358);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox usernameField;
        private TextBox passwordField;
    }
}