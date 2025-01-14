using BusinessLogic;
using PresentationLayer.AdminControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLogic.registration_services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer
{
    public partial class Admin : Form
    {
        product_services Product_Services;
        categories_services Categories_Services;
        user_services User_Services;
        getcategory _getcategory;
        int product_selectedID = -1;
        int category_selectedID = -1;
        int User_selectedID = -1;
        int User_profileID = -1;



        public Admin(int id, string username, string email, string password)
        {
            InitializeComponent();
            Product_Services = new product_services();
            Categories_Services = new categories_services();
            _getcategory = new getcategory();
            User_Services = new user_services();
            getcat();
            btn_add.Visible = true;
            btn_add.Location = new Point(btn_add.Location.X - 120, btn_add.Location.Y);
            btn_show.Visible = true;
            btn_show.Location = new Point(btn_show.Location.X + 40, btn_show.Location.Y);
            btn_delete.Visible = false;
            btn_delete.Location = new Point(btn_delete.Location.X - 170, btn_delete.Location.Y);
            btn_update.Visible = false;
            btn_update.Location = new Point(btn_update.Location.X - 80, btn_update.Location.Y);
            /////////////////////////
            btn_catadd.Visible = true;
            btn_catadd.Location = new Point(btn_catadd.Location.X - 120, btn_catadd.Location.Y);
            btn_catshow.Visible = true;
            btn_catshow.Location = new Point(btn_catshow.Location.X + 40, btn_catshow.Location.Y);
            btn_catdelete.Visible = false;
            btn_catdelete.Location = new Point(btn_catdelete.Location.X - 170, btn_catdelete.Location.Y);
            btn_catupdate.Visible = false;
            btn_catupdate.Location = new Point(btn_catupdate.Location.X - 80, btn_catupdate.Location.Y);
            //////////////////////////
            Get_Role();
            btn_useradd.Visible = true;
            btn_useradd.Location = new Point(btn_useradd.Location.X - 120, btn_useradd.Location.Y);
            btn_usershow.Visible = true;
            btn_usershow.Location = new Point(btn_usershow.Location.X + 40, btn_usershow.Location.Y);
            btn_userdelete.Visible = false;
            btn_userdelete.Location = new Point(btn_userdelete.Location.X - 170, btn_userdelete.Location.Y);
            btn_userupdate.Visible = false;
            btn_userupdate.Location = new Point(btn_userupdate.Location.X - 80, btn_userupdate.Location.Y);
            lb_username.Text = $"Welcome,{username}";
            ////////////////////////////////////////////////////
            getadmininfo(username, email, password);
            User_profileID = id;



        }

        private void brn_logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        //////////////////////////// Products//////////////////////////////////////////////
        public void getcat()
        {
            DataTable dt_cat = new DataTable();
            dt_cat.Clear();
            dt_cat = _getcategory.GetCategories();
            cb_cat.DataSource = dt_cat;
            cb_cat.DisplayMember = "Cat_name";
            cb_cat.ValueMember = "Cat_id";
            cb_cat.SelectedValue = 0;


        }
        private void cb_cat_Click(object sender, EventArgs e)
        {
            getcat();
        }
        public void LoadProducts()
        {
            DataTable dataTable = Product_Services.GetData();
            dgv_show.DataSource = dataTable;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || nud_price.Value == 0 || cb_cat.SelectedValue == null)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    int rowsAffected = Product_Services.AddProduct(txt_name.Text, nud_price.Value, (int)cb_cat.SelectedValue);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_name.Text} Add Successfully");
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }

        private void btn_show_Click_2(object sender, EventArgs e)
        {
            LoadProducts();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || nud_price.Value == 0 || cb_cat.SelectedValue == null)
            {
                MessageBox.Show("Please fill all the fields");

            }
            else
            {
                try
                {
                    int rowsAffected = Product_Services.updateProduct(product_selectedID, txt_name.Text, nud_price.Value, (int)cb_cat.SelectedValue);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_name.Text} Updated Successfully");
                        LoadProducts();

                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }

            }

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (product_selectedID == -1)
            {
                MessageBox.Show("Please select an item to delete, No Item Selected");

            }
            else
            {
                try
                {
                    int rowsAffected = Product_Services.deleteProduct(product_selectedID);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_name.Text} deleted successfully.");
                        LoadProducts();

                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }


        private void dgv_show_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResetCategory();
                Reset();
                DataGridViewRow Row = dgv_show.SelectedRows[0];
                txt_name.Text = Row.Cells["ProductName"].Value.ToString();
                nud_price.Value = (decimal)Row.Cells["Price"].Value;
                string category = Row.Cells["CategoryName"].Value.ToString();
                cb_cat.SelectedIndex = cb_cat.FindStringExact(category);
                product_selectedID = (int)Row.Cells["ProductId"].Value;
                btn_add.Visible = false;
                btn_delete.Visible = true;
                btn_update.Visible = true;
                btn_show.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        public void ResetProducts()
        {
            product_selectedID = -1;
            txt_name.Text = "";
            nud_price.Value = 0;
            cb_cat.SelectedValue = 0;
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            btn_show.Visible = true;
        }
        private void btn_proback_Click(object sender, EventArgs e)
        {
            ResetProducts();
        }
        //////////////////////////// Category//////////////////////////////////////////////

        public void LoadCategory()
        {
            dgv_showcategory.DataSource = Categories_Services.GetCategories();
        }

        private void btn_catshow_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void dgv_showcategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResetProducts();
                Reset();

                DataGridViewRow Row = dgv_showcategory.SelectedRows[0];
                txt_catname.Text = Row.Cells["CategoryName"].Value.ToString();
                category_selectedID = (int)Row.Cells["CategoryID"].Value;
                txt_catid.Text = Row.Cells["CategoryID"].Value.ToString();
                btn_catadd.Visible = false;
                btn_catdelete.Visible = true;
                btn_catupdate.Visible = true;
                btn_catshow.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btn_catupdate_Click(object sender, EventArgs e)
        {
            if (txt_catname.Text == "" || txt_catid.Text == null || category_selectedID == -1)
            {
                MessageBox.Show("No Item Selected");

            }
            else
            {
                try
                {
                    int rowsAffected = Categories_Services.updatecategory(category_selectedID, txt_catname.Text);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_catname.Text} Updated Successfully");
                        LoadCategory();
                        LoadProducts();


                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }

        private void btn_catadd_Click(object sender, EventArgs e)
        {
            if (txt_catname.Text == "")
            {
                MessageBox.Show("Please Enter category");

            }
            else
            {
                try
                {
                    int rowsAffected = Categories_Services.Addcategory(txt_catname.Text);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_catname.Text} Added Successfully");
                        LoadCategory();
                        LoadProducts();


                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }

        }

        private void btn_catdelete_Click(object sender, EventArgs e)
        {
            if (txt_catname.Text == "" || txt_catid.Text == null || category_selectedID == -1)
            {
                MessageBox.Show("No Item Selected");

            }
            else
            {
                try
                {
                    int rowsAffected = Categories_Services.deletecategory(category_selectedID);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_catname.Text} Deleted Successfully");
                        LoadCategory();
                        LoadProducts();

                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }
        public void ResetCategory()
        {
            category_selectedID = -1;
            txt_catid.Text = "0";
            txt_catname.Text = "";
            btn_catadd.Visible = true;
            btn_catdelete.Visible = false;
            btn_catupdate.Visible = false;
            btn_catshow.Visible = true;
        }
        private void btn_catback_Click(object sender, EventArgs e)
        {

            ResetCategory();

        }
        ///////////////////////////////////////////Users////////////////////////////////////////////
        public void LoadUsers()
        {

            dgv_usershow.DataSource = User_Services.GetUsers();

        }
        private void btn_usershow_Click(object sender, EventArgs e)
        {
            LoadUsers();

        }
        public void Get_Role()
        {
            cb_userrole.DataSource = Enum.GetValues(typeof(registration_services.Role));
        }

        private void btn_useradd_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "" || txt_useraddress.Text == "" || txt_userpassword.Text == "" || txt_useremail.Text == "" || nud_userage.Value < 10)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                try
                {

                    User_Services.Adduser(txt_username.Text, txt_useraddress.Text, txt_userpassword.Text, txt_useremail.Text, (int)nud_userage.Value, (registration_services.Role)cb_userrole.SelectedValue);
                    MessageBox.Show($"{txt_username.Text} Added Successfully As {(registration_services.Role)cb_userrole.SelectedValue}");
                    Reset();
                    LoadUsers();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }


        public void Reset()
        {

            txt_username.Text = "";
            txt_useraddress.Text = "";
            txt_userpassword.Text = "";
            txt_useremail.Text = "";
            nud_userage.Value = 0;
        }

        private void btn_userupdate_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_useraddress.Text == "" || txt_userpassword.Text == "" || txt_useremail.Text == "" || nud_userage.Value < 18 || User_selectedID == -1)
            {
                MessageBox.Show("No Item Selected");

            }
            else
            {
                try
                {
                    int rowsAffected = User_Services.updateUser(User_selectedID, txt_username.Text, txt_useraddress.Text, txt_userpassword.Text, txt_useremail.Text, (int)nud_userage.Value, (registration_services.Role)cb_userrole.SelectedValue);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_catname.Text} Updated Successfully");
                        LoadUsers();

                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }
        }
        private void btn_userdelete_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "" || txt_useraddress.Text == "" || txt_userpassword.Text == "" || txt_useremail.Text == "" || nud_userage.Value == 0 || User_selectedID == -1)
            {
                MessageBox.Show("No Item Selected");

            }
            else
            {
                try
                {
                    int rowsAffected = User_Services.deleteUser(User_selectedID);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_catname.Text} Deleted Successfully");
                        LoadUsers();

                    }
                    else
                    {
                        MessageBox.Show("something wrong");
                    }
                }
                catch (Exception ex) { MessageBox.Show("An error occurred: " + ex.Message); }
            }

        }

        private void dgv_usershow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResetProducts();
                ResetCategory();
                DataGridViewRow Row = dgv_usershow.SelectedRows[0];
                User_selectedID = (int)Row.Cells["UserId"].Value;
                txt_username.Text = Row.Cells["Username"].Value.ToString();
                txt_useraddress.Text = Row.Cells["Address"].Value.ToString();
                txt_userpassword.Text = Row.Cells["Password"].Value.ToString();
                txt_useremail.Text = Row.Cells["Email"].Value.ToString();
                nud_userage.Value = (int)Row.Cells["Age"].Value;
                cb_userrole.SelectedIndex = cb_userrole.FindStringExact(Row.Cells["Role"].Value.ToString());
                btn_useradd.Visible = false;
                btn_userdelete.Visible = true;
                btn_userupdate.Visible = true;
                btn_usershow.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_userback_Click(object sender, EventArgs e)
        {
            btn_useradd.Visible = true;
            btn_userdelete.Visible = false;
            btn_userupdate.Visible = false;
            btn_usershow.Visible = true;
            txt_username.Text = "";
            txt_useraddress.Text = "";
            txt_userpassword.Text = "";
            txt_useremail.Text = "";
            nud_userage.Value = 0;
            User_selectedID = -1;

        }

        ///////////////////////////////////////////Profile////////////////////////////////////////////
        public void getadmininfo(string username, string email, string password)
        {
           
            txt_profilename.Text = username;
            txt_profileemail.Text = email;
            txt_profilepassword.Text = password;

        }

      

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show_CheckedChanged != null)
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
            ResetCategory();
            ResetProducts();
            Reset();
            if (txt_profilename.Text == "" || txt_profileemail.Text == "" || txt_profilepassword.Text == "" )
            {
                MessageBox.Show("Please fill all the fields");

            }
            else if (txt_conprofilepassword.Text == ""||txt_profilepassword.Text != txt_conprofilepassword.Text) { MessageBox.Show("Password and Confirm Password does not match"); }
            else
            {
              
                try
                {
                    int rowsAffected = User_Services.updateProfile(User_profileID, txt_profilename.Text,txt_profilepassword.Text,txt_profileemail.Text);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{txt_profilename.Text} Updated Successfully! Now Log Out 👋");

                        brn_logout_Click(null, null);
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

 

