namespace OOP
{
    partial class Form1
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
            label1 = new Label();
            userBox = new TextBox();
            button3 = new Button();
            button2 = new Button();
            passBox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 18);
            label1.Name = "label1";
            label1.Size = new Size(655, 65);
            label1.TabIndex = 0;
            label1.Text = "HR MANAGEMENT SYSTEM";
            // 
            // userBox
            // 
            userBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userBox.BackColor = Color.White;
            userBox.BorderStyle = BorderStyle.None;
            userBox.Location = new Point(48, 81);
            userBox.Multiline = true;
            userBox.Name = "userBox";
            userBox.PlaceholderText = "username";
            userBox.Size = new Size(308, 41);
            userBox.TabIndex = 1;
            userBox.TextAlign = HorizontalAlignment.Center;
            userBox.UseSystemPasswordChar = true;
            userBox.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(74, 215);
            button3.Name = "button3";
            button3.Size = new Size(270, 26);
            button3.TabIndex = 7;
            button3.Text = "appy as applicant";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(280, 186);
            button2.Name = "button2";
            button2.Size = new Size(76, 23);
            button2.TabIndex = 6;
            button2.Text = "login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // passBox
            // 
            passBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passBox.BackColor = Color.White;
            passBox.BorderStyle = BorderStyle.None;
            passBox.Location = new Point(48, 139);
            passBox.Multiline = true;
            passBox.Name = "passBox";
            passBox.PlaceholderText = "password";
            passBox.Size = new Size(308, 41);
            passBox.TabIndex = 4;
            passBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(48, 186);
            button1.Name = "button1";
            button1.Size = new Size(173, 23);
            button1.TabIndex = 5;
            button1.Text = "forgot password?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(132, 13);
            label2.Name = "label2";
            label2.Size = new Size(175, 65);
            label2.TabIndex = 3;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(userBox);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(passBox);
            groupBox1.Location = new Point(47, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 258);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._36072460b42c39a8cd8c32118e4d7d0b2cf2b9af;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(489, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 258);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(849, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userBox;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox passBox;
        private Label label2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
