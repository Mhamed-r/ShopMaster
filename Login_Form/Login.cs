using Login;


namespace Login_Form
{
    public partial class Login : Form
    {
        login_serv login;
        public Login()
        {
            InitializeComponent();
            login = new login_serv();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login.check_user(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show_CheckedChanged != null)
            {
                if (cb_show.Checked)
                {
                    txt_password.PasswordChar = '\0';
                }
                else
                {
                    txt_password.PasswordChar = '*';
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //Registration_Form  = new Registration_Form();
            this.Hide();
        }
    }
}
