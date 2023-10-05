namespace RegistrationAndLogin
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAdult = new TextBox();
            textBoxChildren = new TextBox();
            groupBox1 = new GroupBox();
            buttonReturn = new RadioButton();
            buttonSingle = new RadioButton();
            groupBox2 = new GroupBox();
            buttonSecond = new RadioButton();
            buttonFirst = new RadioButton();
            IssueTicketButton = new Button();
            textTicket = new TextBox();
            infoBox = new PictureBox();
            closeBox = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 40);
            label1.Name = "label1";
            label1.Size = new Size(384, 46);
            label1.TabIndex = 0;
            label1.Text = "Railway booking ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(176, 155);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Adults";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(475, 153);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Children";
            // 
            // textBoxAdult
            // 
            textBoxAdult.Location = new Point(250, 155);
            textBoxAdult.Name = "textBoxAdult";
            textBoxAdult.Size = new Size(52, 27);
            textBoxAdult.TabIndex = 3;
            textBoxAdult.Text = "0";
            // 
            // textBoxChildren
            // 
            textBoxChildren.Location = new Point(567, 153);
            textBoxChildren.Name = "textBoxChildren";
            textBoxChildren.Size = new Size(54, 27);
            textBoxChildren.TabIndex = 4;
            textBoxChildren.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonReturn);
            groupBox1.Controls.Add(buttonSingle);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(82, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Journey type";
            // 
            // buttonReturn
            // 
            buttonReturn.AutoSize = true;
            buttonReturn.Location = new Point(25, 75);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(84, 29);
            buttonReturn.TabIndex = 1;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonSingle
            // 
            buttonSingle.AutoSize = true;
            buttonSingle.Checked = true;
            buttonSingle.Location = new Point(25, 41);
            buttonSingle.Name = "buttonSingle";
            buttonSingle.Size = new Size(81, 29);
            buttonSingle.TabIndex = 0;
            buttonSingle.TabStop = true;
            buttonSingle.Text = "Single";
            buttonSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSecond);
            groupBox2.Controls.Add(buttonFirst);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(455, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Class";
            // 
            // buttonSecond
            // 
            buttonSecond.AutoSize = true;
            buttonSecond.Location = new Point(23, 75);
            buttonSecond.Name = "buttonSecond";
            buttonSecond.Size = new Size(92, 29);
            buttonSecond.TabIndex = 1;
            buttonSecond.Text = "Second";
            buttonSecond.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            buttonFirst.AutoSize = true;
            buttonFirst.Checked = true;
            buttonFirst.Location = new Point(22, 35);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(66, 29);
            buttonFirst.TabIndex = 0;
            buttonFirst.TabStop = true;
            buttonFirst.Text = "First";
            buttonFirst.UseVisualStyleBackColor = true;
            // 
            // IssueTicketButton
            // 
            IssueTicketButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            IssueTicketButton.Location = new Point(345, 392);
            IssueTicketButton.Name = "IssueTicketButton";
            IssueTicketButton.Size = new Size(111, 36);
            IssueTicketButton.TabIndex = 7;
            IssueTicketButton.Text = "Issue ticket";
            IssueTicketButton.UseVisualStyleBackColor = true;
            IssueTicketButton.Click += IssueTicketButton_Click;
            // 
            // textTicket
            // 
            textTicket.Location = new Point(331, 445);
            textTicket.Name = "textTicket";
            textTicket.Size = new Size(143, 27);
            textTicket.TabIndex = 8;
            // 
            // infoBox
            // 
            infoBox.Image = (Image)resources.GetObject("infoBox.Image");
            infoBox.Location = new Point(646, 426);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(59, 47);
            infoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            infoBox.TabIndex = 9;
            infoBox.TabStop = false;
            infoBox.Click += pictureBox1_Click;
            // 
            // closeBox
            // 
            closeBox.Image = (Image)resources.GetObject("closeBox.Image");
            closeBox.Location = new Point(718, 426);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(56, 51);
            closeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBox.TabIndex = 10;
            closeBox.TabStop = false;
            closeBox.Click += pictureBox1_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 485);
            Controls.Add(closeBox);
            Controls.Add(infoBox);
            Controls.Add(textTicket);
            Controls.Add(IssueTicketButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBoxChildren);
            Controls.Add(textBoxAdult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAdult;
        private TextBox textBoxChildren;
        private GroupBox groupBox1;
        private RadioButton buttonReturn;
        private RadioButton buttonSingle;
        private GroupBox groupBox2;
        private RadioButton buttonSecond;
        private RadioButton buttonFirst;
        private Button IssueTicketButton;
        private TextBox textTicket;
        private PictureBox infoBox;
        private PictureBox closeBox;
    }
}