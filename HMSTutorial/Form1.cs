﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Data.SqlClient;
namespace HMSTutorial
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MJEZU PW\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PassTb.Text == "" || Role.SelectedIndex == -1)
                MessageBox.Show("Enter a valid Username, Password and Position");
            else
            {
                //if (Role.SelectedIndex == 0)
                //{
                  //  if (DocNameTb.Text == "" && PassTb.Text == "")
                  //  {
                   //     MessageBox.Show("Please enter correct Admin username and Password");
                   // }
                   // else if (DocNameTb.Text == "Admin")
                   // { }
               // }
               // else if (Role.SelectedIndex == 1)
               // {

               // }
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTbl where DocName='" + DocNameTb.Text + "' and DocPass='" + PassTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                    {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }  
               else
                {
                    MessageBox.Show("Incorrect information. Please contact your administrator.");
                }
                Con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
            //Role.SelectedIndex = 0;
        }

        private void DocNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            
       
        }
    }
}
