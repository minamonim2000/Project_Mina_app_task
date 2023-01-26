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
    public partial class Salary : Form
    {
        Functions con;
        public Salary()
        {

            InitializeComponent();

            con = new Functions();
            ShowSalaeries();
            GetEmployee();

        }
        private void ShowSalaeries()
        {
            string Query = "Select * from Salary";
            SalaryList.DataSource = con.GetData(Query);
        }
        private void GetEmployee()
        {
            string Query = "Select * from Employee";
            cbEmps.DisplayMember = con.GetData(Query).Columns["EmpName"].ToString();
            cbEmps.ValueMember = con.GetData(Query).Columns["EmpId"].ToString();
            cbEmps.DataSource = con.GetData(Query);
        }