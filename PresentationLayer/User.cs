using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class User : Form
    {
        product_services Product_Services;
        favorites__services Favorites_Services;
        user_services User_Services;
        int product_selectedID = -1;
        int fav_selectedID = -1;
        int User_ID = -1;
        public User(int id, string username, string email, string password)
        {
            InitializeComponent();
           
            Product_Services = new product_services();
            Favorites_Services = new favorites__services();
            User_Services= new user_services();
           
            lb_username.Text = $"Welcome,{username}";
            User_ID = id;
            ProductShow();
            FavShow();
            getuserinfo(username, email, password);


        }

        ////////////////////////////////////Products///////////////////////////////////////////////
        public void ProductShow() {
            try
            {
                DataTable dataTable = Product_Services.GetData();
                dgv_Productshow.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
        }
        string ProductName = null;
        private void dgv_Productshow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow Row = dgv_Productshow.SelectedRows[0];
                ProductName = Row.Cells["ProductName"].Value.ToString();
                product_selectedID = (int)Row.Cells["ProductId"].Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (product_selectedID == -1)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                try
                {
                    int rowsAffected = Favorites_Services.AddFavProduct(User_ID, product_selectedID);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{ProductName} Add Successfully");
                       
                        FavShow();

                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }
        private void btn_proback_Click(object sender, EventArgs e)
        {
            product_selectedID = -1;
        }
        ////////////////////////////////////////Favorite//////////////////////////////////////////////////////
        public void FavShow()
        {
            try
            {
                DataTable dataTable = Favorites_Services.GetFavData(User_ID);
                dgv_favshow.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
        }
        string Favouritesproduct = null;

        private void dgv_favshow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow Row = dgv_favshow.SelectedRows[0];
                Favouritesproduct = Row.Cells["ProductName"].Value.ToString();
                fav_selectedID = (int)Row.Cells["ProductId"].Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btn_favdelete_Click(object sender, EventArgs e)
        {

            if (fav_selectedID == -1)
            {
                MessageBox.Show("Please select an item to delete, No Item Selected");

            }
            else
            {
                try
                {
                    int rowsAffected = Favorites_Services.deleteFavProduct(User_ID, fav_selectedID);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{Favouritesproduct} deleted successfully.");

                        FavShow();


                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }

        private void btn_userlogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_favback_Click(object sender, EventArgs e)
        {
            fav_selectedID = -1;
        }
        ///////////////////////////////////User Profile///////////////////////////////////
        public void getuserinfo(string username, string email, string password)
        {

            txt_profilename.Text = username;
            txt_profileemail.Text = email;
            txt_profilepassword.Text = password;

        }
        private void cb_show_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_show_CheckedChanged_1 != null)
            {
                if (cb_show.Checked)
                {
                    txt_profilepassword.PasswordChar = '\0';
                    txt_conprofilepassword.PasswordChar = '\0';
                }
                else
                {
                    txt_profilepassword.PasswordChar = '*';
                    txt_conprofilepassword.PasswordChar = '*';

                }
            }

        }

        private void btn_profileupdate_Click(object sender, EventArgs e)
        {
            if (txt_profilename.Text == "" || txt_profileemail.Text == "" || txt_profilepassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields");

            }
            else if (txt_conprofilepassword.Text == "" || txt_profilepassword.Text != txt_conprofilepassword.Text) { MessageBox.Show("Password and Confirm Password does not match"); }
            else
            {

                try
                {
                    int rowsAffected = User_Services.updateProfile(User_ID, txt_profilename.Text, txt_profilepassword.Text, txt_profileemail.Text);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_profilename.Text} Updated Successfully! Now Log Out 👋");

                        btn_userlogout_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }
    }
}
