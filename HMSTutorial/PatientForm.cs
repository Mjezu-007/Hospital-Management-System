using System;
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
using System.Reflection;
using System.IO;

namespace HMSTutorial
{
  public partial class PatientForm : Form
  {
    public PatientForm()
    {
      InitializeComponent();
    }
    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=HMSDB.MDF;Integrated Security=True;Connect Timeout=30");
    void populate()
    {
      var appPath = Assembly.GetEntryAssembly();

      Con.Open();
      string query = "select * from PatientTbl";
      SqlDataAdapter da = new SqlDataAdapter(query, Con);
      SqlCommandBuilder builder = new SqlCommandBuilder(da);
      var ds = new DataSet();
      da.Fill(ds);
      PatientGV.DataSource = ds.Tables[0];
      Con.Close();
    }
    private void button4_Click(object sender, EventArgs e)
    {
      Home h = new Home();
      h.Show();
      this.Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (PatId.Text == "" || PatName.Text == "" || PatDoc.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || MajorTb.Text == "")
        MessageBox.Show("No Empty Fill Accepted");
      else
      {
        Con.Open();
        string query = "insert into PatientTbl values(" + PatId.Text + ",'" + PatName.Text + "','" + PatDoc.Text + "','" + PatPhone.Text + "'," + PatAge.Text + ",'" + GenderCb.SelectedItem.ToString() + "','" + BloodCb.SelectedItem.ToString() + "','" + MajorTb.Text + "')";
        SqlCommand cmd = new SqlCommand(query, Con);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Patient Successfully Added");
        Con.Close();
        populate();
      }
    }

    private void PatientForm_Load(object sender, EventArgs e)
    {
      populate();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (PatId.Text == "")
        MessageBox.Show("Enter The Patient Id");
      else
      {
        Con.Open();
        string query = "delete from PatientTbl where PatId=" + PatId.Text + "";
        SqlCommand cmd = new SqlCommand(query, Con);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Patient Successfully Deleted");
        Con.Close();
        populate();
      }
    }

    private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
      PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
      PatDoc.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
      PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
      PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
      MajorTb.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Con.Open();
      string query = "update PatientTbl set PatName = '" + PatName.Text + "',PatDoc ='" + PatDoc.Text + "',PatPhone='" + PatPhone.Text + "',PatAge=" + PatAge.Text + ",PatGender='" + GenderCb.SelectedItem.ToString() + "',PatBlood='" + BloodCb.SelectedItem.ToString() + "' where PatId=" + PatId.Text + "";
      SqlCommand cmd = new SqlCommand(query, Con);
      cmd.ExecuteNonQuery();
      MessageBox.Show("Patient Successfully updated");
      Con.Close();
      populate();
    }

    private void label5_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void PatId_OnValueChanged(object sender, EventArgs e)
    {

    }

    private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void PatDoc_OnValueChanged(object sender, EventArgs e)
    {

    }

    private void PatAge_OnValueChanged(object sender, EventArgs e)
    {

    }
  }
}
