namespace OOP
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(145, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 93);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 0);
            label1.Name = "label1";
            label1.Size = new Size(423, 86);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 449);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 119);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 7;
            label3.Text = "Dashboard";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Location = new Point(13, 288);
            button4.Name = "button4";
            button4.Size = new Size(177, 33);
            button4.TabIndex = 6;
            button4.Text = "EvaluateApplicants";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Location = new Point(13, 234);
            button3.Name = "button3";
            button3.Size = new Size(177, 33);
            button3.TabIndex = 5;
            button3.Text = "ScheduleApplicants";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(13, 177);
            button2.Name = "button2";
            button2.Size = new Size(177, 33);
            button2.TabIndex = 4;
            button2.Text = "ViewApplicants";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 2);
            label2.Name = "label2";
            label2.Size = new Size(123, 86);
            label2.TabIndex = 2;
            label2.Text = "HR";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(227, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "DASHBOARD";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}