using System;
using Registration;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Login_Form;


namespace Registration_Form
{
    public partial class Register : Form
    {
        registration_serv serv;
        public Register()
        {
            InitializeComponent();
            serv = new registration_serv();
            Get_Role();
            reset();
        }


        private void btn_registration_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_address.Text == "" || txt_password.Text == "" || txt_email.Text == "" || nud_age.Value == 0)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                try
                {

                    serv.add_user(txt_username.Text, txt_address.Text, txt_password.Text, txt_email.Text, (int)nud_age.Value, (Role)cb_role.SelectedValue);
                    MessageBox.Show($"{txt_username.Text} Added Successfully As {(Role)cb_role.SelectedValue}");
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
            cb_role.DataSource = Enum.GetValues(typeof(Role));
        }
        public void reset()
        {
            txt_username.Text = "";
            txt_address.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            nud_age.Value = 0;
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
            new Login_Form.Login().Show();
            this.Hide();
        }
    }
}
