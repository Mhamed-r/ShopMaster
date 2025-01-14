namespace Registration_Form
{
   public partial class Register
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
            txt_username = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            txt_address = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nud_age = new NumericUpDown();
            label6 = new Label();
            cb_role = new ComboBox();
            btn_registration = new Button();
            btn_reset = new Button();
            cb_show = new CheckBox();
            label7 = new Label();
            label9 = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(49, 171);
            txt_username.Margin = new Padding(4, 3, 4, 3);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(279, 41);
            txt_username.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.FromArgb(230, 231, 233);
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("MS UI Gothic", 13.8F);
            txt_email.Location = new Point(49, 404);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(279, 41);
            txt_email.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(230, 231, 233);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("MS UI Gothic", 13.8F);
            txt_password.Location = new Point(49, 324);
            txt_password.Margin = new Padding(4, 3, 4, 3);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(279, 41);
            txt_password.TabIndex = 3;
            // 
            // txt_address
            // 
            txt_address.BackColor = Color.FromArgb(230, 231, 233);
            txt_address.BorderStyle = BorderStyle.None;
            txt_address.Font = new Font("MS UI Gothic", 13.8F);
            txt_address.Location = new Point(49, 253);
            txt_address.Margin = new Padding(4, 3, 4, 3);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(279, 41);
            txt_address.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(164, 165, 196);
            label1.Location = new Point(49, 145);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 5;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(164, 165, 196);
            label2.Location = new Point(49, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 6;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(164, 165, 196);
            label3.Location = new Point(49, 298);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(164, 165, 196);
            label4.Location = new Point(49, 375);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(164, 165, 196);
            label5.Location = new Point(49, 448);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 9;
            label5.Text = "Age";
            // 
            // nud_age
            // 
            nud_age.BackColor = Color.FromArgb(230, 231, 233);
            nud_age.Font = new Font("MS UI Gothic", 13.8F);
            nud_age.Location = new Point(49, 474);
            nud_age.Margin = new Padding(4, 3, 4, 3);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(279, 30);
            nud_age.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(164, 165, 196);
            label6.Location = new Point(49, 507);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 23);
            label6.TabIndex = 11;
            label6.Text = "Role";
            // 
            // cb_role
            // 
            cb_role.BackColor = Color.FromArgb(230, 231, 233);
            cb_role.FlatStyle = FlatStyle.Flat;
            cb_role.Font = new Font("MS UI Gothic", 13.8F);
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(49, 533);
            cb_role.Margin = new Padding(4, 3, 4, 3);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(279, 31);
            cb_role.TabIndex = 12;
            // 
            // btn_registration
            // 
            btn_registration.BackColor = Color.FromArgb(116, 86, 174);
            btn_registration.Cursor = Cursors.Hand;
            btn_registration.FlatAppearance.BorderSize = 0;
            btn_registration.FlatStyle = FlatStyle.Flat;
            btn_registration.ForeColor = Color.White;
            btn_registration.Location = new Point(78, 589);
            btn_registration.Margin = new Padding(4, 3, 4, 3);
            btn_registration.Name = "btn_registration";
            btn_registration.Size = new Size(221, 47);
            btn_registration.TabIndex = 13;
            btn_registration.Text = "REGISTER";
            btn_registration.UseVisualStyleBackColor = false;
            btn_registration.Click += btn_registration_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.White;
            btn_reset.Cursor = Cursors.Hand;
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.ForeColor = Color.FromArgb(116, 86, 174);
            btn_reset.Location = new Point(78, 654);
            btn_reset.Margin = new Padding(4, 3, 4, 3);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(221, 47);
            btn_reset.TabIndex = 14;
            btn_reset.Text = "CLEAR";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.Cursor = Cursors.Hand;
            cb_show.FlatStyle = FlatStyle.Flat;
            cb_show.Location = new Point(182, 371);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(146, 27);
            cb_show.TabIndex = 15;
            cb_show.Text = "ShowPassword";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(116, 86, 174);
            label7.Location = new Point(49, 73);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(200, 46);
            label7.TabIndex = 16;
            label7.Text = "Get Started";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(164, 165, 196);
            label9.Location = new Point(88, 723);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(211, 23);
            label9.TabIndex = 18;
            label9.Text = "Already Have an Account";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.FromArgb(116, 86, 174);
            btn_back.Location = new Point(78, 749);
            btn_back.Margin = new Padding(4, 3, 4, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(221, 47);
            btn_back.TabIndex = 19;
            btn_back.Text = "Back To LOGIN";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 837);
            Controls.Add(btn_back);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cb_show);
            Controls.Add(btn_reset);
            Controls.Add(btn_registration);
            Controls.Add(cb_role);
            Controls.Add(label6);
            Controls.Add(nud_age);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_address);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_username);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 196);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_email;
        private TextBox txt_password;
        private TextBox txt_address;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nud_age;
        private Label label6;
        private ComboBox cb_role;
        private Button btn_registration;
        private Button btn_reset;
        private CheckBox cb_show;
        private Label label7;
        private Label label9;
        private Button btn_back;
    }
}
