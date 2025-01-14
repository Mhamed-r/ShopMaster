using Azure.Identity;
using BusinessLogic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        login_services login;
        DataTable result;
        public Login()
        {
            InitializeComponent();
            login = new login_services();
            result = new DataTable();
        }
        
        public void btn_login_Click(object sender, EventArgs e)
        {
            result = login.check_user(txt_username.Text, txt_password.Text);
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password");

            }
            else if (result.Rows.Count > 0)
            {

                string finalResult = result.Rows[0]["Role"].ToString();
                int id = (int)result.Rows[0]["UserId"];
                string username = result.Rows[0]["Username"].ToString();
                string password = result.Rows[0]["Password"].ToString();
                string email = result.Rows[0]["Email"].ToString();
               


                if (finalResult.ToLower() == "admin")
                {
                    MessageBox.Show($"Login Success as {finalResult}");
                    new Admin(id,username, email,password).Show();
                    this.Hide();


                }
                else if (finalResult.ToLower() == "user")
                {
                    MessageBox.Show($"Login Success as {finalResult}");
                    new User(id, username, email, password).Show();
                    this.Hide();



                }
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
            new Register().Show();
            this.Hide();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        public void UserInfo(string Username, string Email, string Password)
        {

      
         

        }

    }
}
