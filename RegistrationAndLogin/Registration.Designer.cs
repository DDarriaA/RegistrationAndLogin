namespace RegistrationAndLogin
{
    partial class Registration
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
            label1 = new Label();
            usernameField = new TextBox();
            label2 = new Label();
            passwordField = new TextBox();
            button1 = new Button();
            button2 = new Button();
            confirmpasswordField = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 83);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter username";
            label1.Click += label1_Click;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(180, 84);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(313, 27);
            usernameField.TabIndex = 2;
            usernameField.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 139);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter password";
            // 
            // passwordField
            // 
            passwordField.Location = new Point(179, 139);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(313, 27);
            passwordField.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(179, 279);
            button1.Name = "button1";
            button1.Size = new Size(175, 44);
            button1.TabIndex = 5;
            button1.Text = "Register ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(92, 354);
            button2.Name = "button2";
            button2.Size = new Size(326, 45);
            button2.TabIndex = 6;
            button2.Text = " Have an account? Login now.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // confirmpasswordField
            // 
            confirmpasswordField.Location = new Point(180, 200);
            confirmpasswordField.Name = "confirmpasswordField";
            confirmpasswordField.Size = new Size(313, 27);
            confirmpasswordField.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 200);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 8;
            label3.Text = "Confirm password";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(514, 428);
            Controls.Add(label3);
            Controls.Add(confirmpasswordField);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passwordField);
            Controls.Add(label2);
            Controls.Add(usernameField);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameField;
        private Label label2;
        private TextBox passwordField;
        private Button button1;
        private Button button2;
        private TextBox confirmpasswordField;
        private Label label3;
    }
}