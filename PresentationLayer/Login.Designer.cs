namespace PresentationLayer
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            label3 = new Label();
            label4 = new Label();
            cb_show = new CheckBox();
            label7 = new Label();
            btn_create = new Button();
            label9 = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("MS UI Gothic", 13.8F);
            txt_username.Location = new Point(65, 186);
            txt_username.Margin = new Padding(4, 3, 4, 3);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(279, 41);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(230, 231, 233);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("MS UI Gothic", 13.8F);
            txt_password.Location = new Point(65, 292);
            txt_password.Margin = new Padding(4, 3, 4, 3);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(279, 41);
            txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(116, 86, 174);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(94, 411);
            btn_login.Margin = new Padding(4, 3, 4, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(221, 47);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(164, 165, 196);
            label3.Location = new Point(65, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 6;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(164, 165, 196);
            label4.Location = new Point(65, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.Cursor = Cursors.Hand;
            cb_show.FlatStyle = FlatStyle.Flat;
            cb_show.Location = new Point(234, 352);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(146, 27);
            cb_show.TabIndex = 16;
            cb_show.Text = "ShowPassword";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(116, 86, 174);
            label7.Location = new Point(65, 68);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(200, 46);
            label7.TabIndex = 17;
            label7.Text = "Get Started";
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.White;
            btn_create.Cursor = Cursors.Hand;
            btn_create.FlatAppearance.BorderSize = 0;
            btn_create.FlatStyle = FlatStyle.Flat;
            btn_create.ForeColor = Color.FromArgb(116, 86, 174);
            btn_create.Location = new Point(94, 502);
            btn_create.Margin = new Padding(4, 3, 4, 3);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(221, 47);
            btn_create.TabIndex = 21;
            btn_create.Text = "Create Account";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(164, 165, 196);
            label9.Location = new Point(99, 476);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(189, 23);
            label9.TabIndex = 20;
            label9.Text = "Dont Have an Account";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.White;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.Red;
            closeButton.Location = new Point(370, -6);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(42, 41);
            closeButton.TabIndex = 22;
            closeButton.Text = "✗";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 573);
            Controls.Add(closeButton);
            Controls.Add(btn_create);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cb_show);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private Label label3;
        private Label label4;
        private CheckBox cb_show;
        private Label label7;
        private Button btn_create;
        private Label label9;
        private Button closeButton;
    }
}