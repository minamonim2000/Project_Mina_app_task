﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mina_app
{
    public partial class Employee : Form
    {
        private Functions con;
        public Employee()
        {

            InitializeComponent();
            con = new Functions();
            ShowEmployess();
            GetDepartment();
        }
        private void ShowEmployess()
        {
            string Query = "Select * from Employee";
            EmpList.DataSource = con.GetData(Query);


        }

    }
}
