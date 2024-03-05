namespace WinFormsApp1
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
            txtName = new TextBox();
            txtSurname = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            rbWhite = new RadioButton();
            rbBlack = new RadioButton();
            cboGender = new ComboBox();
            rbIndian = new RadioButton();
            chkTv = new CheckBox();
            chkBooks = new CheckBox();
            chkSport = new CheckBox();
            chkWork = new CheckBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btnValidate = new Button();
            lblSubmit = new Label();
            lblClear = new Label();
            lblValidate = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(74, 121);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(282, 23);
            txtSurname.TabIndex = 1;
            txtSurname.TextChanged += TextBox2_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(74, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // rbWhite
            // 
            rbWhite.AutoSize = true;
            rbWhite.Location = new Point(74, 254);
            rbWhite.Name = "rbWhite";
            rbWhite.Size = new Size(56, 19);
            rbWhite.TabIndex = 3;
            rbWhite.TabStop = true;
            rbWhite.Text = "White";
            rbWhite.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            rbBlack.AutoSize = true;
            rbBlack.Location = new Point(74, 279);
            rbBlack.Name = "rbBlack";
            rbBlack.Size = new Size(53, 19);
            rbBlack.TabIndex = 4;
            rbBlack.TabStop = true;
            rbBlack.Text = "Black";
            rbBlack.UseVisualStyleBackColor = true;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(74, 159);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(282, 23);
            cboGender.TabIndex = 5;
            // 
            // rbIndian
            // 
            rbIndian.AutoSize = true;
            rbIndian.Location = new Point(74, 304);
            rbIndian.Name = "rbIndian";
            rbIndian.Size = new Size(58, 19);
            rbIndian.TabIndex = 6;
            rbIndian.TabStop = true;
            rbIndian.Text = "Indian";
            rbIndian.UseVisualStyleBackColor = true;
            // 
            // chkTv
            // 
            chkTv.AutoSize = true;
            chkTv.Location = new Point(73, 346);
            chkTv.Name = "chkTv";
            chkTv.Size = new Size(37, 19);
            chkTv.TabIndex = 7;
            chkTv.Text = "Tv";
            chkTv.UseVisualStyleBackColor = true;
            // 
            // chkBooks
            // 
            chkBooks.AutoSize = true;
            chkBooks.Location = new Point(73, 364);
            chkBooks.Name = "chkBooks";
            chkBooks.Size = new Size(58, 19);
            chkBooks.TabIndex = 8;
            chkBooks.Text = "Books";
            chkBooks.UseVisualStyleBackColor = true;
            chkBooks.CheckedChanged += chkBooks_CheckedChanged;
            // 
            // chkSport
            // 
            chkSport.AutoSize = true;
            chkSport.Location = new Point(73, 386);
            chkSport.Name = "chkSport";
            chkSport.Size = new Size(54, 19);
            chkSport.TabIndex = 9;
            chkSport.Text = "Sport";
            chkSport.UseVisualStyleBackColor = true;
            // 
            // chkWork
            // 
            chkWork.AutoSize = true;
            chkWork.Location = new Point(73, 407);
            chkWork.Name = "chkWork";
            chkWork.Size = new Size(54, 19);
            chkWork.TabIndex = 10;
            chkWork.Text = "Work";
            chkWork.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Location = new Point(73, 448);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(141, 33);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(277, 446);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = SystemColors.ActiveCaption;
            btnValidate.Location = new Point(494, 448);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(157, 35);
            btnValidate.TabIndex = 14;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblSubmit
            // 
            lblSubmit.AutoSize = true;
            lblSubmit.Location = new Point(301, 520);
            lblSubmit.Name = "lblSubmit";
            lblSubmit.Size = new Size(0, 15);
            lblSubmit.TabIndex = 15;
            lblSubmit.Click += label1_Click;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Location = new Point(481, 521);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(0, 15);
            lblClear.TabIndex = 16;
            // 
            // lblValidate
            // 
            lblValidate.AutoSize = true;
            lblValidate.Location = new Point(651, 466);
            lblValidate.Name = "lblValidate";
            lblValidate.Size = new Size(0, 15);
            lblValidate.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(74, 62);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 18;
            label1.Text = "Enter your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(74, 106);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 19;
            label2.Text = "Enter your Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(74, 147);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 20;
            label3.Text = "Choose your gender\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(74, 189);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 21;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(74, 236);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 22;
            label5.Text = "Race";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(74, 328);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 23;
            label6.Text = "Choose your hobbies\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 641);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblValidate);
            Controls.Add(lblClear);
            Controls.Add(lblSubmit);
            Controls.Add(btnValidate);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(chkWork);
            Controls.Add(chkSport);
            Controls.Add(chkBooks);
            Controls.Add(chkTv);
            Controls.Add(rbIndian);
            Controls.Add(cboGender);
            Controls.Add(rbBlack);
            Controls.Add(rbWhite);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbWhite;
        private RadioButton rbBlack;
        private ComboBox cboGender;
        private RadioButton rbIndian;
        private CheckBox chkTv;
        private CheckBox chkBooks;
        private CheckBox chkSport;
        private CheckBox chkWork;
        private Button btnSubmit;
        private Button btnClear;
        private Button button3;
        private Button btnValidate;
        private Label lblSubmit;
        private Label lblClear;
        private Label lblValidate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
