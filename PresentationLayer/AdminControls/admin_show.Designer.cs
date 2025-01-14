namespace PresentationLayer.AdminControls
{
    partial class admin_show
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_show = new DataGridView();
            btn_show = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_show).BeginInit();
            SuspendLayout();
            // 
            // dgv_show
            // 
            dgv_show.BackgroundColor = Color.White;
            dgv_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_show.Dock = DockStyle.Top;
            dgv_show.Location = new Point(0, 0);
            dgv_show.Name = "dgv_show";
            dgv_show.RowHeadersWidth = 51;
            dgv_show.Size = new Size(653, 353);
            dgv_show.TabIndex = 0;
            // 
            // btn_show
            // 
            btn_show.BackColor = Color.FromArgb(116, 86, 174);
            btn_show.FlatAppearance.BorderSize = 0;
            btn_show.FlatStyle = FlatStyle.Flat;
            btn_show.ForeColor = Color.White;
            btn_show.Location = new Point(211, 368);
            btn_show.Margin = new Padding(4, 3, 4, 3);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(221, 47);
            btn_show.TabIndex = 5;
            btn_show.Text = "SHOW";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.FromArgb(116, 86, 174);
            btn_back.Location = new Point(4, 378);
            btn_back.Margin = new Padding(4, 3, 4, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(42, 37);
            btn_back.TabIndex = 22;
            btn_back.Text = "↩";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // admin_show
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(btn_back);
            Controls.Add(btn_show);
            Controls.Add(dgv_show);
            Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "admin_show";
            Size = new Size(653, 440);
            ((System.ComponentModel.ISupportInitialize)dgv_show).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_show;
        private Button btn_show;
        private Button btn_back;
    }
}
