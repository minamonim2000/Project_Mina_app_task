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
    public partial class Deparment : Form
    {


        Functions con;
        public Department()
        {
            InitializeComponent();
            con = new Functions();
            ShowDepartmentList();

        }

        private void ShowDepartmentList()
        {
            string Query = "Select * from Department";
            DeptList.DataSource = con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        
}
