﻿using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.AdminControls
{
    public partial class admin_show : UserControl
    {
        product_services admin_Services;
        public admin_show()
        {
            InitializeComponent();
            admin_Services = new product_services();

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dataTable = admin_Services.GetData();
            dgv_show.DataSource = dataTable;
        }
    }
}
