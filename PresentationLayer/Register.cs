using BusinessLogic;
namespace PresentationLayer
{
    public partial class Register : Form
    {
        registration_services serv;
        int Age = 0;
        public Register()
        {
            InitializeComponent();
            serv = new registration_services();
            Get_Role();
            reset();
           dtp_birthdate_ValueChanged(null, null);
        }
        private void dtp_birthdate_ValueChanged(object sender, EventArgs e)
        {
            Age = DateTime.Today.Year - dtp_birthdate.Value.Year;
        }
        private void btn_registration_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_address.Text == "" || txt_password.Text == "" || txt_email.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else if (dtp_birthdate.Value.Year > 2012)
            {
                MessageBox.Show("Only users who are 14 years of age or older can register!");
            }
            else { 

                try
                {

                    serv.add_user(txt_username.Text, txt_address.Text, txt_password.Text, txt_email.Text, Age, (registration_services.Role)cb_role.SelectedValue);
                    MessageBox.Show($"{txt_username.Text} Added Successfully As {(registration_services.Role)cb_role.SelectedValue}");
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }



            }
        }
        public void Get_Role()
        {
            cb_role.DataSource = Enum.GetValues(typeof(registration_services.Role));
        }
        public void reset()
        {
            txt_username.Text = "";
            txt_address.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            dtp_birthdate.Value = DateTime.Now;
            cb_role.SelectedIndex = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();


        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }



        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
