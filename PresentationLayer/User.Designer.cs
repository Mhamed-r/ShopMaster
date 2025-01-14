namespace PresentationLayer
{
    partial class User
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label7 = new Label();
            closeButton = new Button();
            panel1 = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btn_userlogout = new Button();
            brn_logout = new Button();
            lb_username = new Label();
            tab_control = new Guna.UI2.WinForms.Guna2TabControl();
            tab_products = new TabPage();
            dgv_Productshow = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_proback = new Button();
            btn_add = new Button();
            tab_favorites = new TabPage();
            dgv_favshow = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_favdelete = new Button();
            btn_favback = new Button();
            tab_userprofile = new TabPage();
            btn_profileupdate = new Button();
            label8 = new Label();
            txt_conprofilepassword = new TextBox();
            cb_show = new CheckBox();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            txt_profilepassword = new TextBox();
            txt_profileemail = new TextBox();
            txt_profilename = new TextBox();
            userservicesBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            tab_control.SuspendLayout();
            tab_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productshow).BeginInit();
            tab_favorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_favshow).BeginInit();
            tab_userprofile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userservicesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 12);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(231, 60);
            label7.TabIndex = 16;
            label7.Text = "User Page";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(46, 26, 71);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.Red;
            closeButton.Location = new Point(1092, -9);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(42, 41);
            closeButton.TabIndex = 20;
            closeButton.Text = "✗";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 26, 71);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(btn_userlogout);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(brn_logout);
            panel1.Controls.Add(lb_username);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 100);
            panel1.TabIndex = 22;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(922, 15);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(88, 70);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 40;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // btn_userlogout
            // 
            btn_userlogout.BackColor = Color.FromArgb(46, 26, 71);
            btn_userlogout.BackgroundImage = (Image)resources.GetObject("btn_userlogout.BackgroundImage");
            btn_userlogout.BackgroundImageLayout = ImageLayout.Zoom;
            btn_userlogout.FlatAppearance.BorderSize = 0;
            btn_userlogout.FlatStyle = FlatStyle.Flat;
            btn_userlogout.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_userlogout.ForeColor = Color.White;
            btn_userlogout.Location = new Point(1005, 24);
            btn_userlogout.Margin = new Padding(4, 3, 4, 3);
            btn_userlogout.Name = "btn_userlogout";
            btn_userlogout.Size = new Size(68, 52);
            btn_userlogout.TabIndex = 41;
            btn_userlogout.UseVisualStyleBackColor = false;
            btn_userlogout.Click += btn_userlogout_Click;
            // 
            // brn_logout
            // 
            brn_logout.BackColor = Color.FromArgb(46, 26, 71);
            brn_logout.BackgroundImageLayout = ImageLayout.Zoom;
            brn_logout.FlatAppearance.BorderSize = 0;
            brn_logout.FlatStyle = FlatStyle.Flat;
            brn_logout.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brn_logout.ForeColor = Color.White;
            brn_logout.Location = new Point(1005, 24);
            brn_logout.Margin = new Padding(4, 3, 4, 3);
            brn_logout.Name = "brn_logout";
            brn_logout.Size = new Size(68, 52);
            brn_logout.TabIndex = 37;
            brn_logout.UseVisualStyleBackColor = false;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.ForeColor = Color.White;
            lb_username.Location = new Point(761, 41);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(0, 23);
            lb_username.TabIndex = 39;
            // 
            // tab_control
            // 
            tab_control.Alignment = TabAlignment.Left;
            tab_control.Controls.Add(tab_products);
            tab_control.Controls.Add(tab_favorites);
            tab_control.Controls.Add(tab_userprofile);
            tab_control.Dock = DockStyle.Left;
            tab_control.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            tab_control.ItemSize = new Size(180, 80);
            tab_control.Location = new Point(0, 100);
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Size = new Size(1126, 549);
            tab_control.TabButtonHoverState.BorderColor = Color.Empty;
            tab_control.TabButtonHoverState.FillColor = Color.FromArgb(73, 66, 122);
            tab_control.TabButtonHoverState.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            tab_control.TabButtonHoverState.ForeColor = Color.White;
            tab_control.TabButtonHoverState.InnerColor = Color.FromArgb(116, 86, 174);
            tab_control.TabButtonIdleState.BorderColor = Color.Empty;
            tab_control.TabButtonIdleState.FillColor = Color.FromArgb(46, 26, 71);
            tab_control.TabButtonIdleState.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            tab_control.TabButtonIdleState.ForeColor = Color.White;
            tab_control.TabButtonIdleState.InnerColor = Color.FromArgb(46, 26, 71);
            tab_control.TabButtonSelectedState.BorderColor = Color.Empty;
            tab_control.TabButtonSelectedState.FillColor = Color.FromArgb(73, 66, 122);
            tab_control.TabButtonSelectedState.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            tab_control.TabButtonSelectedState.ForeColor = Color.White;
            tab_control.TabButtonSelectedState.InnerColor = Color.FromArgb(229, 226, 255);
            tab_control.TabButtonSize = new Size(180, 80);
            tab_control.TabIndex = 24;
            tab_control.TabMenuBackColor = Color.FromArgb(46, 26, 71);
            // 
            // tab_products
            // 
            tab_products.Controls.Add(dgv_Productshow);
            tab_products.Controls.Add(btn_proback);
            tab_products.Controls.Add(btn_add);
            tab_products.ForeColor = Color.Black;
            tab_products.Location = new Point(184, 4);
            tab_products.Name = "tab_products";
            tab_products.Padding = new Padding(3);
            tab_products.Size = new Size(938, 541);
            tab_products.TabIndex = 0;
            tab_products.Text = "Products";
            tab_products.UseVisualStyleBackColor = true;
            // 
            // dgv_Productshow
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv_Productshow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Productshow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Productshow.ColumnHeadersHeight = 4;
            dgv_Productshow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Productshow.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Productshow.Dock = DockStyle.Top;
            dgv_Productshow.GridColor = Color.FromArgb(231, 229, 255);
            dgv_Productshow.Location = new Point(3, 3);
            dgv_Productshow.Name = "dgv_Productshow";
            dgv_Productshow.RowHeadersVisible = false;
            dgv_Productshow.RowHeadersWidth = 51;
            dgv_Productshow.Size = new Size(932, 458);
            dgv_Productshow.TabIndex = 36;
            dgv_Productshow.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv_Productshow.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv_Productshow.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv_Productshow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv_Productshow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv_Productshow.ThemeStyle.BackColor = Color.White;
            dgv_Productshow.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgv_Productshow.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv_Productshow.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Productshow.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dgv_Productshow.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv_Productshow.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_Productshow.ThemeStyle.HeaderStyle.Height = 4;
            dgv_Productshow.ThemeStyle.ReadOnly = false;
            dgv_Productshow.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv_Productshow.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Productshow.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dgv_Productshow.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgv_Productshow.ThemeStyle.RowsStyle.Height = 29;
            dgv_Productshow.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv_Productshow.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgv_Productshow.CellDoubleClick += dgv_Productshow_CellDoubleClick;
            // 
            // btn_proback
            // 
            btn_proback.BackColor = Color.Transparent;
            btn_proback.Cursor = Cursors.Hand;
            btn_proback.FlatAppearance.BorderSize = 0;
            btn_proback.FlatStyle = FlatStyle.Flat;
            btn_proback.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_proback.ForeColor = Color.FromArgb(46, 26, 71);
            btn_proback.Location = new Point(-5, 511);
            btn_proback.Margin = new Padding(4, 3, 4, 3);
            btn_proback.Name = "btn_proback";
            btn_proback.Size = new Size(35, 29);
            btn_proback.TabIndex = 30;
            btn_proback.Text = "↩";
            btn_proback.UseVisualStyleBackColor = false;
            btn_proback.Click += btn_proback_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(46, 26, 71);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(348, 476);
            btn_add.Margin = new Padding(4, 3, 4, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(191, 47);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add to Favorites";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // tab_favorites
            // 
            tab_favorites.Controls.Add(dgv_favshow);
            tab_favorites.Controls.Add(btn_favdelete);
            tab_favorites.Controls.Add(btn_favback);
            tab_favorites.ForeColor = Color.Black;
            tab_favorites.Location = new Point(184, 4);
            tab_favorites.Name = "tab_favorites";
            tab_favorites.Padding = new Padding(3);
            tab_favorites.Size = new Size(938, 541);
            tab_favorites.TabIndex = 1;
            tab_favorites.Text = "Favorites";
            tab_favorites.UseVisualStyleBackColor = true;
            // 
            // dgv_favshow
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgv_favshow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_favshow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_favshow.ColumnHeadersHeight = 4;
            dgv_favshow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_favshow.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_favshow.Dock = DockStyle.Top;
            dgv_favshow.GridColor = Color.FromArgb(231, 229, 255);
            dgv_favshow.Location = new Point(3, 3);
            dgv_favshow.Name = "dgv_favshow";
            dgv_favshow.RowHeadersVisible = false;
            dgv_favshow.RowHeadersWidth = 51;
            dgv_favshow.Size = new Size(932, 457);
            dgv_favshow.TabIndex = 48;
            dgv_favshow.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv_favshow.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv_favshow.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv_favshow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv_favshow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv_favshow.ThemeStyle.BackColor = Color.White;
            dgv_favshow.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgv_favshow.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv_favshow.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_favshow.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dgv_favshow.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv_favshow.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_favshow.ThemeStyle.HeaderStyle.Height = 4;
            dgv_favshow.ThemeStyle.ReadOnly = false;
            dgv_favshow.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv_favshow.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_favshow.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dgv_favshow.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgv_favshow.ThemeStyle.RowsStyle.Height = 29;
            dgv_favshow.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv_favshow.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgv_favshow.CellDoubleClick += dgv_favshow_CellDoubleClick;
            // 
            // btn_favdelete
            // 
            btn_favdelete.BackColor = Color.FromArgb(46, 26, 71);
            btn_favdelete.FlatAppearance.BorderSize = 0;
            btn_favdelete.FlatStyle = FlatStyle.Flat;
            btn_favdelete.ForeColor = Color.White;
            btn_favdelete.Location = new Point(348, 476);
            btn_favdelete.Margin = new Padding(4, 3, 4, 3);
            btn_favdelete.Name = "btn_favdelete";
            btn_favdelete.Size = new Size(191, 47);
            btn_favdelete.TabIndex = 47;
            btn_favdelete.Text = "DELETE";
            btn_favdelete.UseVisualStyleBackColor = false;
            btn_favdelete.Click += btn_favdelete_Click;
            // 
            // btn_favback
            // 
            btn_favback.BackColor = Color.Transparent;
            btn_favback.Cursor = Cursors.Hand;
            btn_favback.FlatAppearance.BorderSize = 0;
            btn_favback.FlatStyle = FlatStyle.Flat;
            btn_favback.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_favback.ForeColor = Color.FromArgb(46, 26, 71);
            btn_favback.Location = new Point(-1, 510);
            btn_favback.Margin = new Padding(4, 3, 4, 3);
            btn_favback.Name = "btn_favback";
            btn_favback.Size = new Size(35, 29);
            btn_favback.TabIndex = 44;
            btn_favback.Text = "↩";
            btn_favback.UseVisualStyleBackColor = false;
            btn_favback.Click += btn_favback_Click;
            // 
            // tab_userprofile
            // 
            tab_userprofile.Controls.Add(btn_profileupdate);
            tab_userprofile.Controls.Add(label8);
            tab_userprofile.Controls.Add(txt_conprofilepassword);
            tab_userprofile.Controls.Add(cb_show);
            tab_userprofile.Controls.Add(label16);
            tab_userprofile.Controls.Add(label17);
            tab_userprofile.Controls.Add(label19);
            tab_userprofile.Controls.Add(txt_profilepassword);
            tab_userprofile.Controls.Add(txt_profileemail);
            tab_userprofile.Controls.Add(txt_profilename);
            tab_userprofile.ForeColor = Color.Black;
            tab_userprofile.Location = new Point(184, 4);
            tab_userprofile.Name = "tab_userprofile";
            tab_userprofile.Padding = new Padding(3);
            tab_userprofile.Size = new Size(938, 541);
            tab_userprofile.TabIndex = 3;
            tab_userprofile.Text = "Profile";
            tab_userprofile.UseVisualStyleBackColor = true;
            // 
            // btn_profileupdate
            // 
            btn_profileupdate.BackColor = Color.FromArgb(46, 26, 71);
            btn_profileupdate.FlatAppearance.BorderSize = 0;
            btn_profileupdate.FlatStyle = FlatStyle.Flat;
            btn_profileupdate.ForeColor = Color.White;
            btn_profileupdate.Location = new Point(352, 411);
            btn_profileupdate.Margin = new Padding(4, 3, 4, 3);
            btn_profileupdate.Name = "btn_profileupdate";
            btn_profileupdate.Size = new Size(191, 47);
            btn_profileupdate.TabIndex = 47;
            btn_profileupdate.Text = "UPDATE";
            btn_profileupdate.UseVisualStyleBackColor = false;
            btn_profileupdate.Click += btn_profileupdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(164, 165, 196);
            label8.Location = new Point(319, 286);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(189, 23);
            label8.TabIndex = 36;
            label8.Text = "Confirm Password:";
            // 
            // txt_conprofilepassword
            // 
            txt_conprofilepassword.BackColor = Color.FromArgb(230, 231, 233);
            txt_conprofilepassword.BorderStyle = BorderStyle.None;
            txt_conprofilepassword.Font = new Font("MS UI Gothic", 13.8F);
            txt_conprofilepassword.Location = new Point(319, 312);
            txt_conprofilepassword.Margin = new Padding(4, 3, 4, 3);
            txt_conprofilepassword.Multiline = true;
            txt_conprofilepassword.Name = "txt_conprofilepassword";
            txt_conprofilepassword.PasswordChar = '*';
            txt_conprofilepassword.Size = new Size(279, 41);
            txt_conprofilepassword.TabIndex = 35;
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.Cursor = Cursors.Hand;
            cb_show.FlatStyle = FlatStyle.Flat;
            cb_show.Location = new Point(455, 357);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(169, 27);
            cb_show.TabIndex = 34;
            cb_show.Text = "ShowPassword";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(164, 165, 196);
            label16.Location = new Point(319, 138);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(68, 23);
            label16.TabIndex = 31;
            label16.Text = "Email:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(164, 165, 196);
            label17.Location = new Point(319, 218);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(191, 23);
            label17.TabIndex = 30;
            label17.Text = "Change Password:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.FromArgb(164, 165, 196);
            label19.Location = new Point(319, 65);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(117, 23);
            label19.TabIndex = 28;
            label19.Text = "UserName:";
            // 
            // txt_profilepassword
            // 
            txt_profilepassword.BackColor = Color.FromArgb(230, 231, 233);
            txt_profilepassword.BorderStyle = BorderStyle.None;
            txt_profilepassword.Font = new Font("MS UI Gothic", 13.8F);
            txt_profilepassword.Location = new Point(319, 244);
            txt_profilepassword.Margin = new Padding(4, 3, 4, 3);
            txt_profilepassword.Multiline = true;
            txt_profilepassword.Name = "txt_profilepassword";
            txt_profilepassword.PasswordChar = '*';
            txt_profilepassword.Size = new Size(279, 41);
            txt_profilepassword.TabIndex = 26;
            // 
            // txt_profileemail
            // 
            txt_profileemail.BackColor = Color.FromArgb(230, 231, 233);
            txt_profileemail.BorderStyle = BorderStyle.None;
            txt_profileemail.Font = new Font("MS UI Gothic", 13.8F);
            txt_profileemail.Location = new Point(319, 169);
            txt_profileemail.Margin = new Padding(4, 3, 4, 3);
            txt_profileemail.Multiline = true;
            txt_profileemail.Name = "txt_profileemail";
            txt_profileemail.Size = new Size(279, 41);
            txt_profileemail.TabIndex = 25;
            // 
            // txt_profilename
            // 
            txt_profilename.BackColor = Color.FromArgb(230, 231, 233);
            txt_profilename.BorderStyle = BorderStyle.None;
            txt_profilename.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_profilename.Location = new Point(319, 91);
            txt_profilename.Margin = new Padding(4, 3, 4, 3);
            txt_profilename.Multiline = true;
            txt_profilename.Name = "txt_profilename";
            txt_profilename.Size = new Size(279, 41);
            txt_profilename.TabIndex = 24;
            // 
            // userservicesBindingSource
            // 
            userservicesBindingSource.DataSource = typeof(BusinessLogic.user_services);
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1126, 649);
            Controls.Add(tab_control);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 196);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            tab_control.ResumeLayout(false);
            tab_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Productshow).EndInit();
            tab_favorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_favshow).EndInit();
            tab_userprofile.ResumeLayout(false);
            tab_userprofile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userservicesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label7;
        private Button closeButton;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TabControl tab_control;
        private TabPage tab_products;
        private TabPage tab_favorites;
        private TabPage tab_userprofile;
        private Guna.UI2.WinForms.Guna2ComboBox cb_cat;
        private Button btn_proback;
        private Button btn_add;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Productshow;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_favshow;
        private Button btn_favdelete;
        private Button btn_favback;
        private BindingSource userservicesBindingSource;
        private Button brn_logout;
        private CheckBox cb_show;
        private Label label16;
        private Label label17;
        private Label label19;
        private TextBox txt_profilepassword;
        private TextBox txt_profileemail;
        private TextBox txt_profilename;
        private Label label8;
        private TextBox txt_conprofilepassword;
        private Button btn_profileupdate;
        private Label lb_username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Button btn_userlogout;
    }
}